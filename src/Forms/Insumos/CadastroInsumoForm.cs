using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Insumos;

public partial class CadastroInsumoForm : Form
{
    private readonly InsumoController _insumoController;

    public CadastroInsumoForm(InsumoController insumoController)
    {
        InitializeComponent();
        _insumoController = insumoController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void CadastroInsumoForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        dateDataCompra.Value = DateTime.Now;
        dateDataValidade.Value = DateTime.Now;
    }

    #region Métodos de verificação
    
    private void dateDataValidade_ValueChanged(object sender, EventArgs e)
    {
        if (dateDataValidade.Value < DateTime.Now.AddDays(7))
        {
            MessageBox.Show("A data de validade deve ser no mínimo daqui a 7 dias.",
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dateDataValidade.Value = DateTime.Now.AddDays(7);
        }
    }

    private async void txtIdFornecedor_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (Regex.IsMatch(txtIdFornecedor.Text, @"^\d+$"))
            {
                var fornecedor = await _insumoController.SearchFornecedor(int.Parse(txtIdFornecedor.Text));
                txtNomeFornecedor.Text = fornecedor.Nome;
            }

            else if (!Regex.IsMatch(txtIdFornecedor.Text, @"^\d+$") && !txtIdFornecedor.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Insira apenas números inteiros no campo 'Código do Fornecedor'", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao recuperar o fornecedor.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Erro: " + exception.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #endregion

    #region Métodos de Click

    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            var insumo = new Insumo
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Quantidade_Estoque = int.Parse(txtQuantidadeEstoque.Text),
                Data_Compra = dateDataCompra.Value,
                Data_Validade = dateDataValidade.Value,
                Id_Fornecedor = int.Parse(txtIdFornecedor.Text),
                Nome_Fornecedor = txtNomeFornecedor.Text,
            };

            if (await _insumoController.Create(insumo))
            {
                MessageBox.Show("Insumo cadastrado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            else
            {
                var insumoValidator = new InsumoValidator();
                var insumoValidationResult = await insumoValidator.ValidateAsync(insumo);

                MessageBox.Show("Cadastro de Insumo inválido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                foreach (var erro in insumoValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente mais tarde.");
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}
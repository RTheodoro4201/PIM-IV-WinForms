using System;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Produtos;

public partial class CadastroProdutoForm : Form
{
    private readonly ProdutoController _produtoController;

    public CadastroProdutoForm(ProdutoController produtoController)
    {
        InitializeComponent();
        _produtoController = produtoController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void CadastroProdutoForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
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
    
    private void txtPrecoUnitario_Leave(object sender, EventArgs e)
    {
        try
        {
            if (decimal.TryParse(txtPrecoUnitario.Text, out decimal precoUnitario) || txtPrecoUnitario.Text.Contains("R$"))
            {
                txtPrecoUnitario.Text = "";
                txtPrecoUnitario.Text = precoUnitario.ToString("C");
            }

            else if (!decimal.TryParse(txtPrecoUnitario.Text, out precoUnitario) && !txtPrecoUnitario.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Insira apenas números decimais no campo 'Preço Unitário'.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao exibir o valor do campo 'Preço Unitário'.", "Erro",
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
            var produto = new Produto
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Quantidade_Estoque = int.Parse(txtQuantidadeEstoque.Text),
                Preco_Unitario = decimal.Parse(txtPrecoUnitario.Text),
                Data_Validade = dateDataValidade.Value
            };

            if (await _produtoController.Create(produto))
            {
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            else
            {
                var produtoValidator = new ProdutoValidator();
                var produtoValidationResult = await produtoValidator.ValidateAsync(produto);

                MessageBox.Show("Cadastro de Produto inválido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                foreach (var erro in produtoValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);
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
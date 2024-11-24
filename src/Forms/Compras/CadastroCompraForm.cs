using System;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Compras;

public partial class CadastroCompraForm : Form
{
    private readonly CompraController _compraController;

    public CadastroCompraForm(CompraController compraController)
    {
        InitializeComponent();
        _compraController = compraController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void CadastroCompraForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        dateDataCompra.Value = DateTime.Now;
    }

    #region Métodos de verificação

    private async void txtIdFornecedor_Leave(object sender, EventArgs e)
    {
        try
        {
            if (int.TryParse(txtIdFornecedor.Text, out int idFornecedor))
            {
                var fornecedor = await _compraController.SearchFornecedor(idFornecedor);
                txtNomeFornecedor.Text = fornecedor.Nome;
            }

            else if (!int.TryParse(txtIdFornecedor.Text, out idFornecedor) && !txtIdFornecedor.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Insira apenas números inteiros no campo 'Código do Fornecedor'", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private async void txtIdInsumo_Leave(object sender, EventArgs e)
    {
        try
        {
            if (int.TryParse(txtIdInsumo.Text, out int idInsumo))
            {
                var insumo = await _compraController.SearchInsumo(idInsumo);
                txtNomeInsumo.Text = insumo.Nome;
            }

            else if (!int.TryParse(txtIdFornecedor.Text, out idInsumo) && !txtIdInsumo.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Insira apenas números inteiros no campo 'Código do Insumo'", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao recuperar o insumo.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Erro: " + exception.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void txtValorUnitario_Leave(object sender, EventArgs e)
    {
        try
        {
            if (decimal.TryParse(txtValorUnitario.Text, out decimal valorUnitario) &&
                int.TryParse(txtQuantidadeComprada.Text, out int quantidadeComprada) &&
                quantidadeComprada >= 1)
            {
                var valorTotal = valorUnitario * quantidadeComprada;
                txtValorUnitario.Text = valorUnitario.ToString("C");
                txtValorTotal.Text = valorTotal.ToString("C");
            }

            else if (txtQuantidadeComprada.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Preencha o campo 'Quantidade Comprada' antes de inserir o valor unitário.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if(!decimal.TryParse(txtValorUnitario.Text, out valorUnitario) && !txtValorUnitario.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Insira apenas números decimais no campo 'Valor Unitário'.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar calcular o valor total da compra.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            MessageBox.Show("Erro: " + exception.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dateDataCompra_Leave(object sender, EventArgs e)
    {
        if (dateDataCompra.Value > DateTime.Now)
        {
            MessageBox.Show("A data de compra não pode ser futura.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            dateDataCompra.Value = DateTime.Now;
        }
    }

    #endregion

    #region Métodos de Click

    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            var compra = new Compra
            {
                Id_Fornecedor = int.Parse(txtIdFornecedor.Text),
                Nome_Fornecedor = txtNomeFornecedor.Text,
                Data_Compra = dateDataCompra.Value,
                Id_Insumo = int.Parse(txtIdInsumo.Text),
                Nome_Insumo = txtNomeInsumo.Text,
                Quantidade_Comprada = int.Parse(txtQuantidadeComprada.Text),
                Valor_Unitario = decimal.Parse(txtValorUnitario.Text.Trim('R', '$')),
                Valor_Total = decimal.Parse(txtValorTotal.Text.Trim('R', '$'))
            };

            if (await _compraController.Create(compra))
            {
                MessageBox.Show("Compra cadastrada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            else
            {
                var compraValidator = new CompraValidator();
                var compraValidationResult = await compraValidator.ValidateAsync(compra);

                MessageBox.Show("Cadastro de Compra inválido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                foreach (var erro in compraValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);
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
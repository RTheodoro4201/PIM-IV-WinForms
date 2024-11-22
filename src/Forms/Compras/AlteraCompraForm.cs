using System;
using System.Globalization;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.IdentityModel.Tokens;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Compras;

public partial class AlteraCompraForm : Form
{
    private readonly CompraController _compraController;
    private readonly int _idCompra;
    private Compra _compra;

    public AlteraCompraForm(CompraController compraController, int idCompra)
    {
        InitializeComponent();
        _compraController = compraController;
        _idCompra = idCompra;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void AlteraCompraForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var compra = await _compraController.SearchCompra(_idCompra);
        if (compra != null)
        {
            txtId.Text = _idCompra.ToString();
            _compra = compra;

            PopulaCampos(compra);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados desta compra! Tente novamente mais tarde.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }

    private void PopulaCampos(Compra compra)
    {
        txtIdInsumo.Text = compra.Id_Insumo.ToString();
        txtNomeInsumo.Text = compra.Nome_Insumo;
        txtQuantidadeComprada.Text = compra.Quantidade_Comprada.ToString();
        txtValorUnitario.Text = compra.Valor_Unitario.ToString("C");
        txtIdFornecedor.Text = compra.Id_Fornecedor.ToString();
        txtValorTotal.Text = compra.Valor_Total.ToString("C");
        txtNomeFornecedor.Text = compra.Nome_Fornecedor;
        dateDataCompra.Value = compra.Data_Compra;
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
            MessageBox.Show("Houve um erro ao recuperar o fornecedor.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Erro: " + exception.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void txtQuantidadeComprada_Leave(object sender, EventArgs e)
    {
        if (!int.TryParse(txtQuantidadeComprada.Text, out var quantidadeComprada) && !txtQuantidadeComprada.Text.IsNullOrEmpty())
        {
            MessageBox.Show("Insira apenas números inteiros no campo 'Quantidade Comprada'.", "Atenção",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void txtValorUnitario_Enter(object sender, EventArgs e)
    {
        if (!txtValorUnitario.Text.IsNullOrEmpty())
        {
            txtValorUnitario.Text = txtValorUnitario.Text.Trim('R', '$');
        }
    }
    private void dateDataCompra_Leave(object sender, EventArgs e)
    {
        if (dateDataCompra.Value > DateTime.Now)
        {
            MessageBox.Show("A data de compra não pode ser futura.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            dateDataCompra.Value = _compra.Data_Compra;
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
                Id_Compra = _idCompra,
                Id_Fornecedor = int.Parse(txtIdFornecedor.Text),
                Nome_Fornecedor = txtNomeFornecedor.Text,
                Data_Compra = dateDataCompra.Value,
                Id_Insumo = int.Parse(txtIdInsumo.Text),
                Nome_Insumo = txtNomeInsumo.Text,
                Quantidade_Comprada = int.Parse(txtQuantidadeComprada.Text),
                Valor_Unitario = decimal.Parse(txtValorUnitario.Text.Trim('R', '$')),
                Valor_Total = decimal.Parse(txtValorTotal.Text.Trim('R', '$'))
            };

            if (await _compraController.Edit(compra))
            {
                MessageBox.Show("Compra alterada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            else
            {
                var compraValidator = new CompraValidator();
                var compraValidationResult = await compraValidator.ValidateAsync(compra);

                MessageBox.Show("Alteração de Compra inválida!", "Erro",
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
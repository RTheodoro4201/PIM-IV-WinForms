using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Compras;

public partial class ExcluirCompraForm : Form
{
    private readonly CompraController _compraController;
    private readonly int _idCompra;
    private Compra _compra;

    public ExcluirCompraForm(CompraController compraController, int idCompra)
    {
        InitializeComponent();
        _compraController = compraController;
        _idCompra = idCompra;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ExcluirCompraForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var compra = await _compraController.SearchCompra(_idCompra);
        if (compra != null)
        {
            _compra = compra;
            txtId.Text = _idCompra.ToString();

            PopulaCampos(_compra);
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

    #region Métodos de Click
    
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            var resultado =
                MessageBox.Show($"Deseja excluir a Compra nº{_idCompra}? \nEsta ação não pode ser desfeita.",
                    "Excluir Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                await _compraController.Delete(_idCompra);
                MessageBox.Show("Compra excluído com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar excluir o Compra!");
            MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }
}
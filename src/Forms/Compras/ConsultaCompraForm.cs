using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Compras;

public partial class ConsultaCompraForm : Form
{
    private readonly CompraController _compraController;
    private readonly int _idCompra;

    public ConsultaCompraForm(CompraController compraController, int idCompra)
    {
        InitializeComponent();
        _compraController = compraController;
        _idCompra = idCompra;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ConsultaCompraForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var compra = await _compraController.SearchCompra(_idCompra);
        if (compra != null)
        {
            txtId.Text = _idCompra.ToString();

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

    #region Métodos de Click
    
    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

}
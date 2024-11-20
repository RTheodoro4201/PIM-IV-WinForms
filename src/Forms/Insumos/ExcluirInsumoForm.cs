using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Insumos;

public partial class ExcluirInsumoForm : Form
{
    private readonly InsumoController _insumoController;
    private readonly int _idInsumo;

    public ExcluirInsumoForm(InsumoController insumoController, int idInsumo)
    {
        InitializeComponent();
        _insumoController = insumoController;
        _idInsumo = idInsumo;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ExcluirInsumoForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var insumo = await _insumoController.SearchInsumo(_idInsumo);
        if (insumo != null)
        {
            txtId.Text = _idInsumo.ToString();

            PopulaCampos(insumo);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados desta insumo! Tente novamente mais tarde.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }

    private void PopulaCampos(Insumo insumo)
    {
        txtNome.Text = insumo.Nome;
        txtDescricao.Text = insumo.Descricao;
        txtQuantidadeEstoque.Text = insumo.Quantidade_Estoque.ToString();
        dateDataCompra.Value = insumo.Data_Compra;
        dateDataValidade.Value = insumo.Data_Validade;
        txtIdFornecedor.Text = insumo.Id_Fornecedor.ToString();
        txtNomeFornecedor.Text = insumo.Nome_Fornecedor;
    }

    #region Métodos de Click

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}
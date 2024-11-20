using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Produtos;

public partial class ConsultaProdutoForm : Form
{
    private readonly ProdutoController _produtoController;
    private readonly int _idProduto;

    public ConsultaProdutoForm(ProdutoController produtoController, int idProduto)
    {
        InitializeComponent();
        _produtoController = produtoController;
        _idProduto = idProduto;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ConsultaProdutoForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var produto = await _produtoController.SearchProduto(_idProduto);
        if (produto != null)
        {
            txtId.Text = _idProduto.ToString();
            PopulaCampos(produto);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste produto! Tente novamente mais tarde.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }

    private void PopulaCampos(Produto produto)
    {
        txtNome.Text = produto.Nome;
        txtDescricao.Text = produto.Descricao;
        txtQuantidadeEstoque.Text = produto.Quantidade_Estoque.ToString();
        txtPrecoUnitario.Text = produto.Preco_Unitario.ToString(CultureInfo.CurrentCulture);
        dateDataValidade.Value = produto.Data_Validade;
    }

    #region Métodos de Click

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}
using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Produtos;

public partial class ExcluirProdutoForm : Form
{
    private readonly ProdutoController _produtoController;
    private readonly int _idProduto;
    private Produto _produto;

    public ExcluirProdutoForm(ProdutoController produtoController, int idProduto)
    {
        InitializeComponent();
        _produtoController = produtoController;
        _idProduto = idProduto;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ExcluirProdutoForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var produto = await _produtoController.SearchProduto(_idProduto);
        if (produto != null)
        {
            txtId.Text = _idProduto.ToString();
            _produto = produto;
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
        txtPrecoUnitario.Text = produto.Preco_Unitario.ToString("C");
        dateDataValidade.Value = produto.Data_Validade;
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
                MessageBox.Show($"Deseja excluir a produto nº{_idProduto} '{_produto.Nome}'? \nEsta ação não pode ser desfeita.",
                    "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                await _produtoController.Delete(_idProduto);
                MessageBox.Show("Produto excluído com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar excluir o produto!");
            MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }
}
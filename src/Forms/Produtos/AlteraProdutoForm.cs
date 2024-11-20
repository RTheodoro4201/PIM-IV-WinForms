using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Produtos;

public partial class AlteraProdutoForm : Form
{
    private readonly ProdutoController _produtoController;
    private readonly int _idProduto;

    public AlteraProdutoForm(ProdutoController produtoController, int idProduto)
    {
        InitializeComponent();
        _produtoController = produtoController;
        _idProduto = idProduto;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void AlteraProdutoForm_Load(object sender, EventArgs e)
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
            MessageBox.Show("Não foi possível carregar os dados desta produto! Tente novamente mais tarde.",
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

    #endregion

    #region Métodos de Click

    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            var produto = new Produto
            {
                Id_Produto = _idProduto,
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Quantidade_Estoque = int.Parse(txtQuantidadeEstoque.Text),
                Preco_Unitario = decimal.Parse(txtPrecoUnitario.Text),
                Data_Validade = dateDataValidade.Value
            };

            if (await _produtoController.Edit(produto))
            {
                MessageBox.Show("Produto alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            else
            {
                var produtoValidator = new ProdutoValidator();
                var produtoValidationResult = await produtoValidator.ValidateAsync(produto);

                MessageBox.Show("Alteração de Produto inválida!", "Erro",
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
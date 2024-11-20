using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms.Produtos;

public partial class ProdutoForm : Form
{
    private readonly ProdutoController _produtoController;

    public ProdutoForm(ProdutoController produtoController)
    {
        InitializeComponent();
        _produtoController = produtoController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ProdutoForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);

        await CarregarGrid();
    }

    private async Task CarregarGrid()
    {
        try
        {
            var produtos = await _produtoController.Index();

            if (produtos.Any())
            {
                dataGridProdutos.DataSource = produtos;
                dataGridProdutos.AutoGenerateColumns = true;
                dataGridProdutos.Columns[0].HeaderText = "Código";
                dataGridProdutos.Columns[2].HeaderText = "Descrição";
                dataGridProdutos.Columns[3].HeaderText = "Quantidade em Estoque";
                dataGridProdutos.Columns[4].HeaderText = "Preço Unitário";
                dataGridProdutos.Columns[5].HeaderText = "Data de Validade";
                dataGridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro no servidor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        catch (Exception)
        {
            // Exibir uma mensagem de erro genérica para o usuário
            MessageBox.Show(
                "Ocorreu um erro ao carregar os dados dos produtos. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #region Métodos de verificação

    private bool VerificarSelecao()
    {
        if (dataGridProdutos.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione um produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }

    #endregion

    #region Métodos de Click

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroProdutoForm = new CadastroProdutoForm(_produtoController);
        cadastroProdutoForm.ShowDialog();

        await CarregarGrid();
    }

    private async void btnAlterar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var produtoId = Convert.ToInt32(dataGridProdutos.SelectedRows[0].Cells["id_produto"].Value);

            var alteraProdutoForm = new AlteraProdutoForm(_produtoController, produtoId);
            alteraProdutoForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var produtoId = Convert.ToInt32(dataGridProdutos.SelectedRows[0].Cells["id_produto"].Value);
            var consultaProdutoForm = new ConsultaProdutoForm(_produtoController, produtoId);
            consultaProdutoForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var produtoId = Convert.ToInt32(dataGridProdutos.SelectedRows[0].Cells["id_produto"].Value);
            var excluirProdutoForm = new ExcluirProdutoForm(_produtoController, produtoId);
            excluirProdutoForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

}
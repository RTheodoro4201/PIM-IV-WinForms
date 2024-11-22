using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms.Compras;

public partial class CompraForm : Form
{
    private readonly CompraController _compraController;

    public CompraForm(CompraController compraController)
    {
        InitializeComponent();
        _compraController = compraController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void CompraForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);

        await CarregarGrid();
    }

    private async Task CarregarGrid()
    {
        try
        {
            var compras = await _compraController.Index();

            if (compras.Any())
            {
                dataGridCompras.DataSource = compras;
                dataGridCompras.AutoGenerateColumns = true;
                dataGridCompras.Columns[0].HeaderText = "Código";
                dataGridCompras.Columns[1].HeaderText = "Código do Fornecedor";
                dataGridCompras.Columns[2].HeaderText = "Nome Fantasia/Razão Social do Fornecedor";
                dataGridCompras.Columns[3].HeaderText = "Data de Compra";
                dataGridCompras.Columns[4].HeaderText = "Código do Insumo";
                dataGridCompras.Columns[5].HeaderText = "Nome do Insumo";
                dataGridCompras.Columns[6].HeaderText = "Quantidade Comprada";
                dataGridCompras.Columns[7].HeaderText = "Valor Unitário";
                dataGridCompras.Columns[7].DefaultCellStyle.Format = "C";
                dataGridCompras.Columns[8].HeaderText = "Valor Total";
                dataGridCompras.Columns[8].DefaultCellStyle.Format = "C";
                dataGridCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro no servidor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        catch (Exception)
        {
            MessageBox.Show("Ocorreu um erro ao carregar os dados das compras. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #region Métodos de verificação

    private bool VerificarSelecao()
    {
        if (dataGridCompras.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione uma compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }

    #endregion

    #region Métodos de Click

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroCompraForm = new CadastroCompraForm(_compraController);
        cadastroCompraForm.ShowDialog();

        await CarregarGrid();
    }

    private async void btnAlterar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var compraId = Convert.ToInt32(dataGridCompras.SelectedRows[0].Cells["id_compra"].Value);

            var alteraCompraForm = new AlteraCompraForm(_compraController, compraId);
            alteraCompraForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var compraId = Convert.ToInt32(dataGridCompras.SelectedRows[0].Cells["id_compra"].Value);
            var consultaCompraForm = new ConsultaCompraForm(_compraController, compraId);
            consultaCompraForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var compraId = Convert.ToInt32(dataGridCompras.SelectedRows[0].Cells["id_compra"].Value);
            var excluirCompraForm = new ExcluirCompraForm(_compraController, compraId);
            excluirCompraForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

}
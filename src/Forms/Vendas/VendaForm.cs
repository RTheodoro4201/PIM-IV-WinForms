using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms.Vendas;

public partial class VendaForm : Form
{
    private readonly VendaController _vendaController;

    public VendaForm(VendaController vendaController)
    {
        InitializeComponent();
        _vendaController = vendaController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void VendaForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);

        await CarregarGrid();
    }

    private async Task CarregarGrid()
    {
        try
        {
            var vendas = await _vendaController.Index();

            if (vendas.Any())
            {
                dataGridVendas.DataSource = vendas;
                dataGridVendas.AutoGenerateColumns = true;
                dataGridVendas.Columns[0].HeaderText = "Código";
                dataGridVendas.Columns[1].HeaderText = "Código do Cliente";
                dataGridVendas.Columns[2].HeaderText = "Nome do Cliente";
                dataGridVendas.Columns[3].HeaderText = "Código do Produto";
                dataGridVendas.Columns[4].HeaderText = "Nome do Produto";
                dataGridVendas.Columns[5].HeaderText = "Descrição do Produto";
                dataGridVendas.Columns[6].HeaderText = "Data de Venda";
                dataGridVendas.Columns[7].HeaderText = "Valor Unitário";
                dataGridVendas.Columns[7].DefaultCellStyle.Format = "C";
                dataGridVendas.Columns[8].HeaderText = "Quantidade Vendida";
                dataGridVendas.Columns[9].HeaderText = "Valor Total";
                dataGridVendas.Columns[9].DefaultCellStyle.Format = "C";
                dataGridVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro no servidor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        catch (Exception)
        {
            MessageBox.Show("Ocorreu um erro ao carregar os dados das vendas. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #region Métodos de verificação

    private bool VerificarSelecao()
    {
        if (dataGridVendas.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione uma venda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }

    #endregion

    #region Métodos de Click

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroVendaForm = new CadastroVendaForm(_vendaController);
        cadastroVendaForm.ShowDialog();

        await CarregarGrid();
    }

    private async void btnAlterar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var vendaId = Convert.ToInt32(dataGridVendas.SelectedRows[0].Cells["id_venda"].Value);

            var alteraVendaForm = new AlteraVendaForm(_vendaController, vendaId);
            alteraVendaForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var vendaId = Convert.ToInt32(dataGridVendas.SelectedRows[0].Cells["id_venda"].Value);
            var consultaVendaForm = new ConsultaVendaForm(_vendaController, vendaId);
            consultaVendaForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var vendaId = Convert.ToInt32(dataGridVendas.SelectedRows[0].Cells["id_venda"].Value);
            var excluirVendaForm = new ExcluirVendaForm(_vendaController, vendaId);
            excluirVendaForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

}
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms.Insumos;

public partial class InsumoForm : Form
{
    private readonly InsumoController _insumoController;

    public InsumoForm(InsumoController insumoController)
    {
        InitializeComponent();
        _insumoController = insumoController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void InsumoForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);

        await CarregarGrid();
    }

    private async Task CarregarGrid()
    {
        try
        {
            var insumos = await _insumoController.Index();

            if (insumos.Any())
            {
                dataGridInsumos.DataSource = insumos;
                dataGridInsumos.AutoGenerateColumns = true;
                dataGridInsumos.Columns[0].HeaderText = "Código";
                dataGridInsumos.Columns[2].HeaderText = "Descrição";
                dataGridInsumos.Columns[3].HeaderText = "Quantidade em Estoque";
                dataGridInsumos.Columns[4].HeaderText = "Data de Compra";
                dataGridInsumos.Columns[5].HeaderText = "Data de Validade";
                dataGridInsumos.Columns[6].HeaderText = "Código do Fornecedor";
                dataGridInsumos.Columns[7].HeaderText = "Nome do Fornecedor";
                dataGridInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro no servidor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        catch (Exception)
        {
            MessageBox.Show("Ocorreu um erro ao carregar os dados dos insumos. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #region Métodos de verificação

    private bool VerificarSelecao()
    {
        if (dataGridInsumos.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione um insumo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }

    #endregion

    #region Métodos de Click

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroInsumoForm = new CadastroInsumoForm(_insumoController);
        cadastroInsumoForm.ShowDialog();

        await CarregarGrid();
    }

    private async void btnAlterar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var insumoId = Convert.ToInt32(dataGridInsumos.SelectedRows[0].Cells["id_insumo"].Value);

            var alteraInsumoForm = new AlteraInsumoForm(_insumoController, insumoId);
            alteraInsumoForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var insumoId = Convert.ToInt32(dataGridInsumos.SelectedRows[0].Cells["id_insumo"].Value);
            var consultaInsumoForm = new ConsultaInsumoForm(_insumoController, insumoId);
            consultaInsumoForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var insumoId = Convert.ToInt32(dataGridInsumos.SelectedRows[0].Cells["id_insumo"].Value);
            var excluirInsumoForm = new ExcluirInsumoForm(_insumoController, insumoId);
            excluirInsumoForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

}
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms.Culturas;

public partial class CulturaForm : Form
{
    private readonly CulturaController _culturaController;

    public CulturaForm(CulturaController culturaController)
    {
        InitializeComponent();
        _culturaController = culturaController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void CulturaForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);

        await CarregarGrid();
    }

    private async Task CarregarGrid()
    {
        try
        {
            var culturas = await _culturaController.Index();

            if (culturas.Any())
            {
                dataGridCulturas.DataSource = culturas;
                dataGridCulturas.AutoGenerateColumns = true;
                dataGridCulturas.Columns[0].HeaderText = "Código";
                dataGridCulturas.Columns[2].HeaderText = "Data de Plantio";
                dataGridCulturas.Columns[3].HeaderText = "Data de Colheita";
                dataGridCulturas.Columns[4].HeaderText = "Área Plantada";
                dataGridCulturas.Columns[5].HeaderText = "Quantidade Plantada";
                dataGridCulturas.Columns[6].HeaderText = "Tipo de Solo";
                dataGridCulturas.Columns[7].HeaderText = "Tipo de Irrigação";
                dataGridCulturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro no servidor.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        catch (Exception)
        {
            // Exibir uma mensagem de erro genérica para o usuário
            MessageBox.Show(
                "Ocorreu um erro ao carregar os dados dos culturas. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #region Métodos de verificação

    private bool VerificarSelecao()
    {
        if (dataGridCulturas.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione uma cultura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }

    #endregion

    #region Métodos de Click

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroCulturaForm = new CadastroCulturaForm(_culturaController);
        cadastroCulturaForm.ShowDialog();

        await CarregarGrid();
    }

    private async void btnAlterar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var culturaId =
                Convert.ToInt32(dataGridCulturas.SelectedRows[0].Cells["id_cultura"].Value);

            var alteraCulturaForm = new AlteraCulturaForm(_culturaController, culturaId);
            alteraCulturaForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var culturaId = Convert.ToInt32(dataGridCulturas.SelectedRows[0].Cells["id_cultura"].Value);
            var consultaCulturaForm = new ConsultaCulturaForm(_culturaController, culturaId);
            consultaCulturaForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var culturaId = Convert.ToInt32(dataGridCulturas.SelectedRows[0].Cells["id_cultura"].Value);
            var excluirCulturaForm = new ExcluirCulturaForm(_culturaController, culturaId);
            excluirCulturaForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

}
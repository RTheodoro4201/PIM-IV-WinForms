using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms.Funcionarios;

public partial class FuncionarioForm : Form
{
    private readonly FuncionarioController _funcionarioController;

    public FuncionarioForm(FuncionarioController funcionarioController)
    {
        InitializeComponent();
        _funcionarioController = funcionarioController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void FuncionarioForm_Load(object sender, EventArgs e)
    {
        await CarregarGrid();
    }

    #region Métodos de Click

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroFuncionarioForm = new CadastroFuncionarioForm(_funcionarioController);
        cadastroFuncionarioForm.ShowDialog();

        await CarregarGrid();
    }

    private async void btnAlterar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var funcionarioId =
                Convert.ToInt32(dataGridFuncionarios.SelectedRows[0].Cells["id_funcionario"].Value);

            var alteraFuncionarioForm = new AlteraFuncionarioForm(_funcionarioController, funcionarioId);
            alteraFuncionarioForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var funcionarioId = Convert.ToInt32(dataGridFuncionarios.SelectedRows[0].Cells["id_funcionario"].Value);
            var consultaFuncionarioForm = new ConsultaFuncionarioForm(_funcionarioController, funcionarioId);
            consultaFuncionarioForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var funcionarioId = Convert.ToInt32(dataGridFuncionarios.SelectedRows[0].Cells["id_funcionario"].Value);
            var excluirFuncionarioForm = new ExcluirFuncionarioForm(_funcionarioController, funcionarioId);
            excluirFuncionarioForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

    private async Task CarregarGrid()
    {
        try
        {
            var funcionarios = await _funcionarioController.Index();

            if (funcionarios.Any())
            {
                dataGridFuncionarios.DataSource = funcionarios;
                dataGridFuncionarios.AutoGenerateColumns = true;
                dataGridFuncionarios.Columns[0].HeaderText = "Id";
                dataGridFuncionarios.Columns[1].HeaderText = "Nome";
                dataGridFuncionarios.Columns[7].HeaderText = "Salário";
                dataGridFuncionarios.Columns[8].HeaderText = "Data de Admissão";
                dataGridFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                "Ocorreu um erro ao carregar os dados dos funcionários. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool VerificarSelecao()
    {
        if (dataGridFuncionarios.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione um funcionário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }
}
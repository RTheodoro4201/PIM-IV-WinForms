using System;
using System.Linq;
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
        this.WindowState = FormWindowState.Maximized;
    }

    private async void FuncionarioForm_Load(object sender, EventArgs e)
    {
        var funcionarios = await _funcionarioController.Index();

        if (funcionarios != null && funcionarios.Any())
        {
            this.dataGridFuncionarios.DataSource =  funcionarios;
            this.dataGridFuncionarios.AutoGenerateColumns = true;
            this.dataGridFuncionarios.Columns[0].HeaderText = "Id";
            this.dataGridFuncionarios.Columns[1].HeaderText = "Nome";
            this.dataGridFuncionarios.Columns[7].HeaderText = "Salário";
            this.dataGridFuncionarios.Columns[8].HeaderText = "Data de Admissão";
            this.dataGridFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        else
        {
            MessageBox.Show("Não foi encontrado nenhum registro no servidor!");
        }
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        int funcionarioId = Convert.ToInt32(this.dataGridFuncionarios.SelectedRows[0].Cells["id_funcionario"].Value);
        var alteraFuncionarioForm = new AlteraFuncionarioForm(_funcionarioController, funcionarioId);
        alteraFuncionarioForm.ShowDialog();

        FuncionarioForm_Load(this, null);
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroFuncionarioForm = new CadastroFuncionarioForm(_funcionarioController);
        cadastroFuncionarioForm.ShowDialog();

        FuncionarioForm_Load(this, null);
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        int funcionarioId = Convert.ToInt32(this.dataGridFuncionarios.SelectedRows[0].Cells["id_funcionario"].Value);
        var excluirFuncionarioForm = new ExcluirFuncionarioForm(_funcionarioController, funcionarioId);
        excluirFuncionarioForm.ShowDialog();

        FuncionarioForm_Load(this, null);
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnConsultar_Click(object sender, EventArgs e)
    {
        int funcionarioId = Convert.ToInt32(this.dataGridFuncionarios.SelectedRows[0].Cells["id_funcionario"].Value);
        var consultaFuncionarioForm = new ConsultaFuncionarioForm(_funcionarioController, funcionarioId);
        consultaFuncionarioForm.ShowDialog();

        FuncionarioForm_Load(this, null);
    }
}
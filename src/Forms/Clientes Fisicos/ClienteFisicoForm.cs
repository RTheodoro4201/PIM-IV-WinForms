using System;
using System.Linq;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms.Clientes_Fisicos;

#region TODO
//TODO Refatorar para seguir evolução do projeto
#endregion

public partial class ClienteFisicoForm : Form
{
    private readonly ClienteFisicoController _clienteFisicoController;
    public ClienteFisicoForm(ClienteFisicoController clienteFisicoController)
    {
        InitializeComponent();
        _clienteFisicoController = clienteFisicoController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;
    }

    private async void ClienteFisicoForm_Load(object sender, EventArgs e)
    {
        var clientes = await _clienteFisicoController.Index();

        if (clientes.Any())
        {
            this.dataGridClientes.DataSource =  clientes;
            this.dataGridClientes.AutoGenerateColumns = true;
            this.dataGridClientes.Columns[0].HeaderText = "Id";
            this.dataGridClientes.Columns[1].HeaderText = "Nome";
            this.dataGridClientes.Columns[7].HeaderText = "Data de Nascimento";
            this.dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        else
        {
            MessageBox.Show("Houve um erro ao receber os dados do servidor");
            this.Close();
        }
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        int clienteId = Convert.ToInt32(this.dataGridClientes.SelectedRows[0].Cells["id_cliente"].Value);
        var alteraClienteFisicoForm = new AlteraClienteFisicoForm(_clienteFisicoController, clienteId);
        alteraClienteFisicoForm.ShowDialog();

        ClienteFisicoForm_Load(this, null);
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroClienteFisicoForm = new CadastroClienteFisicoForm(_clienteFisicoController);
        cadastroClienteFisicoForm.ShowDialog();

        ClienteFisicoForm_Load(this, null);
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        int clienteId = Convert.ToInt32(this.dataGridClientes.SelectedRows[0].Cells["id_cliente"].Value);
        var excluirClienteFisicoForm = new ExcluirClienteFisicoForm(_clienteFisicoController, clienteId);
        excluirClienteFisicoForm.ShowDialog();

        ClienteFisicoForm_Load(this, null);
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnConsultar_Click(object sender, EventArgs e)
    {
        int clienteId = Convert.ToInt32(this.dataGridClientes.SelectedRows[0].Cells["id_cliente"].Value);
        var consultaClienteFisicoForm = new ConsultaClienteFisicoForm(_clienteFisicoController, clienteId);
        consultaClienteFisicoForm.ShowDialog();

        ClienteFisicoForm_Load(this, null);
    }
}
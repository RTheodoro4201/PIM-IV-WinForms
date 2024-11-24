using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms.Clientes;

public partial class ClienteForm : Form
{
    private readonly ClienteController _clienteController;
    private readonly string _tipoCliente;

    public ClienteForm(ClienteController clienteController, string tipoCliente)
    {
        InitializeComponent();
        _clienteController = clienteController;
        _tipoCliente = tipoCliente;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ClienteFisicoForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);

        await VerificarTipoGrid();
    }

    private bool VerificarSelecao()
    {
        if (dataGridClientes.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione um cliente.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }

    #region Métodos de Verificação

    private async Task VerificarTipoGrid()
    {
        if (_tipoCliente == "Físico")
        {
            await CarregarGridFisico();
        }

        else if (_tipoCliente == "Jurídico")
        {
            await CarregarGridJuridico();
        }

        else if (_tipoCliente == "Geral")
        {
            await CarregarGridGeral();
        }
    }

    private async Task CarregarGridJuridico()
    {
        var clientes = await _clienteController.IndexJuridico();

        if (clientes.Any())
        {
            dataGridClientes.DataSource = clientes;
            dataGridClientes.AutoGenerateColumns = true;
            dataGridClientes.Columns[0].HeaderText = "Código";
            dataGridClientes.Columns[1].HeaderText = "Nome Fantasia/Razão Social";
            dataGridClientes.Columns[2].HeaderText = "CNPJ";
            dataGridClientes.Columns[7].HeaderText = "Data de Fundação";
            dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        else
        {
            MessageBox.Show("Houve um erro ao receber os dados do servidor");
            Close();
        }
    }

    private async Task CarregarGridFisico()
    {
        var clientes = await _clienteController.IndexFisico();

        if (clientes.Any())
        {
            dataGridClientes.DataSource = clientes;
            dataGridClientes.AutoGenerateColumns = true;
            dataGridClientes.Columns[0].HeaderText = "Código";
            dataGridClientes.Columns[1].HeaderText = "Nome";
            dataGridClientes.Columns[2].HeaderText = "CPF";
            dataGridClientes.Columns[7].HeaderText = "Data de Nascimento";
            dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        else
        {
            MessageBox.Show("Houve um erro ao receber os dados do servidor");
            Close();
        }
    }

    private async Task CarregarGridGeral()
    {
        var clientes = await _clienteController.IndexAll();

        if (clientes.Any())
        {
            dataGridClientes.DataSource = clientes;
            dataGridClientes.AutoGenerateColumns = true;
            dataGridClientes.Columns[0].HeaderText = "Código";
            dataGridClientes.Columns[1].HeaderText = "Nome/Nome Fantasia";
            dataGridClientes.Columns[7].HeaderText = "Data de Nascimento/Fundação";
            dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        else
        {
            MessageBox.Show("Houve um erro ao receber os dados do servidor");
            Close();
        }
    }

    #endregion

    #region Métodos de Click

    private async void btnAlterar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var clienteId = Convert.ToInt32(dataGridClientes.SelectedRows[0].Cells["id_cliente"].Value);
            var alteraClienteFisicoForm = new AlteraClienteForm(_clienteController, clienteId);
            alteraClienteFisicoForm.ShowDialog();

            await VerificarTipoGrid();
        }
    }

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroClienteFisicoForm = new CadastroClienteForm(_clienteController);
        cadastroClienteFisicoForm.ShowDialog();

        await VerificarTipoGrid();
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var clienteId = Convert.ToInt32(dataGridClientes.SelectedRows[0].Cells["id_cliente"].Value);
            var excluirClienteFisicoForm = new ExcluirClienteForm(_clienteController, clienteId);
            excluirClienteFisicoForm.ShowDialog();

            await VerificarTipoGrid();
        }
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var clienteId = Convert.ToInt32(dataGridClientes.SelectedRows[0].Cells["id_cliente"].Value);
            var consultaClienteFisicoForm = new ConsultaClienteForm(_clienteController, clienteId);
            consultaClienteFisicoForm.ShowDialog();

            await VerificarTipoGrid();
        }
    }
    
    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}
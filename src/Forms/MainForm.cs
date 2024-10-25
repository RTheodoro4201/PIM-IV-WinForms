using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Forms.Clientes_Fisicos;

namespace PIM_IV_Forms.Forms;

public partial class MainForm : Form
{
    private ClienteFisicoController _clienteFisicoController;

    public MainForm(ClienteFisicoController clienteFisicoController)
    {
        InitializeComponent();
        _clienteFisicoController = clienteFisicoController;
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void btnClienteFisico_Click(object sender, EventArgs e)
    {
        if (_clienteFisicoController != null)
        {
            var clienteFisicoForm = new ClienteFisicoForm(_clienteFisicoController);
            clienteFisicoForm.Show();
        }
    }
}


using System;
using System.Windows.Forms;
using Autofac.Core.Lifetime;

namespace PIM_IV_Forms.Forms;

public partial class MainForm : Form
{
    private readonly LifetimeScope _lifetimeScope;

    public MainForm(LifetimeScope lifetimeScope)
    {
        InitializeComponent();
        _lifetimeScope = lifetimeScope;
    }


    private void tabClientes_Enter(object sender, EventArgs e)
    {

    }

    private void btnCadastroCliente_Click(object sender, EventArgs e)
    {
        var cadastroClienteForm = new CadastroClienteForm(_lifetimeScope);
        cadastroClienteForm.Show();
    }
}
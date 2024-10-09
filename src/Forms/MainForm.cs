using System;
using System.Drawing;
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
        MainControl mainControl = new MainControl();
        Controls.Add(mainControl);

        Rectangle workingArea = Screen.GetWorkingArea(this);
        Size formSize = workingArea.Size;
        Size = formSize;
    }

    private void btnCadastroCliente_Click(object sender, EventArgs e)
    {
        var cadastroClienteForm = new CadastroClienteForm(_lifetimeScope);
        cadastroClienteForm.Show();
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }
}
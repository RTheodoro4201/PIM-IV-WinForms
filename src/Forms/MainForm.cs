using System;
using System.Drawing;
using System.Windows.Forms;
using Autofac;
using Autofac.Core.Lifetime;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Forms.UserControls;

namespace PIM_IV_Forms.Forms;

public partial class MainForm : Form
{
    public MainForm(IComponentContext componentContext)
    {
        InitializeComponent();
        MainControl mainControl = new MainControl(componentContext);
        CadastroClienteFisicoControl cadastroClienteFisicoControl = new CadastroClienteFisicoControl(componentContext.Resolve<ClienteFisicoController>());
        Controls.Add(mainControl);
        Controls.Add(cadastroClienteFisicoControl);
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }
}
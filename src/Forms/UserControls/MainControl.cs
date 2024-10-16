using System;
using System.Windows.Forms;
using Autofac;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms.UserControls;

public partial class MainControl : UserControl
{
    private readonly IComponentContext _context;
    public MainControl(IComponentContext context)
    {
        InitializeComponent();
        _context = context;
    }

    private void btnClienteFisico_Click(object sender, EventArgs e)
    {
        var cadastroClienteFisicoControl = new CadastroClienteFisicoControl(_context.Resolve<ClienteFisicoController>());
        this.Visible = false;
        cadastroClienteFisicoControl.Dock = DockStyle.Fill;
    }
}
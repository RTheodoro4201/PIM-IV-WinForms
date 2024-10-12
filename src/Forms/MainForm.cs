using System;
using System.Drawing;
using System.Windows.Forms;
using Autofac;
using Autofac.Core.Lifetime;
using PIM_IV_Forms.Forms.UserControls;

namespace PIM_IV_Forms.Forms;

public partial class MainForm : Form
{
    private readonly IComponentContext _componentContext;

    public MainForm(IComponentContext componentContext)
    {
        InitializeComponent();
        _componentContext = componentContext;
        MainControl mainControl = new MainControl(_componentContext);
        Controls.Add(mainControl);

        Rectangle workingArea = Screen.GetWorkingArea(this);
        Size formSize = workingArea.Size;
        Size = formSize;
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }
}
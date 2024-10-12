using System;
using System.Windows.Forms;
using Autofac;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Properties;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Panels;

public partial class CadastroClienteFisicoForm : Form
{
    private readonly ClienteController _clienteController;
    public CadastroClienteFisicoForm(IComponentContext componentContext)
    {
        InitializeComponent();
        _clienteController = componentContext.Resolve<ClienteController>();
    }


    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        var cliente = new Cliente
        {
            Nome = txtNome.Text + " " + txtSobrenome.Text,
            Documento = txtDocumento.Text,
            TipoDocumento = "CPF",
            Telefone = txtTelefone.Text
        };
        var validator = new ClienteValidator();

        if (validator.ValidateModel(cliente))
        {
            await _clienteController.Create(cliente);
            MessageBox.Show(Resources.Sucesso_Cadastro);
        }

        else
        {
            MessageBox.Show(Resources.Falha_Cadastro);
        }
    }


    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

}
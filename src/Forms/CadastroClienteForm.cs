using System;
using System.Windows.Forms;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Validator;
using Autofac;
using Autofac.Core.Lifetime;
using PIM_IV_Forms.Properties;

namespace PIM_IV_Forms.Forms;

public partial class CadastroClienteForm : Form
{
    private readonly ClienteController _clienteController;
    public CadastroClienteForm(LifetimeScope lifetimeScope)
    {
        InitializeComponent();
        _clienteController = lifetimeScope.Resolve<ClienteController>();
    }


    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        var cliente = new Cliente
        {
            Nome = txtNome.Text + " " + txtSobrenome.Text,
            Documento = txtDocumento.Text,
            Telefone = txtTelefone.Text
        };
        var validator = new ClienteValidator();

        if (rbtnCpf.Checked)
        {
            cliente.TipoDocumento = rbtnCpf.Text;
            Console.WriteLine(cliente.TipoDocumento);
        }
        if (rbtnCnpj.Checked)
        {
            cliente.TipoDocumento = rbtnCnpj.Text;
            Console.WriteLine(cliente.TipoDocumento);
        }

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
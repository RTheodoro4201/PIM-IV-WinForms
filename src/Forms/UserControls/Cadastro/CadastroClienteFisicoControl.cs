using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.UserControls;

public partial class CadastroClienteFisicoControl : UserControl
{
    private readonly ClienteFisicoController _clienteFisicoController;
    public CadastroClienteFisicoControl(ClienteFisicoController clienteFisicoController)
    {
        InitializeComponent();
        _clienteFisicoController = clienteFisicoController;
    }

    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        var cliente = new ClienteFisico()
        {
            Nome = txtNome.Text + " " + txtSobrenome.Text,
            Rg = txtRg.Text,
            Cpf = txtCpf.Text,
            Email = txtEmail.Text,
            Telefone = txtTelefone.Text,
            DataNascimento = dateDataNascimento.Value,
        };

        if (await _clienteFisicoController.Create(cliente))
        {
            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        else
        {
            var validator = new ClienteValidator();
            MessageBox.Show("Cadastro de Cliente inválido!");

            validator.ValidateModel(cliente);
            if (validator.Erros.Any())
            {
                foreach (var erro in validator.Erros)
                {
                    MessageBox.Show("Erro no campo: " + erro.NomeCampo + "\n" + erro.MensagemErro);
                }
            }
        }
    }
}
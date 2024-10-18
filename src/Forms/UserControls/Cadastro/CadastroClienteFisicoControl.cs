using System;
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
        try
        {
            var endereco = new Endereco()
            {
                Logradouro = txtLogradouro.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtBairro.Text,
                Uf = cbUf.Text,
                Cep = txtCep.Text,
            };

            var cliente = new ClienteFisico()
            {
                Nome = txtNome.Text,
                Rg = txtRg.Text,
                Cpf = txtCpf.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Endereco = endereco,
                DataNascimento = dateDataNascimento.Value,
            };

            if (await _clienteFisicoController.Create(cliente))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!");
                LimparCampos();
            }

            else
            {
                var validator = new ClienteFisicoValidator();
                var validationResult = await validator.ValidateAsync(cliente);
                MessageBox.Show("Cadastro de Cliente inválido!");

                foreach (var erro in validationResult.Errors)
                {
                    MessageBox.Show(erro.ErrorMessage);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente mais tarde.");
            MessageBox.Show(ex.Message);
        }
    }

    private void LimparCampos()
    {
        foreach (Control control in this.Controls)
        {
            switch (control)
            {
                case TextBox box:
                    box.Clear();
                    break;
                case ComboBox box:
                    box.SelectedIndex = -1;
                    break;
            }
        }

    }

    private void CadastroClienteFisicoControl_Load(object sender, EventArgs e)
    {
        this.dateDataNascimento.Value = DateTime.Now;
    }

    private void dateDataNascimento_ValueChanged(object sender, EventArgs e)
    {
        if (this.dateDataNascimento.Value > DateTime.Now)
        {
            MessageBox.Show("Data inválida!");
            this.dateDataNascimento.Value = DateTime.Now;
        }
    }

}
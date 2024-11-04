using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Clientes_Fisicos;

public partial class CadastroClienteFisicoForm : Form
{
    private readonly ClienteFisicoController _clienteFisicoController;

    public CadastroClienteFisicoForm(ClienteFisicoController clienteFisicoController)
    {
        InitializeComponent();
        _clienteFisicoController = clienteFisicoController;
    }

    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            var endereco = new Endereco
            {
                Logradouro = txtLogradouro.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtBairro.Text,
                Uf = cbUf.Text,
                Cep = txtCep.Text
            };

            var cliente = new ClienteFisico
            {
                Nome_Completo = txtNome.Text,
                Rg = txtRg.Text,
                Cpf = txtCpf.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Endereco = endereco.ToString(),
                Data_De_Nascimento = dateDataNascimento.Value
            };

            if (await _clienteFisicoController.Create(cliente, endereco))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!");
                Close();
            }

            else
            {
                var clienteValidator = new ClienteFisicoValidator();
                var clienteValidationResult = await clienteValidator.ValidateAsync(cliente);
                var enderecoValidator = new EnderecoValidator();
                var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);
                MessageBox.Show("Cadastro de Cliente inválido!");

                foreach (var erro in clienteValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);

                foreach (var erro in enderecoValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente mais tarde.");
            MessageBox.Show(ex.Message);
        }
    }

    private void CadastroClienteFisicoForm_Load(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void dateDataNascimento_ValueChanged(object sender, EventArgs e)
    {
        if (dateDataNascimento.Value > DateTime.Now.AddYears(-18))
        {
            MessageBox.Show("Data inválida!");
            dateDataNascimento.Value = DateTime.Now.AddYears(-18);
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
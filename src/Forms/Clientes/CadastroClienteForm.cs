using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Clientes;

public partial class CadastroClienteForm : Form
{
    private readonly ClienteController _clienteController;

    public CadastroClienteForm(ClienteController clienteController)
    {
        InitializeComponent();
        _clienteController = clienteController;
    }

    private void CadastroClienteForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    #region Métodos de Verificação

    private void VerificarTipoCliente(object sender, EventArgs e)
    {
        if (txtTipo.Text == "Jurídico")
        {
            txtDocumento.Mask = "99.999.999/9999-99";
        }

        else if (txtTipo.Text == "Físico")
        {
            txtDocumento.Mask = "999.999.999-99";
        }
    }

    private void dateDataInicial_ValueChanged(object sender, EventArgs e)
    {
        VerificarTipoCliente(this, null);

        if (txtTipo.Text == "Físico")
        {
            lblDataInicial.Text = "Data de Nascimento";
            VerificarDataInicial();
        }

        else if (txtTipo.Text == "Jurídico")
        {
            lblDataInicial.Text = "Data de Fundação";
            VerificarDataInicial();
        }
    }

    private void VerificarDataInicial()
    {
        if (txtTipo.Text == "Físico" && dateDataInicial.Value > DateTime.Now.AddYears(-18))
        {
            MessageBox.Show("Data de nascimento inválida. O cliente precisa ser maior de 18 anos.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            dateDataInicial.Value = DateTime.Now.AddYears(-18);
        }

        else if (txtTipo.Text == "Jurídico" && dateDataInicial.Value > DateTime.Now)
        {
            MessageBox.Show("Data de Fundação inválida. A data de fundação não pode ser futura", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    #endregion

    #region Métodos de Click

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

            var cliente = new Cliente
            {
                Nome = txtNome.Text,
                Tipo = txtTipo.Text,
                Documento = txtDocumento.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Endereco = endereco.ToString(),
                Data_Inicial = dateDataInicial.Value
            };

            if (await _clienteController.Create(cliente, endereco))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!");
                Close();
            }

            else
            {
                var clienteValidator = new ClienteValidator();
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

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}
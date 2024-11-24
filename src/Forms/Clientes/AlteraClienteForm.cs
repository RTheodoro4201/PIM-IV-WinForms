using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Clientes;

public partial class AlteraClienteForm : Form
{
    private readonly ClienteController _clienteController;
    private readonly int _idCliente;
    private Cliente _cliente;

    public AlteraClienteForm(ClienteController clienteController, int idCliente)
    {
        InitializeComponent();
        _clienteController = clienteController;
        _idCliente = idCliente;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void AlteraClienteForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);

        var cliente = await _clienteController.SearchCliente(_idCliente);
        if (cliente != null)
        {
            _cliente = cliente;
            var endereco = Endereco.ToEndereco(cliente.Endereco);

            VerificarTipoCliente(this, null);
            PopulaCampos(endereco, _cliente);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste cliente. Tente novamente mais tarde.");
            Close();
        }
    }

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

        else if (txtTipo.Text == "")
        {
            txtDocumento.Mask = "";
        }
    }

    private void PopulaCampos(Endereco endereco, Cliente cliente)
    {
        txtIdCliente.Text = cliente.Id_Cliente.ToString();
        txtNome.Text = cliente.Nome;
        txtTipo.Text = cliente.Tipo;
        txtDocumento.Text = cliente.Documento;
        txtEmail.Text = cliente.Email;
        txtTelefone.Text = cliente.Telefone;
        txtLogradouro.Text = endereco.Logradouro;
        txtNumero.Text = endereco.Numero;
        txtComplemento.Text = endereco.Complemento;
        txtBairro.Text = endereco.Bairro;
        txtCidade.Text = endereco.Cidade;
        cbUf.Text = endereco.Uf;
        txtCep.Text = endereco.Cep;
        dateDataInicial.Value = cliente.Data_Inicial.Date;
    }

    private void dateDataInicial_ValueChanged(object sender, EventArgs e)
    {
        VerificarDataInicial();
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
            MessageBox.Show("Data de fundação inválida. A data de fundação não pode ser futura.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            dateDataInicial.Value = DateTime.Now;
        }
    }

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
                Cidade = txtCidade.Text,
                Uf = cbUf.Text,
                Cep = txtCep.Text
            };

            var cliente = new Cliente
            {
                Id_Cliente = _idCliente,
                Nome = txtNome.Text,
                Tipo = txtTipo.Text,
                Documento = txtDocumento.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Endereco = endereco.ToString(),
                Data_Inicial = dateDataInicial.Value
            };

            if (await _clienteController.Edit(cliente, endereco))
            {
                MessageBox.Show("Cliente alterado com sucesso.");
                Close();
            }

            else
            {
                var clienteValidator = new ClienteValidator();
                var clienteValidationResult = await clienteValidator.ValidateAsync(cliente);
                var enderecoValidator = new EnderecoValidator();
                var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);
                MessageBox.Show("Dados de alteração inválidos.");

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
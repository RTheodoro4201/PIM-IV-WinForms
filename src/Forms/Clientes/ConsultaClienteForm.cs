using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Clientes;

public partial class ConsultaClienteForm : Form
{
    private readonly ClienteController _clienteController;
    private readonly int _clienteId;
    private Cliente _cliente;

    public ConsultaClienteForm(ClienteController clienteController, int clienteId)
    {
        InitializeComponent();
        _clienteController = clienteController;
        _clienteId = clienteId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ConsultaClienteForm_Load(object sender, EventArgs e)
    {
        var cliente = await _clienteController.SearchCliente(_clienteId);
        if (cliente != null)
        {
            _cliente = cliente;
            var endereco = Endereco.ToEndereco(cliente.Endereco);

            VerificarTipoCliente();
            PopulaCampos(endereco, _cliente);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste cliente! Tente novamente mais tarde.");
            Close();
        }
    }

    private void VerificarTipoCliente()
    {
        if (txtTipo.Text == "Jurídico")
        {
            txtDocumento.Mask = "99.999.999/9999-99";
            lblDataInicial.Text = "Data de Fundação";
        }

        else if (txtTipo.Text == "Físico")
        {
            txtDocumento.Mask = "999.999.999-99";
            lblDataInicial.Text = "Data de Nascimento";
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
        dateDataInicial.Value = cliente.Data_Inicial;
    }

    #region Métodos de Click

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}
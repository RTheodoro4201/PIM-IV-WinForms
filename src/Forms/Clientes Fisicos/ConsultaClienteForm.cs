using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Clientes_Fisicos;

public partial class ConsultaClienteFisicoForm : Form
{
    private readonly ClienteFisicoController _clienteFisicoController;
    private readonly int _clienteFisicoId;
    private ClienteFisico _clienteFisico;

    public ConsultaClienteFisicoForm(ClienteFisicoController clienteFisicoController, int clienteId)
    {
        InitializeComponent();
        _clienteFisicoController = clienteFisicoController;
        _clienteFisicoId = clienteId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ConsultaClienteFisicoForm_Load(object sender, EventArgs e)
    {
        var cliente = await _clienteFisicoController.SearchCliente(_clienteFisicoId);
        if (cliente != null)
        {
            _clienteFisico = cliente;
            var endereco = Endereco.ToEndereco(cliente.Endereco);

            PopulaCampos(endereco, _clienteFisico);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste cliente! Tente novamente mais tarde.");
            Close();
        }
    }

    private void PopulaCampos(Endereco endereco, ClienteFisico clienteFisico)
    {
        txtIdCliente.Text = clienteFisico.Id_Cliente.ToString();
        txtIdCliente.ReadOnly = true;
        txtNome.Text = clienteFisico.Nome_Completo;
        txtRg.Text = clienteFisico.Rg;
        txtCpf.Text = clienteFisico.Cpf;
        txtEmail.Text = clienteFisico.Email;
        txtTelefone.Text = clienteFisico.Telefone;
        txtLogradouro.Text = endereco.Logradouro;
        txtNumero.Text = endereco.Numero;
        txtComplemento.Text = endereco.Complemento;
        txtBairro.Text = endereco.Bairro;
        txtCidade.Text = endereco.Cidade;
        cbUf.Text = endereco.Uf;
        txtCep.Text = endereco.Cep;
        dateDataNascimento.Value = clienteFisico.Data_De_Nascimento.Date;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Clientes_Fisicos;

public partial class ConsultaClienteFisicoForm : Form
{
    private readonly ClienteFisicoController _clienteFisicoController;
    private ClienteFisico _clienteFisico;
    private readonly int _clienteFisicoId;

    public ConsultaClienteFisicoForm(ClienteFisicoController clienteFisicoController, int clienteId)
    {
        InitializeComponent();
        _clienteFisicoController = clienteFisicoController;
        _clienteFisicoId = clienteId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;
    }

    private async void ConsultaClienteFisicoForm_Load(object sender, EventArgs e)
    {
        var cliente = await _clienteFisicoController.SearchCliente(_clienteFisicoId);
        if (cliente != null)
        {
            _clienteFisico = cliente;
            var endereco = Endereco.ToEndereco(cliente.Endereco);

            PopulaCampos(endereco,_clienteFisico);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste cliente! Tente novamente mais tarde.");
            this.Close();
        }
    }

    private void PopulaCampos(Endereco endereco, ClienteFisico clienteFisico)
    {
        this.txtIdCliente.Text = clienteFisico.Id_Cliente.ToString();
        this.txtIdCliente.ReadOnly = true;
        this.txtNome.Text = clienteFisico.Nome_Completo;
        this.txtRg.Text = clienteFisico.Rg;
        this.txtCpf.Text = clienteFisico.Cpf;
        this.txtEmail.Text = clienteFisico.Email;
        this.txtTelefone.Text = clienteFisico.Telefone;
        this.txtLogradouro.Text = endereco.Logradouro;
        this.txtNumero.Text = endereco.Numero;
        this.txtComplemento.Text = endereco.Complemento;
        this.txtBairro.Text = endereco.Bairro;
        this.txtCidade.Text = endereco.Cidade;
        this.cbUf.Text = endereco.Uf;
        this.txtCep.Text = endereco.Cep;
        this.dateDataNascimento.Value = clienteFisico.Data_De_Nascimento.Date;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

}
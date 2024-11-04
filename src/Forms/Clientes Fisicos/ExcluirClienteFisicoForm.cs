using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Clientes_Fisicos;

public partial class ExcluirClienteFisicoForm : Form
{
    private readonly ClienteFisicoController _clienteFisicoController;
    private readonly int _clienteFisicoId;
    private ClienteFisico _clienteFisico;

    public ExcluirClienteFisicoForm(ClienteFisicoController clienteFisicoController, int clienteId)
    {
        InitializeComponent();
        _clienteFisicoController = clienteFisicoController;
        _clienteFisicoId = clienteId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ExcluirClienteFisicoForm_Load(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
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

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            var resultado =
                MessageBox.Show(
                    $"Deseja excluir o cliente {_clienteFisico.Nome_Completo}? Esta ação não pode ser desfeita.",
                    "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                await _clienteFisicoController.Delete(_clienteFisicoId);
                MessageBox.Show("Cliente excluído com sucesso!");
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar excluir o cliente!");
            MessageBox.Show(exception.Message);
            throw;
        }
    }
}
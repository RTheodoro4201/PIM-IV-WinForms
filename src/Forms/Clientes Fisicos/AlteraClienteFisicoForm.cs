using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Clientes_Fisicos;

public partial class AlteraClienteFisicoForm : Form
{
    private readonly ClienteFisicoController _clienteFisicoController;
    private ClienteFisico _clienteFisico;
    private readonly int _clienteFisicoId;

    public AlteraClienteFisicoForm(ClienteFisicoController clienteFisicoController, int clienteId)
    {
        InitializeComponent();
        _clienteFisicoController = clienteFisicoController;
        _clienteFisicoId = clienteId;
    }
    private void ResizeForm(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;
    }

    private async void AlteraClienteFisicoForm_Load(object sender, EventArgs e)
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
                Cidade = txtCidade.Text,
                Uf = cbUf.Text,
                Cep = txtCep.Text,
            };

            var cliente = new ClienteFisico()
            {
                Id_Cliente = _clienteFisicoId,
                Nome_Completo = txtNome.Text,
                Rg = txtRg.Text,
                Cpf = txtCpf.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Endereco = endereco.ToString(),
                Data_De_Nascimento = dateDataNascimento.Value,
            };

            if (await _clienteFisicoController.Edit(cliente, endereco))
            {
                MessageBox.Show("Cliente alterado com sucesso!");
                this.Close();
            }

            else
            {
                var clienteValidator = new ClienteFisicoValidator();
                var clienteValidationResult = await clienteValidator.ValidateAsync(cliente);
                var enderecoValidator = new EnderecoValidator();
                var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);
                MessageBox.Show("Dados de alteração inválidos!");

                foreach (var erro in clienteValidationResult.Errors)
                {
                    MessageBox.Show(erro.ErrorMessage);
                }

                foreach (var erro in enderecoValidationResult.Errors)
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

    private void dateDataNascimento_ValueChanged(object sender, EventArgs e)
    {
        if (this.dateDataNascimento.Value > DateTime.Now.AddYears(-18))
        {
            MessageBox.Show("Data inválida!");
            this.dateDataNascimento.Value = DateTime.Now.AddYears(-18);
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
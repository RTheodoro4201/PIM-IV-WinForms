using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Funcionarios;

public partial class AlteraFuncionarioForm : Form
{
    private readonly FuncionarioController _funcionarioController;
    private Funcionario _funcionario;
    private readonly int _funcionarioId;

    public AlteraFuncionarioForm(FuncionarioController funcionarioController, int clienteId)
    {
        InitializeComponent();
        _funcionarioController = funcionarioController;
        _funcionarioId = clienteId;
    }
    private void ResizeForm(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;
    }

    private async void AlteraFuncionarioForm_Load(object sender, EventArgs e)
    {
        var funcionario = await _funcionarioController.SearchFuncionario(_funcionarioId);
        if (funcionario != null)
        {
            _funcionario = funcionario;
            var endereco = Endereco.ToEndereco(funcionario.Endereco);

            PopulaCampos(endereco,_funcionario);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste cliente! Tente novamente mais tarde.");
            this.Close();
        }
    }

    private void PopulaCampos(Endereco endereco, Funcionario funcionario)
    {
        this.txtIdFuncionario.Text = funcionario.Id_Funcionario.ToString();
        this.txtIdFuncionario.ReadOnly = true;
        this.txtNome.Text = funcionario.Nome_Completo;
        this.txtRg.Text = funcionario.Rg;
        this.txtCpf.Text = funcionario.Cpf;
        this.txtEmail.Text = funcionario.Email;
        this.txtTelefone.Text = funcionario.Telefone;
        this.txtLogradouro.Text = endereco.Logradouro;
        this.txtNumero.Text = endereco.Numero;
        this.txtComplemento.Text = endereco.Complemento;
        this.txtBairro.Text = endereco.Bairro;
        this.txtCidade.Text = endereco.Cidade;
        this.cbUf.Text = endereco.Uf;
        this.txtCep.Text = endereco.Cep;
        this.dateDataAdmissao.Value = funcionario.Data_Admissao.Date;
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

            var funcionario = new Funcionario()
            {
                Id_Funcionario = _funcionarioId,
                Nome_Completo = txtNome.Text,
                Rg = txtRg.Text,
                Cpf = txtCpf.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Endereco = endereco.ToString(),
                Data_Admissao = dateDataAdmissao.Value,
            };

            if (await _funcionarioController.Edit(funcionario, endereco))
            {
                MessageBox.Show("Funcionário alterado com sucesso!");
                this.Close();
            }

            else
            {
                var funcionarioValidator = new FuncionarioValidator();
                var funcionarioValidationResult = await funcionarioValidator.ValidateAsync(funcionario);
                var enderecoValidator = new EnderecoValidator();
                var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);
                MessageBox.Show("Dados de alteração inválidos!");

                foreach (var erro in funcionarioValidationResult.Errors)
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
        if (this.dateDataAdmissao.Value > DateTime.Now.AddYears(-18))
        {
            MessageBox.Show("Data inválida!");
            this.dateDataAdmissao.Value = DateTime.Now.AddYears(-18);
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
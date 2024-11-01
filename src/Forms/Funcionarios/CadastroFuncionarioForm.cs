using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Funcionarios;

#region TODOs
//TODO Refatorar datePicker
//TODO Adicionar novos campos
//TODO Reestruturar interface
#endregion

public partial class CadastroFuncionarioForm : Form
{
    private readonly FuncionarioController _funcionarioController;
    public CadastroFuncionarioForm(FuncionarioController funcionarioController)
    {
        InitializeComponent();
        _funcionarioController = funcionarioController;
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

                var funcionario = new Funcionario()
                {
                    Nome_Completo = txtNome.Text,
                    Rg = txtRg.Text,
                    Cpf = txtCpf.Text,
                    Email = txtEmail.Text,
                    Telefone = txtTelefone.Text,
                    Endereco = endereco.ToString(),
                    Data_Admissao = dateDataAdmissao.Value,
                };

                if (await _funcionarioController.Create(funcionario, endereco))
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                    this.Close();
                }

                else
                {
                    var funcionarioValidator = new FuncionarioValidator();
                    var funcionarioValidationResult = await funcionarioValidator.ValidateAsync(funcionario);
                    var enderecoValidator = new EnderecoValidator();
                    var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);

                    MessageBox.Show("Cadastro de Funcionário inválido!");

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

    private void CadastroFuncionarioForm_Load(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;
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
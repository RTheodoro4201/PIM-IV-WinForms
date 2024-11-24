using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Funcionarios;

public partial class AlteraFuncionarioForm : Form
{
    private readonly FuncionarioController _funcionarioController;
    private readonly int _funcionarioId;
    private Funcionario _funcionario;

    public AlteraFuncionarioForm(FuncionarioController funcionarioController, int funcionarioId)
    {
        InitializeComponent();
        _funcionarioController = funcionarioController;
        _funcionarioId = funcionarioId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void AlteraFuncionarioForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var funcionario = await _funcionarioController.SearchFuncionario(_funcionarioId);
        if (funcionario != null)
        {
            _funcionario = funcionario;
            var endereco = Endereco.ToEndereco(funcionario.Endereco);

            PopulaCampos(endereco, _funcionario);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste cliente! Tente novamente mais tarde.");
            Close();
        }
    }

    private void PopulaCampos(Endereco endereco, Funcionario funcionario)
    {
        txtId.Text = funcionario.Id_Funcionario.ToString();
        txtNome.Text = funcionario.Nome_Completo;
        txtCargo.Text = funcionario.Cargo;
        txtRg.Text = funcionario.Rg;
        txtCpf.Text = funcionario.Cpf;
        txtEmail.Text = funcionario.Email;
        txtTelefone.Text = funcionario.Telefone;
        txtLogradouro.Text = endereco.Logradouro;
        txtNumero.Text = endereco.Numero;
        txtComplemento.Text = endereco.Complemento;
        txtBairro.Text = endereco.Bairro;
        txtCidade.Text = endereco.Cidade;
        cbUf.Text = endereco.Uf;
        txtCep.Text = endereco.Cep;
        txtSalario.Text = funcionario.Salario.ToString("C");
        dateDataAdmissao.Value = funcionario.Data_Admissao.Date;
    }

    #region Métodos de Verificação

    private void txtSalario_Leave(object sender, EventArgs e)
    {
        try
        {
            if (decimal.TryParse(txtSalario.Text, out decimal salario) || txtSalario.Text.Contains("R$"))
            {
                txtSalario.Text = "";
                txtSalario.Text = salario.ToString("C");
            }

            else if (!decimal.TryParse(txtSalario.Text, out salario) && !txtSalario.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Insira apenas números decimais no campo 'Salário'.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao exibir o valor do campo salário.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            MessageBox.Show("Erro: " + exception.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dateDataNascimento_ValueChanged(object sender, EventArgs e)
    {
        if (dateDataAdmissao.Value > DateTime.Now)
        {
            MessageBox.Show("Data de admissão não pode ser maior do que a data atual!");
            dateDataAdmissao.Value = DateTime.Now;
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
                Cidade = txtCidade.Text,
                Uf = cbUf.Text,
                Cep = txtCep.Text
            };

            var funcionario = new Funcionario
            {
                Id_Funcionario = int.Parse(txtId.Text),
                Nome_Completo = txtNome.Text,
                Cargo = txtCargo.Text,
                Rg = txtRg.Text.Replace(".", "").Replace("-", "").Replace(" ", ""),
                Cpf = txtCpf.Text.Replace(".", "").Replace("-", ""),
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text.Replace("(", "").Replace("-", "").Replace(" ", "").Replace(")", ""),
                Endereco = endereco.ToString(),
                Salario = decimal.Parse(txtSalario.Text),
                Data_Admissao = dateDataAdmissao.Value
            };

            if (await _funcionarioController.Edit(funcionario, endereco))
            {
                MessageBox.Show("Funcionário alterado com sucesso!");
                Close();
            }

            else
            {
                var funcionarioValidator = new FuncionarioValidator();
                var funcionarioValidationResult = await funcionarioValidator.ValidateAsync(funcionario);
                var enderecoValidator = new EnderecoValidator();
                var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);
                MessageBox.Show("Dados de alteração inválidos!");

                foreach (var erro in funcionarioValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);

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
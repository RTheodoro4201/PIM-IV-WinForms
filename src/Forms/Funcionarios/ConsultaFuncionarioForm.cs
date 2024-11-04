using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Funcionarios;

public partial class ConsultaFuncionarioForm : Form
{
    private readonly FuncionarioController _funcionarioController;
    private readonly int _funcionarioId;
    private Funcionario _funcionario;

    public ConsultaFuncionarioForm(FuncionarioController funcionarioController, int funcionarioId)
    {
        InitializeComponent();
        _funcionarioController = funcionarioController;
        _funcionarioId = funcionarioId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ConsultaFuncionarioForm_Load(object sender, EventArgs e)
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
            MessageBox.Show("Não foi possível carregar os dados deste funcionário! Tente novamente mais tarde.");
            Close();
        }
    }

    private void PopulaCampos(Endereco endereco, Funcionario funcionario)
    {
        txtIdFuncionario.Text = funcionario.Id_Funcionario.ToString();
        txtIdFuncionario.ReadOnly = true;
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
        txtSalario.Text = funcionario.Salario.ToString(CultureInfo.CurrentCulture);
        dateDataAdmissao.Value = funcionario.Data_Admissao.Date;
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
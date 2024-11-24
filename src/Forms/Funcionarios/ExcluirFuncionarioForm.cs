using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Funcionarios;

public partial class ExcluirFuncionarioForm : Form
{
    private readonly FuncionarioController _funcionarioController;
    private readonly int _funcionarioId;
    private Funcionario _funcionario;

    public ExcluirFuncionarioForm(FuncionarioController funcionarioController, int funcionarioId)
    {
        InitializeComponent();
        _funcionarioController = funcionarioController;
        _funcionarioId = funcionarioId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ExcluirFuncionarioForm_Load(object sender, EventArgs e)
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
                    $"Deseja excluir o funcionário nº{_funcionarioId} '{_funcionario.Nome_Completo}'? Esta ação não pode ser desfeita.",
                    "Excluir Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                await _funcionarioController.Delete(_funcionarioId);
                MessageBox.Show("Funcionário excluído com sucesso!");
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar excluir o funcionário!");
            MessageBox.Show(exception.Message);
            throw;
        }
    }
}
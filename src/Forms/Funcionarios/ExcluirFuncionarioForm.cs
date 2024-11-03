using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Funcionarios;

#region TODOs
//TODO Reestruturar interface
#endregion

public partial class ExcluirFuncionarioForm : Form
{
    private readonly FuncionarioController _funcionarioController;
    private Funcionario _funcionario;
    private readonly int _funcionarioId;

    public ExcluirFuncionarioForm(FuncionarioController funcionarioController, int funcionarioId)
    {
        InitializeComponent();
        _funcionarioController = funcionarioController;
        _funcionarioId = funcionarioId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;
    }

    private async void ExcluirFuncionarioForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var funcionario = await _funcionarioController.SearchFuncionario(_funcionarioId);
        if (funcionario != null)
        {
            _funcionario = funcionario;
            var endereco = Endereco.ToEndereco(funcionario.Endereco);

            PopulaCampos(endereco,_funcionario);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste funcionario! Tente novamente mais tarde.");
            this.Close();
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

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            DialogResult resultado = MessageBox.Show($"Deseja excluir o funcionario {_funcionario.Nome_Completo}? Esta ação não pode ser desfeita.", "Excluir Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                await _funcionarioController.Delete(_funcionarioId);
                MessageBox.Show("Funcionario excluído com sucesso!");
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar excluir o funcionario!");
            MessageBox.Show(exception.Message);
            throw;
        }
    }
}
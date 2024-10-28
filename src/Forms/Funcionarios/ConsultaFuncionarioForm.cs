using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Funcionarios;

public partial class ConsultaFuncionarioForm : Form
{
    private readonly FuncionarioController _funcionarioController;
    private Funcionario _funcionario;
    private readonly int _funcionarioId;

    public ConsultaFuncionarioForm(FuncionarioController funcionarioController, int funcionarioId)
    {
        InitializeComponent();
        _funcionarioController = funcionarioController;
        _funcionarioId = funcionarioId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;
    }

    private async void ConsultaFuncionarioForm_Load(object sender, EventArgs e)
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
            MessageBox.Show("Não foi possível carregar os dados deste funcionário! Tente novamente mais tarde.");
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

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

}
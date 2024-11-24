using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Fornecedores;

public partial class CadastroFornecedorForm : Form
{
    private readonly FornecedorController _fornecedorController;
    private readonly string _tipoFornecedor;

    public CadastroFornecedorForm(FornecedorController fornecedorController, string tipoFornecedor)
    {
        InitializeComponent();
        _fornecedorController = fornecedorController;
        _tipoFornecedor = tipoFornecedor;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void CadastroFornecedorForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        VerificarTipoFornecedor(this, null);
    }

    #region Métodos de verificação

    private void VerificarTipoFornecedor(object sender, EventArgs e)
    {
        if (_tipoFornecedor == "Geral")
        {
            txtTipo.ReadOnly = false;
        }

        if (_tipoFornecedor == "Jurídico" || txtTipo.Text == "Jurídico")
        {
            txtTipo.Text = "Jurídico";
            txtDocumento.Mask = "99.999.999/9999-99";
            dateDataInicial.Value = DateTime.Now;
        }

        if (_tipoFornecedor == "Físico" || txtTipo.Text == "Físico")
        {
            txtTipo.Text = "Físico";
            txtDocumento.Mask = "999.999.999-99";
            dateDataInicial.Value = DateTime.Now.AddYears(-18);
        }
    }

    private void dateDataInicial_ValueChanged(object sender, EventArgs e)
    {
        if (txtTipo.Text == "Físico" && dateDataInicial.Value > DateTime.Now.AddYears(-18))
        {
            MessageBox.Show("Data de nascimento inválida!");
            dateDataInicial.Value = DateTime.Now.AddYears(-18);
        }

        if (txtTipo.Text == "Jurídico" && dateDataInicial.Value > DateTime.Now)
        {
            MessageBox.Show("Data de inicial (fundação/nascimento) não pode ser maior do que a data atual!");
            dateDataInicial.Value = DateTime.Now;
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

            var fornecedor = new Fornecedor
            {
                Nome = txtNome.Text,
                Tipo = txtTipo.Text,
                Documento = txtDocumento.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Endereco = endereco.ToString(),
                Data_Inicial = dateDataInicial.Value
            };

            if (await _fornecedorController.Create(fornecedor, endereco))
            {
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                Close();
            }

            else
            {
                var fornecedorValidator = new FornecedorValidator();
                var fornecedorValidationResult = await fornecedorValidator.ValidateAsync(fornecedor);
                var enderecoValidator = new EnderecoValidator();
                var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);

                MessageBox.Show("Cadastro de Fornecedor inválido!");

                foreach (var erro in fornecedorValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);

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
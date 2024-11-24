using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Fornecedores;

public partial class AlteraFornecedorForm : Form
{
    private readonly FornecedorController _fornecedorController;
    private readonly int _fornecedorId;

    public AlteraFornecedorForm(FornecedorController fornecedorController, int fornecedorId)
    {
        InitializeComponent();
        _fornecedorController = fornecedorController;
        _fornecedorId = fornecedorId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void AlteraFornecedorForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var fornecedor = await _fornecedorController.SearchFornecedor(_fornecedorId);
        if (fornecedor != null)
        {
            var endereco = Endereco.ToEndereco(fornecedor.Endereco);

            PopulaCampos(endereco, fornecedor);
            VerificarTipoFornecedor(this, null);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste fornecedor! Tente novamente mais tarde.");
            Close();
        }
    }

    private void VerificarTipoFornecedor(object sender, EventArgs e)
    {
        if (txtTipo.Text == "Jurídico")
        {
            txtDocumento.Mask = "99.999.999/9999-99";
        }

        if (txtTipo.Text == "Físico")
        {
            txtDocumento.Mask = "999.999.999-99";
        }
    }

    private void PopulaCampos(Endereco endereco, Fornecedor fornecedor)
    {
        txtId.Text = fornecedor.Id_Fornecedor.ToString();
        txtNome.Text = fornecedor.Nome;
        txtTipo.Text = fornecedor.Tipo;
        txtDocumento.Text = fornecedor.Documento;
        txtEmail.Text = fornecedor.Email;
        txtTelefone.Text = fornecedor.Telefone;
        txtLogradouro.Text = endereco.Logradouro;
        txtNumero.Text = endereco.Numero;
        txtComplemento.Text = endereco.Complemento;
        txtBairro.Text = endereco.Bairro;
        txtCidade.Text = endereco.Cidade;
        cbUf.Text = endereco.Uf;
        txtCep.Text = endereco.Cep;
        dateDataInicial.Value = fornecedor.Data_Inicial.Date;
    }

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
                Id_Fornecedor = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Tipo = txtTipo.Text,
                Documento = txtDocumento.Text.Replace(".", "").Replace("-", "").Replace("/", ""),
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text.Replace("(", "").Replace("-", "").Replace(" ", "").Replace(")", ""),
                Endereco = endereco.ToString(),
                Data_Inicial = dateDataInicial.Value
            };

            if (await _fornecedorController.Edit(fornecedor, endereco))
            {
                MessageBox.Show("Fornecedor alterado com sucesso!");
                Close();
            }

            else
            {
                var fornecedorValidator = new FornecedorValidator();
                var fornecedorValidationResult = await fornecedorValidator.ValidateAsync(fornecedor);
                var enderecoValidator = new EnderecoValidator();
                var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);
                MessageBox.Show("Dados de alteração inválidos!");

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

    private void dateDataInicial_ValueChanged(object sender, EventArgs e)
    {
        if (dateDataInicial.Value > DateTime.Now)
        {
            MessageBox.Show("Data de inicial (fundação/nascimento) não pode ser maior do que a data atual!");
            dateDataInicial.Value = DateTime.Now;
        }

        if (txtTipo.Text == "Físico" && dateDataInicial.Value > DateTime.Now.AddYears(-18))
        {
            MessageBox.Show("Data de nascimento inválida!");
            dateDataInicial.Value = DateTime.Now.AddYears(-18);
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
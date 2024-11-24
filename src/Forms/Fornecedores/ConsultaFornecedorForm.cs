using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Fornecedores;

public partial class ConsultaFornecedorForm : Form
{
    private readonly FornecedorController _fornecedorController;
    private readonly int _fornecedorId;
    private Fornecedor _fornecedor;

    public ConsultaFornecedorForm(FornecedorController fornecedorController, int fornecedorId)
    {
        InitializeComponent();
        _fornecedorController = fornecedorController;
        _fornecedorId = fornecedorId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ConsultaFornecedorForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var fornecedor = await _fornecedorController.SearchFornecedor(_fornecedorId);
        if (fornecedor != null)
        {
            _fornecedor = fornecedor;
            var endereco = Endereco.ToEndereco(fornecedor.Endereco);

            PopulaCampos(endereco, _fornecedor);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste fornecedor! Tente novamente mais tarde.");
            Close();
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

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
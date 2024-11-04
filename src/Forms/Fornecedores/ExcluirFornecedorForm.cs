using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Fornecedores;

public partial class ExcluirFornecedorForm : Form
{
    private readonly FornecedorController _fornecedorController;
    private readonly int _fornecedorId;
    private Fornecedor _fornecedor;

    public ExcluirFornecedorForm(FornecedorController fornecedorController, int fornecedorId)
    {
        InitializeComponent();
        _fornecedorController = fornecedorController;
        _fornecedorId = fornecedorId;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ExcluirFornecedorForm_Load(object sender, EventArgs e)
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
        txtIdFornecedor.Text = fornecedor.Id_Fornecedor.ToString();
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

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            var resultado =
                MessageBox.Show($"Deseja excluir o fornecedor {_fornecedor.Nome}? Esta ação não pode ser desfeita.",
                    "Excluir Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                await _fornecedorController.Delete(_fornecedorId);
                MessageBox.Show("Fornecedor excluído com sucesso!");
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar excluir o fornecedor!");
            MessageBox.Show(exception.Message);
            throw;
        }
    }
}
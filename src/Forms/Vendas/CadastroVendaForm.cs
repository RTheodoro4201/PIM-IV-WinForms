using System;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Vendas;

public partial class CadastroVendaForm : Form
{
    private readonly VendaController _vendaController;

    public CadastroVendaForm(VendaController vendaController)
    {
        InitializeComponent();
        _vendaController = vendaController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void CadastroVendaForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        dateDataVenda.Value = DateTime.Now;
    }

    #region Métodos de verificação

    private async void txtIdCliente_Leave(object sender, EventArgs e)
    {
        try
        {
            if (int.TryParse(txtIdCliente.Text, out int idCliente))
            {
                var cliente = await _vendaController.SearchCliente(idCliente);
                txtNomeCliente.Text = cliente.Nome_Completo;
            }

            else if (!int.TryParse(txtIdCliente.Text, out idCliente) && !txtIdCliente.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Insira apenas números inteiros no campo 'Código do Cliente'", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao recuperar o cliente.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Erro: " + exception.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void txtIdProduto_Leave(object sender, EventArgs e)
    {
        try
        {
            if (int.TryParse(txtIdProduto.Text, out int idProduto))
            {
                var produto = await _vendaController.SearchProduto(idProduto);
                txtNomeProduto.Text = produto.Nome;
                txtDescricaoProduto.Text = produto.Descricao;
            }

            else if (!int.TryParse(txtIdCliente.Text, out idProduto) && !txtIdProduto.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Insira apenas números inteiros no campo 'Código do Produto'", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao recuperar o produto.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Erro: " + exception.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void txtValorUnitario_Leave(object sender, EventArgs e)
    {
        try
        {
            if (decimal.TryParse(txtValorUnitario.Text, out decimal valorUnitario) &&
                int.TryParse(txtQuantidadeVendida.Text, out int quantidadeVendida) &&
                quantidadeVendida >= 1)
            {
                var valorTotal = valorUnitario * quantidadeVendida;
                txtValorUnitario.Text = valorUnitario.ToString("C");
                txtValorTotal.Text = valorTotal.ToString("C");
            }

            else if (txtQuantidadeVendida.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Preencha o campo 'Quantidade Vendida' antes de inserir o valor unitário.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if(!decimal.TryParse(txtValorUnitario.Text, out valorUnitario) && !txtValorUnitario.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Insira apenas números decimais no campo 'Valor Unitário'.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar calcular o valor total da venda.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            MessageBox.Show("Erro: " + exception.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dateDataVenda_Leave(object sender, EventArgs e)
    {
        if (dateDataVenda.Value > DateTime.Now)
        {
            MessageBox.Show("A data de venda não pode ser futura.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            dateDataVenda.Value = DateTime.Now;
        }
    }

    #endregion

    #region Métodos de Click

    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            var venda = new Venda
            {
                Id_Cliente = int.Parse(txtIdCliente.Text),
                Nome_Cliente = txtNomeCliente.Text,
                Data_Venda = dateDataVenda.Value,
                Id_Produto = int.Parse(txtIdProduto.Text),
                Nome_Produto = txtNomeProduto.Text,
                Descricao_Produto = txtDescricaoProduto.Text,
                Quantidade_Vendida = int.Parse(txtQuantidadeVendida.Text),
                Valor_Unitario = decimal.Parse(txtValorUnitario.Text.Trim('R', '$')),
                Valor_Total = decimal.Parse(txtValorTotal.Text.Trim('R', '$'))
            };

            if (await _vendaController.Create(venda))
            {
                MessageBox.Show("Venda cadastrada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            else
            {
                var vendaValidator = new VendaValidator();
                var vendaValidationResult = await vendaValidator.ValidateAsync(venda);

                MessageBox.Show("Cadastro de Venda inválido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                foreach (var erro in vendaValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente mais tarde.");
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}
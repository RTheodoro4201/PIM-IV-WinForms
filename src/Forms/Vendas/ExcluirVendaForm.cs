using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Vendas;

public partial class ExcluirVendaForm : Form
{
    private readonly VendaController _vendaController;
    private readonly int _idVenda;
    private Venda _venda;

    public ExcluirVendaForm(VendaController vendaController, int idVenda)
    {
        InitializeComponent();
        _vendaController = vendaController;
        _idVenda = idVenda;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ExcluirVendaForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        dateDataVenda.Value = DateTime.Now;
        
        var venda = await _vendaController.SearchVenda(_idVenda);
        if (venda != null)
        {
            txtId.Text = _idVenda.ToString();
            _venda = venda;

            PopulaCampos(_venda);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados desta venda! Tente novamente mais tarde.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }
    
    private void PopulaCampos(Venda venda)
    {
        txtIdProduto.Text = venda.Id_Produto.ToString();
        txtNomeProduto.Text = venda.Nome_Produto;
        txtDescricaoProduto.Text = venda.Descricao_Produto;
        txtQuantidadeVendida.Text = venda.Quantidade_Vendida.ToString();
        txtValorUnitario.Text = venda.Valor_Unitario.ToString("C");
        txtIdCliente.Text = venda.Id_Cliente.ToString();
        txtValorTotal.Text = venda.Valor_Total.ToString("C");
        txtNomeCliente.Text = venda.Nome_Cliente;
        dateDataVenda.Value = venda.Data_Venda;
    }

    #region Métodos de Click
    
    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            var resultado =
                MessageBox.Show($"Deseja excluir a Venda nº{_idVenda}? \nEsta ação não pode ser desfeita.",
                    "Excluir Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                await _vendaController.Delete(_idVenda);
                MessageBox.Show("Venda excluída com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar excluir a Venda!");
            MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }
    
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}
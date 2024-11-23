using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Vendas;

public partial class ConsultaVendaForm : Form
{
    private readonly VendaController _vendaController;
    private readonly int _idVenda;
    private Venda _venda;

    public ConsultaVendaForm(VendaController vendaController, int idVenda)
    {
        InitializeComponent();
        _vendaController = vendaController;
        _idVenda = idVenda;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ConsultaVendaForm_Load(object sender, EventArgs e)
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

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}
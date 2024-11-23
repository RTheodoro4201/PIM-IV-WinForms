using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Forms.Clientes_Fisicos;
using PIM_IV_Forms.Forms.Compras;
using PIM_IV_Forms.Forms.Culturas;
using PIM_IV_Forms.Forms.Fornecedores;
using PIM_IV_Forms.Forms.Funcionarios;
using PIM_IV_Forms.Forms.Insumos;
using PIM_IV_Forms.Forms.Produtos;
using PIM_IV_Forms.Forms.Vendas;

namespace PIM_IV_Forms.Forms;

public partial class MainForm : Form
{
    private readonly ClienteFisicoController _clienteFisicoController;
    private readonly FuncionarioController _funcionarioController;
    private readonly FornecedorController _fornecedorController;
    private readonly CulturaController _culturaController;
    private readonly ProdutoController _produtoController;
    private readonly InsumoController _insumoController;
    private readonly CompraController _compraController;
    private readonly VendaController _vendaController;

    public MainForm(ClienteFisicoController clienteFisicoController, FuncionarioController funcionarioController,
        FornecedorController fornecedorController, CulturaController culturaController,
        ProdutoController produtoController, InsumoController insumoController,
        CompraController compraController, VendaController vendaController)
    {
        InitializeComponent();
        _clienteFisicoController = clienteFisicoController;
        _funcionarioController = funcionarioController;
        _fornecedorController = fornecedorController;
        _culturaController = culturaController;
        _produtoController = produtoController;
        _insumoController = insumoController;
        _compraController = compraController;
        _vendaController = vendaController;
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void btnClienteFisico_Click(object sender, EventArgs e)
    {
        if (_clienteFisicoController != null)
        {
            var clienteFisicoForm = new ClienteFisicoForm(_clienteFisicoController);
            clienteFisicoForm.Show();
        }
    }

    private void btnFuncionario_Click(object sender, EventArgs e)
    {
        if (_funcionarioController != null)
        {
            var funcionarioForm = new FuncionarioForm(_funcionarioController);
            funcionarioForm.Show();
        }
    }

    private void btnFornecedorFisico_Click(object sender, EventArgs e)
    {
        if (_fornecedorController != null)
        {
            var fornecedorForm = new FornecedorForm(_fornecedorController, "Físico");
            fornecedorForm.Show();
        }
    }

    private void btnFornecedorJurídico_Click(object sender, EventArgs e)
    {
        if (_fornecedorController != null)
        {
            var fornecedorForm = new FornecedorForm(_fornecedorController, "Jurídico");
            fornecedorForm.Show();
        }
    }

    private void btnFornecedor_Click(object sender, EventArgs e)
    {
        if (_fornecedorController != null)
        {
            var fornecedorForm = new FornecedorForm(_fornecedorController, "Geral");
            fornecedorForm.Show();
        }
    }

    private void btnCultura_Click(object sender, EventArgs e)
    {
        if (_culturaController != null)
        {
            var culturaForm = new CulturaForm(_culturaController);
            culturaForm.Show();
        }
    }

    private void btnProduto_Click(object sender, EventArgs e)
    {
        if (_produtoController != null)
        {
            var produtoForm = new ProdutoForm(_produtoController);
            produtoForm.Show();
        }
    }

    private void btnInsumo_Click(object sender, EventArgs e)
    {
        if (_insumoController != null)
        {
            var insumoForm = new InsumoForm(_insumoController);
            insumoForm.Show();
        }
    }

    private void btnCompras_Click(object sender, EventArgs e)
    {
        if (_compraController != null)
        {
            var compraForm = new CompraForm(_compraController);
            compraForm.Show();
        }
    }

    private void btnVendas_Click(object sender, EventArgs e)
    {
        if (_vendaController != null)
        {
            var vendaForm = new VendaForm(_vendaController);
            vendaForm.Show();
        }
    }
}
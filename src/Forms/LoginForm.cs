using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms;

public partial class LoginForm : Form
{
    private readonly ClienteController _clienteController;
    private readonly FuncionarioController _funcionarioController;
    private readonly FornecedorController _fornecedorController;
    private readonly CulturaController _culturaController;
    private readonly ProdutoController _produtoController;
    private readonly InsumoController _insumoController;
    private readonly CompraController _compraController;
    private readonly VendaController _vendaController;
    private readonly UsuarioController _usuarioController;

    public LoginForm(ClienteController clienteController, FuncionarioController funcionarioController,
        FornecedorController fornecedorController, CulturaController culturaController,
        ProdutoController produtoController, InsumoController insumoController,
        CompraController compraController, VendaController vendaController,
        UsuarioController usuarioController)
    {
        InitializeComponent();
        _clienteController = clienteController;
        _funcionarioController = funcionarioController;
        _fornecedorController = fornecedorController;
        _culturaController = culturaController;
        _produtoController = produtoController;
        _insumoController = insumoController;
        _compraController = compraController;
        _vendaController = vendaController;
        _usuarioController = usuarioController;
    }

    private void chkRevelar_CheckedChanged(object sender, EventArgs e)
    {
        if (chkRevelar.Checked)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        else
        {
            txtSenha.UseSystemPasswordChar = true;
        }
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private async void btnLogar_Click(object sender, EventArgs e)
    {
        try
        {
            var usuario = await _usuarioController.TestUsuario(txtLogin.Text, txtSenha.Text);

            if (usuario.Login == txtLogin.Text && usuario.Senha == txtSenha.Text)
            {
                Hide();
                var mainForm = new MainForm(_clienteController, _funcionarioController, _fornecedorController,
                    _culturaController, _produtoController, _insumoController,
                    _compraController, _vendaController, _usuarioController);

                mainForm.Closed += (s, args) => Close();
                mainForm.Show();
            }

            else
            {
                MessageBox.Show("Login e/ou Senha incorretos, tente novamente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar se conectar ao aplicativo. Tente novamente.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Erro: " + exception.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
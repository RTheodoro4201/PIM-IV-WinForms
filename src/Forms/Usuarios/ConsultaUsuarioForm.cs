using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Usuarios;

public partial class ConsultaUsuarioForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly int _idUsuario;

    public ConsultaUsuarioForm(UsuarioController usuarioController, int idUsuario)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _idUsuario = idUsuario;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ConsultaUsuarioForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var usuario = await _usuarioController.SearchUsuario(_idUsuario);
        if (usuario != null)
        {
            txtId.Text = _idUsuario.ToString();
            PopulaCampos(usuario);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste usuário! Tente novamente mais tarde.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }

    private void PopulaCampos(Usuario usuario)
    {
        txtLogin.Text = usuario.Login;
        txtCargo.Text = usuario.Cargo;
        txtSenha.Text = usuario.Senha;
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

    #region Métodos de Click

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}
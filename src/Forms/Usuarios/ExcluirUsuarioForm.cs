using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Usuarios;

public partial class ExcluirUsuarioForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly int _idUsuario;
    private Usuario _usuario;

    public ExcluirUsuarioForm(UsuarioController usuarioController, int idUsuario)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _idUsuario = idUsuario;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ExcluirUsuarioForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var usuario = await _usuarioController.SearchUsuario(_idUsuario);
        if (usuario != null)
        {
            txtId.Text = _idUsuario.ToString();
            _usuario = usuario;
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

    #region Métodos de Click

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            var resultado =
                MessageBox.Show($"Deseja excluir a usuário nº{_idUsuario} '{_usuario.Login}'? \nEsta ação não pode ser desfeita.",
                    "Excluir Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                await _usuarioController.Delete(_idUsuario);
                MessageBox.Show("Usuário excluído com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar excluir o usuário!");
            MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }

    #endregion
}
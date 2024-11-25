using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Usuarios;

public partial class AlteraUsuarioForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly int _idUsuario;

    public AlteraUsuarioForm(UsuarioController usuarioController, int idUsuario)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _idUsuario = idUsuario;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void AlteraUsuarioForm_Load(object sender, EventArgs e)
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


    #region Métodos de Click

    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            var usuario = new Usuario
            {
                Id_Usuario = _idUsuario,
                Login = txtLogin.Text,
                Cargo = txtCargo.Text,
                Senha = txtSenha.Text
            };

            if (await _usuarioController.Edit(usuario))
            {
                MessageBox.Show("Usuário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            else
            {
                var usuarioValidator = new UsuarioValidator();
                var usuarioValidationResult = await usuarioValidator.ValidateAsync(usuario);

                MessageBox.Show("Alteração de Usuário inválida!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                foreach (var erro in usuarioValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);
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
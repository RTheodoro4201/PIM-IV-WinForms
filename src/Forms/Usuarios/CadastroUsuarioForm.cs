using System;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Usuarios;

public partial class CadastroUsuarioForm : Form
{
    private readonly UsuarioController _usuarioController;

    public CadastroUsuarioForm(UsuarioController usuarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void CadastroUsuarioForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
    }

    #region Métodos de Click

    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            var usuario = new Usuario
            {
                Login = txtLogin.Text,
                Cargo = txtCargo.Text,
                Senha = txtSenha.Text
            };

            if (await _usuarioController.Create(usuario))
            {
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            else
            {
                var usuarioValidator = new UsuarioValidator();
                var usuarioValidationResult = await usuarioValidator.ValidateAsync(usuario);

                MessageBox.Show("Cadastro de Usuário inválido!", "Erro",
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
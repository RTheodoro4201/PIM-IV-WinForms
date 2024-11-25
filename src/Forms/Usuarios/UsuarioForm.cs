using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms.Usuarios;

public partial class UsuarioForm : Form
{
    private readonly UsuarioController _usuarioController;

    public UsuarioForm(UsuarioController usuarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void UsuarioForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);

        await CarregarGrid();
    }

    private async Task CarregarGrid()
    {
        try
        {
            var usuarios = await _usuarioController.Index();

            if (usuarios.Any())
            {
                dataGridUsuarios.DataSource = usuarios;
                dataGridUsuarios.AutoGenerateColumns = true;
                dataGridUsuarios.Columns[0].HeaderText = "Código";
                dataGridUsuarios.Columns.RemoveAt(3);
                dataGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro no servidor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        catch (Exception)
        {
            // Exibir uma mensagem de erro genérica para o usuário
            MessageBox.Show(
                "Ocorreu um erro ao carregar os dados dos usuários. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #region Métodos de verificação

    private bool VerificarSelecao()
    {
        if (dataGridUsuarios.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione um usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }

    #endregion

    #region Métodos de Click

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroUsuarioForm = new CadastroUsuarioForm(_usuarioController);
        cadastroUsuarioForm.ShowDialog();

        await CarregarGrid();
    }

    private async void btnAlterar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var usuarioId = Convert.ToInt32(dataGridUsuarios.SelectedRows[0].Cells["id_usuario"].Value);

            var alteraUsuarioForm = new AlteraUsuarioForm(_usuarioController, usuarioId);
            alteraUsuarioForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var usuarioId = Convert.ToInt32(dataGridUsuarios.SelectedRows[0].Cells["id_usuario"].Value);
            var consultaUsuarioForm = new ConsultaUsuarioForm(_usuarioController, usuarioId);
            consultaUsuarioForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var usuarioId = Convert.ToInt32(dataGridUsuarios.SelectedRows[0].Cells["id_usuario"].Value);
            var excluirUsuarioForm = new ExcluirUsuarioForm(_usuarioController, usuarioId);
            excluirUsuarioForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

}
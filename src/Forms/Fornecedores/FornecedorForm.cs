using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;

namespace PIM_IV_Forms.Forms.Fornecedores;

public partial class FornecedorForm : Form
{
    private readonly FornecedorController _fornecedorController;
    private readonly string _tipoFornecedor;

    public FornecedorForm(FornecedorController fornecedorController, string tipoFornecedor)
    {
        InitializeComponent();
        _fornecedorController = fornecedorController;
        _tipoFornecedor = tipoFornecedor;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void FornecedorForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);

        await VerificarTipoGrid();
    }

    #region Métodos de carregamento de Grid

    private async Task CarregarGridFisico()
    {
        try
        {
            var fornecedores = await _fornecedorController.IndexFisico();

            if (fornecedores.Any())
            {
                dataGridFornecedores.DataSource = fornecedores;
                dataGridFornecedores.AutoGenerateColumns = true;
                dataGridFornecedores.Columns[0].HeaderText = "Id";
                dataGridFornecedores.Columns[1].HeaderText = "Nome";
                dataGridFornecedores.Columns[2].HeaderText = "CPF";
                dataGridFornecedores.Columns[5].HeaderText = "Endereço";
                dataGridFornecedores.Columns[7].HeaderText = "Data de Nascimento";
                dataGridFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro no servidor.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        catch (Exception)
        {
            // Exibir uma mensagem de erro genérica para o usuário
            MessageBox.Show(
                "Ocorreu um erro ao carregar os dados dos fornecedores. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task CarregarGridJuridico()
    {
        try
        {
            var fornecedores = await _fornecedorController.IndexJuridico();

            if (fornecedores.Any())
            {
                dataGridFornecedores.DataSource = fornecedores;
                dataGridFornecedores.AutoGenerateColumns = true;
                dataGridFornecedores.Columns[0].HeaderText = "Id";
                dataGridFornecedores.Columns[1].HeaderText = "Nome Fantasia/Razão Social";
                dataGridFornecedores.Columns[2].HeaderText = "CNPJ";
                dataGridFornecedores.Columns[5].HeaderText = "Endereço";
                dataGridFornecedores.Columns[7].HeaderText = "Data de Fundação";
                dataGridFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro no servidor.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        catch (Exception)
        {
            // Exibir uma mensagem de erro genérica para o usuário
            MessageBox.Show(
                "Ocorreu um erro ao carregar os dados dos fornecedores. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task CarregarGridGeral()
    {
        try
        {
            var fornecedores = await _fornecedorController.IndexAll();

            if (fornecedores.Any())
            {
                dataGridFornecedores.DataSource = fornecedores;
                dataGridFornecedores.AutoGenerateColumns = true;
                dataGridFornecedores.Columns[0].HeaderText = "Id";
                dataGridFornecedores.Columns[1].HeaderText = "Nome/Razão Social";
                dataGridFornecedores.Columns[5].HeaderText = "Endereço";
                dataGridFornecedores.Columns[7].HeaderText = "Data de Nascimento/Fundação";
                dataGridFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro no servidor.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        catch (Exception)
        {
            // Exibir uma mensagem de erro genérica para o usuário
            MessageBox.Show(
                "Ocorreu um erro ao carregar os dados dos fornecedores. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #endregion

    #region Métodos de verificação

    private bool VerificarSelecao()
    {
        if (dataGridFornecedores.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione um fornecedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }

    private async Task VerificarTipoGrid()
    {
        if (_tipoFornecedor == "Físico")
        {
            await CarregarGridFisico();
        }

        if (_tipoFornecedor == "Jurídico")
        {
            await CarregarGridJuridico();
        }

        if (_tipoFornecedor == "Geral")
        {
            await CarregarGridGeral();
        }
    }

    #endregion

    #region Métodos de Click

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroFornecedorForm = new CadastroFornecedorForm(_fornecedorController, _tipoFornecedor);
        cadastroFornecedorForm.ShowDialog();

        await VerificarTipoGrid();
    }

    private async void btnAlterar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var fornecedorId =
                Convert.ToInt32(dataGridFornecedores.SelectedRows[0].Cells["id_fornecedor"].Value);

            var alteraFornecedorForm = new AlteraFornecedorForm(_fornecedorController, fornecedorId);
            alteraFornecedorForm.ShowDialog();

            await VerificarTipoGrid();
        }
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var fornecedorId = Convert.ToInt32(dataGridFornecedores.SelectedRows[0].Cells["id_fornecedor"].Value);
            var consultaFornecedorForm = new ConsultaFornecedorForm(_fornecedorController, fornecedorId);
            consultaFornecedorForm.ShowDialog();

            await VerificarTipoGrid();
        }
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var fornecedorId = Convert.ToInt32(dataGridFornecedores.SelectedRows[0].Cells["id_fornecedor"].Value);
            var excluirFornecedorForm = new ExcluirFornecedorForm(_fornecedorController, fornecedorId);
            excluirFornecedorForm.ShowDialog();

            await VerificarTipoGrid();
        }
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}
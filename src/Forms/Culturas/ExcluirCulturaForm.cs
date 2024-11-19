using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Culturas;

public partial class ExcluirCulturaForm : Form
{
    private readonly CulturaController _culturaController;
    private readonly int _idCultura;
    private Cultura _cultura;

    public ExcluirCulturaForm(CulturaController culturaController, int idCultura)
    {
        InitializeComponent();
        _culturaController = culturaController;
        _idCultura = idCultura;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ExcluirCulturaForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        try
        {
            var cultura = await _culturaController.SearchCultura(_idCultura);

            _cultura = cultura;
            txtId.Text = _idCultura.ToString();
            PopulaCampos(cultura);
        }
        catch (Exception exception)
        {
            MessageBox.Show("Não foi possível carregar os dados desta cultura! Tente novamente mais tarde.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }

    private void PopulaCampos(Cultura cultura)
    {
        txtNome.Text = cultura.Nome;
        dateDataPlantio.Value = cultura.Data_Plantio;
        dateColheita.Value = cultura.Data_Colheita;
        txtAreaPlantada.Text = cultura.Area_Plantada.ToString(CultureInfo.CurrentCulture);
        txtQuantidadePlantada.Text = cultura.Quantidade_Plantada.ToString();
        txtTipoSolo.Text = cultura.Tipo_Solo;
        txtTipoIrrigacao.Text = cultura.Tipo_Irrigacao;
        txtNotas.Text = cultura.Notas;
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            var resultado =
                MessageBox.Show($"Deseja excluir a cultura nº{_idCultura} '{_cultura.Nome}'? \nEsta ação não pode ser desfeita.",
                    "Excluir Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                await _culturaController.Delete(_idCultura);
                MessageBox.Show("Cultura excluída com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar excluir a cultura!");
            MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }
}
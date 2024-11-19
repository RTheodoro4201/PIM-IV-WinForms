using System;
using System.Globalization;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Forms.Culturas;

public partial class ConsultaCulturaForm : Form
{
    private readonly CulturaController _culturaController;
    private readonly int _idCultura;

    public ConsultaCulturaForm(CulturaController culturaController, int idCultura)
    {
        InitializeComponent();
        _culturaController = culturaController;
        _idCultura = idCultura;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void ConsultaCulturaForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var cultura = await _culturaController.SearchCultura(_idCultura);
        if (cultura != null)
        {
            txtId.Text = _idCultura.ToString();
            PopulaCampos(cultura);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados desta cultura! Tente novamente mais tarde.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
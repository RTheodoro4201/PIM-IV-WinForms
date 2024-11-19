using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Forms.Culturas;

public partial class CadastroCulturaForm : Form
{
    private readonly CulturaController _culturaController;

    public CadastroCulturaForm(CulturaController culturaController)
    {
        InitializeComponent();
        _culturaController = culturaController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void CadastroCulturaForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
    }

    #region Métodos de verificação
    
    private void dateDataColheita_ValueChanged(object sender, EventArgs e)
    {
        if (dateColheita.Value <= dateDataPlantio.Value)
        {
            MessageBox.Show("A data de colheita não pode ser igual ou menor que a data de plantio",
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dateColheita.Value = dateColheita.Value.AddMonths(1);
        }
    }

    #endregion

    #region Métodos de Click

    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            var cultura = new Cultura
            {
                Nome = txtNome.Text,
                Data_Plantio = dateDataPlantio.Value,
                Data_Colheita = dateColheita.Value,
                Area_Plantada = double.Parse(txtAreaPlantada.Text),
                Quantidade_Plantada = int.Parse(txtQuantidadePlantada.Text),
                Tipo_Solo = txtTipoSolo.Text,
                Tipo_Irrigacao = txtTipoIrrigacao.Text,
                Notas = txtNotas.Text
            };

            if (await _culturaController.Create(cultura))
            {
                MessageBox.Show("Cultura cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            else
            {
                var culturaValidator = new CulturaValidator();
                var culturaValidationResult = await culturaValidator.ValidateAsync(cultura);

                MessageBox.Show("Cadastro de Cultura inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                foreach (var erro in culturaValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);
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
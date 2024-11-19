using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Culturas;

partial class AlteraCulturaForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.lblTipoSolo = new System.Windows.Forms.Label();
        this.lblDataPlantio = new System.Windows.Forms.Label();
        this.lblÁreaPlantada = new System.Windows.Forms.Label();
        this.lblNome = new System.Windows.Forms.Label();
        this.dateDataPlantio = new System.Windows.Forms.DateTimePicker();
        this.txtAreaPlantada = new System.Windows.Forms.TextBox();
        this.txtTipoSolo = new System.Windows.Forms.TextBox();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.txtNome = new System.Windows.Forms.TextBox();
        this.lblDataColheita = new System.Windows.Forms.Label();
        this.dateColheita = new System.Windows.Forms.DateTimePicker();
        this.lblTipoIrrigacao = new System.Windows.Forms.Label();
        this.txtTipoIrrigacao = new System.Windows.Forms.TextBox();
        this.lblQuantidadePlantada = new System.Windows.Forms.Label();
        this.txtQuantidadePlantada = new System.Windows.Forms.TextBox();
        this.lblNotas = new System.Windows.Forms.Label();
        this.txtNotas = new System.Windows.Forms.TextBox();
        this.txtId = new System.Windows.Forms.TextBox();
        this.lblId = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // lblTipoSolo
        // 
        this.lblTipoSolo.BackColor = System.Drawing.Color.GhostWhite;
        this.lblTipoSolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTipoSolo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblTipoSolo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblTipoSolo.Location = new System.Drawing.Point(96, 195);
        this.lblTipoSolo.Name = "lblTipoSolo";
        this.lblTipoSolo.Size = new System.Drawing.Size(118, 27);
        this.lblTipoSolo.TabIndex = 64;
        this.lblTipoSolo.Text = "Tipo de Solo";
        this.lblTipoSolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblDataPlantio
        // 
        this.lblDataPlantio.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataPlantio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataPlantio.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDataPlantio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataPlantio.Location = new System.Drawing.Point(458, 87);
        this.lblDataPlantio.Name = "lblDataPlantio";
        this.lblDataPlantio.Size = new System.Drawing.Size(118, 30);
        this.lblDataPlantio.TabIndex = 42;
        this.lblDataPlantio.Text = "Data de Plantio";
        this.lblDataPlantio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblÁreaPlantada
        // 
        this.lblÁreaPlantada.BackColor = System.Drawing.Color.GhostWhite;
        this.lblÁreaPlantada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblÁreaPlantada.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblÁreaPlantada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblÁreaPlantada.Location = new System.Drawing.Point(96, 125);
        this.lblÁreaPlantada.Name = "lblÁreaPlantada";
        this.lblÁreaPlantada.Size = new System.Drawing.Size(118, 27);
        this.lblÁreaPlantada.TabIndex = 54;
        this.lblÁreaPlantada.Text = "Área Plantada";
        this.lblÁreaPlantada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblNome
        // 
        this.lblNome.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNome.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNome.Location = new System.Drawing.Point(96, 90);
        this.lblNome.Name = "lblNome";
        this.lblNome.Size = new System.Drawing.Size(118, 27);
        this.lblNome.TabIndex = 50;
        this.lblNome.Text = "Nome";
        this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dateDataPlantio
        // 
        this.dateDataPlantio.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataPlantio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataPlantio.Location = new System.Drawing.Point(580, 87);
        this.dateDataPlantio.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataPlantio.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataPlantio.Name = "dateDataPlantio";
        this.dateDataPlantio.Size = new System.Drawing.Size(132, 30);
        this.dateDataPlantio.TabIndex = 56;
        this.dateDataPlantio.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
        this.dateDataPlantio.ValueChanged += new System.EventHandler(this.dateDataColheita_ValueChanged);
        this.dateDataPlantio.Enter += new System.EventHandler(this.dateDataColheita_ValueChanged);
        this.dateDataPlantio.Leave += new System.EventHandler(this.dateDataColheita_ValueChanged);
        this.dateDataPlantio.Validated += new System.EventHandler(this.dateDataColheita_ValueChanged);
        // 
        // txtAreaPlantada
        // 
        this.txtAreaPlantada.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtAreaPlantada.Location = new System.Drawing.Point(220, 125);
        this.txtAreaPlantada.Name = "txtAreaPlantada";
        this.txtAreaPlantada.Size = new System.Drawing.Size(223, 27);
        this.txtAreaPlantada.TabIndex = 43;
        // 
        // txtTipoSolo
        // 
        this.txtTipoSolo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtTipoSolo.Location = new System.Drawing.Point(220, 195);
        this.txtTipoSolo.Name = "txtTipoSolo";
        this.txtTipoSolo.Size = new System.Drawing.Size(223, 27);
        this.txtTipoSolo.TabIndex = 40;
        // 
        // btnCancelar
        // 
        this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnCancelar.BackColor = System.Drawing.Color.GhostWhite;
        this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 12F);
        this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnCancelar.Location = new System.Drawing.Point(501, 322);
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.Size = new System.Drawing.Size(148, 52);
        this.btnCancelar.TabIndex = 68;
        this.btnCancelar.Text = "Cancelar";
        this.btnCancelar.UseVisualStyleBackColor = false;
        this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        // 
        // btnSalvar
        // 
        this.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnSalvar.BackColor = System.Drawing.Color.GhostWhite;
        this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 12F);
        this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnSalvar.Location = new System.Drawing.Point(220, 322);
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.Size = new System.Drawing.Size(148, 52);
        this.btnSalvar.TabIndex = 67;
        this.btnSalvar.Text = "Salvar";
        this.btnSalvar.UseVisualStyleBackColor = false;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        // 
        // txtNome
        // 
        this.txtNome.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtNome.Location = new System.Drawing.Point(220, 90);
        this.txtNome.Name = "txtNome";
        this.txtNome.Size = new System.Drawing.Size(223, 27);
        this.txtNome.TabIndex = 69;
        // 
        // lblDataColheita
        // 
        this.lblDataColheita.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataColheita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataColheita.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDataColheita.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataColheita.Location = new System.Drawing.Point(458, 125);
        this.lblDataColheita.Name = "lblDataColheita";
        this.lblDataColheita.Size = new System.Drawing.Size(129, 30);
        this.lblDataColheita.TabIndex = 70;
        this.lblDataColheita.Text = "Data de Colheita";
        this.lblDataColheita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dateColheita
        // 
        this.dateColheita.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateColheita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateColheita.Location = new System.Drawing.Point(593, 125);
        this.dateColheita.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateColheita.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateColheita.Name = "dateColheita";
        this.dateColheita.Size = new System.Drawing.Size(132, 30);
        this.dateColheita.TabIndex = 71;
        this.dateColheita.Value = new System.DateTime(2024, 12, 19, 0, 0, 0, 0);
        // 
        // lblTipoIrrigacao
        // 
        this.lblTipoIrrigacao.BackColor = System.Drawing.Color.GhostWhite;
        this.lblTipoIrrigacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTipoIrrigacao.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblTipoIrrigacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblTipoIrrigacao.Location = new System.Drawing.Point(458, 195);
        this.lblTipoIrrigacao.Name = "lblTipoIrrigacao";
        this.lblTipoIrrigacao.Size = new System.Drawing.Size(138, 27);
        this.lblTipoIrrigacao.TabIndex = 73;
        this.lblTipoIrrigacao.Text = "Tipo de Irrigação";
        this.lblTipoIrrigacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtTipoIrrigacao
        // 
        this.txtTipoIrrigacao.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtTipoIrrigacao.Location = new System.Drawing.Point(602, 196);
        this.txtTipoIrrigacao.Name = "txtTipoIrrigacao";
        this.txtTipoIrrigacao.Size = new System.Drawing.Size(223, 27);
        this.txtTipoIrrigacao.TabIndex = 72;
        // 
        // lblQuantidadePlantada
        // 
        this.lblQuantidadePlantada.BackColor = System.Drawing.Color.GhostWhite;
        this.lblQuantidadePlantada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblQuantidadePlantada.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblQuantidadePlantada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblQuantidadePlantada.Location = new System.Drawing.Point(96, 160);
        this.lblQuantidadePlantada.Name = "lblQuantidadePlantada";
        this.lblQuantidadePlantada.Size = new System.Drawing.Size(158, 27);
        this.lblQuantidadePlantada.TabIndex = 75;
        this.lblQuantidadePlantada.Text = "Quantidade Plantada";
        this.lblQuantidadePlantada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtQuantidadePlantada
        // 
        this.txtQuantidadePlantada.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtQuantidadePlantada.Location = new System.Drawing.Point(260, 160);
        this.txtQuantidadePlantada.Name = "txtQuantidadePlantada";
        this.txtQuantidadePlantada.Size = new System.Drawing.Size(183, 27);
        this.txtQuantidadePlantada.TabIndex = 74;
        // 
        // lblNotas
        // 
        this.lblNotas.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNotas.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblNotas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNotas.Location = new System.Drawing.Point(458, 160);
        this.lblNotas.Name = "lblNotas";
        this.lblNotas.Size = new System.Drawing.Size(118, 27);
        this.lblNotas.TabIndex = 77;
        this.lblNotas.Text = "Notas";
        this.lblNotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtNotas
        // 
        this.txtNotas.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtNotas.Location = new System.Drawing.Point(582, 161);
        this.txtNotas.Name = "txtNotas";
        this.txtNotas.Size = new System.Drawing.Size(243, 27);
        this.txtNotas.TabIndex = 76;
        // 
        // txtId
        // 
        this.txtId.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtId.Location = new System.Drawing.Point(425, 9);
        this.txtId.Name = "txtId";
        this.txtId.ReadOnly = true;
        this.txtId.Size = new System.Drawing.Size(86, 27);
        this.txtId.TabIndex = 79;
        // 
        // lblId
        // 
        this.lblId.BackColor = System.Drawing.Color.GhostWhite;
        this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblId.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblId.Location = new System.Drawing.Point(301, 9);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(118, 27);
        this.lblId.TabIndex = 78;
        this.lblId.Text = "Código";
        this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // AlteraCulturaForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblId);
        this.Controls.Add(this.lblNotas);
        this.Controls.Add(this.txtNotas);
        this.Controls.Add(this.lblQuantidadePlantada);
        this.Controls.Add(this.txtQuantidadePlantada);
        this.Controls.Add(this.lblTipoIrrigacao);
        this.Controls.Add(this.txtTipoIrrigacao);
        this.Controls.Add(this.lblDataColheita);
        this.Controls.Add(this.dateColheita);
        this.Controls.Add(this.txtNome);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.lblTipoSolo);
        this.Controls.Add(this.lblDataPlantio);
        this.Controls.Add(this.lblÁreaPlantada);
        this.Controls.Add(this.lblNome);
        this.Controls.Add(this.dateDataPlantio);
        this.Controls.Add(this.txtAreaPlantada);
        this.Controls.Add(this.txtTipoSolo);
        this.MaximizeBox = false;
        this.Name = "AlteraCulturaForm";
        this.ShowIcon = false;
        this.Text = "Alterar Cultura";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.AlteraCulturaForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.Label lblId;

    private System.Windows.Forms.Label lblQuantidadePlantada;
    private System.Windows.Forms.TextBox txtNotas;

    private System.Windows.Forms.Label lblNotas;
    private System.Windows.Forms.TextBox txtQuantidadePlantada;

    private System.Windows.Forms.Label lblTipoIrrigacao;
    private System.Windows.Forms.TextBox txtTipoIrrigacao;

    private System.Windows.Forms.Label lblDataColheita;
    private System.Windows.Forms.DateTimePicker dateColheita;

    private System.Windows.Forms.TextBox txtNome;

    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnSalvar;

    private System.Windows.Forms.Label lblTipoSolo;
    private System.Windows.Forms.Label lblDataPlantio;
    private System.Windows.Forms.Label lblÁreaPlantada;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.DateTimePicker dateDataPlantio;
    private System.Windows.Forms.TextBox txtAreaPlantada;
    private System.Windows.Forms.TextBox txtTipoSolo;

    #endregion
}
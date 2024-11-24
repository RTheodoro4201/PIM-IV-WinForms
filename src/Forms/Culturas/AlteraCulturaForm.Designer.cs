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
        this.lblAlteraCultura = new System.Windows.Forms.Label();
        this.lblId = new System.Windows.Forms.Label();
        this.txtId = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // lblTipoSolo
        // 
        this.lblTipoSolo.BackColor = System.Drawing.Color.DimGray;
        this.lblTipoSolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTipoSolo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblTipoSolo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblTipoSolo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblTipoSolo.Location = new System.Drawing.Point(45, 180);
        this.lblTipoSolo.Name = "lblTipoSolo";
        this.lblTipoSolo.Size = new System.Drawing.Size(118, 30);
        this.lblTipoSolo.TabIndex = 64;
        this.lblTipoSolo.Text = "Tipo de Solo";
        this.lblTipoSolo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblDataPlantio
        // 
        this.lblDataPlantio.BackColor = System.Drawing.Color.DimGray;
        this.lblDataPlantio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataPlantio.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDataPlantio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDataPlantio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataPlantio.Location = new System.Drawing.Point(45, 285);
        this.lblDataPlantio.Name = "lblDataPlantio";
        this.lblDataPlantio.Size = new System.Drawing.Size(148, 30);
        this.lblDataPlantio.TabIndex = 42;
        this.lblDataPlantio.Text = "Data de Plantio";
        this.lblDataPlantio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblÁreaPlantada
        // 
        this.lblÁreaPlantada.BackColor = System.Drawing.Color.DimGray;
        this.lblÁreaPlantada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblÁreaPlantada.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblÁreaPlantada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblÁreaPlantada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblÁreaPlantada.Location = new System.Drawing.Point(45, 110);
        this.lblÁreaPlantada.Name = "lblÁreaPlantada";
        this.lblÁreaPlantada.Size = new System.Drawing.Size(175, 30);
        this.lblÁreaPlantada.TabIndex = 54;
        this.lblÁreaPlantada.Text = "Área Plantada (m2)";
        this.lblÁreaPlantada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblNome
        // 
        this.lblNome.BackColor = System.Drawing.Color.DimGray;
        this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNome.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNome.Location = new System.Drawing.Point(45, 75);
        this.lblNome.Name = "lblNome";
        this.lblNome.Size = new System.Drawing.Size(70, 30);
        this.lblNome.TabIndex = 50;
        this.lblNome.Text = "Nome";
        this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dateDataPlantio
        // 
        this.dateDataPlantio.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataPlantio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataPlantio.Location = new System.Drawing.Point(201, 283);
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
        this.txtAreaPlantada.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtAreaPlantada.Location = new System.Drawing.Point(226, 110);
        this.txtAreaPlantada.Name = "txtAreaPlantada";
        this.txtAreaPlantada.Size = new System.Drawing.Size(86, 30);
        this.txtAreaPlantada.TabIndex = 43;
        this.txtAreaPlantada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // txtTipoSolo
        // 
        this.txtTipoSolo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtTipoSolo.Location = new System.Drawing.Point(169, 180);
        this.txtTipoSolo.Name = "txtTipoSolo";
        this.txtTipoSolo.Size = new System.Drawing.Size(223, 30);
        this.txtTipoSolo.TabIndex = 40;
        // 
        // btnCancelar
        // 
        this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
        this.btnCancelar.FlatAppearance.BorderSize = 0;
        this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 14F);
        this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnCancelar.Location = new System.Drawing.Point(368, 602);
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
        this.btnSalvar.BackColor = System.Drawing.Color.DimGray;
        this.btnSalvar.FlatAppearance.BorderSize = 0;
        this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 14F);
        this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnSalvar.Location = new System.Drawing.Point(45, 602);
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.Size = new System.Drawing.Size(148, 52);
        this.btnSalvar.TabIndex = 67;
        this.btnSalvar.Text = "Salvar";
        this.btnSalvar.UseVisualStyleBackColor = false;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        // 
        // txtNome
        // 
        this.txtNome.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNome.Location = new System.Drawing.Point(121, 75);
        this.txtNome.Name = "txtNome";
        this.txtNome.Size = new System.Drawing.Size(271, 30);
        this.txtNome.TabIndex = 69;
        // 
        // lblDataColheita
        // 
        this.lblDataColheita.BackColor = System.Drawing.Color.DimGray;
        this.lblDataColheita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataColheita.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDataColheita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDataColheita.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataColheita.Location = new System.Drawing.Point(45, 320);
        this.lblDataColheita.Name = "lblDataColheita";
        this.lblDataColheita.Size = new System.Drawing.Size(150, 30);
        this.lblDataColheita.TabIndex = 70;
        this.lblDataColheita.Text = "Data de Colheita";
        this.lblDataColheita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dateColheita
        // 
        this.dateColheita.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateColheita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateColheita.Location = new System.Drawing.Point(201, 320);
        this.dateColheita.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateColheita.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateColheita.Name = "dateColheita";
        this.dateColheita.Size = new System.Drawing.Size(132, 30);
        this.dateColheita.TabIndex = 71;
        this.dateColheita.Value = new System.DateTime(2024, 12, 19, 0, 0, 0, 0);
        // 
        // lblTipoIrrigacao
        // 
        this.lblTipoIrrigacao.BackColor = System.Drawing.Color.DimGray;
        this.lblTipoIrrigacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTipoIrrigacao.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblTipoIrrigacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblTipoIrrigacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblTipoIrrigacao.Location = new System.Drawing.Point(45, 215);
        this.lblTipoIrrigacao.Name = "lblTipoIrrigacao";
        this.lblTipoIrrigacao.Size = new System.Drawing.Size(160, 30);
        this.lblTipoIrrigacao.TabIndex = 73;
        this.lblTipoIrrigacao.Text = "Tipo de Irrigação";
        this.lblTipoIrrigacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTipoIrrigacao
        // 
        this.txtTipoIrrigacao.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtTipoIrrigacao.Location = new System.Drawing.Point(216, 215);
        this.txtTipoIrrigacao.Name = "txtTipoIrrigacao";
        this.txtTipoIrrigacao.Size = new System.Drawing.Size(223, 30);
        this.txtTipoIrrigacao.TabIndex = 72;
        // 
        // lblQuantidadePlantada
        // 
        this.lblQuantidadePlantada.BackColor = System.Drawing.Color.DimGray;
        this.lblQuantidadePlantada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblQuantidadePlantada.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblQuantidadePlantada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblQuantidadePlantada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblQuantidadePlantada.Location = new System.Drawing.Point(45, 145);
        this.lblQuantidadePlantada.Name = "lblQuantidadePlantada";
        this.lblQuantidadePlantada.Size = new System.Drawing.Size(188, 30);
        this.lblQuantidadePlantada.TabIndex = 75;
        this.lblQuantidadePlantada.Text = "Quantidade Plantada";
        this.lblQuantidadePlantada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtQuantidadePlantada
        // 
        this.txtQuantidadePlantada.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtQuantidadePlantada.Location = new System.Drawing.Point(239, 145);
        this.txtQuantidadePlantada.Name = "txtQuantidadePlantada";
        this.txtQuantidadePlantada.Size = new System.Drawing.Size(79, 30);
        this.txtQuantidadePlantada.TabIndex = 74;
        this.txtQuantidadePlantada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblNotas
        // 
        this.lblNotas.BackColor = System.Drawing.Color.DimGray;
        this.lblNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNotas.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblNotas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNotas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNotas.Location = new System.Drawing.Point(45, 250);
        this.lblNotas.Name = "lblNotas";
        this.lblNotas.Size = new System.Drawing.Size(59, 30);
        this.lblNotas.TabIndex = 77;
        this.lblNotas.Text = "Notas";
        this.lblNotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtNotas
        // 
        this.txtNotas.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNotas.Location = new System.Drawing.Point(110, 250);
        this.txtNotas.Name = "txtNotas";
        this.txtNotas.Size = new System.Drawing.Size(243, 30);
        this.txtNotas.TabIndex = 76;
        // 
        // lblAlteraCultura
        // 
        this.lblAlteraCultura.BackColor = System.Drawing.Color.DimGray;
        this.lblAlteraCultura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblAlteraCultura.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblAlteraCultura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblAlteraCultura.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblAlteraCultura.Location = new System.Drawing.Point(45, 25);
        this.lblAlteraCultura.Name = "lblAlteraCultura";
        this.lblAlteraCultura.Size = new System.Drawing.Size(195, 40);
        this.lblAlteraCultura.TabIndex = 78;
        this.lblAlteraCultura.Text = "Alterar Cultura";
        this.lblAlteraCultura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblId
        // 
        this.lblId.BackColor = System.Drawing.Color.DimGray;
        this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblId.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblId.Location = new System.Drawing.Point(246, 25);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(105, 40);
        this.lblId.TabIndex = 79;
        this.lblId.Text = "Código";
        this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtId
        // 
        this.txtId.Font = new System.Drawing.Font("Tahoma", 20F);
        this.txtId.Location = new System.Drawing.Point(357, 25);
        this.txtId.Name = "txtId";
        this.txtId.ReadOnly = true;
        this.txtId.Size = new System.Drawing.Size(90, 40);
        this.txtId.TabIndex = 80;
        this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
        this.Controls.Add(this.lblAlteraCultura);
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

    private System.Windows.Forms.Label lblAlteraCultura;
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
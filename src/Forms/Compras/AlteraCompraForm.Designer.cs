using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Compras;

partial class AlteraCompraForm
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
        this.lblNomeInsumo = new System.Windows.Forms.Label();
        this.lblIdInsumo = new System.Windows.Forms.Label();
        this.txtNomeInsumo = new System.Windows.Forms.TextBox();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.txtIdInsumo = new System.Windows.Forms.TextBox();
        this.lblQuantidadeComprada = new System.Windows.Forms.Label();
        this.txtQuantidadeComprada = new System.Windows.Forms.TextBox();
        this.lblIdFornecedor = new System.Windows.Forms.Label();
        this.txtIdFornecedor = new System.Windows.Forms.TextBox();
        this.lblDataCompra = new System.Windows.Forms.Label();
        this.dateDataCompra = new System.Windows.Forms.DateTimePicker();
        this.lblNomeFornecedor = new System.Windows.Forms.Label();
        this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
        this.lblValorUnitario = new System.Windows.Forms.Label();
        this.txtValorUnitario = new System.Windows.Forms.TextBox();
        this.lblValorTotal = new System.Windows.Forms.Label();
        this.txtValorTotal = new System.Windows.Forms.TextBox();
        this.lblAlteraCompra = new System.Windows.Forms.Label();
        this.lblId = new System.Windows.Forms.Label();
        this.txtId = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // lblNomeInsumo
        // 
        this.lblNomeInsumo.BackColor = System.Drawing.Color.DimGray;
        this.lblNomeInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNomeInsumo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblNomeInsumo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNomeInsumo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNomeInsumo.Location = new System.Drawing.Point(45, 110);
        this.lblNomeInsumo.Name = "lblNomeInsumo";
        this.lblNomeInsumo.Size = new System.Drawing.Size(135, 30);
        this.lblNomeInsumo.TabIndex = 54;
        this.lblNomeInsumo.Text = "Nome Insumo";
        this.lblNomeInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblIdInsumo
        // 
        this.lblIdInsumo.BackColor = System.Drawing.Color.DimGray;
        this.lblIdInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblIdInsumo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblIdInsumo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblIdInsumo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblIdInsumo.Location = new System.Drawing.Point(45, 75);
        this.lblIdInsumo.Name = "lblIdInsumo";
        this.lblIdInsumo.Size = new System.Drawing.Size(140, 30);
        this.lblIdInsumo.TabIndex = 50;
        this.lblIdInsumo.Text = "Código Insumo";
        this.lblIdInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtNomeInsumo
        // 
        this.txtNomeInsumo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNomeInsumo.Location = new System.Drawing.Point(186, 110);
        this.txtNomeInsumo.Name = "txtNomeInsumo";
        this.txtNomeInsumo.ReadOnly = true;
        this.txtNomeInsumo.Size = new System.Drawing.Size(240, 30);
        this.txtNomeInsumo.TabIndex = 43;
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
        // txtIdInsumo
        // 
        this.txtIdInsumo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtIdInsumo.Location = new System.Drawing.Point(191, 75);
        this.txtIdInsumo.Name = "txtIdInsumo";
        this.txtIdInsumo.Size = new System.Drawing.Size(80, 30);
        this.txtIdInsumo.TabIndex = 69;
        this.txtIdInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.txtIdInsumo.Leave += new System.EventHandler(this.txtIdInsumo_Leave);
        // 
        // lblQuantidadeComprada
        // 
        this.lblQuantidadeComprada.BackColor = System.Drawing.Color.DimGray;
        this.lblQuantidadeComprada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblQuantidadeComprada.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblQuantidadeComprada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblQuantidadeComprada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblQuantidadeComprada.Location = new System.Drawing.Point(45, 215);
        this.lblQuantidadeComprada.Name = "lblQuantidadeComprada";
        this.lblQuantidadeComprada.Size = new System.Drawing.Size(202, 30);
        this.lblQuantidadeComprada.TabIndex = 75;
        this.lblQuantidadeComprada.Text = "Quantidade Comprada";
        this.lblQuantidadeComprada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtQuantidadeComprada
        // 
        this.txtQuantidadeComprada.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtQuantidadeComprada.Location = new System.Drawing.Point(253, 215);
        this.txtQuantidadeComprada.Name = "txtQuantidadeComprada";
        this.txtQuantidadeComprada.Size = new System.Drawing.Size(80, 30);
        this.txtQuantidadeComprada.TabIndex = 74;
        this.txtQuantidadeComprada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblIdFornecedor
        // 
        this.lblIdFornecedor.BackColor = System.Drawing.Color.DimGray;
        this.lblIdFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblIdFornecedor.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblIdFornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblIdFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblIdFornecedor.Location = new System.Drawing.Point(45, 145);
        this.lblIdFornecedor.Name = "lblIdFornecedor";
        this.lblIdFornecedor.Size = new System.Drawing.Size(170, 30);
        this.lblIdFornecedor.TabIndex = 77;
        this.lblIdFornecedor.Text = "Código Fornecedor";
        this.lblIdFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtIdFornecedor
        // 
        this.txtIdFornecedor.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtIdFornecedor.Location = new System.Drawing.Point(221, 145);
        this.txtIdFornecedor.Name = "txtIdFornecedor";
        this.txtIdFornecedor.Size = new System.Drawing.Size(80, 30);
        this.txtIdFornecedor.TabIndex = 76;
        this.txtIdFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.txtIdFornecedor.Leave += new System.EventHandler(this.txtIdFornecedor_Leave);
        // 
        // lblDataCompra
        // 
        this.lblDataCompra.BackColor = System.Drawing.Color.DimGray;
        this.lblDataCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataCompra.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDataCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDataCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataCompra.Location = new System.Drawing.Point(45, 320);
        this.lblDataCompra.Name = "lblDataCompra";
        this.lblDataCompra.Size = new System.Drawing.Size(149, 30);
        this.lblDataCompra.TabIndex = 78;
        this.lblDataCompra.Text = "Data de Compra";
        this.lblDataCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dateDataCompra
        // 
        this.dateDataCompra.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataCompra.Location = new System.Drawing.Point(200, 320);
        this.dateDataCompra.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataCompra.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataCompra.Name = "dateDataCompra";
        this.dateDataCompra.Size = new System.Drawing.Size(132, 30);
        this.dateDataCompra.TabIndex = 79;
        this.dateDataCompra.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
        this.dateDataCompra.Leave += new System.EventHandler(this.dateDataCompra_Leave);
        // 
        // lblNomeFornecedor
        // 
        this.lblNomeFornecedor.BackColor = System.Drawing.Color.DimGray;
        this.lblNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNomeFornecedor.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblNomeFornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNomeFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNomeFornecedor.Location = new System.Drawing.Point(45, 180);
        this.lblNomeFornecedor.Name = "lblNomeFornecedor";
        this.lblNomeFornecedor.Size = new System.Drawing.Size(162, 30);
        this.lblNomeFornecedor.TabIndex = 81;
        this.lblNomeFornecedor.Text = "Nome Fornecedor";
        this.lblNomeFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtNomeFornecedor
        // 
        this.txtNomeFornecedor.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNomeFornecedor.Location = new System.Drawing.Point(213, 180);
        this.txtNomeFornecedor.Name = "txtNomeFornecedor";
        this.txtNomeFornecedor.ReadOnly = true;
        this.txtNomeFornecedor.Size = new System.Drawing.Size(213, 30);
        this.txtNomeFornecedor.TabIndex = 80;
        this.txtNomeFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblValorUnitario
        // 
        this.lblValorUnitario.BackColor = System.Drawing.Color.DimGray;
        this.lblValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblValorUnitario.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblValorUnitario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblValorUnitario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblValorUnitario.Location = new System.Drawing.Point(45, 250);
        this.lblValorUnitario.Name = "lblValorUnitario";
        this.lblValorUnitario.Size = new System.Drawing.Size(128, 30);
        this.lblValorUnitario.TabIndex = 83;
        this.lblValorUnitario.Text = "Valor Unitário";
        this.lblValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtValorUnitario
        // 
        this.txtValorUnitario.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtValorUnitario.Location = new System.Drawing.Point(181, 250);
        this.txtValorUnitario.Name = "txtValorUnitario";
        this.txtValorUnitario.Size = new System.Drawing.Size(110, 30);
        this.txtValorUnitario.TabIndex = 82;
        this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.txtValorUnitario.Leave += new System.EventHandler(this.txtValorUnitario_Leave);
        // 
        // lblValorTotal
        // 
        this.lblValorTotal.BackColor = System.Drawing.Color.DimGray;
        this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblValorTotal.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblValorTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblValorTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblValorTotal.Location = new System.Drawing.Point(45, 285);
        this.lblValorTotal.Name = "lblValorTotal";
        this.lblValorTotal.Size = new System.Drawing.Size(111, 30);
        this.lblValorTotal.TabIndex = 85;
        this.lblValorTotal.Text = "Valor Total";
        this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtValorTotal
        // 
        this.txtValorTotal.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtValorTotal.Location = new System.Drawing.Point(162, 285);
        this.txtValorTotal.Name = "txtValorTotal";
        this.txtValorTotal.ReadOnly = true;
        this.txtValorTotal.Size = new System.Drawing.Size(110, 30);
        this.txtValorTotal.TabIndex = 84;
        this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblAlteraCompra
        // 
        this.lblAlteraCompra.BackColor = System.Drawing.Color.DimGray;
        this.lblAlteraCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblAlteraCompra.Font = new System.Drawing.Font("Tahoma", 18F);
        this.lblAlteraCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblAlteraCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblAlteraCompra.Location = new System.Drawing.Point(45, 25);
        this.lblAlteraCompra.Name = "lblAlteraCompra";
        this.lblAlteraCompra.Size = new System.Drawing.Size(179, 40);
        this.lblAlteraCompra.TabIndex = 86;
        this.lblAlteraCompra.Text = "Alterar Compra";
        this.lblAlteraCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblId
        // 
        this.lblId.BackColor = System.Drawing.Color.DimGray;
        this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblId.Font = new System.Drawing.Font("Tahoma", 18F);
        this.lblId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblId.Location = new System.Drawing.Point(230, 25);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(100, 40);
        this.lblId.TabIndex = 87;
        this.lblId.Text = "Código";
        this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtId
        // 
        this.txtId.Font = new System.Drawing.Font("Tahoma", 20F);
        this.txtId.Location = new System.Drawing.Point(336, 25);
        this.txtId.Name = "txtId";
        this.txtId.ReadOnly = true;
        this.txtId.Size = new System.Drawing.Size(90, 40);
        this.txtId.TabIndex = 88;
        this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // AlteraCompraForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblId);
        this.Controls.Add(this.lblAlteraCompra);
        this.Controls.Add(this.lblValorTotal);
        this.Controls.Add(this.txtValorTotal);
        this.Controls.Add(this.lblValorUnitario);
        this.Controls.Add(this.txtValorUnitario);
        this.Controls.Add(this.lblNomeFornecedor);
        this.Controls.Add(this.txtNomeFornecedor);
        this.Controls.Add(this.lblDataCompra);
        this.Controls.Add(this.dateDataCompra);
        this.Controls.Add(this.lblIdFornecedor);
        this.Controls.Add(this.txtIdFornecedor);
        this.Controls.Add(this.lblQuantidadeComprada);
        this.Controls.Add(this.txtQuantidadeComprada);
        this.Controls.Add(this.txtIdInsumo);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.lblNomeInsumo);
        this.Controls.Add(this.lblIdInsumo);
        this.Controls.Add(this.txtNomeInsumo);
        this.MaximizeBox = false;
        this.Name = "AlteraCompraForm";
        this.ShowIcon = false;
        this.Text = "Alterar Compra";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.AlteraCompraForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtId;

    private System.Windows.Forms.Label lblAlteraCompra;

    private System.Windows.Forms.Label lblValorTotal;
    private System.Windows.Forms.TextBox txtValorTotal;

    private System.Windows.Forms.Label lblValorUnitario;
    private System.Windows.Forms.TextBox txtValorUnitario;

    private System.Windows.Forms.Label lblNomeFornecedor;
    private System.Windows.Forms.TextBox txtNomeFornecedor;

    private System.Windows.Forms.Label lblDataCompra;
    private System.Windows.Forms.DateTimePicker dateDataCompra;

    private System.Windows.Forms.Label lblQuantidadeComprada;
    private System.Windows.Forms.TextBox txtIdFornecedor;

    private System.Windows.Forms.Label lblIdFornecedor;
    private System.Windows.Forms.TextBox txtQuantidadeComprada;

    private System.Windows.Forms.TextBox txtIdInsumo;

    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnSalvar;

    private System.Windows.Forms.Label lblNomeInsumo;
    private System.Windows.Forms.Label lblIdInsumo;
    private System.Windows.Forms.TextBox txtNomeInsumo;

    #endregion
}
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
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.txtId = new System.Windows.Forms.TextBox();
        this.lblId = new System.Windows.Forms.Label();
        this.lblValorTotal = new System.Windows.Forms.Label();
        this.txtValorTotal = new System.Windows.Forms.TextBox();
        this.lblValorUnitario = new System.Windows.Forms.Label();
        this.txtValorUnitario = new System.Windows.Forms.TextBox();
        this.lblNomeFornecedor = new System.Windows.Forms.Label();
        this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
        this.lblDataCompra = new System.Windows.Forms.Label();
        this.dateDataCompra = new System.Windows.Forms.DateTimePicker();
        this.lblIdFornecedor = new System.Windows.Forms.Label();
        this.txtIdFornecedor = new System.Windows.Forms.TextBox();
        this.lblQuantidadeComprada = new System.Windows.Forms.Label();
        this.txtQuantidadeComprada = new System.Windows.Forms.TextBox();
        this.txtIdInsumo = new System.Windows.Forms.TextBox();
        this.lblNomeInsumo = new System.Windows.Forms.Label();
        this.lblIdInsumo = new System.Windows.Forms.Label();
        this.txtNomeInsumo = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
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
        // lblValorTotal
        // 
        this.lblValorTotal.BackColor = System.Drawing.Color.GhostWhite;
        this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblValorTotal.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblValorTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblValorTotal.Location = new System.Drawing.Point(457, 163);
        this.lblValorTotal.Name = "lblValorTotal";
        this.lblValorTotal.Size = new System.Drawing.Size(111, 27);
        this.lblValorTotal.TabIndex = 101;
        this.lblValorTotal.Text = "Valor Total";
        this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtValorTotal
        // 
        this.txtValorTotal.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtValorTotal.Location = new System.Drawing.Point(574, 164);
        this.txtValorTotal.Name = "txtValorTotal";
        this.txtValorTotal.ReadOnly = true;
        this.txtValorTotal.Size = new System.Drawing.Size(151, 27);
        this.txtValorTotal.TabIndex = 100;
        // 
        // lblValorUnitario
        // 
        this.lblValorUnitario.BackColor = System.Drawing.Color.GhostWhite;
        this.lblValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblValorUnitario.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblValorUnitario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblValorUnitario.Location = new System.Drawing.Point(457, 127);
        this.lblValorUnitario.Name = "lblValorUnitario";
        this.lblValorUnitario.Size = new System.Drawing.Size(111, 27);
        this.lblValorUnitario.TabIndex = 99;
        this.lblValorUnitario.Text = "Valor Unitário";
        this.lblValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtValorUnitario
        // 
        this.txtValorUnitario.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtValorUnitario.Location = new System.Drawing.Point(574, 128);
        this.txtValorUnitario.Name = "txtValorUnitario";
        this.txtValorUnitario.Size = new System.Drawing.Size(151, 27);
        this.txtValorUnitario.TabIndex = 98;
        this.txtValorUnitario.Enter += new System.EventHandler(this.txtValorUnitario_Enter);
        this.txtValorUnitario.Leave += new System.EventHandler(this.txtValorUnitario_Leave);
        // 
        // lblNomeFornecedor
        // 
        this.lblNomeFornecedor.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNomeFornecedor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblNomeFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNomeFornecedor.Location = new System.Drawing.Point(95, 197);
        this.lblNomeFornecedor.Name = "lblNomeFornecedor";
        this.lblNomeFornecedor.Size = new System.Drawing.Size(162, 27);
        this.lblNomeFornecedor.TabIndex = 97;
        this.lblNomeFornecedor.Text = "Nome do Fornecedor";
        this.lblNomeFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtNomeFornecedor
        // 
        this.txtNomeFornecedor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtNomeFornecedor.Location = new System.Drawing.Point(263, 197);
        this.txtNomeFornecedor.Name = "txtNomeFornecedor";
        this.txtNomeFornecedor.ReadOnly = true;
        this.txtNomeFornecedor.Size = new System.Drawing.Size(164, 27);
        this.txtNomeFornecedor.TabIndex = 96;
        this.txtNomeFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblDataCompra
        // 
        this.lblDataCompra.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataCompra.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDataCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataCompra.Location = new System.Drawing.Point(457, 197);
        this.lblDataCompra.Name = "lblDataCompra";
        this.lblDataCompra.Size = new System.Drawing.Size(128, 30);
        this.lblDataCompra.TabIndex = 94;
        this.lblDataCompra.Text = "Data de Compra";
        this.lblDataCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dateDataCompra
        // 
        this.dateDataCompra.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataCompra.Location = new System.Drawing.Point(591, 197);
        this.dateDataCompra.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataCompra.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataCompra.Name = "dateDataCompra";
        this.dateDataCompra.Size = new System.Drawing.Size(132, 30);
        this.dateDataCompra.TabIndex = 95;
        this.dateDataCompra.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
        this.dateDataCompra.Leave += new System.EventHandler(this.dateDataCompra_Leave);
        // 
        // lblIdFornecedor
        // 
        this.lblIdFornecedor.BackColor = System.Drawing.Color.GhostWhite;
        this.lblIdFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblIdFornecedor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblIdFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblIdFornecedor.Location = new System.Drawing.Point(95, 162);
        this.lblIdFornecedor.Name = "lblIdFornecedor";
        this.lblIdFornecedor.Size = new System.Drawing.Size(175, 27);
        this.lblIdFornecedor.TabIndex = 93;
        this.lblIdFornecedor.Text = "Código do Fornecedor";
        this.lblIdFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtIdFornecedor
        // 
        this.txtIdFornecedor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtIdFornecedor.Location = new System.Drawing.Point(276, 163);
        this.txtIdFornecedor.Name = "txtIdFornecedor";
        this.txtIdFornecedor.Size = new System.Drawing.Size(151, 27);
        this.txtIdFornecedor.TabIndex = 92;
        this.txtIdFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.txtIdFornecedor.Leave += new System.EventHandler(this.txtIdFornecedor_Leave);
        // 
        // lblQuantidadeComprada
        // 
        this.lblQuantidadeComprada.BackColor = System.Drawing.Color.GhostWhite;
        this.lblQuantidadeComprada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblQuantidadeComprada.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblQuantidadeComprada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblQuantidadeComprada.Location = new System.Drawing.Point(95, 127);
        this.lblQuantidadeComprada.Name = "lblQuantidadeComprada";
        this.lblQuantidadeComprada.Size = new System.Drawing.Size(175, 27);
        this.lblQuantidadeComprada.TabIndex = 91;
        this.lblQuantidadeComprada.Text = "Quantidade Comprada";
        this.lblQuantidadeComprada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtQuantidadeComprada
        // 
        this.txtQuantidadeComprada.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtQuantidadeComprada.Location = new System.Drawing.Point(276, 127);
        this.txtQuantidadeComprada.Name = "txtQuantidadeComprada";
        this.txtQuantidadeComprada.Size = new System.Drawing.Size(151, 27);
        this.txtQuantidadeComprada.TabIndex = 90;
        this.txtQuantidadeComprada.Leave += new System.EventHandler(this.txtQuantidadeComprada_Leave);
        // 
        // txtIdInsumo
        // 
        this.txtIdInsumo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtIdInsumo.Location = new System.Drawing.Point(263, 92);
        this.txtIdInsumo.Name = "txtIdInsumo";
        this.txtIdInsumo.Size = new System.Drawing.Size(164, 27);
        this.txtIdInsumo.TabIndex = 89;
        this.txtIdInsumo.Leave += new System.EventHandler(this.txtIdInsumo_Leave);
        // 
        // lblNomeInsumo
        // 
        this.lblNomeInsumo.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNomeInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNomeInsumo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblNomeInsumo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNomeInsumo.Location = new System.Drawing.Point(457, 91);
        this.lblNomeInsumo.Name = "lblNomeInsumo";
        this.lblNomeInsumo.Size = new System.Drawing.Size(138, 27);
        this.lblNomeInsumo.TabIndex = 88;
        this.lblNomeInsumo.Text = "Nome do Insumo";
        this.lblNomeInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblIdInsumo
        // 
        this.lblIdInsumo.BackColor = System.Drawing.Color.GhostWhite;
        this.lblIdInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblIdInsumo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblIdInsumo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblIdInsumo.Location = new System.Drawing.Point(95, 92);
        this.lblIdInsumo.Name = "lblIdInsumo";
        this.lblIdInsumo.Size = new System.Drawing.Size(162, 27);
        this.lblIdInsumo.TabIndex = 87;
        this.lblIdInsumo.Text = "Código do Insumo";
        this.lblIdInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtNomeInsumo
        // 
        this.txtNomeInsumo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtNomeInsumo.Location = new System.Drawing.Point(601, 92);
        this.txtNomeInsumo.Name = "txtNomeInsumo";
        this.txtNomeInsumo.ReadOnly = true;
        this.txtNomeInsumo.Size = new System.Drawing.Size(223, 27);
        this.txtNomeInsumo.TabIndex = 86;
        // 
        // AlteraCompraForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
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
        this.Controls.Add(this.lblNomeInsumo);
        this.Controls.Add(this.lblIdInsumo);
        this.Controls.Add(this.txtNomeInsumo);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblId);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
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

    private System.Windows.Forms.Label lblValorTotal;
    private System.Windows.Forms.TextBox txtValorTotal;
    private System.Windows.Forms.Label lblValorUnitario;
    private System.Windows.Forms.TextBox txtValorUnitario;
    private System.Windows.Forms.Label lblNomeFornecedor;
    private System.Windows.Forms.TextBox txtNomeFornecedor;
    private System.Windows.Forms.Label lblDataCompra;
    private System.Windows.Forms.DateTimePicker dateDataCompra;
    private System.Windows.Forms.Label lblIdFornecedor;
    private System.Windows.Forms.TextBox txtIdFornecedor;
    private System.Windows.Forms.Label lblQuantidadeComprada;
    private System.Windows.Forms.TextBox txtQuantidadeComprada;
    private System.Windows.Forms.TextBox txtIdInsumo;
    private System.Windows.Forms.Label lblNomeInsumo;
    private System.Windows.Forms.Label lblIdInsumo;
    private System.Windows.Forms.TextBox txtNomeInsumo;

    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.Label lblId;

    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnSalvar;

    #endregion
}
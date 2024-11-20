using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Insumos;

partial class ConsultaInsumoForm
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
        this.btnFechar = new System.Windows.Forms.Button();
        this.txtId = new System.Windows.Forms.TextBox();
        this.lblId = new System.Windows.Forms.Label();
        this.lblNomeFornecedor = new System.Windows.Forms.Label();
        this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
        this.lblDataCompra = new System.Windows.Forms.Label();
        this.dateDataCompra = new System.Windows.Forms.DateTimePicker();
        this.lblIdFornecedor = new System.Windows.Forms.Label();
        this.txtIdFornecedor = new System.Windows.Forms.TextBox();
        this.lblQuantidadeEstoque = new System.Windows.Forms.Label();
        this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
        this.txtNome = new System.Windows.Forms.TextBox();
        this.lblDataValidade = new System.Windows.Forms.Label();
        this.lblDescricao = new System.Windows.Forms.Label();
        this.lblNome = new System.Windows.Forms.Label();
        this.dateDataValidade = new System.Windows.Forms.DateTimePicker();
        this.txtDescricao = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // btnFechar
        // 
        this.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnFechar.BackColor = System.Drawing.Color.GhostWhite;
        this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnFechar.Font = new System.Drawing.Font("Tahoma", 12F);
        this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnFechar.Location = new System.Drawing.Point(363, 323);
        this.btnFechar.Name = "btnFechar";
        this.btnFechar.Size = new System.Drawing.Size(148, 52);
        this.btnFechar.TabIndex = 68;
        this.btnFechar.Text = "Fechar";
        this.btnFechar.UseVisualStyleBackColor = false;
        this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
        // lblNomeFornecedor
        // 
        this.lblNomeFornecedor.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNomeFornecedor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblNomeFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNomeFornecedor.Location = new System.Drawing.Point(96, 195);
        this.lblNomeFornecedor.Name = "lblNomeFornecedor";
        this.lblNomeFornecedor.Size = new System.Drawing.Size(162, 27);
        this.lblNomeFornecedor.TabIndex = 95;
        this.lblNomeFornecedor.Text = "Nome do Fornecedor";
        this.lblNomeFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtNomeFornecedor
        // 
        this.txtNomeFornecedor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtNomeFornecedor.Location = new System.Drawing.Point(264, 195);
        this.txtNomeFornecedor.Name = "txtNomeFornecedor";
        this.txtNomeFornecedor.ReadOnly = true;
        this.txtNomeFornecedor.Size = new System.Drawing.Size(179, 27);
        this.txtNomeFornecedor.TabIndex = 94;
        this.txtNomeFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblDataCompra
        // 
        this.lblDataCompra.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataCompra.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDataCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataCompra.Location = new System.Drawing.Point(459, 125);
        this.lblDataCompra.Name = "lblDataCompra";
        this.lblDataCompra.Size = new System.Drawing.Size(138, 30);
        this.lblDataCompra.TabIndex = 92;
        this.lblDataCompra.Text = "Data de Compra";
        this.lblDataCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dateDataCompra
        // 
        this.dateDataCompra.Enabled = false;
        this.dateDataCompra.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataCompra.Location = new System.Drawing.Point(603, 125);
        this.dateDataCompra.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataCompra.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataCompra.Name = "dateDataCompra";
        this.dateDataCompra.Size = new System.Drawing.Size(132, 30);
        this.dateDataCompra.TabIndex = 93;
        this.dateDataCompra.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
        // 
        // lblIdFornecedor
        // 
        this.lblIdFornecedor.BackColor = System.Drawing.Color.GhostWhite;
        this.lblIdFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblIdFornecedor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblIdFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblIdFornecedor.Location = new System.Drawing.Point(96, 160);
        this.lblIdFornecedor.Name = "lblIdFornecedor";
        this.lblIdFornecedor.Size = new System.Drawing.Size(175, 27);
        this.lblIdFornecedor.TabIndex = 91;
        this.lblIdFornecedor.Text = "Código do Fornecedor";
        this.lblIdFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtIdFornecedor
        // 
        this.txtIdFornecedor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtIdFornecedor.Location = new System.Drawing.Point(277, 161);
        this.txtIdFornecedor.Name = "txtIdFornecedor";
        this.txtIdFornecedor.ReadOnly = true;
        this.txtIdFornecedor.Size = new System.Drawing.Size(166, 27);
        this.txtIdFornecedor.TabIndex = 90;
        this.txtIdFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblQuantidadeEstoque
        // 
        this.lblQuantidadeEstoque.BackColor = System.Drawing.Color.GhostWhite;
        this.lblQuantidadeEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblQuantidadeEstoque.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblQuantidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblQuantidadeEstoque.Location = new System.Drawing.Point(96, 125);
        this.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque";
        this.lblQuantidadeEstoque.Size = new System.Drawing.Size(190, 27);
        this.lblQuantidadeEstoque.TabIndex = 89;
        this.lblQuantidadeEstoque.Text = "Quantidade em Estoque";
        this.lblQuantidadeEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtQuantidadeEstoque
        // 
        this.txtQuantidadeEstoque.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtQuantidadeEstoque.Location = new System.Drawing.Point(292, 125);
        this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
        this.txtQuantidadeEstoque.ReadOnly = true;
        this.txtQuantidadeEstoque.Size = new System.Drawing.Size(151, 27);
        this.txtQuantidadeEstoque.TabIndex = 88;
        // 
        // txtNome
        // 
        this.txtNome.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtNome.Location = new System.Drawing.Point(220, 90);
        this.txtNome.Name = "txtNome";
        this.txtNome.ReadOnly = true;
        this.txtNome.Size = new System.Drawing.Size(223, 27);
        this.txtNome.TabIndex = 87;
        // 
        // lblDataValidade
        // 
        this.lblDataValidade.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataValidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataValidade.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDataValidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataValidade.Location = new System.Drawing.Point(459, 161);
        this.lblDataValidade.Name = "lblDataValidade";
        this.lblDataValidade.Size = new System.Drawing.Size(138, 30);
        this.lblDataValidade.TabIndex = 82;
        this.lblDataValidade.Text = "Data de Validade";
        this.lblDataValidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblDescricao
        // 
        this.lblDescricao.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDescricao.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDescricao.Location = new System.Drawing.Point(459, 90);
        this.lblDescricao.Name = "lblDescricao";
        this.lblDescricao.Size = new System.Drawing.Size(118, 27);
        this.lblDescricao.TabIndex = 85;
        this.lblDescricao.Text = "Descrição";
        this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        this.lblNome.TabIndex = 84;
        this.lblNome.Text = "Nome";
        this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dateDataValidade
        // 
        this.dateDataValidade.Enabled = false;
        this.dateDataValidade.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataValidade.Location = new System.Drawing.Point(603, 161);
        this.dateDataValidade.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataValidade.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataValidade.Name = "dateDataValidade";
        this.dateDataValidade.Size = new System.Drawing.Size(132, 30);
        this.dateDataValidade.TabIndex = 86;
        this.dateDataValidade.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
        // 
        // txtDescricao
        // 
        this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtDescricao.Location = new System.Drawing.Point(583, 90);
        this.txtDescricao.Name = "txtDescricao";
        this.txtDescricao.ReadOnly = true;
        this.txtDescricao.Size = new System.Drawing.Size(223, 27);
        this.txtDescricao.TabIndex = 83;
        // 
        // ConsultaInsumoForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
        this.Controls.Add(this.lblNomeFornecedor);
        this.Controls.Add(this.txtNomeFornecedor);
        this.Controls.Add(this.lblDataCompra);
        this.Controls.Add(this.dateDataCompra);
        this.Controls.Add(this.lblIdFornecedor);
        this.Controls.Add(this.txtIdFornecedor);
        this.Controls.Add(this.lblQuantidadeEstoque);
        this.Controls.Add(this.txtQuantidadeEstoque);
        this.Controls.Add(this.txtNome);
        this.Controls.Add(this.lblDataValidade);
        this.Controls.Add(this.lblDescricao);
        this.Controls.Add(this.lblNome);
        this.Controls.Add(this.dateDataValidade);
        this.Controls.Add(this.txtDescricao);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblId);
        this.Controls.Add(this.btnFechar);
        this.MaximizeBox = false;
        this.Name = "ConsultaInsumoForm";
        this.ShowIcon = false;
        this.Text = "Consultar Insumo";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.ConsultaInsumoForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblNomeFornecedor;
    private System.Windows.Forms.TextBox txtNomeFornecedor;
    private System.Windows.Forms.Label lblDataCompra;
    private System.Windows.Forms.DateTimePicker dateDataCompra;
    private System.Windows.Forms.Label lblIdFornecedor;
    private System.Windows.Forms.TextBox txtIdFornecedor;
    private System.Windows.Forms.Label lblQuantidadeEstoque;
    private System.Windows.Forms.TextBox txtQuantidadeEstoque;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.Label lblDataValidade;
    private System.Windows.Forms.Label lblDescricao;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.DateTimePicker dateDataValidade;
    private System.Windows.Forms.TextBox txtDescricao;

    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.Label lblId;

    private System.Windows.Forms.Button btnFechar;

    #endregion
}
using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Produtos;

partial class ExcluirProdutoForm
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
        this.lblDataValidade = new System.Windows.Forms.Label();
        this.lblDescricao = new System.Windows.Forms.Label();
        this.lblNome = new System.Windows.Forms.Label();
        this.dateDataValidade = new System.Windows.Forms.DateTimePicker();
        this.txtDescricao = new System.Windows.Forms.TextBox();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnExcluir = new System.Windows.Forms.Button();
        this.txtNome = new System.Windows.Forms.TextBox();
        this.lblQuantidadeEstoque = new System.Windows.Forms.Label();
        this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
        this.lblPrecoUnitario = new System.Windows.Forms.Label();
        this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
        this.lblExcluirProduto = new System.Windows.Forms.Label();
        this.lblId = new System.Windows.Forms.Label();
        this.txtId = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // lblDataValidade
        // 
        this.lblDataValidade.BackColor = System.Drawing.Color.DimGray;
        this.lblDataValidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataValidade.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDataValidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDataValidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataValidade.Location = new System.Drawing.Point(45, 215);
        this.lblDataValidade.Name = "lblDataValidade";
        this.lblDataValidade.Size = new System.Drawing.Size(159, 30);
        this.lblDataValidade.TabIndex = 42;
        this.lblDataValidade.Text = "Data de Validade";
        this.lblDataValidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblDescricao
        // 
        this.lblDescricao.BackColor = System.Drawing.Color.DimGray;
        this.lblDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDescricao.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDescricao.Location = new System.Drawing.Point(45, 110);
        this.lblDescricao.Name = "lblDescricao";
        this.lblDescricao.Size = new System.Drawing.Size(92, 30);
        this.lblDescricao.TabIndex = 54;
        this.lblDescricao.Text = "Descrição";
        this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
        this.lblNome.Size = new System.Drawing.Size(63, 30);
        this.lblNome.TabIndex = 50;
        this.lblNome.Text = "Nome";
        this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dateDataValidade
        // 
        this.dateDataValidade.Enabled = false;
        this.dateDataValidade.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataValidade.Location = new System.Drawing.Point(210, 215);
        this.dateDataValidade.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataValidade.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataValidade.Name = "dateDataValidade";
        this.dateDataValidade.Size = new System.Drawing.Size(132, 30);
        this.dateDataValidade.TabIndex = 56;
        this.dateDataValidade.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
        // 
        // txtDescricao
        // 
        this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtDescricao.Location = new System.Drawing.Point(143, 110);
        this.txtDescricao.Name = "txtDescricao";
        this.txtDescricao.ReadOnly = true;
        this.txtDescricao.Size = new System.Drawing.Size(336, 30);
        this.txtDescricao.TabIndex = 43;
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
        // btnExcluir
        // 
        this.btnExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnExcluir.BackColor = System.Drawing.Color.DimGray;
        this.btnExcluir.FlatAppearance.BorderSize = 0;
        this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 14F);
        this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnExcluir.Location = new System.Drawing.Point(45, 602);
        this.btnExcluir.Name = "btnExcluir";
        this.btnExcluir.Size = new System.Drawing.Size(148, 52);
        this.btnExcluir.TabIndex = 67;
        this.btnExcluir.Text = "Excluir";
        this.btnExcluir.UseVisualStyleBackColor = false;
        this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
        // 
        // txtNome
        // 
        this.txtNome.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNome.Location = new System.Drawing.Point(114, 75);
        this.txtNome.Name = "txtNome";
        this.txtNome.ReadOnly = true;
        this.txtNome.Size = new System.Drawing.Size(365, 30);
        this.txtNome.TabIndex = 69;
        // 
        // lblQuantidadeEstoque
        // 
        this.lblQuantidadeEstoque.BackColor = System.Drawing.Color.DimGray;
        this.lblQuantidadeEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblQuantidadeEstoque.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblQuantidadeEstoque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblQuantidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblQuantidadeEstoque.Location = new System.Drawing.Point(45, 145);
        this.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque";
        this.lblQuantidadeEstoque.Size = new System.Drawing.Size(215, 30);
        this.lblQuantidadeEstoque.TabIndex = 75;
        this.lblQuantidadeEstoque.Text = "Quantidade em Estoque";
        this.lblQuantidadeEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtQuantidadeEstoque
        // 
        this.txtQuantidadeEstoque.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtQuantidadeEstoque.Location = new System.Drawing.Point(266, 145);
        this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
        this.txtQuantidadeEstoque.ReadOnly = true;
        this.txtQuantidadeEstoque.Size = new System.Drawing.Size(83, 30);
        this.txtQuantidadeEstoque.TabIndex = 74;
        // 
        // lblPrecoUnitario
        // 
        this.lblPrecoUnitario.BackColor = System.Drawing.Color.DimGray;
        this.lblPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblPrecoUnitario.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblPrecoUnitario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblPrecoUnitario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblPrecoUnitario.Location = new System.Drawing.Point(45, 180);
        this.lblPrecoUnitario.Name = "lblPrecoUnitario";
        this.lblPrecoUnitario.Size = new System.Drawing.Size(128, 30);
        this.lblPrecoUnitario.TabIndex = 77;
        this.lblPrecoUnitario.Text = "Preço Unitário";
        this.lblPrecoUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtPrecoUnitario
        // 
        this.txtPrecoUnitario.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtPrecoUnitario.Location = new System.Drawing.Point(179, 179);
        this.txtPrecoUnitario.Name = "txtPrecoUnitario";
        this.txtPrecoUnitario.ReadOnly = true;
        this.txtPrecoUnitario.Size = new System.Drawing.Size(151, 30);
        this.txtPrecoUnitario.TabIndex = 76;
        this.txtPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblExcluirProduto
        // 
        this.lblExcluirProduto.BackColor = System.Drawing.Color.DimGray;
        this.lblExcluirProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblExcluirProduto.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblExcluirProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblExcluirProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblExcluirProduto.Location = new System.Drawing.Point(45, 25);
        this.lblExcluirProduto.Name = "lblExcluirProduto";
        this.lblExcluirProduto.Size = new System.Drawing.Size(233, 40);
        this.lblExcluirProduto.TabIndex = 78;
        this.lblExcluirProduto.Text = "Excluir Produto";
        this.lblExcluirProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblId
        // 
        this.lblId.BackColor = System.Drawing.Color.DimGray;
        this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblId.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblId.Location = new System.Drawing.Point(284, 25);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(100, 40);
        this.lblId.TabIndex = 79;
        this.lblId.Text = "Código";
        this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtId
        // 
        this.txtId.Font = new System.Drawing.Font("Tahoma", 20F);
        this.txtId.Location = new System.Drawing.Point(390, 25);
        this.txtId.Name = "txtId";
        this.txtId.ReadOnly = true;
        this.txtId.Size = new System.Drawing.Size(90, 40);
        this.txtId.TabIndex = 80;
        // 
        // ExcluirProdutoForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblId);
        this.Controls.Add(this.lblExcluirProduto);
        this.Controls.Add(this.lblPrecoUnitario);
        this.Controls.Add(this.txtPrecoUnitario);
        this.Controls.Add(this.lblQuantidadeEstoque);
        this.Controls.Add(this.txtQuantidadeEstoque);
        this.Controls.Add(this.txtNome);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnExcluir);
        this.Controls.Add(this.lblDataValidade);
        this.Controls.Add(this.lblDescricao);
        this.Controls.Add(this.lblNome);
        this.Controls.Add(this.dateDataValidade);
        this.Controls.Add(this.txtDescricao);
        this.MaximizeBox = false;
        this.Name = "ExcluirProdutoForm";
        this.ShowIcon = false;
        this.Text = "Excluir Produto";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.ExcluirProdutoForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox txtId;

    private System.Windows.Forms.Label lblId;

    private System.Windows.Forms.Label lblExcluirProduto;

    private System.Windows.Forms.Label lblQuantidadeEstoque;
    private System.Windows.Forms.TextBox txtPrecoUnitario;

    private System.Windows.Forms.Label lblPrecoUnitario;
    private System.Windows.Forms.TextBox txtQuantidadeEstoque;

    private System.Windows.Forms.TextBox txtNome;

    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnExcluir;

    private System.Windows.Forms.Label lblDataValidade;
    private System.Windows.Forms.Label lblDescricao;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.DateTimePicker dateDataValidade;
    private System.Windows.Forms.TextBox txtDescricao;

    #endregion
}
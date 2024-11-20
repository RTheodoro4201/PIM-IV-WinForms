﻿using System.ComponentModel;

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
        this.btnFechar = new System.Windows.Forms.Button();
        this.txtId = new System.Windows.Forms.TextBox();
        this.lblId = new System.Windows.Forms.Label();
        this.lblPrecoUnitario = new System.Windows.Forms.Label();
        this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
        this.lblQuantidadeEstoque = new System.Windows.Forms.Label();
        this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
        this.txtNome = new System.Windows.Forms.TextBox();
        this.lblDataValidade = new System.Windows.Forms.Label();
        this.lblDescricao = new System.Windows.Forms.Label();
        this.lblNome = new System.Windows.Forms.Label();
        this.dateDataValidade = new System.Windows.Forms.DateTimePicker();
        this.txtDescricao = new System.Windows.Forms.TextBox();
        this.btnExcluir = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // btnFechar
        // 
        this.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnFechar.BackColor = System.Drawing.Color.GhostWhite;
        this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnFechar.Font = new System.Drawing.Font("Tahoma", 12F);
        this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnFechar.Location = new System.Drawing.Point(458, 311);
        this.btnFechar.Name = "btnFechar";
        this.btnFechar.Size = new System.Drawing.Size(148, 52);
        this.btnFechar.TabIndex = 68;
        this.btnFechar.Text = "Fechar";
        this.btnFechar.UseVisualStyleBackColor = false;
        this.btnFechar.Click += new System.EventHandler(this.btnCancelar_Click);
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
        // lblPrecoUnitario
        // 
        this.lblPrecoUnitario.BackColor = System.Drawing.Color.GhostWhite;
        this.lblPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblPrecoUnitario.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblPrecoUnitario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblPrecoUnitario.Location = new System.Drawing.Point(458, 125);
        this.lblPrecoUnitario.Name = "lblPrecoUnitario";
        this.lblPrecoUnitario.Size = new System.Drawing.Size(118, 27);
        this.lblPrecoUnitario.TabIndex = 89;
        this.lblPrecoUnitario.Text = "Preço Unitário";
        this.lblPrecoUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtPrecoUnitario
        // 
        this.txtPrecoUnitario.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtPrecoUnitario.Location = new System.Drawing.Point(582, 126);
        this.txtPrecoUnitario.Name = "txtPrecoUnitario";
        this.txtPrecoUnitario.ReadOnly = true;
        this.txtPrecoUnitario.Size = new System.Drawing.Size(223, 27);
        this.txtPrecoUnitario.TabIndex = 88;
        this.txtPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
        this.lblQuantidadeEstoque.TabIndex = 87;
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
        this.txtQuantidadeEstoque.TabIndex = 86;
        // 
        // txtNome
        // 
        this.txtNome.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtNome.Location = new System.Drawing.Point(220, 90);
        this.txtNome.Name = "txtNome";
        this.txtNome.ReadOnly = true;
        this.txtNome.Size = new System.Drawing.Size(223, 27);
        this.txtNome.TabIndex = 85;
        // 
        // lblDataValidade
        // 
        this.lblDataValidade.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataValidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataValidade.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDataValidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataValidade.Location = new System.Drawing.Point(96, 160);
        this.lblDataValidade.Name = "lblDataValidade";
        this.lblDataValidade.Size = new System.Drawing.Size(138, 30);
        this.lblDataValidade.TabIndex = 80;
        this.lblDataValidade.Text = "Data de Validade";
        this.lblDataValidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblDescricao
        // 
        this.lblDescricao.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDescricao.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDescricao.Location = new System.Drawing.Point(458, 90);
        this.lblDescricao.Name = "lblDescricao";
        this.lblDescricao.Size = new System.Drawing.Size(118, 27);
        this.lblDescricao.TabIndex = 83;
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
        this.lblNome.TabIndex = 82;
        this.lblNome.Text = "Nome";
        this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dateDataValidade
        // 
        this.dateDataValidade.Enabled = false;
        this.dateDataValidade.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataValidade.Location = new System.Drawing.Point(240, 160);
        this.dateDataValidade.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataValidade.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataValidade.Name = "dateDataValidade";
        this.dateDataValidade.Size = new System.Drawing.Size(132, 30);
        this.dateDataValidade.TabIndex = 84;
        this.dateDataValidade.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
        // 
        // txtDescricao
        // 
        this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtDescricao.Location = new System.Drawing.Point(582, 90);
        this.txtDescricao.Name = "txtDescricao";
        this.txtDescricao.ReadOnly = true;
        this.txtDescricao.Size = new System.Drawing.Size(223, 27);
        this.txtDescricao.TabIndex = 81;
        // 
        // btnExcluir
        // 
        this.btnExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnExcluir.BackColor = System.Drawing.Color.GhostWhite;
        this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 12F);
        this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnExcluir.Location = new System.Drawing.Point(271, 311);
        this.btnExcluir.Name = "btnExcluir";
        this.btnExcluir.Size = new System.Drawing.Size(148, 52);
        this.btnExcluir.TabIndex = 90;
        this.btnExcluir.Text = "Excluir";
        this.btnExcluir.UseVisualStyleBackColor = false;
        this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
        // 
        // ExcluirProdutoForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
        this.Controls.Add(this.btnExcluir);
        this.Controls.Add(this.lblPrecoUnitario);
        this.Controls.Add(this.txtPrecoUnitario);
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
        this.Name = "ExcluirProdutoForm";
        this.ShowIcon = false;
        this.Text = "Excluirr Produto";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.ExcluirProdutoForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button btnExcluir;

    private System.Windows.Forms.Label lblPrecoUnitario;
    private System.Windows.Forms.TextBox txtPrecoUnitario;
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
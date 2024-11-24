﻿using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Vendas;

partial class ConsultaVendaForm
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
        this.lblNomeProduto = new System.Windows.Forms.Label();
        this.lblIdProduto = new System.Windows.Forms.Label();
        this.txtNomeProduto = new System.Windows.Forms.TextBox();
        this.btnFechar = new System.Windows.Forms.Button();
        this.txtIdProduto = new System.Windows.Forms.TextBox();
        this.lblQuantidadeVendida = new System.Windows.Forms.Label();
        this.txtQuantidadeVendida = new System.Windows.Forms.TextBox();
        this.lblIdCliente = new System.Windows.Forms.Label();
        this.txtIdCliente = new System.Windows.Forms.TextBox();
        this.lblDataVenda = new System.Windows.Forms.Label();
        this.dateDataVenda = new System.Windows.Forms.DateTimePicker();
        this.lblNomeCliente = new System.Windows.Forms.Label();
        this.txtNomeCliente = new System.Windows.Forms.TextBox();
        this.lblValorUnitario = new System.Windows.Forms.Label();
        this.txtValorUnitario = new System.Windows.Forms.TextBox();
        this.lblValorTotal = new System.Windows.Forms.Label();
        this.txtValorTotal = new System.Windows.Forms.TextBox();
        this.lblDescricaoProduto = new System.Windows.Forms.Label();
        this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
        this.lblConsultaVenda = new System.Windows.Forms.Label();
        this.lblId = new System.Windows.Forms.Label();
        this.txtId = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // lblNomeProduto
        // 
        this.lblNomeProduto.BackColor = System.Drawing.Color.DimGray;
        this.lblNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNomeProduto.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblNomeProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNomeProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNomeProduto.Location = new System.Drawing.Point(45, 110);
        this.lblNomeProduto.Name = "lblNomeProduto";
        this.lblNomeProduto.Size = new System.Drawing.Size(162, 30);
        this.lblNomeProduto.TabIndex = 54;
        this.lblNomeProduto.Text = "Nome do Produto";
        this.lblNomeProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblIdProduto
        // 
        this.lblIdProduto.BackColor = System.Drawing.Color.DimGray;
        this.lblIdProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblIdProduto.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblIdProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblIdProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblIdProduto.Location = new System.Drawing.Point(45, 75);
        this.lblIdProduto.Name = "lblIdProduto";
        this.lblIdProduto.Size = new System.Drawing.Size(167, 30);
        this.lblIdProduto.TabIndex = 50;
        this.lblIdProduto.Text = "Código do Produto";
        this.lblIdProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtNomeProduto
        // 
        this.txtNomeProduto.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNomeProduto.Location = new System.Drawing.Point(213, 110);
        this.txtNomeProduto.Name = "txtNomeProduto";
        this.txtNomeProduto.ReadOnly = true;
        this.txtNomeProduto.Size = new System.Drawing.Size(250, 30);
        this.txtNomeProduto.TabIndex = 43;
        // 
        // btnFechar
        // 
        this.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnFechar.BackColor = System.Drawing.Color.DimGray;
        this.btnFechar.FlatAppearance.BorderSize = 0;
        this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnFechar.Font = new System.Drawing.Font("Tahoma", 14F);
        this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnFechar.Location = new System.Drawing.Point(368, 602);
        this.btnFechar.Name = "btnFechar";
        this.btnFechar.Size = new System.Drawing.Size(148, 52);
        this.btnFechar.TabIndex = 68;
        this.btnFechar.Text = "Fechar";
        this.btnFechar.UseVisualStyleBackColor = false;
        this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
        // 
        // txtIdProduto
        // 
        this.txtIdProduto.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtIdProduto.Location = new System.Drawing.Point(218, 75);
        this.txtIdProduto.Name = "txtIdProduto";
        this.txtIdProduto.ReadOnly = true;
        this.txtIdProduto.Size = new System.Drawing.Size(70, 30);
        this.txtIdProduto.TabIndex = 69;
        // 
        // lblQuantidadeVendida
        // 
        this.lblQuantidadeVendida.BackColor = System.Drawing.Color.DimGray;
        this.lblQuantidadeVendida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblQuantidadeVendida.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblQuantidadeVendida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblQuantidadeVendida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblQuantidadeVendida.Location = new System.Drawing.Point(45, 180);
        this.lblQuantidadeVendida.Name = "lblQuantidadeVendida";
        this.lblQuantidadeVendida.Size = new System.Drawing.Size(184, 30);
        this.lblQuantidadeVendida.TabIndex = 75;
        this.lblQuantidadeVendida.Text = "Quantidade Vendida";
        this.lblQuantidadeVendida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtQuantidadeVendida
        // 
        this.txtQuantidadeVendida.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtQuantidadeVendida.Location = new System.Drawing.Point(235, 180);
        this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
        this.txtQuantidadeVendida.ReadOnly = true;
        this.txtQuantidadeVendida.Size = new System.Drawing.Size(76, 30);
        this.txtQuantidadeVendida.TabIndex = 74;
        // 
        // lblIdCliente
        // 
        this.lblIdCliente.BackColor = System.Drawing.Color.DimGray;
        this.lblIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblIdCliente.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblIdCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblIdCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblIdCliente.Location = new System.Drawing.Point(45, 215);
        this.lblIdCliente.Name = "lblIdCliente";
        this.lblIdCliente.Size = new System.Drawing.Size(162, 30);
        this.lblIdCliente.TabIndex = 77;
        this.lblIdCliente.Text = "Código do Cliente";
        this.lblIdCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtIdCliente
        // 
        this.txtIdCliente.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtIdCliente.Location = new System.Drawing.Point(213, 217);
        this.txtIdCliente.Name = "txtIdCliente";
        this.txtIdCliente.ReadOnly = true;
        this.txtIdCliente.Size = new System.Drawing.Size(70, 30);
        this.txtIdCliente.TabIndex = 76;
        this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblDataVenda
        // 
        this.lblDataVenda.BackColor = System.Drawing.Color.DimGray;
        this.lblDataVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataVenda.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDataVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDataVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataVenda.Location = new System.Drawing.Point(45, 355);
        this.lblDataVenda.Name = "lblDataVenda";
        this.lblDataVenda.Size = new System.Drawing.Size(143, 30);
        this.lblDataVenda.TabIndex = 78;
        this.lblDataVenda.Text = "Data de Venda";
        this.lblDataVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dateDataVenda
        // 
        this.dateDataVenda.Enabled = false;
        this.dateDataVenda.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataVenda.Location = new System.Drawing.Point(194, 355);
        this.dateDataVenda.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataVenda.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataVenda.Name = "dateDataVenda";
        this.dateDataVenda.Size = new System.Drawing.Size(132, 30);
        this.dateDataVenda.TabIndex = 79;
        this.dateDataVenda.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
        // 
        // lblNomeCliente
        // 
        this.lblNomeCliente.BackColor = System.Drawing.Color.DimGray;
        this.lblNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNomeCliente.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblNomeCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNomeCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNomeCliente.Location = new System.Drawing.Point(45, 250);
        this.lblNomeCliente.Name = "lblNomeCliente";
        this.lblNomeCliente.Size = new System.Drawing.Size(162, 30);
        this.lblNomeCliente.TabIndex = 81;
        this.lblNomeCliente.Text = "Nome do Cliente";
        this.lblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtNomeCliente
        // 
        this.txtNomeCliente.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNomeCliente.Location = new System.Drawing.Point(213, 250);
        this.txtNomeCliente.Name = "txtNomeCliente";
        this.txtNomeCliente.ReadOnly = true;
        this.txtNomeCliente.Size = new System.Drawing.Size(250, 30);
        this.txtNomeCliente.TabIndex = 80;
        this.txtNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblValorUnitario
        // 
        this.lblValorUnitario.BackColor = System.Drawing.Color.DimGray;
        this.lblValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblValorUnitario.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblValorUnitario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblValorUnitario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblValorUnitario.Location = new System.Drawing.Point(45, 285);
        this.lblValorUnitario.Name = "lblValorUnitario";
        this.lblValorUnitario.Size = new System.Drawing.Size(128, 30);
        this.lblValorUnitario.TabIndex = 83;
        this.lblValorUnitario.Text = "Valor Unitário";
        this.lblValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtValorUnitario
        // 
        this.txtValorUnitario.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtValorUnitario.Location = new System.Drawing.Point(179, 285);
        this.txtValorUnitario.Name = "txtValorUnitario";
        this.txtValorUnitario.ReadOnly = true;
        this.txtValorUnitario.Size = new System.Drawing.Size(100, 30);
        this.txtValorUnitario.TabIndex = 82;
        // 
        // lblValorTotal
        // 
        this.lblValorTotal.BackColor = System.Drawing.Color.DimGray;
        this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblValorTotal.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblValorTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblValorTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblValorTotal.Location = new System.Drawing.Point(45, 320);
        this.lblValorTotal.Name = "lblValorTotal";
        this.lblValorTotal.Size = new System.Drawing.Size(111, 30);
        this.lblValorTotal.TabIndex = 85;
        this.lblValorTotal.Text = "Valor Total";
        this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtValorTotal
        // 
        this.txtValorTotal.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtValorTotal.Location = new System.Drawing.Point(162, 320);
        this.txtValorTotal.Name = "txtValorTotal";
        this.txtValorTotal.ReadOnly = true;
        this.txtValorTotal.Size = new System.Drawing.Size(100, 30);
        this.txtValorTotal.TabIndex = 84;
        // 
        // lblDescricaoProduto
        // 
        this.lblDescricaoProduto.BackColor = System.Drawing.Color.DimGray;
        this.lblDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDescricaoProduto.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDescricaoProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDescricaoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDescricaoProduto.Location = new System.Drawing.Point(45, 145);
        this.lblDescricaoProduto.Name = "lblDescricaoProduto";
        this.lblDescricaoProduto.Size = new System.Drawing.Size(196, 30);
        this.lblDescricaoProduto.TabIndex = 87;
        this.lblDescricaoProduto.Text = "Descrição do Produto";
        this.lblDescricaoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtDescricaoProduto
        // 
        this.txtDescricaoProduto.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtDescricaoProduto.Location = new System.Drawing.Point(247, 145);
        this.txtDescricaoProduto.Name = "txtDescricaoProduto";
        this.txtDescricaoProduto.ReadOnly = true;
        this.txtDescricaoProduto.Size = new System.Drawing.Size(216, 30);
        this.txtDescricaoProduto.TabIndex = 86;
        // 
        // lblConsultaVenda
        // 
        this.lblConsultaVenda.BackColor = System.Drawing.Color.DimGray;
        this.lblConsultaVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblConsultaVenda.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblConsultaVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblConsultaVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblConsultaVenda.Location = new System.Drawing.Point(45, 25);
        this.lblConsultaVenda.Name = "lblConsultaVenda";
        this.lblConsultaVenda.Size = new System.Drawing.Size(214, 40);
        this.lblConsultaVenda.TabIndex = 88;
        this.lblConsultaVenda.Text = "Consultar Venda";
        this.lblConsultaVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblId
        // 
        this.lblId.BackColor = System.Drawing.Color.DimGray;
        this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblId.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblId.Location = new System.Drawing.Point(265, 25);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(100, 40);
        this.lblId.TabIndex = 89;
        this.lblId.Text = "Código";
        this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtId
        // 
        this.txtId.Font = new System.Drawing.Font("Tahoma", 20F);
        this.txtId.Location = new System.Drawing.Point(371, 25);
        this.txtId.Name = "txtId";
        this.txtId.ReadOnly = true;
        this.txtId.Size = new System.Drawing.Size(90, 40);
        this.txtId.TabIndex = 90;
        // 
        // ConsultaVendaForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblId);
        this.Controls.Add(this.lblConsultaVenda);
        this.Controls.Add(this.lblDescricaoProduto);
        this.Controls.Add(this.txtDescricaoProduto);
        this.Controls.Add(this.lblValorTotal);
        this.Controls.Add(this.txtValorTotal);
        this.Controls.Add(this.lblValorUnitario);
        this.Controls.Add(this.txtValorUnitario);
        this.Controls.Add(this.lblNomeCliente);
        this.Controls.Add(this.txtNomeCliente);
        this.Controls.Add(this.lblDataVenda);
        this.Controls.Add(this.dateDataVenda);
        this.Controls.Add(this.lblIdCliente);
        this.Controls.Add(this.txtIdCliente);
        this.Controls.Add(this.lblQuantidadeVendida);
        this.Controls.Add(this.txtQuantidadeVendida);
        this.Controls.Add(this.txtIdProduto);
        this.Controls.Add(this.btnFechar);
        this.Controls.Add(this.lblNomeProduto);
        this.Controls.Add(this.lblIdProduto);
        this.Controls.Add(this.txtNomeProduto);
        this.MaximizeBox = false;
        this.Name = "ConsultaVendaForm";
        this.ShowIcon = false;
        this.Text = "Consultar Venda";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.ConsultaVendaForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox txtId;

    private System.Windows.Forms.Label lblId;

    private System.Windows.Forms.Label lblConsultaVenda;

    private System.Windows.Forms.Label lblDescricaoProduto;
    private System.Windows.Forms.TextBox txtDescricaoProduto;

    private System.Windows.Forms.Label lblValorTotal;
    private System.Windows.Forms.TextBox txtValorTotal;

    private System.Windows.Forms.Label lblValorUnitario;
    private System.Windows.Forms.TextBox txtValorUnitario;

    private System.Windows.Forms.Label lblNomeCliente;
    private System.Windows.Forms.TextBox txtNomeCliente;

    private System.Windows.Forms.Label lblDataVenda;
    private System.Windows.Forms.DateTimePicker dateDataVenda;

    private System.Windows.Forms.Label lblQuantidadeVendida;
    private System.Windows.Forms.TextBox txtIdCliente;

    private System.Windows.Forms.Label lblIdCliente;
    private System.Windows.Forms.TextBox txtQuantidadeVendida;

    private System.Windows.Forms.TextBox txtIdProduto;

    private System.Windows.Forms.Button btnFechar;

    private System.Windows.Forms.Label lblNomeProduto;
    private System.Windows.Forms.Label lblIdProduto;
    private System.Windows.Forms.TextBox txtNomeProduto;

    #endregion
}
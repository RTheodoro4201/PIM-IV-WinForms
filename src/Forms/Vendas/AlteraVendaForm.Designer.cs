using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Vendas;

partial class AlteraVendaForm
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
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnSalvar = new System.Windows.Forms.Button();
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
        this.txtId = new System.Windows.Forms.TextBox();
        this.lblId = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // lblNomeProduto
        // 
        this.lblNomeProduto.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNomeProduto.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblNomeProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNomeProduto.Location = new System.Drawing.Point(458, 89);
        this.lblNomeProduto.Name = "lblNomeProduto";
        this.lblNomeProduto.Size = new System.Drawing.Size(138, 27);
        this.lblNomeProduto.TabIndex = 54;
        this.lblNomeProduto.Text = "Nome do Produto";
        this.lblNomeProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblIdProduto
        // 
        this.lblIdProduto.BackColor = System.Drawing.Color.GhostWhite;
        this.lblIdProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblIdProduto.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblIdProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblIdProduto.Location = new System.Drawing.Point(96, 90);
        this.lblIdProduto.Name = "lblIdProduto";
        this.lblIdProduto.Size = new System.Drawing.Size(162, 27);
        this.lblIdProduto.TabIndex = 50;
        this.lblIdProduto.Text = "Código do Produto";
        this.lblIdProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtNomeProduto
        // 
        this.txtNomeProduto.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtNomeProduto.Location = new System.Drawing.Point(602, 90);
        this.txtNomeProduto.Name = "txtNomeProduto";
        this.txtNomeProduto.ReadOnly = true;
        this.txtNomeProduto.Size = new System.Drawing.Size(223, 27);
        this.txtNomeProduto.TabIndex = 43;
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
        // txtIdProduto
        // 
        this.txtIdProduto.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtIdProduto.Location = new System.Drawing.Point(264, 90);
        this.txtIdProduto.Name = "txtIdProduto";
        this.txtIdProduto.Size = new System.Drawing.Size(164, 27);
        this.txtIdProduto.TabIndex = 69;
        this.txtIdProduto.Leave += new System.EventHandler(this.txtIdProduto_Leave);
        // 
        // lblQuantidadeVendida
        // 
        this.lblQuantidadeVendida.BackColor = System.Drawing.Color.GhostWhite;
        this.lblQuantidadeVendida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblQuantidadeVendida.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblQuantidadeVendida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblQuantidadeVendida.Location = new System.Drawing.Point(96, 125);
        this.lblQuantidadeVendida.Name = "lblQuantidadeVendida";
        this.lblQuantidadeVendida.Size = new System.Drawing.Size(162, 27);
        this.lblQuantidadeVendida.TabIndex = 75;
        this.lblQuantidadeVendida.Text = "Quantidade Vendida";
        this.lblQuantidadeVendida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtQuantidadeVendida
        // 
        this.txtQuantidadeVendida.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtQuantidadeVendida.Location = new System.Drawing.Point(264, 125);
        this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
        this.txtQuantidadeVendida.Size = new System.Drawing.Size(164, 27);
        this.txtQuantidadeVendida.TabIndex = 74;
        // 
        // lblIdCliente
        // 
        this.lblIdCliente.BackColor = System.Drawing.Color.GhostWhite;
        this.lblIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblIdCliente.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblIdCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblIdCliente.Location = new System.Drawing.Point(96, 195);
        this.lblIdCliente.Name = "lblIdCliente";
        this.lblIdCliente.Size = new System.Drawing.Size(162, 27);
        this.lblIdCliente.TabIndex = 77;
        this.lblIdCliente.Text = "Código do Cliente";
        this.lblIdCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtIdCliente
        // 
        this.txtIdCliente.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtIdCliente.Location = new System.Drawing.Point(264, 196);
        this.txtIdCliente.Name = "txtIdCliente";
        this.txtIdCliente.Size = new System.Drawing.Size(164, 27);
        this.txtIdCliente.TabIndex = 76;
        this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.txtIdCliente.Leave += new System.EventHandler(this.txtIdCliente_Leave);
        // 
        // lblDataVenda
        // 
        this.lblDataVenda.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataVenda.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDataVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataVenda.Location = new System.Drawing.Point(458, 195);
        this.lblDataVenda.Name = "lblDataVenda";
        this.lblDataVenda.Size = new System.Drawing.Size(128, 30);
        this.lblDataVenda.TabIndex = 78;
        this.lblDataVenda.Text = "Data de Venda";
        this.lblDataVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dateDataVenda
        // 
        this.dateDataVenda.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataVenda.Location = new System.Drawing.Point(592, 195);
        this.dateDataVenda.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataVenda.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataVenda.Name = "dateDataVenda";
        this.dateDataVenda.Size = new System.Drawing.Size(132, 30);
        this.dateDataVenda.TabIndex = 79;
        this.dateDataVenda.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
        this.dateDataVenda.Leave += new System.EventHandler(this.dateDataVenda_Leave);
        // 
        // lblNomeCliente
        // 
        this.lblNomeCliente.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNomeCliente.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblNomeCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNomeCliente.Location = new System.Drawing.Point(96, 230);
        this.lblNomeCliente.Name = "lblNomeCliente";
        this.lblNomeCliente.Size = new System.Drawing.Size(162, 27);
        this.lblNomeCliente.TabIndex = 81;
        this.lblNomeCliente.Text = "Nome do Cliente";
        this.lblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtNomeCliente
        // 
        this.txtNomeCliente.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtNomeCliente.Location = new System.Drawing.Point(264, 230);
        this.txtNomeCliente.Name = "txtNomeCliente";
        this.txtNomeCliente.ReadOnly = true;
        this.txtNomeCliente.Size = new System.Drawing.Size(164, 27);
        this.txtNomeCliente.TabIndex = 80;
        this.txtNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblValorUnitario
        // 
        this.lblValorUnitario.BackColor = System.Drawing.Color.GhostWhite;
        this.lblValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblValorUnitario.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblValorUnitario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblValorUnitario.Location = new System.Drawing.Point(96, 161);
        this.lblValorUnitario.Name = "lblValorUnitario";
        this.lblValorUnitario.Size = new System.Drawing.Size(111, 27);
        this.lblValorUnitario.TabIndex = 83;
        this.lblValorUnitario.Text = "Valor Unitário";
        this.lblValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtValorUnitario
        // 
        this.txtValorUnitario.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtValorUnitario.Location = new System.Drawing.Point(213, 162);
        this.txtValorUnitario.Name = "txtValorUnitario";
        this.txtValorUnitario.Size = new System.Drawing.Size(151, 27);
        this.txtValorUnitario.TabIndex = 82;
        this.txtValorUnitario.Leave += new System.EventHandler(this.txtValorUnitario_Leave);
        // 
        // lblValorTotal
        // 
        this.lblValorTotal.BackColor = System.Drawing.Color.GhostWhite;
        this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblValorTotal.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblValorTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblValorTotal.Location = new System.Drawing.Point(458, 161);
        this.lblValorTotal.Name = "lblValorTotal";
        this.lblValorTotal.Size = new System.Drawing.Size(111, 27);
        this.lblValorTotal.TabIndex = 85;
        this.lblValorTotal.Text = "Valor Total";
        this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtValorTotal
        // 
        this.txtValorTotal.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtValorTotal.Location = new System.Drawing.Point(575, 162);
        this.txtValorTotal.Name = "txtValorTotal";
        this.txtValorTotal.ReadOnly = true;
        this.txtValorTotal.Size = new System.Drawing.Size(151, 27);
        this.txtValorTotal.TabIndex = 84;
        // 
        // lblDescricaoProduto
        // 
        this.lblDescricaoProduto.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDescricaoProduto.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDescricaoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDescricaoProduto.Location = new System.Drawing.Point(458, 125);
        this.lblDescricaoProduto.Name = "lblDescricaoProduto";
        this.lblDescricaoProduto.Size = new System.Drawing.Size(167, 27);
        this.lblDescricaoProduto.TabIndex = 87;
        this.lblDescricaoProduto.Text = "Descrição do Produto";
        this.lblDescricaoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtDescricaoProduto
        // 
        this.txtDescricaoProduto.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtDescricaoProduto.Location = new System.Drawing.Point(631, 126);
        this.txtDescricaoProduto.Name = "txtDescricaoProduto";
        this.txtDescricaoProduto.ReadOnly = true;
        this.txtDescricaoProduto.Size = new System.Drawing.Size(194, 27);
        this.txtDescricaoProduto.TabIndex = 86;
        // 
        // txtId
        // 
        this.txtId.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtId.Location = new System.Drawing.Point(434, 21);
        this.txtId.Name = "txtId";
        this.txtId.ReadOnly = true;
        this.txtId.Size = new System.Drawing.Size(86, 27);
        this.txtId.TabIndex = 89;
        // 
        // lblId
        // 
        this.lblId.BackColor = System.Drawing.Color.GhostWhite;
        this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblId.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblId.Location = new System.Drawing.Point(310, 21);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(118, 27);
        this.lblId.TabIndex = 88;
        this.lblId.Text = "Código";
        this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // AlteraVendaForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblId);
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
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.lblNomeProduto);
        this.Controls.Add(this.lblIdProduto);
        this.Controls.Add(this.txtNomeProduto);
        this.MaximizeBox = false;
        this.Name = "AlteraVendaForm";
        this.ShowIcon = false;
        this.Text = "Cadastrar Venda";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.AlteraVendaForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.Label lblId;

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

    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnSalvar;

    private System.Windows.Forms.Label lblNomeProduto;
    private System.Windows.Forms.Label lblIdProduto;
    private System.Windows.Forms.TextBox txtNomeProduto;

    #endregion
}
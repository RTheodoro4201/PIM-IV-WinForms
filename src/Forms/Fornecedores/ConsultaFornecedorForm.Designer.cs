using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Fornecedores;

partial class ConsultaFornecedorForm
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFornecedorForm));
        this.lblEndereco = new System.Windows.Forms.Label();
        this.txtCep = new System.Windows.Forms.MaskedTextBox();
        this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
        this.lblDocumento = new System.Windows.Forms.Label();
        this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
        this.lblTipo = new System.Windows.Forms.Label();
        this.txtIdFornecedor = new System.Windows.Forms.TextBox();
        this.lblIdFornecedor = new System.Windows.Forms.Label();
        this.lblDataInicial = new System.Windows.Forms.Label();
        this.cbUf = new System.Windows.Forms.ComboBox();
        this.lblUf = new System.Windows.Forms.Label();
        this.lblCidade = new System.Windows.Forms.Label();
        this.lblCep = new System.Windows.Forms.Label();
        this.txtNumero = new System.Windows.Forms.TextBox();
        this.txtCidade = new System.Windows.Forms.TextBox();
        this.txtBairro = new System.Windows.Forms.TextBox();
        this.lblComplemento = new System.Windows.Forms.Label();
        this.lblLogradouro = new System.Windows.Forms.Label();
        this.lblNum = new System.Windows.Forms.Label();
        this.lblBairro = new System.Windows.Forms.Label();
        this.lblTelefone = new System.Windows.Forms.Label();
        this.lblEmail = new System.Windows.Forms.Label();
        this.lblNome = new System.Windows.Forms.Label();
        this.dateDataInicial = new System.Windows.Forms.DateTimePicker();
        this.txtLogradouro = new System.Windows.Forms.TextBox();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.txtTipo = new System.Windows.Forms.TextBox();
        this.txtComplemento = new System.Windows.Forms.TextBox();
        this.txtNome = new System.Windows.Forms.TextBox();
        this.btnFechar = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // lblEndereco
        // 
        this.lblEndereco.BackColor = System.Drawing.Color.GhostWhite;
        this.lblEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblEndereco, "lblEndereco");
        this.lblEndereco.Name = "lblEndereco";
        // 
        // txtCep
        // 
        this.txtCep.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtCep, "txtCep");
        this.txtCep.Name = "txtCep";
        this.txtCep.ReadOnly = true;
        // 
        // txtDocumento
        // 
        this.txtDocumento.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtDocumento, "txtDocumento");
        this.txtDocumento.Name = "txtDocumento";
        this.txtDocumento.ReadOnly = true;
        // 
        // lblDocumento
        // 
        this.lblDocumento.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblDocumento, "lblDocumento");
        this.lblDocumento.Name = "lblDocumento";
        // 
        // txtTelefone
        // 
        this.txtTelefone.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtTelefone, "txtTelefone");
        this.txtTelefone.Name = "txtTelefone";
        this.txtTelefone.ReadOnly = true;
        // 
        // lblTipo
        // 
        this.lblTipo.BackColor = System.Drawing.Color.GhostWhite;
        this.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblTipo, "lblTipo");
        this.lblTipo.Name = "lblTipo";
        // 
        // txtIdFornecedor
        // 
        resources.ApplyResources(this.txtIdFornecedor, "txtIdFornecedor");
        this.txtIdFornecedor.Name = "txtIdFornecedor";
        this.txtIdFornecedor.ReadOnly = true;
        // 
        // lblIdFornecedor
        // 
        this.lblIdFornecedor.BackColor = System.Drawing.Color.GhostWhite;
        this.lblIdFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblIdFornecedor, "lblIdFornecedor");
        this.lblIdFornecedor.Name = "lblIdFornecedor";
        // 
        // lblDataInicial
        // 
        this.lblDataInicial.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblDataInicial, "lblDataInicial");
        this.lblDataInicial.Name = "lblDataInicial";
        // 
        // cbUf
        // 
        resources.ApplyResources(this.cbUf, "cbUf");
        this.cbUf.Items.AddRange(new object[] { resources.GetString("cbUf.Items"), resources.GetString("cbUf.Items1"), resources.GetString("cbUf.Items2"), resources.GetString("cbUf.Items3"), resources.GetString("cbUf.Items4"), resources.GetString("cbUf.Items5"), resources.GetString("cbUf.Items6"), resources.GetString("cbUf.Items7"), resources.GetString("cbUf.Items8"), resources.GetString("cbUf.Items9"), resources.GetString("cbUf.Items10"), resources.GetString("cbUf.Items11"), resources.GetString("cbUf.Items12"), resources.GetString("cbUf.Items13"), resources.GetString("cbUf.Items14"), resources.GetString("cbUf.Items15"), resources.GetString("cbUf.Items16"), resources.GetString("cbUf.Items17"), resources.GetString("cbUf.Items18"), resources.GetString("cbUf.Items19"), resources.GetString("cbUf.Items20"), resources.GetString("cbUf.Items21"), resources.GetString("cbUf.Items22"), resources.GetString("cbUf.Items23"), resources.GetString("cbUf.Items24"), resources.GetString("cbUf.Items25") });
        this.cbUf.Name = "cbUf";
        // 
        // lblUf
        // 
        this.lblUf.BackColor = System.Drawing.Color.GhostWhite;
        this.lblUf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblUf, "lblUf");
        this.lblUf.Name = "lblUf";
        // 
        // lblCidade
        // 
        this.lblCidade.BackColor = System.Drawing.Color.GhostWhite;
        this.lblCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblCidade, "lblCidade");
        this.lblCidade.Name = "lblCidade";
        // 
        // lblCep
        // 
        this.lblCep.BackColor = System.Drawing.Color.GhostWhite;
        this.lblCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblCep, "lblCep");
        this.lblCep.Name = "lblCep";
        // 
        // txtNumero
        // 
        resources.ApplyResources(this.txtNumero, "txtNumero");
        this.txtNumero.Name = "txtNumero";
        this.txtNumero.ReadOnly = true;
        // 
        // txtCidade
        // 
        resources.ApplyResources(this.txtCidade, "txtCidade");
        this.txtCidade.Name = "txtCidade";
        this.txtCidade.ReadOnly = true;
        // 
        // txtBairro
        // 
        resources.ApplyResources(this.txtBairro, "txtBairro");
        this.txtBairro.Name = "txtBairro";
        this.txtBairro.ReadOnly = true;
        // 
        // lblComplemento
        // 
        this.lblComplemento.BackColor = System.Drawing.Color.GhostWhite;
        this.lblComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblComplemento, "lblComplemento");
        this.lblComplemento.Name = "lblComplemento";
        // 
        // lblLogradouro
        // 
        this.lblLogradouro.BackColor = System.Drawing.Color.GhostWhite;
        this.lblLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblLogradouro, "lblLogradouro");
        this.lblLogradouro.Name = "lblLogradouro";
        // 
        // lblNum
        // 
        this.lblNum.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblNum, "lblNum");
        this.lblNum.Name = "lblNum";
        // 
        // lblBairro
        // 
        this.lblBairro.BackColor = System.Drawing.Color.GhostWhite;
        this.lblBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblBairro, "lblBairro");
        this.lblBairro.Name = "lblBairro";
        // 
        // lblTelefone
        // 
        this.lblTelefone.BackColor = System.Drawing.Color.GhostWhite;
        this.lblTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblTelefone, "lblTelefone");
        this.lblTelefone.Name = "lblTelefone";
        // 
        // lblEmail
        // 
        this.lblEmail.BackColor = System.Drawing.Color.GhostWhite;
        this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblEmail, "lblEmail");
        this.lblEmail.Name = "lblEmail";
        // 
        // lblNome
        // 
        this.lblNome.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblNome, "lblNome");
        this.lblNome.Name = "lblNome";
        // 
        // dateDataInicial
        // 
        resources.ApplyResources(this.dateDataInicial, "dateDataInicial");
        this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataInicial.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataInicial.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataInicial.Name = "dateDataInicial";
        this.dateDataInicial.Value = new System.DateTime(2024, 11, 2, 0, 0, 0, 0);
        // 
        // txtLogradouro
        // 
        resources.ApplyResources(this.txtLogradouro, "txtLogradouro");
        this.txtLogradouro.Name = "txtLogradouro";
        this.txtLogradouro.ReadOnly = true;
        // 
        // txtEmail
        // 
        resources.ApplyResources(this.txtEmail, "txtEmail");
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.ReadOnly = true;
        // 
        // txtTipo
        // 
        resources.ApplyResources(this.txtTipo, "txtTipo");
        this.txtTipo.Name = "txtTipo";
        this.txtTipo.ReadOnly = true;
        // 
        // txtComplemento
        // 
        resources.ApplyResources(this.txtComplemento, "txtComplemento");
        this.txtComplemento.Name = "txtComplemento";
        this.txtComplemento.ReadOnly = true;
        // 
        // txtNome
        // 
        resources.ApplyResources(this.txtNome, "txtNome");
        this.txtNome.Name = "txtNome";
        this.txtNome.ReadOnly = true;
        // 
        // btnFechar
        // 
        this.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        resources.ApplyResources(this.btnFechar, "btnFechar");
        this.btnFechar.Name = "btnFechar";
        this.btnFechar.UseVisualStyleBackColor = true;
        this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
        // 
        // ConsultaFornecedorForm
        // 
        resources.ApplyResources(this, "$this");
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.Controls.Add(this.btnFechar);
        this.Controls.Add(this.lblEndereco);
        this.Controls.Add(this.txtCep);
        this.Controls.Add(this.txtDocumento);
        this.Controls.Add(this.lblDocumento);
        this.Controls.Add(this.txtTelefone);
        this.Controls.Add(this.lblTipo);
        this.Controls.Add(this.txtIdFornecedor);
        this.Controls.Add(this.lblIdFornecedor);
        this.Controls.Add(this.lblDataInicial);
        this.Controls.Add(this.cbUf);
        this.Controls.Add(this.lblUf);
        this.Controls.Add(this.lblCidade);
        this.Controls.Add(this.lblCep);
        this.Controls.Add(this.txtNumero);
        this.Controls.Add(this.txtCidade);
        this.Controls.Add(this.txtBairro);
        this.Controls.Add(this.lblComplemento);
        this.Controls.Add(this.lblLogradouro);
        this.Controls.Add(this.lblNum);
        this.Controls.Add(this.lblBairro);
        this.Controls.Add(this.lblTelefone);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.lblNome);
        this.Controls.Add(this.dateDataInicial);
        this.Controls.Add(this.txtLogradouro);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.txtTipo);
        this.Controls.Add(this.txtComplemento);
        this.Controls.Add(this.txtNome);
        this.MaximizeBox = false;
        this.Name = "ConsultaFornecedorForm";
        this.ShowIcon = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.ConsultaFornecedorForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Move += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button btnFechar;

    private System.Windows.Forms.Label lblEndereco;
    private System.Windows.Forms.MaskedTextBox txtDocumento;
    private System.Windows.Forms.Label lblDocumento;
    private System.Windows.Forms.Label lblTipo;
    private System.Windows.Forms.Label lblDataInicial;
    private System.Windows.Forms.DateTimePicker dateDataInicial;
    private System.Windows.Forms.TextBox txtTipo;

    private System.Windows.Forms.MaskedTextBox txtCep;
    private System.Windows.Forms.MaskedTextBox txtTelefone;
    private System.Windows.Forms.TextBox txtIdFornecedor;
    private System.Windows.Forms.Label lblIdFornecedor;
    private System.Windows.Forms.ComboBox cbUf;
    private System.Windows.Forms.Label lblUf;
    private System.Windows.Forms.Label lblCidade;
    private System.Windows.Forms.Label lblCep;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.TextBox txtCidade;
    private System.Windows.Forms.TextBox txtBairro;
    private System.Windows.Forms.Label lblComplemento;
    private System.Windows.Forms.Label lblLogradouro;
    private System.Windows.Forms.Label lblNum;
    private System.Windows.Forms.Label lblBairro;
    private System.Windows.Forms.Label lblTelefone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.TextBox txtLogradouro;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.TextBox txtComplemento;
    private System.Windows.Forms.TextBox txtNome;

    #endregion
}
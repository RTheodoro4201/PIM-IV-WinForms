using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Fornecedores;

partial class AlteraFornecedorForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlteraFornecedorForm));
        this.txtNome = new System.Windows.Forms.TextBox();
        this.txtComplemento = new System.Windows.Forms.TextBox();
        this.txtTipo = new System.Windows.Forms.TextBox();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.txtLogradouro = new System.Windows.Forms.TextBox();
        this.dateDataInicial = new System.Windows.Forms.DateTimePicker();
        this.lblNome = new System.Windows.Forms.Label();
        this.lblTelefone = new System.Windows.Forms.Label();
        this.lblEmail = new System.Windows.Forms.Label();
        this.lblComplemento = new System.Windows.Forms.Label();
        this.lblLogradouro = new System.Windows.Forms.Label();
        this.lblNum = new System.Windows.Forms.Label();
        this.lblBairro = new System.Windows.Forms.Label();
        this.txtBairro = new System.Windows.Forms.TextBox();
        this.txtCidade = new System.Windows.Forms.TextBox();
        this.txtNumero = new System.Windows.Forms.TextBox();
        this.lblCep = new System.Windows.Forms.Label();
        this.lblCidade = new System.Windows.Forms.Label();
        this.lblUf = new System.Windows.Forms.Label();
        this.cbUf = new System.Windows.Forms.ComboBox();
        this.lblDataInicial = new System.Windows.Forms.Label();
        this.lblIdFornecedor = new System.Windows.Forms.Label();
        this.txtIdFornecedor = new System.Windows.Forms.TextBox();
        this.lblTipo = new System.Windows.Forms.Label();
        this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
        this.lblDocumento = new System.Windows.Forms.Label();
        this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
        this.txtCep = new System.Windows.Forms.MaskedTextBox();
        this.lblEndereco = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // txtNome
        // 
        resources.ApplyResources(this.txtNome, "txtNome");
        this.txtNome.Name = "txtNome";
        // 
        // txtComplemento
        // 
        resources.ApplyResources(this.txtComplemento, "txtComplemento");
        this.txtComplemento.Name = "txtComplemento";
        // 
        // txtTipo
        // 
        resources.ApplyResources(this.txtTipo, "txtTipo");
        this.txtTipo.Name = "txtTipo";
        this.txtTipo.TextChanged += new System.EventHandler(this.VerificarTipoFornecedor);
        this.txtTipo.Enter += new System.EventHandler(this.VerificarTipoFornecedor);
        this.txtTipo.Leave += new System.EventHandler(this.VerificarTipoFornecedor);
        // 
        // btnSalvar
        // 
        this.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        resources.ApplyResources(this.btnSalvar, "btnSalvar");
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.UseVisualStyleBackColor = true;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        // 
        // btnCancelar
        // 
        this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        resources.ApplyResources(this.btnCancelar, "btnCancelar");
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.UseVisualStyleBackColor = true;
        this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        // 
        // txtEmail
        // 
        resources.ApplyResources(this.txtEmail, "txtEmail");
        this.txtEmail.Name = "txtEmail";
        // 
        // txtLogradouro
        // 
        resources.ApplyResources(this.txtLogradouro, "txtLogradouro");
        this.txtLogradouro.Name = "txtLogradouro";
        // 
        // dateDataInicial
        // 
        this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        resources.ApplyResources(this.dateDataInicial, "dateDataInicial");
        this.dateDataInicial.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataInicial.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataInicial.Name = "dateDataInicial";
        this.dateDataInicial.Value = new System.DateTime(2024, 11, 2, 0, 0, 0, 0);
        this.dateDataInicial.ValueChanged += new System.EventHandler(this.dateDataInicial_ValueChanged);
        // 
        // lblNome
        // 
        this.lblNome.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblNome, "lblNome");
        this.lblNome.Name = "lblNome";
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
        // txtBairro
        // 
        resources.ApplyResources(this.txtBairro, "txtBairro");
        this.txtBairro.Name = "txtBairro";
        // 
        // txtCidade
        // 
        resources.ApplyResources(this.txtCidade, "txtCidade");
        this.txtCidade.Name = "txtCidade";
        // 
        // txtNumero
        // 
        resources.ApplyResources(this.txtNumero, "txtNumero");
        this.txtNumero.Name = "txtNumero";
        // 
        // lblCep
        // 
        this.lblCep.BackColor = System.Drawing.Color.GhostWhite;
        this.lblCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblCep, "lblCep");
        this.lblCep.Name = "lblCep";
        // 
        // lblCidade
        // 
        this.lblCidade.BackColor = System.Drawing.Color.GhostWhite;
        this.lblCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblCidade, "lblCidade");
        this.lblCidade.Name = "lblCidade";
        // 
        // lblUf
        // 
        this.lblUf.BackColor = System.Drawing.Color.GhostWhite;
        this.lblUf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblUf, "lblUf");
        this.lblUf.Name = "lblUf";
        // 
        // cbUf
        // 
        this.cbUf.Items.AddRange(new object[] { resources.GetString("cbUf.Items"), resources.GetString("cbUf.Items1"), resources.GetString("cbUf.Items2"), resources.GetString("cbUf.Items3"), resources.GetString("cbUf.Items4"), resources.GetString("cbUf.Items5"), resources.GetString("cbUf.Items6"), resources.GetString("cbUf.Items7"), resources.GetString("cbUf.Items8"), resources.GetString("cbUf.Items9"), resources.GetString("cbUf.Items10"), resources.GetString("cbUf.Items11"), resources.GetString("cbUf.Items12"), resources.GetString("cbUf.Items13"), resources.GetString("cbUf.Items14"), resources.GetString("cbUf.Items15"), resources.GetString("cbUf.Items16"), resources.GetString("cbUf.Items17"), resources.GetString("cbUf.Items18"), resources.GetString("cbUf.Items19"), resources.GetString("cbUf.Items20"), resources.GetString("cbUf.Items21"), resources.GetString("cbUf.Items22"), resources.GetString("cbUf.Items23"), resources.GetString("cbUf.Items24"), resources.GetString("cbUf.Items25") });
        resources.ApplyResources(this.cbUf, "cbUf");
        this.cbUf.Name = "cbUf";
        // 
        // lblDataInicial
        // 
        this.lblDataInicial.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblDataInicial, "lblDataInicial");
        this.lblDataInicial.Name = "lblDataInicial";
        // 
        // lblIdFornecedor
        // 
        this.lblIdFornecedor.BackColor = System.Drawing.Color.GhostWhite;
        this.lblIdFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblIdFornecedor, "lblIdFornecedor");
        this.lblIdFornecedor.Name = "lblIdFornecedor";
        // 
        // txtIdFornecedor
        // 
        resources.ApplyResources(this.txtIdFornecedor, "txtIdFornecedor");
        this.txtIdFornecedor.Name = "txtIdFornecedor";
        this.txtIdFornecedor.ReadOnly = true;
        // 
        // lblTipo
        // 
        this.lblTipo.BackColor = System.Drawing.Color.GhostWhite;
        this.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblTipo, "lblTipo");
        this.lblTipo.Name = "lblTipo";
        // 
        // txtTelefone
        // 
        this.txtTelefone.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtTelefone, "txtTelefone");
        this.txtTelefone.Name = "txtTelefone";
        // 
        // lblDocumento
        // 
        this.lblDocumento.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblDocumento, "lblDocumento");
        this.lblDocumento.Name = "lblDocumento";
        // 
        // txtDocumento
        // 
        this.txtDocumento.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtDocumento, "txtDocumento");
        this.txtDocumento.Name = "txtDocumento";
        // 
        // txtCep
        // 
        this.txtCep.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtCep, "txtCep");
        this.txtCep.Name = "txtCep";
        // 
        // lblEndereco
        // 
        this.lblEndereco.BackColor = System.Drawing.Color.GhostWhite;
        this.lblEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblEndereco, "lblEndereco");
        this.lblEndereco.Name = "lblEndereco";
        // 
        // AlteraFornecedorForm
        // 
        resources.ApplyResources(this, "$this");
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.PaleGreen;
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
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.txtTipo);
        this.Controls.Add(this.txtComplemento);
        this.Controls.Add(this.txtNome);
        this.MaximizeBox = false;
        this.Name = "AlteraFornecedorForm";
        this.ShowIcon = false;
        this.Load += new System.EventHandler(this.AlteraFornecedorForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Move += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblEndereco;

    private System.Windows.Forms.MaskedTextBox txtCep;

    private System.Windows.Forms.Label lblDocumento;
    private System.Windows.Forms.MaskedTextBox txtDocumento;

    private System.Windows.Forms.MaskedTextBox txtTelefone;

    private System.Windows.Forms.Label lblTipo;

    private System.Windows.Forms.TextBox txtIdFornecedor;

    private System.Windows.Forms.Label lblIdFornecedor;

    private System.Windows.Forms.Label lblCep;

    private System.Windows.Forms.ComboBox cbUf;

    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.Label lblDataInicial;
    private System.Windows.Forms.Label lblCidade;
    private System.Windows.Forms.Label lblUf;

    private System.Windows.Forms.TextBox txtBairro;
    private System.Windows.Forms.TextBox txtCidade;

    private System.Windows.Forms.Label lblTelefone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblComplemento;
    private System.Windows.Forms.Label lblLogradouro;
    private System.Windows.Forms.Label lblNum;
    private System.Windows.Forms.Label lblBairro;

    private System.Windows.Forms.Label lblNome;

    private System.Windows.Forms.DateTimePicker dateDataInicial;

    private System.Windows.Forms.TextBox txtLogradouro;

    private System.Windows.Forms.TextBox txtEmail;

    private System.Windows.Forms.Button btnCancelar;

    private System.Windows.Forms.Button btnSalvar;

    private System.Windows.Forms.TextBox txtTipo;

    private System.Windows.Forms.TextBox txtComplemento;

    private System.Windows.Forms.TextBox txtNome;

    #endregion
}
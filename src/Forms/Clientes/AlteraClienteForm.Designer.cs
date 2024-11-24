using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Clientes;

partial class AlteraClienteForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlteraClienteForm));
        this.txtTipo = new System.Windows.Forms.TextBox();
        this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
        this.lblDataInicial = new System.Windows.Forms.Label();
        this.cbUf = new System.Windows.Forms.ComboBox();
        this.lblUf = new System.Windows.Forms.Label();
        this.lblCidade = new System.Windows.Forms.Label();
        this.lblCep = new System.Windows.Forms.Label();
        this.txtCidade = new System.Windows.Forms.TextBox();
        this.txtBairro = new System.Windows.Forms.TextBox();
        this.lblComplemento = new System.Windows.Forms.Label();
        this.lblLogradouro = new System.Windows.Forms.Label();
        this.lblNum = new System.Windows.Forms.Label();
        this.lblBairro = new System.Windows.Forms.Label();
        this.lblDocumento = new System.Windows.Forms.Label();
        this.lblTipo = new System.Windows.Forms.Label();
        this.lblTelefone = new System.Windows.Forms.Label();
        this.lblEmail = new System.Windows.Forms.Label();
        this.lblNome = new System.Windows.Forms.Label();
        this.txtNumero = new System.Windows.Forms.TextBox();
        this.dateDataInicial = new System.Windows.Forms.DateTimePicker();
        this.txtLogradouro = new System.Windows.Forms.TextBox();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.txtTelefone = new System.Windows.Forms.TextBox();
        this.txtComplemento = new System.Windows.Forms.TextBox();
        this.txtNome = new System.Windows.Forms.TextBox();
        this.lblAlteraCliente = new System.Windows.Forms.Label();
        this.txtCep = new System.Windows.Forms.TextBox();
        this.lblIdCliente = new System.Windows.Forms.Label();
        this.txtIdCliente = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // txtTipo
        // 
        resources.ApplyResources(this.txtTipo, "txtTipo");
        this.txtTipo.Name = "txtTipo";
        // 
        // txtDocumento
        // 
        resources.ApplyResources(this.txtDocumento, "txtDocumento");
        this.txtDocumento.Name = "txtDocumento";
        // 
        // lblDataInicial
        // 
        this.lblDataInicial.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblDataInicial, "lblDataInicial");
        this.lblDataInicial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDataInicial.Name = "lblDataInicial";
        // 
        // cbUf
        // 
        resources.ApplyResources(this.cbUf, "cbUf");
        this.cbUf.FormattingEnabled = true;
        this.cbUf.Items.AddRange(new object[] { resources.GetString("cbUf.Items"), resources.GetString("cbUf.Items1"), resources.GetString("cbUf.Items2"), resources.GetString("cbUf.Items3"), resources.GetString("cbUf.Items4"), resources.GetString("cbUf.Items5"), resources.GetString("cbUf.Items6"), resources.GetString("cbUf.Items7"), resources.GetString("cbUf.Items8"), resources.GetString("cbUf.Items9"), resources.GetString("cbUf.Items10"), resources.GetString("cbUf.Items11"), resources.GetString("cbUf.Items12"), resources.GetString("cbUf.Items13"), resources.GetString("cbUf.Items14"), resources.GetString("cbUf.Items15"), resources.GetString("cbUf.Items16"), resources.GetString("cbUf.Items17"), resources.GetString("cbUf.Items18"), resources.GetString("cbUf.Items19"), resources.GetString("cbUf.Items20"), resources.GetString("cbUf.Items21"), resources.GetString("cbUf.Items22"), resources.GetString("cbUf.Items23"), resources.GetString("cbUf.Items24"), resources.GetString("cbUf.Items25") });
        this.cbUf.Name = "cbUf";
        // 
        // lblUf
        // 
        this.lblUf.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblUf, "lblUf");
        this.lblUf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblUf.Name = "lblUf";
        // 
        // lblCidade
        // 
        this.lblCidade.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblCidade, "lblCidade");
        this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCidade.Name = "lblCidade";
        // 
        // lblCep
        // 
        this.lblCep.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblCep, "lblCep");
        this.lblCep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCep.Name = "lblCep";
        // 
        // txtCidade
        // 
        resources.ApplyResources(this.txtCidade, "txtCidade");
        this.txtCidade.Name = "txtCidade";
        // 
        // txtBairro
        // 
        resources.ApplyResources(this.txtBairro, "txtBairro");
        this.txtBairro.Name = "txtBairro";
        // 
        // lblComplemento
        // 
        this.lblComplemento.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblComplemento, "lblComplemento");
        this.lblComplemento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblComplemento.Name = "lblComplemento";
        // 
        // lblLogradouro
        // 
        this.lblLogradouro.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblLogradouro, "lblLogradouro");
        this.lblLogradouro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblLogradouro.Name = "lblLogradouro";
        // 
        // lblNum
        // 
        this.lblNum.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblNum, "lblNum");
        this.lblNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNum.Name = "lblNum";
        // 
        // lblBairro
        // 
        this.lblBairro.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblBairro, "lblBairro");
        this.lblBairro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblBairro.Name = "lblBairro";
        // 
        // lblDocumento
        // 
        this.lblDocumento.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblDocumento, "lblDocumento");
        this.lblDocumento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDocumento.Name = "lblDocumento";
        // 
        // lblTipo
        // 
        this.lblTipo.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblTipo, "lblTipo");
        this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblTipo.Name = "lblTipo";
        // 
        // lblTelefone
        // 
        this.lblTelefone.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblTelefone, "lblTelefone");
        this.lblTelefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblTelefone.Name = "lblTelefone";
        // 
        // lblEmail
        // 
        this.lblEmail.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblEmail, "lblEmail");
        this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblEmail.Name = "lblEmail";
        // 
        // lblNome
        // 
        this.lblNome.BackColor = System.Drawing.Color.DimGray;
        this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblNome, "lblNome");
        this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNome.Name = "lblNome";
        // 
        // txtNumero
        // 
        resources.ApplyResources(this.txtNumero, "txtNumero");
        this.txtNumero.Name = "txtNumero";
        // 
        // dateDataInicial
        // 
        resources.ApplyResources(this.dateDataInicial, "dateDataInicial");
        this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataInicial.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataInicial.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataInicial.Name = "dateDataInicial";
        this.dateDataInicial.Value = new System.DateTime(2002, 10, 13, 0, 0, 0, 0);
        this.dateDataInicial.Leave += new System.EventHandler(this.dateDataInicial_ValueChanged);
        // 
        // txtLogradouro
        // 
        resources.ApplyResources(this.txtLogradouro, "txtLogradouro");
        this.txtLogradouro.Name = "txtLogradouro";
        // 
        // txtEmail
        // 
        resources.ApplyResources(this.txtEmail, "txtEmail");
        this.txtEmail.Name = "txtEmail";
        // 
        // btnCancelar
        // 
        this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
        this.btnCancelar.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnCancelar, "btnCancelar");
        this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.UseVisualStyleBackColor = false;
        this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        // 
        // btnSalvar
        // 
        this.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnSalvar.BackColor = System.Drawing.Color.DimGray;
        this.btnSalvar.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnSalvar, "btnSalvar");
        this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.UseVisualStyleBackColor = false;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        // 
        // txtTelefone
        // 
        resources.ApplyResources(this.txtTelefone, "txtTelefone");
        this.txtTelefone.Name = "txtTelefone";
        // 
        // txtComplemento
        // 
        resources.ApplyResources(this.txtComplemento, "txtComplemento");
        this.txtComplemento.Name = "txtComplemento";
        // 
        // txtNome
        // 
        resources.ApplyResources(this.txtNome, "txtNome");
        this.txtNome.Name = "txtNome";
        // 
        // lblAlteraCliente
        // 
        this.lblAlteraCliente.BackColor = System.Drawing.Color.DimGray;
        this.lblAlteraCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblAlteraCliente, "lblAlteraCliente");
        this.lblAlteraCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblAlteraCliente.Name = "lblAlteraCliente";
        // 
        // txtCep
        // 
        resources.ApplyResources(this.txtCep, "txtCep");
        this.txtCep.Name = "txtCep";
        // 
        // lblIdCliente
        // 
        this.lblIdCliente.BackColor = System.Drawing.Color.DimGray;
        this.lblIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblIdCliente, "lblIdCliente");
        this.lblIdCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblIdCliente.Name = "lblIdCliente";
        // 
        // txtIdCliente
        // 
        resources.ApplyResources(this.txtIdCliente, "txtIdCliente");
        this.txtIdCliente.Name = "txtIdCliente";
        this.txtIdCliente.ReadOnly = true;
        // 
        // AlteraClienteForm
        // 
        resources.ApplyResources(this, "$this");
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.Controls.Add(this.txtIdCliente);
        this.Controls.Add(this.lblIdCliente);
        this.Controls.Add(this.txtCep);
        this.Controls.Add(this.lblAlteraCliente);
        this.Controls.Add(this.txtTipo);
        this.Controls.Add(this.txtDocumento);
        this.Controls.Add(this.lblDataInicial);
        this.Controls.Add(this.cbUf);
        this.Controls.Add(this.lblUf);
        this.Controls.Add(this.lblCidade);
        this.Controls.Add(this.lblCep);
        this.Controls.Add(this.txtCidade);
        this.Controls.Add(this.txtBairro);
        this.Controls.Add(this.lblComplemento);
        this.Controls.Add(this.lblLogradouro);
        this.Controls.Add(this.lblNum);
        this.Controls.Add(this.lblBairro);
        this.Controls.Add(this.lblDocumento);
        this.Controls.Add(this.lblTipo);
        this.Controls.Add(this.lblTelefone);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.lblNome);
        this.Controls.Add(this.txtNumero);
        this.Controls.Add(this.dateDataInicial);
        this.Controls.Add(this.txtLogradouro);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.txtTelefone);
        this.Controls.Add(this.txtComplemento);
        this.Controls.Add(this.txtNome);
        this.MaximizeBox = false;
        this.Name = "AlteraClienteForm";
        this.ShowIcon = false;
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.AlteraClienteForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblIdCliente;
    private System.Windows.Forms.TextBox txtIdCliente;
    private System.Windows.Forms.Label lblAlteraCliente;

    private System.Windows.Forms.TextBox txtTipo;
    private System.Windows.Forms.MaskedTextBox txtDocumento;
    private System.Windows.Forms.Label lblDataInicial;
    private System.Windows.Forms.ComboBox cbUf;
    private System.Windows.Forms.Label lblUf;
    private System.Windows.Forms.Label lblCidade;
    private System.Windows.Forms.Label lblCep;
    private System.Windows.Forms.TextBox txtCep;
    private System.Windows.Forms.TextBox txtCidade;
    private System.Windows.Forms.TextBox txtBairro;
    private System.Windows.Forms.Label lblComplemento;
    private System.Windows.Forms.Label lblLogradouro;
    private System.Windows.Forms.Label lblNum;
    private System.Windows.Forms.Label lblBairro;
    private System.Windows.Forms.Label lblDocumento;
    private System.Windows.Forms.Label lblTipo;
    private System.Windows.Forms.Label lblTelefone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.DateTimePicker dateDataInicial;
    private System.Windows.Forms.TextBox txtLogradouro;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.TextBox txtTelefone;
    private System.Windows.Forms.TextBox txtComplemento;
    private System.Windows.Forms.TextBox txtNome;

    #endregion
}
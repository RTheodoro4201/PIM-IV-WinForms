using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Fornecedores;

partial class CadastroFornecedorForm
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
        System.Windows.Forms.Label lblComplemento;
        this.txtCep = new System.Windows.Forms.MaskedTextBox();
        this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
        this.lblDocumento = new System.Windows.Forms.Label();
        this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
        this.lblTipo = new System.Windows.Forms.Label();
        this.lblDataInicial = new System.Windows.Forms.Label();
        this.cbUf = new System.Windows.Forms.ComboBox();
        this.lblUf = new System.Windows.Forms.Label();
        this.lblCidade = new System.Windows.Forms.Label();
        this.lblCep = new System.Windows.Forms.Label();
        this.txtNumero = new System.Windows.Forms.TextBox();
        this.txtCidade = new System.Windows.Forms.TextBox();
        this.txtBairro = new System.Windows.Forms.TextBox();
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
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.txtNome = new System.Windows.Forms.TextBox();
        this.lblCadastroFornecedor = new System.Windows.Forms.Label();
        lblComplemento = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // lblComplemento
        // 
        lblComplemento.BackColor = System.Drawing.Color.DimGray;
        lblComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        lblComplemento.Font = new System.Drawing.Font("Tahoma", 14F);
        lblComplemento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        lblComplemento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        lblComplemento.Location = new System.Drawing.Point(45, 355);
        lblComplemento.Name = "lblComplemento";
        lblComplemento.Size = new System.Drawing.Size(135, 30);
        lblComplemento.TabIndex = 60;
        lblComplemento.Text = "Complemento";
        lblComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtCep
        // 
        this.txtCep.Culture = new System.Globalization.CultureInfo("");
        this.txtCep.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtCep.Location = new System.Drawing.Point(96, 495);
        this.txtCep.Mask = "99999-999";
        this.txtCep.Name = "txtCep";
        this.txtCep.Size = new System.Drawing.Size(124, 30);
        this.txtCep.TabIndex = 52;
        // 
        // txtDocumento
        // 
        this.txtDocumento.Culture = new System.Globalization.CultureInfo("");
        this.txtDocumento.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtDocumento.Location = new System.Drawing.Point(166, 145);
        this.txtDocumento.Mask = "999.999.999-99";
        this.txtDocumento.Name = "txtDocumento";
        this.txtDocumento.Size = new System.Drawing.Size(140, 30);
        this.txtDocumento.TabIndex = 45;
        // 
        // lblDocumento
        // 
        this.lblDocumento.BackColor = System.Drawing.Color.DimGray;
        this.lblDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDocumento.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDocumento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDocumento.Location = new System.Drawing.Point(45, 145);
        this.lblDocumento.Name = "lblDocumento";
        this.lblDocumento.Size = new System.Drawing.Size(115, 30);
        this.lblDocumento.TabIndex = 65;
        this.lblDocumento.Text = "Documento";
        this.lblDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtTelefone
        // 
        this.txtTelefone.Culture = new System.Globalization.CultureInfo("");
        this.txtTelefone.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtTelefone.Location = new System.Drawing.Point(137, 215);
        this.txtTelefone.Mask = "(99) 99999-9999";
        this.txtTelefone.Name = "txtTelefone";
        this.txtTelefone.Size = new System.Drawing.Size(146, 30);
        this.txtTelefone.TabIndex = 44;
        // 
        // lblTipo
        // 
        this.lblTipo.BackColor = System.Drawing.Color.DimGray;
        this.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTipo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblTipo.Location = new System.Drawing.Point(45, 110);
        this.lblTipo.Name = "lblTipo";
        this.lblTipo.Size = new System.Drawing.Size(48, 30);
        this.lblTipo.TabIndex = 64;
        this.lblTipo.Text = "Tipo";
        this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblDataInicial
        // 
        this.lblDataInicial.BackColor = System.Drawing.Color.DimGray;
        this.lblDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataInicial.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDataInicial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDataInicial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataInicial.Location = new System.Drawing.Point(45, 250);
        this.lblDataInicial.Name = "lblDataInicial";
        this.lblDataInicial.Size = new System.Drawing.Size(115, 30);
        this.lblDataInicial.TabIndex = 42;
        this.lblDataInicial.Text = "Data Inicial";
        this.lblDataInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // cbUf
        // 
        this.cbUf.Font = new System.Drawing.Font("Tahoma", 14F);
        this.cbUf.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "SC", "SP", "SE", "TO" });
        this.cbUf.Location = new System.Drawing.Point(86, 460);
        this.cbUf.Name = "cbUf";
        this.cbUf.Size = new System.Drawing.Size(124, 31);
        this.cbUf.TabIndex = 49;
        // 
        // lblUf
        // 
        this.lblUf.BackColor = System.Drawing.Color.DimGray;
        this.lblUf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblUf.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblUf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblUf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblUf.Location = new System.Drawing.Point(45, 460);
        this.lblUf.Name = "lblUf";
        this.lblUf.Size = new System.Drawing.Size(35, 30);
        this.lblUf.TabIndex = 63;
        this.lblUf.Text = "UF";
        this.lblUf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCidade
        // 
        this.lblCidade.BackColor = System.Drawing.Color.DimGray;
        this.lblCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCidade.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblCidade.Location = new System.Drawing.Point(45, 425);
        this.lblCidade.Name = "lblCidade";
        this.lblCidade.Size = new System.Drawing.Size(70, 30);
        this.lblCidade.TabIndex = 62;
        this.lblCidade.Text = "Cidade";
        this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCep
        // 
        this.lblCep.BackColor = System.Drawing.Color.DimGray;
        this.lblCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCep.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblCep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblCep.Location = new System.Drawing.Point(45, 495);
        this.lblCep.Name = "lblCep";
        this.lblCep.Size = new System.Drawing.Size(45, 30);
        this.lblCep.TabIndex = 61;
        this.lblCep.Text = "CEP";
        this.lblCep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtNumero
        // 
        this.txtNumero.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNumero.Location = new System.Drawing.Point(136, 320);
        this.txtNumero.Name = "txtNumero";
        this.txtNumero.Size = new System.Drawing.Size(124, 30);
        this.txtNumero.TabIndex = 47;
        // 
        // txtCidade
        // 
        this.txtCidade.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtCidade.Location = new System.Drawing.Point(121, 425);
        this.txtCidade.Name = "txtCidade";
        this.txtCidade.Size = new System.Drawing.Size(225, 30);
        this.txtCidade.TabIndex = 51;
        // 
        // txtBairro
        // 
        this.txtBairro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtBairro.Location = new System.Drawing.Point(121, 390);
        this.txtBairro.Name = "txtBairro";
        this.txtBairro.Size = new System.Drawing.Size(225, 30);
        this.txtBairro.TabIndex = 53;
        // 
        // lblLogradouro
        // 
        this.lblLogradouro.BackColor = System.Drawing.Color.DimGray;
        this.lblLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblLogradouro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblLogradouro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblLogradouro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblLogradouro.Location = new System.Drawing.Point(45, 285);
        this.lblLogradouro.Name = "lblLogradouro";
        this.lblLogradouro.Size = new System.Drawing.Size(115, 30);
        this.lblLogradouro.TabIndex = 59;
        this.lblLogradouro.Text = "Logradouro";
        this.lblLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblNum
        // 
        this.lblNum.BackColor = System.Drawing.Color.DimGray;
        this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNum.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNum.Location = new System.Drawing.Point(45, 320);
        this.lblNum.Name = "lblNum";
        this.lblNum.Size = new System.Drawing.Size(85, 30);
        this.lblNum.TabIndex = 58;
        this.lblNum.Text = "Número";
        this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblBairro
        // 
        this.lblBairro.BackColor = System.Drawing.Color.DimGray;
        this.lblBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblBairro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblBairro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblBairro.Location = new System.Drawing.Point(45, 390);
        this.lblBairro.Name = "lblBairro";
        this.lblBairro.Size = new System.Drawing.Size(70, 30);
        this.lblBairro.TabIndex = 57;
        this.lblBairro.Text = "Bairro";
        this.lblBairro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblTelefone
        // 
        this.lblTelefone.BackColor = System.Drawing.Color.DimGray;
        this.lblTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTelefone.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblTelefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblTelefone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblTelefone.Location = new System.Drawing.Point(45, 215);
        this.lblTelefone.Name = "lblTelefone";
        this.lblTelefone.Size = new System.Drawing.Size(86, 30);
        this.lblTelefone.TabIndex = 55;
        this.lblTelefone.Text = "Telefone";
        this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblEmail
        // 
        this.lblEmail.BackColor = System.Drawing.Color.DimGray;
        this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblEmail.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblEmail.Location = new System.Drawing.Point(45, 180);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(58, 30);
        this.lblEmail.TabIndex = 54;
        this.lblEmail.Text = "Email";
        this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        this.lblNome.Size = new System.Drawing.Size(74, 30);
        this.lblNome.TabIndex = 50;
        this.lblNome.Text = "Nome";
        this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dateDataInicial
        // 
        this.dateDataInicial.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataInicial.Location = new System.Drawing.Point(167, 250);
        this.dateDataInicial.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataInicial.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataInicial.Name = "dateDataInicial";
        this.dateDataInicial.Size = new System.Drawing.Size(132, 30);
        this.dateDataInicial.TabIndex = 56;
        this.dateDataInicial.Value = new System.DateTime(2006, 11, 2, 0, 0, 0, 0);
        this.dateDataInicial.ValueChanged += new System.EventHandler(this.dateDataInicial_ValueChanged);
        this.dateDataInicial.Enter += new System.EventHandler(this.dateDataInicial_ValueChanged);
        this.dateDataInicial.Leave += new System.EventHandler(this.dateDataInicial_ValueChanged);
        this.dateDataInicial.Validated += new System.EventHandler(this.dateDataInicial_ValueChanged);
        // 
        // txtLogradouro
        // 
        this.txtLogradouro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtLogradouro.Location = new System.Drawing.Point(167, 285);
        this.txtLogradouro.Name = "txtLogradouro";
        this.txtLogradouro.Size = new System.Drawing.Size(225, 30);
        this.txtLogradouro.TabIndex = 46;
        // 
        // txtEmail
        // 
        this.txtEmail.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtEmail.Location = new System.Drawing.Point(109, 180);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(302, 30);
        this.txtEmail.TabIndex = 43;
        // 
        // txtTipo
        // 
        this.txtTipo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtTipo.Location = new System.Drawing.Point(99, 110);
        this.txtTipo.Name = "txtTipo";
        this.txtTipo.Size = new System.Drawing.Size(124, 30);
        this.txtTipo.TabIndex = 40;
        this.txtTipo.TextChanged += new System.EventHandler(this.VerificarTipoFornecedor);
        this.txtTipo.Enter += new System.EventHandler(this.VerificarTipoFornecedor);
        this.txtTipo.Leave += new System.EventHandler(this.VerificarTipoFornecedor);
        // 
        // txtComplemento
        // 
        this.txtComplemento.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtComplemento.Location = new System.Drawing.Point(186, 355);
        this.txtComplemento.Name = "txtComplemento";
        this.txtComplemento.Size = new System.Drawing.Size(225, 30);
        this.txtComplemento.TabIndex = 48;
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
        // txtNome
        // 
        this.txtNome.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNome.Location = new System.Drawing.Point(125, 75);
        this.txtNome.Name = "txtNome";
        this.txtNome.Size = new System.Drawing.Size(390, 30);
        this.txtNome.TabIndex = 69;
        // 
        // lblCadastroFornecedor
        // 
        this.lblCadastroFornecedor.BackColor = System.Drawing.Color.DimGray;
        this.lblCadastroFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCadastroFornecedor.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblCadastroFornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCadastroFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.lblCadastroFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblCadastroFornecedor.Location = new System.Drawing.Point(45, 25);
        this.lblCadastroFornecedor.Name = "lblCadastroFornecedor";
        this.lblCadastroFornecedor.Size = new System.Drawing.Size(290, 40);
        this.lblCadastroFornecedor.TabIndex = 70;
        this.lblCadastroFornecedor.Text = "Cadastrar Fornecedor";
        this.lblCadastroFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CadastroFornecedorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
        this.Controls.Add(this.lblCadastroFornecedor);
        this.Controls.Add(this.txtNome);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.txtCep);
        this.Controls.Add(this.txtDocumento);
        this.Controls.Add(this.lblDocumento);
        this.Controls.Add(this.txtTelefone);
        this.Controls.Add(this.lblTipo);
        this.Controls.Add(this.lblDataInicial);
        this.Controls.Add(this.cbUf);
        this.Controls.Add(this.lblUf);
        this.Controls.Add(this.lblCidade);
        this.Controls.Add(this.lblCep);
        this.Controls.Add(this.txtNumero);
        this.Controls.Add(this.txtCidade);
        this.Controls.Add(this.txtBairro);
        this.Controls.Add(lblComplemento);
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
        this.MaximizeBox = false;
        this.Name = "CadastroFornecedorForm";
        this.ShowIcon = false;
        this.Text = "Cadastrar Fornecedor";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.CadastroFornecedorForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblCadastroFornecedor;

    private System.Windows.Forms.TextBox txtNome;

    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnSalvar;

    private System.Windows.Forms.MaskedTextBox txtCep;
    private System.Windows.Forms.MaskedTextBox txtDocumento;
    private System.Windows.Forms.Label lblDocumento;
    private System.Windows.Forms.MaskedTextBox txtTelefone;
    private System.Windows.Forms.Label lblTipo;
    private System.Windows.Forms.Label lblDataInicial;
    private System.Windows.Forms.ComboBox cbUf;
    private System.Windows.Forms.Label lblUf;
    private System.Windows.Forms.Label lblCidade;
    private System.Windows.Forms.Label lblCep;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.TextBox txtCidade;
    private System.Windows.Forms.TextBox txtBairro;
    private System.Windows.Forms.Label lblLogradouro;
    private System.Windows.Forms.Label lblNum;
    private System.Windows.Forms.Label lblBairro;
    private System.Windows.Forms.Label lblTelefone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.DateTimePicker dateDataInicial;
    private System.Windows.Forms.TextBox txtLogradouro;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.TextBox txtTipo;
    private System.Windows.Forms.TextBox txtComplemento;

    #endregion
}
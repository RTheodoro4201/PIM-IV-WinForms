using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Clientes;

partial class CadastroClienteForm
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
        this.lblCadastroCliente = new System.Windows.Forms.Label();
        this.txtCep = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // txtTipo
        // 
        this.txtTipo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtTipo.Location = new System.Drawing.Point(100, 145);
        this.txtTipo.Name = "txtTipo";
        this.txtTipo.Size = new System.Drawing.Size(112, 30);
        this.txtTipo.TabIndex = 61;
        // 
        // txtDocumento
        // 
        this.txtDocumento.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtDocumento.Location = new System.Drawing.Point(170, 110);
        this.txtDocumento.Name = "txtDocumento";
        this.txtDocumento.Size = new System.Drawing.Size(166, 30);
        this.txtDocumento.TabIndex = 60;
        // 
        // lblDataInicial
        // 
        this.lblDataInicial.BackColor = System.Drawing.Color.DimGray;
        this.lblDataInicial.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDataInicial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDataInicial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataInicial.Location = new System.Drawing.Point(46, 495);
        this.lblDataInicial.Name = "lblDataInicial";
        this.lblDataInicial.Size = new System.Drawing.Size(186, 30);
        this.lblDataInicial.TabIndex = 59;
        this.lblDataInicial.Text = "Data Inicial";
        this.lblDataInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // cbUf
        // 
        this.cbUf.Font = new System.Drawing.Font("Tahoma", 14F);
        this.cbUf.FormattingEnabled = true;
        this.cbUf.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "SC", "SP", "SE", "TO" });
        this.cbUf.Location = new System.Drawing.Point(91, 425);
        this.cbUf.Name = "cbUf";
        this.cbUf.Size = new System.Drawing.Size(75, 31);
        this.cbUf.TabIndex = 58;
        // 
        // lblUf
        // 
        this.lblUf.BackColor = System.Drawing.Color.DimGray;
        this.lblUf.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblUf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblUf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblUf.Location = new System.Drawing.Point(46, 425);
        this.lblUf.Name = "lblUf";
        this.lblUf.Size = new System.Drawing.Size(35, 30);
        this.lblUf.TabIndex = 57;
        this.lblUf.Text = "UF";
        this.lblUf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblCidade
        // 
        this.lblCidade.BackColor = System.Drawing.Color.DimGray;
        this.lblCidade.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblCidade.Location = new System.Drawing.Point(46, 390);
        this.lblCidade.Name = "lblCidade";
        this.lblCidade.Size = new System.Drawing.Size(70, 30);
        this.lblCidade.TabIndex = 56;
        this.lblCidade.Text = "Cidade";
        this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblCep
        // 
        this.lblCep.BackColor = System.Drawing.Color.DimGray;
        this.lblCep.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblCep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblCep.Location = new System.Drawing.Point(46, 460);
        this.lblCep.Name = "lblCep";
        this.lblCep.Size = new System.Drawing.Size(45, 30);
        this.lblCep.TabIndex = 55;
        this.lblCep.Text = "CEP";
        this.lblCep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtCidade
        // 
        this.txtCidade.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtCidade.Location = new System.Drawing.Point(125, 390);
        this.txtCidade.Name = "txtCidade";
        this.txtCidade.Size = new System.Drawing.Size(158, 30);
        this.txtCidade.TabIndex = 53;
        // 
        // txtBairro
        // 
        this.txtBairro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtBairro.Location = new System.Drawing.Point(125, 355);
        this.txtBairro.Name = "txtBairro";
        this.txtBairro.Size = new System.Drawing.Size(246, 30);
        this.txtBairro.TabIndex = 52;
        // 
        // lblComplemento
        // 
        this.lblComplemento.BackColor = System.Drawing.Color.DimGray;
        this.lblComplemento.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblComplemento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblComplemento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblComplemento.Location = new System.Drawing.Point(45, 320);
        this.lblComplemento.Name = "lblComplemento";
        this.lblComplemento.Size = new System.Drawing.Size(135, 30);
        this.lblComplemento.TabIndex = 51;
        this.lblComplemento.Text = "Complemento";
        this.lblComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblLogradouro
        // 
        this.lblLogradouro.BackColor = System.Drawing.Color.DimGray;
        this.lblLogradouro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblLogradouro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblLogradouro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblLogradouro.Location = new System.Drawing.Point(46, 250);
        this.lblLogradouro.Name = "lblLogradouro";
        this.lblLogradouro.Size = new System.Drawing.Size(115, 30);
        this.lblLogradouro.TabIndex = 50;
        this.lblLogradouro.Text = "Logradouro";
        this.lblLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblNum
        // 
        this.lblNum.BackColor = System.Drawing.Color.DimGray;
        this.lblNum.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNum.Location = new System.Drawing.Point(46, 285);
        this.lblNum.Name = "lblNum";
        this.lblNum.Size = new System.Drawing.Size(80, 30);
        this.lblNum.TabIndex = 49;
        this.lblNum.Text = "Número";
        this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblBairro
        // 
        this.lblBairro.BackColor = System.Drawing.Color.DimGray;
        this.lblBairro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblBairro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblBairro.Location = new System.Drawing.Point(46, 355);
        this.lblBairro.Name = "lblBairro";
        this.lblBairro.Size = new System.Drawing.Size(70, 30);
        this.lblBairro.TabIndex = 48;
        this.lblBairro.Text = "Bairro";
        this.lblBairro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblDocumento
        // 
        this.lblDocumento.BackColor = System.Drawing.Color.DimGray;
        this.lblDocumento.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDocumento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDocumento.Location = new System.Drawing.Point(46, 110);
        this.lblDocumento.Name = "lblDocumento";
        this.lblDocumento.Size = new System.Drawing.Size(115, 30);
        this.lblDocumento.TabIndex = 47;
        this.lblDocumento.Text = "Documento";
        this.lblDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTipo
        // 
        this.lblTipo.BackColor = System.Drawing.Color.DimGray;
        this.lblTipo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblTipo.Location = new System.Drawing.Point(46, 145);
        this.lblTipo.Name = "lblTipo";
        this.lblTipo.Size = new System.Drawing.Size(48, 30);
        this.lblTipo.TabIndex = 46;
        this.lblTipo.Text = "Tipo";
        this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTelefone
        // 
        this.lblTelefone.BackColor = System.Drawing.Color.DimGray;
        this.lblTelefone.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblTelefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblTelefone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblTelefone.Location = new System.Drawing.Point(46, 215);
        this.lblTelefone.Name = "lblTelefone";
        this.lblTelefone.Size = new System.Drawing.Size(86, 30);
        this.lblTelefone.TabIndex = 45;
        this.lblTelefone.Text = "Telefone";
        this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblEmail
        // 
        this.lblEmail.BackColor = System.Drawing.Color.DimGray;
        this.lblEmail.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblEmail.Location = new System.Drawing.Point(46, 180);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(58, 30);
        this.lblEmail.TabIndex = 44;
        this.lblEmail.Text = "Email";
        this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
        this.lblNome.Size = new System.Drawing.Size(71, 30);
        this.lblNome.TabIndex = 43;
        this.lblNome.Text = "Nome";
        this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtNumero
        // 
        this.txtNumero.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNumero.Location = new System.Drawing.Point(132, 285);
        this.txtNumero.Name = "txtNumero";
        this.txtNumero.Size = new System.Drawing.Size(76, 30);
        this.txtNumero.TabIndex = 42;
        // 
        // dateDataInicial
        // 
        this.dateDataInicial.CustomFormat = "";
        this.dateDataInicial.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataInicial.Location = new System.Drawing.Point(238, 495);
        this.dateDataInicial.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataInicial.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataInicial.Name = "dateDataInicial";
        this.dateDataInicial.Size = new System.Drawing.Size(113, 30);
        this.dateDataInicial.TabIndex = 39;
        this.dateDataInicial.Value = new System.DateTime(2002, 10, 13, 0, 0, 0, 0);
        this.dateDataInicial.Leave += new System.EventHandler(this.dateDataInicial_ValueChanged);
        // 
        // txtLogradouro
        // 
        this.txtLogradouro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtLogradouro.Location = new System.Drawing.Point(170, 250);
        this.txtLogradouro.Name = "txtLogradouro";
        this.txtLogradouro.Size = new System.Drawing.Size(296, 30);
        this.txtLogradouro.TabIndex = 38;
        // 
        // txtEmail
        // 
        this.txtEmail.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtEmail.Location = new System.Drawing.Point(110, 180);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(356, 30);
        this.txtEmail.TabIndex = 36;
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
        this.btnCancelar.TabIndex = 41;
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
        this.btnSalvar.Location = new System.Drawing.Point(46, 602);
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.Size = new System.Drawing.Size(148, 52);
        this.btnSalvar.TabIndex = 40;
        this.btnSalvar.Text = "Salvar";
        this.btnSalvar.UseVisualStyleBackColor = false;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        // 
        // txtTelefone
        // 
        this.txtTelefone.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtTelefone.Location = new System.Drawing.Point(138, 215);
        this.txtTelefone.Name = "txtTelefone";
        this.txtTelefone.Size = new System.Drawing.Size(148, 30);
        this.txtTelefone.TabIndex = 37;
        // 
        // txtComplemento
        // 
        this.txtComplemento.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtComplemento.Location = new System.Drawing.Point(186, 320);
        this.txtComplemento.Name = "txtComplemento";
        this.txtComplemento.Size = new System.Drawing.Size(185, 30);
        this.txtComplemento.TabIndex = 35;
        // 
        // txtNome
        // 
        this.txtNome.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNome.Location = new System.Drawing.Point(122, 75);
        this.txtNome.Name = "txtNome";
        this.txtNome.Size = new System.Drawing.Size(344, 30);
        this.txtNome.TabIndex = 34;
        // 
        // lblCadastroCliente
        // 
        this.lblCadastroCliente.BackColor = System.Drawing.Color.DimGray;
        this.lblCadastroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCadastroCliente.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblCadastroCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCadastroCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblCadastroCliente.Location = new System.Drawing.Point(45, 25);
        this.lblCadastroCliente.Name = "lblCadastroCliente";
        this.lblCadastroCliente.Size = new System.Drawing.Size(219, 40);
        this.lblCadastroCliente.TabIndex = 62;
        this.lblCadastroCliente.Text = "Cadastrar Cliente";
        this.lblCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtCep
        // 
        this.txtCep.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtCep.Location = new System.Drawing.Point(100, 460);
        this.txtCep.Name = "txtCep";
        this.txtCep.Size = new System.Drawing.Size(113, 30);
        this.txtCep.TabIndex = 63;
        // 
        // CadastroClienteForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 681);
        this.Controls.Add(this.txtCep);
        this.Controls.Add(this.lblCadastroCliente);
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
        this.Name = "CadastroClienteForm";
        this.ShowIcon = false;
        this.Text = "Cadastrar Cliente";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.CadastroClienteFisicoForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblCadastroCliente;

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
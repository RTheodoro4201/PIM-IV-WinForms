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
        this.lblEndereco = new System.Windows.Forms.Label();
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
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.txtNome = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // lblEndereco
        // 
        this.lblEndereco.BackColor = System.Drawing.Color.GhostWhite;
        this.lblEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblEndereco.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblEndereco.Location = new System.Drawing.Point(96, 237);
        this.lblEndereco.Name = "lblEndereco";
        this.lblEndereco.Size = new System.Drawing.Size(667, 27);
        this.lblEndereco.TabIndex = 66;
        this.lblEndereco.Text = "Endereço";
        this.lblEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtCep
        // 
        this.txtCep.Culture = new System.Globalization.CultureInfo("");
        this.txtCep.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtCep.Location = new System.Drawing.Point(639, 344);
        this.txtCep.Mask = "99999-999";
        this.txtCep.Name = "txtCep";
        this.txtCep.Size = new System.Drawing.Size(124, 27);
        this.txtCep.TabIndex = 52;
        // 
        // txtDocumento
        // 
        this.txtDocumento.Culture = new System.Globalization.CultureInfo("");
        this.txtDocumento.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtDocumento.Location = new System.Drawing.Point(638, 162);
        this.txtDocumento.Mask = "999.999.999-99";
        this.txtDocumento.Name = "txtDocumento";
        this.txtDocumento.Size = new System.Drawing.Size(124, 27);
        this.txtDocumento.TabIndex = 45;
        // 
        // lblDocumento
        // 
        this.lblDocumento.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDocumento.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDocumento.Location = new System.Drawing.Point(492, 162);
        this.lblDocumento.Name = "lblDocumento";
        this.lblDocumento.Size = new System.Drawing.Size(140, 27);
        this.lblDocumento.TabIndex = 65;
        this.lblDocumento.Text = "Documento";
        this.lblDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtTelefone
        // 
        this.txtTelefone.Culture = new System.Globalization.CultureInfo("");
        this.txtTelefone.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtTelefone.Location = new System.Drawing.Point(218, 162);
        this.txtTelefone.Mask = "(99) 99999-9999";
        this.txtTelefone.Name = "txtTelefone";
        this.txtTelefone.Size = new System.Drawing.Size(131, 27);
        this.txtTelefone.TabIndex = 44;
        // 
        // lblTipo
        // 
        this.lblTipo.BackColor = System.Drawing.Color.GhostWhite;
        this.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTipo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblTipo.Location = new System.Drawing.Point(492, 127);
        this.lblTipo.Name = "lblTipo";
        this.lblTipo.Size = new System.Drawing.Size(140, 27);
        this.lblTipo.TabIndex = 64;
        this.lblTipo.Text = "Tipo";
        this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblDataInicial
        // 
        this.lblDataInicial.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataInicial.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblDataInicial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblDataInicial.Location = new System.Drawing.Point(95, 197);
        this.lblDataInicial.Name = "lblDataInicial";
        this.lblDataInicial.Size = new System.Drawing.Size(118, 30);
        this.lblDataInicial.TabIndex = 42;
        this.lblDataInicial.Text = "Data Inicial";
        this.lblDataInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // cbUf
        // 
        this.cbUf.Font = new System.Drawing.Font("Tahoma", 12F);
        this.cbUf.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "SC", "SP", "SE", "TO" });
        this.cbUf.Location = new System.Drawing.Point(639, 309);
        this.cbUf.Name = "cbUf";
        this.cbUf.Size = new System.Drawing.Size(124, 27);
        this.cbUf.TabIndex = 49;
        // 
        // lblUf
        // 
        this.lblUf.BackColor = System.Drawing.Color.GhostWhite;
        this.lblUf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblUf.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblUf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblUf.Location = new System.Drawing.Point(493, 309);
        this.lblUf.Name = "lblUf";
        this.lblUf.Size = new System.Drawing.Size(140, 27);
        this.lblUf.TabIndex = 63;
        this.lblUf.Text = "UF";
        this.lblUf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCidade
        // 
        this.lblCidade.BackColor = System.Drawing.Color.GhostWhite;
        this.lblCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCidade.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblCidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblCidade.Location = new System.Drawing.Point(95, 376);
        this.lblCidade.Name = "lblCidade";
        this.lblCidade.Size = new System.Drawing.Size(116, 27);
        this.lblCidade.TabIndex = 62;
        this.lblCidade.Text = "Cidade";
        this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCep
        // 
        this.lblCep.BackColor = System.Drawing.Color.GhostWhite;
        this.lblCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCep.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblCep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblCep.Location = new System.Drawing.Point(493, 344);
        this.lblCep.Name = "lblCep";
        this.lblCep.Size = new System.Drawing.Size(140, 27);
        this.lblCep.TabIndex = 61;
        this.lblCep.Text = "CEP";
        this.lblCep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtNumero
        // 
        this.txtNumero.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtNumero.Location = new System.Drawing.Point(639, 274);
        this.txtNumero.Name = "txtNumero";
        this.txtNumero.Size = new System.Drawing.Size(124, 27);
        this.txtNumero.TabIndex = 47;
        // 
        // txtCidade
        // 
        this.txtCidade.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtCidade.Location = new System.Drawing.Point(220, 376);
        this.txtCidade.Name = "txtCidade";
        this.txtCidade.Size = new System.Drawing.Size(225, 27);
        this.txtCidade.TabIndex = 51;
        // 
        // txtBairro
        // 
        this.txtBairro.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtBairro.Location = new System.Drawing.Point(220, 341);
        this.txtBairro.Name = "txtBairro";
        this.txtBairro.Size = new System.Drawing.Size(225, 27);
        this.txtBairro.TabIndex = 53;
        // 
        // lblComplemento
        // 
        this.lblComplemento.BackColor = System.Drawing.Color.GhostWhite;
        this.lblComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblComplemento.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblComplemento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblComplemento.Location = new System.Drawing.Point(97, 306);
        this.lblComplemento.Name = "lblComplemento";
        this.lblComplemento.Size = new System.Drawing.Size(116, 27);
        this.lblComplemento.TabIndex = 60;
        this.lblComplemento.Text = "Complemento";
        this.lblComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblLogradouro
        // 
        this.lblLogradouro.BackColor = System.Drawing.Color.GhostWhite;
        this.lblLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblLogradouro.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblLogradouro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblLogradouro.Location = new System.Drawing.Point(97, 271);
        this.lblLogradouro.Name = "lblLogradouro";
        this.lblLogradouro.Size = new System.Drawing.Size(116, 27);
        this.lblLogradouro.TabIndex = 59;
        this.lblLogradouro.Text = "Logradouro";
        this.lblLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblNum
        // 
        this.lblNum.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNum.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNum.Location = new System.Drawing.Point(493, 271);
        this.lblNum.Name = "lblNum";
        this.lblNum.Size = new System.Drawing.Size(140, 27);
        this.lblNum.TabIndex = 58;
        this.lblNum.Text = "Número";
        this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblBairro
        // 
        this.lblBairro.BackColor = System.Drawing.Color.GhostWhite;
        this.lblBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblBairro.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblBairro.Location = new System.Drawing.Point(97, 341);
        this.lblBairro.Name = "lblBairro";
        this.lblBairro.Size = new System.Drawing.Size(116, 27);
        this.lblBairro.TabIndex = 57;
        this.lblBairro.Text = "Bairro";
        this.lblBairro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblTelefone
        // 
        this.lblTelefone.BackColor = System.Drawing.Color.GhostWhite;
        this.lblTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTelefone.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblTelefone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblTelefone.Location = new System.Drawing.Point(97, 162);
        this.lblTelefone.Name = "lblTelefone";
        this.lblTelefone.Size = new System.Drawing.Size(116, 27);
        this.lblTelefone.TabIndex = 55;
        this.lblTelefone.Text = "Telefone";
        this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblEmail
        // 
        this.lblEmail.BackColor = System.Drawing.Color.GhostWhite;
        this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblEmail.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblEmail.Location = new System.Drawing.Point(96, 127);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(116, 27);
        this.lblEmail.TabIndex = 54;
        this.lblEmail.Text = "Email";
        this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblNome
        // 
        this.lblNome.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNome.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblNome.Location = new System.Drawing.Point(96, 92);
        this.lblNome.Name = "lblNome";
        this.lblNome.Size = new System.Drawing.Size(116, 27);
        this.lblNome.TabIndex = 50;
        this.lblNome.Text = "Nome";
        this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dateDataInicial
        // 
        this.dateDataInicial.Font = new System.Drawing.Font("Tahoma", 12F);
        this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataInicial.Location = new System.Drawing.Point(217, 197);
        this.dateDataInicial.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataInicial.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataInicial.Name = "dateDataInicial";
        this.dateDataInicial.Size = new System.Drawing.Size(132, 27);
        this.dateDataInicial.TabIndex = 56;
        this.dateDataInicial.Value = new System.DateTime(2006, 11, 2, 0, 0, 0, 0);
        this.dateDataInicial.ValueChanged += new System.EventHandler(this.dateDataInicial_ValueChanged);
        this.dateDataInicial.Enter += new System.EventHandler(this.dateDataInicial_ValueChanged);
        this.dateDataInicial.Leave += new System.EventHandler(this.dateDataInicial_ValueChanged);
        this.dateDataInicial.Validated += new System.EventHandler(this.dateDataInicial_ValueChanged);
        // 
        // txtLogradouro
        // 
        this.txtLogradouro.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtLogradouro.Location = new System.Drawing.Point(219, 271);
        this.txtLogradouro.Name = "txtLogradouro";
        this.txtLogradouro.Size = new System.Drawing.Size(225, 27);
        this.txtLogradouro.TabIndex = 46;
        // 
        // txtEmail
        // 
        this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtEmail.Location = new System.Drawing.Point(218, 127);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(225, 27);
        this.txtEmail.TabIndex = 43;
        // 
        // txtTipo
        // 
        this.txtTipo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtTipo.Location = new System.Drawing.Point(638, 127);
        this.txtTipo.Name = "txtTipo";
        this.txtTipo.ReadOnly = true;
        this.txtTipo.Size = new System.Drawing.Size(124, 27);
        this.txtTipo.TabIndex = 40;
        this.txtTipo.TextChanged += new System.EventHandler(this.VerificarTipoFornecedor);
        this.txtTipo.Enter += new System.EventHandler(this.VerificarTipoFornecedor);
        this.txtTipo.Leave += new System.EventHandler(this.VerificarTipoFornecedor);
        // 
        // txtComplemento
        // 
        this.txtComplemento.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtComplemento.Location = new System.Drawing.Point(220, 306);
        this.txtComplemento.Name = "txtComplemento";
        this.txtComplemento.Size = new System.Drawing.Size(225, 27);
        this.txtComplemento.TabIndex = 48;
        // 
        // btnCancelar
        // 
        this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 12F);
        this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnCancelar.Location = new System.Drawing.Point(514, 513);
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.Size = new System.Drawing.Size(148, 52);
        this.btnCancelar.TabIndex = 68;
        this.btnCancelar.Text = "Cancelar";
        this.btnCancelar.UseVisualStyleBackColor = true;
        this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        // 
        // btnSalvar
        // 
        this.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 12F);
        this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnSalvar.Location = new System.Drawing.Point(295, 513);
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.Size = new System.Drawing.Size(148, 52);
        this.btnSalvar.TabIndex = 67;
        this.btnSalvar.Text = "Salvar";
        this.btnSalvar.UseVisualStyleBackColor = true;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        // 
        // txtNome
        // 
        this.txtNome.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtNome.Location = new System.Drawing.Point(220, 92);
        this.txtNome.Name = "txtNome";
        this.txtNome.Size = new System.Drawing.Size(543, 27);
        this.txtNome.TabIndex = 69;
        // 
        // CadastroFornecedorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
        this.Controls.Add(this.txtNome);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.lblEndereco);
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

    private System.Windows.Forms.TextBox txtNome;

    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnSalvar;

    private System.Windows.Forms.Label lblEndereco;
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
    private System.Windows.Forms.Label lblComplemento;
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
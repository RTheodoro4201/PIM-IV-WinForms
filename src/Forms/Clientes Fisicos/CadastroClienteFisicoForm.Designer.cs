using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Clientes_Fisicos;

partial class CadastroClienteFisicoForm
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
        this.txtNome = new System.Windows.Forms.TextBox();
        this.txtComplemento = new System.Windows.Forms.TextBox();
        this.txtCpf = new System.Windows.Forms.TextBox();
        this.txtTelefone = new System.Windows.Forms.TextBox();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.txtRg = new System.Windows.Forms.TextBox();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.txtLogradouro = new System.Windows.Forms.TextBox();
        this.dateDataNascimento = new System.Windows.Forms.DateTimePicker();
        this.txtNumero = new System.Windows.Forms.TextBox();
        this.lblNome = new System.Windows.Forms.Label();
        this.lblTelefone = new System.Windows.Forms.Label();
        this.lblEmail = new System.Windows.Forms.Label();
        this.lblCpf = new System.Windows.Forms.Label();
        this.lblRg = new System.Windows.Forms.Label();
        this.lblComplemento = new System.Windows.Forms.Label();
        this.lblLogradouro = new System.Windows.Forms.Label();
        this.lblNum = new System.Windows.Forms.Label();
        this.lblBairro = new System.Windows.Forms.Label();
        this.txtBairro = new System.Windows.Forms.TextBox();
        this.txtCidade = new System.Windows.Forms.TextBox();
        this.txtCep = new System.Windows.Forms.TextBox();
        this.lblCep = new System.Windows.Forms.Label();
        this.lblCidade = new System.Windows.Forms.Label();
        this.lblUf = new System.Windows.Forms.Label();
        this.cbUf = new System.Windows.Forms.ComboBox();
        this.lblDataNascimento = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // txtNome
        // 
        this.txtNome.Location = new System.Drawing.Point(217, 96);
        this.txtNome.Name = "txtNome";
        this.txtNome.Size = new System.Drawing.Size(533, 20);
        this.txtNome.TabIndex = 0;
        // 
        // txtComplemento
        // 
        this.txtComplemento.Location = new System.Drawing.Point(217, 200);
        this.txtComplemento.Name = "txtComplemento";
        this.txtComplemento.Size = new System.Drawing.Size(167, 20);
        this.txtComplemento.TabIndex = 1;
        // 
        // txtCpf
        // 
        this.txtCpf.Location = new System.Drawing.Point(216, 122);
        this.txtCpf.Name = "txtCpf";
        this.txtCpf.Size = new System.Drawing.Size(167, 20);
        this.txtCpf.TabIndex = 3;
        // 
        // txtTelefone
        // 
        this.txtTelefone.Location = new System.Drawing.Point(637, 148);
        this.txtTelefone.Name = "txtTelefone";
        this.txtTelefone.Size = new System.Drawing.Size(113, 20);
        this.txtTelefone.TabIndex = 5;
        // 
        // btnSalvar
        // 
        this.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnSalvar.Location = new System.Drawing.Point(270, 396);
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.Size = new System.Drawing.Size(113, 35);
        this.btnSalvar.TabIndex = 8;
        this.btnSalvar.Text = "Salvar";
        this.btnSalvar.UseVisualStyleBackColor = true;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        // 
        // btnCancelar
        // 
        this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnCancelar.Location = new System.Drawing.Point(518, 396);
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.Size = new System.Drawing.Size(113, 35);
        this.btnCancelar.TabIndex = 9;
        this.btnCancelar.Text = "Cancelar";
        this.btnCancelar.UseVisualStyleBackColor = true;
        this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        // 
        // txtRg
        // 
        this.txtRg.Location = new System.Drawing.Point(637, 122);
        this.txtRg.Name = "txtRg";
        this.txtRg.Size = new System.Drawing.Size(113, 20);
        this.txtRg.TabIndex = 2;
        // 
        // txtEmail
        // 
        this.txtEmail.Location = new System.Drawing.Point(217, 148);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(167, 20);
        this.txtEmail.TabIndex = 4;
        // 
        // txtLogradouro
        // 
        this.txtLogradouro.Location = new System.Drawing.Point(217, 174);
        this.txtLogradouro.Name = "txtLogradouro";
        this.txtLogradouro.Size = new System.Drawing.Size(167, 20);
        this.txtLogradouro.TabIndex = 6;
        // 
        // dateDataNascimento
        // 
        this.dateDataNascimento.CustomFormat = "";
        this.dateDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataNascimento.Location = new System.Drawing.Point(637, 252);
        this.dateDataNascimento.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataNascimento.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataNascimento.Name = "dateDataNascimento";
        this.dateDataNascimento.Size = new System.Drawing.Size(113, 20);
        this.dateDataNascimento.TabIndex = 7;
        this.dateDataNascimento.Value = new System.DateTime(2002, 10, 13, 0, 0, 0, 0);
        this.dateDataNascimento.ValueChanged += new System.EventHandler(this.dateDataNascimento_ValueChanged);
        // 
        // txtNumero
        // 
        this.txtNumero.Location = new System.Drawing.Point(637, 174);
        this.txtNumero.Name = "txtNumero";
        this.txtNumero.Size = new System.Drawing.Size(113, 20);
        this.txtNumero.TabIndex = 10;
        // 
        // lblNome
        // 
        this.lblNome.Location = new System.Drawing.Point(95, 100);
        this.lblNome.Name = "lblNome";
        this.lblNome.Size = new System.Drawing.Size(116, 20);
        this.lblNome.TabIndex = 11;
        this.lblNome.Text = "Nome";
        // 
        // lblTelefone
        // 
        this.lblTelefone.Location = new System.Drawing.Point(508, 147);
        this.lblTelefone.Name = "lblTelefone";
        this.lblTelefone.Size = new System.Drawing.Size(123, 20);
        this.lblTelefone.TabIndex = 14;
        this.lblTelefone.Text = "Telefone";
        // 
        // lblEmail
        // 
        this.lblEmail.Location = new System.Drawing.Point(95, 151);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(116, 20);
        this.lblEmail.TabIndex = 13;
        this.lblEmail.Text = "Email";
        // 
        // lblCpf
        // 
        this.lblCpf.Location = new System.Drawing.Point(95, 125);
        this.lblCpf.Name = "lblCpf";
        this.lblCpf.Size = new System.Drawing.Size(115, 20);
        this.lblCpf.TabIndex = 16;
        this.lblCpf.Text = "CPF";
        // 
        // lblRg
        // 
        this.lblRg.Location = new System.Drawing.Point(508, 124);
        this.lblRg.Name = "lblRg";
        this.lblRg.Size = new System.Drawing.Size(123, 20);
        this.lblRg.TabIndex = 15;
        this.lblRg.Text = "RG";
        // 
        // lblComplemento
        // 
        this.lblComplemento.Location = new System.Drawing.Point(95, 203);
        this.lblComplemento.Name = "lblComplemento";
        this.lblComplemento.Size = new System.Drawing.Size(116, 20);
        this.lblComplemento.TabIndex = 20;
        this.lblComplemento.Text = "Complemento";
        // 
        // lblLogradouro
        // 
        this.lblLogradouro.Location = new System.Drawing.Point(95, 177);
        this.lblLogradouro.Name = "lblLogradouro";
        this.lblLogradouro.Size = new System.Drawing.Size(116, 20);
        this.lblLogradouro.TabIndex = 19;
        this.lblLogradouro.Text = "Logradouro";
        // 
        // lblNum
        // 
        this.lblNum.Location = new System.Drawing.Point(508, 176);
        this.lblNum.Name = "lblNum";
        this.lblNum.Size = new System.Drawing.Size(123, 20);
        this.lblNum.TabIndex = 18;
        this.lblNum.Text = "Nº";
        // 
        // lblBairro
        // 
        this.lblBairro.Location = new System.Drawing.Point(508, 205);
        this.lblBairro.Name = "lblBairro";
        this.lblBairro.Size = new System.Drawing.Size(123, 20);
        this.lblBairro.TabIndex = 17;
        this.lblBairro.Text = "Bairro";
        // 
        // txtBairro
        // 
        this.txtBairro.Location = new System.Drawing.Point(637, 200);
        this.txtBairro.Name = "txtBairro";
        this.txtBairro.Size = new System.Drawing.Size(113, 20);
        this.txtBairro.TabIndex = 22;
        // 
        // txtCidade
        // 
        this.txtCidade.Location = new System.Drawing.Point(217, 226);
        this.txtCidade.Name = "txtCidade";
        this.txtCidade.Size = new System.Drawing.Size(167, 20);
        this.txtCidade.TabIndex = 23;
        // 
        // txtCep
        // 
        this.txtCep.Location = new System.Drawing.Point(217, 252);
        this.txtCep.Name = "txtCep";
        this.txtCep.Size = new System.Drawing.Size(167, 20);
        this.txtCep.TabIndex = 24;
        // 
        // lblCep
        // 
        this.lblCep.Location = new System.Drawing.Point(95, 252);
        this.lblCep.Name = "lblCep";
        this.lblCep.Size = new System.Drawing.Size(116, 20);
        this.lblCep.TabIndex = 25;
        this.lblCep.Text = "CEP";
        // 
        // lblCidade
        // 
        this.lblCidade.Location = new System.Drawing.Point(95, 226);
        this.lblCidade.Name = "lblCidade";
        this.lblCidade.Size = new System.Drawing.Size(116, 20);
        this.lblCidade.TabIndex = 26;
        this.lblCidade.Text = "Cidade";
        // 
        // lblUf
        // 
        this.lblUf.Location = new System.Drawing.Point(508, 228);
        this.lblUf.Name = "lblUf";
        this.lblUf.Size = new System.Drawing.Size(123, 20);
        this.lblUf.TabIndex = 27;
        this.lblUf.Text = "UF";
        // 
        // cbUf
        // 
        this.cbUf.FormattingEnabled = true;
        this.cbUf.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "SC", "SP", "SE", "TO" });
        this.cbUf.Location = new System.Drawing.Point(637, 226);
        this.cbUf.Name = "cbUf";
        this.cbUf.Size = new System.Drawing.Size(113, 21);
        this.cbUf.TabIndex = 28;
        // 
        // lblDataNascimento
        // 
        this.lblDataNascimento.Location = new System.Drawing.Point(508, 252);
        this.lblDataNascimento.Name = "lblDataNascimento";
        this.lblDataNascimento.Size = new System.Drawing.Size(123, 20);
        this.lblDataNascimento.TabIndex = 29;
        this.lblDataNascimento.Text = "Data de Nascimento";
        // 
        // CadastroClienteFisicoForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 681);
        this.Controls.Add(this.lblDataNascimento);
        this.Controls.Add(this.cbUf);
        this.Controls.Add(this.lblUf);
        this.Controls.Add(this.lblCidade);
        this.Controls.Add(this.lblCep);
        this.Controls.Add(this.txtCep);
        this.Controls.Add(this.txtCidade);
        this.Controls.Add(this.txtBairro);
        this.Controls.Add(this.lblComplemento);
        this.Controls.Add(this.lblLogradouro);
        this.Controls.Add(this.lblNum);
        this.Controls.Add(this.lblBairro);
        this.Controls.Add(this.lblCpf);
        this.Controls.Add(this.lblRg);
        this.Controls.Add(this.lblTelefone);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.lblNome);
        this.Controls.Add(this.txtNumero);
        this.Controls.Add(this.dateDataNascimento);
        this.Controls.Add(this.txtLogradouro);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.txtRg);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.txtTelefone);
        this.Controls.Add(this.txtCpf);
        this.Controls.Add(this.txtComplemento);
        this.Controls.Add(this.txtNome);
        this.MaximizeBox = false;
        this.Name = "CadastroClienteFisicoForm";
        this.ShowIcon = false;
        this.Text = "Cadastrar Cliente Físico";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.CadastroClienteFisicoForm_Load);
        this.ResizeBegin += new System.EventHandler(this.CadastroClienteFisicoForm_Load);
        this.ResizeEnd += new System.EventHandler(this.CadastroClienteFisicoForm_Load);
        this.Resize += new System.EventHandler(this.CadastroClienteFisicoForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblCep;

    private System.Windows.Forms.ComboBox cbUf;

    private System.Windows.Forms.TextBox txtCep;
    private System.Windows.Forms.Label lblDataNascimento;
    private System.Windows.Forms.Label lblCidade;
    private System.Windows.Forms.Label lblUf;

    private System.Windows.Forms.TextBox txtBairro;
    private System.Windows.Forms.TextBox txtCidade;

    private System.Windows.Forms.Label lblTelefone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblCpf;
    private System.Windows.Forms.Label lblRg;
    private System.Windows.Forms.Label lblComplemento;
    private System.Windows.Forms.Label lblLogradouro;
    private System.Windows.Forms.Label lblNum;
    private System.Windows.Forms.Label lblBairro;

    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.Label lblNome;

    private System.Windows.Forms.DateTimePicker dateDataNascimento;

    private System.Windows.Forms.TextBox txtLogradouro;

    private System.Windows.Forms.TextBox txtRg;

    private System.Windows.Forms.TextBox txtEmail;

    private System.Windows.Forms.Button btnCancelar;

    private System.Windows.Forms.Button btnSalvar;

    private System.Windows.Forms.TextBox txtTelefone;

    private System.Windows.Forms.TextBox txtComplemento;
    private System.Windows.Forms.TextBox txtCpf;

    private System.Windows.Forms.TextBox txtNome;

    #endregion
}
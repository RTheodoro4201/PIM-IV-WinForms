using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Funcionarios;

partial class AlteraFuncionarioForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlteraFuncionarioForm));
        this.txtNome = new System.Windows.Forms.TextBox();
        this.txtComplemento = new System.Windows.Forms.TextBox();
        this.txtCpf = new System.Windows.Forms.TextBox();
        this.txtTelefone = new System.Windows.Forms.TextBox();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.txtRg = new System.Windows.Forms.TextBox();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.txtLogradouro = new System.Windows.Forms.TextBox();
        this.dateDataAdmissao = new System.Windows.Forms.DateTimePicker();
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
        this.lblDataAdmissao = new System.Windows.Forms.Label();
        this.lblIdFuncionario = new System.Windows.Forms.Label();
        this.txtIdFuncionario = new System.Windows.Forms.TextBox();
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
        // txtCpf
        // 
        resources.ApplyResources(this.txtCpf, "txtCpf");
        this.txtCpf.Name = "txtCpf";
        // 
        // txtTelefone
        // 
        resources.ApplyResources(this.txtTelefone, "txtTelefone");
        this.txtTelefone.Name = "txtTelefone";
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
        // txtRg
        // 
        resources.ApplyResources(this.txtRg, "txtRg");
        this.txtRg.Name = "txtRg";
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
        // dateDataAdmissao
        //
        this.dateDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        resources.ApplyResources(this.dateDataAdmissao, "dateDataAdmissao");
        this.dateDataAdmissao.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataAdmissao.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataAdmissao.Name = "dateDataAdmissao";
        this.dateDataAdmissao.Value = new System.DateTime(2002, 10, 13, 0, 0, 0, 0);
        this.dateDataAdmissao.ValueChanged += new System.EventHandler(this.dateDataNascimento_ValueChanged);
        //
        // txtNumero
        //
        resources.ApplyResources(this.txtNumero, "txtNumero");
        this.txtNumero.Name = "txtNumero";
        //
        // lblNome
        //
        resources.ApplyResources(this.lblNome, "lblNome");
        this.lblNome.Name = "lblNome";
        //
        // lblTelefone
        //
        resources.ApplyResources(this.lblTelefone, "lblTelefone");
        this.lblTelefone.Name = "lblTelefone";
        //
        // lblEmail
        //
        resources.ApplyResources(this.lblEmail, "lblEmail");
        this.lblEmail.Name = "lblEmail";
        //
        // lblCpf
        //
        resources.ApplyResources(this.lblCpf, "lblCpf");
        this.lblCpf.Name = "lblCpf";
        //
        // lblRg
        //
        resources.ApplyResources(this.lblRg, "lblRg");
        this.lblRg.Name = "lblRg";
        //
        // lblComplemento
        //
        resources.ApplyResources(this.lblComplemento, "lblComplemento");
        this.lblComplemento.Name = "lblComplemento";
        //
        // lblLogradouro
        //
        resources.ApplyResources(this.lblLogradouro, "lblLogradouro");
        this.lblLogradouro.Name = "lblLogradouro";
        //
        // lblNum
        //
        resources.ApplyResources(this.lblNum, "lblNum");
        this.lblNum.Name = "lblNum";
        //
        // lblBairro
        //
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
        // txtCep
        //
        resources.ApplyResources(this.txtCep, "txtCep");
        this.txtCep.Name = "txtCep";
        //
        // lblCep
        //
        resources.ApplyResources(this.lblCep, "lblCep");
        this.lblCep.Name = "lblCep";
        //
        // lblCidade
        //
        resources.ApplyResources(this.lblCidade, "lblCidade");
        this.lblCidade.Name = "lblCidade";
        //
        // lblUf
        //
        resources.ApplyResources(this.lblUf, "lblUf");
        this.lblUf.Name = "lblUf";
        //
        // cbUf
        //
        this.cbUf.FormattingEnabled = true;
        this.cbUf.Items.AddRange(new object[] { resources.GetString("cbUf.Items"), resources.GetString("cbUf.Items1"), resources.GetString("cbUf.Items2"), resources.GetString("cbUf.Items3"), resources.GetString("cbUf.Items4"), resources.GetString("cbUf.Items5"), resources.GetString("cbUf.Items6"), resources.GetString("cbUf.Items7"), resources.GetString("cbUf.Items8"), resources.GetString("cbUf.Items9"), resources.GetString("cbUf.Items10"), resources.GetString("cbUf.Items11"), resources.GetString("cbUf.Items12"), resources.GetString("cbUf.Items13"), resources.GetString("cbUf.Items14"), resources.GetString("cbUf.Items15"), resources.GetString("cbUf.Items16"), resources.GetString("cbUf.Items17"), resources.GetString("cbUf.Items18"), resources.GetString("cbUf.Items19"), resources.GetString("cbUf.Items20"), resources.GetString("cbUf.Items21"), resources.GetString("cbUf.Items22"), resources.GetString("cbUf.Items23"), resources.GetString("cbUf.Items24"), resources.GetString("cbUf.Items25") });
        resources.ApplyResources(this.cbUf, "cbUf");
        this.cbUf.Name = "cbUf";
        //
        // lblDataAdmissao
        //
        resources.ApplyResources(this.lblDataAdmissao, "lblDataAdmissao");
        this.lblDataAdmissao.Name = "lblDataAdmissao";
        //
        // lblIdFuncionario
        //
        resources.ApplyResources(this.lblIdFuncionario, "lblIdFuncionario");
        this.lblIdFuncionario.Name = "lblIdFuncionario";
        //
        // txtIdFuncionario
        //
        resources.ApplyResources(this.txtIdFuncionario, "txtIdFuncionario");
        this.txtIdFuncionario.Name = "txtIdFuncionario";
        //
        // AlteraFuncionarioForm
        //
        resources.ApplyResources(this, "$this");
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.Controls.Add(this.txtIdFuncionario);
        this.Controls.Add(this.lblIdFuncionario);
        this.Controls.Add(this.lblDataAdmissao);
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
        this.Controls.Add(this.dateDataAdmissao);
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
        this.Name = "AlteraFuncionarioForm";
        this.ShowIcon = false;
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.AlteraFuncionarioForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Move += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox txtIdFuncionario;

    private System.Windows.Forms.Label lblIdFuncionario;

    private System.Windows.Forms.Label lblCep;

    private System.Windows.Forms.ComboBox cbUf;

    private System.Windows.Forms.TextBox txtCep;
    private System.Windows.Forms.Label lblDataAdmissao;
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

    private System.Windows.Forms.DateTimePicker dateDataAdmissao;

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
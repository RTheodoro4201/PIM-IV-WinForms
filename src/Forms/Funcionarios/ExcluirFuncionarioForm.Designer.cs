using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Funcionarios;

partial class ExcluirFuncionarioForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirFuncionarioForm));
        this.txtCep = new System.Windows.Forms.MaskedTextBox();
        this.txtCpf = new System.Windows.Forms.MaskedTextBox();
        this.lblCpf = new System.Windows.Forms.Label();
        this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
        this.txtRg = new System.Windows.Forms.MaskedTextBox();
        this.lblCargo = new System.Windows.Forms.Label();
        this.txtIdFuncionario = new System.Windows.Forms.TextBox();
        this.lblIdFuncionario = new System.Windows.Forms.Label();
        this.lblDataAdmissao = new System.Windows.Forms.Label();
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
        this.lblSalario = new System.Windows.Forms.Label();
        this.lblRg = new System.Windows.Forms.Label();
        this.lblTelefone = new System.Windows.Forms.Label();
        this.lblEmail = new System.Windows.Forms.Label();
        this.lblNome = new System.Windows.Forms.Label();
        this.dateDataAdmissao = new System.Windows.Forms.DateTimePicker();
        this.txtLogradouro = new System.Windows.Forms.TextBox();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnExcluir = new System.Windows.Forms.Button();
        this.txtCargo = new System.Windows.Forms.TextBox();
        this.txtSalario = new System.Windows.Forms.TextBox();
        this.txtComplemento = new System.Windows.Forms.TextBox();
        this.txtNome = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // txtCep
        // 
        this.txtCep.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtCep, "txtCep");
        this.txtCep.Name = "txtCep";
        this.txtCep.ReadOnly = true;
        // 
        // txtCpf
        // 
        this.txtCpf.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtCpf, "txtCpf");
        this.txtCpf.Name = "txtCpf";
        this.txtCpf.ReadOnly = true;
        // 
        // lblCpf
        // 
        this.lblCpf.BackColor = System.Drawing.Color.GhostWhite;
        this.lblCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblCpf, "lblCpf");
        this.lblCpf.Name = "lblCpf";
        // 
        // txtTelefone
        // 
        this.txtTelefone.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtTelefone, "txtTelefone");
        this.txtTelefone.Name = "txtTelefone";
        this.txtTelefone.ReadOnly = true;
        // 
        // txtRg
        // 
        this.txtRg.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtRg, "txtRg");
        this.txtRg.Name = "txtRg";
        this.txtRg.ReadOnly = true;
        // 
        // lblCargo
        // 
        this.lblCargo.BackColor = System.Drawing.Color.GhostWhite;
        this.lblCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblCargo, "lblCargo");
        this.lblCargo.Name = "lblCargo";
        // 
        // txtIdFuncionario
        // 
        resources.ApplyResources(this.txtIdFuncionario, "txtIdFuncionario");
        this.txtIdFuncionario.Name = "txtIdFuncionario";
        this.txtIdFuncionario.ReadOnly = true;
        // 
        // lblIdFuncionario
        // 
        this.lblIdFuncionario.BackColor = System.Drawing.Color.GhostWhite;
        this.lblIdFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblIdFuncionario, "lblIdFuncionario");
        this.lblIdFuncionario.Name = "lblIdFuncionario";
        // 
        // lblDataAdmissao
        // 
        this.lblDataAdmissao.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataAdmissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblDataAdmissao, "lblDataAdmissao");
        this.lblDataAdmissao.Name = "lblDataAdmissao";
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
        // lblSalario
        // 
        this.lblSalario.BackColor = System.Drawing.Color.GhostWhite;
        this.lblSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblSalario, "lblSalario");
        this.lblSalario.Name = "lblSalario";
        // 
        // lblRg
        // 
        this.lblRg.BackColor = System.Drawing.Color.GhostWhite;
        this.lblRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblRg, "lblRg");
        this.lblRg.Name = "lblRg";
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
        // dateDataAdmissao
        // 
        resources.ApplyResources(this.dateDataAdmissao, "dateDataAdmissao");
        this.dateDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataAdmissao.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataAdmissao.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataAdmissao.Name = "dateDataAdmissao";
        this.dateDataAdmissao.Value = new System.DateTime(2024, 11, 2, 0, 0, 0, 0);
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
        // btnCancelar
        // 
        this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        resources.ApplyResources(this.btnCancelar, "btnCancelar");
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.UseVisualStyleBackColor = true;
        this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        // 
        // btnExcluir
        // 
        this.btnExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        resources.ApplyResources(this.btnExcluir, "btnExcluir");
        this.btnExcluir.Name = "btnExcluir";
        this.btnExcluir.UseVisualStyleBackColor = true;
        this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
        // 
        // txtCargo
        // 
        resources.ApplyResources(this.txtCargo, "txtCargo");
        this.txtCargo.Name = "txtCargo";
        this.txtCargo.ReadOnly = true;
        // 
        // txtSalario
        // 
        resources.ApplyResources(this.txtSalario, "txtSalario");
        this.txtSalario.Name = "txtSalario";
        this.txtSalario.ReadOnly = true;
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
        // ExcluirFuncionarioForm
        // 
        resources.ApplyResources(this, "$this");
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.Controls.Add(this.txtCep);
        this.Controls.Add(this.txtCpf);
        this.Controls.Add(this.lblCpf);
        this.Controls.Add(this.txtTelefone);
        this.Controls.Add(this.txtRg);
        this.Controls.Add(this.lblCargo);
        this.Controls.Add(this.txtIdFuncionario);
        this.Controls.Add(this.lblIdFuncionario);
        this.Controls.Add(this.lblDataAdmissao);
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
        this.Controls.Add(this.lblSalario);
        this.Controls.Add(this.lblRg);
        this.Controls.Add(this.lblTelefone);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.lblNome);
        this.Controls.Add(this.dateDataAdmissao);
        this.Controls.Add(this.txtLogradouro);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnExcluir);
        this.Controls.Add(this.txtCargo);
        this.Controls.Add(this.txtSalario);
        this.Controls.Add(this.txtComplemento);
        this.Controls.Add(this.txtNome);
        this.MaximizeBox = false;
        this.Name = "ExcluirFuncionarioForm";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.Load += new System.EventHandler(this.ExcluirFuncionarioForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.LocationChanged += new System.EventHandler(this.ResizeForm);
        this.SizeChanged += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.MaskedTextBox txtCep;
    private System.Windows.Forms.MaskedTextBox txtCpf;
    private System.Windows.Forms.Label lblCpf;
    private System.Windows.Forms.MaskedTextBox txtTelefone;
    private System.Windows.Forms.MaskedTextBox txtRg;
    private System.Windows.Forms.Label lblCargo;
    private System.Windows.Forms.TextBox txtIdFuncionario;
    private System.Windows.Forms.Label lblIdFuncionario;
    private System.Windows.Forms.Label lblDataAdmissao;
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
    private System.Windows.Forms.Label lblSalario;
    private System.Windows.Forms.Label lblRg;
    private System.Windows.Forms.Label lblTelefone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.DateTimePicker dateDataAdmissao;
    private System.Windows.Forms.TextBox txtLogradouro;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnExcluir;
    private System.Windows.Forms.TextBox txtCargo;
    private System.Windows.Forms.TextBox txtSalario;
    private System.Windows.Forms.TextBox txtComplemento;
    private System.Windows.Forms.TextBox txtNome;

    #endregion
}
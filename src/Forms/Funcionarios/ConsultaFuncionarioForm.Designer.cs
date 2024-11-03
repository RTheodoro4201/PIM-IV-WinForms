using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Funcionarios;

partial class ConsultaFuncionarioForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFuncionarioForm));
        this.txtNome = new System.Windows.Forms.TextBox();
        this.txtComplemento = new System.Windows.Forms.TextBox();
        this.txtSalario = new System.Windows.Forms.TextBox();
        this.txtCargo = new System.Windows.Forms.TextBox();
        this.btnFechar = new System.Windows.Forms.Button();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.txtLogradouro = new System.Windows.Forms.TextBox();
        this.dateDataAdmissao = new System.Windows.Forms.DateTimePicker();
        this.lblNome = new System.Windows.Forms.Label();
        this.lblEmail = new System.Windows.Forms.Label();
        this.lblTelefone = new System.Windows.Forms.Label();
        this.lblRg = new System.Windows.Forms.Label();
        this.lblSalario = new System.Windows.Forms.Label();
        this.lblBairro = new System.Windows.Forms.Label();
        this.lblNum = new System.Windows.Forms.Label();
        this.lblLogradouro = new System.Windows.Forms.Label();
        this.lblComplemento = new System.Windows.Forms.Label();
        this.txtBairro = new System.Windows.Forms.TextBox();
        this.txtCidade = new System.Windows.Forms.TextBox();
        this.txtNumero = new System.Windows.Forms.TextBox();
        this.lblCep = new System.Windows.Forms.Label();
        this.lblCidade = new System.Windows.Forms.Label();
        this.lblUf = new System.Windows.Forms.Label();
        this.cbUf = new System.Windows.Forms.ComboBox();
        this.lblDataAdmissao = new System.Windows.Forms.Label();
        this.lblIdFuncionario = new System.Windows.Forms.Label();
        this.txtIdFuncionario = new System.Windows.Forms.TextBox();
        this.lblCargo = new System.Windows.Forms.Label();
        this.txtRg = new System.Windows.Forms.MaskedTextBox();
        this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
        this.lblCpf = new System.Windows.Forms.Label();
        this.txtCpf = new System.Windows.Forms.MaskedTextBox();
        this.txtCep = new System.Windows.Forms.MaskedTextBox();
        this.SuspendLayout();
        // 
        // txtNome
        // 
        resources.ApplyResources(this.txtNome, "txtNome");
        this.txtNome.Name = "txtNome";
        this.txtNome.ReadOnly = true;
        // 
        // txtComplemento
        // 
        resources.ApplyResources(this.txtComplemento, "txtComplemento");
        this.txtComplemento.Name = "txtComplemento";
        this.txtComplemento.ReadOnly = true;
        // 
        // txtSalario
        // 
        resources.ApplyResources(this.txtSalario, "txtSalario");
        this.txtSalario.Name = "txtSalario";
        this.txtSalario.ReadOnly = true;
        // 
        // txtCargo
        // 
        resources.ApplyResources(this.txtCargo, "txtCargo");
        this.txtCargo.Name = "txtCargo";
        this.txtCargo.ReadOnly = true;
        // 
        // btnFechar
        // 
        this.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        resources.ApplyResources(this.btnFechar, "btnFechar");
        this.btnFechar.Name = "btnFechar";
        this.btnFechar.UseVisualStyleBackColor = true;
        this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
        // 
        // txtEmail
        // 
        resources.ApplyResources(this.txtEmail, "txtEmail");
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.ReadOnly = true;
        // 
        // txtLogradouro
        // 
        resources.ApplyResources(this.txtLogradouro, "txtLogradouro");
        this.txtLogradouro.Name = "txtLogradouro";
        this.txtLogradouro.ReadOnly = true;
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
        // lblNome
        // 
        this.lblNome.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblNome, "lblNome");
        this.lblNome.Name = "lblNome";
        // 
        // lblEmail
        // 
        this.lblEmail.BackColor = System.Drawing.Color.GhostWhite;
        this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblEmail, "lblEmail");
        this.lblEmail.Name = "lblEmail";
        // 
        // lblTelefone
        // 
        this.lblTelefone.BackColor = System.Drawing.Color.GhostWhite;
        this.lblTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblTelefone, "lblTelefone");
        this.lblTelefone.Name = "lblTelefone";
        // 
        // lblRg
        // 
        this.lblRg.BackColor = System.Drawing.Color.GhostWhite;
        this.lblRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblRg, "lblRg");
        this.lblRg.Name = "lblRg";
        // 
        // lblSalario
        // 
        this.lblSalario.BackColor = System.Drawing.Color.GhostWhite;
        this.lblSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblSalario, "lblSalario");
        this.lblSalario.Name = "lblSalario";
        // 
        // lblBairro
        // 
        this.lblBairro.BackColor = System.Drawing.Color.GhostWhite;
        this.lblBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblBairro, "lblBairro");
        this.lblBairro.Name = "lblBairro";
        // 
        // lblNum
        // 
        this.lblNum.BackColor = System.Drawing.Color.GhostWhite;
        this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblNum, "lblNum");
        this.lblNum.Name = "lblNum";
        // 
        // lblLogradouro
        // 
        this.lblLogradouro.BackColor = System.Drawing.Color.GhostWhite;
        this.lblLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblLogradouro, "lblLogradouro");
        this.lblLogradouro.Name = "lblLogradouro";
        // 
        // lblComplemento
        // 
        this.lblComplemento.BackColor = System.Drawing.Color.GhostWhite;
        this.lblComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblComplemento, "lblComplemento");
        this.lblComplemento.Name = "lblComplemento";
        // 
        // txtBairro
        // 
        resources.ApplyResources(this.txtBairro, "txtBairro");
        this.txtBairro.Name = "txtBairro";
        this.txtBairro.ReadOnly = true;
        // 
        // txtCidade
        // 
        resources.ApplyResources(this.txtCidade, "txtCidade");
        this.txtCidade.Name = "txtCidade";
        this.txtCidade.ReadOnly = true;
        // 
        // txtNumero
        // 
        resources.ApplyResources(this.txtNumero, "txtNumero");
        this.txtNumero.Name = "txtNumero";
        this.txtNumero.ReadOnly = true;
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
        resources.ApplyResources(this.cbUf, "cbUf");
        this.cbUf.Items.AddRange(new object[] { resources.GetString("cbUf.Items"), resources.GetString("cbUf.Items1"), resources.GetString("cbUf.Items2"), resources.GetString("cbUf.Items3"), resources.GetString("cbUf.Items4"), resources.GetString("cbUf.Items5"), resources.GetString("cbUf.Items6"), resources.GetString("cbUf.Items7"), resources.GetString("cbUf.Items8"), resources.GetString("cbUf.Items9"), resources.GetString("cbUf.Items10"), resources.GetString("cbUf.Items11"), resources.GetString("cbUf.Items12"), resources.GetString("cbUf.Items13"), resources.GetString("cbUf.Items14"), resources.GetString("cbUf.Items15"), resources.GetString("cbUf.Items16"), resources.GetString("cbUf.Items17"), resources.GetString("cbUf.Items18"), resources.GetString("cbUf.Items19"), resources.GetString("cbUf.Items20"), resources.GetString("cbUf.Items21"), resources.GetString("cbUf.Items22"), resources.GetString("cbUf.Items23"), resources.GetString("cbUf.Items24"), resources.GetString("cbUf.Items25") });
        this.cbUf.Name = "cbUf";
        // 
        // lblDataAdmissao
        // 
        this.lblDataAdmissao.BackColor = System.Drawing.Color.GhostWhite;
        this.lblDataAdmissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblDataAdmissao, "lblDataAdmissao");
        this.lblDataAdmissao.Name = "lblDataAdmissao";
        // 
        // lblIdFuncionario
        // 
        this.lblIdFuncionario.BackColor = System.Drawing.Color.GhostWhite;
        this.lblIdFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblIdFuncionario, "lblIdFuncionario");
        this.lblIdFuncionario.Name = "lblIdFuncionario";
        // 
        // txtIdFuncionario
        // 
        resources.ApplyResources(this.txtIdFuncionario, "txtIdFuncionario");
        this.txtIdFuncionario.Name = "txtIdFuncionario";
        this.txtIdFuncionario.ReadOnly = true;
        // 
        // lblCargo
        // 
        this.lblCargo.BackColor = System.Drawing.Color.GhostWhite;
        this.lblCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblCargo, "lblCargo");
        this.lblCargo.Name = "lblCargo";
        // 
        // txtRg
        // 
        this.txtRg.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtRg, "txtRg");
        this.txtRg.Name = "txtRg";
        this.txtRg.ReadOnly = true;
        // 
        // txtTelefone
        // 
        this.txtTelefone.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtTelefone, "txtTelefone");
        this.txtTelefone.Name = "txtTelefone";
        this.txtTelefone.ReadOnly = true;
        // 
        // lblCpf
        // 
        this.lblCpf.BackColor = System.Drawing.Color.GhostWhite;
        this.lblCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblCpf, "lblCpf");
        this.lblCpf.Name = "lblCpf";
        // 
        // txtCpf
        // 
        this.txtCpf.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtCpf, "txtCpf");
        this.txtCpf.Name = "txtCpf";
        this.txtCpf.ReadOnly = true;
        // 
        // txtCep
        // 
        this.txtCep.Culture = new System.Globalization.CultureInfo("");
        resources.ApplyResources(this.txtCep, "txtCep");
        this.txtCep.Name = "txtCep";
        this.txtCep.ReadOnly = true;
        // 
        // ConsultaFuncionarioForm
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
        this.Controls.Add(this.btnFechar);
        this.Controls.Add(this.txtCargo);
        this.Controls.Add(this.txtSalario);
        this.Controls.Add(this.txtComplemento);
        this.Controls.Add(this.txtNome);
        this.MaximizeBox = false;
        this.Name = "ConsultaFuncionarioForm";
        this.ShowIcon = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.ConsultaFuncionarioForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Move += new System.EventHandler(this.ResizeForm);
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
    private System.Windows.Forms.Button btnFechar;
    private System.Windows.Forms.TextBox txtCargo;
    private System.Windows.Forms.TextBox txtSalario;
    private System.Windows.Forms.TextBox txtComplemento;
    private System.Windows.Forms.TextBox txtNome;

    #endregion
}
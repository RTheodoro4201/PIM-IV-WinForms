using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Funcionarios;

partial class CadastroFuncionarioForm
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
        this.btnSalvar = new System.Windows.Forms.Button();
        this.btnCancelar = new System.Windows.Forms.Button();
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
        this.lblCep = new System.Windows.Forms.Label();
        this.lblCidade = new System.Windows.Forms.Label();
        this.lblUf = new System.Windows.Forms.Label();
        this.cbUf = new System.Windows.Forms.ComboBox();
        this.lblDataAdmissao = new System.Windows.Forms.Label();
        this.lblCargo = new System.Windows.Forms.Label();
        this.txtCargo = new System.Windows.Forms.TextBox();
        this.lblSalario = new System.Windows.Forms.Label();
        this.txtRg = new System.Windows.Forms.MaskedTextBox();
        this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
        this.txtCpf = new System.Windows.Forms.MaskedTextBox();
        this.txtCep = new System.Windows.Forms.MaskedTextBox();
        this.txtSalario = new System.Windows.Forms.TextBox();
        this.lblCadastroFuncionario = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // txtNome
        // 
        this.txtNome.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNome.Location = new System.Drawing.Point(125, 75);
        this.txtNome.Name = "txtNome";
        this.txtNome.Size = new System.Drawing.Size(390, 30);
        this.txtNome.TabIndex = 0;
        // 
        // txtComplemento
        // 
        this.txtComplemento.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtComplemento.Location = new System.Drawing.Point(181, 390);
        this.txtComplemento.Name = "txtComplemento";
        this.txtComplemento.Size = new System.Drawing.Size(213, 30);
        this.txtComplemento.TabIndex = 1;
        // 
        // btnSalvar
        // 
        this.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnSalvar.BackColor = System.Drawing.Color.DimGray;
        this.btnSalvar.FlatAppearance.BorderSize = 0;
        this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnSalvar.Location = new System.Drawing.Point(45, 602);
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.Size = new System.Drawing.Size(148, 52);
        this.btnSalvar.TabIndex = 8;
        this.btnSalvar.Text = "Salvar";
        this.btnSalvar.UseVisualStyleBackColor = false;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        // 
        // btnCancelar
        // 
        this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
        this.btnCancelar.FlatAppearance.BorderSize = 0;
        this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 14F);
        this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnCancelar.Location = new System.Drawing.Point(368, 602);
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.Size = new System.Drawing.Size(148, 52);
        this.btnCancelar.TabIndex = 9;
        this.btnCancelar.Text = "Cancelar";
        this.btnCancelar.UseVisualStyleBackColor = false;
        this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        // 
        // txtEmail
        // 
        this.txtEmail.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtEmail.Location = new System.Drawing.Point(109, 215);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(225, 30);
        this.txtEmail.TabIndex = 4;
        // 
        // txtLogradouro
        // 
        this.txtLogradouro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtLogradouro.Location = new System.Drawing.Point(167, 320);
        this.txtLogradouro.Name = "txtLogradouro";
        this.txtLogradouro.Size = new System.Drawing.Size(225, 30);
        this.txtLogradouro.TabIndex = 6;
        // 
        // dateDataAdmissao
        // 
        this.dateDataAdmissao.CustomFormat = "";
        this.dateDataAdmissao.Font = new System.Drawing.Font("Tahoma", 14F);
        this.dateDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataAdmissao.Location = new System.Drawing.Point(213, 565);
        this.dateDataAdmissao.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataAdmissao.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataAdmissao.Name = "dateDataAdmissao";
        this.dateDataAdmissao.Size = new System.Drawing.Size(124, 30);
        this.dateDataAdmissao.TabIndex = 7;
        this.dateDataAdmissao.Value = new System.DateTime(2024, 11, 2, 0, 0, 0, 0);
        this.dateDataAdmissao.ValueChanged += new System.EventHandler(this.dateDataNascimento_ValueChanged);
        // 
        // txtNumero
        // 
        this.txtNumero.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtNumero.Location = new System.Drawing.Point(136, 356);
        this.txtNumero.Name = "txtNumero";
        this.txtNumero.Size = new System.Drawing.Size(124, 30);
        this.txtNumero.TabIndex = 10;
        // 
        // lblNome
        // 
        this.lblNome.BackColor = System.Drawing.Color.DimGray;
        this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNome.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
        this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNome.Location = new System.Drawing.Point(45, 75);
        this.lblNome.Name = "lblNome";
        this.lblNome.Size = new System.Drawing.Size(74, 30);
        this.lblNome.TabIndex = 11;
        this.lblNome.Text = "Nome";
        this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTelefone
        // 
        this.lblTelefone.BackColor = System.Drawing.Color.DimGray;
        this.lblTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTelefone.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblTelefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblTelefone.Location = new System.Drawing.Point(45, 250);
        this.lblTelefone.Name = "lblTelefone";
        this.lblTelefone.Size = new System.Drawing.Size(86, 30);
        this.lblTelefone.TabIndex = 14;
        this.lblTelefone.Text = "Telefone";
        this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblEmail
        // 
        this.lblEmail.BackColor = System.Drawing.Color.DimGray;
        this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblEmail.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblEmail.Location = new System.Drawing.Point(45, 215);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(58, 30);
        this.lblEmail.TabIndex = 13;
        this.lblEmail.Text = "Email";
        this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblCpf
        // 
        this.lblCpf.BackColor = System.Drawing.Color.DimGray;
        this.lblCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCpf.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblCpf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCpf.Location = new System.Drawing.Point(45, 180);
        this.lblCpf.Name = "lblCpf";
        this.lblCpf.Size = new System.Drawing.Size(45, 30);
        this.lblCpf.TabIndex = 16;
        this.lblCpf.Text = "CPF";
        this.lblCpf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblRg
        // 
        this.lblRg.BackColor = System.Drawing.Color.DimGray;
        this.lblRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblRg.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblRg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblRg.Location = new System.Drawing.Point(45, 145);
        this.lblRg.Name = "lblRg";
        this.lblRg.Size = new System.Drawing.Size(40, 30);
        this.lblRg.TabIndex = 15;
        this.lblRg.Text = "RG";
        this.lblRg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblComplemento
        // 
        this.lblComplemento.BackColor = System.Drawing.Color.DimGray;
        this.lblComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblComplemento.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblComplemento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblComplemento.Location = new System.Drawing.Point(45, 390);
        this.lblComplemento.Name = "lblComplemento";
        this.lblComplemento.Size = new System.Drawing.Size(130, 30);
        this.lblComplemento.TabIndex = 20;
        this.lblComplemento.Text = "Complemento";
        this.lblComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblLogradouro
        // 
        this.lblLogradouro.BackColor = System.Drawing.Color.DimGray;
        this.lblLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblLogradouro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblLogradouro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblLogradouro.Location = new System.Drawing.Point(45, 320);
        this.lblLogradouro.Name = "lblLogradouro";
        this.lblLogradouro.Size = new System.Drawing.Size(115, 30);
        this.lblLogradouro.TabIndex = 19;
        this.lblLogradouro.Text = "Logradouro";
        this.lblLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblNum
        // 
        this.lblNum.BackColor = System.Drawing.Color.DimGray;
        this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblNum.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblNum.Location = new System.Drawing.Point(45, 355);
        this.lblNum.Name = "lblNum";
        this.lblNum.Size = new System.Drawing.Size(85, 30);
        this.lblNum.TabIndex = 18;
        this.lblNum.Text = "Número";
        this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblBairro
        // 
        this.lblBairro.BackColor = System.Drawing.Color.DimGray;
        this.lblBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblBairro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblBairro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblBairro.Location = new System.Drawing.Point(45, 425);
        this.lblBairro.Name = "lblBairro";
        this.lblBairro.Size = new System.Drawing.Size(70, 30);
        this.lblBairro.TabIndex = 17;
        this.lblBairro.Text = "Bairro";
        this.lblBairro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtBairro
        // 
        this.txtBairro.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtBairro.Location = new System.Drawing.Point(121, 425);
        this.txtBairro.Name = "txtBairro";
        this.txtBairro.Size = new System.Drawing.Size(225, 30);
        this.txtBairro.TabIndex = 22;
        // 
        // txtCidade
        // 
        this.txtCidade.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtCidade.Location = new System.Drawing.Point(121, 461);
        this.txtCidade.Name = "txtCidade";
        this.txtCidade.Size = new System.Drawing.Size(225, 30);
        this.txtCidade.TabIndex = 23;
        // 
        // lblCep
        // 
        this.lblCep.BackColor = System.Drawing.Color.DimGray;
        this.lblCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCep.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblCep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCep.Location = new System.Drawing.Point(45, 530);
        this.lblCep.Name = "lblCep";
        this.lblCep.Size = new System.Drawing.Size(45, 30);
        this.lblCep.TabIndex = 25;
        this.lblCep.Text = "CEP";
        this.lblCep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblCidade
        // 
        this.lblCidade.BackColor = System.Drawing.Color.DimGray;
        this.lblCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCidade.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCidade.Location = new System.Drawing.Point(45, 460);
        this.lblCidade.Name = "lblCidade";
        this.lblCidade.Size = new System.Drawing.Size(70, 27);
        this.lblCidade.TabIndex = 26;
        this.lblCidade.Text = "Cidade";
        this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblUf
        // 
        this.lblUf.BackColor = System.Drawing.Color.DimGray;
        this.lblUf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblUf.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblUf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblUf.Location = new System.Drawing.Point(45, 495);
        this.lblUf.Name = "lblUf";
        this.lblUf.Size = new System.Drawing.Size(35, 30);
        this.lblUf.TabIndex = 27;
        this.lblUf.Text = "UF";
        this.lblUf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // cbUf
        // 
        this.cbUf.Font = new System.Drawing.Font("Tahoma", 14F);
        this.cbUf.FormattingEnabled = true;
        this.cbUf.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "SC", "SP", "SE", "TO" });
        this.cbUf.Location = new System.Drawing.Point(86, 495);
        this.cbUf.Name = "cbUf";
        this.cbUf.Size = new System.Drawing.Size(124, 31);
        this.cbUf.TabIndex = 28;
        // 
        // lblDataAdmissao
        // 
        this.lblDataAdmissao.BackColor = System.Drawing.Color.DimGray;
        this.lblDataAdmissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblDataAdmissao.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblDataAdmissao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblDataAdmissao.Location = new System.Drawing.Point(45, 565);
        this.lblDataAdmissao.Name = "lblDataAdmissao";
        this.lblDataAdmissao.Size = new System.Drawing.Size(162, 30);
        this.lblDataAdmissao.TabIndex = 29;
        this.lblDataAdmissao.Text = "Data de Admissão";
        this.lblDataAdmissao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblCargo
        // 
        this.lblCargo.BackColor = System.Drawing.Color.DimGray;
        this.lblCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCargo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblCargo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCargo.Location = new System.Drawing.Point(45, 110);
        this.lblCargo.Name = "lblCargo";
        this.lblCargo.Size = new System.Drawing.Size(63, 30);
        this.lblCargo.TabIndex = 31;
        this.lblCargo.Text = "Cargo";
        this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtCargo
        // 
        this.txtCargo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtCargo.Location = new System.Drawing.Point(114, 110);
        this.txtCargo.Name = "txtCargo";
        this.txtCargo.Size = new System.Drawing.Size(225, 30);
        this.txtCargo.TabIndex = 30;
        // 
        // lblSalario
        // 
        this.lblSalario.BackColor = System.Drawing.Color.DimGray;
        this.lblSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblSalario.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblSalario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblSalario.Location = new System.Drawing.Point(45, 285);
        this.lblSalario.Name = "lblSalario";
        this.lblSalario.Size = new System.Drawing.Size(74, 30);
        this.lblSalario.TabIndex = 33;
        this.lblSalario.Text = "Salário";
        this.lblSalario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtRg
        // 
        this.txtRg.Culture = new System.Globalization.CultureInfo("");
        this.txtRg.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtRg.Location = new System.Drawing.Point(91, 145);
        this.txtRg.Mask = "00.000.000-0";
        this.txtRg.Name = "txtRg";
        this.txtRg.Size = new System.Drawing.Size(120, 30);
        this.txtRg.TabIndex = 35;
        // 
        // txtTelefone
        // 
        this.txtTelefone.Culture = new System.Globalization.CultureInfo("");
        this.txtTelefone.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtTelefone.Location = new System.Drawing.Point(137, 250);
        this.txtTelefone.Mask = "(99) 00000-0000";
        this.txtTelefone.Name = "txtTelefone";
        this.txtTelefone.Size = new System.Drawing.Size(145, 30);
        this.txtTelefone.TabIndex = 36;
        // 
        // txtCpf
        // 
        this.txtCpf.Culture = new System.Globalization.CultureInfo("");
        this.txtCpf.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtCpf.Location = new System.Drawing.Point(96, 180);
        this.txtCpf.Mask = "000.000.000-00";
        this.txtCpf.Name = "txtCpf";
        this.txtCpf.Size = new System.Drawing.Size(140, 30);
        this.txtCpf.TabIndex = 37;
        // 
        // txtCep
        // 
        this.txtCep.Culture = new System.Globalization.CultureInfo("");
        this.txtCep.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtCep.Location = new System.Drawing.Point(96, 530);
        this.txtCep.Mask = "00000-000";
        this.txtCep.Name = "txtCep";
        this.txtCep.Size = new System.Drawing.Size(103, 30);
        this.txtCep.TabIndex = 38;
        // 
        // txtSalario
        // 
        this.txtSalario.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtSalario.Location = new System.Drawing.Point(125, 285);
        this.txtSalario.Name = "txtSalario";
        this.txtSalario.Size = new System.Drawing.Size(124, 30);
        this.txtSalario.TabIndex = 39;
        this.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.txtSalario.Leave += new System.EventHandler(this.txtSalario_Leave);
        // 
        // lblCadastroFuncionario
        // 
        this.lblCadastroFuncionario.BackColor = System.Drawing.Color.DimGray;
        this.lblCadastroFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCadastroFuncionario.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblCadastroFuncionario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCadastroFuncionario.Location = new System.Drawing.Point(45, 25);
        this.lblCadastroFuncionario.Name = "lblCadastroFuncionario";
        this.lblCadastroFuncionario.Size = new System.Drawing.Size(276, 40);
        this.lblCadastroFuncionario.TabIndex = 40;
        this.lblCadastroFuncionario.Text = "Cadastrar Funcionário";
        this.lblCadastroFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CadastroFuncionarioForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 681);
        this.Controls.Add(this.lblCadastroFuncionario);
        this.Controls.Add(this.txtSalario);
        this.Controls.Add(this.txtCep);
        this.Controls.Add(this.txtCpf);
        this.Controls.Add(this.txtTelefone);
        this.Controls.Add(this.txtRg);
        this.Controls.Add(this.lblSalario);
        this.Controls.Add(this.lblCargo);
        this.Controls.Add(this.txtCargo);
        this.Controls.Add(this.lblDataAdmissao);
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
        this.Controls.Add(this.lblCpf);
        this.Controls.Add(this.lblRg);
        this.Controls.Add(this.lblTelefone);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.lblNome);
        this.Controls.Add(this.txtNumero);
        this.Controls.Add(this.dateDataAdmissao);
        this.Controls.Add(this.txtLogradouro);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.txtComplemento);
        this.Controls.Add(this.txtNome);
        this.MaximizeBox = false;
        this.Name = "CadastroFuncionarioForm";
        this.ShowIcon = false;
        this.Text = "Cadastrar Funcionário";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.CadastroFuncionarioForm_Load);
        this.ResizeBegin += new System.EventHandler(this.CadastroFuncionarioForm_Load);
        this.ResizeEnd += new System.EventHandler(this.CadastroFuncionarioForm_Load);
        this.Resize += new System.EventHandler(this.CadastroFuncionarioForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblCadastroFuncionario;

    private System.Windows.Forms.TextBox txtSalario;

    private System.Windows.Forms.MaskedTextBox txtCep;

    private System.Windows.Forms.MaskedTextBox txtCpf;

    private System.Windows.Forms.MaskedTextBox txtRg;
    private System.Windows.Forms.MaskedTextBox txtTelefone;

    private System.Windows.Forms.Label lblSalario;

    private System.Windows.Forms.Label lblCargo;
    private System.Windows.Forms.TextBox txtCargo;

    private System.Windows.Forms.Label lblCep;

    private System.Windows.Forms.ComboBox cbUf;

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

    private System.Windows.Forms.TextBox txtEmail;

    private System.Windows.Forms.Button btnCancelar;

    private System.Windows.Forms.Button btnSalvar;

    private System.Windows.Forms.TextBox txtComplemento;

    private System.Windows.Forms.TextBox txtNome;

    #endregion
}
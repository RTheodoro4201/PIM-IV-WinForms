using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Usuarios;

partial class ConsultaUsuarioForm
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
        this.lblCargo = new System.Windows.Forms.Label();
        this.lblLogin = new System.Windows.Forms.Label();
        this.txtDescricao = new System.Windows.Forms.TextBox();
        this.btnFechar = new System.Windows.Forms.Button();
        this.txtLogin = new System.Windows.Forms.TextBox();
        this.lblConsultaUsuario = new System.Windows.Forms.Label();
        this.lblId = new System.Windows.Forms.Label();
        this.txtId = new System.Windows.Forms.TextBox();
        this.lblSenha = new System.Windows.Forms.Label();
        this.txtSenha = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // lblCargo
        // 
        this.lblCargo.BackColor = System.Drawing.Color.DimGray;
        this.lblCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCargo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblCargo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCargo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblCargo.Location = new System.Drawing.Point(45, 110);
        this.lblCargo.Name = "lblCargo";
        this.lblCargo.Size = new System.Drawing.Size(63, 30);
        this.lblCargo.TabIndex = 54;
        this.lblCargo.Text = "Cargo";
        this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblLogin
        // 
        this.lblLogin.BackColor = System.Drawing.Color.DimGray;
        this.lblLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblLogin.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblLogin.Location = new System.Drawing.Point(45, 75);
        this.lblLogin.Name = "lblLogin";
        this.lblLogin.Size = new System.Drawing.Size(63, 30);
        this.lblLogin.TabIndex = 50;
        this.lblLogin.Text = "Login";
        this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtDescricao
        // 
        this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtDescricao.Location = new System.Drawing.Point(114, 109);
        this.txtDescricao.Name = "txtDescricao";
        this.txtDescricao.ReadOnly = true;
        this.txtDescricao.Size = new System.Drawing.Size(365, 30);
        this.txtDescricao.TabIndex = 43;
        // 
        // btnFechar
        // 
        this.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnFechar.BackColor = System.Drawing.Color.DimGray;
        this.btnFechar.FlatAppearance.BorderSize = 0;
        this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnFechar.Font = new System.Drawing.Font("Tahoma", 14F);
        this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnFechar.Location = new System.Drawing.Point(368, 602);
        this.btnFechar.Name = "btnFechar";
        this.btnFechar.Size = new System.Drawing.Size(148, 52);
        this.btnFechar.TabIndex = 68;
        this.btnFechar.Text = "Fechar";
        this.btnFechar.UseVisualStyleBackColor = false;
        this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
        // 
        // txtLogin
        // 
        this.txtLogin.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtLogin.Location = new System.Drawing.Point(114, 75);
        this.txtLogin.Name = "txtLogin";
        this.txtLogin.ReadOnly = true;
        this.txtLogin.Size = new System.Drawing.Size(365, 30);
        this.txtLogin.TabIndex = 69;
        // 
        // lblConsultaUsuario
        // 
        this.lblConsultaUsuario.BackColor = System.Drawing.Color.DimGray;
        this.lblConsultaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblConsultaUsuario.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblConsultaUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblConsultaUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblConsultaUsuario.Location = new System.Drawing.Point(45, 25);
        this.lblConsultaUsuario.Name = "lblConsultaUsuario";
        this.lblConsultaUsuario.Size = new System.Drawing.Size(233, 40);
        this.lblConsultaUsuario.TabIndex = 78;
        this.lblConsultaUsuario.Text = "Consultar Usuário";
        this.lblConsultaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblId
        // 
        this.lblId.BackColor = System.Drawing.Color.DimGray;
        this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblId.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblId.Location = new System.Drawing.Point(284, 25);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(100, 40);
        this.lblId.TabIndex = 79;
        this.lblId.Text = "Código";
        this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtId
        // 
        this.txtId.Font = new System.Drawing.Font("Tahoma", 20F);
        this.txtId.Location = new System.Drawing.Point(390, 25);
        this.txtId.Name = "txtId";
        this.txtId.ReadOnly = true;
        this.txtId.Size = new System.Drawing.Size(90, 40);
        this.txtId.TabIndex = 80;
        this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblSenha
        // 
        this.lblSenha.BackColor = System.Drawing.Color.DimGray;
        this.lblSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblSenha.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblSenha.Location = new System.Drawing.Point(45, 145);
        this.lblSenha.Name = "lblSenha";
        this.lblSenha.Size = new System.Drawing.Size(69, 30);
        this.lblSenha.TabIndex = 82;
        this.lblSenha.Text = "Senha";
        this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtSenha
        // 
        this.txtSenha.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtSenha.Location = new System.Drawing.Point(120, 145);
        this.txtSenha.Name = "txtSenha";
        this.txtSenha.ReadOnly = true;
        this.txtSenha.Size = new System.Drawing.Size(170, 30);
        this.txtSenha.TabIndex = 81;
        // 
        // ConsultaUsuarioForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
        this.Controls.Add(this.lblSenha);
        this.Controls.Add(this.txtSenha);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblId);
        this.Controls.Add(this.lblConsultaUsuario);
        this.Controls.Add(this.txtLogin);
        this.Controls.Add(this.btnFechar);
        this.Controls.Add(this.lblCargo);
        this.Controls.Add(this.lblLogin);
        this.Controls.Add(this.txtDescricao);
        this.MaximizeBox = false;
        this.Name = "ConsultaUsuarioForm";
        this.ShowIcon = false;
        this.Text = "Consultar Usuário";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.ConsultaUsuarioForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblSenha;
    private System.Windows.Forms.TextBox txtSenha;

    private System.Windows.Forms.TextBox txtId;

    private System.Windows.Forms.Label lblId;

    private System.Windows.Forms.Label lblConsultaUsuario;

    private System.Windows.Forms.TextBox txtLogin;

    private System.Windows.Forms.Button btnFechar;

    private System.Windows.Forms.Label lblCargo;
    private System.Windows.Forms.Label lblLogin;
    private System.Windows.Forms.TextBox txtDescricao;

    #endregion
}
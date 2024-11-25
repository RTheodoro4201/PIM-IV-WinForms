using System.ComponentModel;

namespace PIM_IV_Forms.Forms;

partial class LoginForm
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
        this.btnLogar = new System.Windows.Forms.Button();
        this.Login = new System.Windows.Forms.Label();
        this.txtLogin = new System.Windows.Forms.TextBox();
        this.txtSenha = new System.Windows.Forms.TextBox();
        this.lblSenha = new System.Windows.Forms.Label();
        this.btnFechar = new System.Windows.Forms.Button();
        this.chkRevelar = new System.Windows.Forms.CheckBox();
        this.SuspendLayout();
        // 
        // btnLogar
        // 
        this.btnLogar.BackColor = System.Drawing.Color.DimGray;
        this.btnLogar.FlatAppearance.BorderSize = 0;
        this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogar.Font = new System.Drawing.Font("Tahoma", 20F);
        this.btnLogar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnLogar.Location = new System.Drawing.Point(497, 429);
        this.btnLogar.Name = "btnLogar";
        this.btnLogar.Size = new System.Drawing.Size(133, 48);
        this.btnLogar.TabIndex = 0;
        this.btnLogar.Text = "Logar";
        this.btnLogar.UseVisualStyleBackColor = false;
        this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
        // 
        // Login
        // 
        this.Login.BackColor = System.Drawing.Color.DimGray;
        this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.Login.Font = new System.Drawing.Font("Tahoma", 20F);
        this.Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.Login.Location = new System.Drawing.Point(414, 251);
        this.Login.Name = "Login";
        this.Login.Size = new System.Drawing.Size(216, 40);
        this.Login.TabIndex = 1;
        this.Login.Text = "Login";
        this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtLogin
        // 
        this.txtLogin.Font = new System.Drawing.Font("Tahoma", 20F);
        this.txtLogin.Location = new System.Drawing.Point(636, 251);
        this.txtLogin.Name = "txtLogin";
        this.txtLogin.Size = new System.Drawing.Size(300, 40);
        this.txtLogin.TabIndex = 2;
        // 
        // txtSenha
        // 
        this.txtSenha.Font = new System.Drawing.Font("Tahoma", 20F);
        this.txtSenha.Location = new System.Drawing.Point(636, 301);
        this.txtSenha.Name = "txtSenha";
        this.txtSenha.Size = new System.Drawing.Size(300, 40);
        this.txtSenha.TabIndex = 4;
        this.txtSenha.UseSystemPasswordChar = true;
        // 
        // lblSenha
        // 
        this.lblSenha.BackColor = System.Drawing.Color.DimGray;
        this.lblSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.lblSenha.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblSenha.Location = new System.Drawing.Point(414, 301);
        this.lblSenha.Name = "lblSenha";
        this.lblSenha.Size = new System.Drawing.Size(216, 40);
        this.lblSenha.TabIndex = 3;
        this.lblSenha.Text = "Senha";
        this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnFechar
        // 
        this.btnFechar.BackColor = System.Drawing.Color.DimGray;
        this.btnFechar.FlatAppearance.BorderSize = 0;
        this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnFechar.Font = new System.Drawing.Font("Tahoma", 20F);
        this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnFechar.Location = new System.Drawing.Point(720, 429);
        this.btnFechar.Name = "btnFechar";
        this.btnFechar.Size = new System.Drawing.Size(133, 48);
        this.btnFechar.TabIndex = 5;
        this.btnFechar.Text = "Fechar";
        this.btnFechar.UseVisualStyleBackColor = false;
        this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
        // 
        // chkRevelar
        // 
        this.chkRevelar.BackColor = System.Drawing.Color.DimGray;
        this.chkRevelar.Font = new System.Drawing.Font("Tahoma", 20F);
        this.chkRevelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.chkRevelar.Location = new System.Drawing.Point(942, 301);
        this.chkRevelar.Name = "chkRevelar";
        this.chkRevelar.Size = new System.Drawing.Size(122, 40);
        this.chkRevelar.TabIndex = 82;
        this.chkRevelar.Text = "Revelar";
        this.chkRevelar.UseVisualStyleBackColor = false;
        this.chkRevelar.CheckedChanged += new System.EventHandler(this.chkRevelar_CheckedChanged);
        // 
        // LoginForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 681);
        this.Controls.Add(this.chkRevelar);
        this.Controls.Add(this.btnFechar);
        this.Controls.Add(this.txtSenha);
        this.Controls.Add(this.lblSenha);
        this.Controls.Add(this.txtLogin);
        this.Controls.Add(this.Login);
        this.Controls.Add(this.btnLogar);
        this.Name = "LoginForm";
        this.Text = "Fresh Co.";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.CheckBox chkRevelar;

    private System.Windows.Forms.Button btnFechar;

    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.Label lblSenha;

    private System.Windows.Forms.Button btnLogar;
    private System.Windows.Forms.Label Login;
    private System.Windows.Forms.TextBox txtLogin;

    #endregion
}
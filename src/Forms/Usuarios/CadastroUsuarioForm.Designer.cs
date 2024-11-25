using System.ComponentModel;

namespace PIM_IV_Forms.Forms.Usuarios;

partial class CadastroUsuarioForm
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
        this.txtCargo = new System.Windows.Forms.TextBox();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.txtLogin = new System.Windows.Forms.TextBox();
        this.lblQuantidadeEstoque = new System.Windows.Forms.Label();
        this.txtSenha = new System.Windows.Forms.TextBox();
        this.lblCadastroUsuario = new System.Windows.Forms.Label();
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
        // txtCargo
        // 
        this.txtCargo.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtCargo.Location = new System.Drawing.Point(114, 110);
        this.txtCargo.Name = "txtCargo";
        this.txtCargo.Size = new System.Drawing.Size(365, 30);
        this.txtCargo.TabIndex = 43;
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
        // txtLogin
        // 
        this.txtLogin.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtLogin.Location = new System.Drawing.Point(114, 75);
        this.txtLogin.Name = "txtLogin";
        this.txtLogin.Size = new System.Drawing.Size(365, 30);
        this.txtLogin.TabIndex = 69;
        // 
        // lblQuantidadeEstoque
        // 
        this.lblQuantidadeEstoque.BackColor = System.Drawing.Color.DimGray;
        this.lblQuantidadeEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblQuantidadeEstoque.Font = new System.Drawing.Font("Tahoma", 14F);
        this.lblQuantidadeEstoque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblQuantidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblQuantidadeEstoque.Location = new System.Drawing.Point(45, 145);
        this.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque";
        this.lblQuantidadeEstoque.Size = new System.Drawing.Size(69, 30);
        this.lblQuantidadeEstoque.TabIndex = 75;
        this.lblQuantidadeEstoque.Text = "Senha";
        this.lblQuantidadeEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtSenha
        // 
        this.txtSenha.Font = new System.Drawing.Font("Tahoma", 14F);
        this.txtSenha.Location = new System.Drawing.Point(120, 145);
        this.txtSenha.Name = "txtSenha";
        this.txtSenha.Size = new System.Drawing.Size(170, 30);
        this.txtSenha.TabIndex = 74;
        this.txtSenha.UseSystemPasswordChar = true;
        // 
        // lblCadastroUsuario
        // 
        this.lblCadastroUsuario.BackColor = System.Drawing.Color.DimGray;
        this.lblCadastroUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblCadastroUsuario.Font = new System.Drawing.Font("Tahoma", 20F);
        this.lblCadastroUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCadastroUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblCadastroUsuario.Location = new System.Drawing.Point(45, 25);
        this.lblCadastroUsuario.Name = "lblCadastroUsuario";
        this.lblCadastroUsuario.Size = new System.Drawing.Size(233, 40);
        this.lblCadastroUsuario.TabIndex = 78;
        this.lblCadastroUsuario.Text = "Cadastrar Usuário";
        this.lblCadastroUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CadastroUsuarioForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 685);
        this.Controls.Add(this.lblCadastroUsuario);
        this.Controls.Add(this.lblQuantidadeEstoque);
        this.Controls.Add(this.txtSenha);
        this.Controls.Add(this.txtLogin);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.lblCargo);
        this.Controls.Add(this.lblLogin);
        this.Controls.Add(this.txtCargo);
        this.MaximizeBox = false;
        this.Name = "CadastroUsuarioForm";
        this.ShowIcon = false;
        this.Text = "Cadastrar Usuário";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.CadastroUsuarioForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblCadastroUsuario;

    private System.Windows.Forms.Label lblQuantidadeEstoque;

    private System.Windows.Forms.TextBox txtSenha;

    private System.Windows.Forms.TextBox txtLogin;

    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnSalvar;

    private System.Windows.Forms.Label lblCargo;
    private System.Windows.Forms.Label lblLogin;
    private System.Windows.Forms.TextBox txtCargo;

    #endregion
}
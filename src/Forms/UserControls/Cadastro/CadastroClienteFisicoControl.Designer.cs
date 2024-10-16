using System.ComponentModel;

namespace PIM_IV_Forms.Forms.UserControls;

partial class CadastroClienteFisicoControl
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
        this.txtNome = new System.Windows.Forms.TextBox();
        this.txtSobrenome = new System.Windows.Forms.TextBox();
        this.txtCpf = new System.Windows.Forms.TextBox();
        this.txtTelefone = new System.Windows.Forms.TextBox();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.txtRg = new System.Windows.Forms.TextBox();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.txtEndereco = new System.Windows.Forms.TextBox();
        this.dateDataNascimento = new System.Windows.Forms.DateTimePicker();
        this.SuspendLayout();
        // 
        // txtNome
        // 
        this.txtNome.Location = new System.Drawing.Point(217, 96);
        this.txtNome.Name = "txtNome";
        this.txtNome.Size = new System.Drawing.Size(113, 20);
        this.txtNome.TabIndex = 0;
        // 
        // txtSobrenome
        // 
        this.txtSobrenome.Location = new System.Drawing.Point(217, 122);
        this.txtSobrenome.Name = "txtSobrenome";
        this.txtSobrenome.Size = new System.Drawing.Size(113, 20);
        this.txtSobrenome.TabIndex = 1;
        // 
        // txtCpf
        // 
        this.txtCpf.Location = new System.Drawing.Point(217, 174);
        this.txtCpf.Name = "txtCpf";
        this.txtCpf.Size = new System.Drawing.Size(113, 20);
        this.txtCpf.TabIndex = 3;
        // 
        // txtTelefone
        // 
        this.txtTelefone.Location = new System.Drawing.Point(217, 226);
        this.txtTelefone.Name = "txtTelefone";
        this.txtTelefone.Size = new System.Drawing.Size(113, 20);
        this.txtTelefone.TabIndex = 5;
        //
        // btnSalvar
        // 
        this.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnSalvar.Location = new System.Drawing.Point(198, 311);
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.Size = new System.Drawing.Size(75, 23);
        this.btnSalvar.TabIndex = 8;
        this.btnSalvar.Text = "Salvar";
        this.btnSalvar.UseVisualStyleBackColor = true;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        // 
        // btnCancelar
        // 
        this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.btnCancelar.Location = new System.Drawing.Point(290, 311);
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.Size = new System.Drawing.Size(75, 23);
        this.btnCancelar.TabIndex = 9;
        this.btnCancelar.Text = "Cancelar";
        this.btnCancelar.UseVisualStyleBackColor = true;
        // 
        // txtRg
        // 
        this.txtRg.Location = new System.Drawing.Point(217, 148);
        this.txtRg.Name = "txtRg";
        this.txtRg.Size = new System.Drawing.Size(113, 20);
        this.txtRg.TabIndex = 2;
        // 
        // txtEmail
        // 
        this.txtEmail.Location = new System.Drawing.Point(217, 200);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(113, 20);
        this.txtEmail.TabIndex = 4;
        // 
        // txtEndereco
        // 
        this.txtEndereco.Location = new System.Drawing.Point(217, 252);
        this.txtEndereco.Name = "txtEndereco";
        this.txtEndereco.Size = new System.Drawing.Size(113, 20);
        this.txtEndereco.TabIndex = 6;
        // 
        // dateDataNascimento
        // 
        this.dateDataNascimento.CustomFormat = "";
        this.dateDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDataNascimento.Location = new System.Drawing.Point(217, 278);
        this.dateDataNascimento.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
        this.dateDataNascimento.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
        this.dateDataNascimento.Name = "dateDataNascimento";
        this.dateDataNascimento.Size = new System.Drawing.Size(113, 20);
        this.dateDataNascimento.TabIndex = 7;
        this.dateDataNascimento.Value = new System.DateTime(2002, 10, 13, 0, 0, 0, 0);
        // 
        // CadastroClienteFisicoControl
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.Controls.Add(this.dateDataNascimento);
        this.Controls.Add(this.txtEndereco);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.txtRg);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.txtTelefone);
        this.Controls.Add(this.txtCpf);
        this.Controls.Add(this.txtSobrenome);
        this.Controls.Add(this.txtNome);
        this.Name = "CadastroClienteFisicoControl";
        this.Size = new System.Drawing.Size(1366, 768);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.DateTimePicker dateDataNascimento;

    private System.Windows.Forms.TextBox txtEndereco;

    private System.Windows.Forms.TextBox txtRg;

    private System.Windows.Forms.TextBox txtEmail;

    private System.Windows.Forms.Button btnCancelar;

    private System.Windows.Forms.Button btnSalvar;

    private System.Windows.Forms.TextBox txtTelefone;

    private System.Windows.Forms.TextBox txtSobrenome;
    private System.Windows.Forms.TextBox txtCpf;

    private System.Windows.Forms.TextBox txtNome;

    #endregion
}
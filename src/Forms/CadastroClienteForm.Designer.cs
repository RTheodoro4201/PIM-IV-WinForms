using System.ComponentModel;

namespace PIM_IV_Forms.Forms;

partial class CadastroClienteForm
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
        this.lblNome = new System.Windows.Forms.Label();
        this.lblSobrenome = new System.Windows.Forms.Label();
        this.txtNome = new System.Windows.Forms.TextBox();
        this.txtSobrenome = new System.Windows.Forms.TextBox();
        this.txtDocumento = new System.Windows.Forms.TextBox();
        this.lblDocumento = new System.Windows.Forms.Label();
        this.txtTelefone = new System.Windows.Forms.TextBox();
        this.lblTelefone = new System.Windows.Forms.Label();
        this.rbtnCpf = new System.Windows.Forms.RadioButton();
        this.rbtnCnpj = new System.Windows.Forms.RadioButton();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // lblNome
        //
        this.lblNome.AutoEllipsis = true;
        this.lblNome.AutoSize = true;
        this.lblNome.Location = new System.Drawing.Point(176, 124);
        this.lblNome.Name = "lblNome";
        this.lblNome.Size = new System.Drawing.Size(38, 13);
        this.lblNome.TabIndex = 0;
        this.lblNome.Text = "Nome:";
        //
        // lblSobrenome
        //
        this.lblSobrenome.AutoSize = true;
        this.lblSobrenome.BackColor = System.Drawing.SystemColors.Control;
        this.lblSobrenome.Location = new System.Drawing.Point(147, 147);
        this.lblSobrenome.Name = "lblSobrenome";
        this.lblSobrenome.Size = new System.Drawing.Size(67, 13);
        this.lblSobrenome.TabIndex = 1;
        this.lblSobrenome.Text = "Sobrenome: ";
        //
        // txtNome
        //
        this.txtNome.Location = new System.Drawing.Point(220, 124);
        this.txtNome.Name = "txtNome";
        this.txtNome.Size = new System.Drawing.Size(100, 20);
        this.txtNome.TabIndex = 2;
        //
        // txtSobrenome
        //
        this.txtSobrenome.Location = new System.Drawing.Point(220, 147);
        this.txtSobrenome.Name = "txtSobrenome";
        this.txtSobrenome.Size = new System.Drawing.Size(100, 20);
        this.txtSobrenome.TabIndex = 3;
        //
        // txtDocumento
        //
        this.txtDocumento.Location = new System.Drawing.Point(220, 170);
        this.txtDocumento.Name = "txtDocumento";
        this.txtDocumento.Size = new System.Drawing.Size(100, 20);
        this.txtDocumento.TabIndex = 5;
        //
        // lblDocumento
        //
        this.lblDocumento.AutoSize = true;
        this.lblDocumento.Location = new System.Drawing.Point(146, 170);
        this.lblDocumento.Name = "lblDocumento";
        this.lblDocumento.Size = new System.Drawing.Size(68, 13);
        this.lblDocumento.TabIndex = 4;
        this.lblDocumento.Text = "Documento: ";
        //
        // txtTelefone
        //
        this.txtTelefone.Location = new System.Drawing.Point(220, 193);
        this.txtTelefone.Name = "txtTelefone";
        this.txtTelefone.Size = new System.Drawing.Size(100, 20);
        this.txtTelefone.TabIndex = 7;
        //
        // lblTelefone
        //
        this.lblTelefone.AutoSize = true;
        this.lblTelefone.Location = new System.Drawing.Point(162, 193);
        this.lblTelefone.Name = "lblTelefone";
        this.lblTelefone.Size = new System.Drawing.Size(52, 13);
        this.lblTelefone.TabIndex = 6;
        this.lblTelefone.Text = "Telefone:";
        //
        // rbtnCpf
        //
        this.rbtnCpf.AutoSize = true;
        this.rbtnCpf.Location = new System.Drawing.Point(322, 171);
        this.rbtnCpf.Name = "rbtnCpf";
        this.rbtnCpf.Size = new System.Drawing.Size(45, 17);
        this.rbtnCpf.TabIndex = 8;
        this.rbtnCpf.TabStop = true;
        this.rbtnCpf.Text = "CPF";
        this.rbtnCpf.UseVisualStyleBackColor = true;
        //
        // rbtnCnpj
        //
        this.rbtnCnpj.AutoSize = true;
        this.rbtnCnpj.Location = new System.Drawing.Point(373, 171);
        this.rbtnCnpj.Name = "rbtnCnpj";
        this.rbtnCnpj.Size = new System.Drawing.Size(52, 17);
        this.rbtnCnpj.TabIndex = 9;
        this.rbtnCnpj.TabStop = true;
        this.rbtnCnpj.Text = "CNPJ";
        this.rbtnCnpj.UseVisualStyleBackColor = true;
        //
        // btnSalvar
        //
        this.btnSalvar.Location = new System.Drawing.Point(199, 228);
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.Size = new System.Drawing.Size(75, 23);
        this.btnSalvar.TabIndex = 10;
        this.btnSalvar.Text = "Salvar";
        this.btnSalvar.UseVisualStyleBackColor = true;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        //
        // btnCancelar
        //
        this.btnCancelar.Location = new System.Drawing.Point(280, 228);
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.Size = new System.Drawing.Size(75, 23);
        this.btnCancelar.TabIndex = 11;
        this.btnCancelar.Text = "Cancelar";
        this.btnCancelar.UseVisualStyleBackColor = true;
        this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        //
        // CadastroClienteForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.ClientSize = new System.Drawing.Size(612, 450);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.rbtnCnpj);
        this.Controls.Add(this.rbtnCpf);
        this.Controls.Add(this.txtTelefone);
        this.Controls.Add(this.lblTelefone);
        this.Controls.Add(this.txtDocumento);
        this.Controls.Add(this.lblDocumento);
        this.Controls.Add(this.txtSobrenome);
        this.Controls.Add(this.txtNome);
        this.Controls.Add(this.lblSobrenome);
        this.Controls.Add(this.lblNome);
        this.Name = "CadastroClienteForm";
        this.ShowIcon = false;
        this.Text = "Gestão de Clientes";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button btnSalvar;

    private System.Windows.Forms.Button btnCancelar;

    private System.Windows.Forms.RadioButton rbtnCpf;
    private System.Windows.Forms.RadioButton rbtnCnpj;

    private System.Windows.Forms.TextBox txtTelefone;
    private System.Windows.Forms.Label lblTelefone;

    private System.Windows.Forms.TextBox txtDocumento;
    private System.Windows.Forms.Label lblDocumento;

    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.TextBox txtSobrenome;

    private System.Windows.Forms.Label lblSobrenome;

    private System.Windows.Forms.Label lblNome;

    #endregion
}
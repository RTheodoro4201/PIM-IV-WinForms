using System.ComponentModel;

namespace PIM_IV_Forms.Forms;

partial class MainForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.userControl1 = new System.Windows.Forms.UserControl();
        this.btnFornecedor = new System.Windows.Forms.Button();
        this.panel1 = new System.Windows.Forms.Panel();
        this.btnFornecedorJuridico = new System.Windows.Forms.Button();
        this.btnFornecedorFisico = new System.Windows.Forms.Button();
        this.btnClienteFisico = new System.Windows.Forms.Button();
        this.btnClienteJuridico = new System.Windows.Forms.Button();
        this.btnCliente = new System.Windows.Forms.Button();
        this.btnMaterial = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        this.SuspendLayout();
        //
        // label1
        //
        this.label1.BackColor = System.Drawing.Color.DimGray;
        this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.label1, "label1");
        this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.label1.Name = "label1";
        //
        // label2
        //
        this.label2.BackColor = System.Drawing.Color.CadetBlue;
        this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.label2, "label2");
        this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.label2.Name = "label2";
        //
        // splitContainer1
        //
        this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        resources.ApplyResources(this.splitContainer1, "splitContainer1");
        this.splitContainer1.Name = "splitContainer1";
        //
        // splitContainer1.Panel1
        //
        this.splitContainer1.Panel1.Controls.Add(this.label1);
        //
        // splitContainer1.Panel2
        //
        this.splitContainer1.Panel2.Controls.Add(this.label2);
        //
        // userControl1
        //
        resources.ApplyResources(this.userControl1, "userControl1");
        this.userControl1.Name = "userControl1";
        this.userControl1.TabStop = false;
        //
        // btnFornecedor
        //
        this.btnFornecedor.BackColor = System.Drawing.Color.DimGray;
        this.btnFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnFornecedor.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnFornecedor, "btnFornecedor");
        this.btnFornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnFornecedor.Name = "btnFornecedor";
        this.btnFornecedor.UseVisualStyleBackColor = false;
        //
        // panel1
        //
        this.panel1.BackColor = System.Drawing.Color.Black;
        resources.ApplyResources(this.panel1, "panel1");
        this.panel1.Name = "panel1";
        //
        // btnFornecedorJuridico
        //
        this.btnFornecedorJuridico.BackColor = System.Drawing.Color.DimGray;
        this.btnFornecedorJuridico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnFornecedorJuridico.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnFornecedorJuridico, "btnFornecedorJuridico");
        this.btnFornecedorJuridico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnFornecedorJuridico.Name = "btnFornecedorJuridico";
        this.btnFornecedorJuridico.UseVisualStyleBackColor = false;
        //
        // btnFornecedorFisico
        //
        this.btnFornecedorFisico.BackColor = System.Drawing.Color.DimGray;
        this.btnFornecedorFisico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnFornecedorFisico.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnFornecedorFisico, "btnFornecedorFisico");
        this.btnFornecedorFisico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnFornecedorFisico.Name = "btnFornecedorFisico";
        this.btnFornecedorFisico.UseVisualStyleBackColor = false;
        //
        // btnClienteFisico
        //
        this.btnClienteFisico.BackColor = System.Drawing.Color.DimGray;
        this.btnClienteFisico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnClienteFisico.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnClienteFisico, "btnClienteFisico");
        this.btnClienteFisico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnClienteFisico.Name = "btnClienteFisico";
        this.btnClienteFisico.UseVisualStyleBackColor = false;
        //
        // btnClienteJuridico
        //
        this.btnClienteJuridico.BackColor = System.Drawing.Color.DimGray;
        this.btnClienteJuridico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnClienteJuridico.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnClienteJuridico, "btnClienteJuridico");
        this.btnClienteJuridico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnClienteJuridico.Name = "btnClienteJuridico";
        this.btnClienteJuridico.UseVisualStyleBackColor = false;
        //
        // btnCliente
        //
        this.btnCliente.BackColor = System.Drawing.Color.DimGray;
        this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnCliente.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnCliente, "btnCliente");
        this.btnCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnCliente.Name = "btnCliente";
        this.btnCliente.UseVisualStyleBackColor = false;
        //
        // btnMaterial
        //
        this.btnMaterial.BackColor = System.Drawing.Color.DimGray;
        this.btnMaterial.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnMaterial.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnMaterial, "btnMaterial");
        this.btnMaterial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnMaterial.Name = "btnMaterial";
        this.btnMaterial.UseVisualStyleBackColor = false;
        //
        // MainForm
        //
        resources.ApplyResources(this, "$this");
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.Controls.Add(this.btnMaterial);
        this.Controls.Add(this.btnClienteFisico);
        this.Controls.Add(this.btnClienteJuridico);
        this.Controls.Add(this.btnCliente);
        this.Controls.Add(this.btnFornecedorFisico);
        this.Controls.Add(this.btnFornecedorJuridico);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.btnFornecedor);
        this.Controls.Add(this.userControl1);
        this.Controls.Add(this.splitContainer1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.IsMdiContainer = true;
        this.Name = "MainForm";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        this.splitContainer1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnMaterial;

    private System.Windows.Forms.Button btnFornecedorFisico;
    private System.Windows.Forms.Button btnClienteFisico;
    private System.Windows.Forms.Button btnClienteJuridico;
    private System.Windows.Forms.Button btnCliente;

    private System.Windows.Forms.Button btnFornecedorJuridico;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button btnFornecedor;

    private System.Windows.Forms.UserControl userControl1;

    private System.Windows.Forms.SplitContainer splitContainer1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}
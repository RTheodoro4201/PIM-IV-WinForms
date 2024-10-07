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
        this.lblCadastros = new System.Windows.Forms.Label();
        this.lblCompras = new System.Windows.Forms.Label();
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.usrCMainControl = new System.Windows.Forms.UserControl();
        this.panel1 = new System.Windows.Forms.Panel();
        this.btnFornecedorJuridico = new System.Windows.Forms.Button();
        this.btnFornecedorFisico = new System.Windows.Forms.Button();
        this.btnClienteFisico = new System.Windows.Forms.Button();
        this.btnClienteJuridico = new System.Windows.Forms.Button();
        this.btnMaterial = new System.Windows.Forms.Button();
        this.lblFornecedor = new System.Windows.Forms.Label();
        this.lblCliente = new System.Windows.Forms.Label();
        this.btnSolicitacaoCompra = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        this.SuspendLayout();
        // 
        // lblCadastros
        // 
        this.lblCadastros.BackColor = System.Drawing.Color.DimGray;
        this.lblCadastros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblCadastros, "lblCadastros");
        this.lblCadastros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCadastros.Name = "lblCadastros";
        // 
        // lblCompras
        // 
        this.lblCompras.BackColor = System.Drawing.Color.CadetBlue;
        this.lblCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        resources.ApplyResources(this.lblCompras, "lblCompras");
        this.lblCompras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCompras.Name = "lblCompras";
        // 
        // splitContainer1
        // 
        this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        resources.ApplyResources(this.splitContainer1, "splitContainer1");
        this.splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        this.splitContainer1.Panel1.Controls.Add(this.lblCadastros);
        // 
        // splitContainer1.Panel2
        // 
        this.splitContainer1.Panel2.Controls.Add(this.lblCompras);
        // 
        // usrCMainControl
        // 
        resources.ApplyResources(this.usrCMainControl, "usrCMainControl");
        this.usrCMainControl.Name = "usrCMainControl";
        this.usrCMainControl.TabStop = false;
        this.usrCMainControl.Load += new System.EventHandler(this.userControl1_Load);
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
        // lblFornecedor
        // 
        this.lblFornecedor.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblFornecedor, "lblFornecedor");
        this.lblFornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblFornecedor.Name = "lblFornecedor";
        // 
        // lblCliente
        // 
        this.lblCliente.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.lblCliente, "lblCliente");
        this.lblCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCliente.Name = "lblCliente";
        // 
        // btnSolicitacaoCompra
        // 
        this.btnSolicitacaoCompra.BackColor = System.Drawing.Color.CadetBlue;
        resources.ApplyResources(this.btnSolicitacaoCompra, "btnSolicitacaoCompra");
        this.btnSolicitacaoCompra.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnSolicitacaoCompra.FlatAppearance.BorderSize = 0;
        this.btnSolicitacaoCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnSolicitacaoCompra.Name = "btnSolicitacaoCompra";
        this.btnSolicitacaoCompra.UseCompatibleTextRendering = true;
        this.btnSolicitacaoCompra.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        this.button2.BackColor = System.Drawing.Color.CadetBlue;
        this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.button2.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.button2, "button2");
        this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.button2.Name = "button2";
        this.button2.UseVisualStyleBackColor = false;
        // 
        // MainForm
        // 
        resources.ApplyResources(this, "$this");
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.Controls.Add(this.button2);
        this.Controls.Add(this.btnSolicitacaoCompra);
        this.Controls.Add(this.lblCliente);
        this.Controls.Add(this.lblFornecedor);
        this.Controls.Add(this.btnMaterial);
        this.Controls.Add(this.btnClienteFisico);
        this.Controls.Add(this.btnClienteJuridico);
        this.Controls.Add(this.btnFornecedorFisico);
        this.Controls.Add(this.btnFornecedorJuridico);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.usrCMainControl);
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

    private System.Windows.Forms.Button btnSolicitacaoCompra;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label lblCliente;

    private System.Windows.Forms.Label lblFornecedor;

    private System.Windows.Forms.Button btnMaterial;

    private System.Windows.Forms.Button btnFornecedorFisico;
    private System.Windows.Forms.Button btnClienteFisico;
    private System.Windows.Forms.Button btnClienteJuridico;

    private System.Windows.Forms.Button btnFornecedorJuridico;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.UserControl usrCMainControl;

    private System.Windows.Forms.SplitContainer splitContainer1;

    private System.Windows.Forms.Label lblCompras;

    private System.Windows.Forms.Label lblCadastros;

    #endregion
}
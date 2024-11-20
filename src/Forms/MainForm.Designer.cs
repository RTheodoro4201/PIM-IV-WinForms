using Autofac;
using IContainer = System.ComponentModel.IContainer;

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
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.btnFornecedorJurídico = new System.Windows.Forms.Button();
        this.btnCliente = new System.Windows.Forms.Button();
        this.btnFornecedorFisico = new System.Windows.Forms.Button();
        this.btnMaterial = new System.Windows.Forms.Button();
        this.panel1 = new System.Windows.Forms.Panel();
        this.btnCultura = new System.Windows.Forms.Button();
        this.btnFuncionario = new System.Windows.Forms.Button();
        this.btnFornecedor = new System.Windows.Forms.Button();
        this.btnProduto = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        this.SuspendLayout();
        // 
        // label2
        // 
        this.label2.BackColor = System.Drawing.Color.DimGray;
        resources.ApplyResources(this.label2, "label2");
        this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.label2.Name = "label2";
        // 
        // label3
        // 
        this.label3.BackColor = System.Drawing.Color.CadetBlue;
        resources.ApplyResources(this.label3, "label3");
        this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.label3.Name = "label3";
        // 
        // splitContainer1
        // 
        resources.ApplyResources(this.splitContainer1, "splitContainer1");
        this.splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        this.splitContainer1.Panel1.Controls.Add(this.label2);
        // 
        // splitContainer1.Panel2
        // 
        this.splitContainer1.Panel2.Controls.Add(this.label3);
        // 
        // btnFornecedorJurídico
        // 
        this.btnFornecedorJurídico.BackColor = System.Drawing.Color.DimGray;
        this.btnFornecedorJurídico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnFornecedorJurídico.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnFornecedorJurídico, "btnFornecedorJurídico");
        this.btnFornecedorJurídico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnFornecedorJurídico.Name = "btnFornecedorJurídico";
        this.btnFornecedorJurídico.UseVisualStyleBackColor = false;
        this.btnFornecedorJurídico.Click += new System.EventHandler(this.btnFornecedorJurídico_Click);
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
        this.btnCliente.Click += new System.EventHandler(this.btnClienteFisico_Click);
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
        this.btnFornecedorFisico.Click += new System.EventHandler(this.btnFornecedorFisico_Click);
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
        // panel1
        // 
        resources.ApplyResources(this.panel1, "panel1");
        this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panel1.Name = "panel1";
        // 
        // btnCultura
        // 
        this.btnCultura.BackColor = System.Drawing.Color.DimGray;
        this.btnCultura.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnCultura.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnCultura, "btnCultura");
        this.btnCultura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnCultura.Name = "btnCultura";
        this.btnCultura.UseVisualStyleBackColor = false;
        this.btnCultura.Click += new System.EventHandler(this.btnCultura_Click);
        // 
        // btnFuncionario
        // 
        this.btnFuncionario.BackColor = System.Drawing.Color.DimGray;
        this.btnFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnFuncionario.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnFuncionario, "btnFuncionario");
        this.btnFuncionario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnFuncionario.Name = "btnFuncionario";
        this.btnFuncionario.UseVisualStyleBackColor = false;
        this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
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
        this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
        // 
        // btnProduto
        // 
        this.btnProduto.BackColor = System.Drawing.Color.DimGray;
        this.btnProduto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnProduto.FlatAppearance.BorderSize = 0;
        resources.ApplyResources(this.btnProduto, "btnProduto");
        this.btnProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnProduto.Name = "btnProduto";
        this.btnProduto.UseVisualStyleBackColor = false;
        this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
        // 
        // MainForm
        // 
        resources.ApplyResources(this, "$this");
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.Controls.Add(this.btnProduto);
        this.Controls.Add(this.btnFornecedor);
        this.Controls.Add(this.btnFuncionario);
        this.Controls.Add(this.btnCultura);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.btnMaterial);
        this.Controls.Add(this.btnFornecedorFisico);
        this.Controls.Add(this.splitContainer1);
        this.Controls.Add(this.btnFornecedorJurídico);
        this.Controls.Add(this.btnCliente);
        this.MaximizeBox = false;
        this.Name = "MainForm";
        this.ShowIcon = false;
        this.Load += new System.EventHandler(this.MainForm_Resize);
        this.ResizeBegin += new System.EventHandler(this.MainForm_Resize);
        this.ResizeEnd += new System.EventHandler(this.MainForm_Resize);
        this.LocationChanged += new System.EventHandler(this.MainForm_Resize);
        this.SizeChanged += new System.EventHandler(this.MainForm_Resize);
        this.Resize += new System.EventHandler(this.MainForm_Resize);
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        this.splitContainer1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnProduto;

    private System.Windows.Forms.Button btnFornecedor;

    private System.Windows.Forms.Button btnFuncionario;

    private System.Windows.Forms.Button btnCultura;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button btnFornecedorJurídico;
    private System.Windows.Forms.Button btnCliente;
    private System.Windows.Forms.Button btnFornecedorFisico;
    private System.Windows.Forms.Button btnMaterial;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.SplitContainer splitContainer1;

    #endregion
}
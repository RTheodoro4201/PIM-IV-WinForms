using System.ComponentModel;

namespace PIM_IV_Forms.Forms;

sealed partial class MainControl
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
        this.scLabelsTitulo = new System.Windows.Forms.SplitContainer();
        this.lblCadastros = new System.Windows.Forms.Label();
        this.lblCompras = new System.Windows.Forms.Label();
        this.lblCliente = new System.Windows.Forms.Label();
        this.btnMaterial = new System.Windows.Forms.Button();
        this.btnFornecedorFisico = new System.Windows.Forms.Button();
        this.btnFornecedorJuridico = new System.Windows.Forms.Button();
        this.btnJuridico = new System.Windows.Forms.Button();
        this.btnClienteFisico = new System.Windows.Forms.Button();
        this.pnlCenterLine = new System.Windows.Forms.Panel();
        this.lblFornecedor = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.scLabelsTitulo)).BeginInit();
        this.scLabelsTitulo.Panel1.SuspendLayout();
        this.scLabelsTitulo.Panel2.SuspendLayout();
        this.scLabelsTitulo.SuspendLayout();
        this.SuspendLayout();
        // 
        // scLabelsTitulo
        // 
        this.scLabelsTitulo.Dock = System.Windows.Forms.DockStyle.Top;
        this.scLabelsTitulo.Location = new System.Drawing.Point(0, 0);
        this.scLabelsTitulo.Name = "scLabelsTitulo";
        // 
        // scLabelsTitulo.Panel1
        // 
        this.scLabelsTitulo.Panel1.Controls.Add(this.lblCadastros);
        // 
        // scLabelsTitulo.Panel2
        // 
        this.scLabelsTitulo.Panel2.Controls.Add(this.lblCompras);
        this.scLabelsTitulo.Size = new System.Drawing.Size(1366, 30);
        this.scLabelsTitulo.SplitterDistance = 680;
        this.scLabelsTitulo.SplitterWidth = 2;
        this.scLabelsTitulo.TabIndex = 0;
        //
        // lblCadastros
        //
        this.lblCadastros.BackColor = System.Drawing.Color.DimGray;
        this.lblCadastros.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblCadastros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblCadastros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCadastros.Location = new System.Drawing.Point(0, 0);
        this.lblCadastros.Name = "lblCadastros";
        this.lblCadastros.Size = new System.Drawing.Size(680, 30);
        this.lblCadastros.TabIndex = 1;
        this.lblCadastros.Text = "Cadastros";
        this.lblCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // lblCompras
        //
        this.lblCompras.BackColor = System.Drawing.Color.CadetBlue;
        this.lblCompras.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblCompras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblCompras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCompras.Location = new System.Drawing.Point(0, 0);
        this.lblCompras.Name = "lblCompras";
        this.lblCompras.Size = new System.Drawing.Size(684, 30);
        this.lblCompras.TabIndex = 2;
        this.lblCompras.Text = "Compras";
        this.lblCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // lblCliente
        //
        this.lblCliente.BackColor = System.Drawing.Color.DimGray;
        this.lblCliente.Font = new System.Drawing.Font("Arial", 12F);
        this.lblCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblCliente.Location = new System.Drawing.Point(234, 325);
        this.lblCliente.Name = "lblCliente";
        this.lblCliente.Size = new System.Drawing.Size(200, 65);
        this.lblCliente.TabIndex = 23;
        this.lblCliente.Text = "Cliente";
        this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // btnMaterial
        //
        this.btnMaterial.BackColor = System.Drawing.Color.DimGray;
        this.btnMaterial.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnMaterial.FlatAppearance.BorderSize = 0;
        this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnMaterial.Font = new System.Drawing.Font("Arial", 12F);
        this.btnMaterial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnMaterial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnMaterial.Location = new System.Drawing.Point(234, 545);
        this.btnMaterial.Name = "btnMaterial";
        this.btnMaterial.Size = new System.Drawing.Size(200, 65);
        this.btnMaterial.TabIndex = 24;
        this.btnMaterial.Text = "Material";
        this.btnMaterial.UseVisualStyleBackColor = false;
        //
        // btnFornecedorFisico
        //
        this.btnFornecedorFisico.BackColor = System.Drawing.Color.DimGray;
        this.btnFornecedorFisico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnFornecedorFisico.FlatAppearance.BorderSize = 0;
        this.btnFornecedorFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnFornecedorFisico.Font = new System.Drawing.Font("Arial", 12F);
        this.btnFornecedorFisico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnFornecedorFisico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnFornecedorFisico.Location = new System.Drawing.Point(104, 215);
        this.btnFornecedorFisico.Name = "btnFornecedorFisico";
        this.btnFornecedorFisico.Size = new System.Drawing.Size(200, 65);
        this.btnFornecedorFisico.TabIndex = 25;
        this.btnFornecedorFisico.Text = "Físico";
        this.btnFornecedorFisico.UseVisualStyleBackColor = false;
        this.btnFornecedorFisico.Click += new System.EventHandler(this.btnFornecedorFisico_Click);
        //
        // btnFornecedorJuridico
        //
        this.btnFornecedorJuridico.BackColor = System.Drawing.Color.DimGray;
        this.btnFornecedorJuridico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnFornecedorJuridico.FlatAppearance.BorderSize = 0;
        this.btnFornecedorJuridico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnFornecedorJuridico.Font = new System.Drawing.Font("Arial", 12F);
        this.btnFornecedorJuridico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnFornecedorJuridico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnFornecedorJuridico.Location = new System.Drawing.Point(364, 215);
        this.btnFornecedorJuridico.Name = "btnFornecedorJuridico";
        this.btnFornecedorJuridico.Size = new System.Drawing.Size(200, 65);
        this.btnFornecedorJuridico.TabIndex = 26;
        this.btnFornecedorJuridico.Text = "Jurídico";
        this.btnFornecedorJuridico.UseVisualStyleBackColor = false;
        //
        // btnJuridico
        //
        this.btnJuridico.BackColor = System.Drawing.Color.DimGray;
        this.btnJuridico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnJuridico.FlatAppearance.BorderSize = 0;
        this.btnJuridico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnJuridico.Font = new System.Drawing.Font("Arial", 12F);
        this.btnJuridico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnJuridico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnJuridico.Location = new System.Drawing.Point(364, 435);
        this.btnJuridico.Name = "btnJuridico";
        this.btnJuridico.Size = new System.Drawing.Size(200, 65);
        this.btnJuridico.TabIndex = 27;
        this.btnJuridico.Text = "Jurídico";
        this.btnJuridico.UseVisualStyleBackColor = false;
        //
        // btnClienteFisico
        //
        this.btnClienteFisico.BackColor = System.Drawing.Color.DimGray;
        this.btnClienteFisico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        this.btnClienteFisico.FlatAppearance.BorderSize = 0;
        this.btnClienteFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClienteFisico.Font = new System.Drawing.Font("Arial", 12F);
        this.btnClienteFisico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnClienteFisico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.btnClienteFisico.Location = new System.Drawing.Point(104, 435);
        this.btnClienteFisico.Name = "btnClienteFisico";
        this.btnClienteFisico.Size = new System.Drawing.Size(200, 65);
        this.btnClienteFisico.TabIndex = 28;
        this.btnClienteFisico.Text = "Físico";
        this.btnClienteFisico.UseVisualStyleBackColor = false;
        //
        // pnlCenterLine
        //
        this.pnlCenterLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.pnlCenterLine.BackColor = System.Drawing.Color.Black;
        this.pnlCenterLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlCenterLine.Location = new System.Drawing.Point(680, -2);
        this.pnlCenterLine.Name = "pnlCenterLine";
        this.pnlCenterLine.Size = new System.Drawing.Size(4, 768);
        this.pnlCenterLine.TabIndex = 29;
        //
        // lblFornecedor
        //
        this.lblFornecedor.BackColor = System.Drawing.Color.DimGray;
        this.lblFornecedor.Font = new System.Drawing.Font("Arial", 12F);
        this.lblFornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.lblFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.lblFornecedor.Location = new System.Drawing.Point(234, 105);
        this.lblFornecedor.Name = "lblFornecedor";
        this.lblFornecedor.Size = new System.Drawing.Size(200, 65);
        this.lblFornecedor.TabIndex = 22;
        this.lblFornecedor.Text = "Fornecedor";
        this.lblFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // MainControl
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.Controls.Add(this.lblFornecedor);
        this.Controls.Add(this.pnlCenterLine);
        this.Controls.Add(this.btnClienteFisico);
        this.Controls.Add(this.btnJuridico);
        this.Controls.Add(this.btnFornecedorJuridico);
        this.Controls.Add(this.btnFornecedorFisico);
        this.Controls.Add(this.btnMaterial);
        this.Controls.Add(this.lblCliente);
        this.Controls.Add(this.scLabelsTitulo);
        this.Cursor = System.Windows.Forms.Cursors.Default;
        this.Name = "MainControl";
        this.Size = new System.Drawing.Size(1366, 769);
        this.scLabelsTitulo.Panel1.ResumeLayout(false);
        this.scLabelsTitulo.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.scLabelsTitulo)).EndInit();
        this.scLabelsTitulo.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    public System.Windows.Forms.Panel pnlCenterLine;

    public System.Windows.Forms.Button btnJuridico;
    public System.Windows.Forms.Button btnClienteFisico;

    public System.Windows.Forms.Button btnFornecedorJuridico;

    public System.Windows.Forms.Button btnFornecedorFisico;

    public System.Windows.Forms.Button btnMaterial;

    public System.Windows.Forms.Label lblCliente;

    public System.Windows.Forms.Label lblFornecedor;

    public System.Windows.Forms.Label lblCompras;

    public System.Windows.Forms.Label lblCadastros;

    public System.Windows.Forms.SplitContainer scLabelsTitulo;

    #endregion
}
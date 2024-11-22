using IContainer = System.ComponentModel.IContainer;

namespace PIM_IV_Forms.Forms.Compras;

partial class CompraForm
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
        this.btnCadastrar = new System.Windows.Forms.Button();
        this.btnAlterar = new System.Windows.Forms.Button();
        this.btnExcluir = new System.Windows.Forms.Button();
        this.dataGridCompras = new System.Windows.Forms.DataGridView();
        this.btnFechar = new System.Windows.Forms.Button();
        this.btnConsultar = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridCompras)).BeginInit();
        this.SuspendLayout();
        // 
        // btnCadastrar
        // 
        this.btnCadastrar.Location = new System.Drawing.Point(236, 86);
        this.btnCadastrar.Name = "btnCadastrar";
        this.btnCadastrar.Size = new System.Drawing.Size(215, 41);
        this.btnCadastrar.TabIndex = 0;
        this.btnCadastrar.Text = "Cadastrar";
        this.btnCadastrar.UseVisualStyleBackColor = true;
        this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
        // 
        // btnAlterar
        // 
        this.btnAlterar.Location = new System.Drawing.Point(457, 86);
        this.btnAlterar.Name = "btnAlterar";
        this.btnAlterar.Size = new System.Drawing.Size(215, 41);
        this.btnAlterar.TabIndex = 1;
        this.btnAlterar.Text = "Alterar";
        this.btnAlterar.UseVisualStyleBackColor = true;
        this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
        // 
        // btnExcluir
        // 
        this.btnExcluir.Location = new System.Drawing.Point(899, 86);
        this.btnExcluir.Name = "btnExcluir";
        this.btnExcluir.Size = new System.Drawing.Size(215, 41);
        this.btnExcluir.TabIndex = 3;
        this.btnExcluir.Text = "Excluir";
        this.btnExcluir.UseVisualStyleBackColor = true;
        this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
        // 
        // dataGridCompras
        // 
        this.dataGridCompras.BackgroundColor = System.Drawing.SystemColors.Control;
        this.dataGridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridCompras.Cursor = System.Windows.Forms.Cursors.Default;
        this.dataGridCompras.GridColor = System.Drawing.SystemColors.Control;
        this.dataGridCompras.Location = new System.Drawing.Point(12, 218);
        this.dataGridCompras.Name = "dataGridCompras";
        this.dataGridCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
        this.dataGridCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dataGridCompras.Size = new System.Drawing.Size(1326, 370);
        this.dataGridCompras.TabIndex = 4;
        // 
        // btnFechar
        // 
        this.btnFechar.Location = new System.Drawing.Point(568, 628);
        this.btnFechar.Name = "btnFechar";
        this.btnFechar.Size = new System.Drawing.Size(215, 41);
        this.btnFechar.TabIndex = 5;
        this.btnFechar.Text = "Fechar";
        this.btnFechar.UseVisualStyleBackColor = true;
        this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
        // 
        // btnConsultar
        // 
        this.btnConsultar.Location = new System.Drawing.Point(678, 86);
        this.btnConsultar.Name = "btnConsultar";
        this.btnConsultar.Size = new System.Drawing.Size(215, 41);
        this.btnConsultar.TabIndex = 6;
        this.btnConsultar.Text = "Consultar";
        this.btnConsultar.UseVisualStyleBackColor = true;
        this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
        // 
        // CompraForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 681);
        this.Controls.Add(this.btnConsultar);
        this.Controls.Add(this.btnFechar);
        this.Controls.Add(this.dataGridCompras);
        this.Controls.Add(this.btnExcluir);
        this.Controls.Add(this.btnAlterar);
        this.Controls.Add(this.btnCadastrar);
        this.MaximizeBox = false;
        this.Name = "CompraForm";
        this.Text = "Compras";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.CompraForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Move += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridCompras)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnConsultar;

    private System.Windows.Forms.Button btnFechar;

    private System.Windows.Forms.DataGridView dataGridCompras;

    private System.Windows.Forms.Button btnCadastrar;
    private System.Windows.Forms.Button btnAlterar;
    private System.Windows.Forms.Button btnExcluir;

    #endregion
}
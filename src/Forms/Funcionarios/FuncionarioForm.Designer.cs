using IContainer = System.ComponentModel.IContainer;

namespace PIM_IV_Forms.Forms.Funcionarios;

partial class FuncionarioForm
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        this.btnCadastrar = new System.Windows.Forms.Button();
        this.btnAlterar = new System.Windows.Forms.Button();
        this.btnExcluir = new System.Windows.Forms.Button();
        this.dataGridFuncionarios = new System.Windows.Forms.DataGridView();
        this.btnFechar = new System.Windows.Forms.Button();
        this.btnConsultar = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).BeginInit();
        this.SuspendLayout();
        // 
        // btnCadastrar
        // 
        this.btnCadastrar.BackColor = System.Drawing.Color.DimGray;
        this.btnCadastrar.FlatAppearance.BorderSize = 0;
        this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCadastrar.Font = new System.Drawing.Font("Tahoma", 20F);
        this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnCadastrar.Location = new System.Drawing.Point(122, 50);
        this.btnCadastrar.Name = "btnCadastrar";
        this.btnCadastrar.Size = new System.Drawing.Size(215, 70);
        this.btnCadastrar.TabIndex = 0;
        this.btnCadastrar.Text = "Cadastrar";
        this.btnCadastrar.UseVisualStyleBackColor = false;
        this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
        // 
        // btnAlterar
        // 
        this.btnAlterar.BackColor = System.Drawing.Color.DimGray;
        this.btnAlterar.FlatAppearance.BorderSize = 0;
        this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAlterar.Font = new System.Drawing.Font("Tahoma", 20F);
        this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnAlterar.Location = new System.Drawing.Point(421, 50);
        this.btnAlterar.Name = "btnAlterar";
        this.btnAlterar.Size = new System.Drawing.Size(215, 70);
        this.btnAlterar.TabIndex = 1;
        this.btnAlterar.Text = "Alterar";
        this.btnAlterar.UseVisualStyleBackColor = false;
        this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
        // 
        // btnExcluir
        // 
        this.btnExcluir.BackColor = System.Drawing.Color.DimGray;
        this.btnExcluir.FlatAppearance.BorderSize = 0;
        this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 20F);
        this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnExcluir.Location = new System.Drawing.Point(1013, 50);
        this.btnExcluir.Name = "btnExcluir";
        this.btnExcluir.Size = new System.Drawing.Size(215, 70);
        this.btnExcluir.TabIndex = 3;
        this.btnExcluir.Text = "Excluir";
        this.btnExcluir.UseVisualStyleBackColor = false;
        this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
        // 
        // dataGridFuncionarios
        // 
        this.dataGridFuncionarios.AllowUserToAddRows = false;
        this.dataGridFuncionarios.AllowUserToDeleteRows = false;
        this.dataGridFuncionarios.BackgroundColor = System.Drawing.SystemColors.Control;
        this.dataGridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridFuncionarios.Cursor = System.Windows.Forms.Cursors.Default;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dataGridFuncionarios.DefaultCellStyle = dataGridViewCellStyle1;
        this.dataGridFuncionarios.GridColor = System.Drawing.SystemColors.Control;
        this.dataGridFuncionarios.Location = new System.Drawing.Point(12, 170);
        this.dataGridFuncionarios.MultiSelect = false;
        this.dataGridFuncionarios.Name = "dataGridFuncionarios";
        this.dataGridFuncionarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
        this.dataGridFuncionarios.RowTemplate.ReadOnly = true;
        this.dataGridFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dataGridFuncionarios.Size = new System.Drawing.Size(1326, 370);
        this.dataGridFuncionarios.TabIndex = 4;
        // 
        // btnFechar
        // 
        this.btnFechar.BackColor = System.Drawing.Color.DimGray;
        this.btnFechar.FlatAppearance.BorderSize = 0;
        this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnFechar.Font = new System.Drawing.Font("Tahoma", 20F);
        this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnFechar.Location = new System.Drawing.Point(567, 575);
        this.btnFechar.Name = "btnFechar";
        this.btnFechar.Size = new System.Drawing.Size(216, 70);
        this.btnFechar.TabIndex = 5;
        this.btnFechar.Text = "Fechar";
        this.btnFechar.UseVisualStyleBackColor = false;
        this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
        // 
        // btnConsultar
        // 
        this.btnConsultar.BackColor = System.Drawing.Color.DimGray;
        this.btnConsultar.FlatAppearance.BorderSize = 0;
        this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnConsultar.Font = new System.Drawing.Font("Tahoma", 20F);
        this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.btnConsultar.Location = new System.Drawing.Point(714, 50);
        this.btnConsultar.Name = "btnConsultar";
        this.btnConsultar.Size = new System.Drawing.Size(215, 70);
        this.btnConsultar.TabIndex = 6;
        this.btnConsultar.Text = "Consultar";
        this.btnConsultar.UseVisualStyleBackColor = false;
        this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
        // 
        // FuncionarioForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.ClientSize = new System.Drawing.Size(1350, 681);
        this.Controls.Add(this.btnConsultar);
        this.Controls.Add(this.btnFechar);
        this.Controls.Add(this.dataGridFuncionarios);
        this.Controls.Add(this.btnExcluir);
        this.Controls.Add(this.btnAlterar);
        this.Controls.Add(this.btnCadastrar);
        this.MaximizeBox = false;
        this.Name = "FuncionarioForm";
        this.Text = "Funcionarios";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.FuncionarioForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.Move += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnConsultar;

    private System.Windows.Forms.Button btnFechar;

    private System.Windows.Forms.DataGridView dataGridFuncionarios;

    private System.Windows.Forms.Button btnCadastrar;
    private System.Windows.Forms.Button btnAlterar;
    private System.Windows.Forms.Button btnExcluir;

    #endregion
}
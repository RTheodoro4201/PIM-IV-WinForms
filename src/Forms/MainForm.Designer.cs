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
        this.SuspendLayout();
        //
        // MainForm
        //
        resources.ApplyResources(this, "$this");
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.PaleGreen;
        this.IsMdiContainer = true;
        this.MaximizeBox = false;
        this.Name = "MainForm";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.LocationChanged += new System.EventHandler(this.MainForm_Resize);
        this.Resize += new System.EventHandler(this.MainForm_Resize);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button button2;

    #endregion
}
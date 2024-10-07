using System.ComponentModel;

namespace PIM_IV_Forms.Forms;

partial class HomeFreshUserControl
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

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFreshUserControl));
        this.button1 = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        this.SuspendLayout();
        //
        // button1
        //
        resources.ApplyResources(this.button1, "button1");
        this.button1.Name = "button1";
        this.button1.UseVisualStyleBackColor = true;
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
        // MainForm
        //
        resources.ApplyResources(this, "$this");
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.Controls.Add(this.splitContainer1);
        this.Controls.Add(this.button1);
        this.Name = "HomeFreshUserControl";
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        this.splitContainer1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.SplitContainer splitContainer1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button1;
}
﻿namespace RTM.Forms
{
  partial class FormConsulta
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(185, 94);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(199, 137);
      this.button1.TabIndex = 0;
      this.button1.Text = "Exportar a EXCEL";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // FormConsulta
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(558, 359);
      this.Controls.Add(this.button1);
      this.Name = "FormConsulta";
      this.Text = "FormConsulta";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
  }
}
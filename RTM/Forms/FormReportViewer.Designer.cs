namespace RTM.Forms
{
  partial class FormReportViewer
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
      this.label1 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1294, 44);
      this.panel1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(102, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Imprimir";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.crystalReportViewer);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 44);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1294, 605);
      this.panel2.TabIndex = 1;
      // 
      // crystalReportViewer
      // 
      this.crystalReportViewer.ActiveViewIndex = -1;
      this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
      this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
      this.crystalReportViewer.Name = "crystalReportViewer";
      this.crystalReportViewer.ShowCloseButton = false;
      this.crystalReportViewer.ShowCopyButton = false;
      this.crystalReportViewer.ShowGotoPageButton = false;
      this.crystalReportViewer.ShowGroupTreeButton = false;
      this.crystalReportViewer.ShowLogo = false;
      this.crystalReportViewer.ShowParameterPanelButton = false;
      this.crystalReportViewer.ShowRefreshButton = false;
      this.crystalReportViewer.ShowTextSearchButton = false;
      this.crystalReportViewer.Size = new System.Drawing.Size(1294, 605);
      this.crystalReportViewer.TabIndex = 0;
      this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(6, 3);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(14, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "X";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.label1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel3.Location = new System.Drawing.Point(1270, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(24, 44);
      this.panel3.TabIndex = 7;
      // 
      // FormReportViewer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1294, 649);
      this.ControlBox = false;
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormReportViewer";
      this.Text = "FormReportViewer";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel2;
    private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label1;
  }
}
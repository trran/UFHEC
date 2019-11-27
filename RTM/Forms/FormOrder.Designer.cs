namespace RTM.Forms
{
  partial class FormOrder
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Pan",
            "5",
            "100",
            "500"}, -1);
      System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
      this.splitContainerMain = new System.Windows.Forms.SplitContainer();
      this.panel4 = new System.Windows.Forms.Panel();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.listViewDetails = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.panel3 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
      this.splitContainerMain.Panel1.SuspendLayout();
      this.splitContainerMain.Panel2.SuspendLayout();
      this.splitContainerMain.SuspendLayout();
      this.panel4.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainerMain
      // 
      this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
      this.splitContainerMain.Name = "splitContainerMain";
      this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainerMain.Panel1
      // 
      this.splitContainerMain.Panel1.Controls.Add(this.panel4);
      // 
      // splitContainerMain.Panel2
      // 
      this.splitContainerMain.Panel2.Controls.Add(this.listViewDetails);
      this.splitContainerMain.Panel2.Controls.Add(this.panel3);
      this.splitContainerMain.Size = new System.Drawing.Size(1186, 634);
      this.splitContainerMain.SplitterDistance = 254;
      this.splitContainerMain.SplitterIncrement = 2;
      this.splitContainerMain.TabIndex = 1;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.toolStrip1);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(1184, 252);
      this.panel4.TabIndex = 0;
      // 
      // toolStrip1
      // 
      this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonAdd,
            this.toolStripSeparator1,
            this.toolStripButtonUndo,
            this.toolStripSeparator6,
            this.toolStripButtonEdit,
            this.toolStripSeparator2,
            this.toolStripButtonSearch,
            this.toolStripSeparator3,
            this.toolStripButtonDelete,
            this.toolStripSeparator4,
            this.toolStripButtonPrint,
            this.toolStripSeparator5});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(1184, 48);
      this.toolStrip1.Stretch = true;
      this.toolStrip1.TabIndex = 3;
      this.toolStrip1.Text = "toolStrip1";
      this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
      // 
      // toolStripButtonNew
      // 
      this.toolStripButtonNew.AutoSize = false;
      this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
      this.toolStripButtonNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonNew.Name = "toolStripButtonNew";
      this.toolStripButtonNew.Size = new System.Drawing.Size(45, 45);
      this.toolStripButtonNew.Text = "Add";
      // 
      // toolStripButtonAdd
      // 
      this.toolStripButtonAdd.AutoSize = false;
      this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
      this.toolStripButtonAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonAdd.Name = "toolStripButtonAdd";
      this.toolStripButtonAdd.Size = new System.Drawing.Size(45, 45);
      this.toolStripButtonAdd.Text = "Save";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
      // 
      // toolStripButtonUndo
      // 
      this.toolStripButtonUndo.AutoSize = false;
      this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
      this.toolStripButtonUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonUndo.Name = "toolStripButtonUndo";
      this.toolStripButtonUndo.Size = new System.Drawing.Size(45, 45);
      this.toolStripButtonUndo.Text = "Undo";
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(6, 48);
      // 
      // toolStripButtonEdit
      // 
      this.toolStripButtonEdit.AutoSize = false;
      this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
      this.toolStripButtonEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonEdit.Name = "toolStripButtonEdit";
      this.toolStripButtonEdit.Size = new System.Drawing.Size(45, 45);
      this.toolStripButtonEdit.Text = "Edit";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
      // 
      // toolStripButtonSearch
      // 
      this.toolStripButtonSearch.AutoSize = false;
      this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
      this.toolStripButtonSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonSearch.Name = "toolStripButtonSearch";
      this.toolStripButtonSearch.Size = new System.Drawing.Size(45, 45);
      this.toolStripButtonSearch.Text = "Search";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
      // 
      // toolStripButtonDelete
      // 
      this.toolStripButtonDelete.AutoSize = false;
      this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
      this.toolStripButtonDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonDelete.Name = "toolStripButtonDelete";
      this.toolStripButtonDelete.Size = new System.Drawing.Size(45, 45);
      this.toolStripButtonDelete.Text = "Delete";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 48);
      // 
      // toolStripButtonPrint
      // 
      this.toolStripButtonPrint.AutoSize = false;
      this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
      this.toolStripButtonPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonPrint.Name = "toolStripButtonPrint";
      this.toolStripButtonPrint.Size = new System.Drawing.Size(45, 45);
      this.toolStripButtonPrint.Text = "Print";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 48);
      // 
      // listViewDetails
      // 
      this.listViewDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
      this.listViewDetails.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
      this.listViewDetails.FullRowSelect = true;
      this.listViewDetails.GridLines = true;
      this.listViewDetails.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
      this.listViewDetails.Location = new System.Drawing.Point(0, 54);
      this.listViewDetails.MultiSelect = false;
      this.listViewDetails.Name = "listViewDetails";
      this.listViewDetails.Size = new System.Drawing.Size(1184, 320);
      this.listViewDetails.TabIndex = 1;
      this.listViewDetails.UseCompatibleStateImageBehavior = false;
      this.listViewDetails.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Id";
      this.columnHeader1.Width = 84;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Descripcion";
      this.columnHeader2.Width = 268;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Cantidad";
      this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader3.Width = 91;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Precio";
      this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.columnHeader4.Width = 158;
      // 
      // columnHeader5
      // 
      this.columnHeader5.Text = "Total";
      this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.columnHeader5.Width = 176;
      // 
      // panel3
      // 
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(1184, 54);
      this.panel3.TabIndex = 0;
      // 
      // FormOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1186, 634);
      this.ControlBox = false;
      this.Controls.Add(this.splitContainerMain);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormOrder";
      this.Text = "FormOrder";
      this.splitContainerMain.Panel1.ResumeLayout(false);
      this.splitContainerMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
      this.splitContainerMain.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainerMain;
    private System.Windows.Forms.ListView listViewDetails;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButtonNew;
    private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;


  }
}
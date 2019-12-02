namespace RTM.Forms
{
  partial class FormCliente
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
      this.metroCheckBoxEstatus = new MetroFramework.Controls.MetroCheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.metroComboBoxTipoDocumento = new MetroFramework.Controls.MetroComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxNombre = new System.Windows.Forms.TextBox();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.textBoxDocumento = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBoxTelefono = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxAddress = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxEmail = new System.Windows.Forms.TextBox();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // metroCheckBoxEstatus
      // 
      this.metroCheckBoxEstatus.AutoSize = true;
      this.metroCheckBoxEstatus.Checked = true;
      this.metroCheckBoxEstatus.CheckState = System.Windows.Forms.CheckState.Checked;
      this.metroCheckBoxEstatus.Location = new System.Drawing.Point(157, 424);
      this.metroCheckBoxEstatus.Name = "metroCheckBoxEstatus";
      this.metroCheckBoxEstatus.Size = new System.Drawing.Size(62, 15);
      this.metroCheckBoxEstatus.TabIndex = 26;
      this.metroCheckBoxEstatus.Text = "Activo?";
      this.metroCheckBoxEstatus.UseSelectable = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label2.Location = new System.Drawing.Point(70, 201);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 17);
      this.label2.TabIndex = 21;
      this.label2.Text = "Documento:";
      // 
      // metroComboBoxTipoDocumento
      // 
      this.metroComboBoxTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.metroComboBoxTipoDocumento.FontSize = MetroFramework.MetroComboBoxSize.Tall;
      this.metroComboBoxTipoDocumento.FormattingEnabled = true;
      this.metroComboBoxTipoDocumento.IntegralHeight = false;
      this.metroComboBoxTipoDocumento.ItemHeight = 29;
      this.metroComboBoxTipoDocumento.Items.AddRange(new object[] {
            "RNC",
            "CED",
            "PAS"});
      this.metroComboBoxTipoDocumento.Location = new System.Drawing.Point(157, 140);
      this.metroComboBoxTipoDocumento.Name = "metroComboBoxTipoDocumento";
      this.metroComboBoxTipoDocumento.Size = new System.Drawing.Size(227, 35);
      this.metroComboBoxTipoDocumento.TabIndex = 18;
      this.metroComboBoxTipoDocumento.UseSelectable = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label5.Location = new System.Drawing.Point(20, 151);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(134, 17);
      this.label5.TabIndex = 19;
      this.label5.Text = "Tipo de documento:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label1.Location = new System.Drawing.Point(92, 99);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 17);
      this.label1.TabIndex = 17;
      this.label1.Text = "Nombre:";
      // 
      // textBoxNombre
      // 
      this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.textBoxNombre.Location = new System.Drawing.Point(157, 90);
      this.textBoxNombre.MaxLength = 200;
      this.textBoxNombre.Multiline = true;
      this.textBoxNombre.Name = "textBoxNombre";
      this.textBoxNombre.Size = new System.Drawing.Size(499, 35);
      this.textBoxNombre.TabIndex = 16;
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 48);
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
      this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
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
      this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
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
      this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(6, 48);
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
      this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
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
      this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
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
      this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 48);
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
      this.toolStrip1.Size = new System.Drawing.Size(808, 48);
      this.toolStrip1.Stretch = true;
      this.toolStrip1.TabIndex = 15;
      this.toolStrip1.Text = "toolStrip1";
      this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
      // 
      // textBoxDocumento
      // 
      this.textBoxDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.textBoxDocumento.Location = new System.Drawing.Point(157, 190);
      this.textBoxDocumento.MaxLength = 11;
      this.textBoxDocumento.Multiline = true;
      this.textBoxDocumento.Name = "textBoxDocumento";
      this.textBoxDocumento.Size = new System.Drawing.Size(227, 35);
      this.textBoxDocumento.TabIndex = 27;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label7.Location = new System.Drawing.Point(86, 248);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(68, 17);
      this.label7.TabIndex = 29;
      this.label7.Text = "Telefono:";
      // 
      // textBoxTelefono
      // 
      this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.textBoxTelefono.Location = new System.Drawing.Point(157, 240);
      this.textBoxTelefono.MaxLength = 25;
      this.textBoxTelefono.Multiline = true;
      this.textBoxTelefono.Name = "textBoxTelefono";
      this.textBoxTelefono.Size = new System.Drawing.Size(227, 35);
      this.textBoxTelefono.TabIndex = 28;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label4.Location = new System.Drawing.Point(83, 337);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(71, 17);
      this.label4.TabIndex = 31;
      this.label4.Text = "Direccion:";
      // 
      // textBoxAddress
      // 
      this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.textBoxAddress.Location = new System.Drawing.Point(157, 340);
      this.textBoxAddress.MaxLength = 500;
      this.textBoxAddress.Multiline = true;
      this.textBoxAddress.Name = "textBoxAddress";
      this.textBoxAddress.Size = new System.Drawing.Size(617, 69);
      this.textBoxAddress.TabIndex = 30;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label3.Location = new System.Drawing.Point(86, 289);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 17);
      this.label3.TabIndex = 33;
      this.label3.Text = "Email:";
      // 
      // textBoxEmail
      // 
      this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.textBoxEmail.Location = new System.Drawing.Point(157, 290);
      this.textBoxEmail.MaxLength = 25;
      this.textBoxEmail.Multiline = true;
      this.textBoxEmail.Name = "textBoxEmail";
      this.textBoxEmail.Size = new System.Drawing.Size(227, 35);
      this.textBoxEmail.TabIndex = 32;
      // 
      // FormCliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(808, 554);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxEmail);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxAddress);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.textBoxTelefono);
      this.Controls.Add(this.textBoxDocumento);
      this.Controls.Add(this.metroCheckBoxEstatus);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.metroComboBoxTipoDocumento);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxNombre);
      this.Controls.Add(this.toolStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormCliente";
      this.Text = "FormCliente";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MetroFramework.Controls.MetroCheckBox metroCheckBoxEstatus;
    private System.Windows.Forms.Label label2;
    private MetroFramework.Controls.MetroComboBox metroComboBoxTipoDocumento;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxNombre;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
    private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
    private System.Windows.Forms.ToolStripButton toolStripButtonNew;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.TextBox textBoxDocumento;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBoxTelefono;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxAddress;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxEmail;
  }
}
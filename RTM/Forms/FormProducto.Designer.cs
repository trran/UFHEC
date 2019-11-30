namespace RTM.Forms
{
  partial class FormProducto
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
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
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxDescripcion = new System.Windows.Forms.TextBox();
      this.metroComboBoxUnidadMedida = new MetroFramework.Controls.MetroComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.numericUpDownPrecio = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.numericUpDownItbis = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
      this.metroCheckBoxEstatus = new MetroFramework.Controls.MetroCheckBox();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItbis)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
      this.SuspendLayout();
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
      this.toolStrip1.Size = new System.Drawing.Size(824, 48);
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
      this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
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
      this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
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
      this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
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
      this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
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
      this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label1.Location = new System.Drawing.Point(39, 94);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 17);
      this.label1.TabIndex = 5;
      this.label1.Text = "Descripcion:";
      // 
      // textBoxDescripcion
      // 
      this.textBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.textBoxDescripcion.Location = new System.Drawing.Point(179, 85);
      this.textBoxDescripcion.Multiline = true;
      this.textBoxDescripcion.Name = "textBoxDescripcion";
      this.textBoxDescripcion.Size = new System.Drawing.Size(523, 35);
      this.textBoxDescripcion.TabIndex = 4;
      // 
      // metroComboBoxUnidadMedida
      // 
      this.metroComboBoxUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.metroComboBoxUnidadMedida.FontSize = MetroFramework.MetroComboBoxSize.Tall;
      this.metroComboBoxUnidadMedida.FormattingEnabled = true;
      this.metroComboBoxUnidadMedida.IntegralHeight = false;
      this.metroComboBoxUnidadMedida.ItemHeight = 29;
      this.metroComboBoxUnidadMedida.Items.AddRange(new object[] {
            "Unidad",
            "Caja",
            "Paleta"});
      this.metroComboBoxUnidadMedida.Location = new System.Drawing.Point(179, 137);
      this.metroComboBoxUnidadMedida.Name = "metroComboBoxUnidadMedida";
      this.metroComboBoxUnidadMedida.Size = new System.Drawing.Size(227, 35);
      this.metroComboBoxUnidadMedida.TabIndex = 6;
      this.metroComboBoxUnidadMedida.UseSelectable = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label5.Location = new System.Drawing.Point(39, 146);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(127, 17);
      this.label5.TabIndex = 7;
      this.label5.Text = "Unidad de Medida:";
      // 
      // numericUpDownPrecio
      // 
      this.numericUpDownPrecio.DecimalPlaces = 2;
      this.numericUpDownPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownPrecio.Location = new System.Drawing.Point(179, 189);
      this.numericUpDownPrecio.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
      this.numericUpDownPrecio.Name = "numericUpDownPrecio";
      this.numericUpDownPrecio.Size = new System.Drawing.Size(227, 31);
      this.numericUpDownPrecio.TabIndex = 8;
      this.numericUpDownPrecio.ThousandsSeparator = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label2.Location = new System.Drawing.Point(39, 196);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 17);
      this.label2.TabIndex = 9;
      this.label2.Text = "Precio:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label3.Location = new System.Drawing.Point(39, 244);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 17);
      this.label3.TabIndex = 11;
      this.label3.Text = "ITBIS:";
      // 
      // numericUpDownItbis
      // 
      this.numericUpDownItbis.DecimalPlaces = 2;
      this.numericUpDownItbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownItbis.Location = new System.Drawing.Point(179, 237);
      this.numericUpDownItbis.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
      this.numericUpDownItbis.Name = "numericUpDownItbis";
      this.numericUpDownItbis.Size = new System.Drawing.Size(227, 31);
      this.numericUpDownItbis.TabIndex = 10;
      this.numericUpDownItbis.ThousandsSeparator = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label4.Location = new System.Drawing.Point(39, 292);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(138, 17);
      this.label4.TabIndex = 13;
      this.label4.Text = "Cantidad Disponible:";
      // 
      // numericUpDownQty
      // 
      this.numericUpDownQty.DecimalPlaces = 2;
      this.numericUpDownQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownQty.Location = new System.Drawing.Point(179, 285);
      this.numericUpDownQty.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
      this.numericUpDownQty.Name = "numericUpDownQty";
      this.numericUpDownQty.Size = new System.Drawing.Size(227, 31);
      this.numericUpDownQty.TabIndex = 12;
      this.numericUpDownQty.ThousandsSeparator = true;
      // 
      // metroCheckBoxEstatus
      // 
      this.metroCheckBoxEstatus.AutoSize = true;
      this.metroCheckBoxEstatus.Checked = true;
      this.metroCheckBoxEstatus.CheckState = System.Windows.Forms.CheckState.Checked;
      this.metroCheckBoxEstatus.Location = new System.Drawing.Point(179, 330);
      this.metroCheckBoxEstatus.Name = "metroCheckBoxEstatus";
      this.metroCheckBoxEstatus.Size = new System.Drawing.Size(62, 15);
      this.metroCheckBoxEstatus.TabIndex = 14;
      this.metroCheckBoxEstatus.Text = "Activo?";
      this.metroCheckBoxEstatus.UseSelectable = true;
      // 
      // FormProducto
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(824, 593);
      this.Controls.Add(this.metroCheckBoxEstatus);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.numericUpDownQty);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.numericUpDownItbis);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.numericUpDownPrecio);
      this.Controls.Add(this.metroComboBoxUnidadMedida);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxDescripcion);
      this.Controls.Add(this.toolStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormProducto";
      this.Text = "FormProducto";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItbis)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

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
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxDescripcion;
    private MetroFramework.Controls.MetroComboBox metroComboBoxUnidadMedida;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown numericUpDownPrecio;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numericUpDownItbis;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numericUpDownQty;
    private MetroFramework.Controls.MetroCheckBox metroCheckBoxEstatus;
  }
}
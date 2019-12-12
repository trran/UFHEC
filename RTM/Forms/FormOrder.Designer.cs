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
      this.splitContainerMain = new System.Windows.Forms.SplitContainer();
      this.panel4 = new System.Windows.Forms.Panel();
      this.metroCheckBoxLlevaITBIS = new MetroFramework.Controls.MetroCheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxEmail = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBoxDireccion = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBoxTelefono = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.numericUpDownTotal = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.numericUpDownItbis = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDownSubtotal = new System.Windows.Forms.NumericUpDown();
      this.buttonBuscarCliente = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxClienteNombre = new System.Windows.Forms.TextBox();
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
      this.buttonLimpiar = new System.Windows.Forms.Button();
      this.buttonEliminar = new System.Windows.Forms.Button();
      this.buttonAgregar = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
      this.label8 = new System.Windows.Forms.Label();
      this.buttonBuscarProducto = new System.Windows.Forms.Button();
      this.textBoxProductoDescripcion = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
      this.splitContainerMain.Panel1.SuspendLayout();
      this.splitContainerMain.Panel2.SuspendLayout();
      this.splitContainerMain.SuspendLayout();
      this.panel4.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItbis)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubtotal)).BeginInit();
      this.toolStrip1.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
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
      this.panel4.Controls.Add(this.metroCheckBoxLlevaITBIS);
      this.panel4.Controls.Add(this.label5);
      this.panel4.Controls.Add(this.textBoxEmail);
      this.panel4.Controls.Add(this.label6);
      this.panel4.Controls.Add(this.textBoxDireccion);
      this.panel4.Controls.Add(this.label7);
      this.panel4.Controls.Add(this.textBoxTelefono);
      this.panel4.Controls.Add(this.groupBox1);
      this.panel4.Controls.Add(this.buttonBuscarCliente);
      this.panel4.Controls.Add(this.label1);
      this.panel4.Controls.Add(this.textBoxClienteNombre);
      this.panel4.Controls.Add(this.toolStrip1);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(1184, 252);
      this.panel4.TabIndex = 0;
      // 
      // metroCheckBoxLlevaITBIS
      // 
      this.metroCheckBoxLlevaITBIS.AutoSize = true;
      this.metroCheckBoxLlevaITBIS.Location = new System.Drawing.Point(355, 112);
      this.metroCheckBoxLlevaITBIS.Name = "metroCheckBoxLlevaITBIS";
      this.metroCheckBoxLlevaITBIS.Size = new System.Drawing.Size(81, 15);
      this.metroCheckBoxLlevaITBIS.TabIndex = 44;
      this.metroCheckBoxLlevaITBIS.Text = "LLeva ITBIS";
      this.metroCheckBoxLlevaITBIS.UseSelectable = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label5.Location = new System.Drawing.Point(51, 155);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(46, 17);
      this.label5.TabIndex = 43;
      this.label5.Text = "Email:";
      // 
      // textBoxEmail
      // 
      this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.textBoxEmail.Location = new System.Drawing.Point(100, 146);
      this.textBoxEmail.MaxLength = 25;
      this.textBoxEmail.Multiline = true;
      this.textBoxEmail.Name = "textBoxEmail";
      this.textBoxEmail.ReadOnly = true;
      this.textBoxEmail.Size = new System.Drawing.Size(227, 35);
      this.textBoxEmail.TabIndex = 42;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label6.Location = new System.Drawing.Point(26, 202);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(71, 17);
      this.label6.TabIndex = 41;
      this.label6.Text = "Direccion:";
      // 
      // textBoxDireccion
      // 
      this.textBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.textBoxDireccion.Location = new System.Drawing.Point(100, 189);
      this.textBoxDireccion.MaxLength = 500;
      this.textBoxDireccion.Multiline = true;
      this.textBoxDireccion.Name = "textBoxDireccion";
      this.textBoxDireccion.ReadOnly = true;
      this.textBoxDireccion.Size = new System.Drawing.Size(438, 43);
      this.textBoxDireccion.TabIndex = 40;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label7.Location = new System.Drawing.Point(29, 112);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(68, 17);
      this.label7.TabIndex = 39;
      this.label7.Text = "Telefono:";
      // 
      // textBoxTelefono
      // 
      this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.textBoxTelefono.Location = new System.Drawing.Point(100, 103);
      this.textBoxTelefono.MaxLength = 25;
      this.textBoxTelefono.Multiline = true;
      this.textBoxTelefono.Name = "textBoxTelefono";
      this.textBoxTelefono.ReadOnly = true;
      this.textBoxTelefono.Size = new System.Drawing.Size(227, 35);
      this.textBoxTelefono.TabIndex = 38;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.numericUpDownTotal);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.numericUpDownItbis);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.numericUpDownSubtotal);
      this.groupBox1.Location = new System.Drawing.Point(573, 60);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(367, 173);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Totales :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label4.Location = new System.Drawing.Point(23, 125);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(44, 17);
      this.label4.TabIndex = 19;
      this.label4.Text = "Total:";
      // 
      // numericUpDownTotal
      // 
      this.numericUpDownTotal.DecimalPlaces = 2;
      this.numericUpDownTotal.Enabled = false;
      this.numericUpDownTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownTotal.Location = new System.Drawing.Point(73, 118);
      this.numericUpDownTotal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
      this.numericUpDownTotal.Name = "numericUpDownTotal";
      this.numericUpDownTotal.ReadOnly = true;
      this.numericUpDownTotal.Size = new System.Drawing.Size(260, 31);
      this.numericUpDownTotal.TabIndex = 18;
      this.numericUpDownTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDownTotal.ThousandsSeparator = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label3.Location = new System.Drawing.Point(22, 77);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 17);
      this.label3.TabIndex = 17;
      this.label3.Text = "ITBIS:";
      // 
      // numericUpDownItbis
      // 
      this.numericUpDownItbis.DecimalPlaces = 2;
      this.numericUpDownItbis.Enabled = false;
      this.numericUpDownItbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownItbis.Location = new System.Drawing.Point(73, 70);
      this.numericUpDownItbis.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
      this.numericUpDownItbis.Name = "numericUpDownItbis";
      this.numericUpDownItbis.ReadOnly = true;
      this.numericUpDownItbis.Size = new System.Drawing.Size(260, 31);
      this.numericUpDownItbis.TabIndex = 16;
      this.numericUpDownItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDownItbis.ThousandsSeparator = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label2.Location = new System.Drawing.Point(3, 29);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 17);
      this.label2.TabIndex = 15;
      this.label2.Text = "Subtotal:";
      // 
      // numericUpDownSubtotal
      // 
      this.numericUpDownSubtotal.DecimalPlaces = 2;
      this.numericUpDownSubtotal.Enabled = false;
      this.numericUpDownSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownSubtotal.Location = new System.Drawing.Point(73, 22);
      this.numericUpDownSubtotal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
      this.numericUpDownSubtotal.Name = "numericUpDownSubtotal";
      this.numericUpDownSubtotal.ReadOnly = true;
      this.numericUpDownSubtotal.Size = new System.Drawing.Size(260, 31);
      this.numericUpDownSubtotal.TabIndex = 14;
      this.numericUpDownSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDownSubtotal.ThousandsSeparator = true;
      // 
      // buttonBuscarCliente
      // 
      this.buttonBuscarCliente.FlatAppearance.BorderSize = 0;
      this.buttonBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCliente.Image")));
      this.buttonBuscarCliente.Location = new System.Drawing.Point(445, 60);
      this.buttonBuscarCliente.Name = "buttonBuscarCliente";
      this.buttonBuscarCliente.Size = new System.Drawing.Size(55, 35);
      this.buttonBuscarCliente.TabIndex = 8;
      this.buttonBuscarCliente.UseVisualStyleBackColor = true;
      this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label1.Location = new System.Drawing.Point(42, 69);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 17);
      this.label1.TabIndex = 7;
      this.label1.Text = "Cliente:";
      // 
      // textBoxClienteNombre
      // 
      this.textBoxClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxClienteNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.textBoxClienteNombre.Location = new System.Drawing.Point(99, 60);
      this.textBoxClienteNombre.Multiline = true;
      this.textBoxClienteNombre.Name = "textBoxClienteNombre";
      this.textBoxClienteNombre.ReadOnly = true;
      this.textBoxClienteNombre.Size = new System.Drawing.Size(344, 35);
      this.textBoxClienteNombre.TabIndex = 6;
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
      this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
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
      this.listViewDetails.Location = new System.Drawing.Point(0, 54);
      this.listViewDetails.MultiSelect = false;
      this.listViewDetails.Name = "listViewDetails";
      this.listViewDetails.Size = new System.Drawing.Size(1184, 320);
      this.listViewDetails.TabIndex = 1;
      this.listViewDetails.UseCompatibleStateImageBehavior = false;
      this.listViewDetails.View = System.Windows.Forms.View.Details;
      this.listViewDetails.DoubleClick += new System.EventHandler(this.listViewDetails_DoubleClick);
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
      this.panel3.Controls.Add(this.buttonLimpiar);
      this.panel3.Controls.Add(this.buttonEliminar);
      this.panel3.Controls.Add(this.buttonAgregar);
      this.panel3.Controls.Add(this.label9);
      this.panel3.Controls.Add(this.numericUpDownCantidad);
      this.panel3.Controls.Add(this.label8);
      this.panel3.Controls.Add(this.buttonBuscarProducto);
      this.panel3.Controls.Add(this.textBoxProductoDescripcion);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(1184, 54);
      this.panel3.TabIndex = 0;
      // 
      // buttonLimpiar
      // 
      this.buttonLimpiar.FlatAppearance.BorderSize = 0;
      this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
      this.buttonLimpiar.Location = new System.Drawing.Point(881, 9);
      this.buttonLimpiar.Name = "buttonLimpiar";
      this.buttonLimpiar.Size = new System.Drawing.Size(54, 35);
      this.buttonLimpiar.TabIndex = 23;
      this.buttonLimpiar.UseVisualStyleBackColor = true;
      this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
      // 
      // buttonEliminar
      // 
      this.buttonEliminar.FlatAppearance.BorderSize = 0;
      this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
      this.buttonEliminar.Location = new System.Drawing.Point(821, 9);
      this.buttonEliminar.Name = "buttonEliminar";
      this.buttonEliminar.Size = new System.Drawing.Size(54, 35);
      this.buttonEliminar.TabIndex = 22;
      this.buttonEliminar.UseVisualStyleBackColor = true;
      this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
      // 
      // buttonAgregar
      // 
      this.buttonAgregar.FlatAppearance.BorderSize = 0;
      this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
      this.buttonAgregar.Location = new System.Drawing.Point(761, 9);
      this.buttonAgregar.Name = "buttonAgregar";
      this.buttonAgregar.Size = new System.Drawing.Size(54, 35);
      this.buttonAgregar.TabIndex = 21;
      this.buttonAgregar.UseVisualStyleBackColor = true;
      this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label9.Location = new System.Drawing.Point(580, 19);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(68, 17);
      this.label9.TabIndex = 20;
      this.label9.Text = "Cantidad:";
      // 
      // numericUpDownCantidad
      // 
      this.numericUpDownCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownCantidad.Location = new System.Drawing.Point(651, 12);
      this.numericUpDownCantidad.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
      this.numericUpDownCantidad.Name = "numericUpDownCantidad";
      this.numericUpDownCantidad.Size = new System.Drawing.Size(104, 31);
      this.numericUpDownCantidad.TabIndex = 19;
      this.numericUpDownCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numericUpDownCantidad.ThousandsSeparator = true;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.label8.Location = new System.Drawing.Point(28, 18);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(69, 17);
      this.label8.TabIndex = 12;
      this.label8.Text = "Producto:";
      // 
      // buttonBuscarProducto
      // 
      this.buttonBuscarProducto.FlatAppearance.BorderSize = 0;
      this.buttonBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarProducto.Image")));
      this.buttonBuscarProducto.Location = new System.Drawing.Point(514, 10);
      this.buttonBuscarProducto.Name = "buttonBuscarProducto";
      this.buttonBuscarProducto.Size = new System.Drawing.Size(54, 35);
      this.buttonBuscarProducto.TabIndex = 11;
      this.buttonBuscarProducto.UseVisualStyleBackColor = true;
      this.buttonBuscarProducto.Click += new System.EventHandler(this.buttonBuscarProducto_Click);
      // 
      // textBoxProductoDescripcion
      // 
      this.textBoxProductoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxProductoDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.textBoxProductoDescripcion.Location = new System.Drawing.Point(100, 10);
      this.textBoxProductoDescripcion.Multiline = true;
      this.textBoxProductoDescripcion.Name = "textBoxProductoDescripcion";
      this.textBoxProductoDescripcion.ReadOnly = true;
      this.textBoxProductoDescripcion.Size = new System.Drawing.Size(413, 35);
      this.textBoxProductoDescripcion.TabIndex = 9;
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
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItbis)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubtotal)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
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
    private System.Windows.Forms.Button buttonBuscarCliente;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxClienteNombre;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numericUpDownTotal;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numericUpDownItbis;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDownSubtotal;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBoxEmail;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBoxDireccion;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBoxTelefono;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button buttonBuscarProducto;
    private System.Windows.Forms.TextBox textBoxProductoDescripcion;
    private System.Windows.Forms.Button buttonLimpiar;
    private System.Windows.Forms.Button buttonEliminar;
    private System.Windows.Forms.Button buttonAgregar;
    private MetroFramework.Controls.MetroCheckBox metroCheckBoxLlevaITBIS;


  }
}
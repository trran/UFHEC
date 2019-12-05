namespace RTM
{
    partial class FormMainModernUI
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainModernUI));
      this.panelMenu = new System.Windows.Forms.Panel();
      this.buttonProductos = new System.Windows.Forms.Button();
      this.buttonReporte = new System.Windows.Forms.Button();
      this.buttonUsuarios = new System.Windows.Forms.Button();
      this.buttonReportes = new System.Windows.Forms.Button();
      this.buttonClientes = new System.Windows.Forms.Button();
      this.buttonOrdenes = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.labelNombre = new System.Windows.Forms.Label();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonMenu = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.panelMain = new System.Windows.Forms.Panel();
      this.timerMainMenuStart = new System.Windows.Forms.Timer(this.components);
      this.timerMainMenuStop = new System.Windows.Forms.Timer(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.panelMenu.SuspendLayout();
      this.panel1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelMenu
      // 
      this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(138)))), ((int)(((byte)(206)))));
      this.panelMenu.Controls.Add(this.buttonProductos);
      this.panelMenu.Controls.Add(this.buttonReporte);
      this.panelMenu.Controls.Add(this.buttonUsuarios);
      this.panelMenu.Controls.Add(this.buttonReportes);
      this.panelMenu.Controls.Add(this.buttonClientes);
      this.panelMenu.Controls.Add(this.buttonOrdenes);
      this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelMenu.Location = new System.Drawing.Point(0, 0);
      this.panelMenu.Name = "panelMenu";
      this.panelMenu.Size = new System.Drawing.Size(50, 647);
      this.panelMenu.TabIndex = 0;
      // 
      // buttonProductos
      // 
      this.buttonProductos.FlatAppearance.BorderSize = 0;
      this.buttonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonProductos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.buttonProductos.Image = ((System.Drawing.Image)(resources.GetObject("buttonProductos.Image")));
      this.buttonProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonProductos.Location = new System.Drawing.Point(0, 92);
      this.buttonProductos.Name = "buttonProductos";
      this.buttonProductos.Size = new System.Drawing.Size(210, 45);
      this.buttonProductos.TabIndex = 5;
      this.buttonProductos.Text = "Productos";
      this.buttonProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.toolTip1.SetToolTip(this.buttonProductos, "Productos");
      this.buttonProductos.UseVisualStyleBackColor = true;
      this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
      // 
      // buttonReporte
      // 
      this.buttonReporte.FlatAppearance.BorderSize = 0;
      this.buttonReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonReporte.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonReporte.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.buttonReporte.Image = ((System.Drawing.Image)(resources.GetObject("buttonReporte.Image")));
      this.buttonReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonReporte.Location = new System.Drawing.Point(0, 312);
      this.buttonReporte.Name = "buttonReporte";
      this.buttonReporte.Size = new System.Drawing.Size(210, 45);
      this.buttonReporte.TabIndex = 4;
      this.buttonReporte.Text = "Reporte";
      this.buttonReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.toolTip1.SetToolTip(this.buttonReporte, "Reporte");
      this.buttonReporte.UseVisualStyleBackColor = true;
      this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
      // 
      // buttonUsuarios
      // 
      this.buttonUsuarios.FlatAppearance.BorderSize = 0;
      this.buttonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonUsuarios.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonUsuarios.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.buttonUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("buttonUsuarios.Image")));
      this.buttonUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonUsuarios.Location = new System.Drawing.Point(0, 257);
      this.buttonUsuarios.Name = "buttonUsuarios";
      this.buttonUsuarios.Size = new System.Drawing.Size(210, 45);
      this.buttonUsuarios.TabIndex = 3;
      this.buttonUsuarios.Text = "Usuarios";
      this.buttonUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.toolTip1.SetToolTip(this.buttonUsuarios, "Usuarios");
      this.buttonUsuarios.UseVisualStyleBackColor = true;
      this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
      // 
      // buttonReportes
      // 
      this.buttonReportes.FlatAppearance.BorderSize = 0;
      this.buttonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonReportes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonReportes.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.buttonReportes.Image = ((System.Drawing.Image)(resources.GetObject("buttonReportes.Image")));
      this.buttonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonReportes.Location = new System.Drawing.Point(0, 147);
      this.buttonReportes.Name = "buttonReportes";
      this.buttonReportes.Size = new System.Drawing.Size(210, 45);
      this.buttonReportes.TabIndex = 2;
      this.buttonReportes.Text = "Consultas";
      this.buttonReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.toolTip1.SetToolTip(this.buttonReportes, "Consultas");
      this.buttonReportes.UseVisualStyleBackColor = true;
      this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
      // 
      // buttonClientes
      // 
      this.buttonClientes.FlatAppearance.BorderSize = 0;
      this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonClientes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonClientes.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.buttonClientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonClientes.Image")));
      this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonClientes.Location = new System.Drawing.Point(0, 202);
      this.buttonClientes.Name = "buttonClientes";
      this.buttonClientes.Size = new System.Drawing.Size(210, 45);
      this.buttonClientes.TabIndex = 1;
      this.buttonClientes.Text = "Clientes";
      this.buttonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.toolTip1.SetToolTip(this.buttonClientes, "Clientes");
      this.buttonClientes.UseVisualStyleBackColor = true;
      this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
      // 
      // buttonOrdenes
      // 
      this.buttonOrdenes.FlatAppearance.BorderSize = 0;
      this.buttonOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonOrdenes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonOrdenes.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.buttonOrdenes.Image = ((System.Drawing.Image)(resources.GetObject("buttonOrdenes.Image")));
      this.buttonOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonOrdenes.Location = new System.Drawing.Point(0, 37);
      this.buttonOrdenes.Name = "buttonOrdenes";
      this.buttonOrdenes.Size = new System.Drawing.Size(210, 45);
      this.buttonOrdenes.TabIndex = 0;
      this.buttonOrdenes.Text = "Ordenes";
      this.buttonOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.toolTip1.SetToolTip(this.buttonOrdenes, "Ordenes");
      this.buttonOrdenes.UseVisualStyleBackColor = true;
      this.buttonOrdenes.Click += new System.EventHandler(this.buttonOrdenes_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.labelNombre);
      this.panel1.Controls.Add(this.buttonMenu);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(50, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1134, 35);
      this.panel1.TabIndex = 1;
      // 
      // labelNombre
      // 
      this.labelNombre.AutoSize = true;
      this.labelNombre.ContextMenuStrip = this.contextMenuStrip1;
      this.labelNombre.Dock = System.Windows.Forms.DockStyle.Right;
      this.labelNombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(138)))), ((int)(((byte)(206)))));
      this.labelNombre.Location = new System.Drawing.Point(926, 0);
      this.labelNombre.Name = "labelNombre";
      this.labelNombre.Size = new System.Drawing.Size(208, 24);
      this.labelNombre.TabIndex = 1;
      this.labelNombre.Text = "admin admin admin";
      this.labelNombre.TextAlign = System.Drawing.ContentAlignment.BottomRight;
      this.toolTip1.SetToolTip(this.labelNombre, "Nombre de usuario");
      this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
      this.toolStripMenuItem1.Text = "Log Out";
      this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
      // 
      // buttonMenu
      // 
      this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
      this.buttonMenu.Location = new System.Drawing.Point(1, 0);
      this.buttonMenu.Name = "buttonMenu";
      this.buttonMenu.Size = new System.Drawing.Size(41, 32);
      this.buttonMenu.TabIndex = 0;
      this.buttonMenu.UseVisualStyleBackColor = true;
      this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 15;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // timer2
      // 
      this.timer2.Interval = 15;
      this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
      // 
      // panelMain
      // 
      this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
      this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelMain.Location = new System.Drawing.Point(50, 35);
      this.panelMain.Name = "panelMain";
      this.panelMain.Size = new System.Drawing.Size(1134, 612);
      this.panelMain.TabIndex = 2;
      // 
      // timerMainMenuStart
      // 
      this.timerMainMenuStart.Interval = 2;
      this.timerMainMenuStart.Tick += new System.EventHandler(this.timerMainMenuStart_Tick);
      // 
      // timerMainMenuStop
      // 
      this.timerMainMenuStop.Interval = 2;
      this.timerMainMenuStop.Tick += new System.EventHandler(this.timerMainMenuStop_Tick);
      // 
      // FormMainModernUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1184, 647);
      this.Controls.Add(this.panelMain);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panelMenu);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormMainModernUI";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RTM - Road To Market";
      this.panelMenu.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonOrdenes;
        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Timer timerMainMenuStart;
        private System.Windows.Forms.Timer timerMainMenuStop;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Button buttonProductos;
    }
}
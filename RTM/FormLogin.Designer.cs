namespace RTM
{
    partial class FormLogin
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
      this.textBoxUsername = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.buttonSignIn = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
      this.pictureBoxGoogle = new System.Windows.Forms.PictureBox();
      this.pictureBoxTwitter = new System.Windows.Forms.PictureBox();
      this.pictureBoxGitHub = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoogle)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwitter)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGitHub)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // textBoxUsername
      // 
      this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
      this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxUsername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
      this.textBoxUsername.Location = new System.Drawing.Point(47, 151);
      this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
      this.textBoxUsername.Multiline = true;
      this.textBoxUsername.Name = "textBoxUsername";
      this.textBoxUsername.Size = new System.Drawing.Size(245, 24);
      this.textBoxUsername.TabIndex = 0;
      this.textBoxUsername.Text = "Username";
      this.textBoxUsername.Enter += new System.EventHandler(this.textBox1_Enter);
      this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
      this.textBoxUsername.Leave += new System.EventHandler(this.textBox1_Leave);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.panel1.Location = new System.Drawing.Point(47, 181);
      this.panel1.Margin = new System.Windows.Forms.Padding(2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(245, 1);
      this.panel1.TabIndex = 1;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.panel2.Location = new System.Drawing.Point(48, 229);
      this.panel2.Margin = new System.Windows.Forms.Padding(2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(245, 1);
      this.panel2.TabIndex = 3;
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
      this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
      this.textBoxPassword.Location = new System.Drawing.Point(47, 203);
      this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
      this.textBoxPassword.Multiline = true;
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.Size = new System.Drawing.Size(245, 24);
      this.textBoxPassword.TabIndex = 2;
      this.textBoxPassword.Text = "Password";
      this.textBoxPassword.Enter += new System.EventHandler(this.textBox2_Enter);
      this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
      this.textBoxPassword.Leave += new System.EventHandler(this.textBox2_Leave);
      // 
      // buttonSignIn
      // 
      this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
      this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonSignIn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
      this.buttonSignIn.ForeColor = System.Drawing.Color.White;
      this.buttonSignIn.Location = new System.Drawing.Point(47, 255);
      this.buttonSignIn.Margin = new System.Windows.Forms.Padding(2);
      this.buttonSignIn.Name = "buttonSignIn";
      this.buttonSignIn.Size = new System.Drawing.Size(245, 33);
      this.buttonSignIn.TabIndex = 4;
      this.buttonSignIn.Text = "Sign In";
      this.buttonSignIn.UseVisualStyleBackColor = false;
      this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(316, 3);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(14, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "X";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(140, 324);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(69, 17);
      this.label5.TabIndex = 9;
      this.label5.Text = "Login with:";
      // 
      // pictureBoxFacebook
      // 
      this.pictureBoxFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFacebook.Image")));
      this.pictureBoxFacebook.Location = new System.Drawing.Point(47, 359);
      this.pictureBoxFacebook.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBoxFacebook.Name = "pictureBoxFacebook";
      this.pictureBoxFacebook.Size = new System.Drawing.Size(64, 64);
      this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBoxFacebook.TabIndex = 11;
      this.pictureBoxFacebook.TabStop = false;
      this.pictureBoxFacebook.Click += new System.EventHandler(this.pictureBoxFacebook_Click);
      this.pictureBoxFacebook.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
      this.pictureBoxFacebook.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
      // 
      // pictureBoxGoogle
      // 
      this.pictureBoxGoogle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGoogle.Image")));
      this.pictureBoxGoogle.Location = new System.Drawing.Point(112, 359);
      this.pictureBoxGoogle.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBoxGoogle.Name = "pictureBoxGoogle";
      this.pictureBoxGoogle.Size = new System.Drawing.Size(64, 64);
      this.pictureBoxGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBoxGoogle.TabIndex = 12;
      this.pictureBoxGoogle.TabStop = false;
      this.pictureBoxGoogle.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
      this.pictureBoxGoogle.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
      // 
      // pictureBoxTwitter
      // 
      this.pictureBoxTwitter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTwitter.Image")));
      this.pictureBoxTwitter.Location = new System.Drawing.Point(178, 359);
      this.pictureBoxTwitter.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBoxTwitter.Name = "pictureBoxTwitter";
      this.pictureBoxTwitter.Size = new System.Drawing.Size(64, 64);
      this.pictureBoxTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBoxTwitter.TabIndex = 13;
      this.pictureBoxTwitter.TabStop = false;
      this.pictureBoxTwitter.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
      this.pictureBoxTwitter.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
      // 
      // pictureBoxGitHub
      // 
      this.pictureBoxGitHub.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGitHub.Image")));
      this.pictureBoxGitHub.Location = new System.Drawing.Point(243, 359);
      this.pictureBoxGitHub.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBoxGitHub.Name = "pictureBoxGitHub";
      this.pictureBoxGitHub.Size = new System.Drawing.Size(64, 64);
      this.pictureBoxGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBoxGitHub.TabIndex = 14;
      this.pictureBoxGitHub.TabStop = false;
      this.pictureBoxGitHub.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
      this.pictureBoxGitHub.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(48, 28);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(244, 106);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 15;
      this.pictureBox1.TabStop = false;
      // 
      // timer1
      // 
      this.timer1.Interval = 10;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // timer2
      // 
      this.timer2.Interval = 10;
      this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
      // 
      // FormLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
      this.ClientSize = new System.Drawing.Size(332, 479);
      this.ControlBox = false;
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.pictureBoxGitHub);
      this.Controls.Add(this.pictureBoxTwitter);
      this.Controls.Add(this.pictureBoxGoogle);
      this.Controls.Add(this.pictureBoxFacebook);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonSignIn);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.textBoxUsername);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormLogin";
      this.Opacity = 0.99D;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.Load += new System.EventHandler(this.FormLogin_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoogle)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwitter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGitHub)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxFacebook;
        private System.Windows.Forms.PictureBox pictureBoxGoogle;
        private System.Windows.Forms.PictureBox pictureBoxTwitter;
        private System.Windows.Forms.PictureBox pictureBoxGitHub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;

    }
}


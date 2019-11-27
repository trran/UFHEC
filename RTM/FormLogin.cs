using ControllerRTM.Controller;
using RTM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTM
{
    public partial class FormLogin : Form
    {
        private readonly LoginController controller = new LoginController();
        FormLoginFacebook formFacebook;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            buttonSignIn.Focus();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxPassword.PasswordChar = '•';
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text))
                textBoxUsername.Text = "Username";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPassword.PasswordChar = new char();
                textBoxPassword.Text = "Password";
            }
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(78, 184, 206);
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Transparent;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
          if (string.IsNullOrEmpty(textBoxUsername.Text))
          {
            MetroFramework.MetroMessageBox.Show(this, "El nombre de usuario no debe estar en blanco.");
            return;
          }

          if (string.IsNullOrEmpty(textBoxPassword.Text))
          {
            MetroFramework.MetroMessageBox.Show(this, "La contraseña no debe estar en blanco.");
            return;
          }

          if (controller.CantLogin(textBoxUsername.Text, textBoxPassword.Text))
          {
            Hide();
            TopMost = false;
            FormMainModernUI formMain = new FormMainModernUI();
            formMain.FormClosed += (oSender, oE) =>
            {
              textBoxUsername.Text = "Username";
              textBoxPassword.PasswordChar = new char();
              textBoxPassword.Text = "Password";

              Show();
            };
            formMain.ShowDialog();
          }
          else
          {
            textBoxPassword.Text = string.Empty;
            textBoxPassword.Focus();
            MetroFramework.MetroMessageBox.Show(this, "Tenemos problemas al iniciar, parecer su usuario o contraseña estan mal, intentelo de nuevo");
          }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter)
          {
            buttonSignIn_Click(null, null);
          }
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
          formFacebook = new FormLoginFacebook();
          formFacebook.Show();
          timer1.Start();
          TopMost = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          formFacebook.Left += 20;
          if (formFacebook.Left >= 950)
          {
            formFacebook.TopMost = true;
            timer1.Stop();
            timer2.Start();
          }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          formFacebook.Left -= 20;
          if (formFacebook.Left <= 634)
          {
            formFacebook.TopMost = true;
            timer2.Stop();
          }
        }
    }
}

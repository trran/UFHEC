using ControllerRTM;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTM.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.TopLevel = false;
            metroPanelMain.Controls.Add(formCustomer);
            
            formCustomer.Dock = DockStyle.Fill;
            formCustomer.Show();
            timerPanel.Start();
        }

        private void timerPanel_Tick(object sender, EventArgs e)
        {
            metroPanelMain.Width += 50;

            if (metroPanelMain.Width >= Width - panelMenu.Width - 5)
            {
                timerPanel.Stop();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = CurrentUserInfo.FullName;
        }
    }
}

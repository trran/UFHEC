using ControllerRTM.Interfaces;
using MetroFramework.Forms;
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
    public partial class FormGenericSearch : MetroForm
    {
        public int Id;
        private readonly IController controller;
        public FormGenericSearch(IController controller)
        {
            InitializeComponent();
            this.metroTextBoxCriteria.WaterMark = "Busqueda...";
            this.controller = controller;
            metroGrid1.DataSource = this.controller.LoadDataTable(string.Empty);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = controller.LoadDataTable(string.IsNullOrEmpty(metroTextBoxCriteria.Text) ? string.Empty : metroTextBoxCriteria.Text);
            metroTextBoxCriteria.Clear();
        }

        private void metroGrid1_DoubleClick(object sender, EventArgs e)
        {
            buttonOk_Click(null, null);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Id = Convert.ToInt32(metroGrid1.CurrentRow.Cells["Id"].Value);
            Close();
        }

        private void metroTextBoxCriteria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                metroButton1_Click(null, null);
            }
        }
    }
}

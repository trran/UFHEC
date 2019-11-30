using ControllerRTM;
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
  public partial class FormMainModernUI : Form
  {
    public FormMainModernUI()
    {
      InitializeComponent();
      labelNombre.Text = CurrentUserInfo.FullName;
    }

    private void buttonMenu_Click(object sender, EventArgs e)
    {
      buttonMenu.Enabled = false;
      if (panelMenu.Width >= 210)
        timer2.Start();
      else
        timer1.Start();
      buttonMenu.Enabled = true;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      panelMenu.Width += 10;
      if (panelMenu.Width >= 210)
        timer1.Stop();
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
      panelMenu.Width -= 10;
      if (panelMenu.Width <= 50)
        timer2.Stop();
    }

    private void buttonOrdenes_Click(object sender, EventArgs e)
    {
      openFormInPanelMain(new FormOrder());
    }

    private void buttonUsuarios_Click(object sender, EventArgs e)
    {
      //buttonUsuarios.Enabled = false;

      //if (panelMain.Width <= 400)
      //  timerMainMenuStart.Start();
      //else
      //  timerMainMenuStop.Start();

      //buttonUsuarios.Enabled = true;
      openFormInPanelMain(new FormCustomer());
    }

    private void timerMainMenuStart_Tick(object sender, EventArgs e)
    {
      panelMain.Width += 100;
      if (panelMain.Width >= Width)
        timerMainMenuStart.Stop();
    }

    private void timerMainMenuStop_Tick(object sender, EventArgs e)
    {
      panelMain.Width -= 100;
      if (panelMain.Width <= 0)
        timerMainMenuStop.Stop();
    }

    private void openFormInPanelMain(Form sender)
    {
      if (panelMain.Controls.Count > 0)
      {
        panelMain.Controls.RemoveAt(0);
      }

      sender.TopLevel = false;
      panelMain.Controls.Add(sender);
      sender.Dock = DockStyle.Fill;
      sender.SendToBack();
      sender.Show();
    }

    private void labelNombre_Click(object sender, EventArgs e)
    {
      contextMenuStrip1.Show(labelNombre,0,30);
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void buttonReporte_Click(object sender, EventArgs e)
    {
      DataTable dt;

      CustomerController controller = new CustomerController(CurrentUserInfo.Username);
      dt = controller.LoadDataTable(string.Empty);

      openFormInPanelMain(new FormReportViewer(@"E:\Desarrollo\RTM\RTM\Reports\EmployeeReport.rpt", "Customer", dt));
    }

    private void buttonReportes_Click(object sender, EventArgs e)
    {
      openFormInPanelMain(new FormConsulta());
    }

    private void buttonProductos_Click(object sender, EventArgs e)
    {
      openFormInPanelMain(new FormProducto());
    }
  }
}

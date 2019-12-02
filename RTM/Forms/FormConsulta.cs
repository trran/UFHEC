using ControllerRTM;
using ControllerRTM.Controller;
using SmartXLS;
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
  public partial class FormConsulta : Form
  {
    public FormConsulta()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        SaveFileDialog sfg = new SaveFileDialog();
        sfg.Filter = "Xsl File (*.xlsx, *.xls) | *.xlsx, *.xls";
        sfg.FileOk += (o, oE) =>
        {

          WorkBook wb = new WorkBook();
          UsuarioController controller = new UsuarioController(CurrentUserInfo.Username);
          DataTable dt = controller.LoadDataTable(string.Empty);
          wb.ImportDataTable(dt, true, 0, 0, dt.Rows.Count, dt.Columns.Count);

          wb.writeXLSX(sfg.FileName);
        };
        sfg.ShowDialog();
      }
      catch (Exception)
      {

      }
    }

    void sfg_FileOk(object sender, CancelEventArgs e)
    {

    }
  }
}

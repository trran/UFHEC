using ControllerRTM;
using ControllerRTM.Controller;
using ControllerRTM.Interfaces;
using CrystalDecisions.CrystalReports.Engine;
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
  public partial class FormReportViewer : Form
  {
    private readonly DataTable _dataBinds;
    private readonly string _tableName;
    private readonly string _reportPath;
    private FormReportViewer()
    {
      InitializeComponent();
    }

    public FormReportViewer(string reportPath,string tableName, DataTable dataBinds)
    {
      InitializeComponent();
      _dataBinds = dataBinds;
      _tableName = tableName;
      _reportPath = reportPath;
    }

    public void RefreshReport()
    {
      button1.Visible = false;
      button1_Click(null, null);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      _dataBinds.TableName = _tableName;
      ReportDocument reportDocument = new ReportDocument();
      reportDocument.Load(_reportPath);
      reportDocument.SetDataSource(_dataBinds);
      crystalReportViewer.ReportSource = reportDocument;
      crystalReportViewer.RefreshReport();
    }

    private void label1_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}

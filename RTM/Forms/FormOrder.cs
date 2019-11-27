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
  public partial class FormOrder : Form
  {
    public FormOrder()
    {
      InitializeComponent();
    }

    private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      ToolStripItem clickedItem = e.ClickedItem;
      switch (clickedItem.Name)
      {
        case "toolStripButtonNew":
          toolStripButtonAdd.Enabled = true;
          toolStripButtonUndo.Enabled = true;
          toolStripButtonNew.Enabled = false;
          toolStripButtonEdit.Enabled = false;
          toolStripButtonDelete.Enabled = false;
          toolStripButtonPrint.Enabled = false;
          toolStripButtonSearch.Enabled = false;
          break;

        case "toolStripButtonAdd":
          toolStripButtonNew.Enabled = true;
          toolStripButtonEdit.Enabled = true;
          toolStripButtonDelete.Enabled = true;
          toolStripButtonPrint.Enabled = true;
          toolStripButtonSearch.Enabled = true;
          toolStripButtonUndo.Enabled = false;
          break;

        case "toolStripButtonEdit":
          toolStripButtonAdd.Enabled = true;
          toolStripButtonUndo.Enabled = true;
          toolStripButtonEdit.Enabled = false;
          toolStripButtonNew.Enabled = false;
          toolStripButtonDelete.Enabled = false;
          toolStripButtonPrint.Enabled = false;
          toolStripButtonSearch.Enabled = false;
          break;

        case "toolStripButtonSearch":
          toolStripButtonNew.Enabled = true;
          toolStripButtonSearch.Enabled = true;
          toolStripButtonDelete.Enabled = true;
          toolStripButtonPrint.Enabled = true;
          toolStripButtonEdit.Enabled = true;
          toolStripButtonAdd.Enabled = false;
          toolStripButtonUndo.Enabled = false;
          clickedItem = toolStripButtonUndo;
          break;

        case "toolStripButtonDelete":
          break;

        case "toolStripButtonPrint":
          break;

        default:
          toolStripButtonNew.Enabled = true;
          toolStripButtonSearch.Enabled = true;
          toolStripButtonUndo.Enabled = false;
          toolStripButtonAdd.Enabled = false;
          toolStripButtonEdit.Enabled = false;
          toolStripButtonDelete.Enabled = false;
          toolStripButtonPrint.Enabled = false;
          break;
      }

      EnableDisableControls(clickedItem);
    }

    private void EnableDisableControls(ToolStripItem toolBarState)
    {
      bool habilitar = toolBarState.Name != toolStripButtonUndo.Name;
    }
  }
}

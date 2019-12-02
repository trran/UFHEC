using ControllerRTM;
using ControllerRTM.Controller;
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
  public partial class FormCliente : Form
  {
    private readonly ClienteController controller = new ClienteController(CurrentUserInfo.Username);
    private int clienteId;
    
    public FormCliente()
    {
      InitializeComponent();
      toolStrip1_ItemClicked(null, new ToolStripItemClickedEventArgs(toolStripButtonUndo));
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
          clickedItem = toolStripButtonUndo;
          break;

        case "toolStripButtonPrint":
          clickedItem = toolStripButtonUndo;
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

      textBoxNombre.Enabled = habilitar;
      metroComboBoxTipoDocumento.Enabled = habilitar;      
      textBoxDocumento.Enabled = habilitar;
      textBoxTelefono.Enabled = habilitar;
      textBoxEmail.Enabled = habilitar;
      textBoxAddress.Enabled = habilitar;
      metroCheckBoxEstatus.Enabled = habilitar;
    }

    private void clearControls()
    {
      clienteId = 0;
      textBoxNombre.Clear();
      metroComboBoxTipoDocumento.SelectedItem = null;
      textBoxDocumento.Clear();
      textBoxEmail.Clear();
      textBoxTelefono.Clear();
      textBoxAddress.Clear();
      metroCheckBoxEstatus.Checked = true;
    }

    public bool SaveEntity()
    {
      bool result = true;
      try
      {
        result = controller.SaveEntity();

        if (result)
        {
          EnableDisableControls(toolStripButtonUndo);
          ScatterEntityValues();
        }
      }
      catch (Exception)
      {
        result = false;
      }

      return result;
    }

    public bool DeleteEntity(params object[] ids)
    {
      return controller.DeleteEntity(ids);
    }

    public bool SearchEntity(params object[] ids)
    {
      return controller.SearchEntity(ids);
    }

    public void AddNewEntity()
    {
      controller.AddNewEntity();
    }

    public void ScatterEntityValues()
    {
      controller.ScatterEntityValues();
      clienteId = controller.Id;
      textBoxNombre.Text = controller.Nombre;
      metroComboBoxTipoDocumento.SelectedItem = controller.DocumentType;
      textBoxDocumento.Text = controller.DocumentNo;
      textBoxTelefono.Text = controller.Telefono;
      textBoxEmail.Text = controller.Email;
      textBoxAddress.Text = controller.Direccion;
      metroCheckBoxEstatus.Checked = controller.Estatus;
    }

    public void GattherEntityValues()
    {
      controller.Id = clienteId;
      controller.Nombre = textBoxNombre.Text;
      controller.DocumentType = metroComboBoxTipoDocumento.SelectedItem.ToString();
      controller.DocumentNo = textBoxDocumento.Text;
      controller.Telefono = textBoxTelefono.Text;
      controller.Email = textBoxEmail.Text;
      controller.Direccion = textBoxAddress.Text;
      controller.Estatus = metroCheckBoxEstatus.Checked;
      controller.GattherEntityValues();
    }

    public DataTable LoadDataTable(string criteria)
    {
      throw new NotImplementedException();
    }

    private void toolStripButtonSearch_Click(object sender, EventArgs e)
    {
      FormGenericSearch formSearch = new FormGenericSearch(controller);
      formSearch.TopLevel = true;
      formSearch.FormClosed += (oSender, oE) =>
      {
        if (formSearch.DialogResult == System.Windows.Forms.DialogResult.OK && SearchEntity(formSearch.Id))
        {
          ScatterEntityValues();
        }
      };

      formSearch.Show();
    }

    private void toolStripButtonNew_Click(object sender, EventArgs e)
    {
      AddNewEntity();
      clearControls();
    }

    private void toolStripButtonAdd_Click(object sender, EventArgs e)
    {
      string msg = string.Empty;
      GattherEntityValues();

      msg = SaveEntity() ? "Completado!" : "Algo anda mal!";

      MessageBox.Show(msg);
    }

    private void toolStripButtonUndo_Click(object sender, EventArgs e)
    {
      ScatterEntityValues();
    }

    private void toolStripButtonEdit_Click(object sender, EventArgs e)
    {

    }

    private void toolStripButtonDelete_Click(object sender, EventArgs e)
    {

    }
  }
}

using ControllerRTM;
using ControllerRTM.Controller;
using ControllerRTM.Interfaces;
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
  public partial class FormOrder : Form, IController
  {
    private readonly OrdenesController ordenesController = new OrdenesController(CurrentUserInfo.Username);
    private readonly ClienteController clienteController = new ClienteController(CurrentUserInfo.Username);
    private readonly ProductoController productoController = new ProductoController(CurrentUserInfo.Username);
    private int clienteId;
    private int ordenId;
    public FormOrder()
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
      buttonBuscarCliente.Enabled = habilitar;
      buttonAgregar.Enabled = habilitar;
      buttonEliminar.Enabled = habilitar;
      buttonLimpiar.Enabled = habilitar;
      numericUpDownCantidad.Enabled = habilitar;
      listViewDetails.Enabled = habilitar;
      buttonBuscarProducto.Enabled = habilitar;
    }

    private void buttonBuscarCliente_Click(object sender, EventArgs e)
    {
      FormGenericSearch formSearchCliente = new FormGenericSearch(clienteController);
      formSearchCliente.TopLevel = true;
      formSearchCliente.FormClosed += (oSender, oE) =>
      {
        if (formSearchCliente.DialogResult == System.Windows.Forms.DialogResult.OK)
        {
          clienteId = formSearchCliente.Id;
          MessageBox.Show("Cliente");
        }
      };

      formSearchCliente.Show();
    }

    private void toolStripButtonSearch_Click(object sender, EventArgs e)
    {
      FormGenericSearch formSearchOrden = new FormGenericSearch(ordenesController);
      formSearchOrden.TopLevel = true;
      formSearchOrden.FormClosed += (oSender, oE) =>
      {
        if (formSearchOrden.DialogResult == System.Windows.Forms.DialogResult.OK && SearchEntity(formSearchOrden.Id))
        {
          ScatterEntityValues();
        }
      };

      formSearchOrden.Show();
    }

    public bool SaveEntity()
    {
      bool result = true;
      try
      {
        result = ordenesController.SaveEntity();

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
      return ordenesController.DeleteEntity(ids);
    }

    public bool SearchEntity(params object[] ids)
    {
      return ordenesController.SearchEntity(ids);
    }

    public void AddNewEntity()
    {
      throw new NotImplementedException();
    }

    public void ScatterEntityValues()
    {
      ordenesController.ScatterEntityValues();
      ordenId = ordenesController.IdOrden;
      clienteId = ordenesController.ClienteId;
      textBoxClienteNombre.Text = ordenesController.ClienteNombre;
      textBoxTelefono.Text = ordenesController.Telefono;
      textBoxEmail.Text= ordenesController.Email;
      textBoxDireccion.Text = ordenesController.Direccion;
      numericUpDownSubtotal.Value = ordenesController.SubTotal;
      numericUpDownItbis.Value = ordenesController.ITBIS;
      numericUpDownTotal.Value = ordenesController.Total;
    }

    public void GattherEntityValues()
    {
      ordenesController.IdOrden = ordenId;
      ordenesController.ClienteId = clienteId;
      ordenesController.ClienteNombre = textBoxClienteNombre.Text;
      ordenesController.Telefono = textBoxTelefono.Text;
      ordenesController.Email = textBoxEmail.Text;
      ordenesController.Direccion = textBoxDireccion.Text;
      ordenesController.GattherEntityValues();
      //numericUpDownSubtotal.Value = ordenesController.SubTotal;
      //numericUpDownItbis.Value = ordenesController.ITBIS;
      //numericUpDownTotal.Value = ordenesController.Total;
    }

    public DataTable LoadDataTable(string criteria)
    {
      throw new NotImplementedException();
    }

    private void fillListViewDetails()
    { 

    }

    private void buttonBuscarProducto_Click(object sender, EventArgs e)
    {
      FormGenericSearch formSearchPorducto = new FormGenericSearch(productoController);
      formSearchPorducto.TopLevel = true;
      formSearchPorducto.FormClosed += (oSender, oE) =>
      {
        if (formSearchPorducto.DialogResult == System.Windows.Forms.DialogResult.OK && SearchEntity(formSearchPorducto.Id))
        {
          MessageBox.Show("Producto");
        }
      };

      formSearchPorducto.Show();
    }
  }
}

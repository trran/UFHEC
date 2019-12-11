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
  public partial class FormOrder : Form, IController
  {
    private readonly OrdenesController ordenesController = new OrdenesController(CurrentUserInfo.Username);
    private readonly ClienteController clienteController = new ClienteController(CurrentUserInfo.Username);
    private readonly ProductoController productoController = new ProductoController(CurrentUserInfo.Username);
    private readonly OrdenesDetalleController ordenesDetalleController;
    private int clienteId;
    private int ordenId;
    private int idProducto;
    private decimal productoPrecio;
    private string documentType;
    private string documentNo;

    public FormOrder()
    {
      InitializeComponent();
      ordenesDetalleController = new OrdenesDetalleController(ordenesController, CurrentUserInfo.Username);
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
      bool habilitaDetalle = !habilitar && ordenesController.IdOrden > 0;
      buttonBuscarCliente.Enabled = habilitar;
      metroCheckBoxLlevaITBIS.Enabled = habilitar;

      buttonAgregar.Enabled = habilitaDetalle;
      buttonEliminar.Enabled = habilitaDetalle;
      buttonLimpiar.Enabled = habilitaDetalle;
      numericUpDownCantidad.Enabled = habilitaDetalle;
      listViewDetails.Enabled = habilitaDetalle;
      buttonBuscarProducto.Enabled = habilitaDetalle;
    }

    private void buttonBuscarCliente_Click(object sender, EventArgs e)
    {
      FormGenericSearch formSearchCliente = new FormGenericSearch(clienteController);
      formSearchCliente.TopLevel = true;
      formSearchCliente.FormClosed += (oSender, oE) =>
      {
        if (formSearchCliente.DialogResult == System.Windows.Forms.DialogResult.OK && clienteController.SearchEntity(formSearchCliente.Id))
        {
          clienteController.ScatterEntityValues();
          clienteId = clienteController.Id;
          documentType = clienteController.DocumentType;
          documentNo = clienteController.DocumentNo;
          textBoxClienteNombre.Text = clienteController.Nombre;
          textBoxTelefono.Text = clienteController.Telefono;
          textBoxEmail.Text = clienteController.Email;
          textBoxDireccion.Text = clienteController.Direccion;
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
          EnableDisableControls(toolStripButtonUndo);
          
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
      ordenesController.AddNewEntity();
      ordenesDetalleController.AddNewEntity();

    }

    public void ScatterEntityValues()
    {
      ordenesController.ScatterEntityValues();
      ordenId = ordenesController.IdOrden;
      clienteId = ordenesController.ClienteId;
      documentType = ordenesController.DocumentType;
      documentNo = ordenesController.Documento;
      textBoxClienteNombre.Text = ordenesController.ClienteNombre;
      metroCheckBoxLlevaITBIS.Checked = ordenesController.LlevaITBIS;
      textBoxTelefono.Text = ordenesController.Telefono;
      textBoxEmail.Text= ordenesController.Email;
      textBoxDireccion.Text = ordenesController.Direccion;
      numericUpDownSubtotal.Value = ordenesController.SubTotal;
      numericUpDownItbis.Value = ordenesController.ITBIS;
      numericUpDownTotal.Value = ordenesController.Total;
      fillListViewDetails();
    }

    public void GattherEntityValues()
    {
      ordenesController.IdOrden = ordenId;
      ordenesController.ClienteId = clienteId;
      ordenesController.ClienteNombre = textBoxClienteNombre.Text;
      ordenesController.DocumentType = documentType;
      ordenesController.Documento = documentNo;
      ordenesController.Telefono = textBoxTelefono.Text;
      ordenesController.Email = textBoxEmail.Text;
      ordenesController.Direccion = textBoxDireccion.Text;
      ordenesController.LlevaITBIS = metroCheckBoxLlevaITBIS.Checked;
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
      listViewDetails.Items.Clear();
      bool color = false;
      foreach (DataRow dr in ordenesDetalleController.FillListViewDetails().Rows)
      {
        ListViewItem lvi = new ListViewItem(dr["Id"].ToString());
        lvi.BackColor = color ? Color.WhiteSmoke : Color.Transparent;
        lvi.SubItems.Add(dr["ProductoNombre"].ToString());
        lvi.SubItems.Add(dr["Cantidad"].ToString());
        lvi.SubItems.Add(dr["Precio"].ToString());
        lvi.SubItems.Add(dr["Total"].ToString());
        listViewDetails.Items.Add(lvi);
        color = !color;
      }
    }

    private void buttonBuscarProducto_Click(object sender, EventArgs e)
    {
      FormGenericSearch formSearchPorducto = new FormGenericSearch(productoController);
      formSearchPorducto.TopLevel = true;
      formSearchPorducto.FormClosed += (oSender, oE) =>
      {
        if (formSearchPorducto.DialogResult == System.Windows.Forms.DialogResult.OK && productoController.SearchEntity(formSearchPorducto.Id))
        {
          productoController.ScatterEntityValues();
          idProducto = productoController.Id;
          textBoxProductoDescripcion.Text = productoController.Nombre;
          numericUpDownCantidad.Maximum = productoController.Qty;
          productoPrecio = productoController.Precio;
        }
      };

      formSearchPorducto.Show();
    }

    private void toolStripButtonNew_Click(object sender, EventArgs e)
    {
      AddNewEntity();
      clearControls();
    }
    public void clearControls()
    {
      ordenId = 0;
      clienteId = 0;
      documentType = string.Empty;
      documentNo = string.Empty;
      textBoxClienteNombre.Clear();
      metroCheckBoxLlevaITBIS.Checked = true;
      textBoxTelefono.Clear();
      textBoxEmail.Clear();
      textBoxDireccion.Clear();
      numericUpDownSubtotal.Value = 0;
      numericUpDownItbis.Value = 0;
      numericUpDownTotal.Value = 0;
      listViewDetails.Items.Clear();
      ordenesController.SubTotal = 0;
      ordenesController.ITBIS = 0;
      ordenesController.Total = 0;

      buttonLimpiar_Click(null, null);
    }

    private void toolStripButtonDelete_Click(object sender, EventArgs e)
    {
      if (DeleteEntity(ordenId))
      {
        ScatterEntityValues();
      }
    }

    private void buttonLimpiar_Click(object sender, EventArgs e)
    {
      idProducto = 0;
      productoPrecio = 0;
      textBoxProductoDescripcion.Clear();
      numericUpDownCantidad.Value = 0;
      numericUpDownCantidad.Maximum = 99999999;
    }

    private void toolStripButtonUndo_Click(object sender, EventArgs e)
    {
      ScatterEntityValues();
    }

    private void toolStripButtonAdd_Click(object sender, EventArgs e)
    {
      string msg = string.Empty;
      GattherEntityValues();

      msg = SaveEntity() ? "Completado!" : "Algo anda mal!";
      MessageBox.Show(msg);
      EnableDisableControls(toolStripButtonUndo);
    }

    private void buttonAgregar_Click(object sender, EventArgs e)
    {
      try
      {
        ordenesDetalleController.Id = 0;
        ordenesDetalleController.ProductoId = idProducto;
        ordenesDetalleController.ProductoNombre = textBoxProductoDescripcion.Text;
        ordenesDetalleController.Cantidad = (int)numericUpDownCantidad.Value;
        ordenesDetalleController.Precio = productoPrecio;
        ordenesDetalleController.SaveEntity();
        buttonLimpiar_Click(null, null);
        fillListViewDetails();
        ScatterEntityValues();

      }
      catch (Exception ex)
      {
        MessageBox.Show("Ha ocurrido una excepcion: " + ex.Message);
      }
    }

    private void buttonEliminar_Click(object sender, EventArgs e)
    {
      fillListViewDetails();
    }

    private void toolStripButtonPrint_Click(object sender, EventArgs e)
    {
      if (ordenesController.IdOrden > 0)
      {
        DataSet ds = ordenesController.LoadInvoiceData();
        ReportDocument reportDocument = new ReportDocument();
        reportDocument.Load(@"../../Reports/InvoiceReport.rpt");

        if (string.IsNullOrEmpty(string.Empty))
        {
          reportDocument.SetDataSource(ds);
        }
        else
        {
        //  _dataBinds.TableName = _tableName;
          //reportDocument.SetDataSource(_dataBinds);
        }

        //reportDocument.PrintToPrinter(2, false, 1, 1);
        /*
        FormReportViewer formReport = new FormReportViewer();
        formReport.StartPosition = FormStartPosition.CenterScreen;
        formReport.WindowState = FormWindowState.Maximized;
        formReport.Show();
        formReport.RefreshReport();
         * */
      }
      EnableDisableControls(toolStripButtonUndo);
    }
  }
}

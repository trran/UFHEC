using BusinessObjectsRTM;
using ControllerRTM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerRTM.Controller
{
  public class OrdenesDetalleController : IController
  {
    private readonly OrdenesController ordenesController;
    private readonly string _currentUsername;
    private OrdenDetalle ordenDetalle;

    public int Id { get; set; }
    public int ProductoId { get; set; }
    public string ProductoNombre { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }

    private OrdenesDetalleController()
    {

    }
    public OrdenesDetalleController(OrdenesController ordenesController, string currentUsername)
    {
      this.ordenesController = ordenesController;
      _currentUsername = currentUsername;
      AddNewEntity();
    }

    public bool SaveEntity()
    {
      bool saved = false;
      try
      {
        AddNewEntity();
        GattherEntityValues();
        ordenDetalle.Save();
        saved = ordenDetalle.Id > 0;
  
          ordenesController.CalcularSubTotal();

      }
      catch (Exception)
      {
        saved = false;
      }

      return saved;
    }

    public bool DeleteEntity(params object[] ids)
    {
      bool deleted = false;

      try
      {
        AddNewEntity();
        if (deleted = SearchEntity(ids))
        {
          ordenDetalle.MarkAsDeleted();
          ordenDetalle.Save();
        }
      }
      catch (Exception)
      {
        deleted = false;
      }

      return deleted;
    }

    public bool SearchEntity(params object[] ids)
    {
      AddNewEntity();
      return ordenDetalle.LoadByPrimaryKey(Convert.ToInt32(ids[0]));
    }

    public void AddNewEntity()
    {
      ordenDetalle = new OrdenDetalle();
    }

    public void ScatterEntityValues()
    {
      Id = ordenDetalle.Id ?? 0;
      ProductoId = ordenDetalle.ProductoId ?? 0;
      ProductoNombre = ordenDetalle.ProductoNombre;
      Cantidad = ordenDetalle.Cantidad ?? 0;
      Precio = ordenDetalle.Precio ?? 0;
    }

    public void GattherEntityValues()
    {
      //ordenDetalle.Id = Id;
      ordenDetalle.OrdenId = ordenesController.IdOrden;
      ordenDetalle.ProductoId = ProductoId;
      ordenDetalle.ProductoNombre = ProductoNombre;
      ordenDetalle.Cantidad = Cantidad;
      ordenDetalle.Precio = Precio;
    }

    public System.Data.DataTable FillListViewDetails()
    {
      OrdenDetalleQuery q = new OrdenDetalleQuery();
      q.Where(q.OrdenId == ordenesController.IdOrden);

      return q.LoadDataTable();
    }

    public System.Data.DataTable LoadDataTable(string criteria)
    {
      OrdenDetalleQuery q = new OrdenDetalleQuery();
      q.SelectAll();
      //q.Where(q.ClienteNombre.Like("%" + criteria + "%") || q.DocumentNo.Like("%" + criteria + "%") || q.Telefono.Like("%" + criteria + "%") || q.ClienteDireccion.Like("%" + criteria + "%") || q.Email.Like("%" + criteria + "%"));

      return q.LoadDataTable();
    }
  }
}
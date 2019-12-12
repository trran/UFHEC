using BusinessObjectsRTM;
using ControllerRTM.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerRTM.Controller
{
  public class OrdenesController : IController
  {
    private readonly string _currentUsername;
    private Ordenes orden;
    public int IdOrden { get; set; }
    public int ClienteId { get; set; }
    public string ClienteNombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string DocumentType { get; set; }
    public string Documento { get; set; }
    public string Email { get; set; }
    public decimal SubTotal { get; set; }
    public bool LlevaITBIS { get; set; }
    public decimal ITBIS { get; set; }
    public decimal Total { get; set; }

    public OrdenesController(string currentUsername)
    {
      _currentUsername = currentUsername;
      AddNewEntity();
    }

    public bool SaveEntity()
    {
      bool saved = false;
      try
      {
        //GattherEntityValues();
        orden.Save();
        saved = orden.Id > 0;
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
          orden.MarkAsDeleted();
          orden.Save();
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
      return orden.LoadByPrimaryKey(Convert.ToInt32(ids[0]));
    }

    public void AddNewEntity()
    {
      orden = new Ordenes();
    }

    public void ScatterEntityValues()
    {
      IdOrden = orden.Id ?? 0;
      ClienteId = orden.ClienteId ?? 0;
      ClienteNombre = orden.ClienteNombre;
      DocumentType = orden.DocumentType;
      Documento = orden.DocumentNo;
      Direccion = orden.ClienteDireccion;
      Email = orden.Email;
      Telefono = orden.Telefono;
      SubTotal = orden.SubTotal ?? 0;
      LlevaITBIS = orden.LlevaITBIS ?? true;
      ITBIS = orden.Itbis ?? 0;
      Total = orden.Total ?? 0;
    }

    public void GattherEntityValues()
    {
      orden.Id = IdOrden;
      orden.ClienteId = ClienteId;
      orden.ClienteNombre = ClienteNombre;
      orden.DocumentType = DocumentType;
      orden.DocumentNo = Documento;
      orden.ClienteDireccion = Direccion;
      orden.Email = Email;
      orden.Telefono = Telefono;
      orden.SubTotal = SubTotal;
      orden.LlevaITBIS = LlevaITBIS;
      orden.UsuarioId = CurrentUserInfo.Id;
    }

    public System.Data.DataTable LoadDataTable(string criteria)
    {
      OrdenesQuery q = new OrdenesQuery();
      q.SelectAll();
      q.Where(q.ClienteNombre.Like("%" + criteria + "%") || q.DocumentNo.Like("%" + criteria + "%") || q.Telefono.Like("%" + criteria + "%") || q.ClienteDireccion.Like("%" + criteria + "%") || q.Email.Like("%" + criteria + "%"));

      return q.LoadDataTable();
    }

    public void CalcularSubTotal()
    {
      orden.OrdenDetalleCollectionByOrdenId = null;
      orden.SubTotal = orden.OrdenDetalleCollectionByOrdenId.Sum(a => a.Total);
      orden.Save();
    }

    public DataSet LoadInvoiceData()
    {
      DataSet ds = new DataSet();
      OrdenesQuery orden = new OrdenesQuery();
      OrdenDetalleQuery ordenDetalle = new OrdenDetalleQuery();
      
      orden.Where(orden.Id == IdOrden);
      ds.Tables.Add(orden.LoadDataTable());
      ordenDetalle.Where(ordenDetalle.OrdenId == IdOrden);      
      ds.Tables.Add(ordenDetalle.LoadDataTable());
      ds.Tables[0].TableName = "Orden";
      ds.Tables[1].TableName = "OrdenDetalle";

      return ds;
    }
  }
}
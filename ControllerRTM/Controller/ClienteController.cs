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
  public class ClienteController : IController
  {
    private ClienteController()
    {

    }

    private Cliente cliente = new Cliente();
    private readonly string _currentUsername;
    public ClienteController(string currentUsername)
    {
      _currentUsername = currentUsername;
    }

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string DocumentType { get; set; }
    public string DocumentNo { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Direccion { get; set; }
    public bool Estatus { get; set; }

    public bool SaveEntity()
    {
      bool saved = true;
      try
      {
        cliente.Save();
        saved = cliente.Id > 0;
      }
      catch (Exception)
      {
        saved = false;
      }

      return saved;
    }

    public bool DeleteEntity(params object[] ids)
    {
      bool result = true;

      try
      {
        if (result = SearchEntity(ids))
        {
          cliente.MarkAsDeleted();
          cliente.Save();
        }
      }
      catch (Exception)
      {
        result = false;
      }

      return result;
    }

    public bool SearchEntity(params object[] ids)
    {
      AddNewEntity();
      return cliente.LoadByPrimaryKey(Convert.ToInt32(ids[0]));
    }

    public void AddNewEntity()
    {
      cliente = new Cliente();
    }

    public void ScatterEntityValues()
    {
      Id = cliente.Id ?? 0;
      Nombre = cliente.Nombre;
      DocumentType = cliente.DocumentType;
      DocumentNo = cliente.DocumentNo;
      Telefono = cliente.Telefono;
      Email = cliente.Email;
      Direccion = cliente.Direccion;
      Estatus = cliente.Estatus ?? true;
    }

    public void GattherEntityValues()
    {
      cliente.Id = Id;
      cliente.Nombre = Nombre;
      cliente.DocumentType = DocumentType;
      cliente.DocumentNo = DocumentNo;
      cliente.Telefono = Telefono;
      cliente.Email = Email;
      cliente.Direccion = Direccion;
      cliente.Estatus = Estatus;
    }

    public DataTable LoadDataTable(string criteria)
    {
      ClienteQuery q = new ClienteQuery();

      q.SelectAll();
      q.Where(q.Nombre.Like("%" + criteria + "%") || q.DocumentNo.Like("%" + criteria + "%") || q.Telefono.Like("%" + criteria + "%") || q.Email.Like("%" + criteria + "%"));

      return q.LoadDataTable();
    }

    public DataTable LoadDataUser()
    {
      throw new NotImplementedException("Contacta el programador");
    }
  }
}

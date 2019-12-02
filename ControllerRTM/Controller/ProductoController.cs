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
    public class ProductoController : IController
    {
        private ProductoController()
        {

        }

        private Productos producto = new Productos();
        private readonly string _currentUsername;
        public ProductoController(string currentUsername)
        {
            _currentUsername = currentUsername;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Itbis { get; set; }
        public string IdUnidad { get; set; }
        public decimal Qty { get; set; }
        public bool Estatus { get; set; }

        public bool SaveEntity()
        {
            bool saved = true;
            try
            {
                producto.Save();
                saved = producto.Id > 0;
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
                    producto.MarkAsDeleted();
                    producto.Save();
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
            return producto.LoadByPrimaryKey(Convert.ToInt32(ids[0]));
        }

        public void AddNewEntity()
        {
          producto = new Productos();
        }

        public void ScatterEntityValues()
        {
            Id = producto.Id ?? 0;
            Nombre = producto.Nombre;
            Precio = producto.Precio ?? 0;
            Itbis = producto.Itbis ?? 0;
            IdUnidad = producto.IdUnidad;
            Qty = producto.Qty ?? 0;
            Estatus = producto.Estatus ?? true;
        }

        public void GattherEntityValues()
        {
          producto.Id = Id;
          producto.Nombre = Nombre;
          producto.Precio = Precio;
          producto.Itbis = Itbis;
          producto.IdUnidad = IdUnidad;
          producto.Qty = Qty;
          producto.Estatus = Estatus;
        }

        public DataTable LoadDataTable(string criteria)
        {
          ProductosQuery q = new ProductosQuery();

            q.SelectAll();
            q.Where(q.Nombre.Like("%" + criteria + "%") || q.IdUnidad.Like("%" + criteria + "%"));

            return q.LoadDataTable();
        }

        public DataTable LoadDataUser()
        {
          throw new NotImplementedException("Contacta el programador");
        }
    }
}

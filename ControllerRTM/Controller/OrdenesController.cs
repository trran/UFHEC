using BusinessObjectsRTM;
using ControllerRTM.Interfaces;
using System;
using System.Collections.Generic;
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
        public int ConsignatarioId { get; set; }
        public string ConsignatarioNombre { get; set; }
        public string Direccion { get; set; }
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
                AddNewEntity();
                ScatterEntityValues();
                orden.Save();
                saved = orden.Id > 0;
            }
            catch (Exception)
            {
                saved = false;
            }
            
            return saved ;
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

        public bool SearchEntity(params object[] ids )
        {
            AddNewEntity();
            return orden.LoadByPrimaryKey(Convert.ToInt32(ids[0]));
        }

        public void AddNewEntity()
        {
            orden = new Ordenes();
            orden.Save();
        }

        public void ScatterEntityValues()
        {
            orden.Id = IdOrden;
            orden.IdConsignatario = ConsignatarioId;
            orden.NombreConsignatario = ConsignatarioNombre;
            orden.Direccion = Direccion;
            orden.Email = Email;
            orden.SubTotal = SubTotal;
            orden.LlevaITBIS = LlevaITBIS;
            orden.Itbis = ITBIS;
            orden.Total = Total;
        }

        public void GattherEntityValues()
        {
            IdOrden = orden.Id ?? 0;
            ConsignatarioId = orden.IdConsignatario ?? 0 ;
            ConsignatarioNombre = orden.NombreConsignatario;
            Direccion = orden.Direccion;
            Email = orden.Email;
            SubTotal = orden.SubTotal ?? 0;
            LlevaITBIS = orden.LlevaITBIS ?? true;
            ITBIS = orden.Itbis ?? 0;
            Total = orden.Total ?? 0;
        }


        public System.Data.DataTable LoadDataTable(string criteria)
        {
            throw new NotImplementedException();
        }
    }
}

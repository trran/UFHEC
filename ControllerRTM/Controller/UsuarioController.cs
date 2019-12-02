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
    public class UsuarioController : IController
    {
        private UsuarioController()
        {

        }
        private Usuario usuario = new Usuario();
        private readonly string _currentUsername;
        public UsuarioController(string currentUsername)
        {
            _currentUsername = currentUsername;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] Avatar { get; set; } 

        public bool SaveEntity()
        {
            bool saved = true;
            try
            {
                usuario.Save();
                saved = usuario.Id > 0;
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
                    usuario.MarkAsDeleted();
                    usuario.Save();
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
            return usuario.LoadByPrimaryKey(Convert.ToInt32(ids[0]));
        }

        public void AddNewEntity()
        {
          usuario = new Usuario();
        }

        public void ScatterEntityValues()
        {
            Id = usuario.Id ?? 0;
            FirstName = usuario.FirstName;
            LastName = usuario.LastName;
            BirthDate = usuario.BirthDate ?? DateTime.Now;
            Address = usuario.Address;
            City = usuario.City;
            ZipCode = usuario.ZipCode;
            Position = usuario.Position;
            Phone = usuario.Phone;
            Notes = usuario.Notes;
            Username = usuario.Username;
            Password = usuario.Password;
            Avatar = usuario.Avatar ;
        }

        public void GattherEntityValues()
        {
            usuario.Id = Id;
            usuario.FirstName = FirstName;
            usuario.LastName = LastName;
            usuario.BirthDate = BirthDate;
            usuario.Address = Address;
            usuario.City = City;
            usuario.ZipCode = ZipCode;
            usuario.Position = Position;
            usuario.Phone = Phone;
            usuario.Notes = Notes;
            usuario.Username = Username;
            usuario.Password = Password;
            usuario.Avatar = Avatar;
        }

        public DataTable LoadDataTable(string criteria)
        {
          UsuarioQuery q = new UsuarioQuery();

            q.SelectAll();
            q.Where(q.FirstName.Like("%" + criteria + "%") || q.LastName.Like("%" + criteria + "%") || q.Username.Like("%" + criteria + "%")
                || q.Position.Like("%" + criteria + "%") || q.Address.Like("%" + criteria + "%") || q.City.Like("%" + criteria + "%"));

            return q.LoadDataTable();
        }

        public DataTable LoadDataUser()
        {
          UsuarioQuery q = new UsuarioQuery();

          q.SelectAll();
          q.Where(q.Id == Id);

          return q.LoadDataTable();
        }
    }
}

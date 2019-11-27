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
    public class CustomerController : IController
    {
        private CustomerController()
        {

        }
        private Customer customer = new Customer();
        private readonly string _currentUsername;
        public CustomerController(string currentUsername)
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
                customer.Save();
                saved = customer.Id > 0;
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
                    customer.MarkAsDeleted();
                    customer.Save();
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
            return customer.LoadByPrimaryKey(Convert.ToInt32(ids[0]));
        }

        public void AddNewEntity()
        {
            customer = new Customer();
        }

        public void ScatterEntityValues()
        {
            Id = customer.Id ?? 0;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            BirthDate = customer.BirthDate ?? DateTime.Now;
            Address = customer.Address;
            City = customer.City;
            ZipCode = customer.ZipCode;
            Position = customer.Position;
            Phone = customer.Phone;
            Notes = customer.Notes;
            Username = customer.Username;
            Password = customer.Password;
            Avatar = customer.Avatar ;
        }

        public void GattherEntityValues()
        {
            customer.Id = Id;
            customer.FirstName = FirstName;
            customer.LastName = LastName;
            customer.BirthDate = BirthDate;
            customer.Address = Address;
            customer.City = City;
            customer.ZipCode = ZipCode;
            customer.Position = Position;
            customer.Phone = Phone;
            customer.Notes = Notes;
            customer.Username = Username;
            customer.Password = Password;
            customer.Avatar = Avatar;
        }

        public DataTable LoadDataTable(string criteria)
        {
            CustomerQuery q = new CustomerQuery();

            q.SelectAll();
            q.Where(q.FirstName.Like("%" + criteria + "%") || q.LastName.Like("%" + criteria + "%") || q.Username.Like("%" + criteria + "%")
                || q.Position.Like("%" + criteria + "%") || q.Address.Like("%" + criteria + "%") || q.City.Like("%" + criteria + "%"));

            return q.LoadDataTable();
        }

        public DataTable LoadDataUser()
        {
          CustomerQuery q = new CustomerQuery();

          q.SelectAll();
          q.Where(q.Id == Id);

          return q.LoadDataTable();
        }

    }
}

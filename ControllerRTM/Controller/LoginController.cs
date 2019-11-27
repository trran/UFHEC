using BusinessObjectsRTM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerRTM.Controller
{
  public class LoginController
  {
    public bool CantLogin(string userName, string password)
    {
      bool isValid = false;

      CustomerQuery entity = new CustomerQuery();
      entity.Select(entity.Id, entity.FirstName, entity.LastName, entity.Username);
      entity.Where(entity.Username != string.Empty && entity.Password != string.Empty && entity.Username == userName && entity.Password == password);
      entity.es.Top = 1;
      DataTable dt = entity.LoadDataTable();

      if (isValid = dt.Rows.Count > 0)
      {
        CurrentUserInfo.Id = Convert.ToInt32(dt.Rows[0][CustomerMetadata.ColumnNames.Id]);
        CurrentUserInfo.FirstName = dt.Rows[0][CustomerMetadata.ColumnNames.FirstName].ToString();
        CurrentUserInfo.LastName = dt.Rows[0][CustomerMetadata.ColumnNames.LastName].ToString();
        CurrentUserInfo.Username = dt.Rows[0][CustomerMetadata.ColumnNames.Username].ToString();
      }

      return isValid;
    }
  }
}

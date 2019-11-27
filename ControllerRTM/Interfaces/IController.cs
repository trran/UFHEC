using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerRTM.Interfaces
{
    public interface IController
    {
        bool SaveEntity();
        bool DeleteEntity(params object[] ids);
        bool SearchEntity(params object[] ids);
        void AddNewEntity();
        void ScatterEntityValues();
        void GattherEntityValues();

        DataTable LoadDataTable(string criteria);
    }
}

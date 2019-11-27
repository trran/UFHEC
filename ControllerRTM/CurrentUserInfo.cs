using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerRTM
{
    public static class CurrentUserInfo
    {
        public static int Id { get; set; }
        public static string Username { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string FullName { get { return FirstName + " " + LastName; } }
    }
}

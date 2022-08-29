using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Lib.Logic
{
    public static class ConnectionStringClass
    {
        public static string GetConnection()
        {
            return Properties.Settings1.Default.ConnectionString;
        }
        public static void SetConnection(string ConnectionString)
        {
            Properties.Settings1.Default.ConnectionString = ConnectionString;
            Properties.Settings1.Default.Save();
            Properties.Settings1.Default.Reload();
        }
    }
}

using Eslam_Managment_Project.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Logic.Services
{
    public static class Session
    {
        private static User _user;

        public static User user
        {
            get { return _user;  }
            set { _user = value; }
        }


    }
}

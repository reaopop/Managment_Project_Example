using Eslam_Managment_Project.Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Views.Interfaces
{
    public interface Ifrm_Drawers
    {
        string DrawerName { get; set; }
        BindingList<Drawer> Drawers {get;set;}
    }
}

using Eslam_Managment_Project.Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Views.Interfaces
{
    public interface Ifrm_Services
    {
        string Service_Name { get; set; }
        int CategoryID { get; set; }
        bool IsCredit { get; set; }
        BindingList<Service> Services { get; set; }
        object Categories { get; }
        bool ValidateData { get; }
    }
}

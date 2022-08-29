using Eslam_Managment_Project.Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Views.Interfaces
{
    public interface ifrm_Categories
    {
        string CategoryName { get; set; }
        BindingList<Category> Categories { get; set; }
        Image Logo { get; set; }
    }
}

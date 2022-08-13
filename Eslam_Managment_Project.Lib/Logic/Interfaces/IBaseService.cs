using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Lib.Logic.Interfaces
{
    public interface IBaseService<T>
    {
        T Entity { get; set; }

        Notification_Service.NotificationsType InsertOrUpdate();
        Notification_Service.NotificationsType Delete();
        List<T> SelectAll();
        T Select();
        
    }
}

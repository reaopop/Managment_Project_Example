using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Lib.Logic.Interfaces
{
    interface IUser_Service
    {
        Notification_Service.NotificationsType Login();
        Notification_Service.NotificationsType Resgister();
    }
}

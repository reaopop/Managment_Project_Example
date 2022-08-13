using Eslam_Managment_Project.Lib.Logic.Models;
using System.Collections.Generic;

namespace Eslam_Managment_Project.Lib.Logic
{
    public static class Notification_Service
    {
        public enum NotificationsType
        {
            add,
            edit,
            delete,
            canNotAdd,
            canNotEdit,
            canNotDelete,
            LoginSuccessed,
            LoginFailed,
            Error,
        }
        public static List<TypeSchemaClass<NotificationsType>> NotificationsTypeList
        {
            get
            {
                return new List<TypeSchemaClass<NotificationsType>>()
                {
                    new TypeSchemaClass<NotificationsType>(){id = (int)NotificationsType.add , contant = "Saved successfully" , title = "", type = NotificationsType.add},
                    new TypeSchemaClass<NotificationsType>(){id = (int)NotificationsType.edit , contant = "Edited successfully" , title = "", type = NotificationsType.edit},
                    new TypeSchemaClass<NotificationsType>(){id = (int)NotificationsType.delete , contant = "Deleted successfully" , title = "", type = NotificationsType.delete},
                    new TypeSchemaClass<NotificationsType>(){id = (int)NotificationsType.canNotAdd , contant = "Save failed" , title = "", type = NotificationsType.canNotAdd},
                    new TypeSchemaClass<NotificationsType>(){id = (int)NotificationsType.canNotEdit , contant = "Edit failed"  , title = "", type = NotificationsType.canNotEdit},
                    new TypeSchemaClass<NotificationsType>(){id = (int)NotificationsType.canNotDelete , contant = "Delete failed"  , title = "", type = NotificationsType.canNotDelete},
                    new TypeSchemaClass<NotificationsType>(){id = (int)NotificationsType.Error , contant = "An unexpected error occurred"  , title = "", type = NotificationsType.Error},
                    new TypeSchemaClass<NotificationsType>(){id = (int)NotificationsType.LoginSuccessed , contant = "Login succeeded"  , title = "", type = NotificationsType.LoginSuccessed},
                    new TypeSchemaClass<NotificationsType>(){id = (int)NotificationsType.LoginFailed , contant = "The username or password is incorrect"  , title = "Login failed", type = NotificationsType.LoginFailed},
                };
            }
        }
    }
}

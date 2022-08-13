using Eslam_Managment_Project.Lib.Logic;
using Eslam_Managment_Project.Lib.Logic.Interfaces;
using Eslam_Managment_Project.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Lib.Services
{
    public class User_Service : IBaseService<User> , IUser_Service
    {
        public User Entity { get ; set ; }
        EslamDbContext db;

        public User_Service(User entity)
        {
            db = new EslamDbContext();
            Entity = entity;
        }

        public Notification_Service.NotificationsType Delete()
        {
            try
            {
                db.Users.Remove(Entity);
                db.SaveChanges();
                return Notification_Service.NotificationsType.delete;
            }
            catch (Exception)
            {
                return Notification_Service.NotificationsType.Error;
            }
        }

        public Notification_Service.NotificationsType InsertOrUpdate()
        {
            try
            {
                Notification_Service.NotificationsType result;
                if (Entity.id == 0)
                {
                    db.Users.Add(Entity);
                    result = Notification_Service.NotificationsType.add;
                }
                else
                {
                    db.Users.Attach(Entity);
                    result = Notification_Service.NotificationsType.edit;
                }
                db.SaveChanges();
                return result;
            }
            catch (Exception)
            {
                return Notification_Service.NotificationsType.Error;
            }
        }

        public Notification_Service.NotificationsType Login()
        {
            throw new NotImplementedException();
        }

        public Notification_Service.NotificationsType Resgister()
        {
            throw new NotImplementedException();
        }

        public User Select()
        {
            throw new NotImplementedException();
        }

        public List<User> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}

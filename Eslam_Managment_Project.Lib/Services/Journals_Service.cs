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
    public class Journals_Service : IBaseService<Journal>
    {
        public Journal Entity { get; set; }
        public List<Journal> Entities { get; set; }
        public EslamDbContext db;

        public Journals_Service(Journal entity)
        {
            db = new EslamDbContext();
            Entity = entity;
        }

        public Notification_Service.NotificationsType Delete()
        {
            try
            {
                db.Journals.Remove(Entity);
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
                    db.Journals.Add(Entity);
                    result = Notification_Service.NotificationsType.add;
                }
                else
                {
                    db.Journals.Attach(Entity);
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
        public void InsertOrUpdateRange()
        {
            foreach (var item in Entities)
            {
                Entity = item;
                InsertOrUpdate();
            }
        }
        public Journal Select()
        {
            return db.Journals.FirstOrDefault(x => x.id == Entity.id);
        }

        public List<Journal> SelectAll()
        {
            return db.Journals.ToList();
        }
    }
}

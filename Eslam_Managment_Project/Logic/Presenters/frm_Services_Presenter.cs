using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Model;
using Eslam_Managment_Project.Logic.Services;
using Eslam_Managment_Project.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Logic.Presenters
{
    public class frm_Services_Presenter : IBasePresenter<Service>
    {
        private readonly Ifrm_Services repo;
        EslamDbContext db;
        public Service Entity { get; set; }

        public frm_Services_Presenter(Ifrm_Services Repo)
        {
            repo = Repo;
            db = new EslamDbContext();
            New();
        }

        public void Delete()
        {
            EslamDbContext dbs = new EslamDbContext();
            if (dbs.ServiceLogs.Where(x => x.drawer_id == Entity.id).Count() == 0)
            {
                if (XtraMessageBox.Show(text: "The Category will be deleted ?", caption: "Delete", buttons: System.Windows.Forms.MessageBoxButtons.YesNo, icon: System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    db.Services.Remove(Entity);
                    db.SaveChanges();
                    New();
                }
            }
        }

        public void InsertOrUpdate()
        {
            try
            {
                if (repo.ValidateData)
                {
                    if (Entity.id == 0)
                    {
                        db.Services.Add(Entity);
                    }
                    else
                    {
                        try { db.Services.Attach(Entity); } catch { }
                    }
                    SetData();
                    db.SaveChanges();
                    New();
                    Notification.RunAlert(Title: "", Documentation: "", type: Notification.alertType.Success);
                }
            }
            catch (Exception)
            {

            }
        }

        public void New()
        {
            Entity = new Service()
            {
                service_name = repo.Service_Name,
                category_id =  repo.CategoryID,
                AccountID = 0,
                IsCredit = repo.IsCredit
            };
            GetData();
            ValidateData();
        }

        public Drawer Select()
        {
            return db.Drawers.FirstOrDefault(x => x.id == Entity.id);
        }

        public void ValidateData()
        {
            repo.Services = new BindingList<Service>(db.Services.ToList());
             var d = repo.Categories;
        }

        public void GetData()
        {
            repo.Service_Name = Entity.service_name;
            repo.CategoryID = Entity.category_id;
            repo.IsCredit = Entity.IsCredit;
            
        }

        public void SetData()
        {
            Entity.service_name = repo.Service_Name;
            Entity.category_id = repo.CategoryID;
            Entity.IsCredit = repo.IsCredit;
        }
    }
}

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
    public class frm_Drawers_Presenter : IBasePresenter<Drawer>
    {
        private readonly Ifrm_Drawers repo;
        EslamDbContext db;
        public Drawer Entity { get ; set ; }

        public frm_Drawers_Presenter(Ifrm_Drawers Repo)
        {
            repo = Repo;
            db = new EslamDbContext();
            New();
        }

        public void Delete()
        {
            EslamDbContext dbs = new EslamDbContext();
            if(dbs.ServiceLogs.Where(x=> x.drawer_id == Entity.id).Count() == 0)
            {
                if(XtraMessageBox.Show(text: "The treasury will be deleted ?", caption:"Delete",buttons:System.Windows.Forms.MessageBoxButtons.YesNo , icon:System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    db.Drawers.Remove(Entity);
                    db.SaveChanges();
                    New();
                }
            }
        }

        public void InsertOrUpdate()
        {
            try
            {
                if(Entity.id == 0)
                {
                    db.Drawers.Add(Entity);
                }
                else
                {
                    try{db.Drawers.Attach(Entity);}catch {}
                }
                SetData();
                db.SaveChanges();
                New();
                Notification.RunAlert(Title: "", Documentation: "", type: Notification.alertType.Success);
            }
            catch (Exception)
            {

            }
        }

        public void New()
        {
            Entity = new Drawer()
            {
                drawer_name = repo.DrawerName
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
            repo.Drawers = new BindingList<Drawer>( db.Drawers.ToList());
        }

        public void GetData()
        {
            repo.DrawerName = Entity.drawer_name;
        }

        public void SetData()
        {
            Entity.drawer_name = repo.DrawerName;
        }
    }
}

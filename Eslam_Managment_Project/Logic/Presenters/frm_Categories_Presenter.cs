using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Model;
using Eslam_Managment_Project.Logic.Services;
using Eslam_Managment_Project.Views.Forms;
using Eslam_Managment_Project.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Logic.Presenters
{
    public class frm_Categories_Presenter : IBasePresenter<Category>
    {
        private readonly ifrm_Categories repo;
        public Category Entity { get; set; }

        public frm_Categories_Presenter(ifrm_Categories Repo)
        {
            repo = Repo;
            New();
        }

        public void Delete()
        {
            using (EslamDbContext dbs = new EslamDbContext())
            {
                if (dbs.Services.Where(x => x.category_id == Entity.id).Count() == 0)
                {
                    if (XtraMessageBox.Show(text: "The Category will be deleted ?", caption: "Delete", buttons: System.Windows.Forms.MessageBoxButtons.YesNo, icon: System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        dbs.Categories.Remove(Entity);
                        dbs.SaveChanges();
                        New();
                    }
                }
            }
        }

        public void InsertOrUpdate()
        {
            try
            {
                using (EslamDbContext db = new EslamDbContext())
                {
                    if (Entity.id == 0)
                    {
                        db.Categories.Add(Entity);
                    }
                    else
                    {
                        try { db.Categories.Attach(Entity); } catch { }
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
            Entity = new Category()
            {
                category_name = repo.CategoryName
            };
            GetData();
            ValidateData();
        }

        public Drawer Select()
        {
            using (EslamDbContext db = new EslamDbContext())
            {
                return db.Drawers.FirstOrDefault(x => x.id == Entity.id);
            }
        }

        public void ValidateData()
        {
            using (EslamDbContext db = new EslamDbContext())
            {
                repo.Categories = new BindingList<Category>(db.Categories.ToList());
            }
        }

        public void GetData()
        {
            repo.CategoryName = Entity.category_name;
            if (Entity.Logo != null)
            repo.Logo = Session.GetImage(Entity.Logo.ToArray());
        }

        public void SetData()
        {
            Entity.category_name = repo.CategoryName;
            Entity.Logo = Session.SetImage(repo.Logo);
        }
    }
}

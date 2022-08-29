using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Model;
using Eslam_Managment_Project.Logic.Services;
using Eslam_Managment_Project.Views.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eslam_Managment_Project.Views.Forms
{
    public partial class frm_Balance : DevExpress.XtraEditors.XtraForm
    {
        ServiceLog serviceLog;
        EslamDbContext db;
        private static frm_Balance _frm;
        public static frm_Balance frm
        {
            get
            {
                if (_frm == null) _frm = new frm_Balance();
                return _frm;
            }
            set { _frm = value; }
        }
        public frm_Balance()
        {
            InitializeComponent();
            this.FormClosed += Frm_Balance_FormClosed;
            db = new EslamDbContext();
            lkp_CategoryID.FillData(db.Categories.Select(x=>new { x.id , x.category_name}).ToList(), true, nameof(Category.id), nameof(Category.category_name));
            lkp_Drawer.FillData(db.Drawers.Select(x => new { x.id, x.drawer_name }).ToList(), true, nameof(Drawer.id), nameof(Drawer.drawer_name));
            lkp_ServiceID.FillData(db.Services.Select(x => new { x.id, x.service_name }).ToList(), true, nameof(Service.id), nameof(Service.service_name));
            lkp_Drawer.EditValue = db.Drawers.FirstOrDefault()?.id??0;

            var categories = db.Categories;

            lbl_Balance.Text = (db.ServiceLogs?.Sum(x => (double?)x.amount) ?? 0).ToString() + " LE";
            foreach (var item in categories)
            {
                usr_CategoryCard usr = new usr_CategoryCard(item);
                usr.categoryID = item.id;
                usr.CategoryName = item.category_name;
                if(item.Logo != null)
                usr.Logo = Session.GetImage( item.Logo.ToArray());
                flowLayoutPanel1.Controls.Add(usr);
                usr.AddClick += (sender, e) => 
                {
                    lkp_ServiceID.FillData(db.Services.Where(x=> x.category_id == usr.categoryID).Select(x => new { x.id, x.service_name }).ToList(), true, nameof(Service.id), nameof(Service.service_name));
                    lkp_ServiceID.EditValue = db.Services.FirstOrDefault(x => x.category_id == usr.categoryID)?.id??0;
                    lkp_CategoryID.EditValue = usr.categoryID;
                    serviceLog = new ServiceLog()
                    {
                        date = DateTime.Now,
                    };
                    flyoutPanel1.ShowPopup();
                };
                usr.ResetClick += (sender, e) =>
                 {

                 };
            }
        }

       

        private void Frm_Balance_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                db = new EslamDbContext();
                serviceLog.drawer_id = Convert.ToInt32(lkp_Drawer.EditValue);
                serviceLog.service_id = Convert.ToInt32(lkp_ServiceID.EditValue);
                serviceLog.note = memoEdit1.Text.Trim() == string.Empty ? "_" : memoEdit1.Text.Trim();
                var Service = db.Services.FirstOrDefault(x => x.id == serviceLog.service_id);
                serviceLog.amount = sp_Amount.Value -  (sp_Amount.Value == 0 || Service.IsCredit ? 0 : (sp_Amount.Value * 2));
                serviceLog.IsIn = Service.IsCredit;
                db.ServiceLogs.Add(serviceLog);
                db.SaveChanges();
                lbl_Balance.Text = (db.ServiceLogs?.Sum(x => (double?)x.amount) ?? 0).ToString() + " LE";

                Notification.RunAlert("تم الحفظ بنجاح", "", Notification.alertType.Success);
                flyoutPanel1.HidePopup();
            }
        }
        bool ValidateData()
        {
            int CheckExceptions = 0;
            CheckExceptions += lkp_Drawer.CheckEmptyLKP() ? 0 : 1;
            CheckExceptions += lkp_ServiceID.CheckEmptyLKP() ? 0 : 1;
            CheckExceptions += lkp_CategoryID.CheckEmptyLKP() ? 0 : 1;

            return CheckExceptions == 0;
        }
    }
}
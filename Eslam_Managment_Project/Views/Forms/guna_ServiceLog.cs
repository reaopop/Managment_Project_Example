using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Model;
using Eslam_Managment_Project.Logic.Services;
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
    public partial class guna_ServiceLog : DevExpress.XtraEditors.XtraForm
    {
        ServiceLog serviceLog;
        int categoryID;
        public guna_ServiceLog(int CategoryID)
        {
            InitializeComponent();
            serviceLog = new ServiceLog();
            btn_Save.Click += btn_Save_Click;
            categoryID = CategoryID;
            lkp_ServiceID.ProcessNewValue += Lkp_ServiceID_ProcessNewValue; ;
            using (EslamDbContext db = new EslamDbContext())
            {

                lkp_ServiceID.FillData(db.Services.Where(x => x.category_id == CategoryID).Select(x => new { x.id, x.service_name }).ToList(), true, nameof(Service.id), nameof(Service.service_name));
                if (db.Services.Where(x => x.category_id == categoryID).Count() > 0)
                    lkp_ServiceID.EditValue = db.Services.FirstOrDefault(x => x.category_id == CategoryID)?.id ?? 0;
            }
        }

        private void Lkp_ServiceID_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue is string vv && vv.Trim() != string.Empty)
            {
                string serviceName = lkp_ServiceID.Text.Trim();
                using (EslamDbContext db = new EslamDbContext())
                {
                    if (serviceName != string.Empty && db.Services.Where(x => x.service_name == serviceName).Count() == 0)
                    {
                        Service Service = new Service() { category_id = categoryID, AccountID = 0, IsCredit = tog_IsCredit.IsOn, service_name = serviceName };
                        db.Services.Add(Service);
                        db.SaveChanges();
                        lkp_ServiceID.FillData(db.Services.Where(x => x.category_id == categoryID).Select(x => new { x.id, x.service_name }).ToList(), true, nameof(Service.id), nameof(Service.service_name));
                        lkp_ServiceID.EditValue = db.Services.FirstOrDefault(x => x.id == Service.id)?.id ?? 0;
                        e.Handled = true;
                    }
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                using (EslamDbContext db = new EslamDbContext())
                {
                    serviceLog.drawer_id = db.Drawers.FirstOrDefault().id;
                    serviceLog.service_id = Convert.ToInt32(lkp_ServiceID.EditValue);
                    serviceLog.note = txt_notes.Text.Trim() == string.Empty ? "1" : txt_notes.Text.Trim();
                    serviceLog.amount = sp_Balance.Value - (sp_Balance.Value == 0 || !tog_IsCredit.IsOn ? 0 : (sp_Balance.Value * 2));
                    serviceLog.IsIn = tog_IsCredit.IsOn;
                    serviceLog.date = DateTime.Now;
                    db.ServiceLogs.Add(serviceLog);
                    db.SaveChanges();
                    
                    Notification.RunAlert("تم الحفظ بنجاح", "", Notification.alertType.Success);
                    this.Close();
                }
            }
        }
        bool ValidateData()
        {
            int CheckExceptions = 0;
            CheckExceptions += lkp_ServiceID.CheckEmptyLKP() ? 0 : 1;

            return CheckExceptions == 0;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Logic;
using Eslam_Managment_Project.Lib.Model;
using Eslam_Managment_Project.Lib.Services;
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
    public partial class guna_AddBalance : DevExpress.XtraEditors.XtraForm
    {
        ServiceLog serviceLog;
        private static guna_AddBalance _frm;
        public static guna_AddBalance frm
        {
            get
            {
                if (_frm == null) _frm = new guna_AddBalance();
                return _frm;
            }
            set { _frm = value; }
        }
        guna_AddBalance()
        {
            InitializeComponent();
            this.FormClosed += Guna_AddBalance_FormClosed;
            serviceLog = new ServiceLog();

        }
        private void Guna_AddBalance_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frm = null;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (sp_Balance.Value > 0)
            {
                using (EslamDbContext db = new EslamDbContext())
                {
                    serviceLog.drawer_id = db.Drawers.FirstOrDefault().id;
                    serviceLog.note = txt_notes.Text.Trim() == string.Empty?"1":txt_notes.Text.Trim();
                    serviceLog.amount = sp_Balance.Value - (sp_Balance.Value == 0 || !tog_IsCredit.IsOn ? 0 : (sp_Balance.Value * 2));
                    serviceLog.IsIn = tog_IsCredit.IsOn;
                    serviceLog.service_id = 0;
                    serviceLog.date = DateTime.Now;
                    db.ServiceLogs.Add(serviceLog);
                    db.SaveChanges();
                    
                    Notification.RunAlert("تم الحفظ بنجاح", "", Notification.alertType.Success);
                    this.Close();
                }
            }
            else
            {
                Notification.RunAlert("", "The value cannot be less than or equal to zero", Notification.alertType.Error);
            }
        }
       
    }
}
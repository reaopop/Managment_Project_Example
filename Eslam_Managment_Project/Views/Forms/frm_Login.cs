using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Logic;
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
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            EslamDbContext db = new EslamDbContext();
            if(db.Users.Where(x=> x.UserName == txt_UserName.Text.Trim() && x.Password == txt_Password.Text.Trim()).Count() > 0)
            {
                this.Hide();
                new frm_Dashboard().ShowDialog();
            }
            else
            {
                Notification.RunAlert("Wrong password or username", "", Notification.alertType.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Connection_Click(object sender, EventArgs e)
        {
            memoEdit1.Text = ConnectionStringClass.GetConnection();
            flyoutPanel1.ShowPopup();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ConnectionStringClass.SetConnection(memoEdit1.Text.Trim());
        }
    }
}
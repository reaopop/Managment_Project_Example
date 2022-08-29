using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Model;
using Eslam_Managment_Project.Logic.Presenters;
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
    public partial class guna_Dashboard : DevExpress.XtraEditors.XtraForm
    {
        public guna_Dashboard()
        {
            InitializeComponent();
            using (EslamDbContext db =new EslamDbContext())
            {
                CustomCategories(db.Categories.ToList());
            }
            txt_Search.TextChanged += Txt_Search_TextChanged;
            txt_Search.KeyDown += Txt_Search_KeyDown;
        }

        private void Txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Search_TextChanged(null, null);
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            var SearchText = txt_Search.Text.Trim();
            using (EslamDbContext db = new EslamDbContext())
            {
                if(SearchText == string.Empty)
                CustomCategories(db.Categories.ToList());
                else
                CustomCategories(db.Categories.Where(x=> x.category_name.Contains(SearchText)).ToList());
            }
        }

        void CustomCategories(List<Category> Categories)
        {
            using (EslamDbContext db = new EslamDbContext())
            {
                var categories = Categories;

                lbl_Balance.Text = (db.ServiceLogs?.Sum(x => (double?)x.amount) ?? 0).ToString() + " LE";
                lbl_Revnues.Text = (db.ServiceLogs.Where(x => x.IsIn == false)?.Sum(x => (double?)x.amount) ?? 0).ToString() + " LE";
                lbl_Expenses.Text = (db.ServiceLogs.Where(x => x.IsIn == true)?.Sum(x => (double?)x.amount) ?? 0).ToString() + " LE";
                flowLayoutPanel1.Controls.Clear();
                foreach (var item in categories)
                {
                    usr_CategoryCard usr = new usr_CategoryCard(item);
                    usr.categoryID = item.id;
                    usr.CategoryName = item.category_name;
                    if (item.Logo != null)
                        usr.Logo = Session.GetImage(item.Logo.ToArray());
                    flowLayoutPanel1.Controls.Add(usr);
                    usr.AddClick += (sender, e) =>
                    {
                        guna_ServiceLog frm = new guna_ServiceLog(usr.categoryID);
                        frm.ShowDialog();
                        using (EslamDbContext dbs = new EslamDbContext())
                        {
                            lbl_Balance.Text = Session.Balance;
                            lbl_Expenses.Text = Session.Expenses;
                            lbl_Revnues.Text = Session.Revnues;
                            CustomCategories(dbs.Categories.ToList());
                        }
                    };
                    usr.ResetClick += (sender, e) =>
                    {
                        if (XtraMessageBox.Show(text: "The Category will be Reset All Actions ?", caption: "Reset", buttons: System.Windows.Forms.MessageBoxButtons.YesNo, icon: System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            using (EslamDbContext dbs = new EslamDbContext())
                            {
                                dbs.ServiceLogs.RemoveRange(dbs.ServiceLogs.Where(z => dbs.Services.Where(x=> x.id == z.service_id && x.category_id == usr.categoryID).Count() > 0));
                                dbs.SaveChanges();
                                lbl_Balance.Text = Session.Balance;
                                lbl_Expenses.Text = Session.Expenses;
                                lbl_Revnues.Text = Session.Revnues;
                                CustomCategories(dbs.Categories.ToList());
                                Notification.RunAlert("Mission completed successfully", "", Notification.alertType.Success);
                            }
                        }
                    };
                    usr.DeleteClick += (sender, e) =>
                    {
                        using (EslamDbContext dbs = new EslamDbContext())
                        {
                            if (dbs.ServiceLogs.Where(x=> dbs.Services.Where(z=> z.id == x.service_id && z.category_id == usr.categoryID).Count() > 0).Count() == 0)
                            {
                                if (XtraMessageBox.Show(text: "The Category will be deleted ?", caption: "Delete", buttons: System.Windows.Forms.MessageBoxButtons.YesNo, icon: System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    dbs.Services.RemoveRange(dbs.Services.Where(z => z.category_id == usr.categoryID));
                                    dbs.SaveChanges();
                                    dbs.Categories.Remove(dbs.Categories.FirstOrDefault(x => x.id == usr.categoryID));
                                    dbs.SaveChanges();
                                    CustomCategories(dbs.Categories.ToList());
                                }
                            }
                            else
                                Notification.RunAlert("", "This category cannot be deleted because it is related to services", Notification.alertType.Error);
                        }
                    };
                }
            }
        }
        

        private void guna_Dashboard_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AddBalance_Click(object sender, EventArgs e)
        {
             guna_AddBalance.frm.ShowDialog();
            lbl_Balance.Text = Session.Balance;
            lbl_Expenses.Text = Session.Expenses;
            lbl_Revnues.Text = Session.Revnues;
        }

        private void btn_AddCategories_Click(object sender, EventArgs e)
        {
            new guna_Categories().ShowDialog();
            using (EslamDbContext db = new EslamDbContext())
            {
                CustomCategories(db.Categories.ToList());
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           frm_ReportGrid.frm.ShowDialog();
        }
    }
}
using DevExpress.XtraEditors;
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
    public partial class frm_Dashboard : DevExpress.XtraBars.TabForm
    {
        public frm_Dashboard()
        {
            InitializeComponent();
            Session.manager = documentManager1;
            Session.TabView = tabbedView1;
            Forms.frm_Report.frm.AddElement();
            btn_Dashboard.CheckedChanged += Btn_Dashboard_CheckedChanged;
            btn_Drawers.CheckedChanged += Btn_Dashboard_CheckedChanged;
            btn_CategoriesList.CheckedChanged += Btn_Dashboard_CheckedChanged;
            btn_Services.CheckedChanged += Btn_Dashboard_CheckedChanged;
            btn_Balance.CheckedChanged += Btn_Dashboard_CheckedChanged;
            btn_Report.CheckedChanged += Btn_Dashboard_CheckedChanged;
        }

        private void Btn_Dashboard_CheckedChanged(object sender, EventArgs e)
        {
            string tag = ((Bunifu.UI.WinForms.BunifuRadioButton)sender).Tag.ToString();
            AddElementByTag(tag);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AddElementByTag(string Tag)
        {
            switch (Tag)
            {
                case nameof(Forms.frm_Report):
                    Forms.frm_Report.frm.AddElement();
                    break;
                case nameof(Forms.frm_Balance):
                    frm_Balance.frm.AddElement();
                    break;
                case nameof(Forms.frm_Drawers):
                    frm_Drawers.frm.AddElement();
                    break;
                case nameof(Forms.frm_Categories):
                    frm_Categories.frm.AddElement();
                    break;
                case nameof(Forms.frm_Services):
                    frm_Services.frm.AddElement();
                    break;
                case nameof(Forms.frm_ReportGrid):
                    frm_ReportGrid.frm.AddElement();
                    break;
                default:
                    break;
            }
        }
    }
}
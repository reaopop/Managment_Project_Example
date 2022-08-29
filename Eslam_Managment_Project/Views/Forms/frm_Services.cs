using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Model;
using Eslam_Managment_Project.Logic.Presenters;
using Eslam_Managment_Project.Logic.Services;
using Eslam_Managment_Project.Views.Interfaces;
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
    public partial class frm_Services : DevExpress.XtraEditors.XtraForm , Ifrm_Services
    {
        private static frm_Services _frm;
        public static frm_Services frm
        {
            get
            {
                if (_frm == null) _frm = new frm_Services();
                return _frm;
            }
            set { _frm = value; }
        }
        frm_Services_Presenter presenter;
        frm_Services()
        {
            InitializeComponent();
            this.FormClosed += Frm_Services_FormClosed;
            gridView1.DoubleClick += GridView1_DoubleClick;
            presenter = new frm_Services_Presenter(this);
        }

        private void Frm_Services_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public string Service_Name { get => txt_ServiceName.Text.Trim(); set => txt_ServiceName.Text = value; }
        public int CategoryID { get => Convert.ToInt32(lkp_CategoryID.EditValue); set => lkp_CategoryID.EditValue = value; }
        public bool IsCredit { get => tog_IsCredit.IsOn; set => tog_IsCredit.IsOn = value; }
        public BindingList<Service> Services { get => gridView1.DataSource as BindingList<Service>; set => gridControl1.DataSource = value; }
        public object Categories { get 
            {
                EslamDbContext db = new EslamDbContext();
                lkp_CategoryID.FillData(db.Categories.Select(x=> new { x.id , x.category_name}).ToList() , true,nameof(Category.id), nameof(Category.category_name));
                return true; 
            } }

        public bool ValidateData { get 
            {
                int CheckException = 0;
                CheckException += (lkp_CategoryID.CheckEmptyLKP()) ? 0 : 1;
                CheckException += (txt_ServiceName.ValidateString()) ? 0 : 1;
                return CheckException == 0;
            } }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.InsertOrUpdate();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.Delete();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.New();
        }
        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            var Row = gridView1.GetFocusedRow() as Service;
            if (Row == null) return;
            presenter.Entity = Row;
            presenter.GetData();
        }
    }
}
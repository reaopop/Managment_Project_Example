using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Model;
using Eslam_Managment_Project.Logic.Presenters;
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
    public partial class frm_Drawers : DevExpress.XtraEditors.XtraForm , Ifrm_Drawers
    {
        private static frm_Drawers _frm;
        public static frm_Drawers frm
        {
            get
            {
                if (_frm == null) _frm = new frm_Drawers();
                return _frm;
            }
            set { _frm = value; }
        }
        frm_Drawers_Presenter presenter;
        public string DrawerName { get => txt_DrawerName.Text.Trim(); set => txt_DrawerName.Text = value; }
        public BindingList<Drawer> Drawers { get => gridView1.DataSource as BindingList<Drawer>; set => gridControl1.DataSource = value; }

        public frm_Drawers()
        {
            InitializeComponent();
            presenter = new frm_Drawers_Presenter(this);
        }

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

        private void frm_Drawers_Load(object sender, EventArgs e)
        {
            gridView1.DoubleClick += GridView1_DoubleClick;
            this.FormClosed += Frm_Drawers_FormClosed;
        }

        private void Frm_Drawers_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            var Row = gridView1.GetFocusedRow() as Drawer;
            if (Row == null) return;
            presenter.Entity = Row;
            presenter.GetData();
        }
    }
}
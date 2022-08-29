using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Model;
using Eslam_Managment_Project.Logic.Presenters;
using Eslam_Managment_Project.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eslam_Managment_Project.Views.Forms
{
    public partial class frm_Categories : DevExpress.XtraEditors.XtraForm,ifrm_Categories
    {
        private static frm_Categories _frm;
        public static frm_Categories frm
        {
            get
            {
                if (_frm == null) _frm = new frm_Categories();
                return _frm;
            }
            set { _frm = value; }
        }
        frm_Categories_Presenter presenter;
        public string CategoryName { get => txt_CategoryName.Text.Trim(); set => txt_CategoryName.Text = value; }
        public BindingList<Category> Categories { get => gridView1.DataSource as BindingList<Category>; set => gridControl1.DataSource = value; }
        public Image Logo { get 
            {
                 return pic_CategoryImage.Image;
            } set => pic_CategoryImage.Image = value; }

        public frm_Categories()
        {
            InitializeComponent();
            presenter = new frm_Categories_Presenter(this);
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

        private void frm_Categories_Load(object sender, EventArgs e)
        {
            this.FormClosed += Frm_Categories_FormClosed;
            gridView1.DoubleClick += GridView1_DoubleClick;

        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            var Row = gridView1.GetFocusedRow() as Category;
            if (Row == null) return;
            presenter.Entity = Row;
            presenter.GetData();
        }

        private void Frm_Categories_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
    }
}
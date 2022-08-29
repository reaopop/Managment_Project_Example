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
    public partial class guna_Categories : DevExpress.XtraEditors.XtraForm, ifrm_Categories
    {
        frm_Categories_Presenter presenter;
        public guna_Categories()
        {
            InitializeComponent();
            presenter = new frm_Categories_Presenter(this);
        }

        public string CategoryName { get => txt_CategoryName.Text; set => txt_CategoryName.Text = value; }
        public BindingList<Category> Categories { get; set ; }
        public Image Logo { get => pictureEdit1.Image; set => pictureEdit1.Image = value; }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            presenter.InsertOrUpdate();
            this.Close();
        }
    }
}
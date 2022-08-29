using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Model;
using Eslam_Managment_Project.Logic.Services;
using Eslam_Managment_Project.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eslam_Managment_Project.Views.Popups
{
    public partial class usr_CategoryCard : UserControl
    {
        public Category category { get; set; }
        public int categoryID { get; set; }
        public string CategoryName
        {
            get => lbl_CategoryName.Text;
            set => lbl_CategoryName.Text = value;
        }
        public Image Logo { get 
            {
                return guna2PictureBox1.Image;
            } set => guna2PictureBox1.Image = value; }
        public usr_CategoryCard(Category CategoryType)
        {
            InitializeComponent();
            category = CategoryType;
            categoryID = category.id;
            using (EslamDbContext db = new EslamDbContext())
            {
                decimal balance = db.ServiceLogs.Where(x=>  db.Services.Where(z=> z.id == x.service_id && z.category_id == categoryID).Count() > 0)?.Sum(x => (decimal?) x.amount) ?? 0;
                if(balance<= 0)
                {
                    guna2GradientPanel1.FillColor = Color.FromArgb(218, 37, 62);
                    guna2GradientPanel1.FillColor2 = Color.FromArgb(225, 80, 100);

                }
                else
                {
                    guna2GradientPanel1.FillColor = Color.FromArgb(67, 154, 173);
                    guna2GradientPanel1.FillColor2 = Color.FromArgb(129, 187, 200);
                }
                lbl_Balance.Text = balance.ToString("0.00") + " LE";
            }
        }

        private void tile_CreateService_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_Services.frm.CategoryID = categoryID;
            frm_Services.frm.AddElement();
        }

        public new event EventHandler AddClick
        {
            add
            {
                guna2ImageButton1.Click += value;
              
            }
            remove
            {
                guna2ImageButton1.Click -= value;
               
            }
        }
        public new event EventHandler DeleteClick
        {
            add
            {
                guna2ImageButton2.Click += value;

            }
            remove
            {
                guna2ImageButton2.Click -= value;

            }
        }

         public new event EventHandler ResetClick
        {
            add
            {
                btn_Reset.Click += value;

            }
            remove
            {
                btn_Reset.Click -= value;

            }
        }

    }
}

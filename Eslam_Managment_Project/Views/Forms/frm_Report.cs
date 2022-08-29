using DevExpress.XtraEditors;
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
    //TODO Add Balance Card And Remove All cards
    public partial class frm_Report : DevExpress.XtraEditors.XtraForm
    {
        private static frm_Report _frm;
        public static frm_Report frm
        {
            get
            {
                if (_frm == null) _frm = new frm_Report();
                return _frm;
            }
            set { _frm = value; }
        }
         frm_Report()
        {
            InitializeComponent();
            this.FormClosed += Frm_Report_FormClosed;
        }

        private void Frm_Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
    }
}
using DevExpress.XtraEditors;
using Eslam_Managment_Project.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eslam_Managment_Project.Views.Popups
{
    public partial class guna_Splash : DevExpress.XtraEditors.XtraForm
    {
        public guna_Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progress.Value == 100)
            {
                timer1.Stop();
                Thread.Sleep(1000);
                new guna_Dashboard().Show();
                this.Close();
            }
            else
            {
                progress.Value += 1;
                lbl_Number.Text = progress.Value.ToString();

            }
        }

        private void guna_Splash_Load(object sender, EventArgs e)
        {
            progress.Value = 0;
            timer1.Start();
            
        }
    }
}
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using static Eslam_Managment_Project.Logic.Services.Notification;

namespace Rased_ERP.Views.Popups
{
    public partial class Alert_Save : Form
    {
        int TimerTime = 50000;
        public Alert_Save()
        {
            InitializeComponent();
        }
        
        private enumAction action;
        private int x, y;

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case enumAction.wait:
                    timer1.Interval = TimerTime;
                    action = enumAction.close;
                    break;
                case enumAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            action = enumAction.wait;
                        }
                    }
                    break;
                case enumAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enumAction.close;
        }

        public void showAlert(string Alert,string Documentation,alertType type,int timertime , HorzAlignment TitlehorzAlignment)
        {
            TimerTime = timertime;
            this.Opacity = 0.0;
            this.lbl_Title.Appearance.TextOptions.HAlignment = TitlehorzAlignment;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Alert_Save frm = (Alert_Save)Application.OpenForms[fname];
                if(frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 5;
            switch (type)
            {
                case alertType.Success:
                    pictureBox1.Image = Eslam_Managment_Project.Properties.Resources.SuccessClude;
                    this.BackColor = Color.SeaGreen;
                    try
                    {
                        SoundPlayer spSuccess =new SoundPlayer("SuccessSound1.wav");
                        spSuccess.Play();
                    }
                    catch { SystemSounds.Beep.Play(); }
                    break;
                case alertType.Warning:
                    pictureBox1.Image = Eslam_Managment_Project.Properties.Resources.WarningClude1;
                    this.BackColor = Color.DarkOrange;
                    try
                    {
                        SoundPlayer spWarning = new SoundPlayer("WarningSound1.wav");
                        spWarning.Play();
                    }
                    catch { SystemSounds.Hand.Play(); }
                    break;
                case alertType.Error:
                    pictureBox1.Image = Eslam_Managment_Project.Properties.Resources.ErrorClude;
                    this.BackColor = Color.DarkRed;
                    try
                    {
                        //SystemSounds.Hand.Play();
                        SoundPlayer spError = new SoundPlayer("ErrorSound1.wav");
                        spError.Play();
                    }
                    catch { SystemSounds.Exclamation.Play(); }
                    break;
                case alertType.Info:
                    pictureBox1.Image = Eslam_Managment_Project.Properties.Resources.InfoClude;
                    this.BackColor = Color.RoyalBlue;
                    try
                    {
                        SoundPlayer spInfo = new SoundPlayer("InfoSound1.wav");
                        spInfo.Play();
                    }
                    catch { SystemSounds.Question.Play(); }
                    break;
                default:
                    break;
            }


            this.lbl_Title.Text = Alert;
            this.lbl_Documentation.Text = Documentation;
            this.Show();
            this.BringToFront();
            this.action = enumAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}

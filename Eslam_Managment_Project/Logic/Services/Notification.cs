using DevExpress.Utils;
using Eslam_Managment_Project.Lib.Logic;
using Eslam_Managment_Project.Lib.Logic.Models;
using Rased_ERP.Views.Popups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Eslam_Managment_Project.Lib.Logic.Notification_Service;

namespace Eslam_Managment_Project.Logic.Services
{
    public class Notification
    {
        #region alerts Actions
        public enum alertType
        {
            Success,
            Warning,
            Error,
            Info,
        }
        public enum enumAction
        {
            wait,
            start,
            close
        }
       

        /// <summary>
        /// This Functions To Display Notification Popup 
        /// </summary>
        /// <param name="Title"> Caption For Notification </param>
        /// <param name="Documentation"> Contant For Notifiaction </param>
        /// <param name="type"> Type Of Message Like (Success , Error , Warning) </param>
        /// <param name="timertime"> Time Of Display </param>
        public static void RunAlert(string Title, string Documentation, alertType type, HorzAlignment horzAlignment, int timertime = 2500)
        {
            Alert_Save alert = new Alert_Save();
            alert.showAlert(Title, Documentation, type, timertime,horzAlignment);
        }
        public static void RunAlert(string Title, string Documentation, alertType type, int timertime = 2500)
        {
            Alert_Save alert = new Alert_Save();
            alert.showAlert(Title, Documentation, type, timertime, HorzAlignment.Center);
        }
        /// <summary>
        /// This Function To Display Notification After Fired Any Request To Database 
        /// </summary>
        /// <param name="Message_iD"> Type of Request (Get From Stored Procedure) </param>
        public static void MessageRequest(int Message_iD)
        {
            string Message_Title  = "";
            string Message_Contant = "";
            alertType type = alertType.Success;
            switch (Message_iD)
            {
                case (int)NotificationsType.add:
                case (int)NotificationsType.edit:
                case (int)NotificationsType.delete:
                case (int)NotificationsType.LoginSuccessed:
                    type = alertType.Success;
                    break;
                case (int)NotificationsType.canNotAdd:
                case (int)NotificationsType.canNotEdit:
                case (int)NotificationsType.canNotDelete:
                case (int)NotificationsType.LoginFailed:
                    type = alertType.Error;
                    break;
             
                default:
                    break;
            }
            Message_Title = NotificationsTypeList.FirstOrDefault(x => x.id == Message_iD).title;
            Message_Contant = NotificationsTypeList.FirstOrDefault(x => x.id == Message_iD).contant;
            RunAlert(Message_Title, Message_Contant, type);
        }
        #endregion
    }
}

using DevExpress.XtraEditors;
using Eslam_Managment_Project.Lib.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Logic.Services
{
    public static class Session
    {
        public static string Balance { get { using (EslamDbContext db = new EslamDbContext()) return (db.ServiceLogs?.Sum(x => (double?)x.amount) ?? 0).ToString() + " LE"; } }
        public static string Expenses { get { using (EslamDbContext db = new EslamDbContext()) return (db.ServiceLogs.Where(x => x.IsIn == true)?.Sum(x => (double?)x.amount) ?? 0).ToString() + " LE"; } }
        public static string Revnues { get { using (EslamDbContext db = new EslamDbContext()) { decimal reven = Convert.ToDecimal(db.ServiceLogs.Where(x => x.IsIn == false)?.Sum(x => (double?)x.amount) ?? 0); return (reven).ToString() + " LE"; } } }
        //This Property is used to display all screens as tabs
        public static DevExpress.XtraBars.Docking2010.DocumentManager manager { get; set; }
        public static DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView TabView { get; set; }

        /// <summary>
        /// this function to add new Screen In Document Manager and Showing it
        /// </summary>
        /// <param name="xtraForm"></param>
        public static void AddElement(this XtraForm xtraForm)
        {
            try
            {
                var frm = manager.View.Documents.FirstOrDefault(x => x.Form == xtraForm);
                if (frm != null)
                {
                    manager.View.ActivateDocument(xtraForm);
                    TabView.ActivateDocument(xtraForm);
                }
                else
                    manager.View.AddDocument(xtraForm);

            }
            catch (Exception e)
            {

            }
        }

        public static byte[] SetImage(Image img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if (img == null) { return null; }
                try
                {
                    img.Save(stream, ImageFormat.Jpeg);
                    return stream.ToArray();
                }
                catch
                {
                    return stream.ToArray();
                }

            }
        }
        public static Image GetImage(byte[] imgArray)
        {
            Image img = null;
            using (MemoryStream stream = new MemoryStream(imgArray, false))
            {
                if (imgArray == null) { return null; }
                try
                {
                    return img = Image.FromStream(stream);

                }
                catch
                {
                    return img;
                }
            }
        }
    }
}

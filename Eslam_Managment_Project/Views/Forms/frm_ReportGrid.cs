using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Eslam_Managment_Project.Lib.Model;
using Eslam_Managment_Project.Logic.Services;
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
    public partial class frm_ReportGrid : DevExpress.XtraEditors.XtraForm
    {
        private static frm_ReportGrid _frm;
        public static frm_ReportGrid frm
        {
            get
            {
                if (_frm == null) _frm = new frm_ReportGrid();
                return _frm;
            }
            set { _frm = value; }
        }

        RepositoryItemLookUpEdit RepoSize = new RepositoryItemLookUpEdit();

        EslamDbContext db;
         frm_ReportGrid()
        {
            InitializeComponent();
            this.FormClosed += Frm_ReportGrid_FormClosed;
        }

        private void Frm_ReportGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frm = null;
        }

        private void frm_ReportGrid_Load(object sender, EventArgs e)
        {
            db = new EslamDbContext();
            gridControl1.DataSource = db.ServiceLogs.ToList();
            RepoSize.FillData(db.Services.ToList(), gridView1.Columns[nameof(ServiceLog.service_id)], ref gridControl1, nameof(Service.service_name), nameof(Service.id));
            RepoSize.ValidateOnEnterKey = true;
            RepoSize.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            RepoSize.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            RepoSize.ImmediatePopup = true;
        }
    }
}
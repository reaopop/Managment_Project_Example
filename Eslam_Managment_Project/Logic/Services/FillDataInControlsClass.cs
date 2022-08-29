using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTreeList;
using DevExpress.XtraEditors.Repository;

namespace Eslam_Managment_Project.Logic.Services
{
    /// <summary>
    /// This Class To Fill Data from Some Controls
    /// </summary>
    public static class FillDataInControlsClass
    {

        // TreeList
        public static void FillData(this TreeList tree, object Data)
        {
            tree.FillData(Data, "ID", "ParentID");
        }
        public static void FillData(this TreeList tree, object Data, string ValueMember, string DisplayMember)
        {
            tree.DataSource = Data;
            tree.ParentFieldName = DisplayMember;
            tree.KeyFieldName = ValueMember;
            tree.OptionsBehavior.Editable = false;
        }
        /// //////////////////////////////////////////////////


        // LookUpEdit
        public static void FillData(this LookUpEdit lkp, object Data)
        {
            lkp.FillData(Data, "ID", "Name");
        }

        public static void FillData(this LookUpEdit lkp, object Data, string ValueMember, string DisplayMember)
        {
            lkp.Properties.DataSource = Data;
            lkp.Properties.DisplayMember = DisplayMember;
            lkp.Properties.ValueMember = ValueMember;
            lkp.Properties.Columns.Clear();
            lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo()
            {
                FieldName = ValueMember,
            });
            lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo()
            {
                FieldName = DisplayMember,
            });
            lkp.Properties.Columns[ValueMember].Visible = false;
            lkp.Properties.ShowHeader = false;
        }

        /// //////////////////////////////////////////////////


        // GridLookUpEdit
        public static void FillData(this GridLookUpEdit lkp, object Data, bool ShowColumns = true)
        {
            lkp.FillData(Data, ShowColumns, "ID", "Name");

        }
        public static void FillData(this GridLookUpEdit lkp, object Data, bool ShowColumns, string ValueMember, string DisplayMember)
        {
            lkp.Properties.DataSource = Data;
            lkp.Properties.DisplayMember = DisplayMember;
            lkp.Properties.ValueMember = ValueMember;
            if (!ShowColumns)
            {
                lkp.Properties.View.Columns.Clear();
                lkp.Properties.View.Columns.Add(new GridColumn()
                {
                    FieldName = ValueMember,
                });
                lkp.Properties.View.Columns.Add(new GridColumn()
                {
                    FieldName = DisplayMember,
                });
                lkp.Properties.View.Columns[ValueMember].Visible = false;
                lkp.Properties.View.OptionsView.ShowColumnHeaders = false;
            }
            lkp.Properties.PopulateViewColumns();
        }

        /// //////////////////////////////////////////////////



        // LookUpEditBase
        /// This Function To Fill Data From LookUpEdit Repository And Add This Repository In GridColumn 
        public static void FillData(this RepositoryItemLookUpEditBase lkp, object Data, GridColumn column, ref GridControl grid, bool Check = true)
        {
            FillData(lkp, Data, column, ref grid, "Name", "ID");
        }
        public static void FillData(this RepositoryItemLookUpEditBase lkp, object Data, GridColumn column, ref GridControl grid, string DisplayMember, string ValueMember, bool Check = true)
        {
            if (Check)
            {
                lkp.BeginInit();
                lkp.DataSource = Data;
                lkp.NullText = "";
                lkp.DisplayMember = DisplayMember;
                lkp.ValueMember = ValueMember;
                lkp.EndInit();
                if (grid != null)
                {
                    grid.ForceInitialize();
                    grid.RepositoryItems.Add(lkp);
                }
                if (column != null) column.ColumnEdit = lkp;
            }
            else
            {
                if (column != null)
                {

                    column.OptionsColumn.AllowEdit = false;
                    column.ColumnEdit = new RepositoryItemHypertextLabel();
                }
            }
        }
        /// //////////////////////////////////////////////////
    }
}

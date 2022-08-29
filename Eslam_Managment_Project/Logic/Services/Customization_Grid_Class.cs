using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Logic.Services
{
    public static class Customization_Grid_Class
    {
        // This Function To Set Defoult Options To GridView
        public static void SetGridViewOptions(this GridView grid , List<string> VisbleityColumns = null)
        {
            grid.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            grid.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            grid.OptionsNavigation.AutoFocusNewRow = true;
            grid.OptionsView.RowAutoHeight = true;

            if (VisbleityColumns != null) grid.VisbleityColumns(VisbleityColumns);
        }

        // This Function To Visible Some Columns from Grid View
        public static void VisbleityColumns(this GridView lkp, List<string> NameColumns)
        {
            foreach (var item in NameColumns)
            {
                lkp.Columns[item].Visible = false;
            }
        }
    }
}

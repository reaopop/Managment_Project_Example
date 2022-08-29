using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Logic.Services
{
    public static class Validation_Controls
    {
        #region ValidateInputs
        public static bool CheckEmptyLKP(this LookUpEditBase lkp)
        {
            if (lkp.EditValue == null || lkp.EditValue.ToString() == string.Empty || Convert.ToInt32(lkp.EditValue) == 0)
            {
                lkp.ErrorText = "This Value Is Required";
                return false;
            }

            return (lkp.EditValue != null);
        }
        public static bool CheckEmptyLKPInt(this LookUpEditBase lkp)
        {
            if (lkp.EditValue == null || lkp.EditValue.ToString() == string.Empty)
            {
                lkp.ErrorText = "This Value Is Required";
                return false;
            }

            return (lkp.EditValue != null);
        }
        public static bool CheckDateTime(this DateEdit DE)
        {
            if (DE.DateTime.Year < 1950)
            {
                DE.ErrorText = "This Value Is Required";
            }

            return (DE.DateTime.Year >= 1950);
        }
        public static bool ValidateString(this TextEdit txt)
        {
            if (txt.Text.Trim() == string.Empty)
            {
                txt.ErrorText = "This Value Is Required";
            }
            return (txt.Text.Trim() != string.Empty);
        }

        public static bool IsValueLessThenZero(this SpinEdit edit, bool ErrorText = true)
        {
            if (ErrorText && edit.Value <= 0) edit.ErrorText = "This Value Is Required";
            return (edit.Value > 0);
        }
        public static bool IsValueBiggerThenZero(this SpinEdit edit, bool ErrorText = true)
        {
            if (ErrorText && edit.Value <= 0) edit.ErrorText = "This Value Is Required";
            return (edit.Value > 0);
        }


        #endregion
    }
}

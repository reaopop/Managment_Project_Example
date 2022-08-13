using Eslam_Managment_Project.Lib.Services;
using Eslam_Managment_Project.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Logic.Presenters
{
    public class frm_Login_Presenter
    {
        #region Fields

        private readonly ifrm_Login repo;
        private User_Service service;
        #endregion

        #region Constractors
        public frm_Login_Presenter(ifrm_Login Repo)
        {
            repo = Repo;
            //service = new User_Service();
        }
        #endregion

        #region Methods

        #endregion
    }
}

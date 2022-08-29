using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Logic.Services
{
    public interface IBasePresenter<T>
    {
        T Entity { get; set; }
        void InsertOrUpdate();
        void Delete();
        void New();
        void ValidateData();
       
        void GetData();
        void SetData();
    }
}

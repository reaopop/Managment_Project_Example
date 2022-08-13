using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eslam_Managment_Project.Lib.Logic.Models
{
    public class TypeSchemaClass<T>
    {
        public int id { get; set; }
        public string title { get; set; }
        public string contant { get; set; }
        public T type { get; set; }
    }
}

namespace Eslam_Managment_Project.Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public byte UserType { get; set; }

        public bool IsActive { get; set; }

        public bool? IsOnline { get; set; }
    }
}

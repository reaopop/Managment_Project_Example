namespace Eslam_Managment_Project.Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        public int id { get; set; }

        [Required]
        public string service_name { get; set; }

        public bool IsCredit { get; set; }

        public int category_id { get; set; }

        public int AccountID { get; set; }

        public virtual Category Category { get; set; }
    }
}

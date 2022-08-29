namespace Eslam_Managment_Project.Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceLog")]
    public partial class ServiceLog
    {
        public int id { get; set; }

        public int service_id { get; set; }

        public decimal amount { get; set; }

        public int drawer_id { get; set; }

        public DateTime date { get; set; }

        [Required]
        public string note { get; set; }

        public bool IsIn { get; set; }

        public virtual Drawer Drawer { get; set; }
    }
}

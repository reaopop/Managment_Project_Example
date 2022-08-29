namespace Eslam_Managment_Project.Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Drawer")]
    public partial class Drawer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drawer()
        {
            ServiceLogs = new HashSet<ServiceLog>();
        }

        public int id { get; set; }

        [Required]
        public string drawer_name { get; set; }

        public int AccountID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceLog> ServiceLogs { get; set; }
    }
}

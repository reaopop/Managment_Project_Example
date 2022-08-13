namespace Eslam_Managment_Project.Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Journal")]
    public partial class Journal
    {
        public int id { get; set; }

        public int CustomerId { get; set; }

        public decimal? Debit { get; set; }

        public decimal? Credit { get; set; }

        public DateTime InsertDate { get; set; }

        public byte SourceType { get; set; }

        public int SourceId { get; set; }

        [Required]
        public string Notes { get; set; }

        public int? UserId { get; set; }
    }
}

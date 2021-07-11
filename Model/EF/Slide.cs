namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slide")]
    public partial class Slide
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(250)]
        public string image { get; set; }

        public int? displayOrder { get; set; }

        [StringLength(250)]
        public string link { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public DateTime? createdDate { get; set; }

        public bool? status { get; set; }
    }
}

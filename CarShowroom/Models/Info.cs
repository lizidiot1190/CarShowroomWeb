namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Info")]
    public partial class Info
    {
        public int id { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        public bool? status { get; set; }
    }
}

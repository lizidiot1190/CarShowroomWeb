namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("Info")]
    public partial class Info
    {
        public int id { get; set; }
        [StringLength(250)]
        public string name { get; set; }
        [StringLength(250)]
        public string image { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile { get; set; }
        [Column(TypeName = "ntext")]
        public string content { get; set; }

        public bool? status { get; set; }
        public bool? link{ get; set; }
    }
}

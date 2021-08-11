namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("Slide")]
    public partial class Slide
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(250)]
        [DisplayName("Hình ảnh")]
        public string image { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile { get; set; }

        public int? displayOrder { get; set; }

        [StringLength(250)]
        public string link { get; set; }

        [StringLength(500)]
        [DisplayName("Mô tả cho ảnh")]
        public string description { get; set; }

        public DateTime? createdDate { get; set; }
        [DisplayName("Trạng thái")]
        public bool? status { get; set; }
    }
}

using Model.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarShowroom.Models
{
    public class MoreProductImage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Product Product { get; set; }
        [Key]
        [DisplayName("ID Sản phẩm")]
        public int productId { get; set; }
        [StringLength(255)]
        [DisplayName("Ảnh 1")]
        public string img1 { get; set; }
        [StringLength(255)]
        [DisplayName("Ảnh 2")]
        public string img2 { get; set; }
        [StringLength(255)]
        [DisplayName("Ảnh 3")]
        public string img3 { get; set; }
        [StringLength(255)]
        [DisplayName("Ảnh 4")]
        public string img4 { get; set; }
        [StringLength(255)]
        [DisplayName("Ảnh 5")]
        public string img5 { get; set; }
        [StringLength(255)]
        [DisplayName("Ảnh 6")]
        public string img6 { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile1 { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile2 { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile3 { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile4 { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile5 { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile6 { get; set; }

    }
}
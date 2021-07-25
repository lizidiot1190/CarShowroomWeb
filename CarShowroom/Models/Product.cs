namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("Product")]
    public partial class Product
    {
        public long id { get; set; }

        [StringLength(250)]
        public string metaTitle { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(255)]
        public string loaiXe { get; set; }
        [StringLength(255)]
        public string loaiThung { get; set; }
        [StringLength(255)]
        public string taiTrong { get; set; }
        [StringLength(255)]
        public string namSX { get; set; }
        [StringLength(255)]
        public string nhapKhau { get; set; }
        [StringLength(255)]
        public string nhienLieu { get; set; }
        [StringLength(255)]
        public string hopSo { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        [StringLength(250)]
        public string image { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile { get; set; }
        public decimal? price { get; set; }

        public decimal? promotionPrice { get; set; }
        public long? categoryID { get; set; }

        [StringLength(250)]
        public string metaKeywords { get; set; }

        [StringLength(250)]
        public string metaDescription { get; set; }

        public bool? status { get; set; }

        public DateTime? topHot { get; set; }
    }
}

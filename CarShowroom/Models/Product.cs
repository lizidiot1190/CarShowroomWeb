namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("Product")]
    public partial class Product
    {
        public long id { get; set; }

        [StringLength(250)]
        [DisplayName("Thẻ tiêu đề")]
        public string metaTitle { get; set; }

        [StringLength(250)]
        [DisplayName("Tên sản phẩm")]
        public string name { get; set; }

        [StringLength(255)]
        [DisplayName("Loại xe")]
        public string loaiXe { get; set; }
        [StringLength(255)]
        [DisplayName("Loại thùng")]
        public string loaiThung { get; set; }
        [DisplayName("Tải trọng")]
        [StringLength(255)]
        public string taiTrong { get; set; }
        [StringLength(255)]
        [DisplayName("Năm sản xuất")]
        public string namSX { get; set; }
        [StringLength(255)]
        [DisplayName("Nhập khẩu/Lắp ráp")]
        public string nhapKhau { get; set; }
        [DisplayName("Loại nhiên liệu")]
        [StringLength(255)]
        public string nhienLieu { get; set; }
        [StringLength(255)]
        [DisplayName("Loại hộp số")]
        public string hopSo { get; set; }

        [StringLength(500)]
        [DisplayName("Mô tả sản phẩm")]
        public string description { get; set; }

        [StringLength(250)]
        [DisplayName("Hình ảnh")]
        public string image { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile { get; set; }
        [DisplayName("Giá")]
        public decimal? price { get; set; }
        [DisplayName("Giá đã giảm")]
        public decimal? promotionPrice { get; set; }
        [DisplayName("ID danh mục sản phẩm")]
        public long? categoryID { get; set; }

        [StringLength(250)]
        public string metaKeywords { get; set; }

        [StringLength(250)]
        public string metaDescription { get; set; }
        [DisplayName("Trạng thái")]
        public bool? status { get; set; }
        [DisplayName("Sản phẩm nổi bật, nhập vào(ngày/tháng/năm) sản phẩm được gỡ xuống")]
        public DateTime? topHot { get; set; }
    }
}

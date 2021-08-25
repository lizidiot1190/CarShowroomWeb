namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("Content")]
    public partial class Content
    {
        public long id { get; set; }

        [StringLength(250)]
        [DisplayName("Tên tin tức")]
        public string name { get; set; }

        [StringLength(250)]
        [DisplayName("Thẻ tiêu đề")]
        public string metaTitle { get; set; }

        [MaxLength]
        [DisplayName("Nội dung")]
        public string description { get; set; }

        [StringLength(250)]
        [DisplayName("Upload ảnh")]
        public string image { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile { get; set; }
        [DisplayName("Id danh mục tin tức")]
        public long? categoryID { get; set; }

        [StringLength(250)]
        public string metaKeywords { get; set; }

        [StringLength(250)]
        public string metaDescription { get; set; }

        [DisplayName("Trạng thái")]
        public bool? status { get; set; }
        [DisplayName("Đưa lên trang bìa(ngày/tháng/năm)")]
        public DateTime? topHot { get; set; }
    }
}

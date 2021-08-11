namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductCategory")]
    public partial class ProductCategory
    {
        [DisplayName("ID Danh mục")]
        public long id { get; set; }

        [StringLength(250)]
        [DisplayName("Tên danh mục")]
        public string name { get; set; }


        [StringLength(250)]
        [DisplayName("Thẻ tiêu đề")]
        public string metaTitle { get; set; }
        [DisplayName("ID cha(không bắt buộc)")]
        public long? parentID { get; set; }
        [DisplayName("Thứ tự hiển thị(không bắt buộc)")]
        public int? displayOrder { get; set; }

        [StringLength(250)]
        [DisplayName("Seo Title(không bắt buộc)")]
        public string seoTitle { get; set; }

        public DateTime? createdDate { get; set; } = DateTime.Now;

        [StringLength(250)]
        public string metaKeywords { get; set; }

        [StringLength(250)]
        public string metaDiscription { get; set; }
        [DisplayName("Trạng thái")]
        public bool? status { get; set; }
        [DisplayName("Đưa lên trang chủ")]
        public bool? showOnHome { get; set; }
    }
}

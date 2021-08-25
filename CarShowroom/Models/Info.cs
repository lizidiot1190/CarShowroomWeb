namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("Info")]
    public partial class Info
    {
        public int id { get; set; }
        [StringLength(250)]
        [DisplayName("Tên thông tin")]
        public string name { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile { get; set; }
        [StringLength(250)]
        [DisplayName("Hình ảnh")]
        public string image { get; set; }
        [MaxLength]
        [DisplayName("Mô tả nội dung")]
        public string content { get; set; }
        [DisplayName("Trạng thái")]
        public bool? status { get; set; }
        [DisplayName("Link tới địa chỉ google map")]
        public bool? link{ get; set; }
    }
}

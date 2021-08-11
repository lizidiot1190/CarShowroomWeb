namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        public int id { get; set; }

        [StringLength(50)]
        [DisplayName("Họ và tên")]
        public string name { get; set; }

        [DisplayName("Số điện thoại")]
        [StringLength(50)]
        public string phoneNumber { get; set; }

        [StringLength(50)]
        [DisplayName("Email")]
        public string email { get; set; }

        [StringLength(50)]
        [DisplayName("Địa chỉ")]
        public string address { get; set; }

        [StringLength(250)]
        [DisplayName("Tin nhắn")]
        public string content { get; set; }
        public DateTime? createdDate { get; set; }
        [DisplayName("Trạng thái")]
        public bool? status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarShowroom.Models
{
    public class Founder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(255)]
        [DisplayName("Họ và Tên")]
        public string name{ get; set; }
        [StringLength(255)]
        [DisplayName("Hình ảnh")]
        public string image { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile { get; set; }

        [StringLength(255)]
        [DisplayName("Châm ngôn")]
        public string slogan { get; set; }
        [StringLength(255)]
        [DisplayName("Link Facebook")]
        public string link1 { get; set; }
        [StringLength(255)]
        [DisplayName("Link Instagram")]
        public string link2 { get; set; }
        [StringLength(255)]
        [DisplayName("Chức vụ")]
        public string position { get; set; }
    }
}
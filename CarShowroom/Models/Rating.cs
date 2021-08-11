using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarShowroom.Models
{
    public class Rating
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(255)]
        [DisplayName("Tên khách hàng")]
        public string name { get; set; }

        [StringLength(255)]
        [DisplayName("Đánh giá")]
        public string comment { get; set; }
    }
}
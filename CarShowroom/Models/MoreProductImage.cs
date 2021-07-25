using Model.EF;
using System;
using System.Collections.Generic;
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
        public int productId { get; set; }
        [StringLength(255)]
        public string img1 { get; set; }
        [StringLength(255)]
        public string img2 { get; set; }
        [StringLength(255)]
        public string img3 { get; set; }
        [StringLength(255)]
        public string img4 { get; set; }
        [StringLength(255)]
        public string img5 { get; set; }
        [StringLength(255)]
        public string img6 { get; set; }

    }
}
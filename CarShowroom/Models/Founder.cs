using System;
using System.Collections.Generic;
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
        public string name{ get; set; }
        [StringLength(255)]
        public string image { get; set; }
        [NotMapped]
        public HttpPostedFileBase imageFile { get; set; }

        [StringLength(255)]
        public string slogan { get; set; }
    }
}
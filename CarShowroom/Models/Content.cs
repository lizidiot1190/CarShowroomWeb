namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Content")]
    public partial class Content
    {
        public long id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(250)]
        public string metaTitle { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        [StringLength(250)]
        public string image { get; set; }

        public long? categoryID { get; set; }

        [StringLength(250)]
        public string metaKeywords { get; set; }

        [StringLength(250)]
        public string metaDescription { get; set; }

        public bool? status { get; set; }

        public DateTime? topHot { get; set; }
    }
}

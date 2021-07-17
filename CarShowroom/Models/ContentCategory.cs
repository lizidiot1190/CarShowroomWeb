namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContentCategory")]
    public partial class ContentCategory
    {
        public long id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(250)]
        public string metaTitle { get; set; }

        public long? parentID { get; set; }

        public int? displayOrder { get; set; }

        [StringLength(250)]
        public string seoTitle { get; set; }

        public DateTime? cratedDate { get; set; }

        [StringLength(250)]
        public string metaKeywords { get; set; }

        [StringLength(250)]
        public string metaDiscription { get; set; }

        public bool? status { get; set; }

        public bool? showOnHome { get; set; }
    }
}

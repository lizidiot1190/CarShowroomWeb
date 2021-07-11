namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public long id { get; set; }

        [StringLength(50)]
        public string userName { get; set; }

        [StringLength(32)]
        public string passWord { get; set; }
    }
}

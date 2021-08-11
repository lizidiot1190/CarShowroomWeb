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
        public string userName { get; set; } = "admin";

        [StringLength(500)]
        public string passWord { get; set; } = "21232f297a57a5a743894a0e4a801fc3";
    }
}

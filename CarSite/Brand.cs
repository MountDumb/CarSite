namespace CarSite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_owner.Brand")]
    public partial class Brand
    {
        public int BrandId { get; set; }

        [Required]
        [StringLength(50)]
        public string BrandName { get; set; }
    }
}

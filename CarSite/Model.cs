namespace CarSite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_owner.Model")]
    public partial class Model
    {
        public int ModelId { get; set; }

        [Required]
        [StringLength(50)]
        public string ModelName { get; set; }

        public int BrandID { get; set; }
    }
}

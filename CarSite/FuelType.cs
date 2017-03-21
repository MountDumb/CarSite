namespace CarSite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_owner.FuelType")]
    public partial class FuelType
    {
        public int FuelTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string FuelTypeName { get; set; }
    }
}

namespace CarSite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_owner.Car")]
    public partial class Car
    {
        public int CarID { get; set; }

        public int ModelId { get; set; }

        public int FuelTypeId { get; set; }

        public decimal? KmPerLiterOfFuel { get; set; }

        public decimal? Price { get; set; }

        public DateTime? Year { get; set; }

        public int? KmDriven { get; set; }

        public bool IsUsed { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
    }
}

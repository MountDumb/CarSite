namespace CarSite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_owner.CarImages")]
    public partial class CarImage
    {
        public int CarImageId { get; set; }

        public int AssociatedCarId { get; set; }

        [Required]
        [StringLength(250)]
        public string ImagePath { get; set; }
    }
}

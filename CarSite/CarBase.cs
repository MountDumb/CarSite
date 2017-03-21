namespace CarSite
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CarBase : DbContext
    {
        public CarBase()
            : base("name=CarBase")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarImage> CarImages { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<FuelType> FuelTypes { get; set; }
        public virtual DbSet<Model> Models { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.BrandName)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .Property(e => e.KmPerLiterOfFuel)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Car>()
                .Property(e => e.Price)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Car>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CarImage>()
                .Property(e => e.ImagePath)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsFixedLength();

            modelBuilder.Entity<Model>()
                .Property(e => e.ModelName)
                .IsFixedLength();
        }
    }
}

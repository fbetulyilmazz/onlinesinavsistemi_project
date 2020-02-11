using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OnlineSinavUI.Models
{
    public partial class RenteCarContext : DbContext
    {
        public RenteCarContext()
        {
        }

        public RenteCarContext(DbContextOptions<RenteCarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }

        // Unable to generate entity type for table 'dbo.CustomerVehicle'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=RenteCar;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationCode).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.IdentityNo).HasMaxLength(50);

                entity.Property(e => e.NameSurname).HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.CasaType).HasMaxLength(50);

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.Engine).HasMaxLength(50);

                entity.Property(e => e.FuelType).HasMaxLength(50);

                entity.Property(e => e.Gear).HasMaxLength(50);

                entity.Property(e => e.Licence).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Passenger).HasMaxLength(50);

                entity.Property(e => e.VehicleProductionDate).HasColumnType("date");

                entity.Property(e => e.VehicleTypeId).HasMaxLength(50);
            });
        }
    }
}

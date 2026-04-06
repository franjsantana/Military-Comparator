using Microsoft.EntityFrameworkCore;
using MilitaryComparator.Models.Entities;

namespace MilitaryComparator.Data
{
    public class MilitaryDbContext : DbContext
    {
        public MilitaryDbContext(DbContextOptions<MilitaryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Nation> Nations { get; set; } = default!;
        public DbSet<ArmoredVehicle> ArmoredVehicles { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Nation>()
                .HasMany(n => n.Vehicles)
                .WithOne(v => v.Nation)
                .HasForeignKey(v => v.NationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace SuperPowerAcademy.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<SuperPower> SuperPowers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<SuperPower>().HasData(new SuperPower
        //    {
        //        Id = 1,
        //        HeroesPower = 0,
        //        VillainsPower = 0
        //    });
        //}
    }
}

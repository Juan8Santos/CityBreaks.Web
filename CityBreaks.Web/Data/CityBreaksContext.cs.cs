using Microsoft.EntityFrameworkCore;
using CityBreaks.Web.Data.Models;
using CityBreaks.Web.Data.Configurations;

namespace CityBreaks.Web.Data
{
    public class CityBreaksContext : DbContext
    {
        public CityBreaksContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Property> Properties { get; set; }
    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new PropertyConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}


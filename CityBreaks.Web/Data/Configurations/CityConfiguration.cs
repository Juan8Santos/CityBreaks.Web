using CityBreaks.Web.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> cityBuilder)
        {
            cityBuilder.Property(x => x.Name).HasColumnName("name");

            cityBuilder.Property(x => x.CountryId).HasColumnName("countryId");

            cityBuilder.HasData(
                new City { Id = 1, Name = "Rio de Janeiro", CountryId = 1 },
                new City { Id = 2, Name = "Berlim", CountryId = 2 },
                new City { Id = 3, Name = "Port Moresby", CountryId = 3 },
                new City { Id = 4, Name = "Paris", CountryId = 4 }
            );
        }
    }
}

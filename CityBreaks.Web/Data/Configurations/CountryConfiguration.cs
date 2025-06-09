using CityBreaks.Web.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> countryBuilder)
        {
            countryBuilder.Property(x => x.CountryName).HasColumnName("countryName").HasMaxLength(20);

            countryBuilder.Property(x => x.CountryCode).HasColumnName("countryCode");

            countryBuilder.HasData(
                new Country { Id = 1, CountryCode = "BR", CountryName = "Brasil" },
                new Country { Id = 2, CountryCode = "AL", CountryName = "Alemanha" },
                new Country { Id = 3, CountryCode = "NG", CountryName = "Papua-Nova Guiné" },
                new Country { Id = 4, CountryCode = "FR", CountryName = "França" }
            );
        }
    }
}

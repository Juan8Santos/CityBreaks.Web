using CityBreaks.Web.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> propertyBuilder)
        {
            propertyBuilder.Property(x => x.Name).HasColumnName("propertyName").HasMaxLength(100);

            propertyBuilder.Property(x => x.PricePerNight).HasColumnName("pricePerNight");

            propertyBuilder.Property(x => x.CityId).HasColumnName("cityId");

            propertyBuilder.HasData(
                new Property { Id = 1, Name = "Copacabana Palace", PricePerNight = 3420.00m, CityId = 1 },
                new Property { Id = 2, Name = "Adlon Kempinski Berlin", PricePerNight = 2343.00m, CityId = 2 },
                new Property { Id = 3, Name = "Hilton Port Moresby", PricePerNight = 1004.00m, CityId = 3 },
                new Property { Id = 4, Name = "Cheval Blanc Paris", PricePerNight = 18330.00m, CityId = 4 }
                );
        }
    }
}

using CardBrand.Domain;
using Microsoft.EntityFrameworkCore;

namespace CardBrand.Persistence.SeeData
{
    public static class Configuration
    {
        public static void InitData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<CardBrandModel>().HasData(
                        new CardBrandModel { Id = 1, Code = "Toyota", Name = "Toyota", Year = 2022 },
                        new CardBrandModel { Id = 2, Code = "Suzuki", Name = "Suzuki", Year = 2021 },
                        new CardBrandModel { Id = 3, Code = "Nissan", Name = "Nissan", Year = 2020 }

                  );
        }
    }
}

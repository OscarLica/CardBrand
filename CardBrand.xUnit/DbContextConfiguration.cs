using CardBrand.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CardBrand.xUnit
{
    public class DbContextConfiguration
    {
        public DbContextOptions<ApplicationDbContext> CreateNewContextOptions()
        {
            return new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
        }
    }
}

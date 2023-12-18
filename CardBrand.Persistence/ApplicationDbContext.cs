using CardBrand.Domain;
using CardBrand.Persistence.SeeData;
using Microsoft.EntityFrameworkCore;

namespace CardBrand.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        #region Entities
        public DbSet<CardBrandModel> CarBrands { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.InitData();
        }
    }
}

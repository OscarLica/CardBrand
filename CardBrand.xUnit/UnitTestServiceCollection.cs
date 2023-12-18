using CardBrand.Persistence;
using CardBrand.Service.Implements;
using Microsoft.EntityFrameworkCore;

namespace CardBrand.xUnit
{
    public class UnitTestServiceCollection
    {
        private DbContextOptions<ApplicationDbContext> _contextOptions;
        private ApplicationDbContext _context;
        private CardBrandService _service;
        public UnitTestServiceCollection()
        {
            _contextOptions = new DbContextConfiguration().CreateNewContextOptions();
            _context = new ApplicationDbContext(_contextOptions);
            _service = new CardBrandService(_context);
        }

        [Fact]
        public async Task InsertData()
        {
            var entity = await _service.Create(new Domain.CardBrandModel { 
                Id  = 0,
                Code = "TOYOTA",
                Name = "TOYTA",
                Year = 2022
            });
            Assert.True(entity.Id > 0);
        }

        [Fact]
        public async Task GetData()
        {
            var list = await _service.Get();
            Assert.NotNull(list);   
        }
    }
}
using CardBrand.Persistence;
using CardBrand.Service.Implements;
using Microsoft.EntityFrameworkCore;

namespace CardBrand.xUnit
{
    public class UnitTestServiceCollection
    {
        
        /// <summary>
        ///     ContextOptions
        /// </summary>
        private DbContextOptions<ApplicationDbContext> _contextOptions;

        /// <summary>
        ///     Contexto de base datos
        /// </summary>
        private ApplicationDbContext _context;

        /// <summary>
        ///     Servicio de cardbrand
        /// </summary>
        private CardBrandService _service;

        /// <summary>
        ///     Constructor base
        /// </summary>
        public UnitTestServiceCollection()
        {
            _contextOptions = new DbContextConfiguration().CreateNewContextOptions();
            _context = new ApplicationDbContext(_contextOptions);
            _service = new CardBrandService(_context);
        }

        /// <summary>
        ///     Prueba unitaria insert de registro
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        ///     Prueba unitaria consulta de datos
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetData()
        {
            var list = await _service.Get();
            Assert.NotNull(list);   
        }
    }
}
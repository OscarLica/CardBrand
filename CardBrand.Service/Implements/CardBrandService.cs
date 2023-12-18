using CardBrand.Domain;
using CardBrand.Persistence;
using CardBrand.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace CardBrand.Service.Implements
{
    public class CardBrandService : ICardBrandService
    {
        /// <summary>
        ///     context base de datos
        /// </summary>
        private ApplicationDbContext _context;

        /// <summary>
        ///     Constructor base
        /// </summary>
        /// <param name="context"></param>
        public CardBrandService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        ///     List <see cref="CardBrandModel"/>
        /// </summary>
        /// <returns></returns>
        public async Task<List<CardBrandModel>> Get()
            => await _context.CarBrands.ToListAsync();

        /// <summary>
        ///    inserta un nuevo registro
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<CardBrandModel> Create(CardBrandModel model)
        {
            await _context.CarBrands.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;

        }

    }
}

using CardBrand.Domain;

namespace CardBrand.Service.Interface
{
    public interface ICardBrandService
    {
        /// <summary>
        ///     Consulta listado de  cardbrands
        /// </summary>
        /// <returns></returns>
        Task<List<CardBrandModel>> Get();
    }
}

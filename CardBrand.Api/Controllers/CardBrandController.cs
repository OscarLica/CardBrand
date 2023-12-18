using CardBrand.Domain;
using CardBrand.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CardBrand.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardBrandController : ControllerBase
    {
        /// <summary>
        ///      servicio para entidad CardBrand
        /// </summary>
        private readonly ICardBrandService _service;

        /// <summary>
        ///     Constructor base
        /// </summary>
        /// <param name="service"></param>
        public CardBrandController(ICardBrandService service)
        {
            _service = service;
        }

        /// <summary>
        ///     endpoint que consulta listado de card brands
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<CardBrandModel>> Get()
            => await _service.Get();
    }
}

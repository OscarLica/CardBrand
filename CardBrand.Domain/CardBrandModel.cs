namespace CardBrand.Domain
{
    public class CardBrandModel
    {
        /// <summary>
        ///     primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     codigo interno del registro
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///     Nombre del registro
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     fecha de creación
        /// </summary>
        public int Year{ get; set; }
    }
}

namespace BestSportsStore.Web.Models.Shopping
{
    using Infrastructure.Mapping;
    using Data.Models;

    public class ShoppingCartViewModel : IMapFrom<ShoppingCart>
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string ProductIds { get; set; }

        public string Sizes { get; set; }

        public int ProductsCount { get; set; }
    }
}
namespace BestSportsStore.Web.Models.Orders
{
    using Data.Models;
    using Infrastructure.Mapping;
    using Product;
    using System.Collections.Generic;

    public class OrderViewModel : IMapFrom<Order>
    {
        public int Id { get; set; }

        public decimal TotalPrice { get; set; }

        public string ProductIds { get; set; }

        public string ProductSizes { get; set; }

        public string ProductTitles { get; set; }

        public string Sizes { get; set; }

        public ICollection<ProductViewModel> Products { get; set; }

    }
}
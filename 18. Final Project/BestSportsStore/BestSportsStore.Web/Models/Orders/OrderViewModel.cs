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

        public IList<ProductViewModel> Products { get; set; }

    }
}
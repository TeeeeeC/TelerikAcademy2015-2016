namespace BestSportsStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ShoppingCart
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string ProductIds { get; set; }

        public string Sizes { get; set; }

        public int ProductsCount { get; set; }
    }
}

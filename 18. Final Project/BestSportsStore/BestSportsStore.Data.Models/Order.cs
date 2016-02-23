namespace BestSportsStore.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Order
    {
        public int Id { get; set; }

        public decimal TotalPrice { get; set; }

        public string ProductIds { get; set; }

        public string ProductSizes { get; set; }

        public string ProductTitles { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}

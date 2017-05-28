namespace BestSportsStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Like
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
            
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}   

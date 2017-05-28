namespace BestSportsStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        private ICollection<SubCategory> subCategories;

        public Category()
        {
            this.subCategories = new HashSet<SubCategory>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        public virtual ICollection<SubCategory> SubCategories
        {
            get { return this.subCategories; }
            set { this.subCategories = value; }
        }
    }
}

namespace MoviesSystem.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        [Range(1940, 2016)]
        public short Year { get; set; }

        [Required]
        public string LeadingMaleRole { get; set; }

        [Required]
        public string LeadingFemaleRole { get; set; }

        [Required]
        [Range(16, 100)]
        public short AgeLeadingMaleRole { get; set; }

        [Required]
        [Range(16, 100)]
        public short AgeLeadingFemaleRole { get; set; }

        [Required]
        public string Studio { get; set; }

        [Required]
        public string StudioAddress { get; set; }
    }
}
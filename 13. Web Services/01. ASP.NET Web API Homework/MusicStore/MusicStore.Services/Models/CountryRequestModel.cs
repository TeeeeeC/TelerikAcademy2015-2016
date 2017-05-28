namespace MusicStore.Services.Models
{
    using MusicStore.Models;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    public class CountryRequestModel
    {
        public static Expression<Func<Country, CountryRequestModel>> FromCountry
        {
            get
            {
                return c => new CountryRequestModel
                {
                    Id = c.Id,
                    Name = c.Name
                };
            }
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
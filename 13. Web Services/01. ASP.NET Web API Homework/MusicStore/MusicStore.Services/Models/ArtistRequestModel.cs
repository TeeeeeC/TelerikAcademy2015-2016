namespace MusicStore.Services.Models
{
    using MusicStore.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq.Expressions;

    public class ArtistRequestModel
    {
        public static Expression<Func<Artist, ArtistRequestModel>> FromArtist
        {
            get
            {
                return a => new ArtistRequestModel
                {
                    Id = a.Id,
                    BirthDate = a.BirthDate,
                    CountryId = a.CountryId,
                    Name = a.Name
                };
            }
        }

        private ICollection<SongRequestModel> songs;

        public ArtistRequestModel()
        {
            this.songs = new HashSet<SongRequestModel>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual CountryRequestModel Country { get; set; }

        public int AlbumId { get; set; }

        [ForeignKey("AlbumId")]
        public virtual AlbumRequestModel Album { get; set; }

        public virtual ICollection<SongRequestModel> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }
    }
}
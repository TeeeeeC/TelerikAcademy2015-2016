namespace MusicStore.Services.Models
{
    using MusicStore.Models;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    public class SongRequestModel
    {
        public static Expression<Func<Song, SongRequestModel>> FromSong
        {
            get
            {
                return s => new SongRequestModel
                {
                    Id = s.Id,
                    Genre = (GenreTypeRequestModel)s.Genre,
                    Title = s.Title,
                    Year = s.Year
                };
            }
        }

        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Title { get; set; }

        [Required]
        [Range(1960, 2020)]
        public short Year { get; set; }

        public GenreTypeRequestModel Genre { get; set; }

        public int ArtistId { get; set; }

        public int AlbumId { get; set; }
    }
}
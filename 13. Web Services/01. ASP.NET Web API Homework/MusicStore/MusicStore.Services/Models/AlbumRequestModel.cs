namespace MusicStore.Services.Models
{
    using MusicStore.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    public class AlbumRequestModel
    {
        public static Expression<Func<Album, AlbumRequestModel>> FromAlbum
        {
            get
            {
                return a => new AlbumRequestModel
                {
                    Id = a.Id,
                    Producer = a.Producer,
                    Title = a.Title,
                    Year = a.Year
                };
            }
        }

        private ICollection<ArtistRequestModel> artists;
        private ICollection<SongRequestModel> songs;

        public AlbumRequestModel()
        {
            this.artists = new HashSet<ArtistRequestModel>();
            this.songs = new HashSet<SongRequestModel>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Title { get; set; }

        [Required]
        [Range(1960, 2020)]
        public short Year { get; set; }

        public string Producer { get; set; }

        public virtual ICollection<ArtistRequestModel> Artists
        {
            get { return this.artists; }
            set { this.artists = value; }
        }

        public virtual ICollection<SongRequestModel> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }
    }
}
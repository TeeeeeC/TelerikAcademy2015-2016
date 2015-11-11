namespace MusicStore.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Models;
    using MusicStore.Models;

    public class ArtistsController : ApiController
    {
        private IMusicStoreData data;

        public ArtistsController()
            : this(new MusicStoreData())
        {
        }

        public ArtistsController(IMusicStoreData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var artists = this.data
                .Artists
                .All()
                .Select(ArtistRequestModel.FromArtist);

            return Ok(artists);
        }

        [HttpGet]
        public IHttpActionResult ById(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbArtist = this.data
                .Artists
                .All()
                .FirstOrDefault(a => a.Id == id);
            if (dbArtist == null)
            {
                return BadRequest("Such artist does not exist in database!");
            }

            var artist = new ArtistRequestModel
            {
                BirthDate = dbArtist.BirthDate,
                CountryId = dbArtist.CountryId,
                Name = dbArtist.Name
            };

            artist.Id = dbArtist.Id;
            return Ok(artist);
        }

        [HttpPost]
        public IHttpActionResult Create(ArtistRequestModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingCountry = this.data
                .Countries
                .All()
                .FirstOrDefault(c => c.Id == artist.CountryId || c.Name == artist.Country.Name);
            if(existingCountry == null)
            {
                return BadRequest("Such country doen not exist in database!");
            }
                
            var newArtist = new Artist
            {
                BirthDate = artist.BirthDate,
                Country = existingCountry,
                Name = artist.Name
            };

            this.data.Artists.Add(newArtist);
            this.data.SaveChanges();

            artist.Id = newArtist.Id;

            return Ok(artist);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, ArtistRequestModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbArtist = this.data
                .Artists
                .All()
                .FirstOrDefault(a => a.Id == id);
            if (dbArtist == null)
            {
                return BadRequest("Such artist does not exist in database!");
            }

            artist.BirthDate = dbArtist.BirthDate;
            artist.CountryId = dbArtist.CountryId;
            artist.Name = dbArtist.Name;
            this.data.SaveChanges();

            artist.Id = id;
            return Ok(artist);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var dbArtist = this.data
                .Artists
                .All()
                .FirstOrDefault(a => a.Id == id);
            if (dbArtist == null)
            {
                return BadRequest("Such artist does not exist in database!");
            }

            this.data.Artists.Delete(dbArtist);
            this.data.SaveChanges();

            return Ok(id);
        }
    }
}

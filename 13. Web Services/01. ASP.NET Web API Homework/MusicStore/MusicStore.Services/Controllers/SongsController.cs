namespace MusicStore.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Models;
    using MusicStore.Models;

    public class SongsController : ApiController
    {
        private IMusicStoreData data;

        public SongsController()
            : this(new MusicStoreData())
        {
        }

        public SongsController(IMusicStoreData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var songs = this.data
                .Songs
                .All()
                .Select(SongRequestModel.FromSong);

            return Ok(songs);
        }

        [HttpGet]
        public IHttpActionResult ById(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbSong = this.data
                .Songs
                .All()
                .FirstOrDefault(s => s.Id == id);
            if (dbSong == null)
            {
                return BadRequest("Such song does not exist in database!");
            }

            var song = new SongRequestModel
            {
                Genre = (GenreTypeRequestModel)dbSong.Genre,
                Title = dbSong.Title,
                Year = dbSong.Year
            };

            return Ok(song);
        }

        [HttpPost]
        public IHttpActionResult Create(SongRequestModel song)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newSong= new Song
            {
                Genre = (GenreType)song.Genre,
                Title = song.Title,
                Year = song.Year
            };

            this.data.Songs.Add(newSong);
            this.data.SaveChanges();

            song.Id = newSong.Id;

            return Ok(song);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, SongRequestModel song)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbSong = this.data
                .Songs.All()
                .FirstOrDefault(s => s.Id == id);
            if (dbSong == null)
            {
                return BadRequest("Such song does not exist in database!");
            }

            dbSong.Genre = (GenreType)song.Genre;
            dbSong.Title = song.Title;
            dbSong.Year = song.Year;
            this.data.SaveChanges();

            song.Id = id;
            return Ok(song);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var dbSong = this.data
                .Songs
                .All()
                .FirstOrDefault(s => s.Id == id);
            if (dbSong == null)
            {
                return BadRequest("Such song does not exist in database!");
            }

            this.data.Songs.Delete(dbSong);
            this.data.SaveChanges();

            return Ok(id);
        }
    }
}

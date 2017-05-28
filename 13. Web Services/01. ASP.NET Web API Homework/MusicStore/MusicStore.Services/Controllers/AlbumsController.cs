namespace MusicStore.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Models;
    using MusicStore.Models;

    public class AlbumsController : ApiController
    {
        private IMusicStoreData data;

        public AlbumsController()
            : this(new MusicStoreData())
        {
        }

        public AlbumsController(IMusicStoreData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var albums = this.data
                .Albums
                .All()
                .Select(AlbumRequestModel.FromAlbum);

            return Ok(albums);
        }

        [HttpGet]
        public IHttpActionResult ById(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbAlbum = this.data
                .Albums
                .All()
                .FirstOrDefault(a => a.Id == id);
            if (dbAlbum == null)
            {
                return BadRequest("Such album does not exist in database!");
            }

            var album = new AlbumRequestModel
            {
                Producer = dbAlbum.Producer,
                Title = dbAlbum.Title,
                Year = dbAlbum.Year
            };

            album.Id = dbAlbum.Id;
            return Ok(album);
        }

        [HttpPost]
        public IHttpActionResult Create(AlbumRequestModel album)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newAlbum = new Album
            {
                Producer = album.Producer,
                Title = album.Title,
                Year = album.Year
            };

            this.data.Albums.Add(newAlbum);
            this.data.SaveChanges();

            album.Id = newAlbum.Id;

            return Ok(album);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, AlbumRequestModel album)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbAlbum = this.data
                .Albums.All()
                .FirstOrDefault(a => a.Id == id);
            if (dbAlbum == null)
            {
                return BadRequest("Such album does not exist in database!");
            }

            album.Producer = dbAlbum.Producer;
            album.Title = dbAlbum.Title;
            album.Year = dbAlbum.Year;
            this.data.SaveChanges();

            album.Id = id;
            return Ok(album);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var dbAlbum = this.data
                .Albums
                .All()
                .FirstOrDefault(a => a.Id == id);
            if (dbAlbum == null)
            {
                return BadRequest("Such album does not exist in database!");
            }

            this.data.Albums.Delete(dbAlbum);
            this.data.SaveChanges();

            return Ok(id);
        }
    }
}

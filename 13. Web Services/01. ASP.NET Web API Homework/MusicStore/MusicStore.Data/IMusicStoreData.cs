namespace MusicStore.Data
{
    using Models;
    using Repositories;

    public interface IMusicStoreData
    {
        IRepository<Album> Albums { get; }

        IRepository<Artist> Artists { get; }

        IRepository<Song> Songs { get; }

        IRepository<Country> Countries { get; }

        void SaveChanges();
    }
}

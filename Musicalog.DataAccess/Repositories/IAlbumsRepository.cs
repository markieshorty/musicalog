using Musicalog.Models;

namespace Musicalog.DataAccess.Repositories
{
    public interface IAlbumsRepository
    {
        public int InsertAlbum(Album album);
    }
}
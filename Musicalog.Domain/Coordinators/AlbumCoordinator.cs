using Musicalog.DataAccess.Repositories;
using Musicalog.Models;

namespace Musicalog.Domain.Coordinators
{
    public class AlbumCoordinator : IAlbumCoordinator
    {
        private readonly IAlbumsRepository _albumRepository;
        public AlbumCoordinator(IAlbumsRepository albumsRepository)
        {
            _albumRepository = albumsRepository;
        }
            
        public Album InsertAlbum(Album album)
        {
            // todo might need to do some business logic here...
            var id = _albumRepository.InsertAlbum(album);
            album.AlbumId = id;
            return album;
        }
    }
}

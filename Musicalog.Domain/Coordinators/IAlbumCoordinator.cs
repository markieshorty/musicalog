using Musicalog.Models;

namespace Musicalog.Domain.Coordinators
{
    public interface IAlbumCoordinator
    {
        Album InsertAlbum(Album album);
    }
}
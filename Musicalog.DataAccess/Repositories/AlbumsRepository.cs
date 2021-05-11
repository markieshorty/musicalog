using Dapper;
using Musicalog.Models;
using System.Data;
using System.Data.SqlClient;

namespace Musicalog.DataAccess.Repositories
{
    public class AlbumsRepository : IAlbumsRepository
    {
        private const string _connectionString = @"Server=tcp:musicalog.database.windows.net,1433;Initial Catalog=Musicalog;Persist Security Info=False;User ID=demo;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public int InsertAlbum(Album album)
        {
            const string sproc_name = "Insert_Album";

            using (var connection = new SqlConnection(_connectionString))
            {
                var affectedRows = connection.Execute(sproc_name,
                    new { @albumName = album.AlbumName, @artist = album.Artist, @physicalType = album.PhysicalType, @stock = album.Stock, @recordLabel = album.RecordLabel  },
                    commandType: CommandType.StoredProcedure);
                return affectedRows;
            }
        }
    }
}

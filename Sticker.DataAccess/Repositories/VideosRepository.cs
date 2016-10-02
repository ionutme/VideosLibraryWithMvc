using System.Data.Entity;
using Sticker.DataAccess.Entities;

namespace Sticker.DataAccess.Repositories
{
    public class VideosRepository : Repository<Video>
    {
        public VideosRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
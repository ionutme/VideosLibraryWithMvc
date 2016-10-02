using System.Data.Entity;
using Sticker.DataAccess.Entities;

namespace Sticker.DataAccess.Repositories
{
    public class CommentsRepository : Repository<Comment>
    {
        public CommentsRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
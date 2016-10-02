using System.Data.Entity;
using Sticker.DataAccess.Repositories;

namespace Sticker.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
            VideosRepository = new VideosRepository(dbContext);
            CommentsRepository = new CommentsRepository(dbContext);
        }

        public VideosRepository VideosRepository { get; }
        public CommentsRepository CommentsRepository { get; }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
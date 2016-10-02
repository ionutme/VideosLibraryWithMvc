using System;
using Sticker.DataAccess.Repositories;

namespace Sticker.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        VideosRepository VideosRepository { get; }
        CommentsRepository CommentsRepository { get; }
        int Complete();
    }
}
using System.Data.Entity;
using Sticker.DataAccess.Entities;

namespace Sticker.DataAccess
{
    public class StickerDb : DbContext
    {
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        public StickerDb() : base(nameof(StickerDb))
        {
            Configuration.LazyLoadingEnabled = false;
        }
    }
}

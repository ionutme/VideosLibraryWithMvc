using System.Collections.Generic;

namespace Sticker.DataAccess.Entities
{
    public class Video : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
namespace Sticker.DataAccess.Entities
{
    public class Comment : Entity
    {
        public string Body { get; set; }
        public int VideoId { set; get; }
    }
}
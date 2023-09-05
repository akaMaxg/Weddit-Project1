namespace Weddit_Project1.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CommentTime { get; set; }


        public string UserId { get; set; }
        public Users User { get; set; }
    }
}

namespace Weddit_Project1.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostTime { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public Users User { get; set; }

        public int TopicId { get; set; }
        public Topics Topics { get; set; }
    }
}

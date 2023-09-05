using Microsoft.Extensions.Hosting;

namespace Weddit_Project1.Models
{
    public class Topics
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Posts> Posts { get; set; }
    }
}

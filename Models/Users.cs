using Microsoft.Extensions.Hosting;
using System.Xml.Linq;

namespace Weddit_Project1.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }


        public ICollection<Comments> Comments { get; set; }
        public ICollection<Posts> Posts { get; set; }
    }
}

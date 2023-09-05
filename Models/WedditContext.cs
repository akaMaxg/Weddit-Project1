using Microsoft.EntityFrameworkCore;

namespace Weddit_Project1.Models
{
    public class WedditContext : DbContext
    {
        public WedditContext(DbContextOptions<WedditContext> options) : base(options) { }
        public DbSet<Topics> Topics { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }
    }
}

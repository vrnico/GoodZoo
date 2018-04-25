

using Microsoft.EntityFrameworkCore;

namespace GoodZoo.Models
{
    public class GoodZooContext : DbContext
    {
        public GoodZooContext()
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=goodzoo;uid=root;pwd=root;");
        }

        public GoodZooContext(DbContextOptions<GoodZooContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

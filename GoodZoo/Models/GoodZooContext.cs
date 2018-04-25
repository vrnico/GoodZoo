

using Microsoft.EntityFrameworkCore;

namespace GoodZoo.Models
{
    public class GoodZooContext : DbContext
    {
        public GoodZooContext()
        {
        }

        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Vet> Vets { get; set; }

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

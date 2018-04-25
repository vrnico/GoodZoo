using Microsoft.EntityFrameworkCore;

namespace GoodZoo.Models
{
    public class TestDbContext : GoodZooContext
    {
        public override DbSet<Animal> Animals { get; set; }
        public override DbSet<Vet> Vets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;database=goodzoo_test;uid=root;pwd=root;");
        }
    }
}
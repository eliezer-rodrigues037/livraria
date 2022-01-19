using livraria.api.Buisness.Entities;
using livraria.api.Infrastructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace livraria.api.Infrastructure.Data
{
    public class LivroDbContext : DbContext
    {
        public DbSet<Livro> Livro { get; set; }

        public LivroDbContext(DbContextOptions<LivroDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}

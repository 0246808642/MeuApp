using Microsoft.EntityFrameworkCore;
using MeuApp.Domain.Entity;
using MeuApp.Data.Mappings;

namespace MeuApp.Data.Context
{ 
    
    public class MeuAppDbContext: DbContext
    {

        public MeuAppDbContext(DbContextOptions<MeuAppDbContext> opcoes) : base(opcoes) { }

        DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Client>(new ClientMap().Configure);
        }
    }

}

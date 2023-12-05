
namespace MeuApp.Data.Context
{
    public class MeuAppContext
    {
        public MeuAppContext(DbContextOptions<MeuAppContext> opcoes) : base(opcoes) { }

        DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Client>(new ClientMap().Configure);
        
        }
    }
}

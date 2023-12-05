using MeuApp;
using MeuApp.Data.Repository.Base;
using MeuApp.Domain.Interfaces.Repository;

namespace MeuApp.Data.Repository
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
      public ClientRepository(MeuAppDbContext meuAppDbContext) : base(meuAppDbContext)
        {

        }

        public IQueryable<Client> GetAllActive(Situations pSituations)
        {
            var result = GetAll(c=> c.Situations == pSituations);
            return result;
        }


    }
}

using MeuApp.Data.Context;
using MeuApp.Data.Repository.Base;
using MeuApp.Domain.Entity;
using MeuApp.Domain.Enum;
using MeuApp.Domain.Interfaces.Repository;

namespace MeuApp.Data.Repository
{

    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(MeuAppDbContext _pMeuAppDbContext) : base(_pMeuAppDbContext) { }

        public IQueryable<Client> GetAllActive(Situations pSituations)
        {
            var result = GetAll(c => c.Situations == pSituations);
            return result;
        }
    }


}
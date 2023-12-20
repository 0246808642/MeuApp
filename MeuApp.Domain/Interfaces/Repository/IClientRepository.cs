using MeuApp.Domain.Interfaces.Repository.Base;
using MeuApp.Domain.Enum;
using MeuApp.Domain.Entity;

namespace MeuApp.Domain.Interfaces.Repository
{
    public interface IClientRepository:IRepositoryBase<Client>
    {
        IQueryable<Client> GetAllActive(Situations pSituations);
    }
}

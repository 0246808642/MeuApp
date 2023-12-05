using MeuApp.Domain.Enum;
using MeuApp.Domain.Interfaces.Repository.Base;

namespace MeuApp.Domain.Interfaces.Repository
{
    public interface IClientRepository:IRepositoryBase<Client>
    {
        IQueryable<Client> GetAllActive(Situations pSituations);
    }
}

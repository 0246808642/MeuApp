using MeuApp.Domain.Entity;
using MeuApp.Domain.Enum;
using MeuApp.Domain.Interfaces.Base;

namespace MeuApp.Domain.Interfaces.Base
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        IQueryable<Cliente> GetAllActive(Situations pSituations);
    }
}

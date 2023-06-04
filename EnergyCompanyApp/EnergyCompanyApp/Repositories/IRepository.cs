using EnergyCompanyApp.Entities;

namespace EnergyCompanyApp.Repositories
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
        where T: class, IEntity
    {
    }
}

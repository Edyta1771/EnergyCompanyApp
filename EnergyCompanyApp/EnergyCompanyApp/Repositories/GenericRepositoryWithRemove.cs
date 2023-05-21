using EnergyCompanyApp.Entities;

namespace EnergyCompanyApp.Repositories
{
    public class GenericRepositoryWithRemove<T> : GenericRepository<T> where T : IEntity
    {
        public void Remove (T item) 
        {
            _items.Remove (item);
        }
    }
}

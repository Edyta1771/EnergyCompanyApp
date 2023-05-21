using EnergyCompanyApp.Entities;

namespace EnergyCompanyApp.Repositories
{
    public class GenericRepository<T> where T : IEntity
    {
        public readonly List<T> _items = new();

        protected void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

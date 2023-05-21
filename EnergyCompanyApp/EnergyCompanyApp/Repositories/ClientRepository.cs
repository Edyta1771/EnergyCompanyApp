using EnergyCompanyApp.Entities;

namespace EnergyCompanyApp.Repositories
{
    public class ClientRepository
    {
        public readonly List<Client>  _clients = new();

        public void Add(Client client) 
        {
            client.Id = _clients.Count + 1;
            _clients.Add(client);
        }

        public void Save()
        {
            foreach (var client in _clients)
            {
                Console.WriteLine(client);
            }
        }

        public Client GetById(int id) 
        {
            return _clients.Single(item => item.Id == id);        
        }
    }
}

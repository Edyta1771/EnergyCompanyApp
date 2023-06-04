using EnergyCompanyApp.Data;
using EnergyCompanyApp.Entities;
using EnergyCompanyApp.Repositories;

var employeeRepository = new SqlRepository<Employee>(new EnergyCompanyAppDbContext());
var clientRepository = new SqlRepository<Client>(new EnergyCompanyAppDbContext());
AddEmployees(employeeRepository);
AddManagers(employeeRepository);
AddClients(clientRepository);
Console.WriteLine("Employees:");
WriteAllToConsole(employeeRepository);
Console.WriteLine("\nClients:");
WriteAllToConsole(clientRepository);

static void AddEmployees(IRepository<Employee> employeeRepository) 
{
    employeeRepository.Add(new Employee { FirstName = "Alex", LastName = "Barecki", Branch = "Olsztyn" });
    employeeRepository.Add(new Employee { FirstName = "Barbara", LastName = "Koliczko", Branch = "Gdańsk" });
    employeeRepository.Add(new Employee { FirstName = "Sylwester", LastName = "Miszczyk", Branch = "Elbląg" });
    employeeRepository.Save();
}

static void AddManagers(IWriteRepository<Manager> managerRepository)
{
    managerRepository.Add(new Manager { FirstName = "Waldemar", LastName = "Powalski", Branch = "Olsztyn" });
    managerRepository.Add(new Manager { FirstName = "Małgorzata", LastName = "Sudowiec", Branch = "Ostróda" });
    managerRepository.Save();
}

static void AddClients(IRepository<Client> clientRepository)
{
    clientRepository.Add(new Client { FirstName = "Edward", LastName = "Woźny", Branch = "Olsztyn" });
    clientRepository.Add(new Client { FirstName = "Marzena", LastName = "Lotnicka", Branch = "Gdańsk" });
    clientRepository.Add(new Client { FirstName = "Monika", LastName = "Sasin", Branch = "Pasłęk" });
    clientRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository) 
{ 
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

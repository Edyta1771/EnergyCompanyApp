using EnergyCompanyApp.Entities;
using EnergyCompanyApp.Repositories;

var employeeRepository = new EmployeeRepository();
employeeRepository.Add(new Employee { FirstName = "Adam" });
employeeRepository.Add(new Employee { FirstName = "Piotr" });
employeeRepository.Add(new Employee { FirstName = "Zuzia" });
employeeRepository.Save();

var clientRepository = new ClientRepository();
clientRepository.Add(new Client { FirstName = "Edyta" });
clientRepository.Add(new Client { FirstName = "Agnieszka" });
clientRepository.Add(new Client { FirstName = "Jacek" });
clientRepository.Save();

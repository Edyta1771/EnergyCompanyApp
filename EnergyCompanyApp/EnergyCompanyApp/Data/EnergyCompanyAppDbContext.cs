using EnergyCompanyApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnergyCompanyApp.Data
{     
    public class EnergyCompanyAppDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<Client> Clients => Set<Client>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}

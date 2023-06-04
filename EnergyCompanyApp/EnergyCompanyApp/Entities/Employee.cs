namespace EnergyCompanyApp.Entities
{
    public class Employee : EntityBase
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Branch { get; set; }

        public override string ToString() => $"Id: {Id}\t FirstName: {FirstName}\t LastName: {LastName}\t Branch: {Branch}";
    }
}

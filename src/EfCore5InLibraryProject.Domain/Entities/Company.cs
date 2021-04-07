using System.Collections.Generic;

namespace EfCore5InLibraryProject.Domain.Entities
{
    public class Company : Entity
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public IReadOnlyList<Customer> Customers => _customers.AsReadOnly();
        private List<Customer> _customers;

        public Company(string name, string number)
        {
            Name = name;
            Number = number;
            _customers = new List<Customer>();
        }
    }
}

using System;

namespace EfCore5InLibraryProject.Domain.Entities
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public long RegisterNumber { get; set; }
        public string Phone { get; set; }
        public Company Company { get; set; }

        public Customer(string name, long registerNumber, string phone)
        {
            Name = name;
            RegisterNumber = registerNumber;
            Phone = phone;
        }
    }
}

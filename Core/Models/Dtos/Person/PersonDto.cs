using System;

namespace Core.Models.Dtos.Person
{
    public class PersonDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Oib { get; set; }

        public bool IsCommercialist { get; set; }
        public bool IsController { get; set; }

        public Guid? UserId { get; set; }
    }
}

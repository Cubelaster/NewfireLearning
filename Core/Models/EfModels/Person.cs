using Core.Models.EfModels.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.EfModels
{
    public class Person : DatabaseEntity<int>
    {
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(40)]
        public string Mobile { get; set; }
        [StringLength(40)]
        public string Phone { get; set; }
        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(40)]
        public string Oib { get; set; }

        public Guid? UserId { get; set; }
        public User User { get; set; }
    }
}

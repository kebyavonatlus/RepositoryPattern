using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("owener")]
    public class Owner
    {
        public Guid OwnerID { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public ICollection<Account> Accounts { get; set; }

    }
}
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("account")]
    public class Account
    {
        public Guid AccountId { get; set; }
        public DateTime DateCreate { get; set; }

        public string AccountType { get; set; }

        [ForeignKey(nameof(Owner))]
        public Guid OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
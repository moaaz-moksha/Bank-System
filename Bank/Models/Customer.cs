using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? EmailAddress { get; set;}
        [Length(11,11)]
        public string? PhoneNumber { get; set; }

        public List<Branch>? Branches { get; set; }

        public List<Account>? Account { get; set; }

        public BankCard? BankCard { get; set; }
    }
}

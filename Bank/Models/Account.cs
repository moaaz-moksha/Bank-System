using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string? AccountNumber { get; set; }
        [Required]
        [Range(0 , double.MaxValue ,ErrorMessage = "must be positive")]
        public decimal Balance { get; set; }
        public Customer? Customer { get; set; }
        public int? CustomerId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class BankCard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(11)]
        public string? CardNumber { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        public Customer? Customer { get; set; }

        public int? CustomerId { get; set; }
    }
}

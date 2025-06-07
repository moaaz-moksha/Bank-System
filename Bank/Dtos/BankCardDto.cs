using System.ComponentModel.DataAnnotations;

namespace Bank.Dtos
{
    public class BankCardDto
    {
        [Required]
        [StringLength(11)]
        public string CardNumber { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
    }

}

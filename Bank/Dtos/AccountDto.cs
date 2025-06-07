using System.ComponentModel.DataAnnotations;

namespace Bank.Dtos
{
    public class AccountDto
    {
        [Required]
        [MaxLength(20)]
        public string AccountNumber { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "must be positive")]
        public decimal Balance { get; set; }
    }


    public class AccountDtoPost
    {
        [Required]
        [MaxLength(20)]
        public string AccountNumber { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "must be positive")]
        public decimal Balance { get; set; }
        public int CustomerId { get; set; }
    }
}

using Bank.Models;
using System.ComponentModel.DataAnnotations;

namespace Bank.Dtos
{
    public class CustomerDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Length(11, 11)]
        public string PhoneNumber { get; set; }

        public List<BranchDto>  branchDtos { get; set; }
        public List<AccountDto>  accountDtos { get; set; }

        public BankCardDto  BankCardDto { get; set; }
    }

    public class CustomerDtoGetById
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Length(11, 11)]
        public string PhoneNumber { get; set; }

        public List<BranchDto> branchDtos { get; set; }
        

        public BankCardDto BankCardDto { get; set; }
    }


    public class CustomerDtoPPPPP
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Length(11, 11)]
        public string PhoneNumber { get; set; }
    }


    public class CustomerDtoGetAll
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Length(11, 11)]
        public string PhoneNumber { get; set; }
        public List<AccountDto>  accountDtos { get; set; }
    }
}

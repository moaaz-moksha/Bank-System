using Bank.Models;
using System.ComponentModel.DataAnnotations;

namespace Bank.Dtos
{
    public class BranchDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
    }


    public class BranchDtoPost
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        public List<CustomerDtoPPPPP>  customerDtoPPPPPs { get; set; }
    }


    public class BranchDtoGetAll
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        public List<CustomerDtoGetAll>  customerDtoGetAlls { get; set; }
    }


    public class BranchDtoUpdate
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<int> CustomerIds { get; set; }  
    }

}

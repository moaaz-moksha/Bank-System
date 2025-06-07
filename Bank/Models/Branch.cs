using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        [Required]
        public string? Location { get; set; }
       
        public List<Customer>? customers { get; set; }
    }
}

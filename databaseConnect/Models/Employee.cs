using System.ComponentModel.DataAnnotations;

namespace databaseConnect.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        public string? Address { get; set; }

        [Required]
        public long PhoneNo { get; set; }
    }
}

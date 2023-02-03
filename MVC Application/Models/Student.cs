using System.ComponentModel.DataAnnotations;

namespace MVC_Application.Models
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

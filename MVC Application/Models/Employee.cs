using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVC_Application.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }    
        public string Department { get; set; }
        public string Address { get; set; } 
        public double Salary { get; set; }
    }
}

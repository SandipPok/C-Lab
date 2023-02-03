using databaseConnect.Repository;
using Microsoft.AspNetCore.Mvc;
using databaseConnect.Models;

namespace databaseConnect.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepo empRepo = new EmployeeRepo();
        public IActionResult Index()
        {
            IEnumerable<Employee> employees = empRepo.GetEmployees();
            return View(employees);
        }
        [HttpGet]
        public IActionResult CreateEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmployee(Employee emp)
        {
            try
            {
                empRepo.AddEmployee(emp);
                return Content("Data has been inserted successfully!");
            }
            catch (Exception ex)
            {
                return Content("OOPS!" + ex.Message);
            }
        }
    }
}

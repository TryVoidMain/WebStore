using Microsoft.AspNetCore.Mvc;

using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Vasya", Patronymic = "Vasilyevich", Age = 21 },
            new Employee { Id = 2, LastName = "Петров", FirstName = "Альтаир", Patronymic = "Андреевич", Age = 29 },
            new Employee { Id = 3, LastName = "Васечкин", FirstName = "Агрегат", Patronymic = "Рашидович", Age = 32 }

        };
        public IActionResult Index()
        {
            return View(_Employees);
        }

        public IActionResult Details(int Id)
        {
            var employee = _Employees.FirstOrDefault(e => e.Id == Id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }
    }
}

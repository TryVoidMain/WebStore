using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Vasya", Patronymic = "Vasilyevich", Age = 21 },
            new Employee { Id = 2, LastName = "Петров", FirstName = "Альтаир", Patronymic= "Андреевич", Age = 29},
            new Employee { Id = 3, LastName = "Васечкин", FirstName = "Агрегат", Patronymic = "Рашидович", Age = 32}

        };

        public readonly IConfiguration _Configuration;
        public HomeController(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContentString(string Id = "-id-")
        {
            return Content($"content: {Id}");
        }

        public IActionResult ConfigStr()
        {
            return Content($"content {_Configuration["ServerGreetings"]}");
        }

        public IActionResult Employees()
        {
            return View(_Employees);
        }
    }
}

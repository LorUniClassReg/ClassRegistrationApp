using Microsoft.AspNetCore.Mvc;
using LorUClassRegistrationApp.Data;
using LorUClassRegistrationApp.Models;

namespace LorUClassRegistrationApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}

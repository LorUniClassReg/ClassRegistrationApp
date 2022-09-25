using LorUClassRegistrationApp.Data;
using LorUClassRegistrationApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LorUClassRegistrationApp.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TeacherController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Class> objClassList = _db.Classes.ToList();
            return View(objClassList);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Data;
using System.Linq;

namespace LibraryManagementSystem.Controllers
{
    public class UsersController : Controller
    {
        private readonly LibraryDbContext _context;

        public UsersController(LibraryDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList(); // Fetch all users from DB
            return View(users);
        }
    }
}

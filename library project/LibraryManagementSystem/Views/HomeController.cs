using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace LibraryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryDbContext _context;

        public HomeController(LibraryDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // Find the user
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            
            if (user == null || user.PasswordHash != password) // Replace this if using password hashing
            {
                TempData["ErrorMessage"] = "Invalid credentials. Please try again.";
                return RedirectToAction("Index"); // Redirect to login page
            }

            // Store user role in session (fallback to "Guest" if null)
            HttpContext.Session.SetString("UserRole", user.Role ?? "Guest");

            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard()
        {
            // Fetch books for display (non-editable)
            var books = _context.Books.ToList();
            return View(books);
        }
        public IActionResult Index()
        {
        return View();
        }

    }
}

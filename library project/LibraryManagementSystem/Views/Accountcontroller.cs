using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibraryManagementSystem.Data; // Updated namespace
using LibraryManagementSystem.Models; // Ensure models are correctly referenced

namespace LibraryManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly LibraryDbContext _context;  // Inject the database context

        public AccountController(LibraryDbContext context)
        {
            _context = context;
        }

        [HttpPost]
public IActionResult Login(string email, string password)
{
    var user = _context.Users.FirstOrDefault(u => u.Email == email && u.PasswordHash == password);

    if (user != null)
    {
        return RedirectToAction("Dashboard");
    }

    // ✅ Use TempData instead of ViewData
    TempData["LoginError"] = "Invalid email or password.";
    
    return RedirectToAction("Login"); // Redirect to refresh the view
}

    }
}

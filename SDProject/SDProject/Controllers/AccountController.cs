using Microsoft.AspNetCore.Mvc;
using SDProject.Data;
using SDProject.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SDProject.Controllers.Inspector
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Startup");
        }
        public IActionResult Startup()
        {
            var name = HttpContext.Session.GetString("Name");
            if (string.IsNullOrEmpty(name))
            {
                return View();
            }
            return View();
        }
        public IActionResult AsAdmin()
        {
            return View( );
        }
       
        // Specified to the Admin.
        [HttpGet]
        public IActionResult Login()
        {
            return View(new Login());
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login user)
        {
            if (ModelState.IsValid)
            {
                var result = await _context.Admins.FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);

                if (result != null)
                {
                    // Store user information in session
                    HttpContext.Session.SetString("UserEmail", result.Email);
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid email or password.");
                }
            }
            return View(user);
        }

        // To enable Admin to create new account.
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Admin user)
        {
            if(ModelState.IsValid)
            {
                _context.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            return View(user);
        }

        // Specified to the Inspector.
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(Login user)
        {
            if (ModelState.IsValid)
            {
                var result = await _context.Inspectors.FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);

                if (result != null)
                {
                    // Store user information in session
                    HttpContext.Session.SetString("UserEmail", result.Email);
                    return RedirectToAction("Index", "Inspector");
                }
                else
                {
                    return RedirectToAction("Signin");
                }
            }
            return View(user);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserEmail");
            return RedirectToAction("Index", "Home");
        }
    }
}
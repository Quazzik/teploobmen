using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using teploobmen.Data;

namespace teploobmen.Controllers
{
    public class LoginController : Controller
    {
        private readonly MyApplicationContext _context;

        public LoginController(ILogger<LoginController> logger, MyApplicationContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(string login, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

            if (user == null)
            {
                ModelState.AddModelError("invalidLoginOrPassword", "Неверный логин или пароль");
                return View();
            }
            await AuthenticateAsync(user);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(string login, string password)
        {
            var duplicate = _context.Users.Any(u => u.Login == login);
            if (duplicate) { ModelState.AddModelError("invalidLogin", "Это имя пользователя уже занято"); return View(); }
            if (password == null || login == null) { return View(); }
            var user = new User { Login = login, Password = password };

            _context.Users.Add(user);
            _context.SaveChanges();

            await AuthenticateAsync(user);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        private async Task AuthenticateAsync(User user)
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, user.Login) };
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
        }
    }
}

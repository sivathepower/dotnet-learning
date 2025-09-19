using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CookieWebSolution.Models;
using CookieWebSolution.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace CookieWebSolution.Controllers
{

    public class AuthController : Controller
    {
        private UserService userService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger, UserService _userService)
        {
            _logger = logger;
            userService = _userService;
        }

        //Synchronous Call
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var usr = userService.Validate(username, password);

            if (usr != null)
            {
                //Create a claims identity
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username)
            };
                var claimsIdentity = new ClaimsIdentity(claims,
                                                        CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                // Sign in the user
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
                return RedirectToAction("Welcome", "Home");
            }

            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }
    }
}
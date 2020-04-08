using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StackITmvc.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace StackITmvc.Models
{
    public class LoginController : Controller
    {
        private readonly SignInManager<User> signInManager;

        public LoginController(SignInManager<User> signInManager)
        {
            this.signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel User)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    User.Email, User.Password, User.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "Dashboard");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View();
        }
    }
}

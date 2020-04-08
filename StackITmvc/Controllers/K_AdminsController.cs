using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StackITmvc.Data;
using StackITmvc.Models;

namespace StackITmvc.Controllers
{
    [Authorize]
    public class K_AdminsController : Controller
    {
        private readonly StackItContext _context;
        private readonly UserManager<User> userManager;
        private readonly IPasswordHasher<User> passwordHasher;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole<int>> roleManager;

        public K_AdminsController(StackItContext context, 
                                  UserManager<User> userManager,
                                  IPasswordHasher<User> passwordHasher,
                                  SignInManager<User> signInManager,
                                  RoleManager<IdentityRole<int>> roleManager)
        {
            _context = context;
            this.userManager = userManager;
            this.passwordHasher = passwordHasher;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        //[Authorize (Roles = "StackIt")]
        // GET: K_Admins
        public IActionResult Index()
        {
            List<User> adminUsers = _context.Users.Where(x => x.AuthorizationLevel == AuthorizationLevel.K_Admin).Include(i => i.Company).ToList();
            return View(adminUsers);
        }

        // GET: K_Admins/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var k_Admin = await _context.Users
                .Include(k => k.Company)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (k_Admin == null)
            {
                return NotFound();
            }

            return View(k_Admin);
        }

        // GET: K_Admins/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CompanyName");
            return View();
        }

        // POST: K_Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( User k_Admin)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = k_Admin.Email,
                    Email = k_Admin.Email,
                    AuthorizationLevel = AuthorizationLevel.K_Admin,
                    FirstName = k_Admin.FirstName,
                    LastName = k_Admin.LastName,
                    CustomerId = k_Admin.CustomerId,
                    Password = k_Admin.Password,
                    PhoneNumber = k_Admin.PhoneNumber,
                    ConfirmPassword = k_Admin.ConfirmPassword,
                    PasswordHash = k_Admin.PasswordHash
                };

                var role = roleManager.Roles.SingleOrDefault(s => s.Name == "K_Admin");

                IdentityResult result = await userManager.CreateAsync(user, user.Password);
                if (result.Succeeded) { 
                    //Adds the role to the user in Identity
                    await userManager.AddToRoleAsync(user, role.Name);
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CompanyName", k_Admin.CustomerId);
            return View(k_Admin);
        }

        // GET: K_Admins/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var k_Admin = await _context.Users.FindAsync(id);
            if (k_Admin == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CompanyName", k_Admin.CustomerId);
            return View(k_Admin);
        }

        // POST: K_Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit
            (
                string id, 
                string email, 
                string password, 
                string firstName, 
                string lastName, 
                string phoneNumber, 
                [Bind("CustomerId")] User k_Admin
            )
        {
            User user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(email))
                    user.Email = email;
                else
                    ModelState.AddModelError("", "Email cannot be empty");

                if (!string.IsNullOrEmpty(email))
                    user.UserName = email;
                else
                    ModelState.AddModelError("", "User Name cannot be empty");

                if (!string.IsNullOrEmpty(password))
                {
                    user.PasswordHash = passwordHasher.HashPassword(user, password);
                    user.Password = password;
                    user.ConfirmPassword = password;
                } 
                else
                    ModelState.AddModelError("", "Password cannot be empty");

                if (!string.IsNullOrEmpty(firstName))
                    user.FirstName = firstName;
                else
                    ModelState.AddModelError("", "First Name cannot be empty");

                if (!string.IsNullOrEmpty(lastName))
                    user.LastName = lastName;
                else
                    ModelState.AddModelError("", "Last Name cannot be empty");

                if (!string.IsNullOrEmpty(phoneNumber))
                    user.PhoneNumber = phoneNumber;
                else
                    ModelState.AddModelError("", "Phone Number cannot be empty");

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CompanyName", k_Admin.CustomerId);
            return View(user);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        // GET: K_Admins/Delete/5
        public async Task<IActionResult> Delete(int id)
        {

            var k_Admin = await _context.Users
                .Include(k => k.Company)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (k_Admin == null)
            {
                return NotFound();
            }

            return View(k_Admin);
        }

        // POST: K_Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var k_Admin = await _context.Users.FindAsync(id);

            //fjern fra sub
            var adminSubscriptions = _context.UserSubscriptions.Where(i => i.UserId == id).SingleOrDefault();
            if(adminSubscriptions != null)
            {
                _context.UserSubscriptions.Remove(adminSubscriptions);
            }
            _context.Users.Remove(k_Admin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool K_AdminExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}

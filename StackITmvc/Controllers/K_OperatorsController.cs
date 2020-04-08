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
    public class K_OperatorsController : Controller
    {
        private readonly StackItContext _context;
        private readonly UserManager<User> userManager;
        private readonly IPasswordHasher<User> passwordHasher;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole<int>> roleManager;

        public K_OperatorsController(StackItContext context,
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
        //[Authorize (Roles = "StackIt, K_Admin")]
        // GET: K_Operators
        public IActionResult Index()
        {
            List<User> operationUsers = _context.Users.Where(x => x.AuthorizationLevel == AuthorizationLevel.K_Operator).Include(i => i.Company).ToList();
            return View(operationUsers);
        }

        // GET: K_Operators/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var k_Operator = await _context.Users
                .Include(k => k.Company)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (k_Operator == null)
            {
                return NotFound();
            }

            return View(k_Operator);
        }

        // GET: K_Operators/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CompanyName");
            return View();
        }

        // POST: K_Operators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( User k_Operator)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = k_Operator.Email,
                    Email = k_Operator.Email,
                    AuthorizationLevel = AuthorizationLevel.K_Operator,
                    FirstName = k_Operator.FirstName,
                    LastName = k_Operator.LastName,
                    CustomerId = k_Operator.CustomerId,
                    Password = k_Operator.Password,
                    PhoneNumber = k_Operator.PhoneNumber,
                    ConfirmPassword = k_Operator.ConfirmPassword,
                    PasswordHash = k_Operator.PasswordHash
                };

                var role = roleManager.Roles.SingleOrDefault(s => s.Name == "K_OPERATOR");

                IdentityResult result = await userManager.CreateAsync(user, user.Password);
                if (result.Succeeded) 
                {
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CompanyName", k_Operator.CustomerId);
            return View(k_Operator);
        }

        // GET: K_Operators/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var k_Operator = await _context.Users.FindAsync(id);
            if (k_Operator == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CompanyName", k_Operator.CustomerId);
            return View(k_Operator);
        }

        // POST: K_Operators/Edit/5
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
                [Bind("CustomerId")] User k_Operator
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CompanyName", k_Operator.CustomerId);
            return View(user);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        // GET: K_Operators/Delete/5
        public async Task<IActionResult> Delete(int id)
        {

            var k_Operator = await _context.Users
                .Include(k => k.Company)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (k_Operator == null)
            {
                return NotFound();
            }

            return View(k_Operator);
        }

        // POST: K_Operators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var k_Operator = await _context.Users.FindAsync(id);
            //fjern fra sub
            var adminSubscriptions = _context.UserSubscriptions.Where(i => i.UserId == id).SingleOrDefault();
            if (adminSubscriptions != null)
            {
                _context.UserSubscriptions.Remove(adminSubscriptions);
            }
            _context.Users.Remove(k_Operator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool K_OperatorExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}

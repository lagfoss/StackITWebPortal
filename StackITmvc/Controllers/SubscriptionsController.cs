using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StackITmvc.Data;
using StackITmvc.Models;
using StackITmvc.Models.StackItViewModels;

namespace StackITmvc.Controllers
{
    [Authorize]
    public class SubscriptionsController : Controller
    {
        private readonly StackItContext _context;

        public SubscriptionsController(StackItContext context)
        {
            _context = context;
        }

        // GET: Subscriptions
        public async Task<IActionResult> Index()
        {
            var stackItContext = _context.Subscription
                .Include(s => s.Company)
                .Include(s => s.UserSubscriptions)
                    .ThenInclude(s => s.User)
                .Include(s => s.Hardware)
                .Include(s => s.SubscriptionJobs)
                    .ThenInclude(s => s.Job);

            return View(await stackItContext.ToListAsync());
        }

        // GET: Subscriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription
                .Include(s => s.Company)
                .Include(s => s.UserSubscriptions)
                    .ThenInclude(s => s.User)
                .Include(s => s.Hardware)
                .Include(s => s.SubscriptionJobs)
                    .ThenInclude(s => s.Job)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.SubscriptionId == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // GET: Subscriptions/Create
        public IActionResult Create()
        {
            PopulateCompanyDropDownList();
            PopulateHardwareDropDownList();
            var subscription = new Subscription
            {
                UserSubscriptions = new List<UserSubscriptions>(),
                SubscriptionJobs = new List<SubscriptionJobs>()
            };
            PopulateAssignedUserData(subscription);
            PopulateAssignedJobData(subscription);
            return View();
        }

        // POST: Subscriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubscriptionId,SubscriptionName,CustomerId,HardwareId")] Subscription subscription, string[] selectedUsers, string[] selectedJobs)
        {
            if (selectedUsers != null)
            {
                subscription.UserSubscriptions = new List<UserSubscriptions>();
                foreach (var user in selectedUsers)
                {
                    var userToAdd = new UserSubscriptions { SubscriptionId = subscription.SubscriptionId, UserId = int.Parse(user) };
                    subscription.UserSubscriptions.Add(userToAdd);
                }
            }
            if (selectedJobs != null)
            {
                subscription.SubscriptionJobs = new List<SubscriptionJobs>();
                foreach (var job in selectedJobs)
                {
                    var jobToAdd = new SubscriptionJobs { SubscriptionId = subscription.SubscriptionId, JobId = int.Parse(job) };
                    subscription.SubscriptionJobs.Add(jobToAdd);
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(subscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            PopulateCompanyDropDownList(subscription.CustomerId);
            PopulateHardwareDropDownList(subscription.HardwareId);
            PopulateAssignedUserData(subscription);
            PopulateAssignedJobData(subscription);
            return View(subscription);
        }

        // GET: Subscriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription
                .Include(i => i.UserSubscriptions).ThenInclude(i => i.User)
                .Include(i => i.SubscriptionJobs).ThenInclude(i => i.Job)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.SubscriptionId == id);
            if (subscription == null)
            {
                return NotFound();
            }

            PopulateCompanyDropDownList(subscription.CustomerId);
            PopulateHardwareDropDownList(subscription.HardwareId);
            PopulateAssignedUserData(subscription);
            PopulateAssignedJobData(subscription);
            return View(subscription);
        }

        private void PopulateAssignedUserData(Subscription subscription)
        {
            var allUsers = _context.Users;
            var subscriptionUsers = new HashSet<int>(subscription.UserSubscriptions.Select(u => u.UserId.Value));
            var viewModel = new List<AssignedUserData>();
            foreach (var user in allUsers)
            {
                if(user.AuthorizationLevel.ToString().ToLower() != "stackit")
                {
                    var userRoleLevel = user.AuthorizationLevel;
                    viewModel.Add(new AssignedUserData
                    {
                        UserId = user.Id,
                        UserName = user.FullName,
                        Assigned = subscriptionUsers.Contains(user.Id),
                        UserLevel = userRoleLevel.ToString()
                    });
                }
            }
            ViewData["Users"] = viewModel;
        }

        private void PopulateAssignedJobData(Subscription subscription)
        {
            var allJobs = _context.Job;
            var subscriptionJobs = new HashSet<int>(subscription.SubscriptionJobs.Select(j => j.JobId));
            var viewModel = new List<AssignedJobData>();
            foreach (var job in allJobs)
            {
                viewModel.Add(new AssignedJobData
                {
                    JobId = job.JobId,
                    JobName = job.JobName,
                    Assigned = subscriptionJobs.Contains(job.JobId)
                });
            }
            ViewData["Jobs"] = viewModel;
        }

        // POST: Subscriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, string[] selectedUsers, string[] selectedJobs)
        {
            if (id == null)
            {
                return NotFound();
            }
            var subscriptionToUpdate = await _context.Subscription
                .Include(i => i.UserSubscriptions)
                    .ThenInclude(i => i.User)
                .Include(i => i.SubscriptionJobs)
                    .ThenInclude(i => i.Job)
                .FirstOrDefaultAsync(s => s.SubscriptionId == id);

            foreach (var adminSub in subscriptionToUpdate.UserSubscriptions)
            {
                bool containsUser = selectedUsers.Any(item => item == adminSub.UserId.ToString());
                if (!containsUser)
                {
                    subscriptionToUpdate.UserSubscriptions.Add(adminSub);
                }
            }

            if (await TryUpdateModelAsync<Subscription>(subscriptionToUpdate,
                "",
                s => s.SubscriptionName, s => s.CustomerId, s => s.HardwareId))
            {
                UpdateUserSubscriptions(selectedUsers, subscriptionToUpdate);
                UpdateSubscriptionJobs(selectedJobs, subscriptionToUpdate);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
                return RedirectToAction(nameof(Index));
            }
            PopulateCompanyDropDownList(subscriptionToUpdate.CustomerId);
            PopulateHardwareDropDownList(subscriptionToUpdate.HardwareId);
            UpdateUserSubscriptions(selectedUsers, subscriptionToUpdate);
            PopulateAssignedUserData(subscriptionToUpdate);
            UpdateSubscriptionJobs(selectedJobs, subscriptionToUpdate);
            PopulateAssignedJobData(subscriptionToUpdate);
            return View(subscriptionToUpdate);
        }
        private void PopulateCompanyDropDownList(object selectedCompany = null)
        {
            var companysQuery = from s in _context.Customer
                                   orderby s.CompanyName
                                   select s;
            ViewBag.CustomerId = new SelectList(companysQuery.AsNoTracking(), "CustomerId", "CompanyName", selectedCompany);
        }

        private void PopulateHardwareDropDownList(object selectedHardware = null)
        {
            var hardwaresQuery = from h in _context.Hardware
                                orderby h.HardwareName
                                select h;
            ViewBag.HardwareId = new SelectList(hardwaresQuery.AsNoTracking(), "HardwareId", "HardwareName", selectedHardware);
        }

        private void UpdateUserSubscriptions(string[] selectedUsers, Subscription subscriptionToUpdate)
        {
            if (selectedUsers == null)
            {
                subscriptionToUpdate.UserSubscriptions = new List<UserSubscriptions>();
                return;
            }

            var selectedUsersHS = new HashSet<string>(selectedUsers);
            var subscriptionUsers = new HashSet<int>
                (subscriptionToUpdate.UserSubscriptions.Select(u => u.User.Id));
            foreach (var user in _context.Users)
            {
                if (selectedUsersHS.Contains(user.Id.ToString()))
                {
                    if (!subscriptionUsers.Contains(user.Id))
                    {
                        subscriptionToUpdate.UserSubscriptions.Add(new UserSubscriptions { SubscriptionId = subscriptionToUpdate.SubscriptionId, UserId = user.Id });
                    }
                }
                else
                {
                    if (subscriptionUsers.Contains(user.Id))
                    {
                        UserSubscriptions userToRemove = subscriptionToUpdate.UserSubscriptions.FirstOrDefault(i => i.UserId == user.Id);
                        _context.Remove(userToRemove);
                    }
                }
            }
        }

        private void UpdateSubscriptionJobs(string[] selectedJobs, Subscription subscriptionToUpdate)
        {
            if (selectedJobs == null)
            {
                subscriptionToUpdate.SubscriptionJobs = new List<SubscriptionJobs>();
                return;
            }

            var selectedJobsHS = new HashSet<string>(selectedJobs);
            var subscriptionJobs = new HashSet<int>
                (subscriptionToUpdate.SubscriptionJobs.Select(j => j.Job.JobId));
            foreach (var job in _context.Job)
            {
                if (selectedJobsHS.Contains(job.JobId.ToString()))
                {
                    if (!subscriptionJobs.Contains(job.JobId))
                    {
                        subscriptionToUpdate.SubscriptionJobs.Add(new SubscriptionJobs { SubscriptionId = subscriptionToUpdate.SubscriptionId, JobId = job.JobId });
                    }
                }
                else
                {
                    if (subscriptionJobs.Contains(job.JobId))
                    {
                        SubscriptionJobs jobToRemove = subscriptionToUpdate.SubscriptionJobs.FirstOrDefault(i => i.JobId == job.JobId);
                        _context.Remove(jobToRemove);
                    }
                }
            }
        }

        // GET: Subscriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription
                .Include(s => s.Company)
                .Include(s => s.Hardware)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.SubscriptionId == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // POST: Subscriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adminSubs = _context.UserSubscriptions.Where(i => i.SubscriptionId == id).ToList();
            _context.UserSubscriptions.RemoveRange(adminSubs);
            var subscription = await _context.Subscription.FindAsync(id);
            _context.Subscription.Remove(subscription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubscriptionExists(int id)
        {
            return _context.Subscription.Any(e => e.SubscriptionId == id);
        }
    }
}

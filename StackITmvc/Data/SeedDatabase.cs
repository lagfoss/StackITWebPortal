using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StackITmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackITmvc.Data
{
    public class SeedDatabase
    {
        public static void CreateCustomer(IServiceProvider serviceProvider)
        {
            using var context = new StackItContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<StackItContext>>());
            if (context.Customer.Any())
            {
                return;
            }

            context.Customer.AddRange(
                new Customer
                {
                    CompanyName = "StackIt",
                    VAT = " DK40558195",
                    StreetName = "Sivlandvaenget",
                    StreetNo = "3, 1.",
                    PostalCode = "5260",
                    City = "Odense",
                    Country = "Denmark",
                    PhoneNo = "+45 60 19 14 80",
                    Email = "info@stackit.eu"
                }
            );
            context.SaveChanges();
        }


        public async static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<StackItContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();
            context.Database.EnsureCreated();
            if (!context.Roles.Any())
            {
                var roles = new List<IdentityRole<int>>
                {
                    new IdentityRole<int>(AuthorizationLevel.StackIt.ToString()),
                    new IdentityRole<int>(AuthorizationLevel.K_Admin.ToString()),
                    new IdentityRole<int>(AuthorizationLevel.K_Operator.ToString()),
                    new IdentityRole<int>(AuthorizationLevel.Api.ToString())
                };
                foreach (var role in roles)
                {
                    await roleManager.CreateAsync(role);
                }
                Console.WriteLine("Working");
            }
            
            CreateUser(serviceProvider);
        }

        public async static void CreateUser(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<StackItContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            var admin = context.Users.FirstOrDefault(i => i.UserName == "admin@stackit.com");
            if (admin != null)
                await userManager.DeleteAsync(admin);


            var user1 = new User()
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "admin@stackit.com",
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = "admin@stackit.com",
                Password = "Password1!",
                CustomerId = 1,
                AuthorizationLevel = AuthorizationLevel.StackIt
            };

            var result = await userManager.CreateAsync(user1, "Password1!");
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user1, user1.AuthorizationLevel.ToString());
            }
        }
    }

}


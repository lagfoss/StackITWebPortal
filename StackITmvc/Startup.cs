using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StackITmvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using StackITmvc.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace StackITmvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        
        public void ConfigureServices(IServiceCollection services)
        {
            //AddIdentity registers the services (infrastructure, so we can communicate with the database, create users etc)
            services.AddIdentity<User, IdentityRole<int>>(options => 
            {
                options.Password.RequiredLength = 8;
            })  .AddRoleManager<RoleManager<IdentityRole<int>>>()
                .AddDefaultTokenProviders() //used to generate token to stuff that's passed into the URL
                .AddEntityFrameworkStores<StackItContext>();

            services.AddControllersWithViews();
            services.AddDbContext<StackItContext>(
                options =>
                options.UseSqlServer
                (Configuration.GetConnectionString("StackItDB")));

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.Cookie.Name = "YourAppCookieName";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.LoginPath = "/Identity/Account/Login";

                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            SeedDatabase.Initialize(app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope().ServiceProvider);

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            // Who are you?
            app.UseAuthentication();

            // Are you allowed?
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

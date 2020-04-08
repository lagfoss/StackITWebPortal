using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StackITmvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace StackITmvc.Data
{
    public class StackItContext : IdentityDbContext<User, Microsoft.AspNetCore.Identity.IdentityRole<int>, int>
    {
        public StackItContext(DbContextOptions<StackItContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<Hardware> Hardware { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<SubscriptionJobs> SubscriptionJobs { get; set; }
        public DbSet<UserSubscriptions> UserSubscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SubscriptionJobs>()
                .HasKey(sj => new { sj.SubscriptionId, sj.JobId });

            modelBuilder.Entity<SubscriptionJobs>()
                .HasOne(sj => sj.Subscription)
                .WithMany(s => s.SubscriptionJobs)
                .HasForeignKey(sj => sj.SubscriptionId);

            modelBuilder.Entity<SubscriptionJobs>()
                .HasOne(sj => sj.Job)
                .WithMany(j => j.SubscriptionJobs)
                .HasForeignKey(j => j.JobId);

            modelBuilder.Entity<UserSubscriptions>()
                .HasOne(us => us.User)
                .WithMany(u => u.UserSubscriptions)
                .HasForeignKey(us => us.UserId).IsRequired(false);

            modelBuilder.Entity<UserSubscriptions>()
                .HasOne(us => us.Subscription)
                .WithMany(s => s.UserSubscriptions)
                .HasForeignKey(s => s.SubscriptionId).IsRequired(false);

        }

    }
}

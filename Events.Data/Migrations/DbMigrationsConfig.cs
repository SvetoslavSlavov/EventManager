namespace Events.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public sealed class DbMigrationsConfig : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public DbMigrationsConfig()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            // Seed initial data only if the database is empty
            if (!context.Users.Any())
            {
                var adminEmail = "admin@admin.com";
                var adminUserName = adminEmail;
                var adminFullName = "System Administrator";
                var adminPassword = adminEmail;
                string adminRole = "Administrator";
                CreateAdminUser(context, adminEmail, adminUserName, adminFullName, adminPassword, adminRole);
                CreateSeveralEvents(context);
            }
        }

        private void CreateAdminUser(ApplicationDbContext context, string adminEmail, string adminUserName, string adminFullName, string adminPassword, string adminRole)
        {
            // Create the "admin" user
            var adminUser = new ApplicationUser
            {
                UserName = adminUserName,
                FullName = adminFullName,
                Email = adminEmail
            };
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 1,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };
            var userCreateResult = userManager.Create(adminUser, adminPassword);
            if (!userCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", userCreateResult.Errors));
            }

            // Create the "Administrator" role
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var roleCreateResult = roleManager.Create(new IdentityRole(adminRole));
            if (!roleCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", roleCreateResult.Errors));
            }

            // Add the "admin" user to "Administrator" role
            var addAdminRoleResult = userManager.AddToRole(adminUser.Id, adminRole);
            if (!addAdminRoleResult.Succeeded)
            {
                throw new Exception(string.Join("; ", addAdminRoleResult.Errors));
            }
        }

        private void CreateSeveralEvents(ApplicationDbContext context)
        {
            context.Events.Add(new Event()
            {
                Name = "Team building Party @ No Sense",
                StartDateTime = DateTime.Now.Date.AddDays(5).AddHours(21).AddMinutes(30),
                EndDateTime = DateTime.Now.Date.AddDays(9).AddHours(10).AddMinutes(30),
                Location = "No Sense",
            });

            context.Events.Add(new Event()
            {
                Name = "Internship Program",
                StartDateTime = DateTime.Now.Date.AddDays(5).AddHours(21).AddMinutes(30),
                EndDateTime = DateTime.Now.Date.AddDays(30).AddHours(10).AddMinutes(30),
                Description = "Don't miss",
            });

            context.Events.Add(new Event()
            {
                Name = "Internship Program",
                StartDateTime = DateTime.Now.Date.AddDays(5).AddHours(21).AddMinutes(30),
                EndDateTime = DateTime.Now.Date.AddDays(30).AddHours(10).AddMinutes(30),
            });

            context.Events.Add(new Event()
            {
                Name = "What is new in C#",
                StartDateTime = DateTime.Now.Date.AddDays(-5).AddHours(21).AddMinutes(30),
                EndDateTime = DateTime.Now.Date.AddDays(-6).AddHours(10).AddMinutes(30),
            });

            context.Events.Add(new Event()
            {
                Name = "OUTSOURCING DESTINATION BULGARIA",
                StartDateTime = DateTime.Now.Date.AddDays(-1).AddHours(21).AddMinutes(30),
                EndDateTime = DateTime.Now.Date.AddDays(-2).AddHours(10).AddMinutes(30),
            });

            context.Events.Add(new Event()
            {
                Name = "Hackafe Plovdiv Party",
                StartDateTime = DateTime.Now.Date.AddDays(-3).AddHours(21).AddMinutes(30),
                EndDateTime = DateTime.Now.Date.AddDays(-4).AddHours(10).AddMinutes(30),
            });

            context.SaveChanges();
        }
    }
}

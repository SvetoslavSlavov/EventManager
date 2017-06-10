namespace Events.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Service;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
                var adminFullName = "Peter Yovchev";
                var adminPassword = adminEmail;
                string adminRole = "Administrator";
                CreateAdminUser(context, adminEmail, adminUserName, adminFullName, adminPassword, adminRole);
                CreateSeveralEvents(context);
            }

            if (!(context.Users.Any(u => u.Email == "pesho@pesho.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "pesho@pesho.com", PhoneNumber = "0889433212", Email = "pesho@pesho.com", FullName = "Pesho Peshev" };
                userManager.Create(userToInsert, "pesho@pesho.com");
            }

            if (!(context.Users.Any(u => u.Email == "niki@niki.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "niki@niki.com", PhoneNumber = "0889356512", Email = "niki@niki.com", FullName = "niki niki" };
                userManager.Create(userToInsert, "niki@niki.com");
            }

            if (!(context.Users.Any(u => u.Email == "boiko@boiko.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "boiko@boiko.com", PhoneNumber = "0889356512", Email = "niki@niki.com", FullName = "boiko" };
                userManager.Create(userToInsert, "boiko@boiko.com");
            }

            if (!(context.Users.Any(u => u.Email == "penio@penev.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "penio@penev.com", PhoneNumber = "0889356512", Email = "penio@penev.com", FullName = "penio" };
                userManager.Create(userToInsert, "penio@penev.com");
            }

            if (!(context.Users.Any(u => u.Email == "gerge@gergev.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "gerge@gergev.com", PhoneNumber = "0889356512", Email = "gerge@gergev.com", FullName = "Georgi" };
                userManager.Create(userToInsert, "gerge@gergev.com");
            }

            if (!(context.Users.Any(u => u.Email == "rado@rado.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "rado@rado.com", PhoneNumber = "0889356512", Email = "pesho@pesho.com", FullName = "rado rado" };
                userManager.Create(userToInsert, "rado@rado.com");
            }

            if (!(context.Users.Any(u => u.Email == "monica@todorova.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "monica@todorova.com", PhoneNumber = "0889343213", Email = "monica@todorova.com", FullName = "monica todorova" };
                userManager.Create(userToInsert, "pesho@pesho.com");
            }

            if (!(context.Users.Any(u => u.Email == "vlado@gmail.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "vlado@gmail.com", PhoneNumber = "0889453211", Email = "vlado@gmail.com", FullName = "vlado vlado" };
                userManager.Create(userToInsert, "pesho@pesho.com");
            }

            if (!(context.Users.Any(u => u.Email == "kris@abv.bg")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "kris@abv.bg", PhoneNumber = "0889313211", Email = "kris@abv.bg", FullName = "Kris Kris" };
                userManager.Create(userToInsert, "pesho@pesho.com");
            }

            if (!(context.Users.Any(u => u.Email == "ana@ana.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "ana@ana.com", PhoneNumber = "0889343212", Email = "ana@ana.com", FullName = "ana ana" };
                userManager.Create(userToInsert, "ana@ana.com");
            }

            if (!(context.Users.Any(u => u.Email == "ana@ana.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "ana@ana.com", PhoneNumber = "0889323213", Email = "ana@ana.com", FullName = "Ana Ana" };
                userManager.Create(userToInsert, "ana@ana.com");
            }

            if (!(context.Users.Any(u => u.Email == "iliq@iliq.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "iliq@iliq.com", PhoneNumber = "0889355419", Email = "iliq@iliq.com", FullName = "iliq iliq" };
                userManager.Create(userToInsert, "iliq@iliq.com");
            }

            if (!(context.Users.Any(u => u.Email == "misho@misho.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "misho@misho.com", PhoneNumber = "0889873212", Email = "misho@misho.com", FullName = "misho misho" };
                userManager.Create(userToInsert, "misho@misho.com");
            }
            context.SaveChanges();
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

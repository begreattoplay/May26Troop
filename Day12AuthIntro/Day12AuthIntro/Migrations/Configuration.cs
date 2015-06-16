namespace Day12AuthIntro.Migrations
{
    using Day12AuthIntro.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Day12AuthIntro.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Day12AuthIntro.Models.ApplicationDbContext context)
        {

            RoleStore<Role> roleStore = new RoleStore<Role>(context);
            RoleManager<Role> roleManager = new RoleManager<Role>(roleStore);

            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            if (!roleManager.RoleExists("Admin"))
            {
                roleManager.Create(new Role
                {
                    Name = "Admin"
                });
            }

            if (!roleManager.RoleExists("User"))
            {
                roleManager.Create(new Role
                {
                    Name = "User"
                });
            }

            try
            {
                ApplicationUser adminUser = userManager.FindByEmail("nick@codercamps.com");
                adminUser.FirstName = "Nick";
                adminUser.LastName = "Brittain";

                if (adminUser != null)
                {
                    if (!userManager.IsInRole(adminUser.Id, "Admin"))
                    {
                        IdentityResult result = userManager.AddToRole(adminUser.Id, "Admin");
                        if (!result.Succeeded)
                        {
                            string errors = string.Empty;
                            result.Errors.ToList().ForEach(e => errors += e);
                            throw new Exception(errors);
                        }
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                string error = ex.EntityValidationErrors.FirstOrDefault().ValidationErrors.FirstOrDefault().ErrorMessage;
                throw new Exception(error);
            }
            

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

namespace NickCafe.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using NickCafe.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NickCafe.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NickCafe.Models.ApplicationDbContext context)
        {
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            RoleStore<Role> roleStore = new RoleStore<Role>(context);
            RoleManager<Role> roleManager = new RoleManager<Role>(roleStore);

            if (!roleManager.RoleExists("Admin"))
                roleManager.Create(new Role { Name = "Admin" });

            if (!roleManager.RoleExists("User"))
                roleManager.Create(new Role { Name = "User" });

            ApplicationUser nick = userManager.FindByName("nick@codercamps.com");

            if (nick == null)
            {
                nick = new ApplicationUser
                {
                    UserName = "nick@codercamps.com",
                    Email = "nick@codercamps.com"
                };

                userManager.Create(nick, "123456");
                userManager.AddToRole(nick.Id, "Admin");

                nick = userManager.FindByName("nick@codercamps.com");
            }

            var products = context.Products.Where(p => p.UserId == null);
            
            foreach(var product in products)
            {
                product.UserId = nick.Id;
            }
        }
    }
}

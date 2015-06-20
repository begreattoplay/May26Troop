namespace ManyToManyCourses.Migrations
{
    using ManyToManyCourses.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManyToManyCourses.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManyToManyCourses.Models.ApplicationDbContext context)
        {
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            ApplicationUser nick = userManager.FindByName("nick@codercamps.com");

            if (nick == null)
            {
                nick = new ApplicationUser
                {
                    FirstName = "Nick",
                    LastName = "Brittain",
                    Email = "nick@codercamps.com",
                    UserName = "nick@codercamps.com"
                };

                try
                {
                    userManager.Create(nick, "123456");
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.FirstOrDefault().ValidationErrors.FirstOrDefault().ErrorMessage;
                    throw new Exception(message);
                }

                nick = userManager.FindByName("nick@codercamps.com");
            }

            Course math = new Course { Name = "Math" };
            Course english = new Course { Name = "English" };
            
            context.Courses.AddOrUpdate(c => c.Name, math, english);
            context.SaveChanges();

            if (!nick.Courses.Any(c => c.CourseId == math.CourseId))
            {
                nick.Courses.Add(new StudentCourse
                {
                    CourseId = math.CourseId
                });
            }

            if (!nick.Courses.Any(c => c.CourseId == english.CourseId))
            {
                nick.Courses.Add(new StudentCourse
                {
                    CourseId = english.CourseId
                });
            }
        }
    }
}

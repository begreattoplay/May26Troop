namespace AuctionSite.Migrations
{
    using AuctionSite.Models.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuctionSite.Models.Data.AuctionDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AuctionSite.Models.Data.AuctionDbContext context)
        {
            AuctionItem[] auctions = new AuctionItem[]
            {
                new AuctionItem { Name = "Peanut Butter", Description = "Tasty stuff!", NumberOfBids = 3, MinimumBid = 5 },
                new AuctionItem { Name = "Pillow", Description = "Sleep better than ever before", NumberOfBids = 3, MinimumBid = 10 }
            };

            context.AuctionItems.AddOrUpdate(a => a.Name, auctions);
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

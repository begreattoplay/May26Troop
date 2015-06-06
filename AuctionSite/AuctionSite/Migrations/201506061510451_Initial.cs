namespace AuctionSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuctionItems",
                c => new
                    {
                        AuctionItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        MinimumBid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumberOfBids = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AuctionItemId);
            
            CreateTable(
                "dbo.Bids",
                c => new
                    {
                        BidId = c.Int(nullable: false, identity: true),
                        AuctionItemId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        BidAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BidId)
                .ForeignKey("dbo.AuctionItems", t => t.AuctionItemId, cascadeDelete: true)
                .Index(t => t.AuctionItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bids", "AuctionItemId", "dbo.AuctionItems");
            DropIndex("dbo.Bids", new[] { "AuctionItemId" });
            DropTable("dbo.Bids");
            DropTable("dbo.AuctionItems");
        }
    }
}

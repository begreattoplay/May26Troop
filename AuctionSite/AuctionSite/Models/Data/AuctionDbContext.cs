using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionSite.Models.Data
{
    public class AuctionDbContext : DbContext
    {
        public IDbSet<AuctionItem> AuctionItems { get; set; }
        public IDbSet<Bid> Bids { get; set; }
    }
}
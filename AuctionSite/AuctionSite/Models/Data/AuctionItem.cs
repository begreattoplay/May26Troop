using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionSite.Models.Data
{
    public class AuctionItem
    {
        public int AuctionItemId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal MinimumBid { get; set; }
        public int NumberOfBids { get; set; }

        public virtual ICollection<Bid> Bids { get; set; }
    }
}
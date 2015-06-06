using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionSite.Models.View
{
    public class CreateBidViewModel
    {
        public int AuctionItemId { get; set; }
        [DisplayName("Auction Name")]
        public string AuctionItemName { get; set; }
        [DisplayName("Minimum Bid Amount")]
        public decimal MinimumBid { get; set; }
        [DisplayName("Your Name")]
        public string Name { get; set; }
        [DisplayName("Bid Amount")]
        public decimal BidAmount { get; set; }
        public decimal? HighestBid { get; set; }
    }
}
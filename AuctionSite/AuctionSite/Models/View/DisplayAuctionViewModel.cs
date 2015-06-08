using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionSite.Models.View
{
    public class DisplayAuctionViewModel
    {
        public int AuctionId { get; set; }
        [DisplayName("Auction Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Minimum Bid")]
        [DataType(DataType.Currency)]
        public decimal MinimumBid { get; set; }
        [DisplayName("Open")]
        public bool IsOpen { get; set; }
        public IList<BidViewModel> Bids { get; set; }
    }
}
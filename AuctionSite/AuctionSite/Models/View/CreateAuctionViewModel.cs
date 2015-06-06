using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionSite.Models.View
{
    public class CreateAuctionViewModel
    {
        [DisplayName("Auction Name")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [DisplayName("Minimum Bid Amount")]
        public decimal MinimumBid { get; set; }
        [DisplayName("Max Number of Bids")]
        public int NumberOfBids { get; set; }
    }
}
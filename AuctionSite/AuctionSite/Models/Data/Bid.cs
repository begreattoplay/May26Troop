using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AuctionSite.Models.Data
{
    public class Bid
    {
        public int BidId { get; set; }
        public int AuctionItemId { get; set; }
        [ForeignKey("AuctionItemId")]
        public virtual AuctionItem AuctionItem { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal BidAmount { get; set; }
    }
}
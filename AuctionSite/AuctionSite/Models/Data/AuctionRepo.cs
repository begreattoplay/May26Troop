using AuctionSite.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionSite.Models.Data
{
    public class AuctionRepo
    { 
        public IList<DisplayAuctionViewModel> GetAuctionViewModels(bool? open = null)
        {
            List<DisplayAuctionViewModel> models = null;

            using (AuctionDbContext db = new AuctionDbContext())
            {
                var q = db.AuctionItems.AsQueryable();

                if (open.HasValue)
                {
                    if (open.Value)
                        q = q.Where(a => a.Bids.Count() < a.NumberOfBids);
                    else
                        q = q.Where(a => a.Bids.Count() == a.NumberOfBids);
                }

                models = q.Select(a => new DisplayAuctionViewModel
                {
                    AuctionId = a.AuctionItemId,
                    Description = a.Description,
                    IsOpen = a.Bids.Count() < a.NumberOfBids,
                    MinimumBid = a.MinimumBid,
                    Name = a.Name
                }).ToList();
            }

            return models;
        }

        public void CreateAuction(CreateAuctionViewModel model)
        {
            using (AuctionDbContext db = new AuctionDbContext())
            {
                AuctionItem dbAuction = new AuctionItem
                {
                    Description = model.Description,
                    MinimumBid = model.MinimumBid,
                    Name = model.Name,
                    NumberOfBids = model.NumberOfBids
                };

                db.AuctionItems.Add(dbAuction);
                db.SaveChanges();
            }
        }

        public CreateBidViewModel GetCreateBidViewModel(int auctionItemId)
        {
            CreateBidViewModel model = null;

            using (AuctionDbContext db = new AuctionDbContext())
            {
                model = db.AuctionItems.Where(a => a.AuctionItemId == auctionItemId).Select(a => new CreateBidViewModel
                {
                    AuctionItemId = a.AuctionItemId,
                    AuctionItemName = a.Name,
                    MinimumBid = a.MinimumBid,
                    HighestBid = a.Bids.OrderByDescending(b => b.BidAmount).Select(b => b.BidAmount).FirstOrDefault()
                }).FirstOrDefault();
            }

            return model;
        }

        public void AddBid(CreateBidViewModel model)
        {
            using (AuctionDbContext db = new AuctionDbContext())
            {
                Bid dbBid = new Bid
                {
                    AuctionItemId = model.AuctionItemId,
                    BidAmount = model.BidAmount,
                    Name = model.Name
                };

                db.Bids.Add(dbBid);
                db.SaveChanges();
            }
        }

        public DisplayAuctionViewModel GetAuctionDetailsViewModel(int auctionItemId)
        {
            DisplayAuctionViewModel model = null;

            using (AuctionDbContext db = new AuctionDbContext())
            {
                model = db.AuctionItems.Where(a => a.AuctionItemId == auctionItemId).Select(a => new DisplayAuctionViewModel
                {
                    AuctionId = a.AuctionItemId,
                    Bids = a.Bids.Select(b => new BidViewModel
                    {
                        BidAmount = b.BidAmount,
                        Name = b.Name
                    }).ToList(),
                    Description = a.Description,
                    MinimumBid = a.MinimumBid,
                    Name = a.Name
                }).FirstOrDefault();
            }

            return model;
        }
    }
}
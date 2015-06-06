using AuctionSite.Models.Data;
using AuctionSite.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionSite.Controllers
{
    public class AuctionController : Controller
    {
        private AuctionRepo _repo;

        public AuctionController()
        {
            _repo = new AuctionRepo();
        }

        // GET: Auction
        public ActionResult Index()
        {
            IList<DisplayAuctionViewModel> models = _repo.GetAuctionViewModels();

            return View(models);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateAuctionViewModel model)
        {
            _repo.CreateAuction(model);

            return RedirectToAction("Index");
        }

        public ActionResult Bid(int id)
        {
            CreateBidViewModel model = _repo.GetCreateBidViewModel(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Bid(CreateBidViewModel model)
        {
            if (model.BidAmount < model.MinimumBid)
                ModelState.AddModelError("BidAmount", "Your bid amount is not greater than or equal to the minimum");

            if (!ModelState.IsValid)
                return View(model);

            _repo.AddBid(model);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            DisplayAuctionViewModel model = _repo.GetAuctionDetailsViewModel(id);
            return View(model);
        }
    }
}
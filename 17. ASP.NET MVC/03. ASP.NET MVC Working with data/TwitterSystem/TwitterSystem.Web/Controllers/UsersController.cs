namespace TwitterSystem.Web.Controllers
{
    using Data.Models;
    using Microsoft.AspNet.Identity;
    using Models;
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using TwitterSystem.Services.Data;

    public class UsersController : Controller
    {
        private readonly ITweetsService tweetsData;

        public UsersController(ITweetsService tweetsData)
        {
            this.tweetsData = tweetsData;
        }

        // GET: User Details
        public ActionResult Details()
        {
            var userId = HttpContext.User.Identity.GetUserId();
            var tweets = this.tweetsData
                .GetAllByUser(userId)
                .Select(TweetViewModel.TweetView)
                .ToList();

            return View(tweets);
        }

        // GET: Users/Tweet/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tweet tweet)
        {
            tweet.LikesCount = 0;
            tweet.TimeStamp = DateTime.Now;
            tweet.UserId = HttpContext.User.Identity.GetUserId();
            if (ModelState.IsValid)
            {
                this.tweetsData.Add(tweet);
                return RedirectToAction("Details");
            }

            return View(tweet);
        }   
    }
}
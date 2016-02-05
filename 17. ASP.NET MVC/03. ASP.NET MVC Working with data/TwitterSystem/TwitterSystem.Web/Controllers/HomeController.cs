using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.UI;
using TwitterSystem.Services.Data;
using TwitterSystem.Web.Models;

namespace TwitterSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private const string TagName = "#fail";

        private readonly ITweetsService tweetsData;

        public HomeController(ITweetsService tweetsData)
        {
            this.tweetsData = tweetsData;
        }

        public ActionResult Index()
        {
            var cache = this.HttpContext.Cache["data"];
            if (cache == null)
            {
                var tweets = this.tweetsData
                    .GetByTag(TagName)
                    .Select(TweetViewModel.TweetView)
                    .ToList();

                this.HttpContext.Cache.Insert("data", tweets, null, DateTime.Now.AddMinutes(15), TimeSpan.Zero);
                cache = this.HttpContext.Cache["data"];
            }

            return View(cache);
        }
    }
}
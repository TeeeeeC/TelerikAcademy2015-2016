using MoviesSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MoviesSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private MoviesSystemDbContext db = new MoviesSystemDbContext();

        public ActionResult Index()
        {
            var movies = db.Movies.ToList();
            return View(movies);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            //TODO validate model on the server and create new view model different from database model

            db.Movies.Add(movie);
            db.SaveChanges();

            return Json(new { url = Url.Action("Index") });
        }


        [HttpPost]
        public ActionResult Update(Movie movie)
        {
            int id = movie.Id;
            var movieToUpdate = db.Movies.Find(id);
            movieToUpdate.Title = movie.Title;
            movieToUpdate.Year = movie.Year;
            movieToUpdate.Director = movie.Director;
            movieToUpdate.LeadingFemaleRole = movie.LeadingFemaleRole;
            movieToUpdate.LeadingMaleRole = movie.LeadingMaleRole;
            movieToUpdate.AgeLeadingMaleRole = movie.AgeLeadingMaleRole;
            movieToUpdate.AgeLeadingFemaleRole = movie.AgeLeadingFemaleRole;
            movieToUpdate.Studio = movie.Studio;
            movieToUpdate.StudioAddress = movie.StudioAddress;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            Redirect("edit");
            return View(movie);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var movieToDel = db.Movies.FirstOrDefault(m => m.Id == id);
            db.Movies.Remove(movieToDel);
            db.SaveChanges();

            return Json(new { url = Url.Action("Index") });
        }
    }
}
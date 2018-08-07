using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restauranter.Models;
using Microsoft.EntityFrameworkCore;

namespace Restauranter.Controllers
{
    public class HomeController : Controller
    {
        private ReviewContext _context;

        public HomeController(ReviewContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // List<Review> AllReviews = _context.reviews.ToList();
            // string theReviews = "Here is a list of all the reviews: \n";
            // foreach(Review review in AllReviews)
            // {
                // theReviews += review.RestaurantName;
                // Console.WriteLine(theReviews);
            // }
            // 

            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(Review data)
        {
            if(ModelState.IsValid)
            {
                Review NewReview = new Review
                {
                    ReviewerName = @data.ReviewerName,
                    RestaurantName = @data.RestaurantName,
                    UserReview = @data.UserReview,
                    Rating = @data.Rating,
                    ReviewDate = @data.ReviewDate
                };

                _context.Add(NewReview);
                // OR _context.Users.Add(NewPerson);
                _context.SaveChanges();
                return View("Reviews");
            }
            return View("Index");
        }

        public IActionResult Reviews()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

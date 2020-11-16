using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRegistrationLab.Models;

namespace MovieRegistrationLab.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieRegistrationForm()
        {
            return View(new Movie());
        }

        public IActionResult MovieRegistered(Movie movie)
        {
            if (ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                return View("MovieRegistrationForm", movie);
            }
        }

    }
}

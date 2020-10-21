using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class StudyController : Controller
    {
        public IActionResult Index()
        {
            var cards = new List<Card>() {
                new Card {
                ID = 1,
                Front = "Yo soy",
                Back = "I am"
                }, new Card {
                ID = 2,
                Front = "Yo estoy",
                Back = "I am currently"
                }, new Card {
                ID = 3,
                Front = "Yo estoy",
                Back = "I am currently"
                }
            };

            return View(cards);
        }
    }
}
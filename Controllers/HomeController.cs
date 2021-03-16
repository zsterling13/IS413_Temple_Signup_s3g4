using IS413_Temple_Signup_ZS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Temple_Signup_ZS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private tourGroupContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, tourGroupContext con)
        {
            _logger = logger;
            _context = con;
        }

        //Determines how many time slote are displayed per page
        public int ItemsPerPage = 35;

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUpForm(tourGroup submittedForm)
        {
            if (ModelState.IsValid == true)
            {
                _context.Groups.Add(submittedForm);
                _context.SaveChanges();
                return View("Index");
            }
            else
            { 
                return View();
            }
        }

        public IActionResult SlotAvailability()
        {
            return View(_context.timeSlots.OrderBy(p => p.scheduleInfo).Take(ItemsPerPage));
        }

        public IActionResult ViewAppointments()
        {
            return View(_context.Groups);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

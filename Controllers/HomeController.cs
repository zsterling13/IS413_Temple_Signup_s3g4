using IS413_Temple_Signup_ZS.Models;
using IS413_Temple_Signup_ZS.Models.ViewModels;
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
        //public int ItemsPerPage = _context.timeSlots.Count();

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
        public IActionResult SignUpForm(requestApptVM submittedForm)
        {
            if (ModelState.IsValid == true)
            {
                _context.Groups.Add(submittedForm.tourGroup);
                
                _context.SaveChanges();

                IQueryable<timeSlot> test = _context.timeSlots.Where(p => p.slotID == submittedForm.timeSlot.slotID);

                foreach(var x in test)
                {
                    x.availablility = false;
                }

                _context.SaveChanges();

                return View("Index");
            }
            else
            { 
                return View(submittedForm);
            }
        }

        [HttpGet]
        public IActionResult SlotAvailability()
        {
            return View(_context.timeSlots.OrderBy(p => p.scheduleInfo));
        }

        [HttpPost]
        public IActionResult SlotAvailability(timeSlot sesTime)
        {

            return View("SignUpForm", new requestApptVM
            {
                timeSlot = sesTime
            }
                );
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

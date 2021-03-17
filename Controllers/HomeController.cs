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
        public IActionResult SignUpForm(requestApptVM submittedForm)
        {
            if (ModelState.IsValid == true)
            {
                //submittedForm.tourGroup.tourTime = submittedForm.timeSlot.scheduleInfo;

                _context.Groups.Add(submittedForm.tourGroup);
                //_context.timeSlots.
                //new timeSlot pleaseWork = _context.timeSlots.Where(p => p.slotID == submittedForm.timeSlot.slotID).Take(1);
                
                _context.SaveChanges();

                var query = _context.timeSlots.Where(p => p.slotID == submittedForm.timeSlot.slotID).Single();

                query.availablility = false;

                _context.SaveChanges();

                //timeSlot testf = _context.timeSlots.Where(c => c.slotID == submittedForm.timeSlot.slotID).Single();

                //testf.availablility = false;

                //_context.timeSlots.Update(submittedForm.timeSlot.);

                //_context.timeSlots.Update(c => c. )   .Where(p => p.slotID == submittedForm.timeSlot.slotID).ToList().Update(c => { c.availablility = false; return c; });
                //_context.timeSlots.Where(p => p.slotID == submittedForm.timeSlot.slotID).ToList();

                return View("Index");
            }
            else
            { 
                return View();
            }
        }

        [HttpGet]
        public IActionResult SlotAvailability()
        {
            return View(_context.timeSlots.OrderBy(p => p.scheduleInfo).Take(ItemsPerPage));
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

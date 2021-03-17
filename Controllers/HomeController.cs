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

        //Create a context object that helps the database update easily
        private tourGroupContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, tourGroupContext con)
        {
            _logger = logger;
            _context = con;
        }

        //Action for the Homepage
        public IActionResult Index()
        {
            return View();
        }

        //HttpGet Action for the SignupForm where the user inserts data for a new group
        [HttpGet]
        public IActionResult SignUpForm()
        {
            return View();
        }

        //making sure the model state is valid and if it is have it output in a certain way
        [HttpPost]
        public IActionResult SignUpForm(requestApptVM submittedForm)
        {
            //If the submitted form is valid then add it to the database
            if (ModelState.IsValid == true)
            {
                //Add the passed-in form to the database
                _context.Groups.Add(submittedForm.tourGroup);
                
                _context.SaveChanges();

                //Process to create queryable object that only returns the row and data for the timeslot that the user selected
                IQueryable<timeSlot> test = _context.timeSlots.Where(p => p.slotID == submittedForm.timeSlot.slotID);

                foreach(var x in test)
                {
                    x.availablility = false;
                }

                _context.SaveChanges();

                return View("Index");
            }

            //If the submitted form is not valid then redirect the user back to the form page to try and correct data
            else
            { 
                return View(submittedForm);
            }
        }
        //slotavailability, making sure it will show up and passing back certain information ordered by 
        [HttpGet]
        public IActionResult SlotAvailability()
        {
            //Returns a view with a filtered database that orders by date
            return View(_context.timeSlots.OrderBy(p => p.scheduleInfo));
        }
        //post of the slot availability 
        [HttpPost]
        public IActionResult SlotAvailability(timeSlot sesTime)
        {
            //Redirect user to the signup form with the date and time info that the user selected passed into the form page
            return View("SignUpForm", new requestApptVM
            {
                timeSlot = sesTime
            }
                );
        }
        //View appointment and passing that information when you return the View
        public IActionResult ViewAppointments()
        {
            //Return a view with the groups table passed into it
            return View(_context.Groups);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

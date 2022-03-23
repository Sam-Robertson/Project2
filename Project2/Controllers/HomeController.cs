using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project2.Models;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {

        private GroupContext blahContext { get; set; }

        public HomeController(GroupContext someName)
        {

            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Add Appt Methods

        [HttpGet]
        public IActionResult AddAppt()
        {
            //ViewBag.majors = blahContext.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddAppt(Group ar)
        {
            blahContext.Add(ar);
            blahContext.SaveChanges();

            return View("Confirmation", ar);
        }
        //Edit Methods

        [HttpGet]

        public IActionResult Edit(int Apptid)
        {
            //ViewBag.Category = blahContext.Category.ToList();

            Group myAppt = blahContext.Appts.Single(x => x.ApptId == Apptid);
            return View("ApptList", myAppt);
        }

        [HttpPost]
        public IActionResult Edit(Group test)
        {
            blahContext.Update(test);
            blahContext.SaveChanges();

            return RedirectToAction("ApptList");

        }
        // Appt List
        public IActionResult ApptList()
        {

            var Appts = blahContext.Appts
                //.Include(x => x.Category)
                //.OrderBy(x => x.Title)
                .ToList();
            return View(Appts);
        }

        // Delete Methods

        [HttpGet]
        public IActionResult Delete(int Apptid)
        {
            var application = blahContext.Appts.Single(x => x.ApptId == Apptid);


            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(Group ar)
        {

            blahContext.Remove(ar);
            blahContext.SaveChanges();

            return RedirectToAction("WaitList");
        }


    }
}



        


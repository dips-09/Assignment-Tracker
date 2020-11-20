using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AssignmentTraker_HW5.Models;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Razor.Language;

namespace AssignmentTraker_HW5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AssignmentContext context;

        public HomeController(ILogger<HomeController> logger,AssignmentContext _context)
        {
            _logger = logger;
            context = _context;
        }

        private static List<ClsAssignment> list;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TrackIt(ClsAssignment assign)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.Message = "Please enter valid Values";
                return RedirectToAction("Index");
            }

            ClsAssignment checkAssign = context.Assignments.FirstOrDefault(item => item.Priority == assign.Priority && item.CourseName.Equals(assign.CourseName) && item.DueDate == assign.DueDate && item.AssignmentTitle.Equals(assign.AssignmentTitle) && item.Notes.Equals(assign.Notes));
            if(checkAssign != null)
            {
                ViewBag.Message = "This data already exists!";
                return View("Index");
            }
            context.Assignments.Add(assign);
            context.SaveChanges();
            ViewBag.Message = "Tracking Successful!";
            return View("Index");
        }


        [HttpGet]
        public IActionResult TaskListing()
        {
            if (list == null)
            {
                list = context.Assignments.ToList();
            }

            return View(list);
    }


        [HttpPost]
        public IActionResult sortbypriority()
        {
            List<ClsAssignment> assignlist = context.Assignments.ToList();
            list =  assignlist.OrderBy(assign => assign.Priority).ToList();
            return RedirectToAction("TaskListing");
        }

        [HttpPost]
        public IActionResult sortbyduedate()
        {
            List<ClsAssignment> assignlist = context.Assignments.ToList();
            list = assignlist.OrderBy(assign => assign.DueDate).ToList();
            return RedirectToAction("TaskListing");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

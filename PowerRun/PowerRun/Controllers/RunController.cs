using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PowerRun.Models;
using PowerRun.Services;
using PowerRun.ViewModels;

namespace PowerRun.Controllers
{
    public class RunController : Controller
    {
        private IRunData _runData;

        public RunController(IRunData runData)
        {
            _runData = runData;
        }

        [HttpGet]
        public IActionResult AddRun()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRun(RunEditModel model)
        { 
            var newRun = new Run()
            {
                Date = DateTime.Now,
                Username = User.Identity.Name,
                Time = model.Time,
                Distance = model.Distance,
                Pace = model.Pace
            };

            newRun = _runData.Add(newRun);

            return View("~/Views/Home/Profile.cshtml", newRun);

        }

        [HttpGet]
        public IActionResult GetAllRuns()
        {
            var runs = _runData.GetAll();
            return View("~/Views/Home/Index.cshtml", runs);
        }

    }

}
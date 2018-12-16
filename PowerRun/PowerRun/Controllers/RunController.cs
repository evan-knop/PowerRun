using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PowerRun.Helpers;
using PowerRun.Models;
using PowerRun.Services;
using PowerRun.ViewModels;

namespace PowerRun.Controllers
{
    [Authorize]
    public class RunController : Controller
    {
        private IRunData _runData;

        public RunController(IRunData runData)
        {
            _runData = runData;
        }

        public IActionResult Profile()
        {
            var runs = _runData.GetAll(User.Identity.Name);
            RunEditModel avgs = RunHelper.CalculateAverages(runs);
            return View(avgs);
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

            newRun = RunHelper.FormatRun(newRun);
            newRun = _runData.Add(newRun);

            return View("~/Views/Run/NewRunAdded.cshtml", newRun);

        }

        [HttpGet]
        public IActionResult ViewRuns()
        {
            var runs = _runData.GetAll(User.Identity.Name);
            return View(runs);
        }

    }

}
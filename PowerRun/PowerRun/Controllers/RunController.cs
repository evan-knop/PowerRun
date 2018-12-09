using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PowerRun.Controllers
{
    public class RunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
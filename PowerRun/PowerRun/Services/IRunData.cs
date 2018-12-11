using PowerRun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerRun.Services
{
   public interface IRunData
    {
        IEnumerable<Run> GetAll();
        Run Add(Run run);
    }
}

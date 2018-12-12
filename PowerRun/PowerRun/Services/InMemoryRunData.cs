using PowerRun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerRun.Services
{
    public class InMemoryRunData : IRunData
    {
        List<Run> _runs;

        public InMemoryRunData()
        {
            _runs = new List<Run>
           {
               new Run {ID = 1, Date = DateTime.Now, Distance = 4, Pace = new TimeSpan(0, 8, 12), Time = new TimeSpan(0, 33, 15) },
               new Run { ID = 2, Date = DateTime.Now, Distance = 2, Pace = new TimeSpan(0, 8, 27), Time = new TimeSpan(0, 17, 11) },
               new Run { ID = 3, Date = DateTime.Now, Distance = 1, Pace = new TimeSpan(0, 10, 00), Time = new TimeSpan(0, 10, 00) },
           };
        }

        public Run Add(Run run)
        {
            run.ID = _runs.Max(x => x.ID + 1);
            _runs.Add(run);
            return run;
        }

        public IEnumerable<Run> GetAll(string username)
        {
            return _runs;
        }
    }
}

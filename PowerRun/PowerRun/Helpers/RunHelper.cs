using PowerRun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerRun.Helpers
{
    public class RunHelper
    {
        public static Run FormatRun(Run run)
        {
            if (run.Time > new TimeSpan(0, 60, 0))
            {
                TimeSpan formattedTime = new TimeSpan(0, run.Time.Hours, run.Time.Minutes);
                run.Time = formattedTime;
            }

            if (run.Pace > new TimeSpan(0, 60, 0))
            {
                TimeSpan formattedPace = new TimeSpan(0, run.Pace.Hours, run.Pace.Minutes);
                run.Pace = formattedPace;
            }

            return run;
        }
    }
}

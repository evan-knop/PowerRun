using PowerRun.Models;
using PowerRun.ViewModels;
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

        public static RunEditModel CalculateAverages(IEnumerable<Run> runs)
        {
            TimeSpan avgTime = new TimeSpan();
            TimeSpan avgPace = new TimeSpan();
            decimal avgDistance = 0;

            foreach(Run run in runs)
            {
                avgTime += run.Time;
                avgPace += run.Pace;
                avgDistance += run.Distance;
            }

            avgTime = avgTime / runs.Count();
            avgPace = avgPace / runs.Count();
            avgDistance = avgDistance / runs.Count();

            return new RunEditModel
            {
                Time = avgTime,
                Pace = avgPace,
                Distance = avgDistance
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerRun.ViewModels
{
    public class RunEditModel
    {
        public TimeSpan Time { get; set; }
        public decimal Distance { get; set; }
        public TimeSpan Pace { get; set; }
    }
}

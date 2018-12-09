using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerRun.Models
{
    public class NewRunModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public decimal Distance { get; set; }
        public TimeSpan Pace { get; set; }
    }
}

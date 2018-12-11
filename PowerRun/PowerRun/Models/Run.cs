using System;

namespace PowerRun.Models
{
    public class Run
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public decimal Distance { get; set; }
        public TimeSpan Pace { get; set; }
    }
}

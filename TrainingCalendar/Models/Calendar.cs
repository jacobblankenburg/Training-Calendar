using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingCalendar.Models
{
    public class Calendar : ApplicationDbContext
    {
        public string EventName { get; set; }
        public int RemainingSpots { get; set; }
        public DateTime EventTime { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string EmailContact { get; set; }
    }
}
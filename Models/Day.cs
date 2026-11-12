using System;
using System.Collections.Generic;
using System.Text;

namespace Habit_Tracker.Models
{
    public class Day
    {
        public DateOnly Date { get; set; }
        public List<Habit> Habits { get; set; }

        public Day(DateOnly date)
        {
            Date = date;
            Habits = new List<Habit>();
        }
    }
}

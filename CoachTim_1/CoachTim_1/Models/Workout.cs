using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoachTim_1.Models
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public int AthleteId { get; set; }
        public string WorkoutType { get; set; }
        public DateTime WorkoutDate { get; set; }
        public int WorkoutDistance { get; set; }
        public int WorkoutHours { get; set; }
        public int WorkoutMinutes { get; set; }
        public int WorkoutSeconds { get; set; }
        public int AverageHeartRate { get; set; }
        public int PreviousNightSleepHours { get; set; }
        public int PreviousNightSleepMinutes { get; set; }

    }
}
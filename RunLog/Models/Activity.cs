using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public short Calories { get; set; }
        public Course Course { get; set; }
        public Creator Creator { get; set; }
        public Single DistanceInMiles { get; set; }
        public DistanceUnits DistanceUnits { get; set; }
        public TimeSpan Duration { get; set; }
        public string FileName {get; set;}
        public HeartRate HeartRate { get; set; }
        public Intensity Intensity { get; set; }
        public List<Lap> Laps { get; set; }
        public TimeSpan MilePace { get; set; }
        public string Notes { get; set; }
        public Shoe Shoes { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan StoppedTime { get; set; }
        public Member Member { get; set; }
        public Weather Weather { get; set; }
        public WorkoutType WorkoutType { get; set; }
    }
}
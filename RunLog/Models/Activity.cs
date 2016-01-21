using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public short? Calories { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public string CourseName { get; set; }
        public int CreatorId { get; set; }
        public virtual Creator Creator { get; set; }
        public Single Distance { get; set; }
        public DistanceUnits DistanceUnits { get; set; }
        public int DurationSeconds { get; set; }
        public string FileName {get; set;}
        public short? HeartRateAverage { get; set; }
        public short? HeartRateMax { get; set; }
        //public HeartRate HeartRate { get; set; }
        public Intensity Intensity { get; set; }
        public List<Lap> Laps { get; set; }
        public int MilePaceSeconds { get; set; }
        public string Notes { get; set; }
        public int? ShoeId { get; set; }
        public virtual Shoe Shoes { get; set; }
        public DateTime StartTime { get; set; }
        public int StoppedTimeSeconds { get; set; }
        public int MemberId { get; set; }
        public virtual Member Member { get; set; }
        public int? WeatherId { get; set; }
        public virtual Weather Weather { get; set; }
        public int? WorkoutId { get; set; }
        public virtual Pace Workout { get; set; }

        public Activity()
        {
            this.Laps = new List<Lap>();
        }
    }
}
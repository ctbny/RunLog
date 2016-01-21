using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public class ScheduledRun
    {
        public int ScheduledRunId { get; set; }
        public DateTime StartDateTime { get; set; }
        public double DistanceInMiles { get; set; }
        public int IntensityId { get; set; }
        public virtual Pace WorkoutType { get; set;}
        public int? CourseId { get; set; }
        public virtual Course Course { get; set; }

    }
}
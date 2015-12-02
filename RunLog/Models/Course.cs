using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public DateTime? CreatedBy { get; set; } // StartDateTime of garmin activity that created this course, if available
        public Single DistanceInMiles { get; set; }
        public decimal StartingLatitude { get; set; }
        public decimal StartingLongitude { get; set; }
        public decimal EndingLatitude { get; set; }
        public decimal EndingLongitude { get; set; }
        public Elevation Elevation { get; set; }
        public virtual List<Trackpoint> Trackpoints { get; set; }
        public virtual List<MilePoint> MilePoints { get; set; }

    }
}
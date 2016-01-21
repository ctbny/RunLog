using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedBy { get; set; } // StartDateTime of garmin activity that created this course, if available
        public float Distance { get; set; }
        public DistanceUnits DistanceUnits { get; set; }
        public decimal StartingLat { get; set; }
        public decimal StartingLong { get; set; }
        public decimal EndingLat { get; set; }
        public decimal EndingLong { get; set; }
        public int EleStart { get; set; }
        public int EleFinish { get; set; }
        public int EleGain { get; set; }
        public int EleLoss { get; set; }
        public int EleNet { get; set; }
        public virtual List<Trackpoint> Trackpoints { get; set; }
        public virtual List<MilePoint> MilePoints { get; set; }

        public Course()
        {
            this.Trackpoints = new List<Trackpoint>();
            this.MilePoints = new List<MilePoint>();
        }

    }
}
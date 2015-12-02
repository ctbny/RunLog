using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public class Trackpoint
    {
        public int TrackpointId { get; set; }
        public DateTime StartTime { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public short ElevationFeet { get; set; }
        public double DistanceInMiles { get; set; }
        public short HeartRate { get; set; }
    }
}
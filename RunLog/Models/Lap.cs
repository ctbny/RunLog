using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public class Lap
    {
        public int Id { get; set; }
        public short AverageHeartRate { get; set; }
        public int Calories { get; set; }
        public Single Distance { get; set; }
        public Single DistanceFromStart { get; set; }
        public DistanceUnits DistanceUnitsView { get; set; } 
        public TimeSpan Duration { get; set; }
        public Elevation Elevation { get; set; }
        public HeartRate HeartRate { get; set; }
        public Intensity Intensity { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan StoppedTime { get; set; }

        public virtual List<Trackpoint> Trackpoints { get; set; }
    }
}
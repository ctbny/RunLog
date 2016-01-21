using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public class Lap
    {
        public int Id { get; set; }
        public short? AverageHeartRate { get; set; }
        public int? Calories { get; set; }
        public Single Distance { get; set; }
        public Single DistanceFromStart { get; set; }
        public DistanceUnits DistanceUnitsView { get; set; }
        public int DurationSec { get; set; }
        public short? HeartRateAverage { get; set; }
        public short? HeartRateMax { get; set; }
        public Intensity Intensity { get; set; }
        public DateTime StartTime { get; set; }
        public int StoppedTimeSeconds { get; set; }

        public List<Trackpoint> Trackpoints { get; set; }

        public Lap()
        {
            this.Trackpoints = new List<Trackpoint>();
        }
    }
}
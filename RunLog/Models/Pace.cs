using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace RunLog.Models
{
    public class Pace
    {
        public int WorkoutId { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public int MinPaceSeconds { get; set; }
        public int MaxPaceSeconds { get; set; }
    }
}
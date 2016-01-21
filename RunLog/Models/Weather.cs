using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public class Weather
    {
        public int WeatherId { get; set; }
        public string Conditons { get; set; }
        public Single? EndTemp { get; set; }
        public Single? FeelsLike { get; set; }
        public Single? Humidity { get; set; }
        public Single? StartTemp { get; set; }
        public DateTime Time { get; set; }
        public Single? WindSpeed { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
	public class Elevation
	{
        public int ElevationId { get; set; }
        public short? Start { get; set; }
        public short? Finish { get; set; }
        public short? Gain { get; set; }
        public short? Loss { get; set; }
        public short? Net { get; set; }
	}
}
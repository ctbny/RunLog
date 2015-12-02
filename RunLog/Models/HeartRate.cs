using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public class HeartRate
    {
        public int Id { get; set; }
        public short? Average { get; set; }
        public short? Max { get; set; }
    }
}
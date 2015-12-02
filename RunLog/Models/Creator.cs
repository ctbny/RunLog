using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public class Creator
    {
        public int CreatorId { get; set; }
        public string Name { get; set; }
        public long UnitId { get; set; }
        public string FileName { get; set; }
    }
}
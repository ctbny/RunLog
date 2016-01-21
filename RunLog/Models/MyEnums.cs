using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    public enum DistanceUnits
    {
        Miles = 0,
        Kilometers = 1,
        Meters = 2
    }

    public enum Intensity
    {
        Undefined = 0,
        Easy = 1,
        Moderate = 2,
        Tempo = 3,
        Hard = 4,
        Race = 5,
    }

    //public enum WorkoutType
    //{
    //    Undefined = 0,
    //}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SQLite;

namespace RunLog.Models
{
    public class Context : DbContext
    {
        public Context()
            : base("cnRunLogWork")
        { }
        //public Context(string filename)
        //    : base(new SQLiteConnection()
        //    {
        //        ConnectionString =
        //        new SQLiteConnectionStringBuilder()
        //        { DataSource = filename, ForeignKeys = true }
        //        .ConnectionString
        //    }, true)
        //{ }

        public DbSet<Activity> Runs { get; set; }
        public DbSet<Lap> Laps { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<MilePoint> MilePoints { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<Trackpoint> Trackpoints { get; set; }
        public DbSet<ScheduledRun> ScheduledRuns { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Pace> Paces { get; set; }

    }
}
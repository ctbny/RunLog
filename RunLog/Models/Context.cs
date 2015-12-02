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
        public Context(string filename)
            : base(new SQLiteConnection()
            {
                ConnectionString =
                new SQLiteConnectionStringBuilder()
                { DataSource = filename, ForeignKeys = true }
                .ConnectionString
            }, true)
        { }


    }
}
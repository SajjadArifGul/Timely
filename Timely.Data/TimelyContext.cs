using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.Data
{
    public class TimelyContext : DbContext
    {
        public TimelyContext() : base("name=TimelyConnectionString-OK")
        {

        }

        public DbSet<Timely.Entities.Task> Tasks { get; set; }
        public DbSet<Timely.Entities.Event> Events { get; set; }
    }
}

using GasAnalytics.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasAnalytics.DataAccess
{
    public class FillUpContext : DbContext
    {
        public FillUpContext() : base ("FillUpContext")
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<StationChain> StationChains { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<OdometerReading> OdometerReadings { get; set; }
        public DbSet<FillUp> FillUps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

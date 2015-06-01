using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BargeSurvey.Models
{
    public class SurveyContext : DbContext
    {
        public SurveyContext()
            : base("SurveyDB")
        {
        }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<BargeSample> BargeSamples { get; set; }
        public DbSet<Draft> Drafts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
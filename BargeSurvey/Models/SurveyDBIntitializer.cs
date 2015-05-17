using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BargeSurvey.Models
{
    public class SurveyDBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SurveyContext>
    {
        protected override void Seed(SurveyContext context)
        {
            base.Seed(context);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BargeSurvey.Controllers
{
    public class BargeSampleController : Controller
    {
        // GET: BargeSample
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Create(long? surveyID)
        {
            BargeSurvey.Models.Survey parent;
            using (var db = new BargeSurvey.Models.SurveyContext())
            {
                parent = await db.Surveys.FindAsync(surveyID);
                if (parent == null)
                    return HttpNotFound("Survey not found");


            }
            ViewBag.SurveyID = parent.Id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SurveyID,LoadedPrior,PumpedAfterLight,BargeID,BargeType,RiverCondition,ReadingP1,ReadingP2,ReadingP3,ReadingP4,ReadingS1,ReadingS2,ReadingS3,ReadingS4,SurveyId")] BargeSurvey.Models.BargeSample sample)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BargeSurvey.Models.SurveyContext())
                {
                    db.BargeSamples.Add(sample);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Edit", "Surveys", new { id = sample.SurveyId });
        }

        public async Task<ActionResult> Delete(long id)
        {
            BargeSurvey.Models.BargeSample local;
            using (var db = new BargeSurvey.Models.SurveyContext())
            {
                local = await db.BargeSamples.FindAsync(id);
                if (local == null)
                {
                    return HttpNotFound();
                }
            }

            return View(local);
        }

        [HttpPost, ActionName(name: "Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            long surveyId;
            using (var db = new BargeSurvey.Models.SurveyContext())
            {
                var sample = await db.BargeSamples.FindAsync(id);
                if (sample == null)
                    return HttpNotFound();

                surveyId = sample.SurveyId;
                db.BargeSamples.Remove(sample);
                await db.SaveChangesAsync();
            }


            return RedirectToAction("Edit", "Surveys", new { id = surveyId });

        }


        public async Task<ActionResult> Edit(long? sampleID)
        {
            BargeSurvey.Models.BargeSample sample;
            using (var db = new BargeSurvey.Models.SurveyContext())
            {
                sample = await db.BargeSamples.FindAsync(sampleID);
            }
            return View(sample);
        }
    }
}
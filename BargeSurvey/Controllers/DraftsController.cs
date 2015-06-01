using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BargeSurvey.Models;

namespace BargeSurvey.Controllers
{
    public class DraftsController : Controller
    {
        private SurveyContext db = new SurveyContext();

        // GET: Drafts
        public async Task<ActionResult> Index()
        {
            return View(await db.Drafts.ToListAsync());
        }

        // GET: Drafts/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Draft draft = await db.Drafts.FindAsync(id);
            if (draft == null)
            {
                return HttpNotFound();
            }
            return View(draft);
        }

        // GET: Drafts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drafts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,DraftType,ReadingP1,ReadingP2,ReadingP3,ReadingP4,ReadingS1,ReadingS2,ReadingS3,ReadingS4,BargeSampleId")] Draft draft)
        {
            if (ModelState.IsValid)
            {
                db.Drafts.Add(draft);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(draft);
        }

        // GET: Drafts/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Draft draft = await db.Drafts.FindAsync(id);
            if (draft == null)
            {
                return HttpNotFound();
            }
            return View(draft);
        }

        // POST: Drafts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,DraftType,ReadingP1,ReadingP2,ReadingP3,ReadingP4,ReadingS1,ReadingS2,ReadingS3,ReadingS4,BargeSampleId")] Draft draft)
        {
            if (ModelState.IsValid)
            {
                db.Entry(draft).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(draft);
        }

        // GET: Drafts/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Draft draft = await db.Drafts.FindAsync(id);
            if (draft == null)
            {
                return HttpNotFound();
            }
            return View(draft);
        }

        // POST: Drafts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            Draft draft = await db.Drafts.FindAsync(id);
            db.Drafts.Remove(draft);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/AdminView
        public ActionResult AdminView()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,Caryear,Carmake,Carmodel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                CalculateQuote(ref insuree);

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,Caryear,Carmake,Carmodel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                CalculateQuote(ref insuree);

                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
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

        public void CalculateQuote(ref Insuree insuree)
        {
            int basePrice = 50;
            DateTime today = DateTime.Today;
            int age = today.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth > today.AddYears(-age)) age--;

            // Age-based pricing
            if (age <= 18)
            {
                basePrice += 100;
            }
            else if (age >= 19 && age <= 25)
            {
                basePrice += 50;
            }
            else
            {
                basePrice += 25;
            }

            // Car year pricing
            if (insuree.Caryear < 2000 || insuree.Caryear > 2015)
            {
                basePrice += 25;
            }

            // Car make and model pricing
            if (insuree.Carmake.Equals("Porsche", StringComparison.OrdinalIgnoreCase))
            {
                basePrice += 25;
                if (insuree.Carmodel.Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
                {
                    basePrice += 25;
                }
            }

            // Speeding tickets pricing
            basePrice += insuree.SpeedingTickets * 10;

            // DUI pricing
            if (insuree.DUI)
            {
                basePrice = (int)(basePrice * 1.25);
            }

            // Coverage type pricing
            // in this case "true" means full coverage
            if (insuree.CoverageType == true)
            {
                basePrice = (int)(basePrice * 1.5);
            }

            insuree.Quote = basePrice;
        }
    }
}

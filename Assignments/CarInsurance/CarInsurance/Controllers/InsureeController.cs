using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModel;

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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType, Quote")] Insuree insuree)
        {
            //Calculating Age Quote
            insuree.Quote = 50; //Initial Quote
            DateTime now = DateTime.Today; //For Calculating User's Age
            int userAge = now.Year - insuree.DateOfBirth.Year; // User's Age

            //Age Confirmation
            if (userAge <= 18)
            {
                insuree.Quote = insuree.Quote + 100;
            }
            else if (userAge >= 19 && userAge <=25)
            {
                insuree.Quote = insuree.Quote + 50;
            }
            else if (userAge >= 26)
            {
                insuree.Quote = insuree.Quote + 25;
            }
            //Calculation CarYear Quote
            if (insuree.CarYear <= 2000)
            {
                insuree.Quote = insuree.Quote + 25;
            }
            else if (insuree.CarYear >= 2015)
            {
                insuree.Quote = insuree.Quote + 25;
            }
            //Checks if CarMake is a "Porsche"
            if (insuree.CarMake == "Porsche")
            {
                insuree.Quote = insuree.Quote + 25;
                //Checks if the model is a "911 Carrera"
                if (insuree.CarModel == "911 Carrera" || insuree.CarModel == "911Carrera")
                {
                    insuree.Quote = insuree.Quote + 25;
                }
            }
            //Checks for speeding tickets, +$10 per speeding ticket 
            int ticket = insuree.SpeedingTickets * 10;
            insuree.Quote = insuree.Quote + ticket;
            
            //If user has DUI, add 25% to the total
            if (insuree.DUI == true)
            {
                decimal percentage = insuree.Quote * 0.25M;
                insuree.Quote = insuree.Quote + percentage;
            }
            //If full coverage, adds 50% to the total
            if (insuree.CoverageType == true)
            {
                decimal percentage = insuree.Quote * 0.5M;
                insuree.Quote = insuree.Quote + percentage;
            }


            if (ModelState.IsValid)
            {
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
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
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

        //ADMIN
        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var users = db.Insurees.ToList();
                var AdminVM = new List<AdminVM>();
                foreach (var user in users)
                {
                    var adminVm = new AdminVM();
                    adminVm.FirstName = user.FirstName;
                    adminVm.LastName = user.LastName;
                    adminVm.EmailAddress = user.EmailAddress;
                    adminVm.Quote = user.Quote;
                    AdminVM.Add(adminVm);

                }
                return View(AdminVM);
            }

            
        }
        
    }
}

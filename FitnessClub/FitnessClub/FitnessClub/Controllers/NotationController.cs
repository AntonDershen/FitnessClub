using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitnessClub.Models;

namespace FitnessClub.Controllers
{
    public class NotationController : Controller
    {
        //
        // GET: /Notation/
        [Authorize]
        public void AddNotation(string name,string number)
        {
            using (var db = new EntityModel())
            {
                Notation newNotation = new Notation();
                newNotation.Name = name;
                newNotation.PhoneNumber = number;
                db.Notations.Add(newNotation);
                db.SaveChanges();
            }
        }
        [Authorize]
        public ActionResult ViewNotation()
        {
            List<Notation> notations = new List<Notation>();
            using (var db = new EntityModel())
            {
                notations = db.Notations.ToList();
            }
            return View(notations);
        }

        [Authorize]
        public ActionResult RemoveNotation(string id)
        {
            using (var db = new EntityModel())
            {
                var notation = db.Notations.Find(Convert.ToInt32(id));
                if (notation != null)
                    db.Notations.Remove(notation);
                db.SaveChanges();
            }
            return RedirectToAction("ViewNotation");
        }
	}
}
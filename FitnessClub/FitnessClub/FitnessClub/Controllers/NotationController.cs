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
	}
}
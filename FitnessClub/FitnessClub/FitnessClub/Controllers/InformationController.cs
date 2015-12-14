using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitnessClub.Models;

namespace FitnessClub.Controllers
{
    public class InformationController : Controller
    {
        public string GetInformationBody(string id)
        {
            using (var db = new EntityModel())
            {
                var information = db.Information.Find(Convert.ToInt32(id));
                if (information != null)
                    return information.Body;
                else return String.Empty;

            }

        }
        public string GetInformationHeader(string id)
        {
            using (var db = new EntityModel())
            {
                var information = db.Information.Find(Convert.ToInt32(id));
                if (information != null)
                    return information.Header;
                else return String.Empty;
            }

        }
        public void SetInformationBody(string id, string bodyText)
        {
            using (var db = new EntityModel())
            {
                bodyText = bodyText.Replace("#%^", "<").Replace("#&*", ">");
                var information = db.Information.Find(Convert.ToInt32(id));
                if (information != null)
                    information.Body = bodyText;
                db.SaveChanges();
            }

        }
        [HttpPost]
        public void SetInformationHeader(string id, string header)
        {
            using (var db = new EntityModel())
            {
                var information = db.Information.Find(Convert.ToInt32(id));
                if (information != null)
                    information.Header = header;
                db.SaveChanges();
            }

        }
	}

}
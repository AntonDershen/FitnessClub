using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessClub.Models
{
    public class Information
    {
        [Key]
        public int InformationId { get; set; }
        [AllowHtml]
        public string Header { get; set; }
        [AllowHtml]
        public string Body { get; set; }
    }
}
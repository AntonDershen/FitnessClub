using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessClub.Models
{
    public class Notation
    {
        [Key]
        public int NotationId { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }
    }
}
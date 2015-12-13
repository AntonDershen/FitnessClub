using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace FitnessClub.Models
{
    public class EntityModel : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Notation> Notations { get; set; }
    }
}
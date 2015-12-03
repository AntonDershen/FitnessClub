using System.ComponentModel.DataAnnotations;

namespace FitnessClub.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
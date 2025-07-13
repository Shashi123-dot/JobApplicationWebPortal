using System.ComponentModel.DataAnnotations;

namespace ApplicationWebPortal.Models
{
    public class AdminDetails
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Admin" or "HR"
    }
}

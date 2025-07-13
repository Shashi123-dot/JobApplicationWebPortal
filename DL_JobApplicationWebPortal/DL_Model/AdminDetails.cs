namespace ApplicationWebPortal.Models
{
    public class AdminDetails
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Admin" or "HR"
    }
}

using System.ComponentModel.DataAnnotations;

namespace ApplicationWebPortal.Models
{
    public class CandidateBasicInfo
    {
        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Enter valid 10-digit mobile number")]
        public string Mobile { get; set; }

        public string Location { get; set; }

        public string Experience { get; set; }
    }
}

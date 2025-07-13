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
        public string DesiredRole { get; set; }

        // Step 2 - Project
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public string Technologies { get; set; }

        // Step 3 - Education
        public string PGCollege { get; set; }
        public string PGUniversity { get; set; }
        public string PGYear { get; set; }
        public string PGScore { get; set; }

        public string UGCollege { get; set; }
        public string UGUniversity { get; set; }
        public string UGYear { get; set; }
        public string UGScore { get; set; }

        public string IntermediateSchool { get; set; }
        public string IntermediateBoard { get; set; }
        public string IntermediateYear { get; set; }
        public string IntermediateScore { get; set; }

        // Step 4 - Skills
        public string Tools { get; set; }
        public string Languages { get; set; }

        // Step 5 - Achievements
        public string Certifications { get; set; }
        public string Achievements { get; set; }
    }
}

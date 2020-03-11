using System.ComponentModel.DataAnnotations;

namespace SchoolLibrary
{
    public class Speaker
    {
        public string SpeakerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string AreaOfSpec { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string Employer { get; set; }
    }
}
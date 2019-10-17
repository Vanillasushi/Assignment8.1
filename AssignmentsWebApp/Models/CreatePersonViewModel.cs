using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AssignmentsWebApp.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [StringLength(25)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Range(0,120)]
        public int Age { get; set; }
        
        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public string Country { get; set; }
    }


}

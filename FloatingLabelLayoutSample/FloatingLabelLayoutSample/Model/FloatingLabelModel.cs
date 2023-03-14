using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FloatingLabelLayoutSample
{
    internal class FloatingLabelModel
    {
        [Display(Name = "First Name", Prompt = "Enter your first name")]
        [DataFormDisplayOptions(ValidMessage = "Valid name")]
        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(10, ErrorMessage = "First name should not exceed 10 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [Required(ErrorMessage = "Please enter your middle name")]
        [StringLength(10, ErrorMessage = "First name should not exceed 10 characters")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name")]
        [StringLength(10, ErrorMessage = "First name should not exceed 10 characters")]
        public string LastName { get; set; }

        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Display(Name = "Email", Prompt = "Enter your email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        public string Address { get; set; }
    }
}

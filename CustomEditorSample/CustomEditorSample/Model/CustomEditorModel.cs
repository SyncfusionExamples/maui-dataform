using System.ComponentModel.DataAnnotations;

namespace CustomEditorSample
{
    public class CustomEditorModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Contact Number")]
        public double ContactNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}

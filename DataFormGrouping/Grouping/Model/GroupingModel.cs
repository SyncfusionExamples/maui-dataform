using System.ComponentModel.DataAnnotations;

namespace Grouping
{
    public class GroupingModel
    {
        [Display(Name = "First Name", GroupName = "Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name", GroupName = "Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name", GroupName = "Name")]
        public string LastName { get; set; }

        [Display(Name = "Contact Number", GroupName = "Details")]
        public string ContactNumber { get; set; }

        [Display(GroupName = "Details")]
        public string Email { get; set; }

        [Display(GroupName = "Details")]
        public string Address { get; set; }

    }
}

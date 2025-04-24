using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Maui.DataForm;

namespace Localization
{
    internal class LocalizationModel
    {
        [Display(Name = "FirstName", GroupName = "Name", Prompt = "PromptText", ResourceType = typeof(DataFormLocalization))]
        [DataFormDisplayOptions(ValidMessage = "ValidMessage")]
        [Required(ErrorMessage = "Value should not be empty", ErrorMessageResourceName = "ErrorMessage", ErrorMessageResourceType = typeof(DataFormLocalization))]
        public string? FirstName { get; set; }

        [Display(Name = "LastName", GroupName = "Name", ResourceType = typeof(DataFormLocalization))]
        public string? LastName { get; set; }

        [Display(GroupName = "Details", ResourceType = typeof(DataFormLocalization))]
        public Gender Gender { get; set; }

        [Display(GroupName = "Details", ResourceType = typeof(DataFormLocalization))]
        public string? Email { get; set; }

        [Display(Name = "Address", ResourceType = typeof(DataFormLocalization))]
        public string? Address { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}

using System.ComponentModel.DataAnnotations;

namespace ManualDataFormItemSample
{
    public class DataFormModel
    {
        public string ProfileImage { get; set; }

        [Display(Prompt="First name" , GroupName= "Name")]
        public string Name { get; set; }

        [Display(GroupName = "Name", Prompt="Last name")]
        public string LastName { get; set; }

        [Display(Prompt = "Mobile", GroupName = "Mobile")]
        public string Mobile { get; set; }

        [Display(Prompt = "Landline", GroupName = "Mobile")]
        public string Landline { get; set; }

        [Display(Prompt = "Address", GroupName = "Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Display(Prompt = "City", GroupName = "Address")]
        public string City { get; set; }

        [Display(Prompt = "State", GroupName = "Address")]
        public string State { get; set;  }

        [Display(Prompt = "Zip code", GroupName = "Address")]
        public string ZipCode { get; set; }

        [Display(Prompt = "Email", GroupName = "Address")]
        public string Email { get; set; }
    }
}

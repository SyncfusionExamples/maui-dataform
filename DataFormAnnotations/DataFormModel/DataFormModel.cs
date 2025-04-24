using Syncfusion.Maui.DataForm;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace DataFormAnnotations
{
    public class DataFormModel
    {
        [Display(Prompt = "Enter your first name", Name = "Name")]
        [Required(ErrorMessage = "Please enter your first name")]
        public string? FirstName { get; set; }

        [Display(AutoGenerateField = false)]
        public string? Email { get; set; }

        [StringLength(10, MinimumLength = 6, ErrorMessage = "Please enter a valid number")]
        public string? MobileNumber { get; set; }

        [Bindable(false)]
        public double? Landline { get; set; }

        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Password length must be greater than 5 characters")]
        [MaxLength(20, ErrorMessage = "Maximum password length should be less than 20")]
        public string? Password { get; set; }

        [EnumDataType(typeof(Gender), ErrorMessage = "Please select Gender")]
        public Gender Gender { get; set; }

        [DataFormDateRange(MinimumDate ="2022/12/25", MaximumDate ="2023/01/05", DisplayFormat ="yyyy/MM/dd", ErrorMessage = "Please select a date between 2022/12/25 and 2023/01/05")]
        public DateTime EventDate { get; set; }
        
        [DataType(DataType.MultilineText)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string? Address { get; set; }

        [ReadOnly(true)]
        public string? City { get; set; }

        [Editable(false)]
        public string? State { get; set; }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        public string? Country { get; set; }

        public string? ZipCode { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Others
    }
}

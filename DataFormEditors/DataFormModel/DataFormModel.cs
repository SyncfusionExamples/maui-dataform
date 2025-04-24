using Syncfusion.Maui.DataForm;
using System.ComponentModel.DataAnnotations;
namespace EditorsSample
{
    public class DataFormModel
    {
        public string Prefix { get; set; }

        public string Name { get; set; }

        [DataFormDisplayOptions(ColumnSpan =2)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        public string Password { get; set; }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        public Gender Gender { get; set; }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        public string BirthTime { get; set; }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        public string BirthDate { get; set; }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        public bool FirstGraduate { get; set; }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        public bool ReadyToRelocate { get; set; }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        public string City { get; set; }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        public string Country { get; set; }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        public double Fee { get; set; }

    }

    public enum Gender
    {
        Male,
        Female,
        Others
    }
}

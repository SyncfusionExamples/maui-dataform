using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataErrorInfoSample
{
    public class DataFormModel  : IDataErrorInfo
    {
        public string? EmployeeID { get; set; }

        public string? Name { get; set; }

        public string Title { get; set; } = string.Empty;

        [Display(AutoGenerateField = false)]
        public string Error
        {
            get
            {
                return string.Empty;
            }
        }

        [Display(AutoGenerateField = false)]
        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Title) && this.Title.Contains("Marketing"))
                {
                    return "Marketing is not allowed";
                }

                return string.Empty;
            }
        }
    }
}
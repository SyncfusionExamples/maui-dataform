using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NotifyDataErrorInfoSample
{
    public class EmployeeInfo : INotifyDataErrorInfo
    {
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public string? EmployeeID { get; set; }

        public string? Name { get; set; }

        public string? Title { get; set; }

        [Display(AutoGenerateField = false)]
        public bool HasErrors
        {
            get
            {
                return false;
            }
        }

        public IEnumerable GetErrors(string? propertyName)
        {
            List<string> list = new List<string>();
            if (propertyName == nameof(Title) && this.Title.Contains("Marketing"))
            {
                list.Add("Marketing is not allowed");
            }

            return list;
        }
    }
}

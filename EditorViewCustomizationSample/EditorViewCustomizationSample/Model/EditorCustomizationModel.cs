using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorViewCustomizationSample
{
    public class EditorCustomizationModel
    {
        public string? Name { get; set; }

        [DataType(DataType.Password)]
        public string? PassWord { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }

        public bool Switch { get; set; }
        public bool CheckBox { get; set; }

        [DataType(DataType.Date)]
        public string? Date { get; set; }

        [DataType(DataType.Time)]
        public string? Time { get; set; }
        public string? AutoComplete { get; set; }
        public string? ComboBox { get; set; }
        public string? Picker { get; set; }
        public string? RadioButton { get; set; }
    }
}

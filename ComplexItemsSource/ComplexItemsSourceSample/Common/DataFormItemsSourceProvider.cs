using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexItemsSourceSample
{
    internal class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "ComboBox" || sourceName == "AutoComplete" || sourceName == "Picker" || sourceName == "RadioGroup")
            {
                List<ComplexModel> details = new List<ComplexModel>();
                details.Add(new ComplexModel() { ID = 1, Name = "Eric" });
                details.Add(new ComplexModel() { ID = 2, Name = "James" });
                details.Add(new ComplexModel() { ID = 3, Name = "Jacob" });
                details.Add(new ComplexModel() { ID = 4, Name = "Lucas" });
                return details;
            }
            return new List<string>();
        }
    }
}

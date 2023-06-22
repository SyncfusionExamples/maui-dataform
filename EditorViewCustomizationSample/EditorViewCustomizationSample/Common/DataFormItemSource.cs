using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorViewCustomizationSample.Common
{
    internal class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "ComboBox" || sourceName == "AutoComplete" || sourceName == "Picker" || sourceName == "RadioButton")
            {
                List<string> source = new List<string>();
                source.Add("One");
                source.Add("Two");
                source.Add("Three");
                return source;
            }
            return new List<string>();
        }
    }
}


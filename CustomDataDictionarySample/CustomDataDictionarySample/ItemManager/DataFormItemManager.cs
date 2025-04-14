using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataDictionarySample
{
    internal class DataFormItemManagerExt : DataFormItemManager
    {
        Dictionary<string, object> dataFormDictionary;

        public DataFormItemManagerExt(Dictionary<string, object> dictionary)
        {
            dataFormDictionary = dictionary;
        }

        public override object GetValue(DataFormItem dataFormItem)
        {
            return dataFormDictionary[dataFormItem.FieldName];
        }

        public override void SetValue(DataFormItem dataFormItem, object? value)
        {
            if(value == null)
            {
                return;
            }
            dataFormDictionary[dataFormItem.FieldName] = value;
        }
    }
}

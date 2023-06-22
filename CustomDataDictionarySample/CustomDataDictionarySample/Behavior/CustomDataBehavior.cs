using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataDictionarySample
{
    internal class CustomDataBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("Name", "John");
            dictionary.Add("Password", "1234");
            dictionary.Add("Check", true);
            dictionary.Add("Switch", true);
            dictionary.Add("DoB", DateTime.Now.Date);
            dictionary.Add("Time", DateTime.Now);
            dictionary.Add("Address", "");
            dictionary.Add("Picker", "one");
            dictionary.Add("ComboBox", "two");
            dictionary.Add("AutoComplete", "three");
            dictionary.Add("RadioGroup", "one");

            ObservableCollection<DataFormViewItem> items = new ObservableCollection<DataFormViewItem>();
            foreach (var key in dictionary.Keys)
            {
                DataFormItem dataFormItem = null;
                if (key == "Name")
                {
                    dataFormItem = new DataFormTextItem()
                    {
                        FieldName = key,
                    };
                }
                else if (key == "Check")
                {
                    dataFormItem = new DataFormCheckBoxItem()
                    {
                        FieldName = key,
                    };

                }
                else if (key == "Switch")
                {
                    dataFormItem = new DataFormSwitchItem()
                    {
                        FieldName = key,
                    };

                }
                else if (key == "Password")
                {
                    dataFormItem = new DataFormPasswordItem()
                    {
                        FieldName = key,
                    };
                }
                else if (key == "Address")
                {
                    dataFormItem = new DataFormMultilineItem()
                    {
                        FieldName = key,
                    };
                }
                else if (key == "DoB")
                {
                    dataFormItem = new DataFormDateItem()
                    {
                        FieldName = key,
                    };
                }
                else if (key == "Time")
                {
                    dataFormItem = new DataFormTimeItem()
                    {
                        FieldName = key,
                    };
                }
                else if (key == "Picker")
                {
                    dataFormItem = new DataFormPickerItem()
                    {
                        FieldName = key,
                        ItemsSource = new List<string> { "one", "two", "three" },
                    };
                }
                else if (key == "ComboBox")
                {
                    dataFormItem = new DataFormComboBoxItem()
                    {
                        FieldName = key,
                        ItemsSource = new List<string> { "one", "two", "three" },
                    };
                }
                else if (key == "AutoComplete")
                {
                    dataFormItem = new DataFormAutoCompleteItem()
                    {
                        FieldName = key,
                        ItemsSource = new List<string> { "one", "two", "three" },
                    };
                }
                else if (key == "RadioGroup")
                {
                    dataFormItem = new DataFormRadioGroupItem()
                    {
                        FieldName = key,
                        ItemsSource = new List<string> { "one", "two", "three" },
                    };
                }

                if (dataFormItem != null)
                {
                    items.Add(dataFormItem);
                }
            }

            dataForm.Items = items;
            dataForm.AutoGenerateItems = false;
            dataForm.ItemManager = new DataFormItemManagerExt(dictionary);
        }

    }

}

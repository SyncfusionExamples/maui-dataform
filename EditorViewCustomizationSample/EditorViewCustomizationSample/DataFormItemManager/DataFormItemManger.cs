using Syncfusion.Maui.DataForm;
using Syncfusion.Maui.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorViewCustomizationSample
{
    public class DataFormItemMangerExt : DataFormItemManager
    {
        public override void InitializeDataEditor(DataFormItem dataFormItem, View editor)
        {
            if (editor is Entry entry)
            {
                entry.TextColor = Colors.Red;
                entry.FontAttributes = FontAttributes.Bold;
                entry.SelectionLength = 5;
                entry.TextTransform = TextTransform.Lowercase;
                entry.VerticalTextAlignment = TextAlignment.Center;
            }
            else if (editor is Editor editor1)
            {
                editor1.TextColor = Colors.Green;
                editor1.FontAttributes = FontAttributes.Bold;
                editor1.SelectionLength = 5;
                editor1.TextTransform = TextTransform.Lowercase;
                editor1.VerticalTextAlignment = TextAlignment.Center;

            }
            else if (editor is Switch switchEditor)
            {
                switchEditor.OnColor = Colors.Red;
                switchEditor.ThumbColor = Colors.Purple;
                switchEditor.IsToggled = true;
            }
            else if (editor is CheckBox check)
            {
                check.Color = Colors.Green;
                check.Background = Colors.Blue;
            }
            else if (editor is DatePicker date)
            {
                date.TextColor = Colors.Green;
            }
            else if (editor is TimePicker timePicker)
            {
                timePicker.TextColor = Colors.BlueViolet;
            }
            else if (editor is Picker picker)
            {
                picker.TextColor = Colors.BlueViolet;
                picker.TitleColor = Colors.Green;
            }
            else if (editor is SfAutocomplete autoComplete)
            {
                autoComplete.TextColor = Colors.DimGray;
            }
            else if (editor is SfComboBox comboBox)
            {
                comboBox.TextColor = Colors.BurlyWood;
            }
            else if (editor is VerticalStackLayout layout)
            {
                foreach (RadioButton radioButton in layout.Children.OfType<RadioButton>())
                {
                    radioButton.TextColor = Colors.BlanchedAlmond;
                }

            }
        }
    }
}

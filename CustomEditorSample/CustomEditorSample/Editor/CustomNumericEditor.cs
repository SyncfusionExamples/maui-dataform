using Syncfusion.Maui.DataForm;
using System.Text.RegularExpressions;

namespace CustomEditorSample
{
    public class CustomNumericEditor : IDataFormEditor
    {
        private SfDataForm dataForm;
        private DataFormCustomItem dataFormCustomItem;

        public CustomNumericEditor(SfDataForm dataForm)
        {
            this.dataForm = dataForm;
        }

        public View CreateEditorView(DataFormItem dataFormItem)
        {
            Entry view = new Entry();
            view.Keyboard = Keyboard.Numeric;
            view.Placeholder = dataFormItem.PlaceholderText;
            DataFormTextStyle textStyle = dataForm.EditorTextStyle;
            view.TextColor = textStyle.TextColor;
            view.FontSize = textStyle.FontSize;
            view.FontFamily = textStyle.FontFamily;
            view.FontAttributes = textStyle.FontAttributes;
            view.TextChanged += this.OnViewTextChanged;
            this.dataFormCustomItem = (DataFormCustomItem)dataFormItem;
            this.dataFormCustomItem.EditorValue = string.Empty;
            return view;
        }

        private void OnViewTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is not InputView numericEntry || dataFormCustomItem == null)
            {
                return;
            }

            string numericText = Regex.Replace(numericEntry.Text, "[^0-9]+", string.Empty);
            if (numericText != numericEntry.Text)
            {
                numericEntry.Text = numericText;
                return;
            }

            dataFormCustomItem.EditorValue = numericText;
            this.ValidateValue(dataFormCustomItem);
            this.CommitValue(dataFormCustomItem, numericEntry);
        }

        public void CommitValue(DataFormItem dataFormItem, View view)
        {
            if (view is InputView numericText)
            {
                double numericValue;
                double.TryParse(numericText.Text, out numericValue);
                dataFormItem.SetValue(numericValue);
            }
        }

        private void ValidateValue(DataFormItem dataFormItem)
        {
            dataForm.Validate(new List<string>() { dataFormItem.FieldName });
        }

        public void UpdateReadyOnly(DataFormItem dataFormItem)
        {
        }
    }
}

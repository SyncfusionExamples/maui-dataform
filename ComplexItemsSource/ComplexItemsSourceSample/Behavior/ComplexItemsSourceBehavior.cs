using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexItemsSourceSample
{
    internal class ComplexItemsSourceBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
            dataForm.RegisterEditor(nameof(ComplexItemsSourceModel.ComboBox), DataFormEditorType.ComboBox);
            dataForm.RegisterEditor(nameof(ComplexItemsSourceModel.AutoComplete), DataFormEditorType.AutoComplete);
            dataForm.RegisterEditor(nameof(ComplexItemsSourceModel.Picker), DataFormEditorType.Picker);
            dataForm.RegisterEditor(nameof(ComplexItemsSourceModel.RadioGroup), DataFormEditorType.RadioGroup);
            dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
        }

        private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null && e.DataFormItem is DataFormListItem listItem)
            {
                listItem.DisplayMemberPath = "Name";
                listItem.SelectedValuePath = "ID";
            }
        }

        protected override void OnDetachingFrom(SfDataForm dataForm)
        {
            base.OnDetachingFrom(dataForm);
        }
    }
}

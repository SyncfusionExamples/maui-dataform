using EditorViewCustomizationSample.Common;
using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorViewCustomizationSample
{
    internal class EditorCustomizationBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
            dataForm.RegisterEditor(nameof(EditorCustomizationModel.Switch), DataFormEditorType.Switch);
            dataForm.RegisterEditor(nameof(EditorCustomizationModel.Picker), DataFormEditorType.Picker);
            dataForm.RegisterEditor(nameof(EditorCustomizationModel.AutoComplete), DataFormEditorType.AutoComplete);
            dataForm.RegisterEditor(nameof(EditorCustomizationModel.ComboBox), DataFormEditorType.ComboBox);
            dataForm.RegisterEditor(nameof(EditorCustomizationModel.RadioButton), DataFormEditorType.RadioGroup);
            dataForm.ItemManager = new DataFormItemMangerExt();
        }
    }
}

using Syncfusion.Maui.DataForm;
namespace EditorsSample
{
    public class DataFormBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.ColumnCount = 2;
            dataForm.ItemsSourceProvider = new ItemSourceProviderExt();
            dataForm.RegisterEditor("Gender", DataFormEditorType.RadioGroup);
            dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);
            dataForm.RegisterEditor("City", DataFormEditorType.ComboBox);
            dataForm.RegisterEditor("Password", DataFormEditorType.Password);
            dataForm.RegisterEditor("ReadyToRelocate", DataFormEditorType.Switch);
            dataForm.RegisterEditor("Prefix", DataFormEditorType.Picker);
            dataForm.RegisterEditor("BirthTime", DataFormEditorType.Time);
            dataForm.RegisterEditor("BirthDate", DataFormEditorType.Date);
        }
    }
}

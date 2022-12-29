using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEditorSample
{
    internal class CustomEditorBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.RegisterEditor(nameof(CustomEditorModel.ContactNumber), new CustomNumericEditor(dataForm));
        }

        protected override void OnDetachingFrom(SfDataForm dataForm)
        {
            base.OnDetachingFrom(dataForm);
        }
    }
}

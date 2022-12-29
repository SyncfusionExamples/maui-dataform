using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localization
{
    internal class LocalizationBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.DataObject = new LocalizationModel();
            dataForm.RegisterEditor("Gender", DataFormEditorType.RadioGroup);
            dataForm.ValidateProperty += OnDataFormValidateProperty;
        }

        private void OnDataFormValidateProperty(object sender, DataFormValidatePropertyEventArgs e)
        {
            if (e.PropertyName == nameof(LocalizationModel.LastName))
            {
                if (string.IsNullOrEmpty(e.NewValue?.ToString()))
                {
                    e.ErrorMessage = DataFormLocalization.ErrorMessage;
                }
                else
                {
                    e.ValidMessage = DataFormLocalization.ValidMessage;
                }
            }
        }

        protected override void OnDetachingFrom(SfDataForm dataForm)
        {
            base.OnDetachingFrom(dataForm);
            dataForm.ValidateProperty +=this.OnDataFormValidateProperty;
        }
    }
}

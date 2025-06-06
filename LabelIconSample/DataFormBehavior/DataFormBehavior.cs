﻿using Syncfusion.Maui.DataForm;

namespace LabelIconSample
{
    public class DataFormBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.GenerateDataFormItem += this.OnGenerateDataFormItem;
            dataForm.DefaultLayoutSettings.LabelWidth = new DataFormItemLength(0.2, DataFormItemLengthUnitType.Star);
            dataForm.DefaultLayoutSettings.EditorWidth = new DataFormItemLength(0.8, DataFormItemLengthUnitType.Star);
        }

        private void OnGenerateDataFormItem(object? sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.FieldName == nameof(DataFormModel.Name))
                {
                    e.DataFormItem.LeadingView = new Image { Source =  new FontImageSource() { Glyph = "F", FontFamily = "InputLayoutIcons" } }; 
                }

                if(e.DataFormItem.FieldName == nameof(DataFormModel.Address))
                {
                    e.DataFormItem.LeadingView = new Image { Source = new FontImageSource() { Glyph = "C", FontFamily = "InputLayoutIcons" } };
                }

                if (e.DataFormItem.FieldName == nameof(DataFormModel.Email))
                {
                    e.DataFormItem.LeadingView = new Image { Source = new FontImageSource() { Glyph = "G", FontFamily = "InputLayoutIcons" } };
                }

                if (e.DataFormItem.FieldName == nameof(DataFormModel.Phone))
                {
                    e.DataFormItem.LeadingView = new Image { Source = new FontImageSource() { Glyph = "E", FontFamily = "InputLayoutIcons" } };
                }
            }
        }

        protected override void OnDetachingFrom(SfDataForm dataForm)
        {
            base.OnDetachingFrom(dataForm);
            dataForm.GenerateDataFormItem -= this.OnGenerateDataFormItem;
        }
    }
}

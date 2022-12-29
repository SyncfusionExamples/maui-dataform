using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grouping
{
    internal class GroupingBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.GenerateDataFormItem += this.OnGenerateDataFormItem;
        }

        private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormGroupItem != null)
            {
                if (e.DataFormGroupItem.Name == "Details")
                {
                    e.DataFormGroupItem.ItemsPadding = 20;
                    e.DataFormGroupItem.HeaderBackground = Brush.Yellow;
                    e.DataFormGroupItem.ColumnCount = 2;
                    e.DataFormGroupItem.HeaderTextStyle = new DataFormTextStyle
                    {
                        TextColor = Colors.Violet,
                        FontSize = 12,
                        FontAttributes = FontAttributes.Italic,
                    };
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

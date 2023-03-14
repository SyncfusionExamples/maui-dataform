using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Maui.DataForm;

namespace FloatingLabelLayoutSample
{
    internal class FloatingLabelBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
        }

        private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.FieldName == nameof(FloatingLabelModel.FirstName))
                {
                    e.DataFormItem.ValidMessageLabelTextStyle = new DataFormTextStyle { TextColor = Colors.GreenYellow, FontAttributes = FontAttributes.Italic };
                    e.DataFormItem.LeadingView = new Label { Text = "F", FontSize = 18, TextColor = Colors.Gray, FontFamily = "InputLayoutIcons", HeightRequest = 24, VerticalTextAlignment = TextAlignment.End };
                    e.DataFormItem.TextInputLayoutSettings = new TextInputLayoutSettings
                    {
                        ContainerType = TextInputLayoutContainerType.Outlined,
                        HelperTextStyle = new DataFormTextStyle { TextColor = Colors.Violet, FontAttributes = FontAttributes.Bold },
                    };
                }
                else if (e.DataFormItem.FieldName == nameof(FloatingLabelModel.MiddleName))
                {
                    e.DataFormItem.ErrorLabelTextStyle = new DataFormTextStyle { TextColor = Colors.Indigo, FontAttributes = FontAttributes.Italic };
                    e.DataFormItem.TextInputLayoutSettings = new TextInputLayoutSettings
                    {
                        ContainerType = TextInputLayoutContainerType.Filled,
                        OutlineCornerRadius = 10,
                        Stroke = Colors.BlueViolet,
                    };
                }
                else if (e.DataFormItem.FieldName == nameof(FloatingLabelModel.LastName))
                {
                    e.DataFormItem.TextInputLayoutSettings = new TextInputLayoutSettings
                    {
                        ContainerType = TextInputLayoutContainerType.None,
                        FocusedStroke = Colors.AliceBlue,
                    };
                }
                else if (e.DataFormItem.FieldName == nameof(FloatingLabelModel.ContactNumber))
                {
                    e.DataFormItem.TrailingView = new Label { Text = "E", FontSize = 18, TextColor = Colors.Gray, FontFamily = "InputLayoutIcons", HeightRequest = 24, VerticalTextAlignment = TextAlignment.End };
                    e.DataFormItem.TrailingViewPosition = TextInputLayoutViewPosition.Inside;
                }
                else if (e.DataFormItem.FieldName == nameof(FloatingLabelModel.Email))
                {
                    e.DataFormItem.TextInputLayoutSettings = new TextInputLayoutSettings
                    {
                        FocusedStrokeThickness = 3.0,
                        UnfocusedStrokeThickness = 4.0,
                    };
                }
                else if (e.DataFormItem.FieldName == nameof(FloatingLabelModel.Address))
                {
                    e.DataFormItem.LabelTextStyle = new DataFormTextStyle { FontAttributes = FontAttributes.Italic, TextColor = Colors.BlueViolet };
                }
            }

        }

        protected override void OnDetachingFrom(SfDataForm dataForm)
        {
            base.OnDetachingFrom(dataForm);
        }
    }
}

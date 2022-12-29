using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualValidation
{
    internal class ValidationBehavior : Behavior<ContentPage>
    {
        /// <summary>
        /// Holds the data form object.
        /// </summary>
        private SfDataForm dataForm;

        /// <summary>
        /// Holds the sign in button instance.
        /// </summary>
        private Button validate;

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.dataForm = bindable.FindByName<SfDataForm>("dataForm");
            this.validate = bindable.FindByName<Button>("Validate");
            if (this.validate != null)
            {
                this.validate.Clicked += this.OnValidateClicked;
            }
        }

        private async void OnValidateClicked(object sender, EventArgs e)
        {
            if (this.dataForm != null && Application.Current?.MainPage != null)
            {
                if (this.dataForm.Validate())
                {
                    await Application.Current.MainPage.DisplayAlert("", "Successfully Validated", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("", "Please enter the required details", "OK");
                }
            }
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.validate != null)
            {
                this.validate.Clicked -= this.OnValidateClicked;
            }
        }
    }
}

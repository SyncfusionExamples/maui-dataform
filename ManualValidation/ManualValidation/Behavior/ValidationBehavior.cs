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
        private SfDataForm? dataForm;

        /// <summary>
        /// Holds the sign in button instance.
        /// </summary>
        private Button? validate;

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

        private async void OnValidateClicked(object? sender, EventArgs e)
        {
            if (this.dataForm != null)
            {
                if (this.dataForm.Validate())
                {
                    await DisplayAlert("", "Successfully Validated", "OK");
                }
                else
                {
                    await DisplayAlert("", "Please enter the required details", "OK");
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
        /// <summary>
        /// Displays an alert dialog to the user.
        /// </summary>
        /// <param name="title">The title of the alert dialog.</param>
        /// <param name="message">The message to display.</param>
        /// <param name="cancel">The text for the cancel button.</param>
        /// <returns>A task representing the asynchronous alert display operation.</returns>
        private Task DisplayAlert(string title, string message, string cancel)
        {
            return App.Current?.Windows?[0]?.Page!.DisplayAlert(title, message, cancel)
                   ?? Task.FromResult(false);
        }
    }
}

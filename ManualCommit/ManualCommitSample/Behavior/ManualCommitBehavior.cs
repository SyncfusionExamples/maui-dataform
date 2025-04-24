using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualCommitSample
{
    internal class ManualCommitBehavior : Behavior<ContentPage>
    {
        /// <summary>
        /// Holds the data form object.
        /// </summary>
        private SfDataForm? dataForm;

        /// <summary>
        /// Holds the sign in button instance.
        /// </summary>
        private Button? commit;

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.dataForm = bindable.FindByName<SfDataForm>("dataForm");

            this.commit = bindable.FindByName<Button>("Commit");
            if (this.commit != null)
            {
                this.commit.Clicked += OnCommitClicked;
            }
        }

        private async void OnCommitClicked(object? sender, EventArgs e)
        {
            if (this.dataForm == null )
            {
                return;
            }
            this.dataForm?.Commit();
            await DisplayAlert("", "Successfully committed", "OK");
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.commit != null)
            {
                this.commit.Clicked += OnCommitClicked;
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

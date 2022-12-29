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
        private SfDataForm dataForm;

        /// <summary>
        /// Holds the sign in button instance.
        /// </summary>
        private Button commit;

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

        private async void OnCommitClicked(object sender, EventArgs e)
        {
            if (this.dataForm != null && Application.Current?.MainPage != null)
            {
                this.dataForm.Commit();
                await Application.Current.MainPage.DisplayAlert("", "Successfully committed", "OK");
            }
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            this.commit.Clicked -= OnCommitClicked;
        }
    }
}

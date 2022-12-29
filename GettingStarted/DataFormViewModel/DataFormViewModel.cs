namespace GettingStarted
{
    public class DataFormViewModel
    {
        public ContactsInfo ContactsInfo { get; set; }

        public DataFormViewModel()
        {
            this.ContactsInfo = new ContactsInfo();
        }
    }
}

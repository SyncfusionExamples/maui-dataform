using Syncfusion.Maui.DataForm;
namespace EditorsSample
{
    internal class ItemSourceProviderExt : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "Prefix")
            {
                List<string> list = new List<string>() { "Mr.", "Ms.", "Mrs" };
                return list;
            }
            else if (sourceName == "Country")
            {
                List<string> country = new List<string>() { "USA", "Italy", "India" };
                return country;
            }
            else if (sourceName == "City")
            {
                List<string> city = new List<string>() { "Chennai", "California", "Calabria" };
                return city;
            }

            return new List<string>();
        }
    }
}

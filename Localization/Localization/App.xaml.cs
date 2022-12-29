using System.Globalization;

namespace Localization;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
        var culture = new CultureInfo("fr");
        CultureInfo.CurrentUICulture = culture;
    }
}

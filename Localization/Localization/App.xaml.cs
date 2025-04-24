using System.Globalization;

namespace Localization;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        var culture = new CultureInfo("fr");
        CultureInfo.CurrentUICulture = culture;
    }
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage());
    }
}

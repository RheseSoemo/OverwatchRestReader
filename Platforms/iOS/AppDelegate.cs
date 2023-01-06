using Foundation;

namespace OverwatchRestReader;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => OverwatchRestReaderMain.CreateMauiApp();
}

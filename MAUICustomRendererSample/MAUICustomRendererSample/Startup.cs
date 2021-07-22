using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;

[assembly: XamlCompilationAttribute(XamlCompilationOptions.Compile)]

namespace MAUICustomRendererSample
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseMauiApp<App>()
				.ConfigureMauiHandlers(handlers =>
                {
#if __ANDROID__
				handlers.AddCompatibilityRenderer(typeof(Label), typeof(MAUICustomRendererSample.Platforms.Android.MyLabelRenderer));
#endif

#if __IOS__
					handlers.AddCompatibilityRenderer(typeof(Label), typeof(MAUICustomRendererSample.Platforms.Android.MyLabelRenderer));
#endif
				})
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});
		}
	}
}
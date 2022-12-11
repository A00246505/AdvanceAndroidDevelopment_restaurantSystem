using ResturantSystemMaui.Models;
using ResturantSystemMaui.Views;
using ZXing.Net.Maui;

namespace ResturantSystemMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseBarcodeReader()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("materialdesignicons-webfont.ttf", "IconFontTypes");
            });

		builder.Services.AddTransient<NewPage1>();
        builder.Services.AddTransient<SignUpViewModel>();
        builder.Services.AddTransient<SignInPage>();
        builder.Services.AddTransient<SigninViewModel>();

        return builder.Build();
	}
}

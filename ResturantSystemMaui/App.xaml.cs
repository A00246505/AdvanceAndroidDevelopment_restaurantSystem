using Microsoft.Maui.Platform;
using ResturantSystemMaui.Handlers;
using ResturantSystemMaui.Service;

namespace ResturantSystemMaui;

public partial class App : Application
{
    static MenuService _menuService;
    public static MenuService MenuService
    {
        get
        {
            if(_menuService == null)
            {
                _menuService = new MenuService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Resturant.db3"));
            }
            return _menuService;
        }
    }
    public App()
    {
        InitializeComponent();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderLessEntry), (handler, view) =>
        {
            if (view is BorderLessEntry)
            {
#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
#elif __IOS__
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
            }
        });

        MainPage = new AppShell();
	}
}

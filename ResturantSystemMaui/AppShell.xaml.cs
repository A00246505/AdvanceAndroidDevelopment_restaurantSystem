using ResturantSystemMaui.Views;

namespace ResturantSystemMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));
		Routing.RegisterRoute(nameof(AddorEditMenuItem), typeof(AddorEditMenuItem));
        Routing.RegisterRoute(nameof(OrderedItemView), typeof(OrderedItemView));


    }
}

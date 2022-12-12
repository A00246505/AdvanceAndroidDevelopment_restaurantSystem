using ResturantSystemMaui.Models;

namespace ResturantSystemMaui.Views;

public partial class AddorEditMenuItem : ContentPage
{
	public MenuItemInfo MenuItemInfo { get; set; }
	public AddorEditMenuItem()
	{
		InitializeComponent();
		BindingContext = new AddorDeleteMenuItemViewModel();
	}

    public AddorEditMenuItem(MenuItemInfo menuItemInfo)
    {
        InitializeComponent();
        BindingContext = new AddorDeleteMenuItemViewModel();

		if(menuItemInfo != null)
		{
			((AddorDeleteMenuItemViewModel)BindingContext).MenuItemInfo = menuItemInfo;
		}
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		MenuItemInfo menuItem = ((AddorDeleteMenuItemViewModel)BindingContext).MenuItemInfo;
		MessagingCenter.Send(this, "AddorEditMenu",menuItem);
		
		Navigation.PopAsync();
    }
}
using ResturantSystemMaui.Models;

namespace ResturantSystemMaui.Views;

public partial class AddorEditMenuItem : ContentPage
{
	public AddorEditMenuItem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		MenuItemInfo menuItem = ((AddorDeleteMenuItemViewModel)BindingContext).MenuItem;
		MessagingCenter.Send(this, "AddorEditMenu",menuItem);
		
		Navigation.PopAsync();
    }
}
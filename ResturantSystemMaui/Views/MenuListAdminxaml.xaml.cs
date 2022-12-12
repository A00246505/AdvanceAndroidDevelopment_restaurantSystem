using ResturantSystemMaui.Models;

namespace ResturantSystemMaui.Views;

public partial class MenuListAdminxaml : ContentPage
{
    MenuItemViewModel menuViewModel;
	public MenuListAdminxaml()
	{
		InitializeComponent();
        BindingContext = menuViewModel = new MenuItemViewModel(Navigation);
	}

    private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {

    }

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddorEditMenuItem());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        menuViewModel.OnAppearing();
    }

}
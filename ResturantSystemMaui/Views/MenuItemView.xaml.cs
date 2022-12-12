using ResturantSystemMaui.Models;

namespace ResturantSystemMaui.Views;

public partial class MenuItem : ContentPage
{

    MenuItemViewModel menuViewModel;
    public MenuItem()
	{
		InitializeComponent();

        BindingContext = menuViewModel = new MenuItemViewModel(Navigation);


    }

	private async void MenuFlyoutItem_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//BarcodeScanner");
    }

    private void MenuFlyoutItem_Clicked_1(object sender, EventArgs e)
    {

    }


    protected override void OnAppearing()
    {
        base.OnAppearing();
        menuViewModel.OnAppearing();
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Review");
    }

    private async void ToolbarItem_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignInPage");
    }
}
namespace ResturantSystemMaui.Views;

public partial class MenuItem : ContentPage
{
	public MenuItem()
	{
		InitializeComponent();
		

	}

	private async void MenuFlyoutItem_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//BarcodeScanner");
    }

    private void MenuFlyoutItem_Clicked_1(object sender, EventArgs e)
    {

    }
}
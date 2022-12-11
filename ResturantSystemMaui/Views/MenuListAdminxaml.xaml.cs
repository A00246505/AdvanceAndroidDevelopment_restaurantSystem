namespace ResturantSystemMaui.Views;

public partial class MenuListAdminxaml : ContentPage
{
	public MenuListAdminxaml()
	{
		InitializeComponent();
	}

    private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {

    }

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddorEditMenuItem());
    }
}
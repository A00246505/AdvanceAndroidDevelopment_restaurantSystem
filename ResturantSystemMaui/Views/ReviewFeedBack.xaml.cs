namespace ResturantSystemMaui.Views;

public partial class ReviewFeedBack : ContentPage
{
	public ReviewFeedBack()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {

    }

    private async void ToolbarItem_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MenuItemPage");
    }
}
using ResturantSystemMaui.Models;

namespace ResturantSystemMaui.Views;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
		
	}


	private async void TapGestureRecognizer_Tapped_For_SignUP(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//SignUpPage");
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//MenuItemPage");
    }
}
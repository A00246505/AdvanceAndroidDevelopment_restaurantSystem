using ResturantSystemMaui.Models;

namespace ResturantSystemMaui.Views;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	
	}

	private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//SignInPage");
	}
}
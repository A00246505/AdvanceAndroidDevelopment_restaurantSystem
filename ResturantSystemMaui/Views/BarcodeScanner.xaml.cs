namespace ResturantSystemMaui.Views;

public partial class BarcodeScanner : ContentPage
{
    string tableno = "";
	public BarcodeScanner()
	{
		InitializeComponent();
	
	}

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {

		Dispatcher.Dispatch(() =>
		{

            barcodeResult.Text = e.Results[0].Value.ToString();
            tableno= e.Results[0].Value.ToString();
            tableno = tableno.Split(',')[0];
           

        });

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        result.Text= "Ordered for "+ tableno;
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MenuItemPage");
    }
}
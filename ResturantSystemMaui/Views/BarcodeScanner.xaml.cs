namespace ResturantSystemMaui.Views;

public partial class BarcodeScanner : ContentPage
{
	public BarcodeScanner()
	{
		InitializeComponent();
	
	}

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {

		Dispatcher.Dispatch(() =>
		{

            barcodeResult.Text = e.Results[0].Value.ToString();


        });

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}
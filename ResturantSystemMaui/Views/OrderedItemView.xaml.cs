using ResturantSystemMaui.Models;

namespace ResturantSystemMaui.Views;

public partial class OrderedItemView : ContentPage
{
	public OrderedItemView()
	{
		

		InitializeComponent();
		myListView.ItemsSource = MenuItemViewModel.OrderList;


    }
}
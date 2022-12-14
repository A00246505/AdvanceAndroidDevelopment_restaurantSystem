using ResturantSystemMaui.Models;

namespace ResturantSystemMaui.Views;

public partial class OrderedItemView : ContentPage
{
	List<MenuItemInfo> myList = new List<MenuItemInfo>();
	int total = 0;
	public OrderedItemView()
	{
		InitializeComponent();

		foreach (MenuItemInfo item in MenuItemViewModel.OrderList)
		{
			myList.Add(item);
			total += int.Parse(item.Price);
		}


		myListView.ItemsSource = myList;
		totalLabel.Text= "Total: "+total.ToString();


    }
}
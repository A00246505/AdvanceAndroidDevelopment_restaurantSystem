using ResturantSystemMaui.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystemMaui.Models
{
   
    public class MenuItemViewModel
    {
        public ObservableCollection<MenuItemInfo> ItemList { get; set; }

        public MenuItemViewModel()
        {
            ItemList = new ObservableCollection<MenuItemInfo>();
            ItemList.Add(new MenuItemInfo() { MenuId=1,MenuItemName= "Coffee",Price = "1500" , ImageUrl= "cheeseburger.jpg" });
            ItemList.Add(new MenuItemInfo() { MenuId = 2, MenuItemName = "Tea", Price = "1500", ImageUrl = "cheeseburger.jpg" });
            ItemList.Add(new MenuItemInfo() { MenuId = 3, MenuItemName = "Moca", Price = "1500", ImageUrl = "cheeseburger.jpg" });
            ItemList.Add(new MenuItemInfo() { MenuId = 4, MenuItemName = "Water", Price = "1500", ImageUrl = "cheeseburger.jpg" });

            MessagingCenter.Subscribe<AddorEditMenuItem, MenuItemInfo>(this, "AddorEditMenu", (Page, menu) =>
            {
                if (menu.MenuId == 0)
                {
                    menu.MenuId = ItemList.Count+1;
                    ItemList.Add(menu);
                }
            });

        }
    }
}

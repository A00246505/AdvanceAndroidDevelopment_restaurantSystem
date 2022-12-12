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
   
    public class MenuItemViewModel :BaseMenuItemViewModel
    {
        public ObservableCollection<MenuItemInfo> ItemList { get;  }

        public Command LoadMenuItemCommand { get; }

        public MenuItemViewModel()
        {
            /*  ItemList = new ObservableCollection<MenuItemInfo>();
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
                  else
                  {
                      MenuItemInfo menuItemInfo = ItemList.Where(prod => prod.MenuId == menu.MenuId).FirstOrDefault();
                      ItemList.Add(menu);
                  }
              });
            */

            LoadMenuItemCommand = new Command(async () => await ExecuteLoadMenuCommand());
            ItemList = new ObservableCollection<MenuItemInfo>();
        }

        public async Task ExecuteLoadMenuCommand()
        {
            IsBusy= true;
        }

        public async void OnAppearing()
        {
           IsBusy= true;
            try
            {
                ItemList.Clear();
                var menuList = await App.MenuService.GetAllMenuAsync();
                foreach (var menu in menuList)
                {
                    ItemList.Add(menu);
                }
            } 
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                IsBusy= false;
            }

        }


        
    }
}

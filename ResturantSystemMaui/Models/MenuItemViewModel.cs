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


        public static ObservableCollection<MenuItemInfo> OrderList = new ObservableCollection<MenuItemInfo>();
        public Command AddMenuCommand { get; }

        public Command OrdersMenuCommand { get; }

        public Command MenuTappedEdit { get; }

        public Command MenuTappedOrder { get; }
        public Command MenuTappedDelete { get; }
        

        public Command LoadMenuItemCommand { get; }

        public MenuItemViewModel(INavigation _navigation)
        {
           
            /*
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
           
            AddMenuCommand = new Command(OnAddMenu);
            MenuTappedEdit = new Command<MenuItemInfo>(OnEditMenu);
            MenuTappedOrder = new Command<MenuItemInfo>(OnOrderMenu);
            MenuTappedDelete = new Command<MenuItemInfo>(OnDeleteMenu);
            OrdersMenuCommand = new Command(OnOrderCommand);
            Navigation = _navigation;


        }

         async Task ExecuteLoadMenuCommand()
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
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }
      
        public async void OnAppearing()
        {
           IsBusy= true;



        }

        private async void OnAddMenu(object obj)
        {
            await Shell.Current.GoToAsync(nameof(AddorEditMenuItem));
        }

        private async void OnOrderCommand(object obj)
        {
            await Shell.Current.GoToAsync(nameof(OrderedItemView));
        }



        private async void OnEditMenu(MenuItemInfo prod) {

            

            await Navigation.PushAsync(new AddorEditMenuItem(prod));

        }

        private void OnOrderMenu(MenuItemInfo prod)
        {

            OrderList.Add(prod);

        }

        private async void OnDeleteMenu(MenuItemInfo prod)
        {

           if(prod == null)
            {
                return;
            }

            await App.MenuService.DeleteMenuAsync(prod.MenuId);
            await ExecuteLoadMenuCommand();

        }


    }
}

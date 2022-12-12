using ResturantSystemMaui.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystemMaui.Models
{
    public class AddorDeleteMenuItemViewModel : BaseMenuItemViewModel
    {
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }
        //public MenuItemInfo MenuItem { get; set; }

        public AddorDeleteMenuItemViewModel() {

            // MenuItem= new MenuItemInfo();

            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);

            this.PropertyChanged += (_, __) => SaveCommand.ChangeCanExecute();

            MenuItemInfo = new MenuItemInfo();
        
        }   

        private async void OnSave()
        {
            var menu = MenuItemInfo;
            await App.MenuService.AddMenuAsync(menu);

            await Shell.Current.GoToAsync("..");

        }

        private async void OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}

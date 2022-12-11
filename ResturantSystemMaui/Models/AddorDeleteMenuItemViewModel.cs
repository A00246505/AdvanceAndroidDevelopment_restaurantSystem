using ResturantSystemMaui.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystemMaui.Models
{
    public class AddorDeleteMenuItemViewModel
    {

        public MenuItemInfo MenuItem { get; set; }

        public AddorDeleteMenuItemViewModel() { 
        
        MenuItem= new MenuItemInfo();
        
        }   
    }
}

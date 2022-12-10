using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystemMaui.Models
{
   
    public class MenuItemViewModel
    {
        public string[] ItemList { get; set; }

        public MenuItemViewModel()
        {
            ItemList = new string[] { "Coffee", "Tea", "Moca", "Water" };
        }
    }
}

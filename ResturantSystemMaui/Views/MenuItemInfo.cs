using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystemMaui.Views
{
    public class MenuItemInfo
    {
        [PrimaryKey,AutoIncrement]
        public int MenuId { get; set; }
        public string MenuItemName { get; set; }

        public string Price { get; set; }   

        public string ImageUrl { get; set; }

    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystemMaui.Views
{
    public class OrderListView
    {
        
        public int OrderId { get; set; }
        public string OrderName { get; set; }

        public string Price { get; set; }

        public string ImageUrl { get; set; }
    }
}

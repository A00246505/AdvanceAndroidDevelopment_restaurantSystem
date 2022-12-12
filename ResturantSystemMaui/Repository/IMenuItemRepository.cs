using ResturantSystemMaui.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystemMaui.Repository
{
    public interface IMenuItemRepository
    {
        Task<bool> AddMenuAsync(MenuItemInfo menuItemInfo);

        Task<bool> UpdateMenuAsync(MenuItemInfo menuItemInfo);

        Task<bool> DeleteMenuAsync(int id);

        Task<MenuItemInfo> GetMenuAsync(int id);

        Task<IEnumerable<MenuItemInfo>> GetAllMenuAsync();  

    }
}

using ResturantSystemMaui.Repository;
using ResturantSystemMaui.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystemMaui.Service
{
    public class MenuService : IMenuItemRepository
    {
        public SQLiteAsyncConnection _database;
        public MenuService(string dbPath) { 
        
        _database= new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<MenuItemInfo>().Wait();
        
        }
        public Task<bool> AddMenuAsync(MenuItemInfo menuItemInfo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMenuAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MenuItemInfo>> GetAllMenuAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MenuItemInfo> GetMenuAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMenuAsync(MenuItemInfo menuItemInfo)
        {
            throw new NotImplementedException();
        }
    }
}

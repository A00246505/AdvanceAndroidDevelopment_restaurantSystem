
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
        public async Task<bool> AddMenuAsync(MenuItemInfo menuItemInfo)
        {
           if(menuItemInfo.MenuId > 0)
            {
                await _database.UpdateAsync(menuItemInfo);
            }
            else
            {
                await _database.InsertAsync(menuItemInfo);
            }
           return await Task.FromResult(true);
        }

        public async Task<bool> DeleteMenuAsync(int id)
        {
            await _database.DeleteAsync<MenuItemInfo>(id);
            return await Task.FromResult(true); 
        }

        public async Task<IEnumerable<MenuItemInfo>> GetAllMenuAsync()
        {
            return await Task.FromResult( await _database.Table<MenuItemInfo>().ToListAsync());
        }

        public async Task<MenuItemInfo> GetMenuAsync(int id)
        {
           return await _database.Table<MenuItemInfo>().Where(p=> p.MenuId == id).FirstOrDefaultAsync();

        }

        public Task<bool> UpdateMenuAsync(MenuItemInfo menuItemInfo)
        {
            throw new NotImplementedException();
        }
    }
}

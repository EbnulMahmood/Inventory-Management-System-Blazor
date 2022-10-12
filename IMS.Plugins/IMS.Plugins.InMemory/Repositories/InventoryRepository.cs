using IMS.CoreBusiness.Entities;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.InMemory.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory() { Id = 1, Name = "Bike Seat", Quantity = 10, Price = 200},
                new Inventory() { Id = 2, Name = "Bike Body", Quantity = 10, Price = 300},
                new Inventory() { Id = 3, Name = "Bike Weels", Quantity = 20, Price = 100},
                new Inventory() { Id = 4, Name = "Bike Pedels", Quantity = 20, Price = 500},
            };
        }

        public Task AddInventoryAsync(Inventory inventory)
        {
            if (_inventories.Any(x => x.Name.Contains(inventory.Name, StringComparison.OrdinalIgnoreCase)))
                throw new Exception("Inventory with same name already exists");

            var maxId = _inventories.Max(x => x.Id);
            inventory.Id = maxId;

            _inventories.Add(inventory);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Inventory>> ListInventoriesByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            return _inventories.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}

using IMS.CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        public Task<IEnumerable<Inventory>> ListInventoriesByNameAsync(string name);
    }
}

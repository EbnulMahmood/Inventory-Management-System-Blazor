using IMS.CoreBusiness.Entities;
using Microsoft.AspNetCore.Components;

namespace IMS.WebApp.Controls
{
    public class InventoryListItemComponentBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<Inventory> Inventories { get; set; } = Enumerable.Empty<Inventory>();
    }
}

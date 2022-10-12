using Microsoft.AspNetCore.Components;

namespace IMS.WebApp.Pages.Inventories
{
    public class InventoryListBase : ComponentBase
    {
        protected string SearchTerm { get; private set; } = string.Empty;
        protected void OnSearchInventory(string searchTerm)
        {
            SearchTerm = searchTerm;
        }
    }
}

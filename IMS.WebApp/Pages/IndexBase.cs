using IMS.CoreBusiness.Entities;
using IMS.UseCases.Inventories.Interfaces;
using Microsoft.AspNetCore.Components;

namespace IMS.WebApp.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public IViewInventoriesByNameUseCase ViewInventoriesByNameUseCase { get; private set; }
        public IEnumerable<Inventory> Inventories { get; private set; }

        protected override async Task OnInitializedAsync()
        {
            Inventories = await ViewInventoriesByNameUseCase.ExecuteAsync();
        }
    }
}

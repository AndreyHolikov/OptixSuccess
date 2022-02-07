using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using CoreBusiness.Models;

namespace WebOptixSuccess.Pages
{
    public partial class ItemOrdersComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected RadzenOptixSuccessService RadzenOptixSuccess { get; set; }


        protected RadzenContent content1;

        protected RadzenHeading pageTitle;

        protected RadzenButton button0;

        protected RadzenGrid<CoreBusiness.Models.ItemOrder> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<CoreBusiness.Models.ItemOrder> _getItemOrdersResult;
        protected IEnumerable<CoreBusiness.Models.ItemOrder> getItemOrdersResult
        {
            get
            {
                return _getItemOrdersResult;
            }
            set
            {
                if(_getItemOrdersResult != value)
                {
                    _getItemOrdersResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var radzenOptixSuccessGetItemOrdersResult = await RadzenOptixSuccess.GetItemOrders(null, null);
            getItemOrdersResult = radzenOptixSuccessGetItemOrdersResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddItemOrder>("Add Item Order", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(CoreBusiness.Models.ItemOrder args)
        {
            var result = await DialogService.OpenAsync<EditItemOrder>("Edit Item Order", new Dictionary<string, object>() { {"ItemOrderId", $"{args.ItemOrderId}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, CoreBusiness.Models.ItemOrder data)
        {
            try
            {
                var radzenOptixSuccessDeleteItemOrderResult = await RadzenOptixSuccess.DeleteItemOrder(data.ItemOrderId);
                if (radzenOptixSuccessDeleteItemOrderResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception radzenOptixSuccessDeleteItemOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete ItemOrder");
            }
        }
    }
}

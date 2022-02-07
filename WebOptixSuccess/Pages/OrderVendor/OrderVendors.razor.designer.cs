using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using CoreBusiness.Models;
//using WebOptixSuccess.Pages.OrderVendor;

namespace WebOptixSuccess.Pages
{
    public partial class OrderVendorsComponent : ComponentBase
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

        protected RadzenGrid<OrderVendor> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<OrderVendor> _getOrderVendorsResult;
        protected IEnumerable<OrderVendor> getOrderVendorsResult
        {
            get
            {
                return _getOrderVendorsResult;
            }
            set
            {
                if(_getOrderVendorsResult != value)
                {
                    _getOrderVendorsResult = value;
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
            var radzenOptixSuccessGetOrderVendorsResult = await RadzenOptixSuccess.GetOrderVendors(null, null);
            getOrderVendorsResult = radzenOptixSuccessGetOrderVendorsResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddOrderVendor>("Add Order Vendor", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(OrderVendor args)
        {
            var result = await DialogService.OpenAsync<EditOrderVendor>("Edit Order Vendor", new Dictionary<string, object>() { {"OrderVendorId", $"{args.OrderVendorId}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, OrderVendor data)
        {
            try
            {
                var radzenOptixSuccessDeleteOrderVendorResult = await RadzenOptixSuccess.DeleteOrderVendor(data.OrderVendorId);
                if (radzenOptixSuccessDeleteOrderVendorResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception)// radzenOptixSuccessDeleteOrderVendorException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete OrderVendor");
            }
        }
    }
}

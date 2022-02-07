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
    public partial class OrderCustomersComponent : ComponentBase
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

        protected RadzenGrid<OrderCustomer> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<OrderCustomer> _getOrderCustomersResult;
        protected IEnumerable<OrderCustomer> getOrderCustomersResult
        {
            get
            {
                return _getOrderCustomersResult;
            }
            set
            {
                if(_getOrderCustomersResult != value)
                {
                    _getOrderCustomersResult = value;
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
            var radzenOptixSuccessGetOrderCustomersResult = await RadzenOptixSuccess.GetOrderCustomers(null, null);
            getOrderCustomersResult = radzenOptixSuccessGetOrderCustomersResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddOrderCustomer>("Add Order Customer", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(OrderCustomer args)
        {
            var result = await DialogService.OpenAsync<EditOrderCustomer>("Edit Order Customer", new Dictionary<string, object>() { {"OrderCustomerId", $"{args.OrderCustomerId}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, OrderCustomer data)
        {
            try
            {
                var radzenOptixSuccessDeleteOrderCustomerResult = await RadzenOptixSuccess.DeleteOrderCustomer(data.OrderCustomerId);
                if (radzenOptixSuccessDeleteOrderCustomerResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception radzenOptixSuccessDeleteOrderCustomerException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete OrderCustomer");
            }
        }
    }
}

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
    public partial class AddItemOrderComponent : ComponentBase
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

        protected RadzenTemplateForm<ItemOrder> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox description;

        protected RadzenLabel label2;

        protected dynamic quantity;

        protected RadzenRequiredValidator quantityRequiredValidator;

        protected RadzenLabel label3;

        protected dynamic price;

        protected RadzenRequiredValidator priceRequiredValidator;

        protected RadzenLabel label4;

        protected RadzenDatePicker edited;

        protected RadzenRequiredValidator editedRequiredValidator;

        protected RadzenLabel label5;

        protected RadzenDropDownDataGrid productId;

        protected RadzenRequiredValidator productIdRequiredValidator;

        protected RadzenLabel label6;

        protected RadzenDropDownDataGrid orderCustomerId;

        protected RadzenRequiredValidator orderCustomerIdRequiredValidator;

        protected RadzenLabel label7;

        protected RadzenDropDownDataGrid orderVendorId;

        protected RadzenButton button1;

        protected RadzenButton button2;

        IEnumerable<CoreBusiness.Models.Product> _getProductsForProductIdResult;
        protected IEnumerable<CoreBusiness.Models.Product> getProductsForProductIdResult
        {
            get
            {
                return _getProductsForProductIdResult;
            }
            set
            {
                if(_getProductsForProductIdResult != value)
                {
                    _getProductsForProductIdResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CoreBusiness.Models.OrderCustomer> _getOrderCustomersForOrderCustomerIdResult;
        protected IEnumerable<CoreBusiness.Models.OrderCustomer> getOrderCustomersForOrderCustomerIdResult
        {
            get
            {
                return _getOrderCustomersForOrderCustomerIdResult;
            }
            set
            {
                if(_getOrderCustomersForOrderCustomerIdResult != value)
                {
                    _getOrderCustomersForOrderCustomerIdResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<CoreBusiness.Models.OrderVendor> _getOrderVendorsForOrderVendorIdResult;
        protected IEnumerable<CoreBusiness.Models.OrderVendor> getOrderVendorsForOrderVendorIdResult
        {
            get
            {
                return _getOrderVendorsForOrderVendorIdResult;
            }
            set
            {
                if(_getOrderVendorsForOrderVendorIdResult != value)
                {
                    _getOrderVendorsForOrderVendorIdResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        CoreBusiness.Models.ItemOrder _itemorder;
        protected CoreBusiness.Models.ItemOrder itemorder
        {
            get
            {
                return _itemorder;
            }
            set
            {
                if(_itemorder != value)
                {
                    _itemorder = value;
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
            var radzenOptixSuccessGetProductsResult = await RadzenOptixSuccess.GetProducts(null, null);
            getProductsForProductIdResult = radzenOptixSuccessGetProductsResult;

            var radzenOptixSuccessGetOrderCustomersResult = await RadzenOptixSuccess.GetOrderCustomers(null, null);
            getOrderCustomersForOrderCustomerIdResult = radzenOptixSuccessGetOrderCustomersResult;

            var radzenOptixSuccessGetOrderVendorsResult = await RadzenOptixSuccess.GetOrderVendors(null, null);
            getOrderVendorsForOrderVendorIdResult = radzenOptixSuccessGetOrderVendorsResult;

            itemorder = new ItemOrder();
        }

        protected async void Form0Submit(ItemOrder args)
        {
            try
            {
                var radzenOptixSuccessCreateItemOrderResult = await RadzenOptixSuccess.CreateItemOrder(itemorder);
                DialogService.Close(itemorder);
            }
            catch (Exception radzenOptixSuccessCreateItemOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new ItemOrder!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}

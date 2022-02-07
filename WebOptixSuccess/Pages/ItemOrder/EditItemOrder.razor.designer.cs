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
    public partial class EditItemOrderComponent : ComponentBase
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

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<CoreBusiness.Models.ItemOrder> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox description;

        protected RadzenLabel label3;

        protected dynamic quantity;

        protected RadzenRequiredValidator quantityRequiredValidator;

        protected RadzenLabel label4;

        protected dynamic price;

        protected RadzenRequiredValidator priceRequiredValidator;

        protected RadzenLabel label5;

        protected RadzenDatePicker edited;

        protected RadzenRequiredValidator editedRequiredValidator;

        protected RadzenLabel label6;

        protected RadzenDropDownDataGrid productId;

        protected RadzenRequiredValidator productIdRequiredValidator;

        protected RadzenLabel label7;

        protected RadzenDropDownDataGrid orderCustomerId;

        protected RadzenRequiredValidator orderCustomerIdRequiredValidator;

        protected RadzenLabel label8;

        protected RadzenDropDownDataGrid orderVendorId;

        protected RadzenButton button2;

        protected RadzenButton button3;

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if(_canEdit != value)
                {
                    _canEdit = value;
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

        protected override async Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            var radzenOptixSuccessGetItemOrderByItemOrderIdResult = await RadzenOptixSuccess.GetItemOrderByItemOrderId(int.Parse(ItemOrderId));
            itemorder = radzenOptixSuccessGetItemOrderByItemOrderIdResult;

            var radzenOptixSuccessGetProductsResult = await RadzenOptixSuccess.GetProducts(null, null);
            getProductsForProductIdResult = radzenOptixSuccessGetProductsResult;

            var radzenOptixSuccessGetOrderCustomersResult = await RadzenOptixSuccess.GetOrderCustomers(null, null);
            getOrderCustomersForOrderCustomerIdResult = radzenOptixSuccessGetOrderCustomersResult;

            var radzenOptixSuccessGetOrderVendorsResult = await RadzenOptixSuccess.GetOrderVendors(null, null);
            getOrderVendorsForOrderVendorIdResult = radzenOptixSuccessGetOrderVendorsResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(CoreBusiness.Models.ItemOrder args)
        {
            try
            {
                var radzenOptixSuccessUpdateItemOrderResult = await RadzenOptixSuccess.UpdateItemOrder(int.Parse(ItemOrderId), itemorder);
                DialogService.Close(itemorder);
            }
            catch (Exception radzenOptixSuccessUpdateItemOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update ItemOrder");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}

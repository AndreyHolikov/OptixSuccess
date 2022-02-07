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
    public partial class EditOrderVendorComponent : ComponentBase
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

        protected RadzenTemplateForm<OrderVendor> form0;

        protected RadzenLabel label2;

        protected dynamic vendorId;

        protected RadzenRequiredValidator vendorIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenTextBox name;

        protected RadzenLabel label4;

        protected RadzenTextBox description;

        protected RadzenLabel label5;

        protected RadzenDatePicker edited;

        protected RadzenRequiredValidator editedRequiredValidator;

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

        OrderVendor _ordervendor;
        protected OrderVendor ordervendor
        {
            get
            {
                return _ordervendor;
            }
            set
            {
                if(_ordervendor != value)
                {
                    _ordervendor = value;
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

            var radzenOptixSuccessGetOrderVendorByOrderVendorIdResult = await RadzenOptixSuccess.GetOrderVendorByOrderVendorId(int.Parse(OrderVendorId));
            ordervendor = radzenOptixSuccessGetOrderVendorByOrderVendorIdResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(OrderVendor args)
        {
            try
            {
                var radzenOptixSuccessUpdateOrderVendorResult = await RadzenOptixSuccess.UpdateOrderVendor(int.Parse(OrderVendorId), ordervendor);
                DialogService.Close(ordervendor);
            }
            catch (Exception radzenOptixSuccessUpdateOrderVendorException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update OrderVendor");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}

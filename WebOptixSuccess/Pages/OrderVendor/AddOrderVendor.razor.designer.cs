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
    public partial class AddOrderVendorComponent : ComponentBase
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

        protected RadzenTemplateForm<OrderVendor> form0;

        protected RadzenLabel label1;

        protected dynamic vendorId;

        protected RadzenRequiredValidator vendorIdRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenTextBox name;

        protected RadzenLabel label3;

        protected RadzenTextBox description;

        protected RadzenLabel label4;

        protected RadzenDatePicker edited;

        protected RadzenRequiredValidator editedRequiredValidator;

        protected RadzenButton button1;

        protected RadzenButton button2;

        CoreBusiness.Models.OrderVendor _ordervendor;
        protected CoreBusiness.Models.OrderVendor ordervendor
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
            ordervendor = new OrderVendor();
        }

        protected async void Form0Submit(OrderVendor args)
        {
            try
            {
                var radzenOptixSuccessCreateOrderVendorResult = await RadzenOptixSuccess.CreateOrderVendor(ordervendor);
                DialogService.Close(ordervendor);
            }
            catch (Exception radzenOptixSuccessCreateOrderVendorException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new OrderVendor!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}

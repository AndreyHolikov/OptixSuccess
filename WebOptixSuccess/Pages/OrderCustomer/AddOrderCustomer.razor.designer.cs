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
    public partial class AddOrderCustomerComponent : ComponentBase
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

        protected RadzenTemplateForm<OrderCustomer> form0;

        protected RadzenLabel label1;

        protected dynamic customerId;

        protected RadzenRequiredValidator customerIdRequiredValidator;

        protected RadzenLabel label2;

        protected dynamic excelFileId;

        protected RadzenRequiredValidator excelFileIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenTextBox name;

        protected RadzenLabel label4;

        protected RadzenTextBox description;

        protected RadzenLabel label5;

        protected RadzenDatePicker edited;

        protected RadzenRequiredValidator editedRequiredValidator;

        protected RadzenButton button1;

        protected RadzenButton button2;

        OrderCustomer _ordercustomer;
        protected OrderCustomer ordercustomer
        {
            get
            {
                return _ordercustomer;
            }
            set
            {
                if(_ordercustomer != value)
                {
                    _ordercustomer = value;
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
            ordercustomer = new OrderCustomer();
        }

        protected async void Form0Submit(OrderCustomer args)
        {
            try
            {
                var radzenOptixSuccessCreateOrderCustomerResult = await RadzenOptixSuccess.CreateOrderCustomer(ordercustomer);
                DialogService.Close(ordercustomer);
            }
            catch (Exception radzenOptixSuccessCreateOrderCustomerException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new OrderCustomer!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}

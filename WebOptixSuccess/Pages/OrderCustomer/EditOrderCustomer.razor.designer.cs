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
    public partial class EditOrderCustomerComponent : ComponentBase
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

        protected RadzenTemplateForm<OrderCustomer> form0;

        protected RadzenLabel label2;

        protected dynamic customerId;

        protected RadzenRequiredValidator customerIdRequiredValidator;

        protected RadzenLabel label3;

        protected dynamic excelFileId;

        protected RadzenRequiredValidator excelFileIdRequiredValidator;

        protected RadzenLabel label4;

        protected RadzenTextBox name;

        protected RadzenLabel label5;

        protected RadzenTextBox description;

        protected RadzenLabel label6;

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

        CoreBusiness.Models.OrderCustomer _ordercustomer;
        protected CoreBusiness.Models.OrderCustomer ordercustomer
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
            canEdit = true;

            var radzenOptixSuccessGetOrderCustomerByOrderCustomerIdResult = await RadzenOptixSuccess.GetOrderCustomerByOrderCustomerId(int.Parse(OrderCustomerId));
            ordercustomer = radzenOptixSuccessGetOrderCustomerByOrderCustomerIdResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(CoreBusiness.Models.OrderCustomer args)
        {
            try
            {
                var radzenOptixSuccessUpdateOrderCustomerResult = await RadzenOptixSuccess.UpdateOrderCustomer(int.Parse(OrderCustomerId), ordercustomer);
                DialogService.Close(ordercustomer);
            }
            catch (Exception radzenOptixSuccessUpdateOrderCustomerException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update OrderCustomer");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}

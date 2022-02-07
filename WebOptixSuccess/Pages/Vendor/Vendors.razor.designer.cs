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
    public partial class VendorsComponent : ComponentBase
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

        protected RadzenGrid<CoreBusiness.Models.Vendor> grid0;

        IEnumerable<CoreBusiness.Models.Vendor> _getVendorsResult;
        protected IEnumerable<CoreBusiness.Models.Vendor> getVendorsResult
        {
            get
            {
                return _getVendorsResult;
            }
            set
            {
                if(_getVendorsResult != value)
                {
                    _getVendorsResult = value;
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
            var radzenOptixSuccessGetVendorsResult = await RadzenOptixSuccess.GetVendors(null, null);
            getVendorsResult = radzenOptixSuccessGetVendorsResult;
        }
    }
}

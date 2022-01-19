using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using Plugins.DataStore.InMemory;
using UseCases.DataStorePluginInterfaces;
using UseCases;


namespace WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            //Dependency  Injection for In-Memory DataStore
            services.AddScoped<ICategoryRepository, CategoryInMemoryRepository>();
            services.AddScoped<IProductRepository, ProductInMemoryRepository>();

            services.AddScoped<ICustomerRepository, CustomerInMemoryRepository>();
            services.AddScoped<IOrderCustomerRepository, OrderCustomerInMemoryRepository>();
            services.AddScoped<IItemOrderRepository, ItemOrderInMemoryRepository>();
            services.AddScoped<IOrderVendorRepository, OrderVendorInMemoryRepository>();
            services.AddScoped<IVendorRepository, VendorInMemoryRepository>();

            services.AddScoped<IExcelFileRepository, ExcelFileInMemoryRepository>();

            //Dependency Injection fo Use Cases and Repositories
            #region Categories
            services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
            services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
            services.AddTransient<IEditCategoryUseCase, EditCategoryUseCase>();
            services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
            services.AddTransient<IDeleteCategoryUseCase, DeleteCategoryUseCase>();
            #endregion

            #region Product
            services.AddTransient<IViewProductsUseCase, ViewProductsUseCase>();
            services.AddTransient<IAddProductUseCase, AddProductUseCase>();
            services.AddTransient<IEditProductUseCase, EditProductUseCase>();
            services.AddTransient<IGetProductByIdUseCase, GetProductByIdUseCase>();
            services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
            #endregion

            #region Customers
            services.AddTransient<IViewCustomersUseCase, ViewCustomersUseCase>();
            services.AddTransient<IAddCustomerUseCase, AddCustomerUseCase>();
            services.AddTransient<IEditCustomerUseCase, EditCustomerUseCase>();
            services.AddTransient<IGetCustomerByIdUseCase, GetCustomerByIdUseCase>();
            services.AddTransient<IDeleteCustomerUseCase, DeleteCustomerUseCase>();
            #endregion

            #region OrderCustomer
            services.AddTransient<IViewOrderCustomersUseCase, ViewOrderCustomersUseCase>();
            services.AddTransient<IAddOrderCustomerUseCase, AddOrderCustomerUseCase>();
            services.AddTransient<IEditOrderCustomerUseCase, EditOrderCustomerUseCase>();
            services.AddTransient<IGetOrderCustomerByIdUseCase, GetOrderCustomerByIdUseCase>();
            services.AddTransient<IDeleteOrderCustomerUseCase, DeleteOrderCustomerUseCase>();
            services.AddTransient<IGetOrderCustomerByCustomerIdUseCase, GetOrderCustomerByCustomerIdUseCase>();
            #endregion

            #region ItemOrder
            services.AddTransient<IViewItemOrdersUseCase, ViewExcelFilesUseCase>();
            services.AddTransient<IAddItemOrderUseCase, AddItemOrderUseCase>();
            services.AddTransient<IEditItemOrderUseCase, EditItemOrderUseCase>();
            services.AddTransient<IGetItemOrderByIdUseCase, GetItemOrderByIdUseCase>();
            services.AddTransient<IDeleteItemOrderUseCase, DeleteItemOrderUseCase>();
            #endregion

            #region OrderVendor
            services.AddTransient<IViewOrderVendorsUseCase, ViewOrderVendorsUseCase>();
            services.AddTransient<IAddOrderVendorUseCase, AddOrderVendorUseCase>();
            services.AddTransient<IEditOrderVendorUseCase, EditOrderVendorUseCase>();
            services.AddTransient<IGetOrderVendorByIdUseCase, GetOrderVendorByIdUseCase>();
            services.AddTransient<IDeleteOrderVendorUseCase, DeleteOrderVendorUseCase>();
            #endregion

            #region Vendor
            services.AddTransient<IViewVendorsUseCase, ViewVendorsUseCase>();
            services.AddTransient<IAddVendorUseCase, AddVendorUseCase>();
            services.AddTransient<IEditVendorUseCase, EditVendorUseCase>();
            services.AddTransient<IGetVendorByIdUseCase, GetVendorByIdUseCase>();
            services.AddTransient<IDeleteVendorUseCase, DeleteVendorUseCase>();
            #endregion

            #region ExcelFiles
            services.AddTransient<IGetExcelFileByIdUseCase, GetExcelFileByIdUseCase>();
            #endregion

            //services.AddIgniteUIBlazor();
            //services.AddBlazorTable();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}

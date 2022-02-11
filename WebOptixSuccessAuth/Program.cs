using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Plugins.DataStore.InMemory;
using Plugins.DataStore.SQL;
using UseCases;
using UseCases.DataStorePluginInterfaces;
using WebOptixSuccessAuth.Areas.Identity;
using WebOptixSuccessAuth.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionStringAuth = builder.Configuration.GetConnectionString("ConnectionAuth");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionStringAuth));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//builder.Services.AddScoped<Radzen.EventConsole>();
builder.Services.AddScoped<Radzen.NotificationService>();
builder.Services.AddScoped<Radzen.TooltipService>();

builder.Services.AddHttpClient(); // для загрузки файлов на сервер

//builder.Services.AddDbContext<AppDbContext>();
;

var optixSuccessConnectionString = builder.Configuration.GetConnectionString("ConnectionOptixSuccess");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(optixSuccessConnectionString));
//options => (options.UseSQLServer(Configuration.GetConnectionString("Defaultconnection"));
//Dependency  Injection for In-Memory DataStore

// DI InMemoryRepository
builder.Services.AddScoped<ICategoryRepository, CategoryInMemoryRepository>();
//builder.Services.AddScoped<IProductRepository, ProductInMemoryRepository>();

//Dependency Injection fo Use Cases and Repositories
#region Categories
builder.Services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
//builder.Services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
//builder.Services.AddTransient<IEditCategoryUseCase, EditCategoryUseCase>();
//builder.Services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
//builder.Services.AddTransient<IDeleteCategoryUseCase, DeleteCategoryUseCase>();
#endregion

#region Product
//builder.Services.AddTransient<IViewProductsUseCase, ViewProductsUseCase>();
//builder.Services.AddTransient<IAddProductUseCase, AddProductUseCase>();
//builder.Services.AddTransient<IEditProductUseCase, EditProductUseCase>();
//builder.Services.AddTransient<IGetProductByIdUseCase, GetProductByIdUseCase>();
//builder.Services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
#endregion

#region Customers
//builder.Services.AddTransient<IViewCustomersUseCase, ViewCustomersUseCase>();
//  builder.Services.AddTransient<IAddCustomerUseCase, AddCustomerUseCase>(); /// ---
//builder.Services.AddTransient<IEditCustomerUseCase, EditCustomerUseCase>();
//builder.Services.AddTransient<IGetCustomerByIdUseCase, GetCustomerByIdUseCase>();
//builder.Services.AddTransient<IDeleteCustomerUseCase, DeleteCustomerUseCase>();
#endregion

#region OrderCustomer
//builder.Services.AddTransient<IViewOrderCustomersUseCase, ViewOrderCustomersUseCase>();
//builder.Services.AddTransient<IAddOrderCustomerUseCase, AddOrderCustomerUseCase>();
//builder.Services.AddTransient<IEditOrderCustomerUseCase, EditOrderCustomerUseCase>();
//builder.Services.AddTransient<IGetOrderCustomerByIdUseCase, GetOrderCustomerByIdUseCase>();
//builder.Services.AddTransient<IDeleteOrderCustomerUseCase, DeleteOrderCustomerUseCase>();
//builder.Services.AddTransient<IGetOrderCustomerByCustomerIdUseCase, GetOrderCustomerByCustomerIdUseCase>();
#endregion

#region ItemOrder
//builder.Services.AddTransient<IViewItemOrdersUseCase, ViewExcelFilesUseCase>();
//builder.Services.AddTransient<IGetItemOrdersByOrderCustomerIdUseCase, GetItemOrdersByOrderCustomerIdUseCase>();
//builder.Services.AddTransient<IGetItemOrdersByOrderVendorIdUseCase, GetItemOrdersByOrderVendorIdUseCase>();

//builder.Services.AddTransient<IAddItemOrderUseCase, AddItemOrderUseCase>();
//builder.Services.AddTransient<IEditItemOrderUseCase, EditItemOrderUseCase>();
//builder.Services.AddTransient<IGetItemOrderByIdUseCase, GetItemOrderByIdUseCase>();
//builder.Services.AddTransient<IDeleteItemOrderUseCase, DeleteItemOrderUseCase>();
#endregion

#region OrderVendor
//builder.Services.AddTransient<IViewOrderVendorsUseCase, ViewOrderVendorsUseCase>();
//builder.Services.AddTransient<IAddOrderVendorUseCase, AddOrderVendorUseCase>();
//builder.Services.AddTransient<IEditOrderVendorUseCase, EditOrderVendorUseCase>();
//builder.Services.AddTransient<IGetOrderVendorByIdUseCase, GetOrderVendorByIdUseCase>();
//builder.Services.AddTransient<IDeleteOrderVendorUseCase, DeleteOrderVendorUseCase>();
#endregion

#region Vendor
//builder.Services.AddTransient<IViewVendorsUseCase, ViewVendorsUseCase>();
//builder.Services.AddTransient<IAddVendorUseCase, AddVendorUseCase>();
//builder.Services.AddTransient<IEditVendorUseCase, EditVendorUseCase>();
//builder.Services.AddTransient<IGetVendorByIdUseCase, GetVendorByIdUseCase>();
//builder.Services.AddTransient<IDeleteVendorUseCase, DeleteVendorUseCase>();
#endregion

#region ExcelFiles
//builder.Services.AddTransient<IGetExcelFileByIdUseCase, GetExcelFileByIdUseCase>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class Init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    BC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cell = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "OrderCustomers",
                columns: table => new
                {
                    OrderCustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ExcelFileId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edited = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCustomers", x => x.OrderCustomerId);
                    table.ForeignKey(
                        name: "FK_OrderCustomers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderVendors",
                columns: table => new
                {
                    OrderVendorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edited = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderVendors", x => x.OrderVendorId);
                    table.ForeignKey(
                        name: "FK_OrderVendors_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemOrders",
                columns: table => new
                {
                    ItemOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Edited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderCustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderVendorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrders", x => x.ItemOrderId);
                    table.ForeignKey(
                        name: "FK_ItemOrders_OrderCustomers_OrderCustomerId",
                        column: x => x.OrderCustomerId,
                        principalTable: "OrderCustomers",
                        principalColumn: "OrderCustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemOrders_OrderVendors_OrderVendorId",
                        column: x => x.OrderVendorId,
                        principalTable: "OrderVendors",
                        principalColumn: "OrderVendorId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_ItemOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "SofLens 59 6 pk" },
                    { 2, null, "SofLens Daily Disposable 30 pk" },
                    { 3, null, "Optima FW 4 pk" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "Оптика № 1", "Описание компании 1", "k1@gmail.com", "Иванов И.И.", "Иванов И.И.", null, "+375 29 123-12-12" },
                    { 2, "Оптика Нова", "Описание компании 2", "k2@gmail.com", "Петров П.П.", "Петров П.П.", null, "+375 29 123-12-13" },
                    { 3, "ИП Смирнов", "Описание компании 3", "k3@gmail.com", "Смирнов С.С.", "Смирнов С.С.", null, "+375 29 123-12-14" },
                    { 4, "Покупатель: 104", "Customer c104", "k3@gmail.com", "Покупатель: 104", "Покупатель: 104", "4", "+375 29 123-12-14" },
                    { 5, "Покупатель: 105", "Customer c105", "k3@gmail.com", "Покупатель: 105", "Покупатель: 105", "5", "+375 29 123-12-14" },
                    { 6, "Покупатель: 106", "Customer c106", "k3@gmail.com", "Покупатель: 106", "Покупатель: 106", "6", "+375 29 123-12-14" },
                    { 7, "Покупатель: 107", "Customer c107", "k3@gmail.com", "Покупатель: 107", "Покупатель: 107", "7", "+375 29 123-12-14" },
                    { 8, "Покупатель: 108", "Customer c108", "k3@gmail.com", "Покупатель: 108", "Покупатель: 108", "8", "+375 29 123-12-14" },
                    { 9, "Покупатель: 109", "Customer c109", "k3@gmail.com", "Покупатель: 109", "Покупатель: 109", "9", "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "Поставщик № 501", "Описание p501", "mail-501@gmail.com", null, "Поставщик № 501", null, null },
                    { 2, "Поставщик: 502", "Описание p502-1", "mail-502@gmail.com", null, "Поставщик: 502", null, null },
                    { 3, "Поставщик: 503", "Описание p503-8", "mail-503@gmail.com", null, "Поставщик: 503", null, null },
                    { 4, "Поставщик: 504", "Описание p504-9", "mail-504@gmail.com", null, "Поставщик: 504", null, null },
                    { 5, "Поставщик: 505", "Описание p505-7", "mail-505@gmail.com", null, "Поставщик: 505", null, null },
                    { 6, "Поставщик: 506", "Описание p506-3", "mail-506@gmail.com", null, "Поставщик: 506", null, null },
                    { 7, "Поставщик: 507", "Описание p507-6", "mail-507@gmail.com", null, "Поставщик: 507", null, null },
                    { 8, "Поставщик: 508", "Описание p508-4", "mail-508@gmail.com", null, "Поставщик: 508", null, null },
                    { 9, "Поставщик: 509", "Описание p509-2", "mail-509@gmail.com", null, "Поставщик: 509", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderCustomers",
                columns: new[] { "OrderCustomerId", "CustomerId", "Description", "Edited", "ExcelFileId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Описание oc201-c101", new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4186), 1, null },
                    { 2, 2, "Описание oc202-c102", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 3, 3, "Описание oc203-c103", new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 4, 1, "Описание oc204-c101", new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 5, 9, "Описание ov205-c9", new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 205" },
                    { 6, 7, "Описание ov206-c7", new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 206" },
                    { 7, 4, "Описание ov207-c4", new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 207" },
                    { 8, 6, "Описание ov208-c6", new DateTime(2020, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 208" },
                    { 9, 8, "Описание ov209-c8", new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 209" }
                });

            migrationBuilder.InsertData(
                table: "OrderVendors",
                columns: new[] { "OrderVendorId", "Description", "Edited", "Name", "VendorId" },
                values: new object[,]
                {
                    { 1, "Описание ov401", new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4358), "OrderVendor-401", 1 },
                    { 2, "Описание 402-7", new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 402", 7 },
                    { 3, "Описание 403-5", new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 403", 5 },
                    { 4, "Описание 404-9", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 404", 9 },
                    { 5, "Описание 405-4", new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 405", 4 },
                    { 6, "Описание 406-3", new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 406", 3 },
                    { 7, "Описание 407-2", new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 407", 2 },
                    { 8, "Описание 408-9", new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 408", 9 },
                    { 9, "Описание 409-8", new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 409", 8 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 1, " 8.6", 1, "C4", "Описание 1001", "SofLens 59 6 pk", 1.0, 1, "-0.50" },
                    { 2, " 8.6", 1, "C5", null, "SofLens 59 6 pk", 1.0, 1, "-0.75" },
                    { 3, " 8.6", 1, "C6", null, "SofLens 59 6 pk", 1.0, 1, "-1.00" },
                    { 4, " 8.6", 1, "C7", null, "SofLens 59 6 pk", 1.0, 1, "-1.25" },
                    { 5, " 8.6", 1, "C8", null, "SofLens 59 6 pk", 1.0, 1, "-1.50" },
                    { 6, " 8.6", 1, "C9", null, "SofLens 59 6 pk", 1.0, 1, "-1.75" },
                    { 7, " 8.6", 1, "C10", null, "SofLens 59 6 pk", 1.0, 1, "-2.00" },
                    { 8, " 8.6", 1, "C11", null, "SofLens 59 6 pk", 1.0, 1, "-2.25" },
                    { 9, " 8.6", 1, "C12", null, "SofLens 59 6 pk", 1.0, 1, "-2.50" },
                    { 10, " 8.6", 1, "C13", null, "SofLens 59 6 pk", 1.0, 1, "-2.75" },
                    { 11, " 8.6", 1, "C14", null, "SofLens 59 6 pk", 1.0, 1, "-3.00" },
                    { 12, " 8.6", 1, "C15", null, "SofLens 59 6 pk", 1.0, 1, "-3.25" },
                    { 13, " 8.6", 1, "C16", null, "SofLens 59 6 pk", 1.0, 1, "-3.50" },
                    { 14, " 8.6", 1, "C17", null, "SofLens 59 6 pk", 1.0, 1, "-3.75" },
                    { 15, " 8.6", 1, "C18", null, "SofLens 59 6 pk", 1.0, 1, "-4.00" },
                    { 16, " 8.6", 1, "C19", null, "SofLens 59 6 pk", 1.0, 1, "-4.25" },
                    { 17, " 8.6", 1, "C20", null, "SofLens 59 6 pk", 1.0, 1, "-4.50" },
                    { 18, " 8.6", 1, "C21", null, "SofLens 59 6 pk", 1.0, 1, "-4.75" },
                    { 19, " 8.6", 1, "C22", null, "SofLens 59 6 pk", 1.0, 1, "-5.00" },
                    { 20, " 8.6", 1, "C23", null, "SofLens 59 6 pk", 1.0, 1, "-5.25" },
                    { 21, " 8.6", 1, "C24", null, "SofLens 59 6 pk", 1.0, 1, "-5.50" },
                    { 22, " 8.6", 1, "C25", null, "SofLens 59 6 pk", 1.0, 1, "-5.75" },
                    { 23, " 8.6", 1, "C26", null, "SofLens 59 6 pk", 1.0, 1, "-6.00" },
                    { 24, " 8.6", 1, "C27", null, "SofLens 59 6 pk", 1.0, 1, "-6.50" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 25, " 8.6", 1, "C28", null, "SofLens 59 6 pk", 1.0, 1, "-7.00" },
                    { 26, " 8.6", 1, "C29", null, "SofLens 59 6 pk", 1.0, 1, "-7.50" },
                    { 27, " 8.6", 1, "C30", null, "SofLens 59 6 pk", 1.0, 1, "-8.00" },
                    { 28, " 8.6", 1, "C31", null, "SofLens 59 6 pk", 1.0, 1, "-8.50" },
                    { 29, " 8.6", 1, "C32", null, "SofLens 59 6 pk", 1.0, 1, "-9.00" },
                    { 30, "", 1, "", null, "", 1.0, 1, "" },
                    { 31, " 8.6", 1, "E5", null, "SofLens 59 6 pk", 1.0, 1, "+0.75" },
                    { 32, " 8.6", 1, "E6", null, "SofLens 59 6 pk", 1.0, 1, "+1.00" },
                    { 33, " 8.6", 1, "E7", null, "SofLens 59 6 pk", 1.0, 1, "+1.25" },
                    { 34, " 8.6", 1, "E8", null, "SofLens 59 6 pk", 1.0, 1, "+1.50" },
                    { 35, " 8.6", 1, "E9", null, "SofLens 59 6 pk", 1.0, 1, "+1.75" },
                    { 36, " 8.6", 1, "E10", null, "SofLens 59 6 pk", 1.0, 1, "+2.00" },
                    { 37, " 8.6", 1, "E11", null, "SofLens 59 6 pk", 1.0, 1, "+2.25" },
                    { 38, " 8.6", 1, "E12", null, "SofLens 59 6 pk", 1.0, 1, "+2.50" },
                    { 39, " 8.6", 1, "E13", null, "SofLens 59 6 pk", 1.0, 1, "+2.75" },
                    { 40, " 8.6", 1, "E14", null, "SofLens 59 6 pk", 1.0, 1, "+3.00" },
                    { 41, " 8.6", 1, "E15", null, "SofLens 59 6 pk", 1.0, 1, "+3.25" },
                    { 42, " 8.6", 1, "E16", null, "SofLens 59 6 pk", 1.0, 1, "+3.50" },
                    { 43, " 8.6", 1, "E17", null, "SofLens 59 6 pk", 1.0, 1, "+3.75" },
                    { 44, " 8.6", 1, "E18", null, "SofLens 59 6 pk", 1.0, 1, "+4.00" },
                    { 45, " 8.6", 1, "E19", null, "SofLens 59 6 pk", 1.0, 1, "+4.25" },
                    { 46, " 8.6", 1, "E20", null, "SofLens 59 6 pk", 1.0, 1, "+4.50" },
                    { 47, " 8.6", 1, "E21", null, "SofLens 59 6 pk", 1.0, 1, "+4.75" },
                    { 48, " 8.6", 1, "E22", null, "SofLens 59 6 pk", 1.0, 1, "+5.00" },
                    { 49, " 8.6", 1, "E23", null, "SofLens 59 6 pk", 1.0, 1, "+5.25" },
                    { 50, " 8.6", 1, "E24", null, "SofLens 59 6 pk", 1.0, 1, "+5.50" },
                    { 51, " 8.6", 1, "E25", null, "SofLens 59 6 pk", 1.0, 1, "+5.75" },
                    { 52, " 8.6", 1, "E26", null, "SofLens 59 6 pk", 1.0, 1, "+6.00" },
                    { 53, "", 1, "", null, "", 1.0, 1, "" },
                    { 54, " 8.6", 1, "H5", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-0.75" },
                    { 55, " 8.6", 1, "H6", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-1.00" },
                    { 56, " 8.6", 1, "H7", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-1.25" },
                    { 57, " 8.6", 1, "H8", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-1.50" },
                    { 58, " 8.6", 1, "H9", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-1.75" },
                    { 59, " 8.6", 1, "H10", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-2.00" },
                    { 60, " 8.6", 1, "H11", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-2.25" },
                    { 61, " 8.6", 1, "H12", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-2.50" },
                    { 62, " 8.6", 1, "H13", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-2.75" },
                    { 63, " 8.6", 1, "H14", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-3.00" },
                    { 64, " 8.6", 1, "H15", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-3.25" },
                    { 65, " 8.6", 1, "H16", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-3.50" },
                    { 66, " 8.6", 1, "H17", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-3.75" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 67, " 8.6", 1, "H18", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-4.00" },
                    { 68, " 8.6", 1, "H19", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-4.25" },
                    { 69, " 8.6", 1, "H20", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-4.50" },
                    { 70, " 8.6", 1, "H21", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-4.75" },
                    { 71, " 8.6", 1, "H22", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-5.00" },
                    { 72, " 8.6", 1, "H23", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-5.25" },
                    { 73, " 8.6", 1, "H24", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-5.50" },
                    { 74, " 8.6", 1, "H25", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-5.75" },
                    { 75, " 8.6", 1, "H26", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-6.00" },
                    { 76, " 8.6", 1, "H27", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-6.50" },
                    { 77, " 8.6", 1, "H28", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-7.00" },
                    { 78, " 8.6", 1, "H29", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-7.50" },
                    { 79, " 8.6", 1, "H30", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-8.00" },
                    { 80, " 8.6", 1, "H31", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-8.50" },
                    { 81, " 8.6", 1, "H32", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-9.00" },
                    { 82, "", 1, "", null, "", 1.0, 1, "" },
                    { 83, " 8.6", 1, "J5", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+0.75" },
                    { 84, " 8.6", 1, "J6", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+1.00" },
                    { 85, " 8.6", 1, "J7", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+1.25" },
                    { 86, " 8.6", 1, "J8", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+1.50" },
                    { 87, " 8.6", 1, "J9", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+1.75" },
                    { 88, " 8.6", 1, "J10", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+2.00" },
                    { 89, " 8.6", 1, "J11", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+2.25" },
                    { 90, " 8.6", 1, "J12", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+2.50" },
                    { 91, " 8.6", 1, "J13", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+2.75" },
                    { 92, " 8.6", 1, "J14", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+3.00" },
                    { 93, " 8.6", 1, "J15", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+3.25" },
                    { 94, " 8.6", 1, "J16", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+3.50" },
                    { 95, " 8.6", 1, "J17", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+3.75" },
                    { 96, " 8.6", 1, "J18", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+4.00" },
                    { 97, " 8.6", 1, "J19", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+4.25" },
                    { 98, " 8.6", 1, "J20", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+4.50" },
                    { 99, " 8.6", 1, "J21", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+4.75" },
                    { 100, " 8.6", 1, "J22", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+5.00" },
                    { 101, " 8.6", 1, "J23", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+5.25" },
                    { 102, " 8.6", 1, "J24", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+5.50" },
                    { 103, " 8.6", 1, "J25", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+5.75" },
                    { 104, " 8.6", 1, "J26", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+6.00" },
                    { 105, " 8.6", 1, "J27", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+6.50" }
                });

            migrationBuilder.InsertData(
                table: "ItemOrders",
                columns: new[] { "ItemOrderId", "Description", "Edited", "OrderCustomerId", "OrderVendorId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, "Опиасние oc201-io301-ov401 p1001", new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4404), 1, 1, 1.1100000000000001, 1, 22 },
                    { 2, "Опиасние oc201-io302-ov401 p1002", new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4407), 1, 1, 2.2200000000000002, 2, 33 },
                    { 3, "Опиасние oc201-io303-ov401 p1003", new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4408), 1, 1, 3.3300000000000001, 3, 44 },
                    { 4, "Опиасние oc201-io304-ov401 p1004", new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4410), 1, 1, 4.4400000000000004, 4, 55 },
                    { 5, "Опиасние oc201-io305-ov403 p1005", new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4411), 1, null, 6.4500000000000002, 5, 855 },
                    { 6, "Опиасние oc201-io306-ov404 p1006", new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4413), 1, null, 0.0, 6, 0 },
                    { 7, "Опиасние oc205-io307-ov406 p1008", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 6, 0.0, 8, 0 },
                    { 8, "Опиасние oc209-io308-ov402 p1006", new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, 0.0, 6, 0 },
                    { 9, "Опиасние oc201-io309-ov408 p1001", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, 0.0, 1, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrders_OrderCustomerId",
                table: "ItemOrders",
                column: "OrderCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrders_OrderVendorId",
                table: "ItemOrders",
                column: "OrderVendorId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrders_ProductId",
                table: "ItemOrders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustomers_CustomerId",
                table: "OrderCustomers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderVendors_VendorId",
                table: "OrderVendors",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemOrders");

            migrationBuilder.DropTable(
                name: "OrderCustomers");

            migrationBuilder.DropTable(
                name: "OrderVendors");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

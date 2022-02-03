using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class Init301 : Migration
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
                    ExcelFileId = table.Column<int>(type: "int", nullable: false),
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
                    { 1, null, "Beverages" },
                    { 2, null, "Bakery" },
                    { 3, null, "Meat" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "Оптика № 1", "Описание компании 1", "k1@gmail.com", "Иванов И.И.", "Иванов И.И.", null, "+375 29 123-12-12" },
                    { 2, "Оптика Нова", "Описание компании 2", "k2@gmail.com", "Петров П.П.", "Петров П.П.", null, "+375 29 123-12-13" },
                    { 3, "ИП Смирнов", "Описание компании 3", "k3@gmail.com", "Смирнов С.С.", "Смирнов С.С.", null, "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "Поставщик № 1", "", "Email", null, "Иванов", null, null },
                    { 2, "Поставщик № 2", "", "Email", null, "Петров", null, null },
                    { 3, "Поставщик № 3", "", "Email", null, "Сидоров", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderCustomers",
                columns: new[] { "OrderCustomerId", "CustomerId", "Description", "Edited", "ExcelFileId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Описание заказа 1", new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 1, null },
                    { 2, 2, "Описание заказа 2", new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 3, 3, "Описание заказа 3", new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 4, 1, "Описание заказа 41", new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null }
                });

            migrationBuilder.InsertData(
                table: "OrderVendors",
                columns: new[] { "OrderVendorId", "Description", "Edited", "Name", "VendorId" },
                values: new object[,]
                {
                    { 1, "Customer-401.1", new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), "OrderVendor-401", 1 },
                    { 2, "Customer-402.1", new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), "OrderVendor-402", 1 },
                    { 3, "Customer-403.1", new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), "OrderVendor-403", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 1, " 8.6", 1, "C4", null, "SofLens 59 6 pk", 1.0, 1, "-0.50" },
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
                    { 24, " 8.6", 1, "C27", null, "SofLens 59 6 pk", 1.0, 1, "-6.50" },
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
                    { 35, " 8.6", 1, "E9", null, "SofLens 59 6 pk", 1.0, 1, "+1.75" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
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
                    { 66, " 8.6", 1, "H17", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-3.75" },
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
                    { 77, " 8.6", 1, "H28", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-7.00" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
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
                    { 1, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 1, 1, 1.1100000000000001, 1, 22 },
                    { 2, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 1, 2, 2.2200000000000002, 2, 33 },
                    { 3, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 2, 1, 3.3300000000000001, 3, 44 },
                    { 4, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, 3, 4.4400000000000004, 4, 55 },
                    { 5, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 6.4500000000000002, 5, 855 },
                    { 6, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 7, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 8, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 9, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 10, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 11, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 12, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 13, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 14, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 15, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 16, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 17, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 18, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 19, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 21, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 22, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 23, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 24, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 25, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 26, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 27, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 28, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 29, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 30, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 31, null, new DateTime(2022, 2, 3, 16, 50, 12, 269, DateTimeKind.Local).AddTicks(1639), 3, null, 0.0, 6, 0 },
                    { 32, null, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 3, 0 },
                    { 33, null, new DateTime(2020, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 32, 0 },
                    { 34, null, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 1, 0 },
                    { 35, null, new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 55, 0 },
                    { 36, null, new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 17, 0 },
                    { 37, null, new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 23, 0 },
                    { 38, null, new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 32, 0 },
                    { 39, null, new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 18, 0 },
                    { 40, null, new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 26, 0 },
                    { 41, null, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 22, 0 },
                    { 42, null, new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 69, 0 },
                    { 43, null, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 62, 0 }
                });

            migrationBuilder.InsertData(
                table: "ItemOrders",
                columns: new[] { "ItemOrderId", "Description", "Edited", "OrderCustomerId", "OrderVendorId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 44, null, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 53, 0 },
                    { 45, null, new DateTime(2020, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 64, 0 },
                    { 46, null, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 75, 0 },
                    { 47, null, new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 58, 0 },
                    { 48, null, new DateTime(2020, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 90, 0 },
                    { 49, null, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 94, 0 },
                    { 50, null, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 19, 0 },
                    { 51, null, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 61, 0 },
                    { 52, null, new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 88, 0 },
                    { 53, null, new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 40, 0 },
                    { 54, null, new DateTime(2020, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 43, 0 },
                    { 55, null, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 20, 0 },
                    { 56, null, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 73, 0 },
                    { 57, null, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 86, 0 },
                    { 58, null, new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 86, 0 },
                    { 59, null, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 96, 0 },
                    { 60, null, new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 1, 0 },
                    { 61, null, new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 99, 0 },
                    { 62, null, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 5, 0 },
                    { 63, null, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 2, 0 },
                    { 64, null, new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 21, 0 },
                    { 65, null, new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 67, 0 },
                    { 66, null, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 50, 0 },
                    { 67, null, new DateTime(2020, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 27, 0 },
                    { 68, null, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 13, 0 },
                    { 69, null, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 43, 0 },
                    { 70, null, new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 57, 0 },
                    { 71, null, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 22, 0 },
                    { 72, null, new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 17, 0 },
                    { 73, null, new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 38, 0 },
                    { 74, null, new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 28, 0 },
                    { 75, null, new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 28, 0 },
                    { 76, null, new DateTime(2020, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 98, 0 },
                    { 77, null, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 50, 0 },
                    { 78, null, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 26, 0 },
                    { 79, null, new DateTime(2020, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 88, 0 },
                    { 80, null, new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 94, 0 },
                    { 81, null, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 69, 0 },
                    { 82, null, new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 60, 0 },
                    { 83, null, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 84, 0 },
                    { 84, null, new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 99, 0 },
                    { 85, null, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 95, 0 }
                });

            migrationBuilder.InsertData(
                table: "ItemOrders",
                columns: new[] { "ItemOrderId", "Description", "Edited", "OrderCustomerId", "OrderVendorId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 86, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 17, 0 },
                    { 87, null, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 58, 0 },
                    { 88, null, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 34, 0 },
                    { 89, null, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 59, 0 },
                    { 90, null, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 52, 0 },
                    { 91, null, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 97, 0 },
                    { 92, null, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 25, 0 },
                    { 93, null, new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 56, 0 },
                    { 94, null, new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0.0, 75, 0 },
                    { 95, null, new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 89, 0 },
                    { 96, null, new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 80, 0 },
                    { 97, null, new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 51, 0 },
                    { 98, null, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 81, 0 },
                    { 99, null, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0.0, 64, 0 }
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

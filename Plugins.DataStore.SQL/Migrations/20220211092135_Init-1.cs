using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class Init1 : Migration
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
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
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
                    { 9, "Покупатель: 109", "Customer c109", "k3@gmail.com", "Покупатель: 109", "Покупатель: 109", "9", "+375 29 123-12-14" },
                    { 10, "Покупатель: 1010", "Customer c1010", "k3@gmail.com", "Покупатель: 1010", "Покупатель: 1010", "10", "+375 29 123-12-14" },
                    { 11, "Покупатель: 1011", "Customer c1011", "k3@gmail.com", "Покупатель: 1011", "Покупатель: 1011", "11", "+375 29 123-12-14" },
                    { 12, "Покупатель: 1012", "Customer c1012", "k3@gmail.com", "Покупатель: 1012", "Покупатель: 1012", "12", "+375 29 123-12-14" },
                    { 13, "Покупатель: 1013", "Customer c1013", "k3@gmail.com", "Покупатель: 1013", "Покупатель: 1013", "13", "+375 29 123-12-14" },
                    { 14, "Покупатель: 1014", "Customer c1014", "k3@gmail.com", "Покупатель: 1014", "Покупатель: 1014", "14", "+375 29 123-12-14" },
                    { 15, "Покупатель: 1015", "Customer c1015", "k3@gmail.com", "Покупатель: 1015", "Покупатель: 1015", "15", "+375 29 123-12-14" },
                    { 16, "Покупатель: 1016", "Customer c1016", "k3@gmail.com", "Покупатель: 1016", "Покупатель: 1016", "16", "+375 29 123-12-14" },
                    { 17, "Покупатель: 1017", "Customer c1017", "k3@gmail.com", "Покупатель: 1017", "Покупатель: 1017", "17", "+375 29 123-12-14" },
                    { 18, "Покупатель: 1018", "Customer c1018", "k3@gmail.com", "Покупатель: 1018", "Покупатель: 1018", "18", "+375 29 123-12-14" },
                    { 19, "Покупатель: 1019", "Customer c1019", "k3@gmail.com", "Покупатель: 1019", "Покупатель: 1019", "19", "+375 29 123-12-14" },
                    { 20, "Покупатель: 1020", "Customer c1020", "k3@gmail.com", "Покупатель: 1020", "Покупатель: 1020", "20", "+375 29 123-12-14" },
                    { 21, "Покупатель: 1021", "Customer c1021", "k3@gmail.com", "Покупатель: 1021", "Покупатель: 1021", "21", "+375 29 123-12-14" },
                    { 22, "Покупатель: 1022", "Customer c1022", "k3@gmail.com", "Покупатель: 1022", "Покупатель: 1022", "22", "+375 29 123-12-14" },
                    { 23, "Покупатель: 1023", "Customer c1023", "k3@gmail.com", "Покупатель: 1023", "Покупатель: 1023", "23", "+375 29 123-12-14" },
                    { 24, "Покупатель: 1024", "Customer c1024", "k3@gmail.com", "Покупатель: 1024", "Покупатель: 1024", "24", "+375 29 123-12-14" },
                    { 25, "Покупатель: 1025", "Customer c1025", "k3@gmail.com", "Покупатель: 1025", "Покупатель: 1025", "25", "+375 29 123-12-14" },
                    { 26, "Покупатель: 1026", "Customer c1026", "k3@gmail.com", "Покупатель: 1026", "Покупатель: 1026", "26", "+375 29 123-12-14" },
                    { 27, "Покупатель: 1027", "Customer c1027", "k3@gmail.com", "Покупатель: 1027", "Покупатель: 1027", "27", "+375 29 123-12-14" },
                    { 28, "Покупатель: 1028", "Customer c1028", "k3@gmail.com", "Покупатель: 1028", "Покупатель: 1028", "28", "+375 29 123-12-14" },
                    { 29, "Покупатель: 1029", "Customer c1029", "k3@gmail.com", "Покупатель: 1029", "Покупатель: 1029", "29", "+375 29 123-12-14" },
                    { 30, "Покупатель: 1030", "Customer c1030", "k3@gmail.com", "Покупатель: 1030", "Покупатель: 1030", "30", "+375 29 123-12-14" },
                    { 31, "Покупатель: 1031", "Customer c1031", "k3@gmail.com", "Покупатель: 1031", "Покупатель: 1031", "31", "+375 29 123-12-14" },
                    { 32, "Покупатель: 1032", "Customer c1032", "k3@gmail.com", "Покупатель: 1032", "Покупатель: 1032", "32", "+375 29 123-12-14" },
                    { 33, "Покупатель: 1033", "Customer c1033", "k3@gmail.com", "Покупатель: 1033", "Покупатель: 1033", "33", "+375 29 123-12-14" },
                    { 34, "Покупатель: 1034", "Customer c1034", "k3@gmail.com", "Покупатель: 1034", "Покупатель: 1034", "34", "+375 29 123-12-14" },
                    { 35, "Покупатель: 1035", "Customer c1035", "k3@gmail.com", "Покупатель: 1035", "Покупатель: 1035", "35", "+375 29 123-12-14" },
                    { 36, "Покупатель: 1036", "Customer c1036", "k3@gmail.com", "Покупатель: 1036", "Покупатель: 1036", "36", "+375 29 123-12-14" },
                    { 37, "Покупатель: 1037", "Customer c1037", "k3@gmail.com", "Покупатель: 1037", "Покупатель: 1037", "37", "+375 29 123-12-14" },
                    { 38, "Покупатель: 1038", "Customer c1038", "k3@gmail.com", "Покупатель: 1038", "Покупатель: 1038", "38", "+375 29 123-12-14" },
                    { 39, "Покупатель: 1039", "Customer c1039", "k3@gmail.com", "Покупатель: 1039", "Покупатель: 1039", "39", "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 40, "Покупатель: 1040", "Customer c1040", "k3@gmail.com", "Покупатель: 1040", "Покупатель: 1040", "40", "+375 29 123-12-14" },
                    { 41, "Покупатель: 1041", "Customer c1041", "k3@gmail.com", "Покупатель: 1041", "Покупатель: 1041", "41", "+375 29 123-12-14" },
                    { 42, "Покупатель: 1042", "Customer c1042", "k3@gmail.com", "Покупатель: 1042", "Покупатель: 1042", "42", "+375 29 123-12-14" },
                    { 43, "Покупатель: 1043", "Customer c1043", "k3@gmail.com", "Покупатель: 1043", "Покупатель: 1043", "43", "+375 29 123-12-14" },
                    { 44, "Покупатель: 1044", "Customer c1044", "k3@gmail.com", "Покупатель: 1044", "Покупатель: 1044", "44", "+375 29 123-12-14" },
                    { 45, "Покупатель: 1045", "Customer c1045", "k3@gmail.com", "Покупатель: 1045", "Покупатель: 1045", "45", "+375 29 123-12-14" },
                    { 46, "Покупатель: 1046", "Customer c1046", "k3@gmail.com", "Покупатель: 1046", "Покупатель: 1046", "46", "+375 29 123-12-14" },
                    { 47, "Покупатель: 1047", "Customer c1047", "k3@gmail.com", "Покупатель: 1047", "Покупатель: 1047", "47", "+375 29 123-12-14" },
                    { 48, "Покупатель: 1048", "Customer c1048", "k3@gmail.com", "Покупатель: 1048", "Покупатель: 1048", "48", "+375 29 123-12-14" },
                    { 49, "Покупатель: 1049", "Customer c1049", "k3@gmail.com", "Покупатель: 1049", "Покупатель: 1049", "49", "+375 29 123-12-14" },
                    { 50, "Покупатель: 1050", "Customer c1050", "k3@gmail.com", "Покупатель: 1050", "Покупатель: 1050", "50", "+375 29 123-12-14" },
                    { 51, "Покупатель: 1051", "Customer c1051", "k3@gmail.com", "Покупатель: 1051", "Покупатель: 1051", "51", "+375 29 123-12-14" },
                    { 52, "Покупатель: 1052", "Customer c1052", "k3@gmail.com", "Покупатель: 1052", "Покупатель: 1052", "52", "+375 29 123-12-14" },
                    { 53, "Покупатель: 1053", "Customer c1053", "k3@gmail.com", "Покупатель: 1053", "Покупатель: 1053", "53", "+375 29 123-12-14" },
                    { 54, "Покупатель: 1054", "Customer c1054", "k3@gmail.com", "Покупатель: 1054", "Покупатель: 1054", "54", "+375 29 123-12-14" },
                    { 55, "Покупатель: 1055", "Customer c1055", "k3@gmail.com", "Покупатель: 1055", "Покупатель: 1055", "55", "+375 29 123-12-14" },
                    { 56, "Покупатель: 1056", "Customer c1056", "k3@gmail.com", "Покупатель: 1056", "Покупатель: 1056", "56", "+375 29 123-12-14" },
                    { 57, "Покупатель: 1057", "Customer c1057", "k3@gmail.com", "Покупатель: 1057", "Покупатель: 1057", "57", "+375 29 123-12-14" },
                    { 58, "Покупатель: 1058", "Customer c1058", "k3@gmail.com", "Покупатель: 1058", "Покупатель: 1058", "58", "+375 29 123-12-14" },
                    { 59, "Покупатель: 1059", "Customer c1059", "k3@gmail.com", "Покупатель: 1059", "Покупатель: 1059", "59", "+375 29 123-12-14" },
                    { 60, "Покупатель: 1060", "Customer c1060", "k3@gmail.com", "Покупатель: 1060", "Покупатель: 1060", "60", "+375 29 123-12-14" },
                    { 61, "Покупатель: 1061", "Customer c1061", "k3@gmail.com", "Покупатель: 1061", "Покупатель: 1061", "61", "+375 29 123-12-14" },
                    { 62, "Покупатель: 1062", "Customer c1062", "k3@gmail.com", "Покупатель: 1062", "Покупатель: 1062", "62", "+375 29 123-12-14" },
                    { 63, "Покупатель: 1063", "Customer c1063", "k3@gmail.com", "Покупатель: 1063", "Покупатель: 1063", "63", "+375 29 123-12-14" },
                    { 64, "Покупатель: 1064", "Customer c1064", "k3@gmail.com", "Покупатель: 1064", "Покупатель: 1064", "64", "+375 29 123-12-14" },
                    { 65, "Покупатель: 1065", "Customer c1065", "k3@gmail.com", "Покупатель: 1065", "Покупатель: 1065", "65", "+375 29 123-12-14" },
                    { 66, "Покупатель: 1066", "Customer c1066", "k3@gmail.com", "Покупатель: 1066", "Покупатель: 1066", "66", "+375 29 123-12-14" },
                    { 67, "Покупатель: 1067", "Customer c1067", "k3@gmail.com", "Покупатель: 1067", "Покупатель: 1067", "67", "+375 29 123-12-14" },
                    { 68, "Покупатель: 1068", "Customer c1068", "k3@gmail.com", "Покупатель: 1068", "Покупатель: 1068", "68", "+375 29 123-12-14" },
                    { 69, "Покупатель: 1069", "Customer c1069", "k3@gmail.com", "Покупатель: 1069", "Покупатель: 1069", "69", "+375 29 123-12-14" },
                    { 70, "Покупатель: 1070", "Customer c1070", "k3@gmail.com", "Покупатель: 1070", "Покупатель: 1070", "70", "+375 29 123-12-14" },
                    { 71, "Покупатель: 1071", "Customer c1071", "k3@gmail.com", "Покупатель: 1071", "Покупатель: 1071", "71", "+375 29 123-12-14" },
                    { 72, "Покупатель: 1072", "Customer c1072", "k3@gmail.com", "Покупатель: 1072", "Покупатель: 1072", "72", "+375 29 123-12-14" },
                    { 73, "Покупатель: 1073", "Customer c1073", "k3@gmail.com", "Покупатель: 1073", "Покупатель: 1073", "73", "+375 29 123-12-14" },
                    { 74, "Покупатель: 1074", "Customer c1074", "k3@gmail.com", "Покупатель: 1074", "Покупатель: 1074", "74", "+375 29 123-12-14" },
                    { 75, "Покупатель: 1075", "Customer c1075", "k3@gmail.com", "Покупатель: 1075", "Покупатель: 1075", "75", "+375 29 123-12-14" },
                    { 76, "Покупатель: 1076", "Customer c1076", "k3@gmail.com", "Покупатель: 1076", "Покупатель: 1076", "76", "+375 29 123-12-14" },
                    { 77, "Покупатель: 1077", "Customer c1077", "k3@gmail.com", "Покупатель: 1077", "Покупатель: 1077", "77", "+375 29 123-12-14" },
                    { 78, "Покупатель: 1078", "Customer c1078", "k3@gmail.com", "Покупатель: 1078", "Покупатель: 1078", "78", "+375 29 123-12-14" },
                    { 79, "Покупатель: 1079", "Customer c1079", "k3@gmail.com", "Покупатель: 1079", "Покупатель: 1079", "79", "+375 29 123-12-14" },
                    { 80, "Покупатель: 1080", "Customer c1080", "k3@gmail.com", "Покупатель: 1080", "Покупатель: 1080", "80", "+375 29 123-12-14" },
                    { 81, "Покупатель: 1081", "Customer c1081", "k3@gmail.com", "Покупатель: 1081", "Покупатель: 1081", "81", "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 82, "Покупатель: 1082", "Customer c1082", "k3@gmail.com", "Покупатель: 1082", "Покупатель: 1082", "82", "+375 29 123-12-14" },
                    { 83, "Покупатель: 1083", "Customer c1083", "k3@gmail.com", "Покупатель: 1083", "Покупатель: 1083", "83", "+375 29 123-12-14" },
                    { 84, "Покупатель: 1084", "Customer c1084", "k3@gmail.com", "Покупатель: 1084", "Покупатель: 1084", "84", "+375 29 123-12-14" },
                    { 85, "Покупатель: 1085", "Customer c1085", "k3@gmail.com", "Покупатель: 1085", "Покупатель: 1085", "85", "+375 29 123-12-14" },
                    { 86, "Покупатель: 1086", "Customer c1086", "k3@gmail.com", "Покупатель: 1086", "Покупатель: 1086", "86", "+375 29 123-12-14" },
                    { 87, "Покупатель: 1087", "Customer c1087", "k3@gmail.com", "Покупатель: 1087", "Покупатель: 1087", "87", "+375 29 123-12-14" },
                    { 88, "Покупатель: 1088", "Customer c1088", "k3@gmail.com", "Покупатель: 1088", "Покупатель: 1088", "88", "+375 29 123-12-14" },
                    { 89, "Покупатель: 1089", "Customer c1089", "k3@gmail.com", "Покупатель: 1089", "Покупатель: 1089", "89", "+375 29 123-12-14" },
                    { 90, "Покупатель: 1090", "Customer c1090", "k3@gmail.com", "Покупатель: 1090", "Покупатель: 1090", "90", "+375 29 123-12-14" },
                    { 91, "Покупатель: 1091", "Customer c1091", "k3@gmail.com", "Покупатель: 1091", "Покупатель: 1091", "91", "+375 29 123-12-14" },
                    { 92, "Покупатель: 1092", "Customer c1092", "k3@gmail.com", "Покупатель: 1092", "Покупатель: 1092", "92", "+375 29 123-12-14" },
                    { 93, "Покупатель: 1093", "Customer c1093", "k3@gmail.com", "Покупатель: 1093", "Покупатель: 1093", "93", "+375 29 123-12-14" },
                    { 94, "Покупатель: 1094", "Customer c1094", "k3@gmail.com", "Покупатель: 1094", "Покупатель: 1094", "94", "+375 29 123-12-14" },
                    { 95, "Покупатель: 1095", "Customer c1095", "k3@gmail.com", "Покупатель: 1095", "Покупатель: 1095", "95", "+375 29 123-12-14" },
                    { 96, "Покупатель: 1096", "Customer c1096", "k3@gmail.com", "Покупатель: 1096", "Покупатель: 1096", "96", "+375 29 123-12-14" },
                    { 97, "Покупатель: 1097", "Customer c1097", "k3@gmail.com", "Покупатель: 1097", "Покупатель: 1097", "97", "+375 29 123-12-14" },
                    { 98, "Покупатель: 1098", "Customer c1098", "k3@gmail.com", "Покупатель: 1098", "Покупатель: 1098", "98", "+375 29 123-12-14" },
                    { 99, "Покупатель: 1099", "Customer c1099", "k3@gmail.com", "Покупатель: 1099", "Покупатель: 1099", "99", "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "Поставщик № 501", "Описание p501", "mail-501@gmail.com", null, "Поставщик № 501", null, null },
                    { 2, "Поставщик: 502", "Описание p502-34", "mail-502@gmail.com", null, "Поставщик: 502", null, "+375 29 123-12-14" },
                    { 3, "Поставщик: 503", "Описание p503-73", "mail-503@gmail.com", null, "Поставщик: 503", null, "+375 29 123-12-14" },
                    { 4, "Поставщик: 504", "Описание p504-82", "mail-504@gmail.com", null, "Поставщик: 504", null, "+375 29 123-12-14" },
                    { 5, "Поставщик: 505", "Описание p505-23", "mail-505@gmail.com", null, "Поставщик: 505", null, "+375 29 123-12-14" },
                    { 6, "Поставщик: 506", "Описание p506-98", "mail-506@gmail.com", null, "Поставщик: 506", null, "+375 29 123-12-14" },
                    { 7, "Поставщик: 507", "Описание p507-53", "mail-507@gmail.com", null, "Поставщик: 507", null, "+375 29 123-12-14" },
                    { 8, "Поставщик: 508", "Описание p508-66", "mail-508@gmail.com", null, "Поставщик: 508", null, "+375 29 123-12-14" },
                    { 9, "Поставщик: 509", "Описание p509-44", "mail-509@gmail.com", null, "Поставщик: 509", null, "+375 29 123-12-14" },
                    { 10, "Поставщик: 5010", "Описание p5010-13", "mail-5010@gmail.com", null, "Поставщик: 5010", null, "+375 29 123-12-14" },
                    { 11, "Поставщик: 5011", "Описание p5011-29", "mail-5011@gmail.com", null, "Поставщик: 5011", null, "+375 29 123-12-14" },
                    { 12, "Поставщик: 5012", "Описание p5012-83", "mail-5012@gmail.com", null, "Поставщик: 5012", null, "+375 29 123-12-14" },
                    { 13, "Поставщик: 5013", "Описание p5013-34", "mail-5013@gmail.com", null, "Поставщик: 5013", null, "+375 29 123-12-14" },
                    { 14, "Поставщик: 5014", "Описание p5014-10", "mail-5014@gmail.com", null, "Поставщик: 5014", null, "+375 29 123-12-14" },
                    { 15, "Поставщик: 5015", "Описание p5015-19", "mail-5015@gmail.com", null, "Поставщик: 5015", null, "+375 29 123-12-14" },
                    { 16, "Поставщик: 5016", "Описание p5016-72", "mail-5016@gmail.com", null, "Поставщик: 5016", null, "+375 29 123-12-14" },
                    { 17, "Поставщик: 5017", "Описание p5017-65", "mail-5017@gmail.com", null, "Поставщик: 5017", null, "+375 29 123-12-14" },
                    { 18, "Поставщик: 5018", "Описание p5018-18", "mail-5018@gmail.com", null, "Поставщик: 5018", null, "+375 29 123-12-14" },
                    { 19, "Поставщик: 5019", "Описание p5019-23", "mail-5019@gmail.com", null, "Поставщик: 5019", null, "+375 29 123-12-14" },
                    { 20, "Поставщик: 5020", "Описание p5020-42", "mail-5020@gmail.com", null, "Поставщик: 5020", null, "+375 29 123-12-14" },
                    { 21, "Поставщик: 5021", "Описание p5021-34", "mail-5021@gmail.com", null, "Поставщик: 5021", null, "+375 29 123-12-14" },
                    { 22, "Поставщик: 5022", "Описание p5022-99", "mail-5022@gmail.com", null, "Поставщик: 5022", null, "+375 29 123-12-14" },
                    { 23, "Поставщик: 5023", "Описание p5023-12", "mail-5023@gmail.com", null, "Поставщик: 5023", null, "+375 29 123-12-14" },
                    { 24, "Поставщик: 5024", "Описание p5024-49", "mail-5024@gmail.com", null, "Поставщик: 5024", null, "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 25, "Поставщик: 5025", "Описание p5025-74", "mail-5025@gmail.com", null, "Поставщик: 5025", null, "+375 29 123-12-14" },
                    { 26, "Поставщик: 5026", "Описание p5026-70", "mail-5026@gmail.com", null, "Поставщик: 5026", null, "+375 29 123-12-14" },
                    { 27, "Поставщик: 5027", "Описание p5027-34", "mail-5027@gmail.com", null, "Поставщик: 5027", null, "+375 29 123-12-14" },
                    { 28, "Поставщик: 5028", "Описание p5028-29", "mail-5028@gmail.com", null, "Поставщик: 5028", null, "+375 29 123-12-14" },
                    { 29, "Поставщик: 5029", "Описание p5029-7", "mail-5029@gmail.com", null, "Поставщик: 5029", null, "+375 29 123-12-14" },
                    { 30, "Поставщик: 5030", "Описание p5030-6", "mail-5030@gmail.com", null, "Поставщик: 5030", null, "+375 29 123-12-14" },
                    { 31, "Поставщик: 5031", "Описание p5031-16", "mail-5031@gmail.com", null, "Поставщик: 5031", null, "+375 29 123-12-14" },
                    { 32, "Поставщик: 5032", "Описание p5032-33", "mail-5032@gmail.com", null, "Поставщик: 5032", null, "+375 29 123-12-14" },
                    { 33, "Поставщик: 5033", "Описание p5033-26", "mail-5033@gmail.com", null, "Поставщик: 5033", null, "+375 29 123-12-14" },
                    { 34, "Поставщик: 5034", "Описание p5034-85", "mail-5034@gmail.com", null, "Поставщик: 5034", null, "+375 29 123-12-14" },
                    { 35, "Поставщик: 5035", "Описание p5035-81", "mail-5035@gmail.com", null, "Поставщик: 5035", null, "+375 29 123-12-14" },
                    { 36, "Поставщик: 5036", "Описание p5036-14", "mail-5036@gmail.com", null, "Поставщик: 5036", null, "+375 29 123-12-14" },
                    { 37, "Поставщик: 5037", "Описание p5037-29", "mail-5037@gmail.com", null, "Поставщик: 5037", null, "+375 29 123-12-14" },
                    { 38, "Поставщик: 5038", "Описание p5038-40", "mail-5038@gmail.com", null, "Поставщик: 5038", null, "+375 29 123-12-14" },
                    { 39, "Поставщик: 5039", "Описание p5039-34", "mail-5039@gmail.com", null, "Поставщик: 5039", null, "+375 29 123-12-14" },
                    { 40, "Поставщик: 5040", "Описание p5040-37", "mail-5040@gmail.com", null, "Поставщик: 5040", null, "+375 29 123-12-14" },
                    { 41, "Поставщик: 5041", "Описание p5041-71", "mail-5041@gmail.com", null, "Поставщик: 5041", null, "+375 29 123-12-14" },
                    { 42, "Поставщик: 5042", "Описание p5042-7", "mail-5042@gmail.com", null, "Поставщик: 5042", null, "+375 29 123-12-14" },
                    { 43, "Поставщик: 5043", "Описание p5043-95", "mail-5043@gmail.com", null, "Поставщик: 5043", null, "+375 29 123-12-14" },
                    { 44, "Поставщик: 5044", "Описание p5044-39", "mail-5044@gmail.com", null, "Поставщик: 5044", null, "+375 29 123-12-14" },
                    { 45, "Поставщик: 5045", "Описание p5045-84", "mail-5045@gmail.com", null, "Поставщик: 5045", null, "+375 29 123-12-14" },
                    { 46, "Поставщик: 5046", "Описание p5046-45", "mail-5046@gmail.com", null, "Поставщик: 5046", null, "+375 29 123-12-14" },
                    { 47, "Поставщик: 5047", "Описание p5047-74", "mail-5047@gmail.com", null, "Поставщик: 5047", null, "+375 29 123-12-14" },
                    { 48, "Поставщик: 5048", "Описание p5048-43", "mail-5048@gmail.com", null, "Поставщик: 5048", null, "+375 29 123-12-14" },
                    { 49, "Поставщик: 5049", "Описание p5049-10", "mail-5049@gmail.com", null, "Поставщик: 5049", null, "+375 29 123-12-14" },
                    { 50, "Поставщик: 5050", "Описание p5050-38", "mail-5050@gmail.com", null, "Поставщик: 5050", null, "+375 29 123-12-14" },
                    { 51, "Поставщик: 5051", "Описание p5051-87", "mail-5051@gmail.com", null, "Поставщик: 5051", null, "+375 29 123-12-14" },
                    { 52, "Поставщик: 5052", "Описание p5052-14", "mail-5052@gmail.com", null, "Поставщик: 5052", null, "+375 29 123-12-14" },
                    { 53, "Поставщик: 5053", "Описание p5053-18", "mail-5053@gmail.com", null, "Поставщик: 5053", null, "+375 29 123-12-14" },
                    { 54, "Поставщик: 5054", "Описание p5054-26", "mail-5054@gmail.com", null, "Поставщик: 5054", null, "+375 29 123-12-14" },
                    { 55, "Поставщик: 5055", "Описание p5055-55", "mail-5055@gmail.com", null, "Поставщик: 5055", null, "+375 29 123-12-14" },
                    { 56, "Поставщик: 5056", "Описание p5056-22", "mail-5056@gmail.com", null, "Поставщик: 5056", null, "+375 29 123-12-14" },
                    { 57, "Поставщик: 5057", "Описание p5057-9", "mail-5057@gmail.com", null, "Поставщик: 5057", null, "+375 29 123-12-14" },
                    { 58, "Поставщик: 5058", "Описание p5058-58", "mail-5058@gmail.com", null, "Поставщик: 5058", null, "+375 29 123-12-14" },
                    { 59, "Поставщик: 5059", "Описание p5059-51", "mail-5059@gmail.com", null, "Поставщик: 5059", null, "+375 29 123-12-14" },
                    { 60, "Поставщик: 5060", "Описание p5060-39", "mail-5060@gmail.com", null, "Поставщик: 5060", null, "+375 29 123-12-14" },
                    { 61, "Поставщик: 5061", "Описание p5061-21", "mail-5061@gmail.com", null, "Поставщик: 5061", null, "+375 29 123-12-14" },
                    { 62, "Поставщик: 5062", "Описание p5062-1", "mail-5062@gmail.com", null, "Поставщик: 5062", null, "+375 29 123-12-14" },
                    { 63, "Поставщик: 5063", "Описание p5063-71", "mail-5063@gmail.com", null, "Поставщик: 5063", null, "+375 29 123-12-14" },
                    { 64, "Поставщик: 5064", "Описание p5064-71", "mail-5064@gmail.com", null, "Поставщик: 5064", null, "+375 29 123-12-14" },
                    { 65, "Поставщик: 5065", "Описание p5065-5", "mail-5065@gmail.com", null, "Поставщик: 5065", null, "+375 29 123-12-14" },
                    { 66, "Поставщик: 5066", "Описание p5066-1", "mail-5066@gmail.com", null, "Поставщик: 5066", null, "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 67, "Поставщик: 5067", "Описание p5067-67", "mail-5067@gmail.com", null, "Поставщик: 5067", null, "+375 29 123-12-14" },
                    { 68, "Поставщик: 5068", "Описание p5068-12", "mail-5068@gmail.com", null, "Поставщик: 5068", null, "+375 29 123-12-14" },
                    { 69, "Поставщик: 5069", "Описание p5069-89", "mail-5069@gmail.com", null, "Поставщик: 5069", null, "+375 29 123-12-14" },
                    { 70, "Поставщик: 5070", "Описание p5070-61", "mail-5070@gmail.com", null, "Поставщик: 5070", null, "+375 29 123-12-14" },
                    { 71, "Поставщик: 5071", "Описание p5071-85", "mail-5071@gmail.com", null, "Поставщик: 5071", null, "+375 29 123-12-14" },
                    { 72, "Поставщик: 5072", "Описание p5072-86", "mail-5072@gmail.com", null, "Поставщик: 5072", null, "+375 29 123-12-14" },
                    { 73, "Поставщик: 5073", "Описание p5073-30", "mail-5073@gmail.com", null, "Поставщик: 5073", null, "+375 29 123-12-14" },
                    { 74, "Поставщик: 5074", "Описание p5074-47", "mail-5074@gmail.com", null, "Поставщик: 5074", null, "+375 29 123-12-14" },
                    { 75, "Поставщик: 5075", "Описание p5075-93", "mail-5075@gmail.com", null, "Поставщик: 5075", null, "+375 29 123-12-14" },
                    { 76, "Поставщик: 5076", "Описание p5076-35", "mail-5076@gmail.com", null, "Поставщик: 5076", null, "+375 29 123-12-14" },
                    { 77, "Поставщик: 5077", "Описание p5077-63", "mail-5077@gmail.com", null, "Поставщик: 5077", null, "+375 29 123-12-14" },
                    { 78, "Поставщик: 5078", "Описание p5078-58", "mail-5078@gmail.com", null, "Поставщик: 5078", null, "+375 29 123-12-14" },
                    { 79, "Поставщик: 5079", "Описание p5079-97", "mail-5079@gmail.com", null, "Поставщик: 5079", null, "+375 29 123-12-14" },
                    { 80, "Поставщик: 5080", "Описание p5080-71", "mail-5080@gmail.com", null, "Поставщик: 5080", null, "+375 29 123-12-14" },
                    { 81, "Поставщик: 5081", "Описание p5081-91", "mail-5081@gmail.com", null, "Поставщик: 5081", null, "+375 29 123-12-14" },
                    { 82, "Поставщик: 5082", "Описание p5082-42", "mail-5082@gmail.com", null, "Поставщик: 5082", null, "+375 29 123-12-14" },
                    { 83, "Поставщик: 5083", "Описание p5083-68", "mail-5083@gmail.com", null, "Поставщик: 5083", null, "+375 29 123-12-14" },
                    { 84, "Поставщик: 5084", "Описание p5084-89", "mail-5084@gmail.com", null, "Поставщик: 5084", null, "+375 29 123-12-14" },
                    { 85, "Поставщик: 5085", "Описание p5085-41", "mail-5085@gmail.com", null, "Поставщик: 5085", null, "+375 29 123-12-14" },
                    { 86, "Поставщик: 5086", "Описание p5086-79", "mail-5086@gmail.com", null, "Поставщик: 5086", null, "+375 29 123-12-14" },
                    { 87, "Поставщик: 5087", "Описание p5087-28", "mail-5087@gmail.com", null, "Поставщик: 5087", null, "+375 29 123-12-14" },
                    { 88, "Поставщик: 5088", "Описание p5088-54", "mail-5088@gmail.com", null, "Поставщик: 5088", null, "+375 29 123-12-14" },
                    { 89, "Поставщик: 5089", "Описание p5089-74", "mail-5089@gmail.com", null, "Поставщик: 5089", null, "+375 29 123-12-14" },
                    { 90, "Поставщик: 5090", "Описание p5090-19", "mail-5090@gmail.com", null, "Поставщик: 5090", null, "+375 29 123-12-14" },
                    { 91, "Поставщик: 5091", "Описание p5091-59", "mail-5091@gmail.com", null, "Поставщик: 5091", null, "+375 29 123-12-14" },
                    { 92, "Поставщик: 5092", "Описание p5092-30", "mail-5092@gmail.com", null, "Поставщик: 5092", null, "+375 29 123-12-14" },
                    { 93, "Поставщик: 5093", "Описание p5093-24", "mail-5093@gmail.com", null, "Поставщик: 5093", null, "+375 29 123-12-14" },
                    { 94, "Поставщик: 5094", "Описание p5094-2", "mail-5094@gmail.com", null, "Поставщик: 5094", null, "+375 29 123-12-14" },
                    { 95, "Поставщик: 5095", "Описание p5095-84", "mail-5095@gmail.com", null, "Поставщик: 5095", null, "+375 29 123-12-14" },
                    { 96, "Поставщик: 5096", "Описание p5096-29", "mail-5096@gmail.com", null, "Поставщик: 5096", null, "+375 29 123-12-14" },
                    { 97, "Поставщик: 5097", "Описание p5097-82", "mail-5097@gmail.com", null, "Поставщик: 5097", null, "+375 29 123-12-14" },
                    { 98, "Поставщик: 5098", "Описание p5098-85", "mail-5098@gmail.com", null, "Поставщик: 5098", null, "+375 29 123-12-14" },
                    { 99, "Поставщик: 5099", "Описание p5099-59", "mail-5099@gmail.com", null, "Поставщик: 5099", null, "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "OrderCustomers",
                columns: new[] { "OrderCustomerId", "CustomerId", "Description", "Edited", "ExcelFileId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Описание oc201-c101", new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845), 1, null },
                    { 2, 2, "Описание oc202-c102", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 3, 3, "Описание oc203-c103", new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 4, 1, "Описание oc204-c101", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 5, 55, "Описание ov205-c55", new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 205" },
                    { 6, 42, "Описание ov206-c42", new DateTime(2020, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 206" },
                    { 7, 23, "Описание ov207-c23", new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 207" },
                    { 8, 65, "Описание ov208-c65", new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 208" },
                    { 9, 69, "Описание ov209-c69", new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 209" },
                    { 10, 9, "Описание ov2010-c9", new DateTime(2021, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2010" },
                    { 11, 8, "Описание ov2011-c8", new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2011" },
                    { 12, 45, "Описание ov2012-c45", new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2012" },
                    { 13, 26, "Описание ov2013-c26", new DateTime(2020, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2013" },
                    { 14, 1, "Описание ov2014-c1", new DateTime(2020, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2014" },
                    { 15, 7, "Описание ov2015-c7", new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2015" },
                    { 16, 54, "Описание ov2016-c54", new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2016" },
                    { 17, 56, "Описание ov2017-c56", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2017" },
                    { 18, 82, "Описание ov2018-c82", new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2018" },
                    { 19, 90, "Описание ov2019-c90", new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2019" },
                    { 20, 86, "Описание ov2020-c86", new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2020" },
                    { 21, 70, "Описание ov2021-c70", new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2021" },
                    { 22, 43, "Описание ov2022-c43", new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2022" },
                    { 23, 43, "Описание ov2023-c43", new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2023" },
                    { 24, 48, "Описание ov2024-c48", new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2024" },
                    { 25, 88, "Описание ov2025-c88", new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2025" },
                    { 26, 26, "Описание ov2026-c26", new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2026" },
                    { 27, 42, "Описание ov2027-c42", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2027" },
                    { 28, 2, "Описание ov2028-c2", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2028" },
                    { 29, 36, "Описание ov2029-c36", new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2029" },
                    { 30, 9, "Описание ov2030-c9", new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2030" },
                    { 31, 38, "Описание ov2031-c38", new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2031" },
                    { 32, 62, "Описание ov2032-c62", new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2032" },
                    { 33, 93, "Описание ov2033-c93", new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2033" },
                    { 34, 24, "Описание ov2034-c24", new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2034" },
                    { 35, 53, "Описание ov2035-c53", new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2035" },
                    { 36, 51, "Описание ov2036-c51", new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2036" },
                    { 37, 29, "Описание ov2037-c29", new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2037" },
                    { 38, 89, "Описание ov2038-c89", new DateTime(2020, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2038" },
                    { 39, 60, "Описание ov2039-c60", new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2039" },
                    { 40, 15, "Описание ov2040-c15", new DateTime(2020, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2040" },
                    { 41, 85, "Описание ov2041-c85", new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2041" },
                    { 42, 35, "Описание ov2042-c35", new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2042" }
                });

            migrationBuilder.InsertData(
                table: "OrderCustomers",
                columns: new[] { "OrderCustomerId", "CustomerId", "Description", "Edited", "ExcelFileId", "Name" },
                values: new object[,]
                {
                    { 43, 53, "Описание ov2043-c53", new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2043" },
                    { 44, 3, "Описание ov2044-c3", new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2044" },
                    { 45, 45, "Описание ov2045-c45", new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2045" },
                    { 46, 45, "Описание ov2046-c45", new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2046" },
                    { 47, 70, "Описание ov2047-c70", new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2047" },
                    { 48, 99, "Описание ov2048-c99", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2048" },
                    { 49, 18, "Описание ov2049-c18", new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2049" },
                    { 50, 9, "Описание ov2050-c9", new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2050" },
                    { 51, 76, "Описание ov2051-c76", new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2051" },
                    { 52, 73, "Описание ov2052-c73", new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2052" },
                    { 53, 33, "Описание ov2053-c33", new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2053" },
                    { 54, 99, "Описание ov2054-c99", new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2054" },
                    { 55, 2, "Описание ov2055-c2", new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2055" },
                    { 56, 37, "Описание ov2056-c37", new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2056" },
                    { 57, 59, "Описание ov2057-c59", new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2057" },
                    { 58, 11, "Описание ov2058-c11", new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2058" },
                    { 59, 97, "Описание ov2059-c97", new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2059" },
                    { 60, 52, "Описание ov2060-c52", new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2060" },
                    { 61, 71, "Описание ov2061-c71", new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2061" },
                    { 62, 38, "Описание ov2062-c38", new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2062" },
                    { 63, 59, "Описание ov2063-c59", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2063" },
                    { 64, 58, "Описание ov2064-c58", new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2064" },
                    { 65, 72, "Описание ov2065-c72", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2065" },
                    { 66, 60, "Описание ov2066-c60", new DateTime(2020, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2066" },
                    { 67, 2, "Описание ov2067-c2", new DateTime(2020, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2067" },
                    { 68, 21, "Описание ov2068-c21", new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2068" },
                    { 69, 50, "Описание ov2069-c50", new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2069" },
                    { 70, 69, "Описание ov2070-c69", new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2070" },
                    { 71, 99, "Описание ov2071-c99", new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2071" },
                    { 72, 79, "Описание ov2072-c79", new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2072" },
                    { 73, 41, "Описание ov2073-c41", new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2073" },
                    { 74, 73, "Описание ov2074-c73", new DateTime(2020, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2074" },
                    { 75, 82, "Описание ov2075-c82", new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2075" },
                    { 76, 38, "Описание ov2076-c38", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2076" },
                    { 77, 6, "Описание ov2077-c6", new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2077" },
                    { 78, 31, "Описание ov2078-c31", new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2078" },
                    { 79, 63, "Описание ov2079-c63", new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2079" },
                    { 80, 46, "Описание ov2080-c46", new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2080" },
                    { 81, 49, "Описание ov2081-c49", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2081" },
                    { 82, 58, "Описание ov2082-c58", new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2082" },
                    { 83, 81, "Описание ov2083-c81", new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2083" },
                    { 84, 62, "Описание ov2084-c62", new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2084" }
                });

            migrationBuilder.InsertData(
                table: "OrderCustomers",
                columns: new[] { "OrderCustomerId", "CustomerId", "Description", "Edited", "ExcelFileId", "Name" },
                values: new object[,]
                {
                    { 85, 99, "Описание ov2085-c99", new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2085" },
                    { 86, 18, "Описание ov2086-c18", new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2086" },
                    { 87, 48, "Описание ov2087-c48", new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2087" },
                    { 88, 24, "Описание ov2088-c24", new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2088" },
                    { 89, 7, "Описание ov2089-c7", new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2089" },
                    { 90, 63, "Описание ov2090-c63", new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2090" },
                    { 91, 81, "Описание ov2091-c81", new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2091" },
                    { 92, 65, "Описание ov2092-c65", new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2092" },
                    { 93, 92, "Описание ov2093-c92", new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2093" },
                    { 94, 52, "Описание ov2094-c52", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2094" },
                    { 95, 96, "Описание ov2095-c96", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2095" },
                    { 96, 78, "Описание ov2096-c78", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2096" },
                    { 97, 42, "Описание ov2097-c42", new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2097" },
                    { 98, 32, "Описание ov2098-c32", new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2098" },
                    { 99, 67, "Описание ov2099-c67", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2099" }
                });

            migrationBuilder.InsertData(
                table: "OrderVendors",
                columns: new[] { "OrderVendorId", "Description", "Edited", "Name", "VendorId" },
                values: new object[,]
                {
                    { 1, "Описание ov401", new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845), "OrderVendor-401", 1 },
                    { 2, "Описание 402-80", new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 402", 80 },
                    { 3, "Описание 403-8", new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 403", 8 },
                    { 4, "Описание 404-29", new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 404", 29 },
                    { 5, "Описание 405-39", new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 405", 39 },
                    { 6, "Описание 406-9", new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 406", 9 },
                    { 7, "Описание 407-38", new DateTime(2020, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 407", 38 },
                    { 8, "Описание 408-81", new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 408", 81 },
                    { 9, "Описание 409-45", new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 409", 45 },
                    { 10, "Описание 4010-91", new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4010", 91 },
                    { 11, "Описание 4011-14", new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4011", 14 },
                    { 12, "Описание 4012-12", new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4012", 12 },
                    { 13, "Описание 4013-14", new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4013", 14 },
                    { 14, "Описание 4014-71", new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4014", 71 },
                    { 15, "Описание 4015-42", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4015", 42 },
                    { 16, "Описание 4016-70", new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4016", 70 },
                    { 17, "Описание 4017-16", new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4017", 16 },
                    { 18, "Описание 4018-82", new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4018", 82 },
                    { 19, "Описание 4019-17", new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4019", 17 },
                    { 20, "Описание 4020-51", new DateTime(2020, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4020", 51 },
                    { 21, "Описание 4021-11", new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4021", 11 },
                    { 22, "Описание 4022-9", new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4022", 9 },
                    { 23, "Описание 4023-4", new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4023", 4 },
                    { 24, "Описание 4024-87", new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4024", 87 },
                    { 25, "Описание 4025-61", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4025", 61 },
                    { 26, "Описание 4026-7", new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4026", 7 },
                    { 27, "Описание 4027-57", new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4027", 57 }
                });

            migrationBuilder.InsertData(
                table: "OrderVendors",
                columns: new[] { "OrderVendorId", "Description", "Edited", "Name", "VendorId" },
                values: new object[,]
                {
                    { 28, "Описание 4028-59", new DateTime(2020, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4028", 59 },
                    { 29, "Описание 4029-55", new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4029", 55 },
                    { 30, "Описание 4030-22", new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4030", 22 },
                    { 31, "Описание 4031-6", new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4031", 6 },
                    { 32, "Описание 4032-98", new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4032", 98 },
                    { 33, "Описание 4033-45", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4033", 45 },
                    { 34, "Описание 4034-90", new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4034", 90 },
                    { 35, "Описание 4035-29", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4035", 29 },
                    { 36, "Описание 4036-67", new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4036", 67 },
                    { 37, "Описание 4037-85", new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4037", 85 },
                    { 38, "Описание 4038-93", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4038", 93 },
                    { 39, "Описание 4039-26", new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4039", 26 },
                    { 40, "Описание 4040-52", new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4040", 52 },
                    { 41, "Описание 4041-32", new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4041", 32 },
                    { 42, "Описание 4042-65", new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4042", 65 },
                    { 43, "Описание 4043-84", new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4043", 84 },
                    { 44, "Описание 4044-59", new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4044", 59 },
                    { 45, "Описание 4045-62", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4045", 62 },
                    { 46, "Описание 4046-73", new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4046", 73 },
                    { 47, "Описание 4047-1", new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4047", 1 },
                    { 48, "Описание 4048-90", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4048", 90 },
                    { 49, "Описание 4049-61", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4049", 61 },
                    { 50, "Описание 4050-78", new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4050", 78 },
                    { 51, "Описание 4051-41", new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4051", 41 },
                    { 52, "Описание 4052-22", new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4052", 22 },
                    { 53, "Описание 4053-71", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4053", 71 },
                    { 54, "Описание 4054-51", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4054", 51 },
                    { 55, "Описание 4055-71", new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4055", 71 },
                    { 56, "Описание 4056-87", new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4056", 87 },
                    { 57, "Описание 4057-35", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4057", 35 },
                    { 58, "Описание 4058-39", new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4058", 39 },
                    { 59, "Описание 4059-8", new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4059", 8 },
                    { 60, "Описание 4060-33", new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4060", 33 },
                    { 61, "Описание 4061-7", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4061", 7 },
                    { 62, "Описание 4062-33", new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4062", 33 },
                    { 63, "Описание 4063-17", new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4063", 17 },
                    { 64, "Описание 4064-62", new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4064", 62 },
                    { 65, "Описание 4065-67", new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4065", 67 },
                    { 66, "Описание 4066-45", new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4066", 45 },
                    { 67, "Описание 4067-85", new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4067", 85 },
                    { 68, "Описание 4068-49", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4068", 49 },
                    { 69, "Описание 4069-94", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4069", 94 }
                });

            migrationBuilder.InsertData(
                table: "OrderVendors",
                columns: new[] { "OrderVendorId", "Description", "Edited", "Name", "VendorId" },
                values: new object[,]
                {
                    { 70, "Описание 4070-8", new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4070", 8 },
                    { 71, "Описание 4071-77", new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4071", 77 },
                    { 72, "Описание 4072-11", new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4072", 11 },
                    { 73, "Описание 4073-70", new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4073", 70 },
                    { 74, "Описание 4074-15", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4074", 15 },
                    { 75, "Описание 4075-64", new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4075", 64 },
                    { 76, "Описание 4076-2", new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4076", 2 },
                    { 77, "Описание 4077-12", new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4077", 12 },
                    { 78, "Описание 4078-85", new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4078", 85 },
                    { 79, "Описание 4079-74", new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4079", 74 },
                    { 80, "Описание 4080-87", new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4080", 87 },
                    { 81, "Описание 4081-64", new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4081", 64 },
                    { 82, "Описание 4082-39", new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4082", 39 },
                    { 83, "Описание 4083-75", new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4083", 75 },
                    { 84, "Описание 4084-74", new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4084", 74 },
                    { 85, "Описание 4085-62", new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4085", 62 },
                    { 86, "Описание 4086-60", new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4086", 60 },
                    { 87, "Описание 4087-70", new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4087", 70 },
                    { 88, "Описание 4088-63", new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4088", 63 },
                    { 89, "Описание 4089-49", new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4089", 49 },
                    { 90, "Описание 4090-26", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4090", 26 },
                    { 91, "Описание 4091-5", new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4091", 5 },
                    { 92, "Описание 4092-49", new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4092", 49 },
                    { 93, "Описание 4093-76", new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4093", 76 },
                    { 94, "Описание 4094-74", new DateTime(2020, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4094", 74 },
                    { 95, "Описание 4095-69", new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4095", 69 },
                    { 96, "Описание 4096-40", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4096", 40 },
                    { 97, "Описание 4097-70", new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4097", 70 },
                    { 98, "Описание 4098-84", new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4098", 84 },
                    { 99, "Описание 4099-3", new DateTime(2020, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4099", 3 }
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
                    { 12, " 8.6", 1, "C15", null, "SofLens 59 6 pk", 1.0, 1, "-3.25" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
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
                    { 30, " 8.6", 1, "E5", null, "SofLens 59 6 pk", 1.0, 1, "+0.75" },
                    { 31, " 8.6", 1, "E6", null, "SofLens 59 6 pk", 1.0, 1, "+1.00" },
                    { 32, " 8.6", 1, "E7", null, "SofLens 59 6 pk", 1.0, 1, "+1.25" },
                    { 33, " 8.6", 1, "E8", null, "SofLens 59 6 pk", 1.0, 1, "+1.50" },
                    { 34, " 8.6", 1, "E9", null, "SofLens 59 6 pk", 1.0, 1, "+1.75" },
                    { 35, " 8.6", 1, "E10", null, "SofLens 59 6 pk", 1.0, 1, "+2.00" },
                    { 36, " 8.6", 1, "E11", null, "SofLens 59 6 pk", 1.0, 1, "+2.25" },
                    { 37, " 8.6", 1, "E12", null, "SofLens 59 6 pk", 1.0, 1, "+2.50" },
                    { 38, " 8.6", 1, "E13", null, "SofLens 59 6 pk", 1.0, 1, "+2.75" },
                    { 39, " 8.6", 1, "E14", null, "SofLens 59 6 pk", 1.0, 1, "+3.00" },
                    { 40, " 8.6", 1, "E15", null, "SofLens 59 6 pk", 1.0, 1, "+3.25" },
                    { 41, " 8.6", 1, "E16", null, "SofLens 59 6 pk", 1.0, 1, "+3.50" },
                    { 42, " 8.6", 1, "E17", null, "SofLens 59 6 pk", 1.0, 1, "+3.75" },
                    { 43, " 8.6", 1, "E18", null, "SofLens 59 6 pk", 1.0, 1, "+4.00" },
                    { 44, " 8.6", 1, "E19", null, "SofLens 59 6 pk", 1.0, 1, "+4.25" },
                    { 45, " 8.6", 1, "E20", null, "SofLens 59 6 pk", 1.0, 1, "+4.50" },
                    { 46, " 8.6", 1, "E21", null, "SofLens 59 6 pk", 1.0, 1, "+4.75" },
                    { 47, " 8.6", 1, "E22", null, "SofLens 59 6 pk", 1.0, 1, "+5.00" },
                    { 48, " 8.6", 1, "E23", null, "SofLens 59 6 pk", 1.0, 1, "+5.25" },
                    { 49, " 8.6", 1, "E24", null, "SofLens 59 6 pk", 1.0, 1, "+5.50" },
                    { 50, " 8.6", 1, "E25", null, "SofLens 59 6 pk", 1.0, 1, "+5.75" },
                    { 51, " 8.6", 1, "E26", null, "SofLens 59 6 pk", 1.0, 1, "+6.00" },
                    { 52, " 8.6", 1, "H5", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-0.75" },
                    { 53, " 8.6", 1, "H6", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-1.00" },
                    { 54, " 8.6", 1, "H7", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-1.25" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 55, " 8.6", 1, "H8", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-1.50" },
                    { 56, " 8.6", 1, "H9", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-1.75" },
                    { 57, " 8.6", 1, "H10", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-2.00" },
                    { 58, " 8.6", 1, "H11", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-2.25" },
                    { 59, " 8.6", 1, "H12", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-2.50" },
                    { 60, " 8.6", 1, "H13", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-2.75" },
                    { 61, " 8.6", 1, "H14", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-3.00" },
                    { 62, " 8.6", 1, "H15", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-3.25" },
                    { 63, " 8.6", 1, "H16", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-3.50" },
                    { 64, " 8.6", 1, "H17", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-3.75" },
                    { 65, " 8.6", 1, "H18", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-4.00" },
                    { 66, " 8.6", 1, "H19", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-4.25" },
                    { 67, " 8.6", 1, "H20", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-4.50" },
                    { 68, " 8.6", 1, "H21", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-4.75" },
                    { 69, " 8.6", 1, "H22", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-5.00" },
                    { 70, " 8.6", 1, "H23", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-5.25" },
                    { 71, " 8.6", 1, "H24", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-5.50" },
                    { 72, " 8.6", 1, "H25", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-5.75" },
                    { 73, " 8.6", 1, "H26", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-6.00" },
                    { 74, " 8.6", 1, "H27", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-6.50" },
                    { 75, " 8.6", 1, "H28", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-7.00" },
                    { 76, " 8.6", 1, "H29", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-7.50" },
                    { 77, " 8.6", 1, "H30", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-8.00" },
                    { 78, " 8.6", 1, "H31", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-8.50" },
                    { 79, " 8.6", 1, "H32", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "-9.00" },
                    { 80, " 8.6", 1, "J5", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+0.75" },
                    { 81, " 8.6", 1, "J6", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+1.00" },
                    { 82, " 8.6", 1, "J7", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+1.25" },
                    { 83, " 8.6", 1, "J8", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+1.50" },
                    { 84, " 8.6", 1, "J9", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+1.75" },
                    { 85, " 8.6", 1, "J10", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+2.00" },
                    { 86, " 8.6", 1, "J11", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+2.25" },
                    { 87, " 8.6", 1, "J12", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+2.50" },
                    { 88, " 8.6", 1, "J13", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+2.75" },
                    { 89, " 8.6", 1, "J14", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+3.00" },
                    { 90, " 8.6", 1, "J15", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+3.25" },
                    { 91, " 8.6", 1, "J16", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+3.50" },
                    { 92, " 8.6", 1, "J17", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+3.75" },
                    { 93, " 8.6", 1, "J18", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+4.00" },
                    { 94, " 8.6", 1, "J19", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+4.25" },
                    { 95, " 8.6", 1, "J20", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+4.50" },
                    { 96, " 8.6", 1, "J21", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+4.75" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 97, " 8.6", 1, "J22", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+5.00" },
                    { 98, " 8.6", 1, "J23", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+5.25" },
                    { 99, " 8.6", 1, "J24", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+5.50" },
                    { 100, " 8.6", 1, "J25", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+5.75" },
                    { 101, " 8.6", 1, "J26", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+6.00" },
                    { 102, " 8.6", 1, "J27", null, " SofLens Daily Disposable 30 pk", 1.0, 1, "+6.50" },
                    { 103, " 8.6", 1, "m5", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-0.75" },
                    { 104, " 8.6", 1, "m6", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-1.00" },
                    { 105, " 8.6", 1, "m7", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-1.25" },
                    { 106, " 8.6", 1, "m8", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-1.50" },
                    { 107, " 8.6", 1, "m9", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-1.75" },
                    { 108, " 8.6", 1, "m10", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-2.00" },
                    { 109, " 8.6", 1, "m11", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-2.25" },
                    { 110, " 8.6", 1, "m12", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-2.50" },
                    { 111, " 8.6", 1, "m13", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-2.75" },
                    { 112, " 8.6", 1, "m14", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-3.00" },
                    { 113, " 8.6", 1, "m15", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-3.25" },
                    { 114, " 8.6", 1, "m16", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-3.50" },
                    { 115, " 8.6", 1, "m17", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-3.75" },
                    { 116, " 8.6", 1, "m18", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-4.00" },
                    { 117, " 8.6", 1, "m19", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-4.25" },
                    { 118, " 8.6", 1, "m20", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-4.50" },
                    { 119, " 8.6", 1, "m21", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-4.75" },
                    { 120, " 8.6", 1, "m22", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-5.00" },
                    { 121, " 8.6", 1, "m23", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-5.25" },
                    { 122, " 8.6", 1, "m24", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-5.50" },
                    { 123, " 8.6", 1, "m25", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-5.75" },
                    { 124, " 8.6", 1, "m26", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-6.00" },
                    { 125, " 8.6", 1, "m27", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-6.50" },
                    { 126, " 8.6", 1, "m28", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-7.00" },
                    { 127, " 8.6", 1, "m29", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-7.50" },
                    { 128, " 8.6", 1, "m30", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-8.00" },
                    { 129, " 8.6", 1, "m31", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-8.50" },
                    { 130, " 8.6", 1, "m32", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-9.00" },
                    { 131, " 8.6", 1, "o5", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+0.75" },
                    { 132, " 8.6", 1, "o6", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+1.00" },
                    { 133, " 8.6", 1, "o7", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+1.25" },
                    { 134, " 8.6", 1, "o8", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+1.50" },
                    { 135, " 8.6", 1, "o9", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+1.75" },
                    { 136, " 8.6", 1, "o10", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+2.00" },
                    { 137, " 8.6", 1, "o11", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+2.25" },
                    { 138, " 8.6", 1, "o12", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+2.50" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 139, " 8.6", 1, "o13", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+2.75" },
                    { 140, " 8.6", 1, "o14", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+3.00" },
                    { 141, " 8.6", 1, "o15", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+3.25" },
                    { 142, " 8.6", 1, "o16", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+3.50" },
                    { 143, " 8.6", 1, "o17", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+3.75" },
                    { 144, " 8.6", 1, "o18", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+4.00" },
                    { 145, " 8.6", 1, "o19", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+4.25" },
                    { 146, " 8.6", 1, "o20", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+4.50" },
                    { 147, " 8.6", 1, "o21", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+4.75" },
                    { 148, " 8.6", 1, "o22", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+5.00" },
                    { 149, " 8.6", 1, "o23", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+5.25" },
                    { 150, " 8.6", 1, "o24", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+5.50" },
                    { 151, " 8.6", 1, "o25", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+5.75" },
                    { 152, " 8.6", 1, "o26", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+6.00" },
                    { 153, " 8.6", 1, "o27", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+6.50" },
                    { 154, " 8.4", 1, "r5", null, "Optima FW 4 pk", 1.0, 1, "-0.75" },
                    { 155, " 8.4", 1, "r6", null, "Optima FW 4 pk", 1.0, 1, "-1.00" },
                    { 156, " 8.4", 1, "r7", null, "Optima FW 4 pk", 1.0, 1, "-1.25" },
                    { 157, " 8.4", 1, "r8", null, "Optima FW 4 pk", 1.0, 1, "-1.50" },
                    { 158, " 8.4", 1, "r9", null, "Optima FW 4 pk", 1.0, 1, "-1.75" },
                    { 159, " 8.4", 1, "r10", null, "Optima FW 4 pk", 1.0, 1, "-2.00" },
                    { 160, " 8.4", 1, "r11", null, "Optima FW 4 pk", 1.0, 1, "-2.25" },
                    { 161, " 8.4", 1, "r12", null, "Optima FW 4 pk", 1.0, 1, "-2.50" },
                    { 162, " 8.4", 1, "r13", null, "Optima FW 4 pk", 1.0, 1, "-2.75" },
                    { 163, " 8.4", 1, "r14", null, "Optima FW 4 pk", 1.0, 1, "-3.00" },
                    { 164, " 8.4", 1, "r15", null, "Optima FW 4 pk", 1.0, 1, "-3.25" },
                    { 165, " 8.4", 1, "r16", null, "Optima FW 4 pk", 1.0, 1, "-3.50" },
                    { 166, " 8.4", 1, "r17", null, "Optima FW 4 pk", 1.0, 1, "-3.75" },
                    { 167, " 8.4", 1, "r18", null, "Optima FW 4 pk", 1.0, 1, "-4.00" },
                    { 168, " 8.4", 1, "r19", null, "Optima FW 4 pk", 1.0, 1, "-4.25" },
                    { 169, " 8.4", 1, "r20", null, "Optima FW 4 pk", 1.0, 1, "-4.50" },
                    { 170, " 8.4", 1, "r21", null, "Optima FW 4 pk", 1.0, 1, "-4.75" },
                    { 171, " 8.4", 1, "r22", null, "Optima FW 4 pk", 1.0, 1, "-5.00" },
                    { 172, " 8.4", 1, "r23", null, "Optima FW 4 pk", 1.0, 1, "-5.25" },
                    { 173, " 8.4", 1, "r24", null, "Optima FW 4 pk", 1.0, 1, "-5.50" },
                    { 174, " 8.4", 1, "r25", null, "Optima FW 4 pk", 1.0, 1, "-5.75" },
                    { 175, " 8.4", 1, "r26", null, "Optima FW 4 pk", 1.0, 1, "-6.00" },
                    { 176, " 8.4", 1, "r27", null, "Optima FW 4 pk", 1.0, 1, "-6.50" },
                    { 177, " 8.4", 1, "r28", null, "Optima FW 4 pk", 1.0, 1, "-7.00" },
                    { 178, " 8.4", 1, "r29", null, "Optima FW 4 pk", 1.0, 1, "-7.50" },
                    { 179, " 8.4", 1, "r30", null, "Optima FW 4 pk", 1.0, 1, "-8.00" },
                    { 180, " 8.4", 1, "r31", null, "Optima FW 4 pk", 1.0, 1, "-8.50" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 181, " 8.4", 1, "r32", null, "Optima FW 4 pk", 1.0, 1, "-9.00" },
                    { 182, " 8.7", 1, "s5", null, "Optima FW 4 pk", 1.0, 1, "-0.75" },
                    { 183, " 8.7", 1, "s6", null, "Optima FW 4 pk", 1.0, 1, "-1.00" },
                    { 184, " 8.7", 1, "s7", null, "Optima FW 4 pk", 1.0, 1, "-1.25" },
                    { 185, " 8.7", 1, "s8", null, "Optima FW 4 pk", 1.0, 1, "-1.50" },
                    { 186, " 8.7", 1, "s9", null, "Optima FW 4 pk", 1.0, 1, "-1.75" },
                    { 187, " 8.7", 1, "s10", null, "Optima FW 4 pk", 1.0, 1, "-2.00" },
                    { 188, " 8.7", 1, "s11", null, "Optima FW 4 pk", 1.0, 1, "-2.25" },
                    { 189, " 8.7", 1, "s12", null, "Optima FW 4 pk", 1.0, 1, "-2.50" },
                    { 190, " 8.7", 1, "s13", null, "Optima FW 4 pk", 1.0, 1, "-2.75" },
                    { 191, " 8.7", 1, "s14", null, "Optima FW 4 pk", 1.0, 1, "-3.00" },
                    { 192, " 8.7", 1, "s15", null, "Optima FW 4 pk", 1.0, 1, "-3.25" },
                    { 193, " 8.7", 1, "s16", null, "Optima FW 4 pk", 1.0, 1, "-3.50" },
                    { 194, " 8.7", 1, "s17", null, "Optima FW 4 pk", 1.0, 1, "-3.75" },
                    { 195, " 8.7", 1, "s18", null, "Optima FW 4 pk", 1.0, 1, "-4.00" },
                    { 196, " 8.7", 1, "s19", null, "Optima FW 4 pk", 1.0, 1, "-4.25" },
                    { 197, " 8.7", 1, "s20", null, "Optima FW 4 pk", 1.0, 1, "-4.50" },
                    { 198, " 8.7", 1, "s21", null, "Optima FW 4 pk", 1.0, 1, "-4.75" },
                    { 199, " 8.7", 1, "s22", null, "Optima FW 4 pk", 1.0, 1, "-5.00" },
                    { 200, " 8.7", 1, "s23", null, "Optima FW 4 pk", 1.0, 1, "-5.25" },
                    { 201, " 8.7", 1, "s24", null, "Optima FW 4 pk", 1.0, 1, "-5.50" },
                    { 202, " 8.7", 1, "s25", null, "Optima FW 4 pk", 1.0, 1, "-5.75" },
                    { 203, " 8.7", 1, "s26", null, "Optima FW 4 pk", 1.0, 1, "-6.00" },
                    { 204, " 8.7", 1, "s27", null, "Optima FW 4 pk", 1.0, 1, "-6.50" },
                    { 205, " 8.7", 1, "s28", null, "Optima FW 4 pk", 1.0, 1, "-7.00" },
                    { 206, " 8.7", 1, "s29", null, "Optima FW 4 pk", 1.0, 1, "-7.50" },
                    { 207, " 8.7", 1, "s30", null, "Optima FW 4 pk", 1.0, 1, "-8.00" },
                    { 208, " 8.7", 1, "s31", null, "Optima FW 4 pk", 1.0, 1, "-8.50" },
                    { 209, " 8.7", 1, "s32", null, "Optima FW 4 pk", 1.0, 1, "-9.00" },
                    { 210, "9.0", 1, "t5", null, "Optima FW 4 pk", 1.0, 1, "-0.75" },
                    { 211, "9.0", 1, "t6", null, "Optima FW 4 pk", 1.0, 1, "-1.00" },
                    { 212, "9.0", 1, "t7", null, "Optima FW 4 pk", 1.0, 1, "-1.25" },
                    { 213, "9.0", 1, "t8", null, "Optima FW 4 pk", 1.0, 1, "-1.50" },
                    { 214, "9.0", 1, "t9", null, "Optima FW 4 pk", 1.0, 1, "-1.75" },
                    { 215, "9.0", 1, "t10", null, "Optima FW 4 pk", 1.0, 1, "-2.00" },
                    { 216, "9.0", 1, "t11", null, "Optima FW 4 pk", 1.0, 1, "-2.25" },
                    { 217, "9.0", 1, "t12", null, "Optima FW 4 pk", 1.0, 1, "-2.50" },
                    { 218, "9.0", 1, "t13", null, "Optima FW 4 pk", 1.0, 1, "-2.75" },
                    { 219, "9.0", 1, "t14", null, "Optima FW 4 pk", 1.0, 1, "-3.00" },
                    { 220, "9.0", 1, "t15", null, "Optima FW 4 pk", 1.0, 1, "-3.25" },
                    { 221, "9.0", 1, "t16", null, "Optima FW 4 pk", 1.0, 1, "-3.50" },
                    { 222, "9.0", 1, "t17", null, "Optima FW 4 pk", 1.0, 1, "-3.75" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 223, "9.0", 1, "t18", null, "Optima FW 4 pk", 1.0, 1, "-4.00" },
                    { 224, "9.0", 1, "t19", null, "Optima FW 4 pk", 1.0, 1, "-4.25" },
                    { 225, "9.0", 1, "t20", null, "Optima FW 4 pk", 1.0, 1, "-4.50" },
                    { 226, "9.0", 1, "t21", null, "Optima FW 4 pk", 1.0, 1, "-4.75" },
                    { 227, "9.0", 1, "t22", null, "Optima FW 4 pk", 1.0, 1, "-5.00" },
                    { 228, "9.0", 1, "t23", null, "Optima FW 4 pk", 1.0, 1, "-5.25" },
                    { 229, "9.0", 1, "t24", null, "Optima FW 4 pk", 1.0, 1, "-5.50" },
                    { 230, "9.0", 1, "t25", null, "Optima FW 4 pk", 1.0, 1, "-5.75" },
                    { 231, "9.0", 1, "t26", null, "Optima FW 4 pk", 1.0, 1, "-6.00" },
                    { 232, "9.0", 1, "t27", null, "Optima FW 4 pk", 1.0, 1, "-6.50" },
                    { 233, "9.0", 1, "t28", null, "Optima FW 4 pk", 1.0, 1, "-7.00" },
                    { 234, "9.0", 1, "t29", null, "Optima FW 4 pk", 1.0, 1, "-7.50" },
                    { 235, "9.0", 1, "t30", null, "Optima FW 4 pk", 1.0, 1, "-8.00" },
                    { 236, "9.0", 1, "t31", null, "Optima FW 4 pk", 1.0, 1, "-8.50" },
                    { 237, "9.0", 1, "t32", null, "Optima FW 4 pk", 1.0, 1, "-9.00" },
                    { 238, " 8.6", 1, "x5", null, "Pure Vision2 6pk", 1.0, 1, "-0.50" },
                    { 239, " 8.6", 1, "x6", null, "Pure Vision2 6pk", 1.0, 1, "-0.75" },
                    { 240, " 8.6", 1, "x7", null, "Pure Vision2 6pk", 1.0, 1, "-1.00" },
                    { 241, " 8.6", 1, "x8", null, "Pure Vision2 6pk", 1.0, 1, "-1.25" },
                    { 242, " 8.6", 1, "x9", null, "Pure Vision2 6pk", 1.0, 1, "-1.50" },
                    { 243, " 8.6", 1, "x10", null, "Pure Vision2 6pk", 1.0, 1, "-1.75" },
                    { 244, " 8.6", 1, "x11", null, "Pure Vision2 6pk", 1.0, 1, "-2.00" },
                    { 245, " 8.6", 1, "x12", null, "Pure Vision2 6pk", 1.0, 1, "-2.25" },
                    { 246, " 8.6", 1, "x13", null, "Pure Vision2 6pk", 1.0, 1, "-2.50" },
                    { 247, " 8.6", 1, "x14", null, "Pure Vision2 6pk", 1.0, 1, "-2.75" },
                    { 248, " 8.6", 1, "x15", null, "Pure Vision2 6pk", 1.0, 1, "-3.00" },
                    { 249, " 8.6", 1, "x16", null, "Pure Vision2 6pk", 1.0, 1, "-3.25" },
                    { 250, " 8.6", 1, "x17", null, "Pure Vision2 6pk", 1.0, 1, "-3.50" },
                    { 251, " 8.6", 1, "x18", null, "Pure Vision2 6pk", 1.0, 1, "-3.75" },
                    { 252, " 8.6", 1, "x19", null, "Pure Vision2 6pk", 1.0, 1, "-4.00" },
                    { 253, " 8.6", 1, "x20", null, "Pure Vision2 6pk", 1.0, 1, "-4.25" },
                    { 254, " 8.6", 1, "x21", null, "Pure Vision2 6pk", 1.0, 1, "-4.50" },
                    { 255, " 8.6", 1, "x22", null, "Pure Vision2 6pk", 1.0, 1, "-4.75" },
                    { 256, " 8.6", 1, "x23", null, "Pure Vision2 6pk", 1.0, 1, "-5.00" },
                    { 257, " 8.6", 1, "x24", null, "Pure Vision2 6pk", 1.0, 1, "-5.25" },
                    { 258, " 8.6", 1, "x25", null, "Pure Vision2 6pk", 1.0, 1, "-5.50" },
                    { 259, " 8.6", 1, "x26", null, "Pure Vision2 6pk", 1.0, 1, "-5.75" },
                    { 260, " 8.6", 1, "x27", null, "Pure Vision2 6pk", 1.0, 1, "-6.00" },
                    { 261, " 8.6", 1, "x28", null, "Pure Vision2 6pk", 1.0, 1, "-6.50" },
                    { 262, " 8.6", 1, "x29", null, "Pure Vision2 6pk", 1.0, 1, "-7.00" },
                    { 263, " 8.6", 1, "x30", null, "Pure Vision2 6pk", 1.0, 1, "-7.50" },
                    { 264, " 8.6", 1, "x31", null, "Pure Vision2 6pk", 1.0, 1, "-8.00" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 265, " 8.6", 1, "x32", null, "Pure Vision2 6pk", 1.0, 1, "-8.50" },
                    { 266, " 8.6", 1, "x33", null, "Pure Vision2 6pk", 1.0, 1, "-9.00" },
                    { 267, " 8.6", 1, "x34", null, "Pure Vision2 6pk", 1.0, 1, "-9.50" },
                    { 268, " 8.6", 1, "x35", null, "Pure Vision2 6pk", 1.0, 1, "-10.00" },
                    { 269, " 8.6", 1, "x36", null, "Pure Vision2 6pk", 1.0, 1, "-10.50" },
                    { 270, " 8.6", 1, "x37", null, "Pure Vision2 6pk", 1.0, 1, "-11.00" },
                    { 271, " 8.6", 1, "x38", null, "Pure Vision2 6pk", 1.0, 1, "-11.50" },
                    { 272, " 8.6", 1, "x39", null, "Pure Vision2 6pk", 1.0, 1, "-12.00" },
                    { 273, " 8.6", 1, "z5", null, "Pure Vision2 6pk", 1.0, 1, "+0.50" },
                    { 274, " 8.6", 1, "z6", null, "Pure Vision2 6pk", 1.0, 1, "+0.75" },
                    { 275, " 8.6", 1, "z7", null, "Pure Vision2 6pk", 1.0, 1, "+1.00" },
                    { 276, " 8.6", 1, "z8", null, "Pure Vision2 6pk", 1.0, 1, "+1.25" },
                    { 277, " 8.6", 1, "z9", null, "Pure Vision2 6pk", 1.0, 1, "+1.50" },
                    { 278, " 8.6", 1, "z10", null, "Pure Vision2 6pk", 1.0, 1, "+1.75" },
                    { 279, " 8.6", 1, "z11", null, "Pure Vision2 6pk", 1.0, 1, "+2.00" },
                    { 280, " 8.6", 1, "z12", null, "Pure Vision2 6pk", 1.0, 1, "+2.25" },
                    { 281, " 8.6", 1, "z13", null, "Pure Vision2 6pk", 1.0, 1, "+2.50" },
                    { 282, " 8.6", 1, "z14", null, "Pure Vision2 6pk", 1.0, 1, "+2.75" },
                    { 283, " 8.6", 1, "z15", null, "Pure Vision2 6pk", 1.0, 1, "+3.00" },
                    { 284, " 8.6", 1, "z16", null, "Pure Vision2 6pk", 1.0, 1, "+3.25" },
                    { 285, " 8.6", 1, "z17", null, "Pure Vision2 6pk", 1.0, 1, "+3.50" },
                    { 286, " 8.6", 1, "z18", null, "Pure Vision2 6pk", 1.0, 1, "+3.75" },
                    { 287, " 8.6", 1, "z19", null, "Pure Vision2 6pk", 1.0, 1, "+4.00" },
                    { 288, " 8.6", 1, "z20", null, "Pure Vision2 6pk", 1.0, 1, "+4.25" },
                    { 289, " 8.6", 1, "z21", null, "Pure Vision2 6pk", 1.0, 1, "+4.50" },
                    { 290, " 8.6", 1, "z22", null, "Pure Vision2 6pk", 1.0, 1, "+4.75" },
                    { 291, " 8.6", 1, "z23", null, "Pure Vision2 6pk", 1.0, 1, "+5.00" },
                    { 292, " 8.6", 1, "z24", null, "Pure Vision2 6pk", 1.0, 1, "+5.25" },
                    { 293, " 8.6", 1, "z25", null, "Pure Vision2 6pk", 1.0, 1, "+5.50" },
                    { 294, " 8.6", 1, "z26", null, "Pure Vision2 6pk", 1.0, 1, "+5.75" },
                    { 295, " 8.6", 1, "z27", null, "Pure Vision2 6pk", 1.0, 1, "+6.00" },
                    { 296, " 8.6", 1, "ac5", null, "Biotrue ONEDay 30pk", 1.0, 1, "-0.50" },
                    { 297, " 8.6", 1, "ac6", null, "Biotrue ONEDay 30pk", 1.0, 1, "-0.75" },
                    { 298, " 8.6", 1, "ac7", null, "Biotrue ONEDay 30pk", 1.0, 1, "-1.00" },
                    { 299, " 8.6", 1, "ac8", null, "Biotrue ONEDay 30pk", 1.0, 1, "-1.25" },
                    { 300, " 8.6", 1, "ac9", null, "Biotrue ONEDay 30pk", 1.0, 1, "-1.50" },
                    { 301, " 8.6", 1, "ac10", null, "Biotrue ONEDay 30pk", 1.0, 1, "-1.75" },
                    { 302, " 8.6", 1, "ac11", null, "Biotrue ONEDay 30pk", 1.0, 1, "-2.00" },
                    { 303, " 8.6", 1, "ac12", null, "Biotrue ONEDay 30pk", 1.0, 1, "-2.25" },
                    { 304, " 8.6", 1, "ac13", null, "Biotrue ONEDay 30pk", 1.0, 1, "-2.50" },
                    { 305, " 8.6", 1, "ac14", null, "Biotrue ONEDay 30pk", 1.0, 1, "-2.75" },
                    { 306, " 8.6", 1, "ac15", null, "Biotrue ONEDay 30pk", 1.0, 1, "-3.00" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 307, " 8.6", 1, "ac16", null, "Biotrue ONEDay 30pk", 1.0, 1, "-3.25" },
                    { 308, " 8.6", 1, "ac17", null, "Biotrue ONEDay 30pk", 1.0, 1, "-3.50" },
                    { 309, " 8.6", 1, "ac18", null, "Biotrue ONEDay 30pk", 1.0, 1, "-3.75" },
                    { 310, " 8.6", 1, "ac19", null, "Biotrue ONEDay 30pk", 1.0, 1, "-4.00" },
                    { 311, " 8.6", 1, "ac20", null, "Biotrue ONEDay 30pk", 1.0, 1, "-4.25" },
                    { 312, " 8.6", 1, "ac21", null, "Biotrue ONEDay 30pk", 1.0, 1, "-4.50" },
                    { 313, " 8.6", 1, "ac22", null, "Biotrue ONEDay 30pk", 1.0, 1, "-4.75" },
                    { 314, " 8.6", 1, "ac23", null, "Biotrue ONEDay 30pk", 1.0, 1, "-5.00" },
                    { 315, " 8.6", 1, "ac24", null, "Biotrue ONEDay 30pk", 1.0, 1, "-5.25" },
                    { 316, " 8.6", 1, "ac25", null, "Biotrue ONEDay 30pk", 1.0, 1, "-5.50" },
                    { 317, " 8.6", 1, "ac26", null, "Biotrue ONEDay 30pk", 1.0, 1, "-5.75" },
                    { 318, " 8.6", 1, "ac27", null, "Biotrue ONEDay 30pk", 1.0, 1, "-6.00" },
                    { 319, " 8.6", 1, "ac28", null, "Biotrue ONEDay 30pk", 1.0, 1, "-6.25" },
                    { 320, " 8.6", 1, "ac29", null, "Biotrue ONEDay 30pk", 1.0, 1, "-6.50" },
                    { 321, " 8.6", 1, "ac30", null, "Biotrue ONEDay 30pk", 1.0, 1, "-7.00" },
                    { 322, " 8.6", 1, "ac31", null, "Biotrue ONEDay 30pk", 1.0, 1, "-7.50" },
                    { 323, " 8.6", 1, "ac32", null, "Biotrue ONEDay 30pk", 1.0, 1, "-8.00" },
                    { 324, " 8.6", 1, "ac33", null, "Biotrue ONEDay 30pk", 1.0, 1, "-8.50" },
                    { 325, " 8.6", 1, "ac34", null, "Biotrue ONEDay 30pk", 1.0, 1, "-9.00" },
                    { 326, " 8.6", 1, "ae5", null, "Biotrue ONEDay 30pk", 1.0, 1, "+0.50" },
                    { 327, " 8.6", 1, "ae6", null, "Biotrue ONEDay 30pk", 1.0, 1, "+0.75" },
                    { 328, " 8.6", 1, "ae7", null, "Biotrue ONEDay 30pk", 1.0, 1, "+1.00" },
                    { 329, " 8.6", 1, "ae8", null, "Biotrue ONEDay 30pk", 1.0, 1, "+1.25" },
                    { 330, " 8.6", 1, "ae9", null, "Biotrue ONEDay 30pk", 1.0, 1, "+1.50" },
                    { 331, " 8.6", 1, "ae10", null, "Biotrue ONEDay 30pk", 1.0, 1, "+1.75" },
                    { 332, " 8.6", 1, "ae11", null, "Biotrue ONEDay 30pk", 1.0, 1, "+2.00" },
                    { 333, " 8.6", 1, "ae12", null, "Biotrue ONEDay 30pk", 1.0, 1, "+2.25" },
                    { 334, " 8.6", 1, "ae13", null, "Biotrue ONEDay 30pk", 1.0, 1, "+2.50" },
                    { 335, " 8.6", 1, "ae14", null, "Biotrue ONEDay 30pk", 1.0, 1, "+2.75" },
                    { 336, " 8.6", 1, "ae15", null, "Biotrue ONEDay 30pk", 1.0, 1, "+3.00" },
                    { 337, " 8.6", 1, "ae16", null, "Biotrue ONEDay 30pk", 1.0, 1, "+3.25" },
                    { 338, " 8.6", 1, "ae17", null, "Biotrue ONEDay 30pk", 1.0, 1, "+3.50" },
                    { 339, " 8.6", 1, "ae18", null, "Biotrue ONEDay 30pk", 1.0, 1, "+3.75" },
                    { 340, " 8.6", 1, "ae19", null, "Biotrue ONEDay 30pk", 1.0, 1, "+4.00" },
                    { 341, " 8.6", 1, "ae20", null, "Biotrue ONEDay 30pk", 1.0, 1, "+4.25" },
                    { 342, " 8.6", 1, "ae21", null, "Biotrue ONEDay 30pk", 1.0, 1, "+4.50" },
                    { 343, " 8.6", 1, "ae22", null, "Biotrue ONEDay 30pk", 1.0, 1, "+4.75" },
                    { 344, " 8.6", 1, "ae23", null, "Biotrue ONEDay 30pk", 1.0, 1, "+5.00" },
                    { 345, " 8.6", 1, "ae24", null, "Biotrue ONEDay 30pk", 1.0, 1, "+5.25" },
                    { 346, " 8.6", 1, "ae25", null, "Biotrue ONEDay 30pk", 1.0, 1, "+5.50" },
                    { 347, " 8.6", 1, "ae26", null, "Biotrue ONEDay 30pk", 1.0, 1, "+5.75" },
                    { 348, " 8.6", 1, "ae27", null, "Biotrue ONEDay 30pk", 1.0, 1, "+6.00" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 349, " 8.6", 1, "ae28", null, "Biotrue ONEDay 30pk", 1.0, 1, "-6.25" },
                    { 350, " 8.6", 1, "ae29", null, "Biotrue ONEDay 30pk", 1.0, 1, "+6.50" },
                    { 351, " 8.6", 1, "ag5", null, "Biotrue ONEDay 90pk", 1.0, 1, "-0.50" },
                    { 352, " 8.6", 1, "ag6", null, "Biotrue ONEDay 90pk", 1.0, 1, "-0.75" },
                    { 353, " 8.6", 1, "ag7", null, "Biotrue ONEDay 90pk", 1.0, 1, "-1.00" },
                    { 354, " 8.6", 1, "ag8", null, "Biotrue ONEDay 90pk", 1.0, 1, "-1.25" },
                    { 355, " 8.6", 1, "ag9", null, "Biotrue ONEDay 90pk", 1.0, 1, "-1.50" },
                    { 356, " 8.6", 1, "ag10", null, "Biotrue ONEDay 90pk", 1.0, 1, "-1.75" },
                    { 357, " 8.6", 1, "ag11", null, "Biotrue ONEDay 90pk", 1.0, 1, "-2.00" },
                    { 358, " 8.6", 1, "ag12", null, "Biotrue ONEDay 90pk", 1.0, 1, "-2.25" },
                    { 359, " 8.6", 1, "ag13", null, "Biotrue ONEDay 90pk", 1.0, 1, "-2.50" },
                    { 360, " 8.6", 1, "ag14", null, "Biotrue ONEDay 90pk", 1.0, 1, "-2.75" },
                    { 361, " 8.6", 1, "ag15", null, "Biotrue ONEDay 90pk", 1.0, 1, "-3.00" },
                    { 362, " 8.6", 1, "ag16", null, "Biotrue ONEDay 90pk", 1.0, 1, "-3.25" },
                    { 363, " 8.6", 1, "ag17", null, "Biotrue ONEDay 90pk", 1.0, 1, "-3.50" },
                    { 364, " 8.6", 1, "ag18", null, "Biotrue ONEDay 90pk", 1.0, 1, "-3.75" },
                    { 365, " 8.6", 1, "ag19", null, "Biotrue ONEDay 90pk", 1.0, 1, "-4.00" },
                    { 366, " 8.6", 1, "ag20", null, "Biotrue ONEDay 90pk", 1.0, 1, "-4.25" },
                    { 367, " 8.6", 1, "ag21", null, "Biotrue ONEDay 90pk", 1.0, 1, "-4.50" },
                    { 368, " 8.6", 1, "ag22", null, "Biotrue ONEDay 90pk", 1.0, 1, "-4.75" },
                    { 369, " 8.6", 1, "ag23", null, "Biotrue ONEDay 90pk", 1.0, 1, "-5.00" },
                    { 370, " 8.6", 1, "ag24", null, "Biotrue ONEDay 90pk", 1.0, 1, "-5.25" },
                    { 371, " 8.6", 1, "ag25", null, "Biotrue ONEDay 90pk", 1.0, 1, "-5.50" },
                    { 372, " 8.6", 1, "ag26", null, "Biotrue ONEDay 90pk", 1.0, 1, "-5.75" },
                    { 373, " 8.6", 1, "ag27", null, "Biotrue ONEDay 90pk", 1.0, 1, "-6.00" },
                    { 374, " 8.6", 1, "ag28", null, "Biotrue ONEDay 90pk", 1.0, 1, "-6.25" },
                    { 375, " 8.6", 1, "ag29", null, "Biotrue ONEDay 90pk", 1.0, 1, "-6.50" },
                    { 376, " 8.6", 1, "ag30", null, "Biotrue ONEDay 90pk", 1.0, 1, "-7.00" },
                    { 377, " 8.6", 1, "ag31", null, "Biotrue ONEDay 90pk", 1.0, 1, "-7.50" },
                    { 378, " 8.6", 1, "ag32", null, "Biotrue ONEDay 90pk", 1.0, 1, "-8.00" },
                    { 379, " 8.6", 1, "ag33", null, "Biotrue ONEDay 90pk", 1.0, 1, "-8.50" },
                    { 380, " 8.6", 1, "ag34", null, "Biotrue ONEDay 90pk", 1.0, 1, "-9.00" },
                    { 381, " 8.6", 1, "ai5", null, "Biotrue ONEDay 90pk", 1.0, 1, "+0.50" },
                    { 382, " 8.6", 1, "ai6", null, "Biotrue ONEDay 90pk", 1.0, 1, "+0.75" },
                    { 383, " 8.6", 1, "ai7", null, "Biotrue ONEDay 90pk", 1.0, 1, "+1.00" },
                    { 384, " 8.6", 1, "ai8", null, "Biotrue ONEDay 90pk", 1.0, 1, "+1.25" },
                    { 385, " 8.6", 1, "ai9", null, "Biotrue ONEDay 90pk", 1.0, 1, "+1.50" },
                    { 386, " 8.6", 1, "ai10", null, "Biotrue ONEDay 90pk", 1.0, 1, "+1.75" },
                    { 387, " 8.6", 1, "ai11", null, "Biotrue ONEDay 90pk", 1.0, 1, "+2.00" },
                    { 388, " 8.6", 1, "ai12", null, "Biotrue ONEDay 90pk", 1.0, 1, "+2.25" },
                    { 389, " 8.6", 1, "ai13", null, "Biotrue ONEDay 90pk", 1.0, 1, "+2.50" },
                    { 390, " 8.6", 1, "ai14", null, "Biotrue ONEDay 90pk", 1.0, 1, "+2.75" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 391, " 8.6", 1, "ai15", null, "Biotrue ONEDay 90pk", 1.0, 1, "+3.00" },
                    { 392, " 8.6", 1, "ai16", null, "Biotrue ONEDay 90pk", 1.0, 1, "+3.25" },
                    { 393, " 8.6", 1, "ai17", null, "Biotrue ONEDay 90pk", 1.0, 1, "+3.50" },
                    { 394, " 8.6", 1, "ai18", null, "Biotrue ONEDay 90pk", 1.0, 1, "+3.75" },
                    { 395, " 8.6", 1, "ai19", null, "Biotrue ONEDay 90pk", 1.0, 1, "+4.00" },
                    { 396, " 8.6", 1, "ai20", null, "Biotrue ONEDay 90pk", 1.0, 1, "+4.25" },
                    { 397, " 8.6", 1, "ai21", null, "Biotrue ONEDay 90pk", 1.0, 1, "+4.50" },
                    { 398, " 8.6", 1, "ai22", null, "Biotrue ONEDay 90pk", 1.0, 1, "+4.75" },
                    { 399, " 8.6", 1, "ai23", null, "Biotrue ONEDay 90pk", 1.0, 1, "+5.00" },
                    { 400, " 8.6", 1, "ai24", null, "Biotrue ONEDay 90pk", 1.0, 1, "+5.25" },
                    { 401, " 8.6", 1, "ai25", null, "Biotrue ONEDay 90pk", 1.0, 1, "+5.50" },
                    { 402, " 8.6", 1, "ai26", null, "Biotrue ONEDay 90pk", 1.0, 1, "+5.75" },
                    { 403, " 8.6", 1, "ai27", null, "Biotrue ONEDay 90pk", 1.0, 1, "+6.00" },
                    { 404, " 8.6", 1, "ai28", null, "Biotrue ONEDay 90pk", 1.0, 1, "+6.50" },
                    { 405, " 8.6", 1, "ai29", null, "Biotrue ONEDay 90pk", 1.0, 1, "+6.50" },
                    { 406, " 8.5", 1, "al5", null, "ULTRA 3pk", 1.0, 1, "-0.25" },
                    { 407, " 8.5", 1, "al6", null, "ULTRA 3pk", 1.0, 1, "-0.50" },
                    { 408, " 8.5", 1, "al7", null, "ULTRA 3pk", 1.0, 1, "-0.75" },
                    { 409, " 8.5", 1, "al8", null, "ULTRA 3pk", 1.0, 1, "-1.00" },
                    { 410, " 8.5", 1, "al9", null, "ULTRA 3pk", 1.0, 1, "-1.25" },
                    { 411, " 8.5", 1, "al10", null, "ULTRA 3pk", 1.0, 1, "-1.50" },
                    { 412, " 8.5", 1, "al11", null, "ULTRA 3pk", 1.0, 1, "-1.75" },
                    { 413, " 8.5", 1, "al12", null, "ULTRA 3pk", 1.0, 1, "-2.00" },
                    { 414, " 8.5", 1, "al13", null, "ULTRA 3pk", 1.0, 1, "-2.25" },
                    { 415, " 8.5", 1, "al14", null, "ULTRA 3pk", 1.0, 1, "-2.50" },
                    { 416, " 8.5", 1, "al15", null, "ULTRA 3pk", 1.0, 1, "-2.75" },
                    { 417, " 8.5", 1, "al16", null, "ULTRA 3pk", 1.0, 1, "-3.00" },
                    { 418, " 8.5", 1, "al17", null, "ULTRA 3pk", 1.0, 1, "-3.25" },
                    { 419, " 8.5", 1, "al18", null, "ULTRA 3pk", 1.0, 1, "-3.50" },
                    { 420, " 8.5", 1, "al19", null, "ULTRA 3pk", 1.0, 1, "-3.75" },
                    { 421, " 8.5", 1, "al20", null, "ULTRA 3pk", 1.0, 1, "-4.00" },
                    { 422, " 8.5", 1, "al21", null, "ULTRA 3pk", 1.0, 1, "-4.25" },
                    { 423, " 8.5", 1, "al22", null, "ULTRA 3pk", 1.0, 1, "-4.50" },
                    { 424, " 8.5", 1, "al23", null, "ULTRA 3pk", 1.0, 1, "-4.75" },
                    { 425, " 8.5", 1, "al24", null, "ULTRA 3pk", 1.0, 1, "-5.00" },
                    { 426, " 8.5", 1, "al25", null, "ULTRA 3pk", 1.0, 1, "-5.25" },
                    { 427, " 8.5", 1, "al26", null, "ULTRA 3pk", 1.0, 1, "-5.50" },
                    { 428, " 8.5", 1, "al27", null, "ULTRA 3pk", 1.0, 1, "-5.75" },
                    { 429, " 8.5", 1, "al28", null, "ULTRA 3pk", 1.0, 1, "-6.00" },
                    { 430, " 8.5", 1, "al29", null, "ULTRA 3pk", 1.0, 1, "-6.50" },
                    { 431, " 8.5", 1, "al30", null, "ULTRA 3pk", 1.0, 1, "-7.00" },
                    { 432, " 8.5", 1, "al31", null, "ULTRA 3pk", 1.0, 1, "-7.50" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 433, " 8.5", 1, "al32", null, "ULTRA 3pk", 1.0, 1, "-8.00" },
                    { 434, " 8.5", 1, "al33", null, "ULTRA 3pk", 1.0, 1, "-8.50" },
                    { 435, " 8.5", 1, "al34", null, "ULTRA 3pk", 1.0, 1, "-9.00" },
                    { 436, " 8.5", 1, "al35", null, "ULTRA 3pk", 1.0, 1, "-9.50" },
                    { 437, " 8.5", 1, "al36", null, "ULTRA 3pk", 1.0, 1, "-10.00" },
                    { 438, " 8.5", 1, "al37", null, "ULTRA 3pk", 1.0, 1, "-10.50" },
                    { 439, " 8.5", 1, "al38", null, "ULTRA 3pk", 1.0, 1, "-11.00" },
                    { 440, " 8.5", 1, "al39", null, "ULTRA 3pk", 1.0, 1, "-11.50" },
                    { 441, " 8.5", 1, "al40", null, "ULTRA 3pk", 1.0, 1, "-12.00" },
                    { 442, " 8.5", 1, "an5", null, "ULTRA 3pk", 1.0, 1, "+0.25" },
                    { 443, " 8.5", 1, "an6", null, "ULTRA 3pk", 1.0, 1, "+0.50" },
                    { 444, " 8.5", 1, "an7", null, "ULTRA 3pk", 1.0, 1, "+0.75" },
                    { 445, " 8.5", 1, "an8", null, "ULTRA 3pk", 1.0, 1, "+1.00" },
                    { 446, " 8.5", 1, "an9", null, "ULTRA 3pk", 1.0, 1, "+1.25" },
                    { 447, " 8.5", 1, "an10", null, "ULTRA 3pk", 1.0, 1, "+1.50" },
                    { 448, " 8.5", 1, "an11", null, "ULTRA 3pk", 1.0, 1, "+1.75" },
                    { 449, " 8.5", 1, "an12", null, "ULTRA 3pk", 1.0, 1, "+2.00" },
                    { 450, " 8.5", 1, "an13", null, "ULTRA 3pk", 1.0, 1, "+2.25" },
                    { 451, " 8.5", 1, "an14", null, "ULTRA 3pk", 1.0, 1, "+2.50" },
                    { 452, " 8.5", 1, "an15", null, "ULTRA 3pk", 1.0, 1, "+2.75" },
                    { 453, " 8.5", 1, "an16", null, "ULTRA 3pk", 1.0, 1, "+3.00" },
                    { 454, " 8.5", 1, "an17", null, "ULTRA 3pk", 1.0, 1, "+3.25" },
                    { 455, " 8.5", 1, "an18", null, "ULTRA 3pk", 1.0, 1, "+3.50" },
                    { 456, " 8.5", 1, "an19", null, "ULTRA 3pk", 1.0, 1, "+3.75" },
                    { 457, " 8.5", 1, "an20", null, "ULTRA 3pk", 1.0, 1, "+4.00" },
                    { 458, " 8.5", 1, "an21", null, "ULTRA 3pk", 1.0, 1, "+4.25" },
                    { 459, " 8.5", 1, "an22", null, "ULTRA 3pk", 1.0, 1, "+4.50" },
                    { 460, " 8.5", 1, "an23", null, "ULTRA 3pk", 1.0, 1, "+4.75" },
                    { 461, " 8.5", 1, "an24", null, "ULTRA 3pk", 1.0, 1, "+5.00" },
                    { 462, " 8.5", 1, "an25", null, "ULTRA 3pk", 1.0, 1, "+5.25" },
                    { 463, " 8.5", 1, "an26", null, "ULTRA 3pk", 1.0, 1, "+5.50" },
                    { 464, " 8.5", 1, "an27", null, "ULTRA 3pk", 1.0, 1, "+5.75" },
                    { 465, " 8.5", 1, "an28", null, "ULTRA 3pk", 1.0, 1, "+6.00" },
                    { 466, " 8.5", 1, "aq5", null, "ULTRA 6pk", 1.0, 1, "-0.25" },
                    { 467, " 8.5", 1, "aq6", null, "ULTRA 6pk", 1.0, 1, "-0.50" },
                    { 468, " 8.5", 1, "aq7", null, "ULTRA 6pk", 1.0, 1, "-0.75" },
                    { 469, " 8.5", 1, "aq8", null, "ULTRA 6pk", 1.0, 1, "-1.00" },
                    { 470, " 8.5", 1, "aq9", null, "ULTRA 6pk", 1.0, 1, "-1.25" },
                    { 471, " 8.5", 1, "aq10", null, "ULTRA 6pk", 1.0, 1, "-1.50" },
                    { 472, " 8.5", 1, "aq11", null, "ULTRA 6pk", 1.0, 1, "-1.75" },
                    { 473, " 8.5", 1, "aq12", null, "ULTRA 6pk", 1.0, 1, "-2.00" },
                    { 474, " 8.5", 1, "aq13", null, "ULTRA 6pk", 1.0, 1, "-2.25" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 475, " 8.5", 1, "aq14", null, "ULTRA 6pk", 1.0, 1, "-2.50" },
                    { 476, " 8.5", 1, "aq15", null, "ULTRA 6pk", 1.0, 1, "-2.75" },
                    { 477, " 8.5", 1, "aq16", null, "ULTRA 6pk", 1.0, 1, "-3.00" },
                    { 478, " 8.5", 1, "aq17", null, "ULTRA 6pk", 1.0, 1, "-3.25" },
                    { 479, " 8.5", 1, "aq18", null, "ULTRA 6pk", 1.0, 1, "-3.50" },
                    { 480, " 8.5", 1, "aq19", null, "ULTRA 6pk", 1.0, 1, "-3.75" },
                    { 481, " 8.5", 1, "aq20", null, "ULTRA 6pk", 1.0, 1, "-4.00" },
                    { 482, " 8.5", 1, "aq21", null, "ULTRA 6pk", 1.0, 1, "-4.25" },
                    { 483, " 8.5", 1, "aq22", null, "ULTRA 6pk", 1.0, 1, "-4.50" },
                    { 484, " 8.5", 1, "aq23", null, "ULTRA 6pk", 1.0, 1, "-4.75" },
                    { 485, " 8.5", 1, "aq24", null, "ULTRA 6pk", 1.0, 1, "-5.00" },
                    { 486, " 8.5", 1, "aq25", null, "ULTRA 6pk", 1.0, 1, "-5.25" },
                    { 487, " 8.5", 1, "aq26", null, "ULTRA 6pk", 1.0, 1, "-5.50" },
                    { 488, " 8.5", 1, "aq27", null, "ULTRA 6pk", 1.0, 1, "-5.75" },
                    { 489, " 8.5", 1, "aq28", null, "ULTRA 6pk", 1.0, 1, "-6.00" },
                    { 490, " 8.5", 1, "aq29", null, "ULTRA 6pk", 1.0, 1, "-6.50" },
                    { 491, " 8.5", 1, "aq30", null, "ULTRA 6pk", 1.0, 1, "-7.00" },
                    { 492, " 8.5", 1, "aq31", null, "ULTRA 6pk", 1.0, 1, "-7.50" },
                    { 493, " 8.5", 1, "aq32", null, "ULTRA 6pk", 1.0, 1, "-8.00" },
                    { 494, " 8.5", 1, "aq33", null, "ULTRA 6pk", 1.0, 1, "-8.50" },
                    { 495, " 8.5", 1, "aq34", null, "ULTRA 6pk", 1.0, 1, "-9.00" },
                    { 496, " 8.5", 1, "aq35", null, "ULTRA 6pk", 1.0, 1, "-9.50" },
                    { 497, " 8.5", 1, "aq36", null, "ULTRA 6pk", 1.0, 1, "-10.00" },
                    { 498, " 8.5", 1, "aq37", null, "ULTRA 6pk", 1.0, 1, "-10.50" },
                    { 499, " 8.5", 1, "aq38", null, "ULTRA 6pk", 1.0, 1, "-11.00" },
                    { 500, " 8.5", 1, "aq39", null, "ULTRA 6pk", 1.0, 1, "-11.50" },
                    { 501, " 8.5", 1, "aq40", null, "ULTRA 6pk", 1.0, 1, "-12.00" },
                    { 502, " 8.5", 1, "as5", null, "ULTRA 6pk", 1.0, 1, "+0.25" },
                    { 503, " 8.5", 1, "as6", null, "ULTRA 6pk", 1.0, 1, "+0.50" },
                    { 504, " 8.5", 1, "as7", null, "ULTRA 6pk", 1.0, 1, "+0.75" },
                    { 505, " 8.5", 1, "as8", null, "ULTRA 6pk", 1.0, 1, "+1.00" },
                    { 506, " 8.5", 1, "as9", null, "ULTRA 6pk", 1.0, 1, "+1.25" },
                    { 507, " 8.5", 1, "as10", null, "ULTRA 6pk", 1.0, 1, "+1.50" },
                    { 508, " 8.5", 1, "as11", null, "ULTRA 6pk", 1.0, 1, "+1.75" },
                    { 509, " 8.5", 1, "as12", null, "ULTRA 6pk", 1.0, 1, "+2.00" },
                    { 510, " 8.5", 1, "as13", null, "ULTRA 6pk", 1.0, 1, "+2.25" },
                    { 511, " 8.5", 1, "as14", null, "ULTRA 6pk", 1.0, 1, "+2.50" },
                    { 512, " 8.5", 1, "as15", null, "ULTRA 6pk", 1.0, 1, "+2.75" },
                    { 513, " 8.5", 1, "as16", null, "ULTRA 6pk", 1.0, 1, "+3.00" },
                    { 514, " 8.5", 1, "as17", null, "ULTRA 6pk", 1.0, 1, "+3.25" },
                    { 515, " 8.5", 1, "as18", null, "ULTRA 6pk", 1.0, 1, "+3.50" },
                    { 516, " 8.5", 1, "as19", null, "ULTRA 6pk", 1.0, 1, "+3.75" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 517, " 8.5", 1, "as20", null, "ULTRA 6pk", 1.0, 1, "+4.00" },
                    { 518, " 8.5", 1, "as21", null, "ULTRA 6pk", 1.0, 1, "+4.25" },
                    { 519, " 8.5", 1, "as22", null, "ULTRA 6pk", 1.0, 1, "+4.50" },
                    { 520, " 8.5", 1, "as23", null, "ULTRA 6pk", 1.0, 1, "+4.75" },
                    { 521, " 8.5", 1, "as24", null, "ULTRA 6pk", 1.0, 1, "+5.00" },
                    { 522, " 8.5", 1, "as25", null, "ULTRA 6pk", 1.0, 1, "+5.25" },
                    { 523, " 8.5", 1, "as26", null, "ULTRA 6pk", 1.0, 1, "+5.50" },
                    { 524, " 8.5", 1, "as27", null, "ULTRA 6pk", 1.0, 1, "+5.75" },
                    { 525, " 8.5", 1, "as28", null, "ULTRA 6pk", 1.0, 1, "+6.00" },
                    { 526, "", 1, "e38", null, "Раствор ReNu Multiplus 120 мл", 1.0, 1, "" },
                    { 527, "", 1, "e39", null, "Раствор ReNu Multiplus 240 мл", 1.0, 1, "" },
                    { 528, "", 1, "e40", null, "Раствор ReNu Multiplus 360 мл", 1.0, 1, "" },
                    { 529, "", 1, "e41", null, "Раствор ReNu MPS 120", 1.0, 1, "" },
                    { 530, "", 1, "e42", null, "Раствор ReNu MPS 240", 1.0, 1, "" },
                    { 531, "", 1, "e43", null, "Раствор ReNu MPS 360", 1.0, 1, "" },
                    { 532, "", 1, "e44", null, "Раствор BIOTRUE 120", 1.0, 1, "" },
                    { 533, "", 1, "e45", null, "Раствор BIOTRUE 300", 1.0, 1, "" }
                });

            migrationBuilder.InsertData(
                table: "ItemOrders",
                columns: new[] { "ItemOrderId", "Description", "Edited", "OrderCustomerId", "OrderVendorId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, "Опиасние oc201-io301-ov401 p1001", new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845), 1, 1, 1.1100000000000001, 1, 22 },
                    { 2, "Опиасние oc201-io302-ov401 p1002", new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845), 1, 1, 2.2200000000000002, 2, 33 },
                    { 3, "Опиасние oc201-io303-ov401 p1003", new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845), 1, 1, 3.3300000000000001, 3, 44 },
                    { 4, "Опиасние oc201-io304-ov401 p1004", new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845), 1, 1, 4.4400000000000004, 4, 55 },
                    { 5, "Опиасние oc201-io305-ov403 p1005", new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845), 1, null, 6.4500000000000002, 5, 855 },
                    { 6, "Опиасние oc201-io306-ov404 p1006", new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845), 1, null, 0.0, 6, 0 },
                    { 7, "Опиасние oc2068-io307-ov4012 p100391", new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 12, 0.0, 391, 0 },
                    { 8, "Опиасние oc2057-io308-ov4056 p10064", new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 56, 0.0, 64, 0 },
                    { 9, "Опиасние oc2020-io309-ov4040 p100318", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 40, 0.0, 318, 0 },
                    { 10, "Опиасние oc2039-io3010-ov4090 p10074", new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 90, 0.0, 74, 0 },
                    { 11, "Опиасние oc2088-io3011-ov4031 p100323", new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 31, 0.0, 323, 0 },
                    { 12, "Опиасние oc2082-io3012-ov4081 p100425", new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 81, 0.0, 425, 0 },
                    { 13, "Опиасние oc2077-io3013-ov4084 p100425", new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 84, 0.0, 425, 0 },
                    { 14, "Опиасние oc2095-io3014-ov4073 p100107", new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 73, 0.0, 107, 0 },
                    { 15, "Опиасние oc2012-io3015-ov4081 p100386", new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 81, 0.0, 386, 0 },
                    { 16, "Опиасние oc2039-io3016-ov4025 p100161", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 25, 0.0, 161, 0 },
                    { 17, "Опиасние oc2037-io3017-ov4013 p10019", new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 13, 0.0, 19, 0 },
                    { 18, "Опиасние oc2083-io3018-ov4022 p10067", new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 22, 0.0, 67, 0 },
                    { 19, "Опиасние oc2071-io3019-ov4030 p100347", new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 30, 0.0, 347, 0 },
                    { 20, "Опиасние oc2049-io3020-ov4095 p100361", new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 95, 0.0, 361, 0 },
                    { 21, "Опиасние oc2036-io3021-ov4071 p100196", new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 71, 0.0, 196, 0 },
                    { 22, "Опиасние oc2070-io3022-ov4039 p10067", new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 39, 0.0, 67, 0 },
                    { 23, "Опиасние oc2061-io3023-ov4097 p100124", new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 97, 0.0, 124, 0 },
                    { 24, "Опиасние oc2086-io3024-ov4019 p100422", new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, 19, 0.0, 422, 0 },
                    { 25, "Опиасние oc2047-io3025-ov4073 p100168", new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 73, 0.0, 168, 0 },
                    { 26, "Опиасние oc2079-io3026-ov4077 p10094", new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 77, 0.0, 94, 0 },
                    { 27, "Опиасние oc203-io3027-ov4086 p10042", new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 86, 0.0, 42, 0 },
                    { 28, "Опиасние oc2046-io3028-ov4059 p100149", new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 59, 0.0, 149, 0 },
                    { 29, "Опиасние oc2070-io3029-ov4045 p100479", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 45, 0.0, 479, 0 },
                    { 30, "Опиасние oc2064-io3030-ov4037 p100113", new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 37, 0.0, 113, 0 },
                    { 31, "Опиасние oc2026-io3031-ov4064 p100152", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 64, 0.0, 152, 0 },
                    { 32, "Опиасние oc206-io3032-ov4061 p100454", new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 61, 0.0, 454, 0 },
                    { 33, "Опиасние oc2014-io3033-ov4095 p100454", new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 95, 0.0, 454, 0 },
                    { 34, "Опиасние oc2020-io3034-ov4042 p100457", new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 42, 0.0, 457, 0 },
                    { 35, "Опиасние oc209-io3035-ov4045 p100284", new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 45, 0.0, 284, 0 },
                    { 36, "Опиасние oc2070-io3036-ov4020 p100260", new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 20, 0.0, 260, 0 },
                    { 37, "Опиасние oc2070-io3037-ov4075 p100451", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 75, 0.0, 451, 0 },
                    { 38, "Опиасние oc2078-io3038-ov405 p10085", new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 5, 0.0, 85, 0 },
                    { 39, "Опиасние oc2011-io3039-ov4066 p100349", new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 66, 0.0, 349, 0 },
                    { 40, "Опиасние oc2093-io3040-ov4010 p100252", new DateTime(2020, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 10, 0.0, 252, 0 },
                    { 41, "Опиасние oc2011-io3041-ov406 p100331", new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 6, 0.0, 331, 0 },
                    { 42, "Опиасние oc2098-io3042-ov4012 p100200", new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 12, 0.0, 200, 0 }
                });

            migrationBuilder.InsertData(
                table: "ItemOrders",
                columns: new[] { "ItemOrderId", "Description", "Edited", "OrderCustomerId", "OrderVendorId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 43, "Опиасние oc2020-io3043-ov4050 p10034", new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 50, 0.0, 34, 0 },
                    { 44, "Опиасние oc202-io3044-ov4070 p100161", new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 70, 0.0, 161, 0 },
                    { 45, "Опиасние oc2049-io3045-ov4016 p10042", new DateTime(2020, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 16, 0.0, 42, 0 },
                    { 46, "Опиасние oc2036-io3046-ov4027 p100375", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 27, 0.0, 375, 0 },
                    { 47, "Опиасние oc2059-io3047-ov4061 p100369", new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 61, 0.0, 369, 0 },
                    { 48, "Опиасние oc2083-io3048-ov4012 p100218", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 12, 0.0, 218, 0 },
                    { 49, "Опиасние oc2099-io3049-ov4085 p100240", new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 85, 0.0, 240, 0 },
                    { 50, "Опиасние oc2080-io3050-ov4026 p100411", new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 26, 0.0, 411, 0 },
                    { 51, "Опиасние oc2041-io3051-ov4019 p100263", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 19, 0.0, 263, 0 },
                    { 52, "Опиасние oc2042-io3052-ov4053 p100160", new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 53, 0.0, 160, 0 },
                    { 53, "Опиасние oc202-io3053-ov4068 p100309", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 68, 0.0, 309, 0 },
                    { 54, "Опиасние oc208-io3054-ov4026 p100135", new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 26, 0.0, 135, 0 },
                    { 55, "Опиасние oc2048-io3055-ov4093 p100232", new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 93, 0.0, 232, 0 },
                    { 56, "Опиасние oc2072-io3056-ov4052 p100323", new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 52, 0.0, 323, 0 },
                    { 57, "Опиасние oc209-io3057-ov4086 p10079", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 86, 0.0, 79, 0 },
                    { 58, "Опиасние oc2096-io3058-ov4088 p100479", new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 88, 0.0, 479, 0 },
                    { 59, "Опиасние oc2024-io3059-ov4072 p100310", new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 72, 0.0, 310, 0 },
                    { 60, "Опиасние oc2024-io3060-ov4096 p100158", new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 96, 0.0, 158, 0 },
                    { 61, "Опиасние oc2013-io3061-ov408 p10088", new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 8, 0.0, 88, 0 },
                    { 62, "Опиасние oc2085-io3062-ov407 p100181", new DateTime(2020, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 7, 0.0, 181, 0 },
                    { 63, "Опиасние oc2058-io3063-ov4037 p100366", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 37, 0.0, 366, 0 },
                    { 64, "Опиасние oc2091-io3064-ov4080 p100320", new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 80, 0.0, 320, 0 },
                    { 65, "Опиасние oc2078-io3065-ov4011 p100141", new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 11, 0.0, 141, 0 },
                    { 66, "Опиасние oc2026-io3066-ov403 p100243", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 3, 0.0, 243, 0 },
                    { 67, "Опиасние oc2026-io3067-ov4041 p10074", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 41, 0.0, 74, 0 },
                    { 68, "Опиасние oc202-io3068-ov4099 p100385", new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 99, 0.0, 385, 0 },
                    { 69, "Опиасние oc2018-io3069-ov4028 p10079", new DateTime(2020, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 28, 0.0, 79, 0 },
                    { 70, "Опиасние oc2063-io3070-ov4083 p100243", new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 83, 0.0, 243, 0 },
                    { 71, "Опиасние oc2018-io3071-ov4012 p100404", new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 12, 0.0, 404, 0 },
                    { 72, "Опиасние oc2072-io3072-ov4076 p10043", new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 76, 0.0, 43, 0 },
                    { 73, "Опиасние oc2077-io3073-ov4043 p100247", new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 43, 0.0, 247, 0 },
                    { 74, "Опиасние oc2050-io3074-ov4090 p10096", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 90, 0.0, 96, 0 },
                    { 75, "Опиасние oc2089-io3075-ov4018 p100178", new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 18, 0.0, 178, 0 },
                    { 76, "Опиасние oc204-io3076-ov4059 p10030", new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 59, 0.0, 30, 0 },
                    { 77, "Опиасние oc2082-io3077-ov4072 p100249", new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 72, 0.0, 249, 0 },
                    { 78, "Опиасние oc2067-io3078-ov4045 p100429", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 45, 0.0, 429, 0 },
                    { 79, "Опиасние oc2039-io3079-ov4096 p100149", new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 96, 0.0, 149, 0 },
                    { 80, "Опиасние oc2049-io3080-ov4043 p100428", new DateTime(2020, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 43, 0.0, 428, 0 },
                    { 81, "Опиасние oc2080-io3081-ov4039 p100477", new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 39, 0.0, 477, 0 },
                    { 82, "Опиасние oc2059-io3082-ov4085 p100368", new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 85, 0.0, 368, 0 },
                    { 83, "Опиасние oc2091-io3083-ov4012 p100454", new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 12, 0.0, 454, 0 },
                    { 84, "Опиасние oc2011-io3084-ov4085 p100142", new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 85, 0.0, 142, 0 }
                });

            migrationBuilder.InsertData(
                table: "ItemOrders",
                columns: new[] { "ItemOrderId", "Description", "Edited", "OrderCustomerId", "OrderVendorId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 85, "Опиасние oc2072-io3085-ov406 p100129", new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 6, 0.0, 129, 0 },
                    { 86, "Опиасние oc2029-io3086-ov4015 p100195", new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 15, 0.0, 195, 0 },
                    { 87, "Опиасние oc2059-io3087-ov4069 p100189", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 69, 0.0, 189, 0 },
                    { 88, "Опиасние oc2039-io3088-ov4084 p100492", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 84, 0.0, 492, 0 },
                    { 89, "Опиасние oc2030-io3089-ov406 p100127", new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 6, 0.0, 127, 0 },
                    { 90, "Опиасние oc2093-io3090-ov4025 p100142", new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 25, 0.0, 142, 0 },
                    { 91, "Опиасние oc2043-io3091-ov4079 p10056", new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 79, 0.0, 56, 0 },
                    { 92, "Опиасние oc2047-io3092-ov4021 p100479", new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 21, 0.0, 479, 0 },
                    { 93, "Опиасние oc2046-io3093-ov4053 p100151", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 53, 0.0, 151, 0 },
                    { 94, "Опиасние oc203-io3094-ov4082 p100204", new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 82, 0.0, 204, 0 },
                    { 95, "Опиасние oc2036-io3095-ov4057 p100335", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 57, 0.0, 335, 0 },
                    { 96, "Опиасние oc2013-io3096-ov4082 p100211", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 82, 0.0, 211, 0 },
                    { 97, "Опиасние oc2052-io3097-ov4016 p100432", new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 16, 0.0, 432, 0 },
                    { 98, "Опиасние oc2099-io3098-ov4082 p100400", new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 82, 0.0, 400, 0 },
                    { 99, "Опиасние oc2089-io3099-ov4053 p100421", new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 53, 0.0, 421, 0 }
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
                name: "Files");

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

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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
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
                    { 39, "Покупатель: 1039", "Customer c1039", "k3@gmail.com", "Покупатель: 1039", "Покупатель: 1039", "39", "+375 29 123-12-14" },
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
                    { 51, "Покупатель: 1051", "Customer c1051", "k3@gmail.com", "Покупатель: 1051", "Покупатель: 1051", "51", "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
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
                    { 81, "Покупатель: 1081", "Customer c1081", "k3@gmail.com", "Покупатель: 1081", "Покупатель: 1081", "81", "+375 29 123-12-14" },
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
                    { 93, "Покупатель: 1093", "Customer c1093", "k3@gmail.com", "Покупатель: 1093", "Покупатель: 1093", "93", "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 94, "Покупатель: 1094", "Customer c1094", "k3@gmail.com", "Покупатель: 1094", "Покупатель: 1094", "94", "+375 29 123-12-14" },
                    { 95, "Покупатель: 1095", "Customer c1095", "k3@gmail.com", "Покупатель: 1095", "Покупатель: 1095", "95", "+375 29 123-12-14" },
                    { 96, "Покупатель: 1096", "Customer c1096", "k3@gmail.com", "Покупатель: 1096", "Покупатель: 1096", "96", "+375 29 123-12-14" },
                    { 97, "Покупатель: 1097", "Customer c1097", "k3@gmail.com", "Покупатель: 1097", "Покупатель: 1097", "97", "+375 29 123-12-14" },
                    { 98, "Покупатель: 1098", "Customer c1098", "k3@gmail.com", "Покупатель: 1098", "Покупатель: 1098", "98", "+375 29 123-12-14" },
                    { 99, "Покупатель: 1099", "Customer c1099", "k3@gmail.com", "Покупатель: 1099", "Покупатель: 1099", "99", "+375 29 123-12-14" }
                });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 11, 48, 48, 594, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 2,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 11, 48, 48, 594, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 3,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 11, 48, 48, 594, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 4,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 11, 48, 48, 594, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 5,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 11, 48, 48, 594, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 6,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 11, 48, 48, 594, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.InsertData(
                table: "ItemOrders",
                columns: new[] { "ItemOrderId", "Description", "Edited", "OrderCustomerId", "OrderVendorId", "Price", "ProductId", "Quantity" },
                values: new object[] { 46, "Опиасние oc202-io3046-ov407 p10043", new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7, 0.0, 43, 0 });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 11, 48, 48, 594, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 2,
                column: "Edited",
                value: new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 3,
                column: "Edited",
                value: new DateTime(2020, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 4,
                column: "Edited",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "OrderCustomers",
                columns: new[] { "OrderCustomerId", "CustomerId", "Description", "Edited", "ExcelFileId", "Name" },
                values: new object[,]
                {
                    { 15, 7, "Описание ov2015-c7", new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2015" },
                    { 20, 7, "Описание ov2020-c7", new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2020" },
                    { 27, 4, "Описание ov2027-c4", new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2027" },
                    { 33, 6, "Описание ov2033-c6", new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2033" },
                    { 37, 9, "Описание ov2037-c9", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2037" }
                });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 11, 48, 48, 594, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 9,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 409-6", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.InsertData(
                table: "OrderVendors",
                columns: new[] { "OrderVendorId", "Description", "Edited", "Name", "VendorId" },
                values: new object[,]
                {
                    { 13, "Описание 4013-9", new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4013", 9 },
                    { 21, "Описание 4021-7", new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4021", 7 },
                    { 32, "Описание 4032-9", new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4032", 9 },
                    { 34, "Описание 4034-4", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4034", 4 },
                    { 35, "Описание 4035-2", new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4035", 2 },
                    { 37, "Описание 4037-3", new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4037", 3 },
                    { 42, "Описание 4042-2", new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4042", 2 },
                    { 57, "Описание 4057-9", new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4057", 9 },
                    { 79, "Описание 4079-3", new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4079", 3 },
                    { 88, "Описание 4088-9", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4088", 9 },
                    { 99, "Описание 4099-2", new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4099", 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 106, "", 1, "", null, "", 1.0, 1, "" },
                    { 107, " 8.6", 1, "m5", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-0.75" },
                    { 108, " 8.6", 1, "m6", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-1.00" },
                    { 109, " 8.6", 1, "m7", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-1.25" },
                    { 110, " 8.6", 1, "m8", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-1.50" },
                    { 111, " 8.6", 1, "m9", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-1.75" },
                    { 112, " 8.6", 1, "m10", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-2.00" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 113, " 8.6", 1, "m11", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-2.25" },
                    { 114, " 8.6", 1, "m12", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-2.50" },
                    { 115, " 8.6", 1, "m13", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-2.75" },
                    { 116, " 8.6", 1, "m14", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-3.00" },
                    { 117, " 8.6", 1, "m15", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-3.25" },
                    { 118, " 8.6", 1, "m16", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-3.50" },
                    { 119, " 8.6", 1, "m17", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-3.75" },
                    { 120, " 8.6", 1, "m18", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-4.00" },
                    { 121, " 8.6", 1, "m19", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-4.25" },
                    { 122, " 8.6", 1, "m20", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-4.50" },
                    { 123, " 8.6", 1, "m21", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-4.75" },
                    { 124, " 8.6", 1, "m22", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-5.00" },
                    { 125, " 8.6", 1, "m23", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-5.25" },
                    { 126, " 8.6", 1, "m24", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-5.50" },
                    { 127, " 8.6", 1, "m25", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-5.75" },
                    { 128, " 8.6", 1, "m26", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-6.00" },
                    { 129, " 8.6", 1, "m27", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-6.50" },
                    { 130, " 8.6", 1, "m28", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-7.00" },
                    { 131, " 8.6", 1, "m29", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-7.50" },
                    { 132, " 8.6", 1, "m30", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-8.00" },
                    { 133, " 8.6", 1, "m31", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-8.50" },
                    { 134, " 8.6", 1, "m32", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "-9.00" },
                    { 135, "", 1, "", null, "", 1.0, 1, "" },
                    { 136, " 8.6", 1, "o5", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+0.75" },
                    { 137, " 8.6", 1, "o6", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+1.00" },
                    { 138, " 8.6", 1, "o7", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+1.25" },
                    { 139, " 8.6", 1, "o8", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+1.50" },
                    { 140, " 8.6", 1, "o9", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+1.75" },
                    { 141, " 8.6", 1, "o10", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+2.00" },
                    { 142, " 8.6", 1, "o11", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+2.25" },
                    { 143, " 8.6", 1, "o12", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+2.50" },
                    { 144, " 8.6", 1, "o13", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+2.75" },
                    { 145, " 8.6", 1, "o14", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+3.00" },
                    { 146, " 8.6", 1, "o15", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+3.25" },
                    { 147, " 8.6", 1, "o16", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+3.50" },
                    { 148, " 8.6", 1, "o17", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+3.75" },
                    { 149, " 8.6", 1, "o18", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+4.00" },
                    { 150, " 8.6", 1, "o19", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+4.25" },
                    { 151, " 8.6", 1, "o20", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+4.50" },
                    { 152, " 8.6", 1, "o21", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+4.75" },
                    { 153, " 8.6", 1, "o22", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+5.00" },
                    { 154, " 8.6", 1, "o23", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+5.25" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 155, " 8.6", 1, "o24", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+5.50" },
                    { 156, " 8.6", 1, "o25", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+5.75" },
                    { 157, " 8.6", 1, "o26", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+6.00" },
                    { 158, " 8.6", 1, "o27", null, " SofLens Daily Disposable 90 pk", 1.0, 1, "+6.50" },
                    { 159, "", 1, "", null, "", 1.0, 1, "" },
                    { 160, " 8.4", 1, "r5", null, "Optima FW 4 pk", 1.0, 1, "-0.75" },
                    { 161, " 8.4", 1, "r6", null, "Optima FW 4 pk", 1.0, 1, "-1.00" },
                    { 162, " 8.4", 1, "r7", null, "Optima FW 4 pk", 1.0, 1, "-1.25" },
                    { 163, " 8.4", 1, "r8", null, "Optima FW 4 pk", 1.0, 1, "-1.50" },
                    { 164, " 8.4", 1, "r9", null, "Optima FW 4 pk", 1.0, 1, "-1.75" },
                    { 165, " 8.4", 1, "r10", null, "Optima FW 4 pk", 1.0, 1, "-2.00" },
                    { 166, " 8.4", 1, "r11", null, "Optima FW 4 pk", 1.0, 1, "-2.25" },
                    { 167, " 8.4", 1, "r12", null, "Optima FW 4 pk", 1.0, 1, "-2.50" },
                    { 168, " 8.4", 1, "r13", null, "Optima FW 4 pk", 1.0, 1, "-2.75" },
                    { 169, " 8.4", 1, "r14", null, "Optima FW 4 pk", 1.0, 1, "-3.00" },
                    { 170, " 8.4", 1, "r15", null, "Optima FW 4 pk", 1.0, 1, "-3.25" },
                    { 171, " 8.4", 1, "r16", null, "Optima FW 4 pk", 1.0, 1, "-3.50" },
                    { 172, " 8.4", 1, "r17", null, "Optima FW 4 pk", 1.0, 1, "-3.75" },
                    { 173, " 8.4", 1, "r18", null, "Optima FW 4 pk", 1.0, 1, "-4.00" },
                    { 174, " 8.4", 1, "r19", null, "Optima FW 4 pk", 1.0, 1, "-4.25" },
                    { 175, " 8.4", 1, "r20", null, "Optima FW 4 pk", 1.0, 1, "-4.50" },
                    { 176, " 8.4", 1, "r21", null, "Optima FW 4 pk", 1.0, 1, "-4.75" },
                    { 177, " 8.4", 1, "r22", null, "Optima FW 4 pk", 1.0, 1, "-5.00" },
                    { 178, " 8.4", 1, "r23", null, "Optima FW 4 pk", 1.0, 1, "-5.25" },
                    { 179, " 8.4", 1, "r24", null, "Optima FW 4 pk", 1.0, 1, "-5.50" },
                    { 180, " 8.4", 1, "r25", null, "Optima FW 4 pk", 1.0, 1, "-5.75" },
                    { 181, " 8.4", 1, "r26", null, "Optima FW 4 pk", 1.0, 1, "-6.00" },
                    { 182, " 8.4", 1, "r27", null, "Optima FW 4 pk", 1.0, 1, "-6.50" },
                    { 183, " 8.4", 1, "r28", null, "Optima FW 4 pk", 1.0, 1, "-7.00" },
                    { 184, " 8.4", 1, "r29", null, "Optima FW 4 pk", 1.0, 1, "-7.50" },
                    { 185, " 8.4", 1, "r30", null, "Optima FW 4 pk", 1.0, 1, "-8.00" },
                    { 186, " 8.4", 1, "r31", null, "Optima FW 4 pk", 1.0, 1, "-8.50" },
                    { 187, " 8.4", 1, "r32", null, "Optima FW 4 pk", 1.0, 1, "-9.00" },
                    { 188, "", 1, "", null, "", 1.0, 1, "" },
                    { 189, " 8.7", 1, "s5", null, "Optima FW 4 pk", 1.0, 1, "-0.75" },
                    { 190, " 8.7", 1, "s6", null, "Optima FW 4 pk", 1.0, 1, "-1.00" },
                    { 191, " 8.7", 1, "s7", null, "Optima FW 4 pk", 1.0, 1, "-1.25" },
                    { 192, " 8.7", 1, "s8", null, "Optima FW 4 pk", 1.0, 1, "-1.50" },
                    { 193, " 8.7", 1, "s9", null, "Optima FW 4 pk", 1.0, 1, "-1.75" },
                    { 194, " 8.7", 1, "s10", null, "Optima FW 4 pk", 1.0, 1, "-2.00" },
                    { 195, " 8.7", 1, "s11", null, "Optima FW 4 pk", 1.0, 1, "-2.25" },
                    { 196, " 8.7", 1, "s12", null, "Optima FW 4 pk", 1.0, 1, "-2.50" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 197, " 8.7", 1, "s13", null, "Optima FW 4 pk", 1.0, 1, "-2.75" },
                    { 198, " 8.7", 1, "s14", null, "Optima FW 4 pk", 1.0, 1, "-3.00" },
                    { 199, " 8.7", 1, "s15", null, "Optima FW 4 pk", 1.0, 1, "-3.25" },
                    { 200, " 8.7", 1, "s16", null, "Optima FW 4 pk", 1.0, 1, "-3.50" },
                    { 201, " 8.7", 1, "s17", null, "Optima FW 4 pk", 1.0, 1, "-3.75" },
                    { 202, " 8.7", 1, "s18", null, "Optima FW 4 pk", 1.0, 1, "-4.00" },
                    { 203, " 8.7", 1, "s19", null, "Optima FW 4 pk", 1.0, 1, "-4.25" },
                    { 204, " 8.7", 1, "s20", null, "Optima FW 4 pk", 1.0, 1, "-4.50" },
                    { 205, " 8.7", 1, "s21", null, "Optima FW 4 pk", 1.0, 1, "-4.75" },
                    { 206, " 8.7", 1, "s22", null, "Optima FW 4 pk", 1.0, 1, "-5.00" },
                    { 207, " 8.7", 1, "s23", null, "Optima FW 4 pk", 1.0, 1, "-5.25" },
                    { 208, " 8.7", 1, "s24", null, "Optima FW 4 pk", 1.0, 1, "-5.50" },
                    { 209, " 8.7", 1, "s25", null, "Optima FW 4 pk", 1.0, 1, "-5.75" },
                    { 210, " 8.7", 1, "s26", null, "Optima FW 4 pk", 1.0, 1, "-6.00" },
                    { 211, " 8.7", 1, "s27", null, "Optima FW 4 pk", 1.0, 1, "-6.50" },
                    { 212, " 8.7", 1, "s28", null, "Optima FW 4 pk", 1.0, 1, "-7.00" },
                    { 213, " 8.7", 1, "s29", null, "Optima FW 4 pk", 1.0, 1, "-7.50" },
                    { 214, " 8.7", 1, "s30", null, "Optima FW 4 pk", 1.0, 1, "-8.00" },
                    { 215, " 8.7", 1, "s31", null, "Optima FW 4 pk", 1.0, 1, "-8.50" },
                    { 216, " 8.7", 1, "s32", null, "Optima FW 4 pk", 1.0, 1, "-9.00" },
                    { 217, "", 1, "", null, "", 1.0, 1, "" },
                    { 218, "9.0", 1, "t5", null, "Optima FW 4 pk", 1.0, 1, "-0.75" },
                    { 219, "9.0", 1, "t6", null, "Optima FW 4 pk", 1.0, 1, "-1.00" },
                    { 220, "9.0", 1, "t7", null, "Optima FW 4 pk", 1.0, 1, "-1.25" },
                    { 221, "9.0", 1, "t8", null, "Optima FW 4 pk", 1.0, 1, "-1.50" },
                    { 222, "9.0", 1, "t9", null, "Optima FW 4 pk", 1.0, 1, "-1.75" },
                    { 223, "9.0", 1, "t10", null, "Optima FW 4 pk", 1.0, 1, "-2.00" },
                    { 224, "9.0", 1, "t11", null, "Optima FW 4 pk", 1.0, 1, "-2.25" },
                    { 225, "9.0", 1, "t12", null, "Optima FW 4 pk", 1.0, 1, "-2.50" },
                    { 226, "9.0", 1, "t13", null, "Optima FW 4 pk", 1.0, 1, "-2.75" },
                    { 227, "9.0", 1, "t14", null, "Optima FW 4 pk", 1.0, 1, "-3.00" },
                    { 228, "9.0", 1, "t15", null, "Optima FW 4 pk", 1.0, 1, "-3.25" },
                    { 229, "9.0", 1, "t16", null, "Optima FW 4 pk", 1.0, 1, "-3.50" },
                    { 230, "9.0", 1, "t17", null, "Optima FW 4 pk", 1.0, 1, "-3.75" },
                    { 231, "9.0", 1, "t18", null, "Optima FW 4 pk", 1.0, 1, "-4.00" },
                    { 232, "9.0", 1, "t19", null, "Optima FW 4 pk", 1.0, 1, "-4.25" },
                    { 233, "9.0", 1, "t20", null, "Optima FW 4 pk", 1.0, 1, "-4.50" },
                    { 234, "9.0", 1, "t21", null, "Optima FW 4 pk", 1.0, 1, "-4.75" },
                    { 235, "9.0", 1, "t22", null, "Optima FW 4 pk", 1.0, 1, "-5.00" },
                    { 236, "9.0", 1, "t23", null, "Optima FW 4 pk", 1.0, 1, "-5.25" },
                    { 237, "9.0", 1, "t24", null, "Optima FW 4 pk", 1.0, 1, "-5.50" },
                    { 238, "9.0", 1, "t25", null, "Optima FW 4 pk", 1.0, 1, "-5.75" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 239, "9.0", 1, "t26", null, "Optima FW 4 pk", 1.0, 1, "-6.00" },
                    { 240, "9.0", 1, "t27", null, "Optima FW 4 pk", 1.0, 1, "-6.50" },
                    { 241, "9.0", 1, "t28", null, "Optima FW 4 pk", 1.0, 1, "-7.00" },
                    { 242, "9.0", 1, "t29", null, "Optima FW 4 pk", 1.0, 1, "-7.50" },
                    { 243, "9.0", 1, "t30", null, "Optima FW 4 pk", 1.0, 1, "-8.00" },
                    { 244, "9.0", 1, "t31", null, "Optima FW 4 pk", 1.0, 1, "-8.50" },
                    { 245, "9.0", 1, "t32", null, "Optima FW 4 pk", 1.0, 1, "-9.00" },
                    { 246, "", 1, "", null, "", 1.0, 1, "" },
                    { 247, " 8.6", 1, "x5", null, "Pure Vision2 6pk", 1.0, 1, "-0.50" },
                    { 248, " 8.6", 1, "x6", null, "Pure Vision2 6pk", 1.0, 1, "-0.75" },
                    { 249, " 8.6", 1, "x7", null, "Pure Vision2 6pk", 1.0, 1, "-1.00" },
                    { 250, " 8.6", 1, "x8", null, "Pure Vision2 6pk", 1.0, 1, "-1.25" },
                    { 251, " 8.6", 1, "x9", null, "Pure Vision2 6pk", 1.0, 1, "-1.50" },
                    { 252, " 8.6", 1, "x10", null, "Pure Vision2 6pk", 1.0, 1, "-1.75" },
                    { 253, " 8.6", 1, "x11", null, "Pure Vision2 6pk", 1.0, 1, "-2.00" },
                    { 254, " 8.6", 1, "x12", null, "Pure Vision2 6pk", 1.0, 1, "-2.25" },
                    { 255, " 8.6", 1, "x13", null, "Pure Vision2 6pk", 1.0, 1, "-2.50" },
                    { 256, " 8.6", 1, "x14", null, "Pure Vision2 6pk", 1.0, 1, "-2.75" },
                    { 257, " 8.6", 1, "x15", null, "Pure Vision2 6pk", 1.0, 1, "-3.00" },
                    { 258, " 8.6", 1, "x16", null, "Pure Vision2 6pk", 1.0, 1, "-3.25" },
                    { 259, " 8.6", 1, "x17", null, "Pure Vision2 6pk", 1.0, 1, "-3.50" },
                    { 260, " 8.6", 1, "x18", null, "Pure Vision2 6pk", 1.0, 1, "-3.75" },
                    { 261, " 8.6", 1, "x19", null, "Pure Vision2 6pk", 1.0, 1, "-4.00" },
                    { 262, " 8.6", 1, "x20", null, "Pure Vision2 6pk", 1.0, 1, "-4.25" },
                    { 263, " 8.6", 1, "x21", null, "Pure Vision2 6pk", 1.0, 1, "-4.50" },
                    { 264, " 8.6", 1, "x22", null, "Pure Vision2 6pk", 1.0, 1, "-4.75" },
                    { 265, " 8.6", 1, "x23", null, "Pure Vision2 6pk", 1.0, 1, "-5.00" },
                    { 266, " 8.6", 1, "x24", null, "Pure Vision2 6pk", 1.0, 1, "-5.25" },
                    { 267, " 8.6", 1, "x25", null, "Pure Vision2 6pk", 1.0, 1, "-5.50" },
                    { 268, " 8.6", 1, "x26", null, "Pure Vision2 6pk", 1.0, 1, "-5.75" },
                    { 269, " 8.6", 1, "x27", null, "Pure Vision2 6pk", 1.0, 1, "-6.00" },
                    { 270, " 8.6", 1, "x28", null, "Pure Vision2 6pk", 1.0, 1, "-6.50" },
                    { 271, " 8.6", 1, "x29", null, "Pure Vision2 6pk", 1.0, 1, "-7.00" },
                    { 272, " 8.6", 1, "x30", null, "Pure Vision2 6pk", 1.0, 1, "-7.50" },
                    { 273, " 8.6", 1, "x31", null, "Pure Vision2 6pk", 1.0, 1, "-8.00" },
                    { 274, " 8.6", 1, "x32", null, "Pure Vision2 6pk", 1.0, 1, "-8.50" },
                    { 275, " 8.6", 1, "x33", null, "Pure Vision2 6pk", 1.0, 1, "-9.00" },
                    { 276, " 8.6", 1, "x34", null, "Pure Vision2 6pk", 1.0, 1, "-9.50" },
                    { 277, " 8.6", 1, "x35", null, "Pure Vision2 6pk", 1.0, 1, "-10.00" },
                    { 278, " 8.6", 1, "x36", null, "Pure Vision2 6pk", 1.0, 1, "-10.50" },
                    { 279, " 8.6", 1, "x37", null, "Pure Vision2 6pk", 1.0, 1, "-11.00" },
                    { 280, " 8.6", 1, "x38", null, "Pure Vision2 6pk", 1.0, 1, "-11.50" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 281, " 8.6", 1, "x39", null, "Pure Vision2 6pk", 1.0, 1, "-12.00" },
                    { 282, "", 1, "", null, "", 1.0, 1, "" },
                    { 283, " 8.6", 1, "z5", null, "Pure Vision2 6pk", 1.0, 1, "+0.50" },
                    { 284, " 8.6", 1, "z6", null, "Pure Vision2 6pk", 1.0, 1, "+0.75" },
                    { 285, " 8.6", 1, "z7", null, "Pure Vision2 6pk", 1.0, 1, "+1.00" },
                    { 286, " 8.6", 1, "z8", null, "Pure Vision2 6pk", 1.0, 1, "+1.25" },
                    { 287, " 8.6", 1, "z9", null, "Pure Vision2 6pk", 1.0, 1, "+1.50" },
                    { 288, " 8.6", 1, "z10", null, "Pure Vision2 6pk", 1.0, 1, "+1.75" },
                    { 289, " 8.6", 1, "z11", null, "Pure Vision2 6pk", 1.0, 1, "+2.00" },
                    { 290, " 8.6", 1, "z12", null, "Pure Vision2 6pk", 1.0, 1, "+2.25" },
                    { 291, " 8.6", 1, "z13", null, "Pure Vision2 6pk", 1.0, 1, "+2.50" },
                    { 292, " 8.6", 1, "z14", null, "Pure Vision2 6pk", 1.0, 1, "+2.75" },
                    { 293, " 8.6", 1, "z15", null, "Pure Vision2 6pk", 1.0, 1, "+3.00" },
                    { 294, " 8.6", 1, "z16", null, "Pure Vision2 6pk", 1.0, 1, "+3.25" },
                    { 295, " 8.6", 1, "z17", null, "Pure Vision2 6pk", 1.0, 1, "+3.50" },
                    { 296, " 8.6", 1, "z18", null, "Pure Vision2 6pk", 1.0, 1, "+3.75" },
                    { 297, " 8.6", 1, "z19", null, "Pure Vision2 6pk", 1.0, 1, "+4.00" },
                    { 298, " 8.6", 1, "z20", null, "Pure Vision2 6pk", 1.0, 1, "+4.25" },
                    { 299, " 8.6", 1, "z21", null, "Pure Vision2 6pk", 1.0, 1, "+4.50" },
                    { 300, " 8.6", 1, "z22", null, "Pure Vision2 6pk", 1.0, 1, "+4.75" },
                    { 301, " 8.6", 1, "z23", null, "Pure Vision2 6pk", 1.0, 1, "+5.00" },
                    { 302, " 8.6", 1, "z24", null, "Pure Vision2 6pk", 1.0, 1, "+5.25" },
                    { 303, " 8.6", 1, "z25", null, "Pure Vision2 6pk", 1.0, 1, "+5.50" },
                    { 304, " 8.6", 1, "z26", null, "Pure Vision2 6pk", 1.0, 1, "+5.75" },
                    { 305, " 8.6", 1, "z27", null, "Pure Vision2 6pk", 1.0, 1, "+6.00" },
                    { 306, "", 1, "", null, "", 1.0, 1, "" },
                    { 307, " 8.6", 1, "ac5", null, "Biotrue ONEDay 30pk", 1.0, 1, "-0.50" },
                    { 308, " 8.6", 1, "ac6", null, "Biotrue ONEDay 30pk", 1.0, 1, "-0.75" },
                    { 309, " 8.6", 1, "ac7", null, "Biotrue ONEDay 30pk", 1.0, 1, "-1.00" },
                    { 310, " 8.6", 1, "ac8", null, "Biotrue ONEDay 30pk", 1.0, 1, "-1.25" },
                    { 311, " 8.6", 1, "ac9", null, "Biotrue ONEDay 30pk", 1.0, 1, "-1.50" },
                    { 312, " 8.6", 1, "ac10", null, "Biotrue ONEDay 30pk", 1.0, 1, "-1.75" },
                    { 313, " 8.6", 1, "ac11", null, "Biotrue ONEDay 30pk", 1.0, 1, "-2.00" },
                    { 314, " 8.6", 1, "ac12", null, "Biotrue ONEDay 30pk", 1.0, 1, "-2.25" },
                    { 315, " 8.6", 1, "ac13", null, "Biotrue ONEDay 30pk", 1.0, 1, "-2.50" },
                    { 316, " 8.6", 1, "ac14", null, "Biotrue ONEDay 30pk", 1.0, 1, "-2.75" },
                    { 317, " 8.6", 1, "ac15", null, "Biotrue ONEDay 30pk", 1.0, 1, "-3.00" },
                    { 318, " 8.6", 1, "ac16", null, "Biotrue ONEDay 30pk", 1.0, 1, "-3.25" },
                    { 319, " 8.6", 1, "ac17", null, "Biotrue ONEDay 30pk", 1.0, 1, "-3.50" },
                    { 320, " 8.6", 1, "ac18", null, "Biotrue ONEDay 30pk", 1.0, 1, "-3.75" },
                    { 321, " 8.6", 1, "ac19", null, "Biotrue ONEDay 30pk", 1.0, 1, "-4.00" },
                    { 322, " 8.6", 1, "ac20", null, "Biotrue ONEDay 30pk", 1.0, 1, "-4.25" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 323, " 8.6", 1, "ac21", null, "Biotrue ONEDay 30pk", 1.0, 1, "-4.50" },
                    { 324, " 8.6", 1, "ac22", null, "Biotrue ONEDay 30pk", 1.0, 1, "-4.75" },
                    { 325, " 8.6", 1, "ac23", null, "Biotrue ONEDay 30pk", 1.0, 1, "-5.00" },
                    { 326, " 8.6", 1, "ac24", null, "Biotrue ONEDay 30pk", 1.0, 1, "-5.25" },
                    { 327, " 8.6", 1, "ac25", null, "Biotrue ONEDay 30pk", 1.0, 1, "-5.50" },
                    { 328, " 8.6", 1, "ac26", null, "Biotrue ONEDay 30pk", 1.0, 1, "-5.75" },
                    { 329, " 8.6", 1, "ac27", null, "Biotrue ONEDay 30pk", 1.0, 1, "-6.00" },
                    { 330, " 8.6", 1, "ac28", null, "Biotrue ONEDay 30pk", 1.0, 1, "-6.25" },
                    { 331, " 8.6", 1, "ac29", null, "Biotrue ONEDay 30pk", 1.0, 1, "-6.50" },
                    { 332, " 8.6", 1, "ac30", null, "Biotrue ONEDay 30pk", 1.0, 1, "-7.00" },
                    { 333, " 8.6", 1, "ac31", null, "Biotrue ONEDay 30pk", 1.0, 1, "-7.50" },
                    { 334, " 8.6", 1, "ac32", null, "Biotrue ONEDay 30pk", 1.0, 1, "-8.00" },
                    { 335, " 8.6", 1, "ac33", null, "Biotrue ONEDay 30pk", 1.0, 1, "-8.50" },
                    { 336, " 8.6", 1, "ac34", null, "Biotrue ONEDay 30pk", 1.0, 1, "-9.00" },
                    { 337, "", 1, "", null, "", 1.0, 1, "" },
                    { 338, " 8.6", 1, "ae5", null, "Biotrue ONEDay 30pk", 1.0, 1, "+0.50" },
                    { 339, " 8.6", 1, "ae6", null, "Biotrue ONEDay 30pk", 1.0, 1, "+0.75" },
                    { 340, " 8.6", 1, "ae7", null, "Biotrue ONEDay 30pk", 1.0, 1, "+1.00" },
                    { 341, " 8.6", 1, "ae8", null, "Biotrue ONEDay 30pk", 1.0, 1, "+1.25" },
                    { 342, " 8.6", 1, "ae9", null, "Biotrue ONEDay 30pk", 1.0, 1, "+1.50" },
                    { 343, " 8.6", 1, "ae10", null, "Biotrue ONEDay 30pk", 1.0, 1, "+1.75" },
                    { 344, " 8.6", 1, "ae11", null, "Biotrue ONEDay 30pk", 1.0, 1, "+2.00" },
                    { 345, " 8.6", 1, "ae12", null, "Biotrue ONEDay 30pk", 1.0, 1, "+2.25" },
                    { 346, " 8.6", 1, "ae13", null, "Biotrue ONEDay 30pk", 1.0, 1, "+2.50" },
                    { 347, " 8.6", 1, "ae14", null, "Biotrue ONEDay 30pk", 1.0, 1, "+2.75" },
                    { 348, " 8.6", 1, "ae15", null, "Biotrue ONEDay 30pk", 1.0, 1, "+3.00" },
                    { 349, " 8.6", 1, "ae16", null, "Biotrue ONEDay 30pk", 1.0, 1, "+3.25" },
                    { 350, " 8.6", 1, "ae17", null, "Biotrue ONEDay 30pk", 1.0, 1, "+3.50" },
                    { 351, " 8.6", 1, "ae18", null, "Biotrue ONEDay 30pk", 1.0, 1, "+3.75" },
                    { 352, " 8.6", 1, "ae19", null, "Biotrue ONEDay 30pk", 1.0, 1, "+4.00" },
                    { 353, " 8.6", 1, "ae20", null, "Biotrue ONEDay 30pk", 1.0, 1, "+4.25" },
                    { 354, " 8.6", 1, "ae21", null, "Biotrue ONEDay 30pk", 1.0, 1, "+4.50" },
                    { 355, " 8.6", 1, "ae22", null, "Biotrue ONEDay 30pk", 1.0, 1, "+4.75" },
                    { 356, " 8.6", 1, "ae23", null, "Biotrue ONEDay 30pk", 1.0, 1, "+5.00" },
                    { 357, " 8.6", 1, "ae24", null, "Biotrue ONEDay 30pk", 1.0, 1, "+5.25" },
                    { 358, " 8.6", 1, "ae25", null, "Biotrue ONEDay 30pk", 1.0, 1, "+5.50" },
                    { 359, " 8.6", 1, "ae26", null, "Biotrue ONEDay 30pk", 1.0, 1, "+5.75" },
                    { 360, " 8.6", 1, "ae27", null, "Biotrue ONEDay 30pk", 1.0, 1, "+6.00" },
                    { 361, " 8.6", 1, "ae28", null, "Biotrue ONEDay 30pk", 1.0, 1, "-6.25" },
                    { 362, " 8.6", 1, "ae29", null, "Biotrue ONEDay 30pk", 1.0, 1, "+6.50" },
                    { 363, "", 1, "", null, "", 1.0, 1, "" },
                    { 364, " 8.6", 1, "ag5", null, "Biotrue ONEDay 90pk", 1.0, 1, "-0.50" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 365, " 8.6", 1, "ag6", null, "Biotrue ONEDay 90pk", 1.0, 1, "-0.75" },
                    { 366, " 8.6", 1, "ag7", null, "Biotrue ONEDay 90pk", 1.0, 1, "-1.00" },
                    { 367, " 8.6", 1, "ag8", null, "Biotrue ONEDay 90pk", 1.0, 1, "-1.25" },
                    { 368, " 8.6", 1, "ag9", null, "Biotrue ONEDay 90pk", 1.0, 1, "-1.50" },
                    { 369, " 8.6", 1, "ag10", null, "Biotrue ONEDay 90pk", 1.0, 1, "-1.75" },
                    { 370, " 8.6", 1, "ag11", null, "Biotrue ONEDay 90pk", 1.0, 1, "-2.00" },
                    { 371, " 8.6", 1, "ag12", null, "Biotrue ONEDay 90pk", 1.0, 1, "-2.25" },
                    { 372, " 8.6", 1, "ag13", null, "Biotrue ONEDay 90pk", 1.0, 1, "-2.50" },
                    { 373, " 8.6", 1, "ag14", null, "Biotrue ONEDay 90pk", 1.0, 1, "-2.75" },
                    { 374, " 8.6", 1, "ag15", null, "Biotrue ONEDay 90pk", 1.0, 1, "-3.00" },
                    { 375, " 8.6", 1, "ag16", null, "Biotrue ONEDay 90pk", 1.0, 1, "-3.25" },
                    { 376, " 8.6", 1, "ag17", null, "Biotrue ONEDay 90pk", 1.0, 1, "-3.50" },
                    { 377, " 8.6", 1, "ag18", null, "Biotrue ONEDay 90pk", 1.0, 1, "-3.75" },
                    { 378, " 8.6", 1, "ag19", null, "Biotrue ONEDay 90pk", 1.0, 1, "-4.00" },
                    { 379, " 8.6", 1, "ag20", null, "Biotrue ONEDay 90pk", 1.0, 1, "-4.25" },
                    { 380, " 8.6", 1, "ag21", null, "Biotrue ONEDay 90pk", 1.0, 1, "-4.50" },
                    { 381, " 8.6", 1, "ag22", null, "Biotrue ONEDay 90pk", 1.0, 1, "-4.75" },
                    { 382, " 8.6", 1, "ag23", null, "Biotrue ONEDay 90pk", 1.0, 1, "-5.00" },
                    { 383, " 8.6", 1, "ag24", null, "Biotrue ONEDay 90pk", 1.0, 1, "-5.25" },
                    { 384, " 8.6", 1, "ag25", null, "Biotrue ONEDay 90pk", 1.0, 1, "-5.50" },
                    { 385, " 8.6", 1, "ag26", null, "Biotrue ONEDay 90pk", 1.0, 1, "-5.75" },
                    { 386, " 8.6", 1, "ag27", null, "Biotrue ONEDay 90pk", 1.0, 1, "-6.00" },
                    { 387, " 8.6", 1, "ag28", null, "Biotrue ONEDay 90pk", 1.0, 1, "-6.25" },
                    { 388, " 8.6", 1, "ag29", null, "Biotrue ONEDay 90pk", 1.0, 1, "-6.50" },
                    { 389, " 8.6", 1, "ag30", null, "Biotrue ONEDay 90pk", 1.0, 1, "-7.00" },
                    { 390, " 8.6", 1, "ag31", null, "Biotrue ONEDay 90pk", 1.0, 1, "-7.50" },
                    { 391, " 8.6", 1, "ag32", null, "Biotrue ONEDay 90pk", 1.0, 1, "-8.00" },
                    { 392, " 8.6", 1, "ag33", null, "Biotrue ONEDay 90pk", 1.0, 1, "-8.50" },
                    { 393, " 8.6", 1, "ag34", null, "Biotrue ONEDay 90pk", 1.0, 1, "-9.00" },
                    { 394, "", 1, "", null, "", 1.0, 1, "" },
                    { 395, " 8.6", 1, "ai5", null, "Biotrue ONEDay 90pk", 1.0, 1, "+0.50" },
                    { 396, " 8.6", 1, "ai6", null, "Biotrue ONEDay 90pk", 1.0, 1, "+0.75" },
                    { 397, " 8.6", 1, "ai7", null, "Biotrue ONEDay 90pk", 1.0, 1, "+1.00" },
                    { 398, " 8.6", 1, "ai8", null, "Biotrue ONEDay 90pk", 1.0, 1, "+1.25" },
                    { 399, " 8.6", 1, "ai9", null, "Biotrue ONEDay 90pk", 1.0, 1, "+1.50" },
                    { 400, " 8.6", 1, "ai10", null, "Biotrue ONEDay 90pk", 1.0, 1, "+1.75" },
                    { 401, " 8.6", 1, "ai11", null, "Biotrue ONEDay 90pk", 1.0, 1, "+2.00" },
                    { 402, " 8.6", 1, "ai12", null, "Biotrue ONEDay 90pk", 1.0, 1, "+2.25" },
                    { 403, " 8.6", 1, "ai13", null, "Biotrue ONEDay 90pk", 1.0, 1, "+2.50" },
                    { 404, " 8.6", 1, "ai14", null, "Biotrue ONEDay 90pk", 1.0, 1, "+2.75" },
                    { 405, " 8.6", 1, "ai15", null, "Biotrue ONEDay 90pk", 1.0, 1, "+3.00" },
                    { 406, " 8.6", 1, "ai16", null, "Biotrue ONEDay 90pk", 1.0, 1, "+3.25" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 407, " 8.6", 1, "ai17", null, "Biotrue ONEDay 90pk", 1.0, 1, "+3.50" },
                    { 408, " 8.6", 1, "ai18", null, "Biotrue ONEDay 90pk", 1.0, 1, "+3.75" },
                    { 409, " 8.6", 1, "ai19", null, "Biotrue ONEDay 90pk", 1.0, 1, "+4.00" },
                    { 410, " 8.6", 1, "ai20", null, "Biotrue ONEDay 90pk", 1.0, 1, "+4.25" },
                    { 411, " 8.6", 1, "ai21", null, "Biotrue ONEDay 90pk", 1.0, 1, "+4.50" },
                    { 412, " 8.6", 1, "ai22", null, "Biotrue ONEDay 90pk", 1.0, 1, "+4.75" },
                    { 413, " 8.6", 1, "ai23", null, "Biotrue ONEDay 90pk", 1.0, 1, "+5.00" },
                    { 414, " 8.6", 1, "ai24", null, "Biotrue ONEDay 90pk", 1.0, 1, "+5.25" },
                    { 415, " 8.6", 1, "ai25", null, "Biotrue ONEDay 90pk", 1.0, 1, "+5.50" },
                    { 416, " 8.6", 1, "ai26", null, "Biotrue ONEDay 90pk", 1.0, 1, "+5.75" },
                    { 417, " 8.6", 1, "ai27", null, "Biotrue ONEDay 90pk", 1.0, 1, "+6.00" },
                    { 418, " 8.6", 1, "ai28", null, "Biotrue ONEDay 90pk", 1.0, 1, "+6.50" },
                    { 419, " 8.6", 1, "ai29", null, "Biotrue ONEDay 90pk", 1.0, 1, "+6.50" },
                    { 420, "", 1, "", null, "", 1.0, 1, "" },
                    { 421, " 8.5", 1, "al5", null, "ULTRA 3pk", 1.0, 1, "-0.25" },
                    { 422, " 8.5", 1, "al6", null, "ULTRA 3pk", 1.0, 1, "-0.50" },
                    { 423, " 8.5", 1, "al7", null, "ULTRA 3pk", 1.0, 1, "-0.75" },
                    { 424, " 8.5", 1, "al8", null, "ULTRA 3pk", 1.0, 1, "-1.00" },
                    { 425, " 8.5", 1, "al9", null, "ULTRA 3pk", 1.0, 1, "-1.25" },
                    { 426, " 8.5", 1, "al10", null, "ULTRA 3pk", 1.0, 1, "-1.50" },
                    { 427, " 8.5", 1, "al11", null, "ULTRA 3pk", 1.0, 1, "-1.75" },
                    { 428, " 8.5", 1, "al12", null, "ULTRA 3pk", 1.0, 1, "-2.00" },
                    { 429, " 8.5", 1, "al13", null, "ULTRA 3pk", 1.0, 1, "-2.25" },
                    { 430, " 8.5", 1, "al14", null, "ULTRA 3pk", 1.0, 1, "-2.50" },
                    { 431, " 8.5", 1, "al15", null, "ULTRA 3pk", 1.0, 1, "-2.75" },
                    { 432, " 8.5", 1, "al16", null, "ULTRA 3pk", 1.0, 1, "-3.00" },
                    { 433, " 8.5", 1, "al17", null, "ULTRA 3pk", 1.0, 1, "-3.25" },
                    { 434, " 8.5", 1, "al18", null, "ULTRA 3pk", 1.0, 1, "-3.50" },
                    { 435, " 8.5", 1, "al19", null, "ULTRA 3pk", 1.0, 1, "-3.75" },
                    { 436, " 8.5", 1, "al20", null, "ULTRA 3pk", 1.0, 1, "-4.00" },
                    { 437, " 8.5", 1, "al21", null, "ULTRA 3pk", 1.0, 1, "-4.25" },
                    { 438, " 8.5", 1, "al22", null, "ULTRA 3pk", 1.0, 1, "-4.50" },
                    { 439, " 8.5", 1, "al23", null, "ULTRA 3pk", 1.0, 1, "-4.75" },
                    { 440, " 8.5", 1, "al24", null, "ULTRA 3pk", 1.0, 1, "-5.00" },
                    { 441, " 8.5", 1, "al25", null, "ULTRA 3pk", 1.0, 1, "-5.25" },
                    { 442, " 8.5", 1, "al26", null, "ULTRA 3pk", 1.0, 1, "-5.50" },
                    { 443, " 8.5", 1, "al27", null, "ULTRA 3pk", 1.0, 1, "-5.75" },
                    { 444, " 8.5", 1, "al28", null, "ULTRA 3pk", 1.0, 1, "-6.00" },
                    { 445, " 8.5", 1, "al29", null, "ULTRA 3pk", 1.0, 1, "-6.50" },
                    { 446, " 8.5", 1, "al30", null, "ULTRA 3pk", 1.0, 1, "-7.00" },
                    { 447, " 8.5", 1, "al31", null, "ULTRA 3pk", 1.0, 1, "-7.50" },
                    { 448, " 8.5", 1, "al32", null, "ULTRA 3pk", 1.0, 1, "-8.00" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 449, " 8.5", 1, "al33", null, "ULTRA 3pk", 1.0, 1, "-8.50" },
                    { 450, " 8.5", 1, "al34", null, "ULTRA 3pk", 1.0, 1, "-9.00" },
                    { 451, " 8.5", 1, "al35", null, "ULTRA 3pk", 1.0, 1, "-9.50" },
                    { 452, " 8.5", 1, "al36", null, "ULTRA 3pk", 1.0, 1, "-10.00" },
                    { 453, " 8.5", 1, "al37", null, "ULTRA 3pk", 1.0, 1, "-10.50" },
                    { 454, " 8.5", 1, "al38", null, "ULTRA 3pk", 1.0, 1, "-11.00" },
                    { 455, " 8.5", 1, "al39", null, "ULTRA 3pk", 1.0, 1, "-11.50" },
                    { 456, " 8.5", 1, "al40", null, "ULTRA 3pk", 1.0, 1, "-12.00" },
                    { 457, "", 1, "", null, "", 1.0, 1, "" },
                    { 458, " 8.5", 1, "an5", null, "ULTRA 3pk", 1.0, 1, "+0.25" },
                    { 459, " 8.5", 1, "an6", null, "ULTRA 3pk", 1.0, 1, "+0.50" },
                    { 460, " 8.5", 1, "an7", null, "ULTRA 3pk", 1.0, 1, "+0.75" },
                    { 461, " 8.5", 1, "an8", null, "ULTRA 3pk", 1.0, 1, "+1.00" },
                    { 462, " 8.5", 1, "an9", null, "ULTRA 3pk", 1.0, 1, "+1.25" },
                    { 463, " 8.5", 1, "an10", null, "ULTRA 3pk", 1.0, 1, "+1.50" },
                    { 464, " 8.5", 1, "an11", null, "ULTRA 3pk", 1.0, 1, "+1.75" },
                    { 465, " 8.5", 1, "an12", null, "ULTRA 3pk", 1.0, 1, "+2.00" },
                    { 466, " 8.5", 1, "an13", null, "ULTRA 3pk", 1.0, 1, "+2.25" },
                    { 467, " 8.5", 1, "an14", null, "ULTRA 3pk", 1.0, 1, "+2.50" },
                    { 468, " 8.5", 1, "an15", null, "ULTRA 3pk", 1.0, 1, "+2.75" },
                    { 469, " 8.5", 1, "an16", null, "ULTRA 3pk", 1.0, 1, "+3.00" },
                    { 470, " 8.5", 1, "an17", null, "ULTRA 3pk", 1.0, 1, "+3.25" },
                    { 471, " 8.5", 1, "an18", null, "ULTRA 3pk", 1.0, 1, "+3.50" },
                    { 472, " 8.5", 1, "an19", null, "ULTRA 3pk", 1.0, 1, "+3.75" },
                    { 473, " 8.5", 1, "an20", null, "ULTRA 3pk", 1.0, 1, "+4.00" },
                    { 474, " 8.5", 1, "an21", null, "ULTRA 3pk", 1.0, 1, "+4.25" },
                    { 475, " 8.5", 1, "an22", null, "ULTRA 3pk", 1.0, 1, "+4.50" },
                    { 476, " 8.5", 1, "an23", null, "ULTRA 3pk", 1.0, 1, "+4.75" },
                    { 477, " 8.5", 1, "an24", null, "ULTRA 3pk", 1.0, 1, "+5.00" },
                    { 478, " 8.5", 1, "an25", null, "ULTRA 3pk", 1.0, 1, "+5.25" },
                    { 479, " 8.5", 1, "an26", null, "ULTRA 3pk", 1.0, 1, "+5.50" },
                    { 480, " 8.5", 1, "an27", null, "ULTRA 3pk", 1.0, 1, "+5.75" },
                    { 481, " 8.5", 1, "an28", null, "ULTRA 3pk", 1.0, 1, "+6.00" },
                    { 482, "", 1, "", null, "", 1.0, 1, "" },
                    { 483, " 8.5", 1, "aq5", null, "ULTRA 6pk", 1.0, 1, "-0.25" },
                    { 484, " 8.5", 1, "aq6", null, "ULTRA 6pk", 1.0, 1, "-0.50" },
                    { 485, " 8.5", 1, "aq7", null, "ULTRA 6pk", 1.0, 1, "-0.75" },
                    { 486, " 8.5", 1, "aq8", null, "ULTRA 6pk", 1.0, 1, "-1.00" },
                    { 487, " 8.5", 1, "aq9", null, "ULTRA 6pk", 1.0, 1, "-1.25" },
                    { 488, " 8.5", 1, "aq10", null, "ULTRA 6pk", 1.0, 1, "-1.50" },
                    { 489, " 8.5", 1, "aq11", null, "ULTRA 6pk", 1.0, 1, "-1.75" },
                    { 490, " 8.5", 1, "aq12", null, "ULTRA 6pk", 1.0, 1, "-2.00" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 491, " 8.5", 1, "aq13", null, "ULTRA 6pk", 1.0, 1, "-2.25" },
                    { 492, " 8.5", 1, "aq14", null, "ULTRA 6pk", 1.0, 1, "-2.50" },
                    { 493, " 8.5", 1, "aq15", null, "ULTRA 6pk", 1.0, 1, "-2.75" },
                    { 494, " 8.5", 1, "aq16", null, "ULTRA 6pk", 1.0, 1, "-3.00" },
                    { 495, " 8.5", 1, "aq17", null, "ULTRA 6pk", 1.0, 1, "-3.25" },
                    { 496, " 8.5", 1, "aq18", null, "ULTRA 6pk", 1.0, 1, "-3.50" },
                    { 497, " 8.5", 1, "aq19", null, "ULTRA 6pk", 1.0, 1, "-3.75" },
                    { 498, " 8.5", 1, "aq20", null, "ULTRA 6pk", 1.0, 1, "-4.00" },
                    { 499, " 8.5", 1, "aq21", null, "ULTRA 6pk", 1.0, 1, "-4.25" },
                    { 500, " 8.5", 1, "aq22", null, "ULTRA 6pk", 1.0, 1, "-4.50" },
                    { 501, " 8.5", 1, "aq23", null, "ULTRA 6pk", 1.0, 1, "-4.75" },
                    { 502, " 8.5", 1, "aq24", null, "ULTRA 6pk", 1.0, 1, "-5.00" },
                    { 503, " 8.5", 1, "aq25", null, "ULTRA 6pk", 1.0, 1, "-5.25" },
                    { 504, " 8.5", 1, "aq26", null, "ULTRA 6pk", 1.0, 1, "-5.50" },
                    { 505, " 8.5", 1, "aq27", null, "ULTRA 6pk", 1.0, 1, "-5.75" },
                    { 506, " 8.5", 1, "aq28", null, "ULTRA 6pk", 1.0, 1, "-6.00" },
                    { 507, " 8.5", 1, "aq29", null, "ULTRA 6pk", 1.0, 1, "-6.50" },
                    { 508, " 8.5", 1, "aq30", null, "ULTRA 6pk", 1.0, 1, "-7.00" },
                    { 509, " 8.5", 1, "aq31", null, "ULTRA 6pk", 1.0, 1, "-7.50" },
                    { 510, " 8.5", 1, "aq32", null, "ULTRA 6pk", 1.0, 1, "-8.00" },
                    { 511, " 8.5", 1, "aq33", null, "ULTRA 6pk", 1.0, 1, "-8.50" },
                    { 512, " 8.5", 1, "aq34", null, "ULTRA 6pk", 1.0, 1, "-9.00" },
                    { 513, " 8.5", 1, "aq35", null, "ULTRA 6pk", 1.0, 1, "-9.50" },
                    { 514, " 8.5", 1, "aq36", null, "ULTRA 6pk", 1.0, 1, "-10.00" },
                    { 515, " 8.5", 1, "aq37", null, "ULTRA 6pk", 1.0, 1, "-10.50" },
                    { 516, " 8.5", 1, "aq38", null, "ULTRA 6pk", 1.0, 1, "-11.00" },
                    { 517, " 8.5", 1, "aq39", null, "ULTRA 6pk", 1.0, 1, "-11.50" },
                    { 518, " 8.5", 1, "aq40", null, "ULTRA 6pk", 1.0, 1, "-12.00" },
                    { 519, "", 1, "", null, "", 1.0, 1, "" },
                    { 520, " 8.5", 1, "as5", null, "ULTRA 6pk", 1.0, 1, "+0.25" },
                    { 521, " 8.5", 1, "as6", null, "ULTRA 6pk", 1.0, 1, "+0.50" },
                    { 522, " 8.5", 1, "as7", null, "ULTRA 6pk", 1.0, 1, "+0.75" },
                    { 523, " 8.5", 1, "as8", null, "ULTRA 6pk", 1.0, 1, "+1.00" },
                    { 524, " 8.5", 1, "as9", null, "ULTRA 6pk", 1.0, 1, "+1.25" },
                    { 525, " 8.5", 1, "as10", null, "ULTRA 6pk", 1.0, 1, "+1.50" },
                    { 526, " 8.5", 1, "as11", null, "ULTRA 6pk", 1.0, 1, "+1.75" },
                    { 527, " 8.5", 1, "as12", null, "ULTRA 6pk", 1.0, 1, "+2.00" },
                    { 528, " 8.5", 1, "as13", null, "ULTRA 6pk", 1.0, 1, "+2.25" },
                    { 529, " 8.5", 1, "as14", null, "ULTRA 6pk", 1.0, 1, "+2.50" },
                    { 530, " 8.5", 1, "as15", null, "ULTRA 6pk", 1.0, 1, "+2.75" },
                    { 531, " 8.5", 1, "as16", null, "ULTRA 6pk", 1.0, 1, "+3.00" },
                    { 532, " 8.5", 1, "as17", null, "ULTRA 6pk", 1.0, 1, "+3.25" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BC", "CategoryId", "Cell", "Description", "Name", "Price", "Quantity", "Sph" },
                values: new object[,]
                {
                    { 533, " 8.5", 1, "as18", null, "ULTRA 6pk", 1.0, 1, "+3.50" },
                    { 534, " 8.5", 1, "as19", null, "ULTRA 6pk", 1.0, 1, "+3.75" },
                    { 535, " 8.5", 1, "as20", null, "ULTRA 6pk", 1.0, 1, "+4.00" },
                    { 536, " 8.5", 1, "as21", null, "ULTRA 6pk", 1.0, 1, "+4.25" },
                    { 537, " 8.5", 1, "as22", null, "ULTRA 6pk", 1.0, 1, "+4.50" },
                    { 538, " 8.5", 1, "as23", null, "ULTRA 6pk", 1.0, 1, "+4.75" },
                    { 539, " 8.5", 1, "as24", null, "ULTRA 6pk", 1.0, 1, "+5.00" },
                    { 540, " 8.5", 1, "as25", null, "ULTRA 6pk", 1.0, 1, "+5.25" },
                    { 541, " 8.5", 1, "as26", null, "ULTRA 6pk", 1.0, 1, "+5.50" },
                    { 542, " 8.5", 1, "as27", null, "ULTRA 6pk", 1.0, 1, "+5.75" },
                    { 543, " 8.5", 1, "as28", null, "ULTRA 6pk", 1.0, 1, "+6.00" },
                    { 544, "", 1, "", null, "", 1.0, 1, "" },
                    { 545, "", 1, "e38", null, "Раствор ReNu Multiplus 120 мл", 1.0, 1, "" },
                    { 546, "", 1, "e39", null, "Раствор ReNu Multiplus 240 мл", 1.0, 1, "" },
                    { 547, "", 1, "e40", null, "Раствор ReNu Multiplus 360 мл", 1.0, 1, "" },
                    { 548, "", 1, "e41", null, "Раствор ReNu MPS 120", 1.0, 1, "" },
                    { 549, "", 1, "e42", null, "Раствор ReNu MPS 240", 1.0, 1, "" },
                    { 550, "", 1, "e43", null, "Раствор ReNu MPS 360", 1.0, 1, "" },
                    { 551, "", 1, "e44", null, "Раствор BIOTRUE 120", 1.0, 1, "" },
                    { 552, "", 1, "e45", null, "Раствор BIOTRUE 300", 1.0, 1, "" }
                });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 2,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p502-13", "+375 29 123-12-14" });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 3,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p503-48", "+375 29 123-12-14" });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 4,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p504-41", "+375 29 123-12-14" });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 5,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p505-49", "+375 29 123-12-14" });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 6,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p506-94", "+375 29 123-12-14" });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 7,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p507-63", "+375 29 123-12-14" });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 8,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p508-36", "+375 29 123-12-14" });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 9,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p509-91", "+375 29 123-12-14" });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 10, "Поставщик: 5010", "Описание p5010-4", "mail-5010@gmail.com", null, "Поставщик: 5010", null, "+375 29 123-12-14" },
                    { 11, "Поставщик: 5011", "Описание p5011-96", "mail-5011@gmail.com", null, "Поставщик: 5011", null, "+375 29 123-12-14" },
                    { 12, "Поставщик: 5012", "Описание p5012-33", "mail-5012@gmail.com", null, "Поставщик: 5012", null, "+375 29 123-12-14" },
                    { 13, "Поставщик: 5013", "Описание p5013-89", "mail-5013@gmail.com", null, "Поставщик: 5013", null, "+375 29 123-12-14" },
                    { 14, "Поставщик: 5014", "Описание p5014-18", "mail-5014@gmail.com", null, "Поставщик: 5014", null, "+375 29 123-12-14" },
                    { 15, "Поставщик: 5015", "Описание p5015-20", "mail-5015@gmail.com", null, "Поставщик: 5015", null, "+375 29 123-12-14" },
                    { 16, "Поставщик: 5016", "Описание p5016-90", "mail-5016@gmail.com", null, "Поставщик: 5016", null, "+375 29 123-12-14" },
                    { 17, "Поставщик: 5017", "Описание p5017-58", "mail-5017@gmail.com", null, "Поставщик: 5017", null, "+375 29 123-12-14" },
                    { 18, "Поставщик: 5018", "Описание p5018-42", "mail-5018@gmail.com", null, "Поставщик: 5018", null, "+375 29 123-12-14" },
                    { 19, "Поставщик: 5019", "Описание p5019-69", "mail-5019@gmail.com", null, "Поставщик: 5019", null, "+375 29 123-12-14" },
                    { 20, "Поставщик: 5020", "Описание p5020-63", "mail-5020@gmail.com", null, "Поставщик: 5020", null, "+375 29 123-12-14" },
                    { 21, "Поставщик: 5021", "Описание p5021-21", "mail-5021@gmail.com", null, "Поставщик: 5021", null, "+375 29 123-12-14" },
                    { 22, "Поставщик: 5022", "Описание p5022-61", "mail-5022@gmail.com", null, "Поставщик: 5022", null, "+375 29 123-12-14" },
                    { 23, "Поставщик: 5023", "Описание p5023-46", "mail-5023@gmail.com", null, "Поставщик: 5023", null, "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 24, "Поставщик: 5024", "Описание p5024-70", "mail-5024@gmail.com", null, "Поставщик: 5024", null, "+375 29 123-12-14" },
                    { 25, "Поставщик: 5025", "Описание p5025-31", "mail-5025@gmail.com", null, "Поставщик: 5025", null, "+375 29 123-12-14" },
                    { 26, "Поставщик: 5026", "Описание p5026-66", "mail-5026@gmail.com", null, "Поставщик: 5026", null, "+375 29 123-12-14" },
                    { 27, "Поставщик: 5027", "Описание p5027-89", "mail-5027@gmail.com", null, "Поставщик: 5027", null, "+375 29 123-12-14" },
                    { 28, "Поставщик: 5028", "Описание p5028-15", "mail-5028@gmail.com", null, "Поставщик: 5028", null, "+375 29 123-12-14" },
                    { 29, "Поставщик: 5029", "Описание p5029-9", "mail-5029@gmail.com", null, "Поставщик: 5029", null, "+375 29 123-12-14" },
                    { 30, "Поставщик: 5030", "Описание p5030-51", "mail-5030@gmail.com", null, "Поставщик: 5030", null, "+375 29 123-12-14" },
                    { 31, "Поставщик: 5031", "Описание p5031-9", "mail-5031@gmail.com", null, "Поставщик: 5031", null, "+375 29 123-12-14" },
                    { 32, "Поставщик: 5032", "Описание p5032-90", "mail-5032@gmail.com", null, "Поставщик: 5032", null, "+375 29 123-12-14" },
                    { 33, "Поставщик: 5033", "Описание p5033-21", "mail-5033@gmail.com", null, "Поставщик: 5033", null, "+375 29 123-12-14" },
                    { 34, "Поставщик: 5034", "Описание p5034-41", "mail-5034@gmail.com", null, "Поставщик: 5034", null, "+375 29 123-12-14" },
                    { 35, "Поставщик: 5035", "Описание p5035-80", "mail-5035@gmail.com", null, "Поставщик: 5035", null, "+375 29 123-12-14" },
                    { 36, "Поставщик: 5036", "Описание p5036-16", "mail-5036@gmail.com", null, "Поставщик: 5036", null, "+375 29 123-12-14" },
                    { 37, "Поставщик: 5037", "Описание p5037-53", "mail-5037@gmail.com", null, "Поставщик: 5037", null, "+375 29 123-12-14" },
                    { 38, "Поставщик: 5038", "Описание p5038-25", "mail-5038@gmail.com", null, "Поставщик: 5038", null, "+375 29 123-12-14" },
                    { 39, "Поставщик: 5039", "Описание p5039-53", "mail-5039@gmail.com", null, "Поставщик: 5039", null, "+375 29 123-12-14" },
                    { 40, "Поставщик: 5040", "Описание p5040-80", "mail-5040@gmail.com", null, "Поставщик: 5040", null, "+375 29 123-12-14" },
                    { 41, "Поставщик: 5041", "Описание p5041-19", "mail-5041@gmail.com", null, "Поставщик: 5041", null, "+375 29 123-12-14" },
                    { 42, "Поставщик: 5042", "Описание p5042-60", "mail-5042@gmail.com", null, "Поставщик: 5042", null, "+375 29 123-12-14" },
                    { 43, "Поставщик: 5043", "Описание p5043-22", "mail-5043@gmail.com", null, "Поставщик: 5043", null, "+375 29 123-12-14" },
                    { 44, "Поставщик: 5044", "Описание p5044-39", "mail-5044@gmail.com", null, "Поставщик: 5044", null, "+375 29 123-12-14" },
                    { 45, "Поставщик: 5045", "Описание p5045-51", "mail-5045@gmail.com", null, "Поставщик: 5045", null, "+375 29 123-12-14" },
                    { 46, "Поставщик: 5046", "Описание p5046-99", "mail-5046@gmail.com", null, "Поставщик: 5046", null, "+375 29 123-12-14" },
                    { 47, "Поставщик: 5047", "Описание p5047-97", "mail-5047@gmail.com", null, "Поставщик: 5047", null, "+375 29 123-12-14" },
                    { 48, "Поставщик: 5048", "Описание p5048-81", "mail-5048@gmail.com", null, "Поставщик: 5048", null, "+375 29 123-12-14" },
                    { 49, "Поставщик: 5049", "Описание p5049-86", "mail-5049@gmail.com", null, "Поставщик: 5049", null, "+375 29 123-12-14" },
                    { 50, "Поставщик: 5050", "Описание p5050-98", "mail-5050@gmail.com", null, "Поставщик: 5050", null, "+375 29 123-12-14" },
                    { 51, "Поставщик: 5051", "Описание p5051-1", "mail-5051@gmail.com", null, "Поставщик: 5051", null, "+375 29 123-12-14" },
                    { 52, "Поставщик: 5052", "Описание p5052-86", "mail-5052@gmail.com", null, "Поставщик: 5052", null, "+375 29 123-12-14" },
                    { 53, "Поставщик: 5053", "Описание p5053-36", "mail-5053@gmail.com", null, "Поставщик: 5053", null, "+375 29 123-12-14" },
                    { 54, "Поставщик: 5054", "Описание p5054-63", "mail-5054@gmail.com", null, "Поставщик: 5054", null, "+375 29 123-12-14" },
                    { 55, "Поставщик: 5055", "Описание p5055-95", "mail-5055@gmail.com", null, "Поставщик: 5055", null, "+375 29 123-12-14" },
                    { 56, "Поставщик: 5056", "Описание p5056-21", "mail-5056@gmail.com", null, "Поставщик: 5056", null, "+375 29 123-12-14" },
                    { 57, "Поставщик: 5057", "Описание p5057-8", "mail-5057@gmail.com", null, "Поставщик: 5057", null, "+375 29 123-12-14" },
                    { 58, "Поставщик: 5058", "Описание p5058-41", "mail-5058@gmail.com", null, "Поставщик: 5058", null, "+375 29 123-12-14" },
                    { 59, "Поставщик: 5059", "Описание p5059-53", "mail-5059@gmail.com", null, "Поставщик: 5059", null, "+375 29 123-12-14" },
                    { 60, "Поставщик: 5060", "Описание p5060-58", "mail-5060@gmail.com", null, "Поставщик: 5060", null, "+375 29 123-12-14" },
                    { 61, "Поставщик: 5061", "Описание p5061-28", "mail-5061@gmail.com", null, "Поставщик: 5061", null, "+375 29 123-12-14" },
                    { 62, "Поставщик: 5062", "Описание p5062-88", "mail-5062@gmail.com", null, "Поставщик: 5062", null, "+375 29 123-12-14" },
                    { 63, "Поставщик: 5063", "Описание p5063-94", "mail-5063@gmail.com", null, "Поставщик: 5063", null, "+375 29 123-12-14" },
                    { 64, "Поставщик: 5064", "Описание p5064-97", "mail-5064@gmail.com", null, "Поставщик: 5064", null, "+375 29 123-12-14" },
                    { 65, "Поставщик: 5065", "Описание p5065-33", "mail-5065@gmail.com", null, "Поставщик: 5065", null, "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "Company", "Description", "Email", "Fullname", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 66, "Поставщик: 5066", "Описание p5066-79", "mail-5066@gmail.com", null, "Поставщик: 5066", null, "+375 29 123-12-14" },
                    { 67, "Поставщик: 5067", "Описание p5067-69", "mail-5067@gmail.com", null, "Поставщик: 5067", null, "+375 29 123-12-14" },
                    { 68, "Поставщик: 5068", "Описание p5068-64", "mail-5068@gmail.com", null, "Поставщик: 5068", null, "+375 29 123-12-14" },
                    { 69, "Поставщик: 5069", "Описание p5069-53", "mail-5069@gmail.com", null, "Поставщик: 5069", null, "+375 29 123-12-14" },
                    { 70, "Поставщик: 5070", "Описание p5070-10", "mail-5070@gmail.com", null, "Поставщик: 5070", null, "+375 29 123-12-14" },
                    { 71, "Поставщик: 5071", "Описание p5071-5", "mail-5071@gmail.com", null, "Поставщик: 5071", null, "+375 29 123-12-14" },
                    { 72, "Поставщик: 5072", "Описание p5072-24", "mail-5072@gmail.com", null, "Поставщик: 5072", null, "+375 29 123-12-14" },
                    { 73, "Поставщик: 5073", "Описание p5073-48", "mail-5073@gmail.com", null, "Поставщик: 5073", null, "+375 29 123-12-14" },
                    { 74, "Поставщик: 5074", "Описание p5074-31", "mail-5074@gmail.com", null, "Поставщик: 5074", null, "+375 29 123-12-14" },
                    { 75, "Поставщик: 5075", "Описание p5075-12", "mail-5075@gmail.com", null, "Поставщик: 5075", null, "+375 29 123-12-14" },
                    { 76, "Поставщик: 5076", "Описание p5076-59", "mail-5076@gmail.com", null, "Поставщик: 5076", null, "+375 29 123-12-14" },
                    { 77, "Поставщик: 5077", "Описание p5077-45", "mail-5077@gmail.com", null, "Поставщик: 5077", null, "+375 29 123-12-14" },
                    { 78, "Поставщик: 5078", "Описание p5078-56", "mail-5078@gmail.com", null, "Поставщик: 5078", null, "+375 29 123-12-14" },
                    { 79, "Поставщик: 5079", "Описание p5079-47", "mail-5079@gmail.com", null, "Поставщик: 5079", null, "+375 29 123-12-14" },
                    { 80, "Поставщик: 5080", "Описание p5080-94", "mail-5080@gmail.com", null, "Поставщик: 5080", null, "+375 29 123-12-14" },
                    { 81, "Поставщик: 5081", "Описание p5081-87", "mail-5081@gmail.com", null, "Поставщик: 5081", null, "+375 29 123-12-14" },
                    { 82, "Поставщик: 5082", "Описание p5082-39", "mail-5082@gmail.com", null, "Поставщик: 5082", null, "+375 29 123-12-14" },
                    { 83, "Поставщик: 5083", "Описание p5083-92", "mail-5083@gmail.com", null, "Поставщик: 5083", null, "+375 29 123-12-14" },
                    { 84, "Поставщик: 5084", "Описание p5084-72", "mail-5084@gmail.com", null, "Поставщик: 5084", null, "+375 29 123-12-14" },
                    { 85, "Поставщик: 5085", "Описание p5085-18", "mail-5085@gmail.com", null, "Поставщик: 5085", null, "+375 29 123-12-14" },
                    { 86, "Поставщик: 5086", "Описание p5086-38", "mail-5086@gmail.com", null, "Поставщик: 5086", null, "+375 29 123-12-14" },
                    { 87, "Поставщик: 5087", "Описание p5087-69", "mail-5087@gmail.com", null, "Поставщик: 5087", null, "+375 29 123-12-14" },
                    { 88, "Поставщик: 5088", "Описание p5088-77", "mail-5088@gmail.com", null, "Поставщик: 5088", null, "+375 29 123-12-14" },
                    { 89, "Поставщик: 5089", "Описание p5089-63", "mail-5089@gmail.com", null, "Поставщик: 5089", null, "+375 29 123-12-14" },
                    { 90, "Поставщик: 5090", "Описание p5090-61", "mail-5090@gmail.com", null, "Поставщик: 5090", null, "+375 29 123-12-14" },
                    { 91, "Поставщик: 5091", "Описание p5091-50", "mail-5091@gmail.com", null, "Поставщик: 5091", null, "+375 29 123-12-14" },
                    { 92, "Поставщик: 5092", "Описание p5092-93", "mail-5092@gmail.com", null, "Поставщик: 5092", null, "+375 29 123-12-14" },
                    { 93, "Поставщик: 5093", "Описание p5093-22", "mail-5093@gmail.com", null, "Поставщик: 5093", null, "+375 29 123-12-14" },
                    { 94, "Поставщик: 5094", "Описание p5094-72", "mail-5094@gmail.com", null, "Поставщик: 5094", null, "+375 29 123-12-14" },
                    { 95, "Поставщик: 5095", "Описание p5095-80", "mail-5095@gmail.com", null, "Поставщик: 5095", null, "+375 29 123-12-14" },
                    { 96, "Поставщик: 5096", "Описание p5096-73", "mail-5096@gmail.com", null, "Поставщик: 5096", null, "+375 29 123-12-14" },
                    { 97, "Поставщик: 5097", "Описание p5097-54", "mail-5097@gmail.com", null, "Поставщик: 5097", null, "+375 29 123-12-14" },
                    { 98, "Поставщик: 5098", "Описание p5098-13", "mail-5098@gmail.com", null, "Поставщик: 5098", null, "+375 29 123-12-14" },
                    { 99, "Поставщик: 5099", "Описание p5099-12", "mail-5099@gmail.com", null, "Поставщик: 5099", null, "+375 29 123-12-14" }
                });

            migrationBuilder.InsertData(
                table: "ItemOrders",
                columns: new[] { "ItemOrderId", "Description", "Edited", "OrderCustomerId", "OrderVendorId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 26, "Опиасние oc203-io3026-ov4035 p100295", new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 35, 0.0, 295, 0 },
                    { 53, "Опиасние oc204-io3053-ov4032 p100485", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 32, 0.0, 485, 0 },
                    { 63, "Опиасние oc2020-io3063-ov4079 p100249", new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 79, 0.0, 249, 0 },
                    { 69, "Опиасние oc2037-io3069-ov407 p100101", new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 7, 0.0, 101, 0 }
                });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 5,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 54, "Описание ov205-c54", new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 37, "Описание ov206-c37", new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 7,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 76, "Описание ov207-c76", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 34, "Описание ov208-c34", new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 9,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 37, "Описание ov209-c37", new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "OrderCustomers",
                columns: new[] { "OrderCustomerId", "CustomerId", "Description", "Edited", "ExcelFileId", "Name" },
                values: new object[,]
                {
                    { 10, 80, "Описание ov2010-c80", new DateTime(2020, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2010" },
                    { 11, 62, "Описание ov2011-c62", new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2011" },
                    { 12, 54, "Описание ov2012-c54", new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2012" },
                    { 13, 50, "Описание ov2013-c50", new DateTime(2020, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2013" },
                    { 14, 26, "Описание ov2014-c26", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2014" },
                    { 16, 91, "Описание ov2016-c91", new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2016" },
                    { 17, 85, "Описание ov2017-c85", new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2017" },
                    { 18, 85, "Описание ov2018-c85", new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2018" },
                    { 19, 63, "Описание ov2019-c63", new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2019" },
                    { 21, 48, "Описание ov2021-c48", new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2021" },
                    { 22, 61, "Описание ov2022-c61", new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2022" },
                    { 23, 80, "Описание ov2023-c80", new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2023" },
                    { 24, 22, "Описание ov2024-c22", new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2024" },
                    { 25, 88, "Описание ov2025-c88", new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2025" },
                    { 26, 87, "Описание ov2026-c87", new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2026" },
                    { 28, 89, "Описание ov2028-c89", new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2028" },
                    { 29, 78, "Описание ov2029-c78", new DateTime(2020, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2029" },
                    { 30, 15, "Описание ov2030-c15", new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2030" },
                    { 31, 56, "Описание ov2031-c56", new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2031" },
                    { 32, 48, "Описание ov2032-c48", new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2032" },
                    { 34, 83, "Описание ov2034-c83", new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2034" },
                    { 35, 85, "Описание ov2035-c85", new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2035" },
                    { 36, 92, "Описание ov2036-c92", new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2036" },
                    { 38, 61, "Описание ov2038-c61", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2038" },
                    { 39, 66, "Описание ov2039-c66", new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2039" },
                    { 40, 46, "Описание ov2040-c46", new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2040" },
                    { 41, 49, "Описание ov2041-c49", new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2041" },
                    { 42, 32, "Описание ov2042-c32", new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2042" },
                    { 43, 63, "Описание ov2043-c63", new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2043" },
                    { 44, 19, "Описание ov2044-c19", new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2044" },
                    { 45, 17, "Описание ov2045-c17", new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2045" },
                    { 46, 39, "Описание ov2046-c39", new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2046" },
                    { 47, 32, "Описание ov2047-c32", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2047" }
                });

            migrationBuilder.InsertData(
                table: "OrderCustomers",
                columns: new[] { "OrderCustomerId", "CustomerId", "Description", "Edited", "ExcelFileId", "Name" },
                values: new object[,]
                {
                    { 48, 28, "Описание ov2048-c28", new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2048" },
                    { 49, 79, "Описание ov2049-c79", new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2049" },
                    { 50, 56, "Описание ov2050-c56", new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2050" },
                    { 51, 87, "Описание ov2051-c87", new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2051" },
                    { 52, 66, "Описание ov2052-c66", new DateTime(2020, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2052" },
                    { 53, 19, "Описание ov2053-c19", new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2053" },
                    { 54, 47, "Описание ov2054-c47", new DateTime(2020, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2054" },
                    { 55, 99, "Описание ov2055-c99", new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2055" },
                    { 56, 75, "Описание ov2056-c75", new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2056" },
                    { 57, 62, "Описание ov2057-c62", new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2057" },
                    { 58, 40, "Описание ov2058-c40", new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2058" },
                    { 59, 80, "Описание ov2059-c80", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2059" },
                    { 60, 39, "Описание ov2060-c39", new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2060" },
                    { 61, 62, "Описание ov2061-c62", new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2061" },
                    { 62, 23, "Описание ov2062-c23", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2062" },
                    { 63, 90, "Описание ov2063-c90", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2063" },
                    { 64, 99, "Описание ov2064-c99", new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2064" },
                    { 65, 63, "Описание ov2065-c63", new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2065" },
                    { 66, 64, "Описание ov2066-c64", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2066" },
                    { 67, 10, "Описание ov2067-c10", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2067" },
                    { 68, 15, "Описание ov2068-c15", new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2068" },
                    { 69, 22, "Описание ov2069-c22", new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2069" },
                    { 70, 40, "Описание ov2070-c40", new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2070" },
                    { 71, 37, "Описание ov2071-c37", new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2071" },
                    { 72, 34, "Описание ov2072-c34", new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2072" },
                    { 73, 91, "Описание ov2073-c91", new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2073" },
                    { 74, 72, "Описание ov2074-c72", new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2074" },
                    { 75, 93, "Описание ov2075-c93", new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2075" },
                    { 76, 67, "Описание ov2076-c67", new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2076" },
                    { 77, 43, "Описание ov2077-c43", new DateTime(2020, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2077" },
                    { 78, 66, "Описание ov2078-c66", new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2078" },
                    { 79, 48, "Описание ov2079-c48", new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2079" },
                    { 80, 20, "Описание ov2080-c20", new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2080" },
                    { 81, 21, "Описание ov2081-c21", new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2081" },
                    { 82, 11, "Описание ov2082-c11", new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2082" },
                    { 83, 91, "Описание ov2083-c91", new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2083" },
                    { 84, 41, "Описание ov2084-c41", new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2084" },
                    { 85, 24, "Описание ov2085-c24", new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2085" },
                    { 86, 60, "Описание ov2086-c60", new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2086" },
                    { 87, 22, "Описание ov2087-c22", new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2087" },
                    { 88, 32, "Описание ov2088-c32", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2088" },
                    { 89, 46, "Описание ov2089-c46", new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2089" }
                });

            migrationBuilder.InsertData(
                table: "OrderCustomers",
                columns: new[] { "OrderCustomerId", "CustomerId", "Description", "Edited", "ExcelFileId", "Name" },
                values: new object[,]
                {
                    { 90, 86, "Описание ov2090-c86", new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2090" },
                    { 91, 74, "Описание ov2091-c74", new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2091" },
                    { 92, 32, "Описание ov2092-c32", new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2092" },
                    { 93, 54, "Описание ov2093-c54", new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2093" },
                    { 94, 90, "Описание ov2094-c90", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2094" },
                    { 95, 17, "Описание ov2095-c17", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2095" },
                    { 96, 20, "Описание ov2096-c20", new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2096" },
                    { 97, 23, "Описание ov2097-c23", new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2097" },
                    { 98, 60, "Описание ov2098-c60", new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2098" },
                    { 99, 92, "Описание ov2099-c92", new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderVendor: 2099" }
                });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 2,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 402-60", new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 3,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 403-30", new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 4,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 404-58", new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 58 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 5,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 405-69", new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 69 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 6,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 406-97", new DateTime(2020, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 97 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 7,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 407-71", new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 71 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 8,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 408-76", new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 76 });

            migrationBuilder.InsertData(
                table: "OrderVendors",
                columns: new[] { "OrderVendorId", "Description", "Edited", "Name", "VendorId" },
                values: new object[,]
                {
                    { 10, "Описание 4010-39", new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4010", 39 },
                    { 11, "Описание 4011-90", new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4011", 90 },
                    { 12, "Описание 4012-94", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4012", 94 },
                    { 14, "Описание 4014-56", new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4014", 56 },
                    { 15, "Описание 4015-69", new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4015", 69 },
                    { 16, "Описание 4016-56", new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4016", 56 },
                    { 17, "Описание 4017-22", new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4017", 22 },
                    { 18, "Описание 4018-96", new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4018", 96 },
                    { 19, "Описание 4019-56", new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4019", 56 },
                    { 20, "Описание 4020-11", new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4020", 11 },
                    { 22, "Описание 4022-12", new DateTime(2020, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4022", 12 },
                    { 23, "Описание 4023-46", new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4023", 46 },
                    { 24, "Описание 4024-58", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4024", 58 },
                    { 25, "Описание 4025-28", new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4025", 28 },
                    { 26, "Описание 4026-48", new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4026", 48 },
                    { 27, "Описание 4027-75", new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4027", 75 },
                    { 28, "Описание 4028-19", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4028", 19 },
                    { 29, "Описание 4029-77", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4029", 77 },
                    { 30, "Описание 4030-16", new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4030", 16 },
                    { 31, "Описание 4031-40", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4031", 40 },
                    { 33, "Описание 4033-63", new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4033", 63 },
                    { 36, "Описание 4036-63", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4036", 63 },
                    { 38, "Описание 4038-96", new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4038", 96 },
                    { 39, "Описание 4039-75", new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4039", 75 },
                    { 40, "Описание 4040-92", new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4040", 92 }
                });

            migrationBuilder.InsertData(
                table: "OrderVendors",
                columns: new[] { "OrderVendorId", "Description", "Edited", "Name", "VendorId" },
                values: new object[,]
                {
                    { 41, "Описание 4041-67", new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4041", 67 },
                    { 43, "Описание 4043-96", new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4043", 96 },
                    { 44, "Описание 4044-82", new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4044", 82 },
                    { 45, "Описание 4045-20", new DateTime(2020, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4045", 20 },
                    { 46, "Описание 4046-53", new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4046", 53 },
                    { 47, "Описание 4047-77", new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4047", 77 },
                    { 48, "Описание 4048-21", new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4048", 21 },
                    { 49, "Описание 4049-99", new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4049", 99 },
                    { 50, "Описание 4050-28", new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4050", 28 },
                    { 51, "Описание 4051-42", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4051", 42 },
                    { 52, "Описание 4052-49", new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4052", 49 },
                    { 53, "Описание 4053-57", new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4053", 57 },
                    { 54, "Описание 4054-14", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4054", 14 },
                    { 55, "Описание 4055-41", new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4055", 41 },
                    { 56, "Описание 4056-50", new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4056", 50 },
                    { 58, "Описание 4058-43", new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4058", 43 },
                    { 59, "Описание 4059-78", new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4059", 78 },
                    { 60, "Описание 4060-47", new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4060", 47 },
                    { 61, "Описание 4061-43", new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4061", 43 },
                    { 62, "Описание 4062-38", new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4062", 38 },
                    { 63, "Описание 4063-61", new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4063", 61 },
                    { 64, "Описание 4064-85", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4064", 85 },
                    { 65, "Описание 4065-65", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4065", 65 },
                    { 66, "Описание 4066-89", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4066", 89 },
                    { 67, "Описание 4067-44", new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4067", 44 },
                    { 68, "Описание 4068-47", new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4068", 47 },
                    { 69, "Описание 4069-18", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4069", 18 },
                    { 70, "Описание 4070-15", new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4070", 15 },
                    { 71, "Описание 4071-16", new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4071", 16 },
                    { 72, "Описание 4072-92", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4072", 92 },
                    { 73, "Описание 4073-86", new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4073", 86 },
                    { 74, "Описание 4074-98", new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4074", 98 },
                    { 75, "Описание 4075-16", new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4075", 16 },
                    { 76, "Описание 4076-37", new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4076", 37 },
                    { 77, "Описание 4077-34", new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4077", 34 },
                    { 78, "Описание 4078-37", new DateTime(2020, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4078", 37 },
                    { 80, "Описание 4080-90", new DateTime(2020, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4080", 90 },
                    { 81, "Описание 4081-46", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4081", 46 },
                    { 82, "Описание 4082-77", new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4082", 77 },
                    { 83, "Описание 4083-27", new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4083", 27 },
                    { 84, "Описание 4084-49", new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4084", 49 },
                    { 85, "Описание 4085-65", new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4085", 65 }
                });

            migrationBuilder.InsertData(
                table: "OrderVendors",
                columns: new[] { "OrderVendorId", "Description", "Edited", "Name", "VendorId" },
                values: new object[,]
                {
                    { 86, "Описание 4086-57", new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4086", 57 },
                    { 87, "Описание 4087-72", new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4087", 72 },
                    { 89, "Описание 4089-58", new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4089", 58 },
                    { 90, "Описание 4090-75", new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4090", 75 },
                    { 91, "Описание 4091-18", new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4091", 18 },
                    { 92, "Описание 4092-28", new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4092", 28 },
                    { 93, "Описание 4093-30", new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4093", 30 },
                    { 94, "Описание 4094-42", new DateTime(2020, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4094", 42 },
                    { 95, "Описание 4095-99", new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4095", 99 },
                    { 96, "Описание 4096-35", new DateTime(2020, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4096", 35 },
                    { 97, "Описание 4097-63", new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4097", 63 },
                    { 98, "Описание 4098-20", new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderVendor: 4098", 20 }
                });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 7,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId" },
                values: new object[] { "Опиасние oc2072-io307-ov4017 p10052", new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 17, 52 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 8,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId" },
                values: new object[] { "Опиасние oc2098-io308-ov4091 p100323", new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 91, 323 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 9,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId" },
                values: new object[] { "Опиасние oc2087-io309-ov4025 p100294", new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 25, 294 });

            migrationBuilder.InsertData(
                table: "ItemOrders",
                columns: new[] { "ItemOrderId", "Description", "Edited", "OrderCustomerId", "OrderVendorId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 10, "Опиасние oc2061-io3010-ov4062 p100308", new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 62, 0.0, 308, 0 },
                    { 11, "Опиасние oc2051-io3011-ov4051 p100503", new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 51, 0.0, 503, 0 },
                    { 12, "Опиасние oc2040-io3012-ov4099 p100397", new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 99, 0.0, 397, 0 },
                    { 13, "Опиасние oc2043-io3013-ov4031 p100489", new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 31, 0.0, 489, 0 },
                    { 14, "Опиасние oc2022-io3014-ov4023 p100323", new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 23, 0.0, 323, 0 },
                    { 15, "Опиасние oc2045-io3015-ov4072 p10083", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 72, 0.0, 83, 0 },
                    { 16, "Опиасние oc2072-io3016-ov4040 p100322", new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 40, 0.0, 322, 0 },
                    { 17, "Опиасние oc2055-io3017-ov4097 p100440", new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 97, 0.0, 440, 0 },
                    { 18, "Опиасние oc2091-io3018-ov4040 p100224", new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 40, 0.0, 224, 0 },
                    { 19, "Опиасние oc2085-io3019-ov406 p100184", new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 6, 0.0, 184, 0 },
                    { 20, "Опиасние oc2072-io3020-ov4050 p100441", new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 50, 0.0, 441, 0 },
                    { 21, "Опиасние oc2085-io3021-ov4030 p100123", new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 30, 0.0, 123, 0 },
                    { 22, "Опиасние oc2058-io3022-ov4022 p100283", new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 22, 0.0, 283, 0 },
                    { 23, "Опиасние oc2099-io3023-ov4086 p100400", new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 86, 0.0, 400, 0 },
                    { 24, "Опиасние oc2028-io3024-ov4078 p10011", new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 78, 0.0, 11, 0 },
                    { 25, "Опиасние oc2058-io3025-ov4043 p100495", new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 43, 0.0, 495, 0 },
                    { 27, "Опиасние oc2010-io3027-ov4070 p100227", new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 70, 0.0, 227, 0 },
                    { 28, "Опиасние oc2091-io3028-ov4016 p10089", new DateTime(2020, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 16, 0.0, 89, 0 },
                    { 29, "Опиасние oc2090-io3029-ov4017 p100203", new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 17, 0.0, 203, 0 },
                    { 30, "Опиасние oc2049-io3030-ov4012 p10084", new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 12, 0.0, 84, 0 },
                    { 31, "Опиасние oc2090-io3031-ov405 p100188", new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 5, 0.0, 188, 0 },
                    { 32, "Опиасние oc2011-io3032-ov4083 p10097", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 83, 0.0, 97, 0 },
                    { 33, "Опиасние oc2058-io3033-ov4081 p100232", new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 81, 0.0, 232, 0 },
                    { 34, "Опиасние oc2061-io3034-ov4050 p100277", new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 50, 0.0, 277, 0 },
                    { 35, "Опиасние oc2045-io3035-ov4010 p1002", new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 10, 0.0, 2, 0 },
                    { 36, "Опиасние oc2085-io3036-ov4063 p100334", new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 63, 0.0, 334, 0 },
                    { 37, "Опиасние oc2058-io3037-ov4014 p100325", new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 14, 0.0, 325, 0 },
                    { 38, "Опиасние oc2063-io3038-ov4064 p1004", new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 64, 0.0, 4, 0 },
                    { 39, "Опиасние oc206-io3039-ov4060 p100545", new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 60, 0.0, 545, 0 },
                    { 40, "Опиасние oc2041-io3040-ov4022 p100467", new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 22, 0.0, 467, 0 },
                    { 41, "Опиасние oc2036-io3041-ov4096 p100483", new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 96, 0.0, 483, 0 },
                    { 42, "Опиасние oc2051-io3042-ov4094 p10072", new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 94, 0.0, 72, 0 },
                    { 43, "Опиасние oc2090-io3043-ov4070 p100480", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 70, 0.0, 480, 0 },
                    { 44, "Опиасние oc2022-io3044-ov4043 p100284", new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 43, 0.0, 284, 0 },
                    { 45, "Опиасние oc2087-io3045-ov4086 p100146", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 86, 0.0, 146, 0 },
                    { 47, "Опиасние oc2011-io3047-ov4054 p100349", new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 54, 0.0, 349, 0 },
                    { 48, "Опиасние oc2066-io3048-ov4016 p100470", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 16, 0.0, 470, 0 },
                    { 49, "Опиасние oc2030-io3049-ov4016 p100174", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 16, 0.0, 174, 0 },
                    { 50, "Опиасние oc2038-io3050-ov4014 p100330", new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 14, 0.0, 330, 0 }
                });

            migrationBuilder.InsertData(
                table: "ItemOrders",
                columns: new[] { "ItemOrderId", "Description", "Edited", "OrderCustomerId", "OrderVendorId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 51, "Опиасние oc2071-io3051-ov4083 p100479", new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 83, 0.0, 479, 0 },
                    { 52, "Опиасние oc2020-io3052-ov4098 p100464", new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 98, 0.0, 464, 0 },
                    { 54, "Опиасние oc2058-io3054-ov4086 p10029", new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 86, 0.0, 29, 0 },
                    { 55, "Опиасние oc2081-io3055-ov4065 p100549", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 65, 0.0, 549, 0 },
                    { 56, "Опиасние oc2084-io3056-ov4051 p100109", new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 51, 0.0, 109, 0 },
                    { 57, "Опиасние oc205-io3057-ov4011 p100230", new DateTime(2020, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 11, 0.0, 230, 0 },
                    { 58, "Опиасние oc2012-io3058-ov401 p100399", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 1, 0.0, 399, 0 },
                    { 59, "Опиасние oc2076-io3059-ov4044 p100384", new DateTime(2020, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, 44, 0.0, 384, 0 },
                    { 60, "Опиасние oc206-io3060-ov4071 p100441", new DateTime(2020, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 71, 0.0, 441, 0 },
                    { 61, "Опиасние oc2041-io3061-ov4099 p100487", new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 99, 0.0, 487, 0 },
                    { 62, "Опиасние oc2011-io3062-ov4042 p100542", new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 42, 0.0, 542, 0 },
                    { 64, "Опиасние oc2091-io3064-ov4045 p100270", new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 45, 0.0, 270, 0 },
                    { 65, "Опиасние oc2077-io3065-ov4080 p100389", new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 80, 0.0, 389, 0 },
                    { 66, "Опиасние oc2032-io3066-ov4043 p100283", new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 43, 0.0, 283, 0 },
                    { 67, "Опиасние oc2015-io3067-ov4094 p100239", new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 94, 0.0, 239, 0 },
                    { 68, "Опиасние oc2031-io3068-ov4030 p100392", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 30, 0.0, 392, 0 },
                    { 70, "Опиасние oc2088-io3070-ov403 p100408", new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 3, 0.0, 408, 0 },
                    { 71, "Опиасние oc2033-io3071-ov4077 p100100", new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 77, 0.0, 100, 0 },
                    { 72, "Опиасние oc2071-io3072-ov4071 p100487", new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 71, 0.0, 487, 0 },
                    { 73, "Опиасние oc2030-io3073-ov4059 p100542", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 59, 0.0, 542, 0 },
                    { 74, "Опиасние oc209-io3074-ov4061 p10086", new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 61, 0.0, 86, 0 },
                    { 75, "Опиасние oc2064-io3075-ov4032 p100367", new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 32, 0.0, 367, 0 },
                    { 76, "Опиасние oc2049-io3076-ov4037 p100442", new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 37, 0.0, 442, 0 },
                    { 77, "Опиасние oc202-io3077-ov4084 p100449", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 84, 0.0, 449, 0 },
                    { 78, "Опиасние oc2029-io3078-ov4098 p10078", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 98, 0.0, 78, 0 },
                    { 79, "Опиасние oc2044-io3079-ov4012 p100165", new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 12, 0.0, 165, 0 },
                    { 80, "Опиасние oc2065-io3080-ov4020 p100318", new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 20, 0.0, 318, 0 },
                    { 81, "Опиасние oc2085-io3081-ov405 p100473", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 5, 0.0, 473, 0 },
                    { 82, "Опиасние oc2038-io3082-ov4087 p100187", new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 87, 0.0, 187, 0 },
                    { 83, "Опиасние oc2053-io3083-ov4087 p100428", new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 87, 0.0, 428, 0 },
                    { 84, "Опиасние oc2073-io3084-ov4079 p10076", new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 79, 0.0, 76, 0 },
                    { 85, "Опиасние oc2048-io3085-ov4035 p100125", new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 35, 0.0, 125, 0 },
                    { 86, "Опиасние oc2079-io3086-ov4013 p100224", new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 13, 0.0, 224, 0 },
                    { 87, "Опиасние oc2020-io3087-ov4070 p100395", new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 70, 0.0, 395, 0 },
                    { 88, "Опиасние oc2087-io3088-ov401 p100527", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 1, 0.0, 527, 0 },
                    { 89, "Опиасние oc2092-io3089-ov4046 p100490", new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 46, 0.0, 490, 0 },
                    { 90, "Опиасние oc2054-io3090-ov4087 p100271", new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 87, 0.0, 271, 0 },
                    { 91, "Опиасние oc2080-io3091-ov4016 p100434", new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 16, 0.0, 434, 0 },
                    { 92, "Опиасние oc2019-io3092-ov4014 p100408", new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 14, 0.0, 408, 0 },
                    { 93, "Опиасние oc2025-io3093-ov4091 p100504", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 91, 0.0, 504, 0 },
                    { 94, "Опиасние oc2044-io3094-ov4051 p100448", new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 51, 0.0, 448, 0 },
                    { 95, "Опиасние oc2039-io3095-ov4070 p100343", new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 70, 0.0, 343, 0 }
                });

            migrationBuilder.InsertData(
                table: "ItemOrders",
                columns: new[] { "ItemOrderId", "Description", "Edited", "OrderCustomerId", "OrderVendorId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 96, "Опиасние oc2035-io3096-ov4098 p100371", new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 98, 0.0, 371, 0 },
                    { 97, "Опиасние oc2033-io3097-ov4030 p100513", new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 30, 0.0, 513, 0 },
                    { 98, "Опиасние oc2045-io3098-ov4036 p10095", new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 36, 0.0, 95, 0 },
                    { 99, "Опиасние oc2056-io3099-ov4029 p100290", new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 29, 0.0, 290, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 96);

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 2,
                column: "Edited",
                value: new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 3,
                column: "Edited",
                value: new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 4,
                column: "Edited",
                value: new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 5,
                column: "Edited",
                value: new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 6,
                column: "Edited",
                value: new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 7,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId" },
                values: new object[] { "Опиасние oc205-io307-ov406 p1008", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 6, 8 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 8,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId" },
                values: new object[] { "Опиасние oc209-io308-ov402 p1006", new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, 6 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 9,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId" },
                values: new object[] { "Опиасние oc201-io309-ov408 p1001", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, 1 });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 2,
                column: "Edited",
                value: new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 3,
                column: "Edited",
                value: new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 4,
                column: "Edited",
                value: new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 5,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 9, "Описание ov205-c9", new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 7, "Описание ov206-c7", new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 7,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 4, "Описание ov207-c4", new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 6, "Описание ov208-c6", new DateTime(2020, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 9,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 8, "Описание ov209-c8", new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 6, 19, 13, 57, 721, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 2,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 402-7", new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 3,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 403-5", new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 4,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 404-9", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 5,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 405-4", new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 6,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 406-3", new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 7,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 407-2", new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 8,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 408-9", new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 9,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 409-8", new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 2,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p502-1", null });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 3,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p503-8", null });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 4,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p504-9", null });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 5,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p505-7", null });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 6,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p506-3", null });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 7,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p507-6", null });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 8,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p508-4", null });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 9,
                columns: new[] { "Description", "Phone" },
                values: new object[] { "Описание p509-2", null });
        }
    }
}

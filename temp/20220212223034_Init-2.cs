using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 13, 1, 30, 33, 63, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 2,
                column: "Edited",
                value: new DateTime(2022, 2, 13, 1, 30, 33, 63, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 3,
                column: "Edited",
                value: new DateTime(2022, 2, 13, 1, 30, 33, 63, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 4,
                column: "Edited",
                value: new DateTime(2022, 2, 13, 1, 30, 33, 63, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 5,
                column: "Edited",
                value: new DateTime(2022, 2, 13, 1, 30, 33, 63, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 6,
                column: "Edited",
                value: new DateTime(2022, 2, 13, 1, 30, 33, 63, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 7,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2070-io307-ov4020 p100360", new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 20, 360, 244 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 8,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2096-io308-ov4071 p100367", new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 71, 367, 422 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 9,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2092-io309-ov4016 p100403", new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 16, 403, 123 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 10,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2027-io3010-ov4031 p100273", new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 31, 273, 482 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 11,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2060-io3011-ov4021 p100301", new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 21, 301, 452 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 12,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2026-io3012-ov4041 p100405", new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 41, 405, 392 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 13,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2078-io3013-ov4028 p100145", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 28, 145, 260 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 14,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2080-io3014-ov4050 p100114", new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 50, 114, 167 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 15,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2093-io3015-ov4080 p100120", new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 80, 120, 405 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 16,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2078-io3016-ov4018 p100163", new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 18, 163, 246 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 17,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2059-io3017-ov4097 p10068", new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 97, 68, 107 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 18,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2093-io3018-ov4049 p100179", new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 49, 179, 113 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 19,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2073-io3019-ov4046 p100250", new DateTime(2020, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 46, 250, 472 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 20,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2040-io3020-ov4058 p100227", new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 58, 227, 476 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 21,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2089-io3021-ov4081 p100341", new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 81, 341, 200 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 22,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2077-io3022-ov4010 p100129", new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 10, 129, 190 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 23,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2067-io3023-ov4070 p100204", new DateTime(2020, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 70, 204, 323 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 24,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2062-io3024-ov4037 p100291", new DateTime(2020, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, 37, 291, 396 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 25,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2092-io3025-ov4036 p100271", new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 36, 271, 108 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 26,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2035-io3026-ov4044 p10097", new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 44, 97, 362 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 27,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2091-io3027-ov4020 p100389", new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 20, 389, 346 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 28,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2068-io3028-ov4058 p100415", new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 58, 415, 265 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 29,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc201-io3029-ov4036 p100323", new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 36, 323, 207 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 30,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2082-io3030-ov4097 p100285", new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 97, 285, 171 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 31,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc204-io3031-ov4022 p100481", new DateTime(2020, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 22, 481, 289 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 32,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2092-io3032-ov4063 p10047", new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 63, 47, 131 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 33,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc209-io3033-ov4047 p100340", new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 47, 340, 288 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 34,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2039-io3034-ov4019 p10021", new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 19, 21, 330 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 35,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2036-io3035-ov4021 p100432", new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 21, 432, 320 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 36,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2035-io3036-ov4098 p100313", new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 98, 313, 120 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 37,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2042-io3037-ov408 p100310", new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 8, 310, 453 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 38,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2030-io3038-ov4032 p100139", new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 32, 139, 170 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 39,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2045-io3039-ov4019 p100358", new DateTime(2020, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 19, 358, 393 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 40,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2074-io3040-ov4013 p100138", new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 13, 138, 159 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 41,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2096-io3041-ov4062 p100185", new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 62, 185, 169 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 42,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2058-io3042-ov4066 p100209", new DateTime(2020, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 66, 209, 455 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 43,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2094-io3043-ov4029 p10077", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 29, 77, 282 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 44,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2025-io3044-ov4013 p100449", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 13, 449, 293 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 45,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2039-io3045-ov4062 p100499", new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 62, 499, 463 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 46,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2028-io3046-ov4010 p100110", new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 10, 110, 362 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 47,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2049-io3047-ov4033 p100176", new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 33, 176, 409 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 48,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2014-io3048-ov4073 p100416", new DateTime(2020, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 73, 416, 146 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 49,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2050-io3049-ov408 p100376", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 8, 376, 193 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 50,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2016-io3050-ov4031 p100283", new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 31, 283, 274 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 51,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2065-io3051-ov4091 p100226", new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 91, 226, 287 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 52,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2035-io3052-ov4017 p100313", new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 17, 313, 482 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 53,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2054-io3053-ov4080 p1008", new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 80, 8, 249 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 54,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2020-io3054-ov4088 p10031", new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 88, 31, 156 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 55,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2096-io3055-ov409 p100218", new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 9, 218, 186 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 56,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2086-io3056-ov4018 p100253", new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, 18, 253, 150 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 57,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2034-io3057-ov4088 p100340", new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 88, 340, 431 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 58,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2028-io3058-ov4049 p100280", new DateTime(2020, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 49, 280, 341 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 59,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2025-io3059-ov4089 p10062", new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 89, 62, 105 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 60,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2056-io3060-ov4043 p100478", new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 43, 478, 375 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 61,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2055-io3061-ov4098 p10092", new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 98, 92, 289 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 62,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2087-io3062-ov4091 p100159", new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 91, 159, 332 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 63,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2045-io3063-ov4029 p100143", new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 29, 143, 369 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 64,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2062-io3064-ov4042 p100241", new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, 42, 241, 370 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 65,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2015-io3065-ov4028 p100118", new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 28, 118, 233 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 66,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2053-io3066-ov405 p100446", new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 5, 446, 470 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 67,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2097-io3067-ov4062 p100241", new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 62, 241, 410 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 68,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2052-io3068-ov4029 p100131", new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 29, 131, 482 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 69,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2099-io3069-ov4024 p10064", new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 24, 64, 116 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 70,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2051-io3070-ov4029 p100392", new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 29, 392, 339 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 71,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2084-io3071-ov4053 p1005", new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 53, 5, 188 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 72,
                columns: new[] { "Description", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2053-io3072-ov408 p100407", 53, 8, 407, 304 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 73,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2096-io3073-ov4041 p100173", new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 41, 173, 433 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 74,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2091-io3074-ov403 p100237", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 3, 237, 123 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 75,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2022-io3075-ov4050 p100424", new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 50, 424, 374 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 76,
                columns: new[] { "Description", "Edited", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc204-io3076-ov4082 p10089", new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 89, 155 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 77,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2045-io3077-ov4054 p100360", new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 54, 360, 209 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 78,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2062-io3078-ov4055 p100460", new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, 55, 460, 323 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 79,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2014-io3079-ov4050 p100173", new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 50, 173, 399 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 80,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2064-io3080-ov4065 p100214", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 65, 214, 233 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 81,
                columns: new[] { "Description", "Edited", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2080-io3081-ov4067 p100242", new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 242, 236 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 82,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2051-io3082-ov4094 p100374", new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 94, 374, 491 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 83,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2094-io3083-ov4060 p100479", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 60, 479, 147 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 84,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2040-io3084-ov4013 p100173", new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 13, 173, 449 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 85,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2080-io3085-ov4070 p10025", new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 70, 25, 402 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 86,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2028-io3086-ov4086 p100282", new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 86, 282, 334 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 87,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2068-io3087-ov4011 p100446", new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 11, 446, 430 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 88,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc204-io3088-ov4043 p10078", new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 43, 78, 121 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 89,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2021-io3089-ov4071 p10099", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 71, 99, 427 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 90,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2065-io3090-ov4013 p1009", new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 13, 9, 313 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 91,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2027-io3091-ov4017 p100125", new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 17, 125, 149 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 92,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2073-io3092-ov4079 p100158", new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 79, 158, 386 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 93,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2079-io3093-ov4078 p100401", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 78, 401, 149 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 94,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2058-io3094-ov4032 p100111", new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 32, 111, 479 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 95,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2055-io3095-ov4016 p100415", new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 16, 415, 342 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 96,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2066-io3096-ov4053 p100414", new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 53, 414, 392 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 97,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2034-io3097-ov4071 p100477", new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 71, 477, 470 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 98,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2020-io3098-ov4045 p10059", new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 45, 59, 301 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 99,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2026-io3099-ov4033 p100291", new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 33, 291, 358 });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 13, 1, 30, 33, 63, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 2,
                column: "Edited",
                value: new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 3,
                column: "Edited",
                value: new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 4,
                column: "Edited",
                value: new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 5,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 7, "Описание ov205-c7", new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 2, "Описание ov206-c2", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 7,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 98, "Описание ov207-c98", new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 67, "Описание ov208-c67", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 9,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 91, "Описание ov209-c91", new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 10,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 89, "Описание ov2010-c89", new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 11,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 28, "Описание ov2011-c28", new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 12,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 6, "Описание ov2012-c6", new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 13,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 41, "Описание ov2013-c41", new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 14,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 44, "Описание ov2014-c44", new DateTime(2020, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 15,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 39, "Описание ov2015-c39", new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 16,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 93, "Описание ov2016-c93", new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 17,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 88, "Описание ov2017-c88", new DateTime(2020, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 18,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 80, "Описание ov2018-c80", new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 19,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 73, "Описание ov2019-c73", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 20,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 77, "Описание ov2020-c77", new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 21,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 71, "Описание ov2021-c71", new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 22,
                column: "Edited",
                value: new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 23,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 47, "Описание ov2023-c47", new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 24,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 8, "Описание ov2024-c8", new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 25,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 22, "Описание ov2025-c22", new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 26,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 64, "Описание ov2026-c64", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 27,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 27, "Описание ov2027-c27", new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 28,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 3, "Описание ov2028-c3", new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 29,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 77, "Описание ov2029-c77", new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 30,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 1, "Описание ov2030-c1", new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 31,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 49, "Описание ov2031-c49", new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 32,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 17, "Описание ov2032-c17", new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 33,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 94, "Описание ov2033-c94", new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 34,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 88, "Описание ov2034-c88", new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 35,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 56, "Описание ov2035-c56", new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 36,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 8, "Описание ov2036-c8", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 37,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 15, "Описание ov2037-c15", new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 38,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 31, "Описание ov2038-c31", new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 39,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 25, "Описание ov2039-c25", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 40,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 45, "Описание ov2040-c45", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 41,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 40, "Описание ov2041-c40", new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 42,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 71, "Описание ov2042-c71", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 43,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 2, "Описание ov2043-c2", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 44,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 83, "Описание ov2044-c83", new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 45,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 85, "Описание ov2045-c85", new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 46,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 84, "Описание ov2046-c84", new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 47,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 63, "Описание ov2047-c63", new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 48,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 96, "Описание ov2048-c96", new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 49,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 52, "Описание ov2049-c52", new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 50,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 37, "Описание ov2050-c37", new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 51,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 80, "Описание ov2051-c80", new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 52,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 78, "Описание ov2052-c78", new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 53,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 70, "Описание ov2053-c70", new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 54,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 71, "Описание ov2054-c71", new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 55,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 3, "Описание ov2055-c3", new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 56,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 88, "Описание ov2056-c88", new DateTime(2020, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 57,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 30, "Описание ov2057-c30", new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 58,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 4, "Описание ov2058-c4", new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 59,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 73, "Описание ov2059-c73", new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 60,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 79, "Описание ov2060-c79", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 61,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 57, "Описание ov2061-c57", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 62,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 90, "Описание ov2062-c90", new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 63,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 93, "Описание ov2063-c93", new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 64,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 55, "Описание ov2064-c55", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 65,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 99, "Описание ov2065-c99", new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 66,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 61, "Описание ov2066-c61", new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 67,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 63, "Описание ov2067-c63", new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 68,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 68, "Описание ov2068-c68", new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 69,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 24, "Описание ov2069-c24", new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 70,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 34, "Описание ov2070-c34", new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 71,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 83, "Описание ov2071-c83", new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 72,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 49, "Описание ov2072-c49", new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 73,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 27, "Описание ov2073-c27", new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 74,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 19, "Описание ov2074-c19", new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 75,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 56, "Описание ov2075-c56", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 76,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 84, "Описание ov2076-c84", new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 77,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 67, "Описание ov2077-c67", new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 78,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 46, "Описание ov2078-c46", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 79,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 98, "Описание ov2079-c98", new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 80,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 11, "Описание ov2080-c11", new DateTime(2020, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 81,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 32, "Описание ov2081-c32", new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 82,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 71, "Описание ov2082-c71", new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 83,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 66, "Описание ov2083-c66", new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 84,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 36, "Описание ov2084-c36", new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 85,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 49, "Описание ov2085-c49", new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 86,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 78, "Описание ov2086-c78", new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 87,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 47, "Описание ov2087-c47", new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 88,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 50, "Описание ov2088-c50", new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 89,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 73, "Описание ov2089-c73", new DateTime(2020, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 90,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 13, "Описание ov2090-c13", new DateTime(2020, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 91,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 76, "Описание ov2091-c76", new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 92,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 14, "Описание ov2092-c14", new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 93,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 42, "Описание ov2093-c42", new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 94,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 38, "Описание ov2094-c38", new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 95,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 78, "Описание ov2095-c78", new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 96,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 93, "Описание ov2096-c93", new DateTime(2020, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 97,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 50, "Описание ov2097-c50", new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 98,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 73, "Описание ov2098-c73", new DateTime(2020, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 99,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 75, "Описание ov2099-c75", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 13, 1, 30, 33, 63, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 2,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 402-85", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 85 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 3,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 403-90", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 90 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 4,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 404-28", new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 5,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 405-78", new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 78 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 6,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 406-11", new DateTime(2020, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 7,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 407-68", new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 68 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 8,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 408-10", new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 9,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 409-96", new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 96 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 10,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4010-22", new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 11,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4011-66", new DateTime(2020, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 66 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 12,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4012-6", new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 13,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4013-69", new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 69 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 14,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4014-68", new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 68 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 15,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4015-10", new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 16,
                column: "Edited",
                value: new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 17,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4017-21", new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 18,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4018-55", new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 19,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4019-28", new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 20,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4020-80", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 80 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 21,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4021-28", new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 22,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4022-77", new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 77 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 23,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4023-76", new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 76 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 24,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4024-4", new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 25,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4025-35", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 26,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4026-32", new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 27,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4027-85", new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 85 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 28,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4028-47", new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 29,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4029-61", new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 61 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 30,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4030-38", new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 31,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4031-47", new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 32,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4032-49", new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 33,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4033-66", new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 66 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 34,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4034-70", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 35,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4035-93", new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 93 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 36,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4036-85", new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 85 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 37,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4037-76", new DateTime(2020, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 76 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 38,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4038-51", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 39,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4039-30", new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 40,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4040-51", new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 41,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4041-10", new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 42,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4042-68", new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 68 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 43,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4043-70", new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 44,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4044-29", new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 45,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4045-25", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 46,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4046-85", new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 85 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 47,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4047-93", new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 93 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 48,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4048-26", new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 49,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4049-12", new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 50,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4050-4", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 51,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4051-55", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 52,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4052-46", new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 53,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4053-64", new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 64 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 54,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4054-22", new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 55,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4055-17", new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 56,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4056-50", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 57,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4057-81", new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 81 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 58,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4058-61", new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 61 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 59,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4059-35", new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 60,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4060-82", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 82 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 61,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4061-61", new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 61 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 62,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4062-6", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 63,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4063-69", new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 69 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 64,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4064-96", new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 96 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 65,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4065-55", new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 66,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4066-80", new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 80 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 67,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4067-32", new DateTime(2020, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 68,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4068-77", new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 77 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 69,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4069-17", new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 70,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4070-86", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 86 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 71,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4071-31", new DateTime(2020, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 72,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4072-75", new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 75 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 73,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4073-46", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 74,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4074-75", new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 75 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 75,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4075-79", new DateTime(2020, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 79 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 76,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4076-20", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 77,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4077-28", new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 78,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4078-56", new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 56 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 79,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4079-47", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 80,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4080-91", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 91 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 81,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4081-74", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 74 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 82,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4082-58", new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 58 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 83,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4083-36", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 84,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4084-94", new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 94 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 85,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4085-91", new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 91 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 86,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4086-48", new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 87,
                column: "Edited",
                value: new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 88,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4088-46", new DateTime(2020, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 89,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4089-43", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 90,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4090-83", new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 83 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 91,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4091-97", new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 97 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 92,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4092-64", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 64 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 93,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4093-55", new DateTime(2020, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 94,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4094-97", new DateTime(2020, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 97 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 95,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4095-65", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 96,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4096-25", new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 97,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4097-75", new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 75 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 98,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4098-74", new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 74 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 99,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4099-15", new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 2,
                column: "Description",
                value: "Описание p502-12");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 3,
                column: "Description",
                value: "Описание p503-74");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 4,
                column: "Description",
                value: "Описание p504-35");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 5,
                column: "Description",
                value: "Описание p505-62");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 6,
                column: "Description",
                value: "Описание p506-5");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 7,
                column: "Description",
                value: "Описание p507-66");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 8,
                column: "Description",
                value: "Описание p508-91");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 9,
                column: "Description",
                value: "Описание p509-32");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 10,
                column: "Description",
                value: "Описание p5010-48");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 11,
                column: "Description",
                value: "Описание p5011-36");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 12,
                column: "Description",
                value: "Описание p5012-94");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 13,
                column: "Description",
                value: "Описание p5013-67");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 14,
                column: "Description",
                value: "Описание p5014-94");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 15,
                column: "Description",
                value: "Описание p5015-27");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 16,
                column: "Description",
                value: "Описание p5016-34");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 17,
                column: "Description",
                value: "Описание p5017-11");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 18,
                column: "Description",
                value: "Описание p5018-10");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 19,
                column: "Description",
                value: "Описание p5019-39");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 20,
                column: "Description",
                value: "Описание p5020-36");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 21,
                column: "Description",
                value: "Описание p5021-7");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 22,
                column: "Description",
                value: "Описание p5022-15");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 23,
                column: "Description",
                value: "Описание p5023-30");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 24,
                column: "Description",
                value: "Описание p5024-24");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 25,
                column: "Description",
                value: "Описание p5025-72");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 26,
                column: "Description",
                value: "Описание p5026-60");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 27,
                column: "Description",
                value: "Описание p5027-21");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 28,
                column: "Description",
                value: "Описание p5028-48");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 29,
                column: "Description",
                value: "Описание p5029-79");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 30,
                column: "Description",
                value: "Описание p5030-18");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 31,
                column: "Description",
                value: "Описание p5031-31");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 32,
                column: "Description",
                value: "Описание p5032-16");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 33,
                column: "Description",
                value: "Описание p5033-87");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 34,
                column: "Description",
                value: "Описание p5034-82");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 35,
                column: "Description",
                value: "Описание p5035-17");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 36,
                column: "Description",
                value: "Описание p5036-13");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 37,
                column: "Description",
                value: "Описание p5037-23");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 38,
                column: "Description",
                value: "Описание p5038-30");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 39,
                column: "Description",
                value: "Описание p5039-65");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 40,
                column: "Description",
                value: "Описание p5040-74");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 41,
                column: "Description",
                value: "Описание p5041-40");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 42,
                column: "Description",
                value: "Описание p5042-95");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 43,
                column: "Description",
                value: "Описание p5043-44");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 44,
                column: "Description",
                value: "Описание p5044-58");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 45,
                column: "Description",
                value: "Описание p5045-85");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 46,
                column: "Description",
                value: "Описание p5046-48");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 47,
                column: "Description",
                value: "Описание p5047-44");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 48,
                column: "Description",
                value: "Описание p5048-42");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 49,
                column: "Description",
                value: "Описание p5049-36");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 50,
                column: "Description",
                value: "Описание p5050-20");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 51,
                column: "Description",
                value: "Описание p5051-67");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 52,
                column: "Description",
                value: "Описание p5052-83");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 53,
                column: "Description",
                value: "Описание p5053-46");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 54,
                column: "Description",
                value: "Описание p5054-25");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 55,
                column: "Description",
                value: "Описание p5055-5");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 56,
                column: "Description",
                value: "Описание p5056-92");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 57,
                column: "Description",
                value: "Описание p5057-93");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 58,
                column: "Description",
                value: "Описание p5058-17");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 59,
                column: "Description",
                value: "Описание p5059-16");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 60,
                column: "Description",
                value: "Описание p5060-67");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 61,
                column: "Description",
                value: "Описание p5061-53");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 62,
                column: "Description",
                value: "Описание p5062-48");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 63,
                column: "Description",
                value: "Описание p5063-4");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 64,
                column: "Description",
                value: "Описание p5064-12");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 65,
                column: "Description",
                value: "Описание p5065-1");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 66,
                column: "Description",
                value: "Описание p5066-16");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 67,
                column: "Description",
                value: "Описание p5067-25");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 68,
                column: "Description",
                value: "Описание p5068-32");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 69,
                column: "Description",
                value: "Описание p5069-28");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 70,
                column: "Description",
                value: "Описание p5070-1");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 71,
                column: "Description",
                value: "Описание p5071-96");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 72,
                column: "Description",
                value: "Описание p5072-58");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 73,
                column: "Description",
                value: "Описание p5073-94");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 74,
                column: "Description",
                value: "Описание p5074-38");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 75,
                column: "Description",
                value: "Описание p5075-62");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 76,
                column: "Description",
                value: "Описание p5076-20");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 77,
                column: "Description",
                value: "Описание p5077-39");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 78,
                column: "Description",
                value: "Описание p5078-32");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 79,
                column: "Description",
                value: "Описание p5079-63");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 80,
                column: "Description",
                value: "Описание p5080-32");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 81,
                column: "Description",
                value: "Описание p5081-30");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 82,
                column: "Description",
                value: "Описание p5082-98");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 83,
                column: "Description",
                value: "Описание p5083-39");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 84,
                column: "Description",
                value: "Описание p5084-94");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 85,
                column: "Description",
                value: "Описание p5085-21");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 86,
                column: "Description",
                value: "Описание p5086-94");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 87,
                column: "Description",
                value: "Описание p5087-60");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 88,
                column: "Description",
                value: "Описание p5088-37");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 89,
                column: "Description",
                value: "Описание p5089-5");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 90,
                column: "Description",
                value: "Описание p5090-24");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 91,
                column: "Description",
                value: "Описание p5091-9");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 92,
                column: "Description",
                value: "Описание p5092-86");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 93,
                column: "Description",
                value: "Описание p5093-11");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 94,
                column: "Description",
                value: "Описание p5094-92");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 95,
                column: "Description",
                value: "Описание p5095-81");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 96,
                column: "Description",
                value: "Описание p5096-96");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 97,
                column: "Description",
                value: "Описание p5097-32");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 98,
                column: "Description",
                value: "Описание p5098-43");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 99,
                column: "Description",
                value: "Описание p5099-45");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 2,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 3,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 4,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 5,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 6,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 7,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2068-io307-ov4012 p100391", new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 12, 391, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 8,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2057-io308-ov4056 p10064", new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 56, 64, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 9,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2020-io309-ov4040 p100318", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 40, 318, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 10,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2039-io3010-ov4090 p10074", new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 90, 74, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 11,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2088-io3011-ov4031 p100323", new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 31, 323, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 12,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2082-io3012-ov4081 p100425", new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 81, 425, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 13,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2077-io3013-ov4084 p100425", new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 84, 425, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 14,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2095-io3014-ov4073 p100107", new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 73, 107, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 15,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2012-io3015-ov4081 p100386", new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 81, 386, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 16,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2039-io3016-ov4025 p100161", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 25, 161, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 17,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2037-io3017-ov4013 p10019", new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 13, 19, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 18,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2083-io3018-ov4022 p10067", new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 22, 67, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 19,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2071-io3019-ov4030 p100347", new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 30, 347, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 20,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2049-io3020-ov4095 p100361", new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 95, 361, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 21,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2036-io3021-ov4071 p100196", new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 71, 196, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 22,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2070-io3022-ov4039 p10067", new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 39, 67, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 23,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2061-io3023-ov4097 p100124", new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 97, 124, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 24,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2086-io3024-ov4019 p100422", new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, 19, 422, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 25,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2047-io3025-ov4073 p100168", new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 73, 168, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 26,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2079-io3026-ov4077 p10094", new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 77, 94, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 27,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc203-io3027-ov4086 p10042", new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 86, 42, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 28,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2046-io3028-ov4059 p100149", new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 59, 149, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 29,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2070-io3029-ov4045 p100479", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 45, 479, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 30,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2064-io3030-ov4037 p100113", new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 37, 113, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 31,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2026-io3031-ov4064 p100152", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 64, 152, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 32,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc206-io3032-ov4061 p100454", new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 61, 454, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 33,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2014-io3033-ov4095 p100454", new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 95, 454, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 34,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2020-io3034-ov4042 p100457", new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 42, 457, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 35,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc209-io3035-ov4045 p100284", new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 45, 284, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 36,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2070-io3036-ov4020 p100260", new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 20, 260, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 37,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2070-io3037-ov4075 p100451", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 75, 451, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 38,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2078-io3038-ov405 p10085", new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 5, 85, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 39,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2011-io3039-ov4066 p100349", new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 66, 349, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 40,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2093-io3040-ov4010 p100252", new DateTime(2020, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 10, 252, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 41,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2011-io3041-ov406 p100331", new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 6, 331, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 42,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2098-io3042-ov4012 p100200", new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 12, 200, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 43,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2020-io3043-ov4050 p10034", new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 50, 34, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 44,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc202-io3044-ov4070 p100161", new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 70, 161, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 45,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2049-io3045-ov4016 p10042", new DateTime(2020, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 16, 42, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 46,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2036-io3046-ov4027 p100375", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 27, 375, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 47,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2059-io3047-ov4061 p100369", new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 61, 369, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 48,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2083-io3048-ov4012 p100218", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 12, 218, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 49,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2099-io3049-ov4085 p100240", new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 85, 240, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 50,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2080-io3050-ov4026 p100411", new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 26, 411, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 51,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2041-io3051-ov4019 p100263", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 19, 263, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 52,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2042-io3052-ov4053 p100160", new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 53, 160, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 53,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc202-io3053-ov4068 p100309", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 68, 309, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 54,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc208-io3054-ov4026 p100135", new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 26, 135, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 55,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2048-io3055-ov4093 p100232", new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 93, 232, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 56,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2072-io3056-ov4052 p100323", new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 52, 323, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 57,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc209-io3057-ov4086 p10079", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 86, 79, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 58,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2096-io3058-ov4088 p100479", new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 88, 479, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 59,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2024-io3059-ov4072 p100310", new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 72, 310, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 60,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2024-io3060-ov4096 p100158", new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 96, 158, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 61,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2013-io3061-ov408 p10088", new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 8, 88, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 62,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2085-io3062-ov407 p100181", new DateTime(2020, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 7, 181, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 63,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2058-io3063-ov4037 p100366", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 37, 366, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 64,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2091-io3064-ov4080 p100320", new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 80, 320, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 65,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2078-io3065-ov4011 p100141", new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 11, 141, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 66,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2026-io3066-ov403 p100243", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 3, 243, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 67,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2026-io3067-ov4041 p10074", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 41, 74, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 68,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc202-io3068-ov4099 p100385", new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 99, 385, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 69,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2018-io3069-ov4028 p10079", new DateTime(2020, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 28, 79, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 70,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2063-io3070-ov4083 p100243", new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 83, 243, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 71,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2018-io3071-ov4012 p100404", new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 12, 404, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 72,
                columns: new[] { "Description", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2072-io3072-ov4076 p10043", 72, 76, 43, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 73,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2077-io3073-ov4043 p100247", new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 43, 247, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 74,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2050-io3074-ov4090 p10096", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 90, 96, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 75,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2089-io3075-ov4018 p100178", new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 18, 178, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 76,
                columns: new[] { "Description", "Edited", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc204-io3076-ov4059 p10030", new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 30, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 77,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2082-io3077-ov4072 p100249", new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 72, 249, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 78,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2067-io3078-ov4045 p100429", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 45, 429, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 79,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2039-io3079-ov4096 p100149", new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 96, 149, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 80,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2049-io3080-ov4043 p100428", new DateTime(2020, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 43, 428, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 81,
                columns: new[] { "Description", "Edited", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2080-io3081-ov4039 p100477", new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 477, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 82,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2059-io3082-ov4085 p100368", new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 85, 368, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 83,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2091-io3083-ov4012 p100454", new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 12, 454, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 84,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2011-io3084-ov4085 p100142", new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 85, 142, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 85,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2072-io3085-ov406 p100129", new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 6, 129, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 86,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2029-io3086-ov4015 p100195", new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 15, 195, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 87,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2059-io3087-ov4069 p100189", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 69, 189, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 88,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2039-io3088-ov4084 p100492", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 84, 492, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 89,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2030-io3089-ov406 p100127", new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 6, 127, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 90,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2093-io3090-ov4025 p100142", new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 25, 142, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 91,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2043-io3091-ov4079 p10056", new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 79, 56, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 92,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2047-io3092-ov4021 p100479", new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 21, 479, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 93,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2046-io3093-ov4053 p100151", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 53, 151, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 94,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc203-io3094-ov4082 p100204", new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 82, 204, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 95,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2036-io3095-ov4057 p100335", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 57, 335, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 96,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2013-io3096-ov4082 p100211", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 82, 211, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 97,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2052-io3097-ov4016 p100432", new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 16, 432, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 98,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2099-io3098-ov4082 p100400", new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 82, 400, 0 });

            migrationBuilder.UpdateData(
                table: "ItemOrders",
                keyColumn: "ItemOrderId",
                keyValue: 99,
                columns: new[] { "Description", "Edited", "OrderCustomerId", "OrderVendorId", "ProductId", "Quantity" },
                values: new object[] { "Опиасние oc2089-io3099-ov4053 p100421", new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 53, 421, 0 });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 2,
                column: "Edited",
                value: new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 3,
                column: "Edited",
                value: new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 4,
                column: "Edited",
                value: new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 5,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 55, "Описание ov205-c55", new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 42, "Описание ov206-c42", new DateTime(2020, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 7,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 23, "Описание ov207-c23", new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 65, "Описание ov208-c65", new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 9,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 69, "Описание ov209-c69", new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 10,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 9, "Описание ov2010-c9", new DateTime(2021, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 11,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 8, "Описание ov2011-c8", new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 12,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 45, "Описание ov2012-c45", new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 13,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 26, "Описание ov2013-c26", new DateTime(2020, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 14,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 1, "Описание ov2014-c1", new DateTime(2020, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 15,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 7, "Описание ov2015-c7", new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 16,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 54, "Описание ov2016-c54", new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 17,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 56, "Описание ov2017-c56", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 18,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 82, "Описание ov2018-c82", new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 19,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 90, "Описание ov2019-c90", new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 20,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 86, "Описание ov2020-c86", new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 21,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 70, "Описание ov2021-c70", new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 22,
                column: "Edited",
                value: new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 23,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 43, "Описание ov2023-c43", new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 24,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 48, "Описание ov2024-c48", new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 25,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 88, "Описание ov2025-c88", new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 26,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 26, "Описание ov2026-c26", new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 27,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 42, "Описание ov2027-c42", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 28,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 2, "Описание ov2028-c2", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 29,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 36, "Описание ov2029-c36", new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 30,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 9, "Описание ov2030-c9", new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 31,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 38, "Описание ov2031-c38", new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 32,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 62, "Описание ov2032-c62", new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 33,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 93, "Описание ov2033-c93", new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 34,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 24, "Описание ov2034-c24", new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 35,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 53, "Описание ov2035-c53", new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 36,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 51, "Описание ov2036-c51", new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 37,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 29, "Описание ov2037-c29", new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 38,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 89, "Описание ov2038-c89", new DateTime(2020, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 39,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 60, "Описание ov2039-c60", new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 40,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 15, "Описание ov2040-c15", new DateTime(2020, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 41,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 85, "Описание ov2041-c85", new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 42,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 35, "Описание ov2042-c35", new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 43,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 53, "Описание ov2043-c53", new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 44,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 3, "Описание ov2044-c3", new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 45,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 45, "Описание ov2045-c45", new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 46,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 45, "Описание ov2046-c45", new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 47,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 70, "Описание ov2047-c70", new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 48,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 99, "Описание ov2048-c99", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 49,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 18, "Описание ov2049-c18", new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 50,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 9, "Описание ov2050-c9", new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 51,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 76, "Описание ov2051-c76", new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 52,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 73, "Описание ov2052-c73", new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 53,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 33, "Описание ov2053-c33", new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 54,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 99, "Описание ov2054-c99", new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 55,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 2, "Описание ov2055-c2", new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 56,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 37, "Описание ov2056-c37", new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 57,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 59, "Описание ov2057-c59", new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 58,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 11, "Описание ov2058-c11", new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 59,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 97, "Описание ov2059-c97", new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 60,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 52, "Описание ov2060-c52", new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 61,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 71, "Описание ov2061-c71", new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 62,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 38, "Описание ov2062-c38", new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 63,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 59, "Описание ov2063-c59", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 64,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 58, "Описание ov2064-c58", new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 65,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 72, "Описание ov2065-c72", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 66,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 60, "Описание ov2066-c60", new DateTime(2020, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 67,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 2, "Описание ov2067-c2", new DateTime(2020, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 68,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 21, "Описание ov2068-c21", new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 69,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 50, "Описание ov2069-c50", new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 70,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 69, "Описание ov2070-c69", new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 71,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 99, "Описание ov2071-c99", new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 72,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 79, "Описание ov2072-c79", new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 73,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 41, "Описание ov2073-c41", new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 74,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 73, "Описание ov2074-c73", new DateTime(2020, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 75,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 82, "Описание ov2075-c82", new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 76,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 38, "Описание ov2076-c38", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 77,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 6, "Описание ov2077-c6", new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 78,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 31, "Описание ov2078-c31", new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 79,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 63, "Описание ov2079-c63", new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 80,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 46, "Описание ov2080-c46", new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 81,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 49, "Описание ov2081-c49", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 82,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 58, "Описание ov2082-c58", new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 83,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 81, "Описание ov2083-c81", new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 84,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 62, "Описание ov2084-c62", new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 85,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 99, "Описание ov2085-c99", new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 86,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 18, "Описание ov2086-c18", new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 87,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 48, "Описание ov2087-c48", new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 88,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 24, "Описание ov2088-c24", new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 89,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 7, "Описание ov2089-c7", new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 90,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 63, "Описание ov2090-c63", new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 91,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 81, "Описание ov2091-c81", new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 92,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 65, "Описание ov2092-c65", new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 93,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 92, "Описание ov2093-c92", new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 94,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 52, "Описание ov2094-c52", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 95,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 96, "Описание ov2095-c96", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 96,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 78, "Описание ov2096-c78", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 97,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 42, "Описание ov2097-c42", new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 98,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 32, "Описание ov2098-c32", new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "OrderCustomerId",
                keyValue: 99,
                columns: new[] { "CustomerId", "Description", "Edited" },
                values: new object[] { 67, "Описание ov2099-c67", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 1,
                column: "Edited",
                value: new DateTime(2022, 2, 11, 12, 21, 34, 342, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 2,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 402-80", new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 80 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 3,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 403-8", new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 4,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 404-29", new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 5,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 405-39", new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 6,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 406-9", new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 7,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 407-38", new DateTime(2020, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 8,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 408-81", new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 81 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 9,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 409-45", new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 10,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4010-91", new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 91 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 11,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4011-14", new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 12,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4012-12", new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 13,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4013-14", new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 14,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4014-71", new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 71 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 15,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4015-42", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 16,
                column: "Edited",
                value: new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 17,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4017-16", new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 18,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4018-82", new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 82 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 19,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4019-17", new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 20,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4020-51", new DateTime(2020, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 21,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4021-11", new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 22,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4022-9", new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 23,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4023-4", new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 24,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4024-87", new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 87 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 25,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4025-61", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 61 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 26,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4026-7", new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 27,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4027-57", new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 57 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 28,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4028-59", new DateTime(2020, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 59 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 29,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4029-55", new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 30,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4030-22", new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 31,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4031-6", new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 32,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4032-98", new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 98 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 33,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4033-45", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 34,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4034-90", new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 90 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 35,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4035-29", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 36,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4036-67", new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 67 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 37,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4037-85", new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 85 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 38,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4038-93", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 93 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 39,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4039-26", new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 40,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4040-52", new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 41,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4041-32", new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 42,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4042-65", new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 65 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 43,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4043-84", new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 84 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 44,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4044-59", new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 59 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 45,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4045-62", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 62 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 46,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4046-73", new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 73 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 47,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4047-1", new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 48,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4048-90", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 90 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 49,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4049-61", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 61 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 50,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4050-78", new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 78 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 51,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4051-41", new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 52,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4052-22", new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 53,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4053-71", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 71 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 54,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4054-51", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 55,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4055-71", new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 71 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 56,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4056-87", new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 87 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 57,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4057-35", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 58,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4058-39", new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 59,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4059-8", new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 60,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4060-33", new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 61,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4061-7", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 62,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4062-33", new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 63,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4063-17", new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 64,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4064-62", new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 62 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 65,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4065-67", new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 67 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 66,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4066-45", new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 67,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4067-85", new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 85 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 68,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4068-49", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 69,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4069-94", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 94 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 70,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4070-8", new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 71,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4071-77", new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 77 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 72,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4072-11", new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 73,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4073-70", new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 74,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4074-15", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 75,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4075-64", new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 64 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 76,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4076-2", new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 77,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4077-12", new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 78,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4078-85", new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 85 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 79,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4079-74", new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 74 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 80,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4080-87", new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 87 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 81,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4081-64", new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 64 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 82,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4082-39", new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 83,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4083-75", new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 75 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 84,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4084-74", new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 74 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 85,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4085-62", new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 62 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 86,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4086-60", new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 87,
                column: "Edited",
                value: new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 88,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4088-63", new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 63 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 89,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4089-49", new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 90,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4090-26", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 91,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4091-5", new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 92,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4092-49", new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 93,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4093-76", new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 76 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 94,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4094-74", new DateTime(2020, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 74 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 95,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4095-69", new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 69 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 96,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4096-40", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 97,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4097-70", new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 98,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4098-84", new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 84 });

            migrationBuilder.UpdateData(
                table: "OrderVendors",
                keyColumn: "OrderVendorId",
                keyValue: 99,
                columns: new[] { "Description", "Edited", "VendorId" },
                values: new object[] { "Описание 4099-3", new DateTime(2020, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 2,
                column: "Description",
                value: "Описание p502-34");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 3,
                column: "Description",
                value: "Описание p503-73");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 4,
                column: "Description",
                value: "Описание p504-82");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 5,
                column: "Description",
                value: "Описание p505-23");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 6,
                column: "Description",
                value: "Описание p506-98");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 7,
                column: "Description",
                value: "Описание p507-53");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 8,
                column: "Description",
                value: "Описание p508-66");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 9,
                column: "Description",
                value: "Описание p509-44");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 10,
                column: "Description",
                value: "Описание p5010-13");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 11,
                column: "Description",
                value: "Описание p5011-29");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 12,
                column: "Description",
                value: "Описание p5012-83");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 13,
                column: "Description",
                value: "Описание p5013-34");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 14,
                column: "Description",
                value: "Описание p5014-10");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 15,
                column: "Description",
                value: "Описание p5015-19");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 16,
                column: "Description",
                value: "Описание p5016-72");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 17,
                column: "Description",
                value: "Описание p5017-65");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 18,
                column: "Description",
                value: "Описание p5018-18");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 19,
                column: "Description",
                value: "Описание p5019-23");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 20,
                column: "Description",
                value: "Описание p5020-42");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 21,
                column: "Description",
                value: "Описание p5021-34");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 22,
                column: "Description",
                value: "Описание p5022-99");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 23,
                column: "Description",
                value: "Описание p5023-12");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 24,
                column: "Description",
                value: "Описание p5024-49");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 25,
                column: "Description",
                value: "Описание p5025-74");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 26,
                column: "Description",
                value: "Описание p5026-70");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 27,
                column: "Description",
                value: "Описание p5027-34");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 28,
                column: "Description",
                value: "Описание p5028-29");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 29,
                column: "Description",
                value: "Описание p5029-7");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 30,
                column: "Description",
                value: "Описание p5030-6");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 31,
                column: "Description",
                value: "Описание p5031-16");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 32,
                column: "Description",
                value: "Описание p5032-33");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 33,
                column: "Description",
                value: "Описание p5033-26");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 34,
                column: "Description",
                value: "Описание p5034-85");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 35,
                column: "Description",
                value: "Описание p5035-81");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 36,
                column: "Description",
                value: "Описание p5036-14");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 37,
                column: "Description",
                value: "Описание p5037-29");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 38,
                column: "Description",
                value: "Описание p5038-40");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 39,
                column: "Description",
                value: "Описание p5039-34");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 40,
                column: "Description",
                value: "Описание p5040-37");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 41,
                column: "Description",
                value: "Описание p5041-71");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 42,
                column: "Description",
                value: "Описание p5042-7");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 43,
                column: "Description",
                value: "Описание p5043-95");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 44,
                column: "Description",
                value: "Описание p5044-39");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 45,
                column: "Description",
                value: "Описание p5045-84");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 46,
                column: "Description",
                value: "Описание p5046-45");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 47,
                column: "Description",
                value: "Описание p5047-74");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 48,
                column: "Description",
                value: "Описание p5048-43");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 49,
                column: "Description",
                value: "Описание p5049-10");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 50,
                column: "Description",
                value: "Описание p5050-38");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 51,
                column: "Description",
                value: "Описание p5051-87");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 52,
                column: "Description",
                value: "Описание p5052-14");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 53,
                column: "Description",
                value: "Описание p5053-18");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 54,
                column: "Description",
                value: "Описание p5054-26");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 55,
                column: "Description",
                value: "Описание p5055-55");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 56,
                column: "Description",
                value: "Описание p5056-22");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 57,
                column: "Description",
                value: "Описание p5057-9");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 58,
                column: "Description",
                value: "Описание p5058-58");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 59,
                column: "Description",
                value: "Описание p5059-51");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 60,
                column: "Description",
                value: "Описание p5060-39");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 61,
                column: "Description",
                value: "Описание p5061-21");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 62,
                column: "Description",
                value: "Описание p5062-1");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 63,
                column: "Description",
                value: "Описание p5063-71");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 64,
                column: "Description",
                value: "Описание p5064-71");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 65,
                column: "Description",
                value: "Описание p5065-5");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 66,
                column: "Description",
                value: "Описание p5066-1");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 67,
                column: "Description",
                value: "Описание p5067-67");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 68,
                column: "Description",
                value: "Описание p5068-12");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 69,
                column: "Description",
                value: "Описание p5069-89");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 70,
                column: "Description",
                value: "Описание p5070-61");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 71,
                column: "Description",
                value: "Описание p5071-85");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 72,
                column: "Description",
                value: "Описание p5072-86");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 73,
                column: "Description",
                value: "Описание p5073-30");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 74,
                column: "Description",
                value: "Описание p5074-47");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 75,
                column: "Description",
                value: "Описание p5075-93");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 76,
                column: "Description",
                value: "Описание p5076-35");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 77,
                column: "Description",
                value: "Описание p5077-63");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 78,
                column: "Description",
                value: "Описание p5078-58");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 79,
                column: "Description",
                value: "Описание p5079-97");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 80,
                column: "Description",
                value: "Описание p5080-71");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 81,
                column: "Description",
                value: "Описание p5081-91");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 82,
                column: "Description",
                value: "Описание p5082-42");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 83,
                column: "Description",
                value: "Описание p5083-68");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 84,
                column: "Description",
                value: "Описание p5084-89");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 85,
                column: "Description",
                value: "Описание p5085-41");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 86,
                column: "Description",
                value: "Описание p5086-79");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 87,
                column: "Description",
                value: "Описание p5087-28");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 88,
                column: "Description",
                value: "Описание p5088-54");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 89,
                column: "Description",
                value: "Описание p5089-74");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 90,
                column: "Description",
                value: "Описание p5090-19");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 91,
                column: "Description",
                value: "Описание p5091-59");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 92,
                column: "Description",
                value: "Описание p5092-30");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 93,
                column: "Description",
                value: "Описание p5093-24");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 94,
                column: "Description",
                value: "Описание p5094-2");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 95,
                column: "Description",
                value: "Описание p5095-84");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 96,
                column: "Description",
                value: "Описание p5096-29");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 97,
                column: "Description",
                value: "Описание p5097-82");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 98,
                column: "Description",
                value: "Описание p5098-85");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 99,
                column: "Description",
                value: "Описание p5099-59");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetPee.Repository.Migrations
{
    /// <inheritdoc />
    public partial class User1000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("180696f2-1596-443a-8102-dec4ab966277"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c349a889-b499-439b-9442-aa27805d5467"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2342e3c4-9288-40db-b867-f6c4d03f4fd7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e0710737-9c33-4005-8fbb-c825fc007e59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f8245f5-856e-4099-9aea-f9e216b9e762"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19decf8e-1c8f-4ee7-83ca-a76d7615ef21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ccfbfb1-724e-4fa4-b607-71fe71c263e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a709c22b-d018-4ad6-969f-96fbad6741f5"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("16e45355-9b23-4551-b0d3-24062330091e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dc2f70c-38a9-424b-84c8-67be66787e36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7050199-e018-46b1-a604-f65bb907edc5"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0667940d-572a-41fc-9526-9d84ec059c95"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null },
                    { new Guid("cafd4aa9-ae89-46e4-ba4d-2e147454af0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("270f48ea-1f15-4916-8153-b5da2d9b5c03"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kin332k5@gmail.com", "Quyen", "hashed_password_1", null, false, false, "Vong", null, "User", null, 0 },
                    { new Guid("3758d907-714f-432b-88d5-497b501fd96e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[] { new Guid("2702c440-eac2-4327-8a47-7103863ff747"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Ren da beo", new Guid("0667940d-572a-41fc-9526-9d84ec059c95"), null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedAt", "IsDeleted", "Status", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("2802f939-e23f-4a95-98b7-2059b46cb6c8"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("3758d907-714f-432b-88d5-497b501fd96e") },
                    { new Guid("f492e5c8-7d25-4019-9972-41fc6b718c68"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("3758d907-714f-432b-88d5-497b501fd96e") }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("2a8abc87-63b4-45a9-ac6d-0e054e4815c1"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("270f48ea-1f15-4916-8153-b5da2d9b5c03") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdatedAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("63ed2dc3-32d0-4921-a0f8-9dc8c8f3a160"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữ dáng ôm, tôn dáng, chất liệu denim co giãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("2a8abc87-63b4-45a9-ac6d-0e054e4815c1"), null, "https://example.com/images/quan_jeans_nu.jpg" },
                    { new Guid("6a574a5d-4e7d-421d-b263-d6cbaabf37d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cao cấp, thoáng mát, phù hợp cho mọi hoạt động hàng ngày.", false, "Áo Thun Nam", 199000m, new Guid("2a8abc87-63b4-45a9-ac6d-0e054e4815c1"), null, "https://example.com/images/ao_thun_nam.jpg" },
                    { new Guid("8eae9b3a-fee2-4207-956c-8484343e5413"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("2a8abc87-63b4-45a9-ac6d-0e054e4815c1"), null, "https://example.com/images/ao_so_mi_nam.jpg" },
                    { new Guid("96c28b5d-f560-4919-bb0b-01c5792f4186"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("2a8abc87-63b4-45a9-ac6d-0e054e4815c1"), null, "https://example.com/images/chan_vay_nu.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2702c440-eac2-4327-8a47-7103863ff747"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cafd4aa9-ae89-46e4-ba4d-2e147454af0d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2802f939-e23f-4a95-98b7-2059b46cb6c8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f492e5c8-7d25-4019-9972-41fc6b718c68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63ed2dc3-32d0-4921-a0f8-9dc8c8f3a160"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a574a5d-4e7d-421d-b263-d6cbaabf37d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8eae9b3a-fee2-4207-956c-8484343e5413"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96c28b5d-f560-4919-bb0b-01c5792f4186"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0667940d-572a-41fc-9526-9d84ec059c95"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("2a8abc87-63b4-45a9-ac6d-0e054e4815c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3758d907-714f-432b-88d5-497b501fd96e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("270f48ea-1f15-4916-8153-b5da2d9b5c03"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("180696f2-1596-443a-8102-dec4ab966277"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null },
                    { new Guid("c349a889-b499-439b-9442-aa27805d5467"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("3dc2f70c-38a9-424b-84c8-67be66787e36"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "User", null, 0 },
                    { new Guid("a7050199-e018-46b1-a604-f65bb907edc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kin332k5@gmail.com", "Quyen", "hashed_password_1", null, false, false, "Vong", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedAt", "IsDeleted", "Status", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("2342e3c4-9288-40db-b867-f6c4d03f4fd7"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("3dc2f70c-38a9-424b-84c8-67be66787e36") },
                    { new Guid("e0710737-9c33-4005-8fbb-c825fc007e59"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("3dc2f70c-38a9-424b-84c8-67be66787e36") }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("16e45355-9b23-4551-b0d3-24062330091e"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("a7050199-e018-46b1-a604-f65bb907edc5") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdatedAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("0f8245f5-856e-4099-9aea-f9e216b9e762"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("16e45355-9b23-4551-b0d3-24062330091e"), null, "https://example.com/images/chan_vay_nu.jpg" },
                    { new Guid("19decf8e-1c8f-4ee7-83ca-a76d7615ef21"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("16e45355-9b23-4551-b0d3-24062330091e"), null, "https://example.com/images/ao_so_mi_nam.jpg" },
                    { new Guid("8ccfbfb1-724e-4fa4-b607-71fe71c263e8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữ dáng ôm, tôn dáng, chất liệu denim co giãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("16e45355-9b23-4551-b0d3-24062330091e"), null, "https://example.com/images/quan_jeans_nu.jpg" },
                    { new Guid("a709c22b-d018-4ad6-969f-96fbad6741f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cao cấp, thoáng mát, phù hợp cho mọi hoạt động hàng ngày.", false, "Áo Thun Nam", 199000m, new Guid("16e45355-9b23-4551-b0d3-24062330091e"), null, "https://example.com/images/ao_thun_nam.jpg" }
                });
        }
    }
}

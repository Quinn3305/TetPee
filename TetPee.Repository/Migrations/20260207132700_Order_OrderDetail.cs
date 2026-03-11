using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetPee.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Order_OrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71f87364-5124-42ac-a6ce-58fa13511f29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e1f3848-fb6a-4d13-bbb5-2db1aff4b8d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce99861f-63be-4009-ab79-5da58c2da658"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f73bd122-488a-4727-961f-95afac2489f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61aed652-be5b-4bfd-938d-fb41f5be53cf"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("41c12a10-53ce-4be9-b0a6-682ba98c9124"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e2f6c75-b888-42ef-9001-2fa6b718b45e"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("211aeb20-0844-4cb2-992c-4b4d268163f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "User", null, 0 },
                    { new Guid("921e6a2c-97bc-469a-aac0-c3e7079ef5ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kin332k5@gmail.com", "Quyen", "hashed_password_1", null, false, false, "Vong", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedAt", "IsDeleted", "Status", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("44943785-7842-4d4b-87a6-a050c020c09a"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("211aeb20-0844-4cb2-992c-4b4d268163f1") },
                    { new Guid("53e0560d-1f28-4c89-b3c1-47a01a3445bd"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("211aeb20-0844-4cb2-992c-4b4d268163f1") }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("0843adf8-6cad-424b-a883-84db6271f2d2"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("921e6a2c-97bc-469a-aac0-c3e7079ef5ac") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdatedAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("76069934-a89f-4ad0-be58-0ce218ba78b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữ dáng ôm, tôn dáng, chất liệu denim co giãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("0843adf8-6cad-424b-a883-84db6271f2d2"), null, "https://example.com/images/quan_jeans_nu.jpg" },
                    { new Guid("adc81f18-8162-4360-aa45-f7e5544f13fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cao cấp, thoáng mát, phù hợp cho mọi hoạt động hàng ngày.", false, "Áo Thun Nam", 199000m, new Guid("0843adf8-6cad-424b-a883-84db6271f2d2"), null, "https://example.com/images/ao_thun_nam.jpg" },
                    { new Guid("bed67eab-4d40-4dcc-8ccb-c050bc57c764"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("0843adf8-6cad-424b-a883-84db6271f2d2"), null, "https://example.com/images/chan_vay_nu.jpg" },
                    { new Guid("ecb6d6c9-98c8-46a5-9446-3ee4d330eb80"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("0843adf8-6cad-424b-a883-84db6271f2d2"), null, "https://example.com/images/ao_so_mi_nam.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("44943785-7842-4d4b-87a6-a050c020c09a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("53e0560d-1f28-4c89-b3c1-47a01a3445bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76069934-a89f-4ad0-be58-0ce218ba78b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adc81f18-8162-4360-aa45-f7e5544f13fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bed67eab-4d40-4dcc-8ccb-c050bc57c764"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ecb6d6c9-98c8-46a5-9446-3ee4d330eb80"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("0843adf8-6cad-424b-a883-84db6271f2d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("211aeb20-0844-4cb2-992c-4b4d268163f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("921e6a2c-97bc-469a-aac0-c3e7079ef5ac"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("3e2f6c75-b888-42ef-9001-2fa6b718b45e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kin332k5@gmail.com", "Quyen", "hashed_password_1", null, false, false, "Vong", null, "User", null, 0 },
                    { new Guid("61aed652-be5b-4bfd-938d-fb41f5be53cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("41c12a10-53ce-4be9-b0a6-682ba98c9124"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("3e2f6c75-b888-42ef-9001-2fa6b718b45e") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdatedAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("71f87364-5124-42ac-a6ce-58fa13511f29"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("41c12a10-53ce-4be9-b0a6-682ba98c9124"), null, "https://example.com/images/chan_vay_nu.jpg" },
                    { new Guid("8e1f3848-fb6a-4d13-bbb5-2db1aff4b8d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("41c12a10-53ce-4be9-b0a6-682ba98c9124"), null, "https://example.com/images/ao_so_mi_nam.jpg" },
                    { new Guid("ce99861f-63be-4009-ab79-5da58c2da658"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cao cấp, thoáng mát, phù hợp cho mọi hoạt động hàng ngày.", false, "Áo Thun Nam", 199000m, new Guid("41c12a10-53ce-4be9-b0a6-682ba98c9124"), null, "https://example.com/images/ao_thun_nam.jpg" },
                    { new Guid("f73bd122-488a-4727-961f-95afac2489f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữ dáng ôm, tôn dáng, chất liệu denim co giãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("41c12a10-53ce-4be9-b0a6-682ba98c9124"), null, "https://example.com/images/quan_jeans_nu.jpg" }
                });
        }
    }
}

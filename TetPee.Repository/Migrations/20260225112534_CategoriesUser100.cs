using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetPee.Repository.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesUser100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null },
                    { new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("002114b4-c1e4-43da-98f1-eb06c75f5799"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k828@gmail.com", "Quyen828", "hashed_password_828", null, false, false, "Vong828", null, "User", null, 0 },
                    { new Guid("00431ce4-4daf-40d3-9eca-1105a33bf0a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k881@gmail.com", "Quyen881", "hashed_password_881", null, false, false, "Vong881", null, "User", null, 0 },
                    { new Guid("00478e5c-68b2-4916-a4aa-ff2581f526b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k762@gmail.com", "Quyen762", "hashed_password_762", null, false, false, "Vong762", null, "User", null, 0 },
                    { new Guid("004e343f-9d3e-4020-b340-5ea99a02e5b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k398@gmail.com", "Quyen398", "hashed_password_398", null, false, false, "Vong398", null, "User", null, 0 },
                    { new Guid("00879e06-1df4-4267-8b54-1ebe66e0c135"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k90@gmail.com", "Quyen90", "hashed_password_90", null, false, false, "Vong90", null, "User", null, 0 },
                    { new Guid("00a78fa5-4e1b-4aa3-8adb-5fdabd8261f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k576@gmail.com", "Quyen576", "hashed_password_576", null, false, false, "Vong576", null, "User", null, 0 },
                    { new Guid("01a5e2ad-057c-43e3-a4e5-dde9750560e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k333@gmail.com", "Quyen333", "hashed_password_333", null, false, false, "Vong333", null, "User", null, 0 },
                    { new Guid("01aaf8cd-e312-4906-be85-0747477e773b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k945@gmail.com", "Quyen945", "hashed_password_945", null, false, false, "Vong945", null, "User", null, 0 },
                    { new Guid("01f48d5e-cdcf-4718-ad3c-558d87f0c585"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k478@gmail.com", "Quyen478", "hashed_password_478", null, false, false, "Vong478", null, "User", null, 0 },
                    { new Guid("02467224-4688-454f-9853-a27295a17298"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k176@gmail.com", "Quyen176", "hashed_password_176", null, false, false, "Vong176", null, "User", null, 0 },
                    { new Guid("02a27160-33f9-4a68-9951-eaa4a8c9fdc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k154@gmail.com", "Quyen154", "hashed_password_154", null, false, false, "Vong154", null, "User", null, 0 },
                    { new Guid("02c849b2-c38e-4a57-abf3-68e65a8f9b96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k760@gmail.com", "Quyen760", "hashed_password_760", null, false, false, "Vong760", null, "User", null, 0 },
                    { new Guid("02f7f4e8-a236-4578-bde6-6a7f212c28b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k723@gmail.com", "Quyen723", "hashed_password_723", null, false, false, "Vong723", null, "User", null, 0 },
                    { new Guid("02ffca5b-c67f-42e2-a74e-975e80ae607e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k841@gmail.com", "Quyen841", "hashed_password_841", null, false, false, "Vong841", null, "User", null, 0 },
                    { new Guid("032b8fbf-b6d1-41e0-b384-741b534d4c2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k380@gmail.com", "Quyen380", "hashed_password_380", null, false, false, "Vong380", null, "User", null, 0 },
                    { new Guid("03674420-7d58-4133-b5a2-d29b437b2ec4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k637@gmail.com", "Quyen637", "hashed_password_637", null, false, false, "Vong637", null, "User", null, 0 },
                    { new Guid("03bd136c-92f7-49f7-ba4a-ddf73ba6bb4d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k809@gmail.com", "Quyen809", "hashed_password_809", null, false, false, "Vong809", null, "User", null, 0 },
                    { new Guid("047e3644-89cf-43fe-b58c-0c904967838c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k441@gmail.com", "Quyen441", "hashed_password_441", null, false, false, "Vong441", null, "User", null, 0 },
                    { new Guid("04aee3f1-3b8a-403b-9421-a810808658f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k288@gmail.com", "Quyen288", "hashed_password_288", null, false, false, "Vong288", null, "User", null, 0 },
                    { new Guid("05405f27-bdb9-4de4-8910-fa1f3592089a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k783@gmail.com", "Quyen783", "hashed_password_783", null, false, false, "Vong783", null, "User", null, 0 },
                    { new Guid("058711bd-25cd-470d-a81c-409044abec6d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k433@gmail.com", "Quyen433", "hashed_password_433", null, false, false, "Vong433", null, "User", null, 0 },
                    { new Guid("059655e5-526e-4a48-9f4f-57d1f5a716fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k712@gmail.com", "Quyen712", "hashed_password_712", null, false, false, "Vong712", null, "User", null, 0 },
                    { new Guid("05d91953-ad75-4b76-b0f5-a5a042cdb3b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k661@gmail.com", "Quyen661", "hashed_password_661", null, false, false, "Vong661", null, "User", null, 0 },
                    { new Guid("06141866-d4aa-4485-83cd-fe5bf15e60ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k183@gmail.com", "Quyen183", "hashed_password_183", null, false, false, "Vong183", null, "User", null, 0 },
                    { new Guid("06272e5a-e86c-4a9d-ba0e-e48ef31ee531"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k5@gmail.com", "Quyen5", "hashed_password_5", null, false, false, "Vong5", null, "User", null, 0 },
                    { new Guid("0657119d-83ec-4392-9e36-61f7b17c2313"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k647@gmail.com", "Quyen647", "hashed_password_647", null, false, false, "Vong647", null, "User", null, 0 },
                    { new Guid("06911fd0-8665-4d56-8169-279ff19951fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k944@gmail.com", "Quyen944", "hashed_password_944", null, false, false, "Vong944", null, "User", null, 0 },
                    { new Guid("070f2f15-6dd6-47a1-8056-4da819ac9658"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k372@gmail.com", "Quyen372", "hashed_password_372", null, false, false, "Vong372", null, "User", null, 0 },
                    { new Guid("07135373-1b87-4f39-9481-768b7cb4d293"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k784@gmail.com", "Quyen784", "hashed_password_784", null, false, false, "Vong784", null, "User", null, 0 },
                    { new Guid("0729666c-506d-43cb-b5f6-5d8a02cbf3b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k403@gmail.com", "Quyen403", "hashed_password_403", null, false, false, "Vong403", null, "User", null, 0 },
                    { new Guid("073a99e6-46b6-4992-a02a-9fcc0a77c508"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k619@gmail.com", "Quyen619", "hashed_password_619", null, false, false, "Vong619", null, "User", null, 0 },
                    { new Guid("07a1cb97-3831-4c84-804c-f376a7aa8040"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k490@gmail.com", "Quyen490", "hashed_password_490", null, false, false, "Vong490", null, "User", null, 0 },
                    { new Guid("080a4182-70fe-4a3e-9832-62f5400dc7bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k964@gmail.com", "Quyen964", "hashed_password_964", null, false, false, "Vong964", null, "User", null, 0 },
                    { new Guid("082c658f-fe33-49e0-823f-8750fb623d39"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k925@gmail.com", "Quyen925", "hashed_password_925", null, false, false, "Vong925", null, "User", null, 0 },
                    { new Guid("082e32a2-0024-4488-b441-40bf49e9041b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k96@gmail.com", "Quyen96", "hashed_password_96", null, false, false, "Vong96", null, "User", null, 0 },
                    { new Guid("083ab58e-16c8-4cf1-a917-7fcbdfa4c1d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k237@gmail.com", "Quyen237", "hashed_password_237", null, false, false, "Vong237", null, "User", null, 0 },
                    { new Guid("086d168f-1538-4da7-8339-08010d438c40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k461@gmail.com", "Quyen461", "hashed_password_461", null, false, false, "Vong461", null, "User", null, 0 },
                    { new Guid("087e8805-7e77-4593-8c96-561fd9937072"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k293@gmail.com", "Quyen293", "hashed_password_293", null, false, false, "Vong293", null, "User", null, 0 },
                    { new Guid("088c6520-caec-4f45-b416-9d5ef944e529"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k235@gmail.com", "Quyen235", "hashed_password_235", null, false, false, "Vong235", null, "User", null, 0 },
                    { new Guid("08c614a7-3791-4d59-ab92-9010a04b9ead"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k75@gmail.com", "Quyen75", "hashed_password_75", null, false, false, "Vong75", null, "User", null, 0 },
                    { new Guid("08d504ed-5d05-4c15-83a1-866680949818"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k27@gmail.com", "Quyen27", "hashed_password_27", null, false, false, "Vong27", null, "User", null, 0 },
                    { new Guid("08e6b4db-0231-438f-90c1-6928b4c204df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k120@gmail.com", "Quyen120", "hashed_password_120", null, false, false, "Vong120", null, "User", null, 0 },
                    { new Guid("08f2a0e8-58ae-4201-af13-b4adf3728251"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k722@gmail.com", "Quyen722", "hashed_password_722", null, false, false, "Vong722", null, "User", null, 0 },
                    { new Guid("090b81e1-ff7b-4dba-aa35-087075eaca42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k897@gmail.com", "Quyen897", "hashed_password_897", null, false, false, "Vong897", null, "User", null, 0 },
                    { new Guid("092147d0-3036-4f0f-a5aa-db0136b62f43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k986@gmail.com", "Quyen986", "hashed_password_986", null, false, false, "Vong986", null, "User", null, 0 },
                    { new Guid("092469d3-728e-453e-ae5f-55fb6a0529e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k674@gmail.com", "Quyen674", "hashed_password_674", null, false, false, "Vong674", null, "User", null, 0 },
                    { new Guid("0939fd1a-aff5-42bb-abf8-5e9d2fb13328"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k779@gmail.com", "Quyen779", "hashed_password_779", null, false, false, "Vong779", null, "User", null, 0 },
                    { new Guid("0953721b-1c4d-4c2f-9e1c-f3923de464eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k343@gmail.com", "Quyen343", "hashed_password_343", null, false, false, "Vong343", null, "User", null, 0 },
                    { new Guid("095a373b-70e8-4f06-81e4-34002101c347"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k175@gmail.com", "Quyen175", "hashed_password_175", null, false, false, "Vong175", null, "User", null, 0 },
                    { new Guid("09674623-0267-414a-b869-88e9e4f45696"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k963@gmail.com", "Quyen963", "hashed_password_963", null, false, false, "Vong963", null, "User", null, 0 },
                    { new Guid("09d3b4c8-34ab-4c13-b797-949c0ee1d77b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k473@gmail.com", "Quyen473", "hashed_password_473", null, false, false, "Vong473", null, "User", null, 0 },
                    { new Guid("0a226d9d-80ef-43a9-8b8b-4611be49c21f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k421@gmail.com", "Quyen421", "hashed_password_421", null, false, false, "Vong421", null, "User", null, 0 },
                    { new Guid("0a2fc11d-6fee-4916-b898-eb6e44bcb3fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k310@gmail.com", "Quyen310", "hashed_password_310", null, false, false, "Vong310", null, "User", null, 0 },
                    { new Guid("0a3edcbd-8c85-4a08-87b8-593320cba51a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k366@gmail.com", "Quyen366", "hashed_password_366", null, false, false, "Vong366", null, "User", null, 0 },
                    { new Guid("0a421c5d-fabe-418a-b37e-3626f6967c7d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k123@gmail.com", "Quyen123", "hashed_password_123", null, false, false, "Vong123", null, "User", null, 0 },
                    { new Guid("0a79c33b-4772-4fa4-ac75-1bf5d167ce58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k418@gmail.com", "Quyen418", "hashed_password_418", null, false, false, "Vong418", null, "User", null, 0 },
                    { new Guid("0aa81648-dfd7-491e-b971-086d9c25cdea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k733@gmail.com", "Quyen733", "hashed_password_733", null, false, false, "Vong733", null, "User", null, 0 },
                    { new Guid("0ae8b5a4-e7ff-4a64-b44d-1af1b25a30af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k719@gmail.com", "Quyen719", "hashed_password_719", null, false, false, "Vong719", null, "User", null, 0 },
                    { new Guid("0b0caf77-23d4-4b1c-bdef-b2647516cf43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k367@gmail.com", "Quyen367", "hashed_password_367", null, false, false, "Vong367", null, "User", null, 0 },
                    { new Guid("0b0da880-32fe-4efc-b80d-81d3d63b8467"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k936@gmail.com", "Quyen936", "hashed_password_936", null, false, false, "Vong936", null, "User", null, 0 },
                    { new Guid("0c5c6b5b-c00b-4f87-aa93-dcca704d6f3e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k821@gmail.com", "Quyen821", "hashed_password_821", null, false, false, "Vong821", null, "User", null, 0 },
                    { new Guid("0d34e3eb-ed70-47a5-b605-d700fba01b4e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k813@gmail.com", "Quyen813", "hashed_password_813", null, false, false, "Vong813", null, "User", null, 0 },
                    { new Guid("0da861bd-7a4e-4b0b-94cc-3eb38de02fc1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k641@gmail.com", "Quyen641", "hashed_password_641", null, false, false, "Vong641", null, "User", null, 0 },
                    { new Guid("0e01bbda-fb15-4f2c-b1c7-c47f9b5acc63"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k389@gmail.com", "Quyen389", "hashed_password_389", null, false, false, "Vong389", null, "User", null, 0 },
                    { new Guid("0e53ecf8-87a1-48cb-8c48-118d7f63e26d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k837@gmail.com", "Quyen837", "hashed_password_837", null, false, false, "Vong837", null, "User", null, 0 },
                    { new Guid("0ec75f74-d092-4d3a-af2a-9c466aff0d7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k569@gmail.com", "Quyen569", "hashed_password_569", null, false, false, "Vong569", null, "User", null, 0 },
                    { new Guid("0f16d058-43ef-4d90-80a3-f237bccb504e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k621@gmail.com", "Quyen621", "hashed_password_621", null, false, false, "Vong621", null, "User", null, 0 },
                    { new Guid("0fca04ad-5c1f-48e4-a316-67c5c0d75826"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k292@gmail.com", "Quyen292", "hashed_password_292", null, false, false, "Vong292", null, "User", null, 0 },
                    { new Guid("0fecd7a7-6822-4259-95cc-a996a8e50fdb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k692@gmail.com", "Quyen692", "hashed_password_692", null, false, false, "Vong692", null, "User", null, 0 },
                    { new Guid("1031274a-83cd-4015-acb1-2b2c5dd9598d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k79@gmail.com", "Quyen79", "hashed_password_79", null, false, false, "Vong79", null, "User", null, 0 },
                    { new Guid("1077fc56-a24b-49ef-ba32-06da22b9f6e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k867@gmail.com", "Quyen867", "hashed_password_867", null, false, false, "Vong867", null, "User", null, 0 },
                    { new Guid("109abf02-74eb-4c6f-ac37-8e9fbaa40c42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k408@gmail.com", "Quyen408", "hashed_password_408", null, false, false, "Vong408", null, "User", null, 0 },
                    { new Guid("10a06441-bce6-44be-b986-e464b7925c41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k873@gmail.com", "Quyen873", "hashed_password_873", null, false, false, "Vong873", null, "User", null, 0 },
                    { new Guid("10a628bf-4bda-4cf6-be25-0e8777f4d233"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k874@gmail.com", "Quyen874", "hashed_password_874", null, false, false, "Vong874", null, "User", null, 0 },
                    { new Guid("10d2ed09-5ba5-4a52-969a-b4b5c99008ad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k672@gmail.com", "Quyen672", "hashed_password_672", null, false, false, "Vong672", null, "User", null, 0 },
                    { new Guid("116d96d4-a394-43ff-bb6a-bb461603f9e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k40@gmail.com", "Quyen40", "hashed_password_40", null, false, false, "Vong40", null, "User", null, 0 },
                    { new Guid("11d03ab6-5c00-4bb6-b09f-133c372f54d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k43@gmail.com", "Quyen43", "hashed_password_43", null, false, false, "Vong43", null, "User", null, 0 },
                    { new Guid("123ce268-adb3-48e0-a75f-814fad2c47e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k199@gmail.com", "Quyen199", "hashed_password_199", null, false, false, "Vong199", null, "User", null, 0 },
                    { new Guid("12428c5f-898f-4da7-b1b7-cd146cb6c492"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k598@gmail.com", "Quyen598", "hashed_password_598", null, false, false, "Vong598", null, "User", null, 0 },
                    { new Guid("12aea1ec-0afb-4674-bdce-c93905f78f09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k151@gmail.com", "Quyen151", "hashed_password_151", null, false, false, "Vong151", null, "User", null, 0 },
                    { new Guid("131e84e6-baea-4d77-b73d-4ef2a57ddea6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k444@gmail.com", "Quyen444", "hashed_password_444", null, false, false, "Vong444", null, "User", null, 0 },
                    { new Guid("135d6060-5f51-444a-95a6-defe7daf2eb9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k169@gmail.com", "Quyen169", "hashed_password_169", null, false, false, "Vong169", null, "User", null, 0 },
                    { new Guid("13c3c0b9-a092-480e-ade8-a1596a549e1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k740@gmail.com", "Quyen740", "hashed_password_740", null, false, false, "Vong740", null, "User", null, 0 },
                    { new Guid("13e12b17-c822-4761-803a-e8088b6cde53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k649@gmail.com", "Quyen649", "hashed_password_649", null, false, false, "Vong649", null, "User", null, 0 },
                    { new Guid("13fffab3-90e3-4c9f-8610-675a15b8ead2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k160@gmail.com", "Quyen160", "hashed_password_160", null, false, false, "Vong160", null, "User", null, 0 },
                    { new Guid("140eb59f-2632-4e3f-9c7e-4892e077cb1e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k252@gmail.com", "Quyen252", "hashed_password_252", null, false, false, "Vong252", null, "User", null, 0 },
                    { new Guid("14ac8767-9875-4ae0-ab12-67ac06883c78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k262@gmail.com", "Quyen262", "hashed_password_262", null, false, false, "Vong262", null, "User", null, 0 },
                    { new Guid("14bc97e1-badc-44c3-bdc2-f126cb8b4f0d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k394@gmail.com", "Quyen394", "hashed_password_394", null, false, false, "Vong394", null, "User", null, 0 },
                    { new Guid("14ffb6e4-9ce0-419c-95c6-a1daca3b52b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k313@gmail.com", "Quyen313", "hashed_password_313", null, false, false, "Vong313", null, "User", null, 0 },
                    { new Guid("15017aa3-3ba1-48a0-9b9d-d3de7150fcbc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k28@gmail.com", "Quyen28", "hashed_password_28", null, false, false, "Vong28", null, "User", null, 0 },
                    { new Guid("15db69b5-12f3-4e92-8aea-1436d1cfad1a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k638@gmail.com", "Quyen638", "hashed_password_638", null, false, false, "Vong638", null, "User", null, 0 },
                    { new Guid("15df031e-294f-4142-af12-6913d12f0f7c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k997@gmail.com", "Quyen997", "hashed_password_997", null, false, false, "Vong997", null, "User", null, 0 },
                    { new Guid("160f0c64-7cf9-4d67-897e-fad2cd42bc64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k141@gmail.com", "Quyen141", "hashed_password_141", null, false, false, "Vong141", null, "User", null, 0 },
                    { new Guid("1667424a-bf48-4da9-958d-f71cc8831176"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k294@gmail.com", "Quyen294", "hashed_password_294", null, false, false, "Vong294", null, "User", null, 0 },
                    { new Guid("17130254-b096-4235-8015-bcab1ba96638"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k481@gmail.com", "Quyen481", "hashed_password_481", null, false, false, "Vong481", null, "User", null, 0 },
                    { new Guid("17a15202-fb67-4110-a0f9-a6b049ea614a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k137@gmail.com", "Quyen137", "hashed_password_137", null, false, false, "Vong137", null, "User", null, 0 },
                    { new Guid("187f80ff-3eba-47e5-8150-542e43230703"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k770@gmail.com", "Quyen770", "hashed_password_770", null, false, false, "Vong770", null, "User", null, 0 },
                    { new Guid("18e11d76-a784-403e-af45-44eca16b750b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k952@gmail.com", "Quyen952", "hashed_password_952", null, false, false, "Vong952", null, "User", null, 0 },
                    { new Guid("19d20d8e-eaee-405c-a4a9-de43fcdc3055"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k556@gmail.com", "Quyen556", "hashed_password_556", null, false, false, "Vong556", null, "User", null, 0 },
                    { new Guid("19eb377e-2c59-4204-93a7-9f05ba9a346b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k573@gmail.com", "Quyen573", "hashed_password_573", null, false, false, "Vong573", null, "User", null, 0 },
                    { new Guid("19fb928b-3815-4199-852f-f789d01c86de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k216@gmail.com", "Quyen216", "hashed_password_216", null, false, false, "Vong216", null, "User", null, 0 },
                    { new Guid("1a49f21b-f82f-4710-89ee-038cfa1bdf67"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k38@gmail.com", "Quyen38", "hashed_password_38", null, false, false, "Vong38", null, "User", null, 0 },
                    { new Guid("1ab5051c-7f2a-483e-9742-8378026e3612"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k680@gmail.com", "Quyen680", "hashed_password_680", null, false, false, "Vong680", null, "User", null, 0 },
                    { new Guid("1aeabd50-8cf8-4b8c-99f7-645b8ed9968a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k326@gmail.com", "Quyen326", "hashed_password_326", null, false, false, "Vong326", null, "User", null, 0 },
                    { new Guid("1b0d50e6-d2f4-49c3-9e4e-651e3652d277"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k774@gmail.com", "Quyen774", "hashed_password_774", null, false, false, "Vong774", null, "User", null, 0 },
                    { new Guid("1beab055-1bed-41af-977e-e784c2457512"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k148@gmail.com", "Quyen148", "hashed_password_148", null, false, false, "Vong148", null, "User", null, 0 },
                    { new Guid("1c242e6c-4d06-439e-a299-8a9f970b7771"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k906@gmail.com", "Quyen906", "hashed_password_906", null, false, false, "Vong906", null, "User", null, 0 },
                    { new Guid("1c29c2d0-a2a9-434f-9f13-f583ae7e75f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k927@gmail.com", "Quyen927", "hashed_password_927", null, false, false, "Vong927", null, "User", null, 0 },
                    { new Guid("1c397d35-a901-462a-b923-626ae67eb5a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k485@gmail.com", "Quyen485", "hashed_password_485", null, false, false, "Vong485", null, "User", null, 0 },
                    { new Guid("1c3e3ea1-ec15-40ea-bc15-80e73d2f39d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k209@gmail.com", "Quyen209", "hashed_password_209", null, false, false, "Vong209", null, "User", null, 0 },
                    { new Guid("1c440193-0985-448a-b1ac-616108c59d81"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k889@gmail.com", "Quyen889", "hashed_password_889", null, false, false, "Vong889", null, "User", null, 0 },
                    { new Guid("1c52b511-2e66-4147-89c1-db746e07782e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k892@gmail.com", "Quyen892", "hashed_password_892", null, false, false, "Vong892", null, "User", null, 0 },
                    { new Guid("1c9b613a-c30a-472f-9442-fce54324afcd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k330@gmail.com", "Quyen330", "hashed_password_330", null, false, false, "Vong330", null, "User", null, 0 },
                    { new Guid("1cf339e7-f810-4b88-a3bb-0a943d77d0f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k617@gmail.com", "Quyen617", "hashed_password_617", null, false, false, "Vong617", null, "User", null, 0 },
                    { new Guid("1d15dc89-c561-4d69-8686-41d2ceaf49a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k157@gmail.com", "Quyen157", "hashed_password_157", null, false, false, "Vong157", null, "User", null, 0 },
                    { new Guid("1d3104e4-544f-4bf2-820c-53f48965033d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k357@gmail.com", "Quyen357", "hashed_password_357", null, false, false, "Vong357", null, "User", null, 0 },
                    { new Guid("1d8388f6-e5df-4252-8c8a-ee379a64b724"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k351@gmail.com", "Quyen351", "hashed_password_351", null, false, false, "Vong351", null, "User", null, 0 },
                    { new Guid("1e14a6ab-8089-4972-91bf-4a5afab35646"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k884@gmail.com", "Quyen884", "hashed_password_884", null, false, false, "Vong884", null, "User", null, 0 },
                    { new Guid("1ee2a9a2-5694-4f4f-aa46-be176438dd5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k825@gmail.com", "Quyen825", "hashed_password_825", null, false, false, "Vong825", null, "User", null, 0 },
                    { new Guid("1eec0dca-d3cf-4f20-a96f-e07fe68718f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k42@gmail.com", "Quyen42", "hashed_password_42", null, false, false, "Vong42", null, "User", null, 0 },
                    { new Guid("1eefa927-625c-4848-88b8-972542f1b0ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k498@gmail.com", "Quyen498", "hashed_password_498", null, false, false, "Vong498", null, "User", null, 0 },
                    { new Guid("1f18ff75-b034-412d-8450-964ab98bfd94"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k992@gmail.com", "Quyen992", "hashed_password_992", null, false, false, "Vong992", null, "User", null, 0 },
                    { new Guid("1f741433-7b7e-4e28-9da4-e8c2f817ede6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k877@gmail.com", "Quyen877", "hashed_password_877", null, false, false, "Vong877", null, "User", null, 0 },
                    { new Guid("2001c1a5-1915-416e-ba09-d817e824097f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k678@gmail.com", "Quyen678", "hashed_password_678", null, false, false, "Vong678", null, "User", null, 0 },
                    { new Guid("208e428e-79e0-430f-95a4-42ee8eae9f76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k33@gmail.com", "Quyen33", "hashed_password_33", null, false, false, "Vong33", null, "User", null, 0 },
                    { new Guid("20a77ab3-151b-4972-b2e6-8f2899bf68d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k689@gmail.com", "Quyen689", "hashed_password_689", null, false, false, "Vong689", null, "User", null, 0 },
                    { new Guid("21056122-f969-475d-8c40-7cb1aefc2e30"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k20@gmail.com", "Quyen20", "hashed_password_20", null, false, false, "Vong20", null, "User", null, 0 },
                    { new Guid("213e92a3-7175-4a36-9f9b-661f74342b6d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k814@gmail.com", "Quyen814", "hashed_password_814", null, false, false, "Vong814", null, "User", null, 0 },
                    { new Guid("217fb4c6-7ae0-4cc7-accd-8a5c4a0a971f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k319@gmail.com", "Quyen319", "hashed_password_319", null, false, false, "Vong319", null, "User", null, 0 },
                    { new Guid("21c7586b-238f-4ac1-bdf5-c20cb99e0572"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k499@gmail.com", "Quyen499", "hashed_password_499", null, false, false, "Vong499", null, "User", null, 0 },
                    { new Guid("21d55201-821b-4391-a5f5-1b205b3c44e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k527@gmail.com", "Quyen527", "hashed_password_527", null, false, false, "Vong527", null, "User", null, 0 },
                    { new Guid("223c553f-21d6-4f4a-a83a-b3391fdc3171"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k60@gmail.com", "Quyen60", "hashed_password_60", null, false, false, "Vong60", null, "User", null, 0 },
                    { new Guid("22754150-e2d7-4e82-9ca5-e65451943b01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k19@gmail.com", "Quyen19", "hashed_password_19", null, false, false, "Vong19", null, "User", null, 0 },
                    { new Guid("22beedb1-a364-433e-a3e4-b3be9078472d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k921@gmail.com", "Quyen921", "hashed_password_921", null, false, false, "Vong921", null, "User", null, 0 },
                    { new Guid("232f998e-d859-412c-b924-b6e29d24ffd6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k251@gmail.com", "Quyen251", "hashed_password_251", null, false, false, "Vong251", null, "User", null, 0 },
                    { new Guid("2350d483-90c5-485d-86fd-4ff21c2b811b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k905@gmail.com", "Quyen905", "hashed_password_905", null, false, false, "Vong905", null, "User", null, 0 },
                    { new Guid("236c2032-9911-4360-b064-9b1efb130bca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k625@gmail.com", "Quyen625", "hashed_password_625", null, false, false, "Vong625", null, "User", null, 0 },
                    { new Guid("23d90c28-d721-4378-a65e-9284dab32464"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k177@gmail.com", "Quyen177", "hashed_password_177", null, false, false, "Vong177", null, "User", null, 0 },
                    { new Guid("2408fe42-be0a-4a43-acd6-3f6dd922bbaa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k477@gmail.com", "Quyen477", "hashed_password_477", null, false, false, "Vong477", null, "User", null, 0 },
                    { new Guid("242f4ce0-8f02-4d3c-a1f6-2f83810f64ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k662@gmail.com", "Quyen662", "hashed_password_662", null, false, false, "Vong662", null, "User", null, 0 },
                    { new Guid("24578b37-47ea-4b92-a2f8-92ffe878caaf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k998@gmail.com", "Quyen998", "hashed_password_998", null, false, false, "Vong998", null, "User", null, 0 },
                    { new Guid("246dd22f-9412-4371-82cb-1863238a2507"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k219@gmail.com", "Quyen219", "hashed_password_219", null, false, false, "Vong219", null, "User", null, 0 },
                    { new Guid("24ebc46f-78d6-44de-abb1-19affbf909a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k902@gmail.com", "Quyen902", "hashed_password_902", null, false, false, "Vong902", null, "User", null, 0 },
                    { new Guid("2513dcda-2cee-4d00-946c-c3c912ba1eba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k358@gmail.com", "Quyen358", "hashed_password_358", null, false, false, "Vong358", null, "User", null, 0 },
                    { new Guid("257c588f-1739-459a-a68b-b76cdd44fe15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k409@gmail.com", "Quyen409", "hashed_password_409", null, false, false, "Vong409", null, "User", null, 0 },
                    { new Guid("258e74a8-a7f9-403a-a7ab-8da5646765d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k87@gmail.com", "Quyen87", "hashed_password_87", null, false, false, "Vong87", null, "User", null, 0 },
                    { new Guid("25902c90-31fd-4c76-b7b3-64dc3562f695"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k88@gmail.com", "Quyen88", "hashed_password_88", null, false, false, "Vong88", null, "User", null, 0 },
                    { new Guid("25d0a21f-2ed2-41dd-aa42-5b4470217c90"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k324@gmail.com", "Quyen324", "hashed_password_324", null, false, false, "Vong324", null, "User", null, 0 },
                    { new Guid("261b9ef9-1f7d-4def-90a6-21b00af1755b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k808@gmail.com", "Quyen808", "hashed_password_808", null, false, false, "Vong808", null, "User", null, 0 },
                    { new Guid("265af3ea-694d-4af9-8485-8c180cb78ac3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k761@gmail.com", "Quyen761", "hashed_password_761", null, false, false, "Vong761", null, "User", null, 0 },
                    { new Guid("26c89fdc-9d4d-445a-abb0-8aa5f3d76f11"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k629@gmail.com", "Quyen629", "hashed_password_629", null, false, false, "Vong629", null, "User", null, 0 },
                    { new Guid("26f87bd0-3d17-4665-b8c1-362727c64a82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k443@gmail.com", "Quyen443", "hashed_password_443", null, false, false, "Vong443", null, "User", null, 0 },
                    { new Guid("270a9ccd-3a70-4213-b6a2-a9c794ea6f06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k432@gmail.com", "Quyen432", "hashed_password_432", null, false, false, "Vong432", null, "User", null, 0 },
                    { new Guid("27338afa-807b-4aaf-9e1c-fd74fc3c02fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k460@gmail.com", "Quyen460", "hashed_password_460", null, false, false, "Vong460", null, "User", null, 0 },
                    { new Guid("275e387d-772f-4930-9d05-20083c04c47b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k128@gmail.com", "Quyen128", "hashed_password_128", null, false, false, "Vong128", null, "User", null, 0 },
                    { new Guid("27a0df0b-0107-4159-9180-2da50a683f11"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k624@gmail.com", "Quyen624", "hashed_password_624", null, false, false, "Vong624", null, "User", null, 0 },
                    { new Guid("283fe9fe-603f-43f8-a13e-a810b244848e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k582@gmail.com", "Quyen582", "hashed_password_582", null, false, false, "Vong582", null, "User", null, 0 },
                    { new Guid("285eedaa-3a2f-4648-aacf-fc01da52f8f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k411@gmail.com", "Quyen411", "hashed_password_411", null, false, false, "Vong411", null, "User", null, 0 },
                    { new Guid("297bcc1c-ad48-4812-88cc-967d50e349a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k277@gmail.com", "Quyen277", "hashed_password_277", null, false, false, "Vong277", null, "User", null, 0 },
                    { new Guid("298219b8-b89c-4379-b338-94b06d77aba1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k81@gmail.com", "Quyen81", "hashed_password_81", null, false, false, "Vong81", null, "User", null, 0 },
                    { new Guid("2a990b84-331e-4ec4-8543-78a75c7b3693"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k469@gmail.com", "Quyen469", "hashed_password_469", null, false, false, "Vong469", null, "User", null, 0 },
                    { new Guid("2ac9045e-5d18-4748-b32c-f46599e7a254"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k859@gmail.com", "Quyen859", "hashed_password_859", null, false, false, "Vong859", null, "User", null, 0 },
                    { new Guid("2af07ab4-b85d-4c75-9cd9-23e1476c83ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k893@gmail.com", "Quyen893", "hashed_password_893", null, false, false, "Vong893", null, "User", null, 0 },
                    { new Guid("2b22d0e0-42cb-4f33-b88e-7e4a84194b5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k200@gmail.com", "Quyen200", "hashed_password_200", null, false, false, "Vong200", null, "User", null, 0 },
                    { new Guid("2b6f12ee-1f5d-44f5-aeac-49f2c8d3f751"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k833@gmail.com", "Quyen833", "hashed_password_833", null, false, false, "Vong833", null, "User", null, 0 },
                    { new Guid("2bb9cc1c-c407-4610-94b0-f173be078a9e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k273@gmail.com", "Quyen273", "hashed_password_273", null, false, false, "Vong273", null, "User", null, 0 },
                    { new Guid("2bff3006-abe5-4c2f-8ba7-629ac1e61a63"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k976@gmail.com", "Quyen976", "hashed_password_976", null, false, false, "Vong976", null, "User", null, 0 },
                    { new Guid("2c16cca1-d4d5-46be-b6a2-e85952f4ad08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k890@gmail.com", "Quyen890", "hashed_password_890", null, false, false, "Vong890", null, "User", null, 0 },
                    { new Guid("2c1bc529-a2f1-43f5-950b-6ccdaf768dc9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k221@gmail.com", "Quyen221", "hashed_password_221", null, false, false, "Vong221", null, "User", null, 0 },
                    { new Guid("2c1f8aa9-5a0e-4101-a772-bddb52492aa6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k571@gmail.com", "Quyen571", "hashed_password_571", null, false, false, "Vong571", null, "User", null, 0 },
                    { new Guid("2c4d2f99-1723-4623-977c-58289258491e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k168@gmail.com", "Quyen168", "hashed_password_168", null, false, false, "Vong168", null, "User", null, 0 },
                    { new Guid("2cabe246-eb3f-4a55-9255-3f75a04f625f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k942@gmail.com", "Quyen942", "hashed_password_942", null, false, false, "Vong942", null, "User", null, 0 },
                    { new Guid("2cbf9735-88e5-4581-813e-9bcd11c3c659"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k901@gmail.com", "Quyen901", "hashed_password_901", null, false, false, "Vong901", null, "User", null, 0 },
                    { new Guid("2cc82b7a-ff81-4f6f-82e0-661add157499"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k232@gmail.com", "Quyen232", "hashed_password_232", null, false, false, "Vong232", null, "User", null, 0 },
                    { new Guid("2d13fe13-1984-4953-b4c4-02ec40e91da3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k857@gmail.com", "Quyen857", "hashed_password_857", null, false, false, "Vong857", null, "User", null, 0 },
                    { new Guid("2d4e8943-c9a8-47e8-b242-f837f2c7869f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k696@gmail.com", "Quyen696", "hashed_password_696", null, false, false, "Vong696", null, "User", null, 0 },
                    { new Guid("2d999923-f4b1-4e8a-a4a9-37795a4e6acb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k248@gmail.com", "Quyen248", "hashed_password_248", null, false, false, "Vong248", null, "User", null, 0 },
                    { new Guid("2da53ab0-6dc2-48df-8e02-305752e01bea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k854@gmail.com", "Quyen854", "hashed_password_854", null, false, false, "Vong854", null, "User", null, 0 },
                    { new Guid("2e03bec9-c1f3-4dfa-9e86-2d9723cf8bba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k233@gmail.com", "Quyen233", "hashed_password_233", null, false, false, "Vong233", null, "User", null, 0 },
                    { new Guid("2e0624e0-dca3-44a3-9ded-f61bf28276bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k970@gmail.com", "Quyen970", "hashed_password_970", null, false, false, "Vong970", null, "User", null, 0 },
                    { new Guid("2e66c49f-e313-4336-9473-782464e725cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k156@gmail.com", "Quyen156", "hashed_password_156", null, false, false, "Vong156", null, "User", null, 0 },
                    { new Guid("2e717b8c-a24e-4a64-8676-385c56e8d75d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k193@gmail.com", "Quyen193", "hashed_password_193", null, false, false, "Vong193", null, "User", null, 0 },
                    { new Guid("2ebc2121-9b84-43ce-8cb7-e41eb9e51a4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k417@gmail.com", "Quyen417", "hashed_password_417", null, false, false, "Vong417", null, "User", null, 0 },
                    { new Guid("2f429729-2724-453e-b483-b59e74f90558"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k568@gmail.com", "Quyen568", "hashed_password_568", null, false, false, "Vong568", null, "User", null, 0 },
                    { new Guid("2f523302-1c50-4fce-a1bd-400fb7d21cf1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k578@gmail.com", "Quyen578", "hashed_password_578", null, false, false, "Vong578", null, "User", null, 0 },
                    { new Guid("2f6ffef6-cc3b-4986-a1a5-35faaeecb5cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k387@gmail.com", "Quyen387", "hashed_password_387", null, false, false, "Vong387", null, "User", null, 0 },
                    { new Guid("2f8d9e9c-e502-4b50-8e24-affa3e1b711b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k609@gmail.com", "Quyen609", "hashed_password_609", null, false, false, "Vong609", null, "User", null, 0 },
                    { new Guid("2f984694-e5c2-438f-804a-1e7678dc3291"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k381@gmail.com", "Quyen381", "hashed_password_381", null, false, false, "Vong381", null, "User", null, 0 },
                    { new Guid("2fb66daa-1ba4-4603-bc91-825a667e3bf3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k509@gmail.com", "Quyen509", "hashed_password_509", null, false, false, "Vong509", null, "User", null, 0 },
                    { new Guid("2fd0d533-250c-4cbb-8bae-deb6f977a82a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k742@gmail.com", "Quyen742", "hashed_password_742", null, false, false, "Vong742", null, "User", null, 0 },
                    { new Guid("2ffcb4f5-1c86-4d41-8132-b3070c92735f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k537@gmail.com", "Quyen537", "hashed_password_537", null, false, false, "Vong537", null, "User", null, 0 },
                    { new Guid("3047dd36-fa52-4adf-9a49-03038fe9dbb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k574@gmail.com", "Quyen574", "hashed_password_574", null, false, false, "Vong574", null, "User", null, 0 },
                    { new Guid("304c9f87-63ea-4581-a0eb-a393c1977e26"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k810@gmail.com", "Quyen810", "hashed_password_810", null, false, false, "Vong810", null, "User", null, 0 },
                    { new Guid("30819fc5-0637-4a99-bbb2-38d1c5b3f9e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k180@gmail.com", "Quyen180", "hashed_password_180", null, false, false, "Vong180", null, "User", null, 0 },
                    { new Guid("3092e137-9c90-4554-8365-d86246a20e42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k196@gmail.com", "Quyen196", "hashed_password_196", null, false, false, "Vong196", null, "User", null, 0 },
                    { new Guid("30f0bd80-51ef-4bd7-829a-01932cc1e81d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k565@gmail.com", "Quyen565", "hashed_password_565", null, false, false, "Vong565", null, "User", null, 0 },
                    { new Guid("31516d29-464e-40fa-8023-993684560ae0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k297@gmail.com", "Quyen297", "hashed_password_297", null, false, false, "Vong297", null, "User", null, 0 },
                    { new Guid("3151ce8f-d3f8-4ecb-a922-052682d95900"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k290@gmail.com", "Quyen290", "hashed_password_290", null, false, false, "Vong290", null, "User", null, 0 },
                    { new Guid("31654c89-5b0c-4c06-9756-c8783af5a066"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k138@gmail.com", "Quyen138", "hashed_password_138", null, false, false, "Vong138", null, "User", null, 0 },
                    { new Guid("31693c10-ad26-4d41-8cc6-24d157f1fbda"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k908@gmail.com", "Quyen908", "hashed_password_908", null, false, false, "Vong908", null, "User", null, 0 },
                    { new Guid("31c587c2-96a0-4b05-9266-db86b18cee10"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k553@gmail.com", "Quyen553", "hashed_password_553", null, false, false, "Vong553", null, "User", null, 0 },
                    { new Guid("31faeeb3-c6d8-48aa-a228-f30abf465608"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k960@gmail.com", "Quyen960", "hashed_password_960", null, false, false, "Vong960", null, "User", null, 0 },
                    { new Guid("32440d90-8f4f-4c4d-86d8-184e8bbf0c04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k628@gmail.com", "Quyen628", "hashed_password_628", null, false, false, "Vong628", null, "User", null, 0 },
                    { new Guid("3269e442-43a1-4e07-8063-5baf9d8bf4de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k321@gmail.com", "Quyen321", "hashed_password_321", null, false, false, "Vong321", null, "User", null, 0 },
                    { new Guid("329c1598-c8b2-4aae-a37a-231d706fd052"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k44@gmail.com", "Quyen44", "hashed_password_44", null, false, false, "Vong44", null, "User", null, 0 },
                    { new Guid("330c08b2-1815-4dd1-b65e-fffe2ef061eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k350@gmail.com", "Quyen350", "hashed_password_350", null, false, false, "Vong350", null, "User", null, 0 },
                    { new Guid("33220f75-6114-4183-b52d-68bd638dc07a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k836@gmail.com", "Quyen836", "hashed_password_836", null, false, false, "Vong836", null, "User", null, 0 },
                    { new Guid("332279ff-5e0d-47dd-b709-7444c46f2572"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k348@gmail.com", "Quyen348", "hashed_password_348", null, false, false, "Vong348", null, "User", null, 0 },
                    { new Guid("33bd96c0-9ce7-4e53-95f5-59403eb08287"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k424@gmail.com", "Quyen424", "hashed_password_424", null, false, false, "Vong424", null, "User", null, 0 },
                    { new Guid("33be8522-6f32-4db3-baef-04ad3c3f326e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k766@gmail.com", "Quyen766", "hashed_password_766", null, false, false, "Vong766", null, "User", null, 0 },
                    { new Guid("33fa37f5-04a9-42d2-aed2-3e53fe1aadb1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k106@gmail.com", "Quyen106", "hashed_password_106", null, false, false, "Vong106", null, "User", null, 0 },
                    { new Guid("3422d3cc-b93f-4cf3-b350-3cc4cc6aa1bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k755@gmail.com", "Quyen755", "hashed_password_755", null, false, false, "Vong755", null, "User", null, 0 },
                    { new Guid("34449341-e789-4a04-b5be-6f6820c1e235"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k392@gmail.com", "Quyen392", "hashed_password_392", null, false, false, "Vong392", null, "User", null, 0 },
                    { new Guid("3491ef6c-e7b8-4ae0-bec2-3649371566bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k886@gmail.com", "Quyen886", "hashed_password_886", null, false, false, "Vong886", null, "User", null, 0 },
                    { new Guid("34e561f9-3f80-479e-b588-36616b0ebdcc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k453@gmail.com", "Quyen453", "hashed_password_453", null, false, false, "Vong453", null, "User", null, 0 },
                    { new Guid("354b2a73-2974-48b8-9f44-bedddba2800b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k876@gmail.com", "Quyen876", "hashed_password_876", null, false, false, "Vong876", null, "User", null, 0 },
                    { new Guid("35a9ad48-f95b-43ee-aa8f-b8924397ae2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k167@gmail.com", "Quyen167", "hashed_password_167", null, false, false, "Vong167", null, "User", null, 0 },
                    { new Guid("361a95a3-5409-4be6-8f23-46d6c8cdbec8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k86@gmail.com", "Quyen86", "hashed_password_86", null, false, false, "Vong86", null, "User", null, 0 },
                    { new Guid("369ad0e1-f17c-4d0e-b32c-c20d11133375"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k67@gmail.com", "Quyen67", "hashed_password_67", null, false, false, "Vong67", null, "User", null, 0 },
                    { new Guid("36f83d0f-4a4c-4fdd-8381-a4cfd0f62994"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k730@gmail.com", "Quyen730", "hashed_password_730", null, false, false, "Vong730", null, "User", null, 0 },
                    { new Guid("377c790b-2ed5-4185-adb1-164989500f63"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k377@gmail.com", "Quyen377", "hashed_password_377", null, false, false, "Vong377", null, "User", null, 0 },
                    { new Guid("384e0125-d1c1-4b4e-a1fe-3b046105321e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k76@gmail.com", "Quyen76", "hashed_password_76", null, false, false, "Vong76", null, "User", null, 0 },
                    { new Guid("384e102b-2dc9-4227-9f1e-a41f731d2852"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k878@gmail.com", "Quyen878", "hashed_password_878", null, false, false, "Vong878", null, "User", null, 0 },
                    { new Guid("386840a2-55c1-4c1c-b84b-ec21fab684ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k301@gmail.com", "Quyen301", "hashed_password_301", null, false, false, "Vong301", null, "User", null, 0 },
                    { new Guid("38782d37-0e71-48cb-9f1a-70eb8456146f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k530@gmail.com", "Quyen530", "hashed_password_530", null, false, false, "Vong530", null, "User", null, 0 },
                    { new Guid("38f496f1-1fcd-4fdc-bf9f-0417ce750245"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k139@gmail.com", "Quyen139", "hashed_password_139", null, false, false, "Vong139", null, "User", null, 0 },
                    { new Guid("39986407-5e9f-410e-8c28-8995d1f5cf10"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k705@gmail.com", "Quyen705", "hashed_password_705", null, false, false, "Vong705", null, "User", null, 0 },
                    { new Guid("39cd8407-d428-4ac8-ba48-3d533c6f9380"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k497@gmail.com", "Quyen497", "hashed_password_497", null, false, false, "Vong497", null, "User", null, 0 },
                    { new Guid("39de9a90-7dd7-41c4-a515-f01438a049a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k676@gmail.com", "Quyen676", "hashed_password_676", null, false, false, "Vong676", null, "User", null, 0 },
                    { new Guid("39fd9228-0613-4c67-a1f9-9e464d85634b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k108@gmail.com", "Quyen108", "hashed_password_108", null, false, false, "Vong108", null, "User", null, 0 },
                    { new Guid("39fe2fd7-b30e-4bdb-98cf-50eb79006191"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k664@gmail.com", "Quyen664", "hashed_password_664", null, false, false, "Vong664", null, "User", null, 0 },
                    { new Guid("3a22a94b-2c68-4668-b655-1c5e564d6adb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k660@gmail.com", "Quyen660", "hashed_password_660", null, false, false, "Vong660", null, "User", null, 0 },
                    { new Guid("3a24b656-9d49-48e2-961d-50db72866401"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k307@gmail.com", "Quyen307", "hashed_password_307", null, false, false, "Vong307", null, "User", null, 0 },
                    { new Guid("3a32ee8c-18b5-4cf0-8179-7a491cefc39e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k840@gmail.com", "Quyen840", "hashed_password_840", null, false, false, "Vong840", null, "User", null, 0 },
                    { new Guid("3a368cdb-ac5a-469b-ac45-8de8d6f8e6e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k754@gmail.com", "Quyen754", "hashed_password_754", null, false, false, "Vong754", null, "User", null, 0 },
                    { new Guid("3a568441-5ad4-426a-a4fc-00c479359120"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k483@gmail.com", "Quyen483", "hashed_password_483", null, false, false, "Vong483", null, "User", null, 0 },
                    { new Guid("3a5d669f-8ccf-4354-981e-415cb605090b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k596@gmail.com", "Quyen596", "hashed_password_596", null, false, false, "Vong596", null, "User", null, 0 },
                    { new Guid("3a7011d9-9186-40f3-83c8-5924f73a37ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k269@gmail.com", "Quyen269", "hashed_password_269", null, false, false, "Vong269", null, "User", null, 0 },
                    { new Guid("3a85f1f7-dfc9-4e25-8fd9-e7ff6ef76e80"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k531@gmail.com", "Quyen531", "hashed_password_531", null, false, false, "Vong531", null, "User", null, 0 },
                    { new Guid("3aa4bbea-8f62-4216-b9c6-25b7430edb23"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k797@gmail.com", "Quyen797", "hashed_password_797", null, false, false, "Vong797", null, "User", null, 0 },
                    { new Guid("3af0122c-9b62-4a7e-864d-f5e4ba9fb9e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k736@gmail.com", "Quyen736", "hashed_password_736", null, false, false, "Vong736", null, "User", null, 0 },
                    { new Guid("3af1da6b-d288-4d36-a9a7-84f014e5e2f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k839@gmail.com", "Quyen839", "hashed_password_839", null, false, false, "Vong839", null, "User", null, 0 },
                    { new Guid("3b93b084-e528-4561-a546-4aa3ccc182c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k835@gmail.com", "Quyen835", "hashed_password_835", null, false, false, "Vong835", null, "User", null, 0 },
                    { new Guid("3caa51c2-dd4c-4ece-a042-e37c9c45c896"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k548@gmail.com", "Quyen548", "hashed_password_548", null, false, false, "Vong548", null, "User", null, 0 },
                    { new Guid("3d14c013-4337-4ffe-8913-5d3306e78141"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k532@gmail.com", "Quyen532", "hashed_password_532", null, false, false, "Vong532", null, "User", null, 0 },
                    { new Guid("3e14154a-51fc-480c-8fd0-e9634a48600b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k597@gmail.com", "Quyen597", "hashed_password_597", null, false, false, "Vong597", null, "User", null, 0 },
                    { new Guid("3e34fef1-4486-4ba8-bb4f-78d98434a2d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k320@gmail.com", "Quyen320", "hashed_password_320", null, false, false, "Vong320", null, "User", null, 0 },
                    { new Guid("3e9d2cae-f753-4cde-b0cc-593a10b5d570"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k495@gmail.com", "Quyen495", "hashed_password_495", null, false, false, "Vong495", null, "User", null, 0 },
                    { new Guid("3ed001a9-ca63-4001-9b61-445072616a1e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k143@gmail.com", "Quyen143", "hashed_password_143", null, false, false, "Vong143", null, "User", null, 0 },
                    { new Guid("3f0dc2c0-3614-4065-8ed3-8a9a2aeb5221"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k606@gmail.com", "Quyen606", "hashed_password_606", null, false, false, "Vong606", null, "User", null, 0 },
                    { new Guid("3f1e7941-8534-4462-91a4-dcceba792bcb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k732@gmail.com", "Quyen732", "hashed_password_732", null, false, false, "Vong732", null, "User", null, 0 },
                    { new Guid("3f5312c0-5c9a-4c03-baa8-e38a440a1b75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k78@gmail.com", "Quyen78", "hashed_password_78", null, false, false, "Vong78", null, "User", null, 0 },
                    { new Guid("3f9e778e-2a7f-4444-8b58-a1f4acea0c54"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k136@gmail.com", "Quyen136", "hashed_password_136", null, false, false, "Vong136", null, "User", null, 0 },
                    { new Guid("4001cf22-1fc4-4d23-b25a-87af12ad66d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k645@gmail.com", "Quyen645", "hashed_password_645", null, false, false, "Vong645", null, "User", null, 0 },
                    { new Guid("400ab835-a5e2-4f92-a08f-913ba8b69c41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k539@gmail.com", "Quyen539", "hashed_password_539", null, false, false, "Vong539", null, "User", null, 0 },
                    { new Guid("4061153b-adf8-47cf-b930-ff91e8fef3c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k940@gmail.com", "Quyen940", "hashed_password_940", null, false, false, "Vong940", null, "User", null, 0 },
                    { new Guid("40b39248-f923-448a-a558-053e1e4c62db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k249@gmail.com", "Quyen249", "hashed_password_249", null, false, false, "Vong249", null, "User", null, 0 },
                    { new Guid("40f10196-046b-47b9-a4ce-c433d8b0eb20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k178@gmail.com", "Quyen178", "hashed_password_178", null, false, false, "Vong178", null, "User", null, 0 },
                    { new Guid("41013230-cb02-40ab-b068-9b6ce35bdd22"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k145@gmail.com", "Quyen145", "hashed_password_145", null, false, false, "Vong145", null, "User", null, 0 },
                    { new Guid("4117482c-1594-4019-b5d6-59ca3c9cc824"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k246@gmail.com", "Quyen246", "hashed_password_246", null, false, false, "Vong246", null, "User", null, 0 },
                    { new Guid("4181a6ce-129f-4867-bbf5-5a21fcbce1d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k164@gmail.com", "Quyen164", "hashed_password_164", null, false, false, "Vong164", null, "User", null, 0 },
                    { new Guid("41866376-a687-43f5-b0ce-90a10b27430c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k677@gmail.com", "Quyen677", "hashed_password_677", null, false, false, "Vong677", null, "User", null, 0 },
                    { new Guid("41da7dc8-f824-4167-ba28-3c87166328aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k602@gmail.com", "Quyen602", "hashed_password_602", null, false, false, "Vong602", null, "User", null, 0 },
                    { new Guid("420bb89a-30fb-49ca-b3e3-bb87fc4f3ed2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k493@gmail.com", "Quyen493", "hashed_password_493", null, false, false, "Vong493", null, "User", null, 0 },
                    { new Guid("4261af0c-c26d-436c-96b6-017f58195d01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k899@gmail.com", "Quyen899", "hashed_password_899", null, false, false, "Vong899", null, "User", null, 0 },
                    { new Guid("43253ba2-f89a-4fab-be79-9754a284b3b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k414@gmail.com", "Quyen414", "hashed_password_414", null, false, false, "Vong414", null, "User", null, 0 },
                    { new Guid("4332c75c-66d3-430c-9049-4e8c51603aea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k853@gmail.com", "Quyen853", "hashed_password_853", null, false, false, "Vong853", null, "User", null, 0 },
                    { new Guid("43acf221-9174-472c-be72-139f88223c14"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k426@gmail.com", "Quyen426", "hashed_password_426", null, false, false, "Vong426", null, "User", null, 0 },
                    { new Guid("43c5d74d-e7ec-422e-aa89-452d8a16150b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k127@gmail.com", "Quyen127", "hashed_password_127", null, false, false, "Vong127", null, "User", null, 0 },
                    { new Guid("44028c94-ad5f-4009-aa75-52127dabb68e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k818@gmail.com", "Quyen818", "hashed_password_818", null, false, false, "Vong818", null, "User", null, 0 },
                    { new Guid("441fcec5-865c-41e9-b11d-fe758308a421"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k560@gmail.com", "Quyen560", "hashed_password_560", null, false, false, "Vong560", null, "User", null, 0 },
                    { new Guid("443f3b45-a84c-4c10-8831-757aeee1e7a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k69@gmail.com", "Quyen69", "hashed_password_69", null, false, false, "Vong69", null, "User", null, 0 },
                    { new Guid("44622c80-d20e-4a8e-beec-56cdcb71969a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k457@gmail.com", "Quyen457", "hashed_password_457", null, false, false, "Vong457", null, "User", null, 0 },
                    { new Guid("449db17b-f21b-4631-8180-166989685cfb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k988@gmail.com", "Quyen988", "hashed_password_988", null, false, false, "Vong988", null, "User", null, 0 },
                    { new Guid("44a08591-302e-4147-a72e-c950c72014fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k184@gmail.com", "Quyen184", "hashed_password_184", null, false, false, "Vong184", null, "User", null, 0 },
                    { new Guid("44cfa4e3-5e90-41a3-a149-4e988e92a3a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k299@gmail.com", "Quyen299", "hashed_password_299", null, false, false, "Vong299", null, "User", null, 0 },
                    { new Guid("451c8890-7795-443d-ba72-297dda38f639"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k721@gmail.com", "Quyen721", "hashed_password_721", null, false, false, "Vong721", null, "User", null, 0 },
                    { new Guid("4580c2e1-68c8-46a9-893c-a35e76788300"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k30@gmail.com", "Quyen30", "hashed_password_30", null, false, false, "Vong30", null, "User", null, 0 },
                    { new Guid("458a0a88-5acf-439c-8805-0964eae45708"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k652@gmail.com", "Quyen652", "hashed_password_652", null, false, false, "Vong652", null, "User", null, 0 },
                    { new Guid("458b92b8-7c48-40c9-bbcf-21a75a8f03f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k465@gmail.com", "Quyen465", "hashed_password_465", null, false, false, "Vong465", null, "User", null, 0 },
                    { new Guid("4595dd09-4a81-41e5-8a2b-ae3108a07551"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k554@gmail.com", "Quyen554", "hashed_password_554", null, false, false, "Vong554", null, "User", null, 0 },
                    { new Guid("45d61b4f-df1b-443c-ab66-81be350d327e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k412@gmail.com", "Quyen412", "hashed_password_412", null, false, false, "Vong412", null, "User", null, 0 },
                    { new Guid("46a115c9-d039-4d42-b06e-09891c7517b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k131@gmail.com", "Quyen131", "hashed_password_131", null, false, false, "Vong131", null, "User", null, 0 },
                    { new Guid("46a54f53-c4ee-48f8-91ff-c31176ab76f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k812@gmail.com", "Quyen812", "hashed_password_812", null, false, false, "Vong812", null, "User", null, 0 },
                    { new Guid("46b6f32b-1782-4ebb-9d4f-b5276017fe9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k564@gmail.com", "Quyen564", "hashed_password_564", null, false, false, "Vong564", null, "User", null, 0 },
                    { new Guid("46fa3f74-634c-4b2c-91c5-ffde63535270"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k425@gmail.com", "Quyen425", "hashed_password_425", null, false, false, "Vong425", null, "User", null, 0 },
                    { new Guid("473aefef-12dc-4a39-b21b-26b569896a09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k536@gmail.com", "Quyen536", "hashed_password_536", null, false, false, "Vong536", null, "User", null, 0 },
                    { new Guid("4748b558-8439-4037-b70a-6b5ee14e29ad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k317@gmail.com", "Quyen317", "hashed_password_317", null, false, false, "Vong317", null, "User", null, 0 },
                    { new Guid("47799890-3d94-4df5-b058-bd4a6991fe08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k695@gmail.com", "Quyen695", "hashed_password_695", null, false, false, "Vong695", null, "User", null, 0 },
                    { new Guid("47eb39e0-9d9c-46f3-8d46-a5729d8b78c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k928@gmail.com", "Quyen928", "hashed_password_928", null, false, false, "Vong928", null, "User", null, 0 },
                    { new Guid("4820c37e-d22e-4d8e-a203-669fd0479e5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k2@gmail.com", "Quyen2", "hashed_password_2", null, false, false, "Vong2", null, "User", null, 0 },
                    { new Guid("48779851-87b1-407f-85d5-4960b416ca56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k830@gmail.com", "Quyen830", "hashed_password_830", null, false, false, "Vong830", null, "User", null, 0 },
                    { new Guid("4881661f-654e-4329-a34b-e2d1598ddc5f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k146@gmail.com", "Quyen146", "hashed_password_146", null, false, false, "Vong146", null, "User", null, 0 },
                    { new Guid("492dd220-b010-4349-8053-3067989e5d39"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k618@gmail.com", "Quyen618", "hashed_password_618", null, false, false, "Vong618", null, "User", null, 0 },
                    { new Guid("49b542ff-914c-492a-b222-a44fd17ceb06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k655@gmail.com", "Quyen655", "hashed_password_655", null, false, false, "Vong655", null, "User", null, 0 },
                    { new Guid("49efe51e-0d2c-4098-87d2-cdeb71ef4a63"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k870@gmail.com", "Quyen870", "hashed_password_870", null, false, false, "Vong870", null, "User", null, 0 },
                    { new Guid("49f87838-5a56-4074-9a05-02ef16bce578"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k804@gmail.com", "Quyen804", "hashed_password_804", null, false, false, "Vong804", null, "User", null, 0 },
                    { new Guid("4aa86138-bf75-4376-82c1-63689938457a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k21@gmail.com", "Quyen21", "hashed_password_21", null, false, false, "Vong21", null, "User", null, 0 },
                    { new Guid("4b299810-3bbb-470b-aef9-42c261721dfd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k711@gmail.com", "Quyen711", "hashed_password_711", null, false, false, "Vong711", null, "User", null, 0 },
                    { new Guid("4c23fa1e-3f3f-4a71-8290-a6e0f03e55d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k118@gmail.com", "Quyen118", "hashed_password_118", null, false, false, "Vong118", null, "User", null, 0 },
                    { new Guid("4c66954c-46c3-4c3e-b96d-d8447ac93728"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k545@gmail.com", "Quyen545", "hashed_password_545", null, false, false, "Vong545", null, "User", null, 0 },
                    { new Guid("4c91191c-d73d-49db-ac34-d0b5ae6e50a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k450@gmail.com", "Quyen450", "hashed_password_450", null, false, false, "Vong450", null, "User", null, 0 },
                    { new Guid("4c94832d-6446-415d-a186-1ece45e5c159"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k851@gmail.com", "Quyen851", "hashed_password_851", null, false, false, "Vong851", null, "User", null, 0 },
                    { new Guid("4c9bdd8f-0ac9-404d-95ec-a755fb491db5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k94@gmail.com", "Quyen94", "hashed_password_94", null, false, false, "Vong94", null, "User", null, 0 },
                    { new Guid("4cf4df10-ab4b-4ede-afb5-6b861df3150b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k360@gmail.com", "Quyen360", "hashed_password_360", null, false, false, "Vong360", null, "User", null, 0 },
                    { new Guid("4d0c0ac9-56ab-4f69-af95-f1087c0a1304"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k789@gmail.com", "Quyen789", "hashed_password_789", null, false, false, "Vong789", null, "User", null, 0 },
                    { new Guid("4d1265d6-3a33-40c8-8801-56e7e1434a65"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k920@gmail.com", "Quyen920", "hashed_password_920", null, false, false, "Vong920", null, "User", null, 0 },
                    { new Guid("4d840602-0a55-4f25-868f-52ecdb556b22"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k919@gmail.com", "Quyen919", "hashed_password_919", null, false, false, "Vong919", null, "User", null, 0 },
                    { new Guid("4e154eda-e076-4408-b37e-25008e9ffe31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k607@gmail.com", "Quyen607", "hashed_password_607", null, false, false, "Vong607", null, "User", null, 0 },
                    { new Guid("4e319c80-7b35-4041-9859-982da7c15d86"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k848@gmail.com", "Quyen848", "hashed_password_848", null, false, false, "Vong848", null, "User", null, 0 },
                    { new Guid("4e51884a-a683-4a50-bfc5-92cb99457d7b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k511@gmail.com", "Quyen511", "hashed_password_511", null, false, false, "Vong511", null, "User", null, 0 },
                    { new Guid("4e87ffbd-ba7e-4b13-8912-8f4312cd9948"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k586@gmail.com", "Quyen586", "hashed_password_586", null, false, false, "Vong586", null, "User", null, 0 },
                    { new Guid("4e9e0d36-a1e1-4e5f-9d4d-3ab19824055e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k89@gmail.com", "Quyen89", "hashed_password_89", null, false, false, "Vong89", null, "User", null, 0 },
                    { new Guid("4eabfacf-8615-4205-99dc-b0a63213570c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k768@gmail.com", "Quyen768", "hashed_password_768", null, false, false, "Vong768", null, "User", null, 0 },
                    { new Guid("4ed70dae-8498-4276-8228-ccf407041a34"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k844@gmail.com", "Quyen844", "hashed_password_844", null, false, false, "Vong844", null, "User", null, 0 },
                    { new Guid("4efae051-193e-479f-af88-36a83b0833e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k212@gmail.com", "Quyen212", "hashed_password_212", null, false, false, "Vong212", null, "User", null, 0 },
                    { new Guid("4f54e78c-3acb-4d41-b34b-fec1098762c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k124@gmail.com", "Quyen124", "hashed_password_124", null, false, false, "Vong124", null, "User", null, 0 },
                    { new Guid("4fab139f-cbc3-4ef8-aeb3-87278c4c7f42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k845@gmail.com", "Quyen845", "hashed_password_845", null, false, false, "Vong845", null, "User", null, 0 },
                    { new Guid("4fc3036b-ad24-4932-a9b4-af01ce048f09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k46@gmail.com", "Quyen46", "hashed_password_46", null, false, false, "Vong46", null, "User", null, 0 },
                    { new Guid("513f324f-5da1-4f34-82af-e955328d4ac2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k224@gmail.com", "Quyen224", "hashed_password_224", null, false, false, "Vong224", null, "User", null, 0 },
                    { new Guid("51a9b0c5-d66d-45b9-b178-ef4b77c475a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k185@gmail.com", "Quyen185", "hashed_password_185", null, false, false, "Vong185", null, "User", null, 0 },
                    { new Guid("51b7bd86-cce8-4ad4-b782-10c344e8809d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k665@gmail.com", "Quyen665", "hashed_password_665", null, false, false, "Vong665", null, "User", null, 0 },
                    { new Guid("51b867b4-54ac-4e43-9382-a3b6726c7b23"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k937@gmail.com", "Quyen937", "hashed_password_937", null, false, false, "Vong937", null, "User", null, 0 },
                    { new Guid("51c7c259-5b2b-4c39-b711-8f0a2c6a2bbe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k590@gmail.com", "Quyen590", "hashed_password_590", null, false, false, "Vong590", null, "User", null, 0 },
                    { new Guid("51ffcfb3-a344-4d40-a68c-0573ab63baa7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k815@gmail.com", "Quyen815", "hashed_password_815", null, false, false, "Vong815", null, "User", null, 0 },
                    { new Guid("520f9ed1-c974-4eed-b4da-e3e2e7ccfdd1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k201@gmail.com", "Quyen201", "hashed_password_201", null, false, false, "Vong201", null, "User", null, 0 },
                    { new Guid("5229484d-2ab4-403a-be89-0b753f119a73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k620@gmail.com", "Quyen620", "hashed_password_620", null, false, false, "Vong620", null, "User", null, 0 },
                    { new Guid("5259849a-be4d-45ea-8276-52b552947a32"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k427@gmail.com", "Quyen427", "hashed_password_427", null, false, false, "Vong427", null, "User", null, 0 },
                    { new Guid("52cd5bbf-fac8-4548-9240-15a84ae41572"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k623@gmail.com", "Quyen623", "hashed_password_623", null, false, false, "Vong623", null, "User", null, 0 },
                    { new Guid("5302aedc-f101-468b-833f-927a715cc6a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k446@gmail.com", "Quyen446", "hashed_password_446", null, false, false, "Vong446", null, "User", null, 0 },
                    { new Guid("53073e82-c1e7-492e-99fe-5d15be945585"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k941@gmail.com", "Quyen941", "hashed_password_941", null, false, false, "Vong941", null, "User", null, 0 },
                    { new Guid("531e6f52-d070-435d-bc86-4abbcaeb5cc3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k336@gmail.com", "Quyen336", "hashed_password_336", null, false, false, "Vong336", null, "User", null, 0 },
                    { new Guid("5362824b-f5c4-4bcb-832c-fa16c34ae2b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k117@gmail.com", "Quyen117", "hashed_password_117", null, false, false, "Vong117", null, "User", null, 0 },
                    { new Guid("53638b9e-3d70-4580-99ec-807d06c1d6ad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k480@gmail.com", "Quyen480", "hashed_password_480", null, false, false, "Vong480", null, "User", null, 0 },
                    { new Guid("53b9956b-9ecb-447e-af83-55bf554d6295"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k799@gmail.com", "Quyen799", "hashed_password_799", null, false, false, "Vong799", null, "User", null, 0 },
                    { new Guid("54b9ba3d-c71f-4a5a-8af1-9b0d309beda1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k520@gmail.com", "Quyen520", "hashed_password_520", null, false, false, "Vong520", null, "User", null, 0 },
                    { new Guid("54d58d37-7b8d-4d74-b5ca-77cd7d5a9d75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k144@gmail.com", "Quyen144", "hashed_password_144", null, false, false, "Vong144", null, "User", null, 0 },
                    { new Guid("54dafcf9-21e0-4789-94bb-1b669b7df235"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k257@gmail.com", "Quyen257", "hashed_password_257", null, false, false, "Vong257", null, "User", null, 0 },
                    { new Guid("555133d6-ca86-4a56-9fa2-299d3841ea05"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k959@gmail.com", "Quyen959", "hashed_password_959", null, false, false, "Vong959", null, "User", null, 0 },
                    { new Guid("559855c1-4532-4c08-8ec1-d761dc3b1381"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k217@gmail.com", "Quyen217", "hashed_password_217", null, false, false, "Vong217", null, "User", null, 0 },
                    { new Guid("55c8c033-0ffd-40cb-b40f-31ac41d7419b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k703@gmail.com", "Quyen703", "hashed_password_703", null, false, false, "Vong703", null, "User", null, 0 },
                    { new Guid("55dedae7-835f-4125-a164-a0857f844f47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k513@gmail.com", "Quyen513", "hashed_password_513", null, false, false, "Vong513", null, "User", null, 0 },
                    { new Guid("561bf85e-d507-4314-9c54-8f38a88e68ad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k709@gmail.com", "Quyen709", "hashed_password_709", null, false, false, "Vong709", null, "User", null, 0 },
                    { new Guid("56e8cff2-4eff-4a53-86ad-4c9eaee64767"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k309@gmail.com", "Quyen309", "hashed_password_309", null, false, false, "Vong309", null, "User", null, 0 },
                    { new Guid("5802f822-34a6-436f-b963-1bede8336c7c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k17@gmail.com", "Quyen17", "hashed_password_17", null, false, false, "Vong17", null, "User", null, 0 },
                    { new Guid("580c8aff-e511-42ce-b2f5-5eed9c46a1cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k775@gmail.com", "Quyen775", "hashed_password_775", null, false, false, "Vong775", null, "User", null, 0 },
                    { new Guid("5852e6e0-408e-41b8-982e-514f10eda8a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k284@gmail.com", "Quyen284", "hashed_password_284", null, false, false, "Vong284", null, "User", null, 0 },
                    { new Guid("5870679c-90c9-4765-a932-7981de21b9b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k491@gmail.com", "Quyen491", "hashed_password_491", null, false, false, "Vong491", null, "User", null, 0 },
                    { new Guid("59576a27-cc88-4c02-8e0b-73dc8da2730f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k353@gmail.com", "Quyen353", "hashed_password_353", null, false, false, "Vong353", null, "User", null, 0 },
                    { new Guid("59ae4c8a-ed70-4f3e-87b8-530729a3cbd2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k63@gmail.com", "Quyen63", "hashed_password_63", null, false, false, "Vong63", null, "User", null, 0 },
                    { new Guid("59e839b2-1023-4d6b-b3b7-53133646e3d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k614@gmail.com", "Quyen614", "hashed_password_614", null, false, false, "Vong614", null, "User", null, 0 },
                    { new Guid("5a202895-7d47-4334-8d01-47b003490835"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k883@gmail.com", "Quyen883", "hashed_password_883", null, false, false, "Vong883", null, "User", null, 0 },
                    { new Guid("5a24920c-0d02-48ce-8eeb-b5750153a946"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k203@gmail.com", "Quyen203", "hashed_password_203", null, false, false, "Vong203", null, "User", null, 0 },
                    { new Guid("5a9a49b9-916f-405f-8c4c-a61091bdaef8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k834@gmail.com", "Quyen834", "hashed_password_834", null, false, false, "Vong834", null, "User", null, 0 },
                    { new Guid("5aac70df-1e06-4952-99e6-b1763f08909f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k904@gmail.com", "Quyen904", "hashed_password_904", null, false, false, "Vong904", null, "User", null, 0 },
                    { new Guid("5b24df9b-e363-4bd9-bc41-7074873bf880"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k214@gmail.com", "Quyen214", "hashed_password_214", null, false, false, "Vong214", null, "User", null, 0 },
                    { new Guid("5b70c791-a258-453a-86a3-8d0cb603c02b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k291@gmail.com", "Quyen291", "hashed_password_291", null, false, false, "Vong291", null, "User", null, 0 },
                    { new Guid("5b81f8cf-dfc7-4246-9b37-fa24970ae437"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k64@gmail.com", "Quyen64", "hashed_password_64", null, false, false, "Vong64", null, "User", null, 0 },
                    { new Guid("5b8890d7-1091-42df-a667-fa010b77f042"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k792@gmail.com", "Quyen792", "hashed_password_792", null, false, false, "Vong792", null, "User", null, 0 },
                    { new Guid("5b8ee19a-5bd5-4cce-b63d-1f8d81e04673"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k452@gmail.com", "Quyen452", "hashed_password_452", null, false, false, "Vong452", null, "User", null, 0 },
                    { new Guid("5bba71b3-853c-4034-8fb4-10cb34ec3907"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k567@gmail.com", "Quyen567", "hashed_password_567", null, false, false, "Vong567", null, "User", null, 0 },
                    { new Guid("5bba9c10-c75d-4a13-b78d-2450b021cb2e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k355@gmail.com", "Quyen355", "hashed_password_355", null, false, false, "Vong355", null, "User", null, 0 },
                    { new Guid("5bd929b2-ad13-4709-a451-f45f2bdb3b35"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k374@gmail.com", "Quyen374", "hashed_password_374", null, false, false, "Vong374", null, "User", null, 0 },
                    { new Guid("5c3a3431-18a2-49a5-b480-aa463ac743ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k264@gmail.com", "Quyen264", "hashed_password_264", null, false, false, "Vong264", null, "User", null, 0 },
                    { new Guid("5c61e599-b254-42de-9652-e9bd7a7a9a1e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k256@gmail.com", "Quyen256", "hashed_password_256", null, false, false, "Vong256", null, "User", null, 0 },
                    { new Guid("5c85e5ac-c50b-421c-a21d-ea8faf832b65"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k275@gmail.com", "Quyen275", "hashed_password_275", null, false, false, "Vong275", null, "User", null, 0 },
                    { new Guid("5c8b8e50-1487-4608-b0b6-09492bce3588"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k379@gmail.com", "Quyen379", "hashed_password_379", null, false, false, "Vong379", null, "User", null, 0 },
                    { new Guid("5c992d32-42aa-48b2-b8de-ff0411363790"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k667@gmail.com", "Quyen667", "hashed_password_667", null, false, false, "Vong667", null, "User", null, 0 },
                    { new Guid("5cbeeda0-db43-46ec-a869-172aaf8f87ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k52@gmail.com", "Quyen52", "hashed_password_52", null, false, false, "Vong52", null, "User", null, 0 },
                    { new Guid("5d480c64-8153-47f0-9550-173e79089538"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k524@gmail.com", "Quyen524", "hashed_password_524", null, false, false, "Vong524", null, "User", null, 0 },
                    { new Guid("5dd245d3-fd9a-4fa5-a89d-254bd1f82298"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k995@gmail.com", "Quyen995", "hashed_password_995", null, false, false, "Vong995", null, "User", null, 0 },
                    { new Guid("5ddd5cef-84dd-40f2-b97f-d5afeeffed30"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k161@gmail.com", "Quyen161", "hashed_password_161", null, false, false, "Vong161", null, "User", null, 0 },
                    { new Guid("5e2738c6-6d4a-4abb-92d0-75d297f9abfd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k786@gmail.com", "Quyen786", "hashed_password_786", null, false, false, "Vong786", null, "User", null, 0 },
                    { new Guid("5e4cae58-1709-419e-8e7e-4e68d7659e86"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k639@gmail.com", "Quyen639", "hashed_password_639", null, false, false, "Vong639", null, "User", null, 0 },
                    { new Guid("5e8b99cc-0fb9-4039-ba04-2a28f529b589"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k35@gmail.com", "Quyen35", "hashed_password_35", null, false, false, "Vong35", null, "User", null, 0 },
                    { new Guid("5f702a44-0598-4ed8-af70-4386363b4c9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k671@gmail.com", "Quyen671", "hashed_password_671", null, false, false, "Vong671", null, "User", null, 0 },
                    { new Guid("5ff27c96-4064-49bd-bbf1-2a4cb3e234e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k542@gmail.com", "Quyen542", "hashed_password_542", null, false, false, "Vong542", null, "User", null, 0 },
                    { new Guid("5fffbf5f-e7fe-4f82-9d38-a76817341896"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k954@gmail.com", "Quyen954", "hashed_password_954", null, false, false, "Vong954", null, "User", null, 0 },
                    { new Guid("6049393b-bef6-4f46-8636-4e6d45b05355"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k759@gmail.com", "Quyen759", "hashed_password_759", null, false, false, "Vong759", null, "User", null, 0 },
                    { new Guid("604c67e4-5a4d-4aa2-bd04-c39ea3aac457"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k693@gmail.com", "Quyen693", "hashed_password_693", null, false, false, "Vong693", null, "User", null, 0 },
                    { new Guid("60db38e3-6675-44ee-a670-6b7d1b2d9de3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k97@gmail.com", "Quyen97", "hashed_password_97", null, false, false, "Vong97", null, "User", null, 0 },
                    { new Guid("612a3cbd-454e-4c97-a8e9-b23272e80648"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k777@gmail.com", "Quyen777", "hashed_password_777", null, false, false, "Vong777", null, "User", null, 0 },
                    { new Guid("6167e2a0-8ee2-435e-b13e-2ad5fcc1edc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k101@gmail.com", "Quyen101", "hashed_password_101", null, false, false, "Vong101", null, "User", null, 0 },
                    { new Guid("616e4690-0833-44eb-8157-273567fe4d0e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k807@gmail.com", "Quyen807", "hashed_password_807", null, false, false, "Vong807", null, "User", null, 0 },
                    { new Guid("61cb5b21-355e-478b-a7c5-2ff172808f62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k707@gmail.com", "Quyen707", "hashed_password_707", null, false, false, "Vong707", null, "User", null, 0 },
                    { new Guid("61e2babd-3989-41e9-9af9-5e145ff6d6a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k900@gmail.com", "Quyen900", "hashed_password_900", null, false, false, "Vong900", null, "User", null, 0 },
                    { new Guid("61e4bb24-8557-46d8-9499-51484b3b8afc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k718@gmail.com", "Quyen718", "hashed_password_718", null, false, false, "Vong718", null, "User", null, 0 },
                    { new Guid("62f729ad-e11e-471b-84ff-0c8581f4a97c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k756@gmail.com", "Quyen756", "hashed_password_756", null, false, false, "Vong756", null, "User", null, 0 },
                    { new Guid("635129e4-6ded-4011-bd33-f3ddb3df3749"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k383@gmail.com", "Quyen383", "hashed_password_383", null, false, false, "Vong383", null, "User", null, 0 },
                    { new Guid("63998d36-a540-45d1-9693-bd7d17390b6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k391@gmail.com", "Quyen391", "hashed_password_391", null, false, false, "Vong391", null, "User", null, 0 },
                    { new Guid("63d351e4-af6d-4d5a-8c51-f875a9554603"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k413@gmail.com", "Quyen413", "hashed_password_413", null, false, false, "Vong413", null, "User", null, 0 },
                    { new Guid("641c8fce-0079-4a61-8e58-e42a958681ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k134@gmail.com", "Quyen134", "hashed_password_134", null, false, false, "Vong134", null, "User", null, 0 },
                    { new Guid("643914b3-ef16-428a-93c3-915ef64233ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k518@gmail.com", "Quyen518", "hashed_password_518", null, false, false, "Vong518", null, "User", null, 0 },
                    { new Guid("6469d915-a4cf-4c6a-bf35-d98953e3b444"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k697@gmail.com", "Quyen697", "hashed_password_697", null, false, false, "Vong697", null, "User", null, 0 },
                    { new Guid("649815a8-e6ea-4cca-8fde-c02c1c28b9c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k181@gmail.com", "Quyen181", "hashed_password_181", null, false, false, "Vong181", null, "User", null, 0 },
                    { new Guid("64b8e88c-8d79-4866-9801-30d9ff9b9aa3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k507@gmail.com", "Quyen507", "hashed_password_507", null, false, false, "Vong507", null, "User", null, 0 },
                    { new Guid("65643851-ce35-4a66-8f5b-6997879100e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k679@gmail.com", "Quyen679", "hashed_password_679", null, false, false, "Vong679", null, "User", null, 0 },
                    { new Guid("658eb7a2-d821-4b20-9311-cfe24b7fe555"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k114@gmail.com", "Quyen114", "hashed_password_114", null, false, false, "Vong114", null, "User", null, 0 },
                    { new Guid("65b558a4-7e67-4afc-af07-1ffd8ced062d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k423@gmail.com", "Quyen423", "hashed_password_423", null, false, false, "Vong423", null, "User", null, 0 },
                    { new Guid("65f5c6e9-e33b-45d4-8012-539f433b940b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k729@gmail.com", "Quyen729", "hashed_password_729", null, false, false, "Vong729", null, "User", null, 0 },
                    { new Guid("669242dd-2a8f-4325-ab88-79010042fce5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k13@gmail.com", "Quyen13", "hashed_password_13", null, false, false, "Vong13", null, "User", null, 0 },
                    { new Guid("669263a4-466b-4bd8-be38-f1bce0159289"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k895@gmail.com", "Quyen895", "hashed_password_895", null, false, false, "Vong895", null, "User", null, 0 },
                    { new Guid("66fba489-c8bd-44c4-a8c8-d93f0e017e38"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k751@gmail.com", "Quyen751", "hashed_password_751", null, false, false, "Vong751", null, "User", null, 0 },
                    { new Guid("67590569-0d99-4f73-8fca-63f41417fd7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k739@gmail.com", "Quyen739", "hashed_password_739", null, false, false, "Vong739", null, "User", null, 0 },
                    { new Guid("6785c795-2cd6-4d2a-a246-2693b2a5969c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k934@gmail.com", "Quyen934", "hashed_password_934", null, false, false, "Vong934", null, "User", null, 0 },
                    { new Guid("67cc6021-e2aa-4296-aa37-394004809acf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k142@gmail.com", "Quyen142", "hashed_password_142", null, false, false, "Vong142", null, "User", null, 0 },
                    { new Guid("67fc3aaf-995e-4ab1-a091-b1daf15c459d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k407@gmail.com", "Quyen407", "hashed_password_407", null, false, false, "Vong407", null, "User", null, 0 },
                    { new Guid("680c1d60-5868-44bb-88fa-1427a304f791"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k462@gmail.com", "Quyen462", "hashed_password_462", null, false, false, "Vong462", null, "User", null, 0 },
                    { new Guid("68530c61-446d-4a64-9d2a-eacf7684d98b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k566@gmail.com", "Quyen566", "hashed_password_566", null, false, false, "Vong566", null, "User", null, 0 },
                    { new Guid("6884e090-969b-4305-af34-4d8723e440de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k312@gmail.com", "Quyen312", "hashed_password_312", null, false, false, "Vong312", null, "User", null, 0 },
                    { new Guid("692970fb-4c4a-45f1-8fbd-80f9d4de3894"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k179@gmail.com", "Quyen179", "hashed_password_179", null, false, false, "Vong179", null, "User", null, 0 },
                    { new Guid("697d8e88-78ca-40be-9282-28daa81f278c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k363@gmail.com", "Quyen363", "hashed_password_363", null, false, false, "Vong363", null, "User", null, 0 },
                    { new Guid("69bd0f1b-9a59-4a2c-9675-26fc9563073a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k990@gmail.com", "Quyen990", "hashed_password_990", null, false, false, "Vong990", null, "User", null, 0 },
                    { new Guid("6a33890c-5fd2-491a-93e6-0aaa75537f06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k150@gmail.com", "Quyen150", "hashed_password_150", null, false, false, "Vong150", null, "User", null, 0 },
                    { new Guid("6a7ce9a7-91e2-45b8-853d-bd2c2ac1cd04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k795@gmail.com", "Quyen795", "hashed_password_795", null, false, false, "Vong795", null, "User", null, 0 },
                    { new Guid("6b344ccd-7470-4a65-9ab0-20e6e11126ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k456@gmail.com", "Quyen456", "hashed_password_456", null, false, false, "Vong456", null, "User", null, 0 },
                    { new Guid("6b803687-4cc9-42d3-8b3d-144e8c5bfa4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k454@gmail.com", "Quyen454", "hashed_password_454", null, false, false, "Vong454", null, "User", null, 0 },
                    { new Guid("6b80597c-5af3-4b11-8550-e0b7a27c6205"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k105@gmail.com", "Quyen105", "hashed_password_105", null, false, false, "Vong105", null, "User", null, 0 },
                    { new Guid("6bfe179a-cb30-4a28-9ba1-ba7f12a7eefc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k521@gmail.com", "Quyen521", "hashed_password_521", null, false, false, "Vong521", null, "User", null, 0 },
                    { new Guid("6c17af18-6379-4f74-b0a5-c283249cd4a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k802@gmail.com", "Quyen802", "hashed_password_802", null, false, false, "Vong802", null, "User", null, 0 },
                    { new Guid("6c1cfda2-6b92-4b09-9f9c-d6f49d74d71f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k549@gmail.com", "Quyen549", "hashed_password_549", null, false, false, "Vong549", null, "User", null, 0 },
                    { new Guid("6c84cfdb-e909-4911-ac90-8ead6dda6ef2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k220@gmail.com", "Quyen220", "hashed_password_220", null, false, false, "Vong220", null, "User", null, 0 },
                    { new Guid("6ce2668d-4c33-4e6e-949e-0db1d24830c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k771@gmail.com", "Quyen771", "hashed_password_771", null, false, false, "Vong771", null, "User", null, 0 },
                    { new Guid("6d450421-aef1-4109-958b-6a727d84884c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k991@gmail.com", "Quyen991", "hashed_password_991", null, false, false, "Vong991", null, "User", null, 0 },
                    { new Guid("6d4ef642-27dc-4433-8a59-177251780fb9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k39@gmail.com", "Quyen39", "hashed_password_39", null, false, false, "Vong39", null, "User", null, 0 },
                    { new Guid("6d815fd3-5a57-4534-842b-16f70a919fd9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k332@gmail.com", "Quyen332", "hashed_password_332", null, false, false, "Vong332", null, "User", null, 0 },
                    { new Guid("6dee356c-649d-465f-916e-056362cbb50a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k279@gmail.com", "Quyen279", "hashed_password_279", null, false, false, "Vong279", null, "User", null, 0 },
                    { new Guid("6e21d2ac-911e-4a08-9573-1030098723de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k182@gmail.com", "Quyen182", "hashed_password_182", null, false, false, "Vong182", null, "User", null, 0 },
                    { new Guid("6e337908-357d-488b-9de2-2b7fba16ba86"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k533@gmail.com", "Quyen533", "hashed_password_533", null, false, false, "Vong533", null, "User", null, 0 },
                    { new Guid("6e7a8bb6-a083-4779-a430-301d461031c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k627@gmail.com", "Quyen627", "hashed_password_627", null, false, false, "Vong627", null, "User", null, 0 },
                    { new Guid("6e962d1a-688c-4198-932c-eb4e2f6c79d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k311@gmail.com", "Quyen311", "hashed_password_311", null, false, false, "Vong311", null, "User", null, 0 },
                    { new Guid("6ea33d60-902d-434d-b979-aba86360f776"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k882@gmail.com", "Quyen882", "hashed_password_882", null, false, false, "Vong882", null, "User", null, 0 },
                    { new Guid("6eab0316-3eb0-47fe-9e45-b069c13f95c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k107@gmail.com", "Quyen107", "hashed_password_107", null, false, false, "Vong107", null, "User", null, 0 },
                    { new Guid("6ef318a3-1c8a-46f0-9b00-5f9d8177bc14"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k470@gmail.com", "Quyen470", "hashed_password_470", null, false, false, "Vong470", null, "User", null, 0 },
                    { new Guid("6f112f55-84c6-4535-886d-090e71f1a46f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k49@gmail.com", "Quyen49", "hashed_password_49", null, false, false, "Vong49", null, "User", null, 0 },
                    { new Guid("6f770273-c4df-4454-bbc6-c04dcfebf963"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k683@gmail.com", "Quyen683", "hashed_password_683", null, false, false, "Vong683", null, "User", null, 0 },
                    { new Guid("6fa5276f-8d6d-4b09-9690-830fd5ddefdb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k50@gmail.com", "Quyen50", "hashed_password_50", null, false, false, "Vong50", null, "User", null, 0 },
                    { new Guid("6fd129ff-ba35-49a6-a0ee-932eff45e76f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k280@gmail.com", "Quyen280", "hashed_password_280", null, false, false, "Vong280", null, "User", null, 0 },
                    { new Guid("6feeebfe-7be3-4af3-938b-76d61ad91565"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k879@gmail.com", "Quyen879", "hashed_password_879", null, false, false, "Vong879", null, "User", null, 0 },
                    { new Guid("7025fa49-4ca3-498f-9a91-deb2293eac28"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k476@gmail.com", "Quyen476", "hashed_password_476", null, false, false, "Vong476", null, "User", null, 0 },
                    { new Guid("70cb5cfa-c891-4ca8-af99-63b7d3f206d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k70@gmail.com", "Quyen70", "hashed_password_70", null, false, false, "Vong70", null, "User", null, 0 },
                    { new Guid("70db5ec0-85bb-4893-b5cc-2cdc531405d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k562@gmail.com", "Quyen562", "hashed_password_562", null, false, false, "Vong562", null, "User", null, 0 },
                    { new Guid("70dd1e8c-d67f-465c-9241-385d90233026"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k913@gmail.com", "Quyen913", "hashed_password_913", null, false, false, "Vong913", null, "User", null, 0 },
                    { new Guid("7113902b-a3dc-4422-bd77-a86f7ac96ad7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k204@gmail.com", "Quyen204", "hashed_password_204", null, false, false, "Vong204", null, "User", null, 0 },
                    { new Guid("712b93b4-2fef-4e28-9c72-c34c3fe95186"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k601@gmail.com", "Quyen601", "hashed_password_601", null, false, false, "Vong601", null, "User", null, 0 },
                    { new Guid("72762b46-7dbd-4e5e-a8c5-ad036e92104a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k202@gmail.com", "Quyen202", "hashed_password_202", null, false, false, "Vong202", null, "User", null, 0 },
                    { new Guid("72f98f6e-6545-451b-96c1-e9e72b3fef38"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k110@gmail.com", "Quyen110", "hashed_password_110", null, false, false, "Vong110", null, "User", null, 0 },
                    { new Guid("73479c12-e5e3-48c6-a86d-90e68dd6a37e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k190@gmail.com", "Quyen190", "hashed_password_190", null, false, false, "Vong190", null, "User", null, 0 },
                    { new Guid("735e631c-965b-4081-b861-56263b9ad7db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k365@gmail.com", "Quyen365", "hashed_password_365", null, false, false, "Vong365", null, "User", null, 0 },
                    { new Guid("74a68264-16db-4bf1-b480-b1c4dc68f255"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k862@gmail.com", "Quyen862", "hashed_password_862", null, false, false, "Vong862", null, "User", null, 0 },
                    { new Guid("74a7f2ec-bf76-4611-9330-b7bb332e1071"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k388@gmail.com", "Quyen388", "hashed_password_388", null, false, false, "Vong388", null, "User", null, 0 },
                    { new Guid("74ae26f7-cc3b-4081-adb6-f2c3c13ff0b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k981@gmail.com", "Quyen981", "hashed_password_981", null, false, false, "Vong981", null, "User", null, 0 },
                    { new Guid("74b7c20b-55be-48e2-8189-e437cdc3ac60"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k467@gmail.com", "Quyen467", "hashed_password_467", null, false, false, "Vong467", null, "User", null, 0 },
                    { new Guid("74d32af1-6d18-438c-b4e0-a7510865f1f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k915@gmail.com", "Quyen915", "hashed_password_915", null, false, false, "Vong915", null, "User", null, 0 },
                    { new Guid("74f59802-f34f-4b05-a565-22071b86b58c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k361@gmail.com", "Quyen361", "hashed_password_361", null, false, false, "Vong361", null, "User", null, 0 },
                    { new Guid("7506006d-4296-4a47-97a2-03e3250368e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k436@gmail.com", "Quyen436", "hashed_password_436", null, false, false, "Vong436", null, "User", null, 0 },
                    { new Guid("755ad1e8-e1ba-4284-9e5a-eb6095c9b26b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "kin332k5@gmail.com", "Quyen", "hashed_password_1", null, false, false, "Vong", null, "User", null, 0 },
                    { new Guid("75722094-f2fa-4b91-aa32-1984315ab718"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k57@gmail.com", "Quyen57", "hashed_password_57", null, false, false, "Vong57", null, "User", null, 0 },
                    { new Guid("75ed37e0-3c13-403b-b87e-055e8b2b1448"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k540@gmail.com", "Quyen540", "hashed_password_540", null, false, false, "Vong540", null, "User", null, 0 },
                    { new Guid("761ed5c9-57a9-4400-87b8-473c923c6209"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k7@gmail.com", "Quyen7", "hashed_password_7", null, false, false, "Vong7", null, "User", null, 0 },
                    { new Guid("76659b18-a10b-4ade-abe7-55ab8b8226ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k191@gmail.com", "Quyen191", "hashed_password_191", null, false, false, "Vong191", null, "User", null, 0 },
                    { new Guid("76cce67c-89f7-409e-a7df-06c9ed09933f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k362@gmail.com", "Quyen362", "hashed_password_362", null, false, false, "Vong362", null, "User", null, 0 },
                    { new Guid("770f610b-b5c5-4908-90f5-e265b4b1cf4f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k971@gmail.com", "Quyen971", "hashed_password_971", null, false, false, "Vong971", null, "User", null, 0 },
                    { new Guid("7873868b-d905-45f6-af2a-014976f6ef1c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k159@gmail.com", "Quyen159", "hashed_password_159", null, false, false, "Vong159", null, "User", null, 0 },
                    { new Guid("78bfac24-b2b6-4377-a61e-e39ae4007b6e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k428@gmail.com", "Quyen428", "hashed_password_428", null, false, false, "Vong428", null, "User", null, 0 },
                    { new Guid("793617cb-fbb5-4bd7-86df-60ee8a2a2140"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k715@gmail.com", "Quyen715", "hashed_password_715", null, false, false, "Vong715", null, "User", null, 0 },
                    { new Guid("7960d142-e218-460e-8180-fddd3d7f89c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k378@gmail.com", "Quyen378", "hashed_password_378", null, false, false, "Vong378", null, "User", null, 0 },
                    { new Guid("7977f787-8eaa-4d3e-b4ab-01119237bce1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k15@gmail.com", "Quyen15", "hashed_password_15", null, false, false, "Vong15", null, "User", null, 0 },
                    { new Guid("79c44790-3840-4187-9dbf-ccfcb64b1d67"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k65@gmail.com", "Quyen65", "hashed_password_65", null, false, false, "Vong65", null, "User", null, 0 },
                    { new Guid("79ca6d90-1678-483f-b0a9-a2a28bd0b1b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k474@gmail.com", "Quyen474", "hashed_password_474", null, false, false, "Vong474", null, "User", null, 0 },
                    { new Guid("7a3faeb4-fc0b-40ff-941d-59db4824bca8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k843@gmail.com", "Quyen843", "hashed_password_843", null, false, false, "Vong843", null, "User", null, 0 },
                    { new Guid("7a4fe61e-e188-4423-a950-e43ea8303cb5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k872@gmail.com", "Quyen872", "hashed_password_872", null, false, false, "Vong872", null, "User", null, 0 },
                    { new Guid("7a847966-6b18-453f-b2ab-194afe322f38"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k584@gmail.com", "Quyen584", "hashed_password_584", null, false, false, "Vong584", null, "User", null, 0 },
                    { new Guid("7abbc736-e53b-44f1-a678-38964bb6e8fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k74@gmail.com", "Quyen74", "hashed_password_74", null, false, false, "Vong74", null, "User", null, 0 },
                    { new Guid("7b32f3bd-a482-49dd-bd10-7f5cbe3848f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k552@gmail.com", "Quyen552", "hashed_password_552", null, false, false, "Vong552", null, "User", null, 0 },
                    { new Guid("7badeb49-d511-4a3d-b12b-8005b1447f84"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k563@gmail.com", "Quyen563", "hashed_password_563", null, false, false, "Vong563", null, "User", null, 0 },
                    { new Guid("7c0c85ce-ffb0-4a69-8b25-90706fde6519"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k405@gmail.com", "Quyen405", "hashed_password_405", null, false, false, "Vong405", null, "User", null, 0 },
                    { new Guid("7c11a134-26b8-4b53-815b-c27d55048f7b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k442@gmail.com", "Quyen442", "hashed_password_442", null, false, false, "Vong442", null, "User", null, 0 },
                    { new Guid("7c7627d2-3cf7-488b-8276-9ad1a3cc4c99"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k488@gmail.com", "Quyen488", "hashed_password_488", null, false, false, "Vong488", null, "User", null, 0 },
                    { new Guid("7c82d0dd-e649-4e2a-a642-a21466af35b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k640@gmail.com", "Quyen640", "hashed_password_640", null, false, false, "Vong640", null, "User", null, 0 },
                    { new Guid("7c9b742a-4212-4c99-bd9c-27cdb8354766"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k675@gmail.com", "Quyen675", "hashed_password_675", null, false, false, "Vong675", null, "User", null, 0 },
                    { new Guid("7cc8fc86-2d86-4598-a73e-1f99430294b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k826@gmail.com", "Quyen826", "hashed_password_826", null, false, false, "Vong826", null, "User", null, 0 },
                    { new Guid("7ce892b9-eb0e-44c5-abe9-853a40781202"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k907@gmail.com", "Quyen907", "hashed_password_907", null, false, false, "Vong907", null, "User", null, 0 },
                    { new Guid("7cf5dffa-1ede-44c7-9ffc-e44a73c879c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k85@gmail.com", "Quyen85", "hashed_password_85", null, false, false, "Vong85", null, "User", null, 0 },
                    { new Guid("7d254014-fbbd-4651-b9e1-93cc75703ac7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k543@gmail.com", "Quyen543", "hashed_password_543", null, false, false, "Vong543", null, "User", null, 0 },
                    { new Guid("7d898635-4212-4f1a-990b-948fa638ddaf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k737@gmail.com", "Quyen737", "hashed_password_737", null, false, false, "Vong737", null, "User", null, 0 },
                    { new Guid("7ded07f9-cbb6-48f3-83cf-864d8a0c215f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k331@gmail.com", "Quyen331", "hashed_password_331", null, false, false, "Vong331", null, "User", null, 0 },
                    { new Guid("7e0c5934-ce28-4ab8-93ca-a30cce4c0196"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k801@gmail.com", "Quyen801", "hashed_password_801", null, false, false, "Vong801", null, "User", null, 0 },
                    { new Guid("7e2faee0-5d0c-4e66-adfa-80c83fbe46bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k238@gmail.com", "Quyen238", "hashed_password_238", null, false, false, "Vong238", null, "User", null, 0 },
                    { new Guid("7e3fb607-1704-45df-af77-c3126abfc7c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k162@gmail.com", "Quyen162", "hashed_password_162", null, false, false, "Vong162", null, "User", null, 0 },
                    { new Guid("7e619e47-6899-4237-9d0b-390b0b0ab1aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k147@gmail.com", "Quyen147", "hashed_password_147", null, false, false, "Vong147", null, "User", null, 0 },
                    { new Guid("7e893193-1502-4912-8fb5-c018093cb46e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k92@gmail.com", "Quyen92", "hashed_password_92", null, false, false, "Vong92", null, "User", null, 0 },
                    { new Guid("7eaf6245-d674-41aa-978a-e6e0eed5ed1e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k708@gmail.com", "Quyen708", "hashed_password_708", null, false, false, "Vong708", null, "User", null, 0 },
                    { new Guid("7ef1fde3-5835-4b1b-af0a-444563a61bf4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k11@gmail.com", "Quyen11", "hashed_password_11", null, false, false, "Vong11", null, "User", null, 0 },
                    { new Guid("7f3e13ad-7c38-4458-9680-f3c26bcd6422"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k459@gmail.com", "Quyen459", "hashed_password_459", null, false, false, "Vong459", null, "User", null, 0 },
                    { new Guid("7fc336ca-55ee-444c-9849-875385a9082f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k226@gmail.com", "Quyen226", "hashed_password_226", null, false, false, "Vong226", null, "User", null, 0 },
                    { new Guid("7fd94883-75ce-40c8-b9f4-23f373d49fe1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k605@gmail.com", "Quyen605", "hashed_password_605", null, false, false, "Vong605", null, "User", null, 0 },
                    { new Guid("7ff8aaef-e2ad-4a52-b5ed-c594c2b0574e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k272@gmail.com", "Quyen272", "hashed_password_272", null, false, false, "Vong272", null, "User", null, 0 },
                    { new Guid("808c3b87-0967-4dc3-9795-a63a426cd171"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k948@gmail.com", "Quyen948", "hashed_password_948", null, false, false, "Vong948", null, "User", null, 0 },
                    { new Guid("81680233-270f-4e08-8a28-ff6ecbd1993d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k776@gmail.com", "Quyen776", "hashed_password_776", null, false, false, "Vong776", null, "User", null, 0 },
                    { new Guid("81c51f2b-21c9-4827-b827-ce72dd324f62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k95@gmail.com", "Quyen95", "hashed_password_95", null, false, false, "Vong95", null, "User", null, 0 },
                    { new Guid("82315fdd-8166-417f-8fe1-093a90dd3b2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k471@gmail.com", "Quyen471", "hashed_password_471", null, false, false, "Vong471", null, "User", null, 0 },
                    { new Guid("82e16b46-6660-432c-b06b-e0ce02dd67b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k887@gmail.com", "Quyen887", "hashed_password_887", null, false, false, "Vong887", null, "User", null, 0 },
                    { new Guid("82e89932-53ae-4c16-b634-49f0ed84cd9d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k56@gmail.com", "Quyen56", "hashed_password_56", null, false, false, "Vong56", null, "User", null, 0 },
                    { new Guid("8337bb4a-abc9-496b-97cf-71cb42c31a6d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k334@gmail.com", "Quyen334", "hashed_password_334", null, false, false, "Vong334", null, "User", null, 0 },
                    { new Guid("83569c20-d47e-4e95-aeb5-ad0a67b9e97a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k694@gmail.com", "Quyen694", "hashed_password_694", null, false, false, "Vong694", null, "User", null, 0 },
                    { new Guid("836bcea0-d11f-4b47-af8a-2cf6f952fb35"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k458@gmail.com", "Quyen458", "hashed_password_458", null, false, false, "Vong458", null, "User", null, 0 },
                    { new Guid("841b50d9-2b39-401f-b2b8-a35b52e117a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k935@gmail.com", "Quyen935", "hashed_password_935", null, false, false, "Vong935", null, "User", null, 0 },
                    { new Guid("842e98ee-bebb-457b-af25-0ab6f9ba592e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k342@gmail.com", "Quyen342", "hashed_password_342", null, false, false, "Vong342", null, "User", null, 0 },
                    { new Guid("848fa79f-5f7c-459a-a9f6-eb12c5b1c35d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k575@gmail.com", "Quyen575", "hashed_password_575", null, false, false, "Vong575", null, "User", null, 0 },
                    { new Guid("84c155c1-66bf-4afb-875e-127a206370ab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k3@gmail.com", "Quyen3", "hashed_password_3", null, false, false, "Vong3", null, "User", null, 0 },
                    { new Guid("851ff1d7-8885-4725-b75e-ae3073bf031e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k447@gmail.com", "Quyen447", "hashed_password_447", null, false, false, "Vong447", null, "User", null, 0 },
                    { new Guid("85205d17-0bff-4f59-8bad-f264135d843b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k713@gmail.com", "Quyen713", "hashed_password_713", null, false, false, "Vong713", null, "User", null, 0 },
                    { new Guid("8525a97e-cd63-4160-a562-d0e4259d35a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k589@gmail.com", "Quyen589", "hashed_password_589", null, false, false, "Vong589", null, "User", null, 0 },
                    { new Guid("85aa2fdf-9c9b-492d-9963-2daa1f3f5931"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k847@gmail.com", "Quyen847", "hashed_password_847", null, false, false, "Vong847", null, "User", null, 0 },
                    { new Guid("86406bbe-89e8-49fa-997e-116303a7cc65"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k393@gmail.com", "Quyen393", "hashed_password_393", null, false, false, "Vong393", null, "User", null, 0 },
                    { new Guid("869606b7-0b2c-4ea1-95b6-726c087f9b31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k506@gmail.com", "Quyen506", "hashed_password_506", null, false, false, "Vong506", null, "User", null, 0 },
                    { new Guid("86cd98a2-2d63-4149-b0f9-4f99accf70c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k194@gmail.com", "Quyen194", "hashed_password_194", null, false, false, "Vong194", null, "User", null, 0 },
                    { new Guid("86f68c23-8ee1-4498-a4c4-f096630051cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k704@gmail.com", "Quyen704", "hashed_password_704", null, false, false, "Vong704", null, "User", null, 0 },
                    { new Guid("872d4e02-2d46-4616-b876-e9196a54c8ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k914@gmail.com", "Quyen914", "hashed_password_914", null, false, false, "Vong914", null, "User", null, 0 },
                    { new Guid("874806bf-cd31-4749-816d-c197d0ff8222"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k420@gmail.com", "Quyen420", "hashed_password_420", null, false, false, "Vong420", null, "User", null, 0 },
                    { new Guid("87a6d3f2-0dae-40f9-be23-2accb0c264fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k538@gmail.com", "Quyen538", "hashed_password_538", null, false, false, "Vong538", null, "User", null, 0 },
                    { new Guid("87c003d3-949d-4997-8158-c69c55d75226"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k978@gmail.com", "Quyen978", "hashed_password_978", null, false, false, "Vong978", null, "User", null, 0 },
                    { new Guid("883c462f-52e8-4468-8638-5c257d670042"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k558@gmail.com", "Quyen558", "hashed_password_558", null, false, false, "Vong558", null, "User", null, 0 },
                    { new Guid("884c3daf-19d7-456c-81e7-6be5d11726dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k130@gmail.com", "Quyen130", "hashed_password_130", null, false, false, "Vong130", null, "User", null, 0 },
                    { new Guid("8873a2c6-9658-4e91-b2b9-3f6954121e94"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k369@gmail.com", "Quyen369", "hashed_password_369", null, false, false, "Vong369", null, "User", null, 0 },
                    { new Guid("88967d3e-f06c-4563-9b41-f7f691ddc9f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k979@gmail.com", "Quyen979", "hashed_password_979", null, false, false, "Vong979", null, "User", null, 0 },
                    { new Guid("88e0b123-d93f-4cb9-ba31-107da746ddb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k685@gmail.com", "Quyen685", "hashed_password_685", null, false, false, "Vong685", null, "User", null, 0 },
                    { new Guid("891f26ef-ae8f-40de-9762-583783b7355f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k805@gmail.com", "Quyen805", "hashed_password_805", null, false, false, "Vong805", null, "User", null, 0 },
                    { new Guid("8956d7ae-6cae-4aad-9869-ff4a6b6063f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k23@gmail.com", "Quyen23", "hashed_password_23", null, false, false, "Vong23", null, "User", null, 0 },
                    { new Guid("89b5744e-7869-4b9e-a866-cd647336e7a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k223@gmail.com", "Quyen223", "hashed_password_223", null, false, false, "Vong223", null, "User", null, 0 },
                    { new Guid("8a6771ca-a8fe-471b-a06b-9ea3a6cb89ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k121@gmail.com", "Quyen121", "hashed_password_121", null, false, false, "Vong121", null, "User", null, 0 },
                    { new Guid("8a8abbb9-4303-4a0d-b355-c5c50bf0d5cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k975@gmail.com", "Quyen975", "hashed_password_975", null, false, false, "Vong975", null, "User", null, 0 },
                    { new Guid("8aa18ff9-b008-43cb-b815-a173a65428c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k829@gmail.com", "Quyen829", "hashed_password_829", null, false, false, "Vong829", null, "User", null, 0 },
                    { new Guid("8ab75032-fce6-4e18-ae62-7759542ea96e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k468@gmail.com", "Quyen468", "hashed_password_468", null, false, false, "Vong468", null, "User", null, 0 },
                    { new Guid("8ad1041c-4690-42c0-8d73-5f35a8a8714a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k129@gmail.com", "Quyen129", "hashed_password_129", null, false, false, "Vong129", null, "User", null, 0 },
                    { new Guid("8ae60e29-612f-4bbb-ac21-6247c41ca336"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k236@gmail.com", "Quyen236", "hashed_password_236", null, false, false, "Vong236", null, "User", null, 0 },
                    { new Guid("8af5a2c5-284e-45ae-a728-42a9bc5bb44f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k849@gmail.com", "Quyen849", "hashed_password_849", null, false, false, "Vong849", null, "User", null, 0 },
                    { new Guid("8b205774-0111-45c3-94b4-b8dd5e7385fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k817@gmail.com", "Quyen817", "hashed_password_817", null, false, false, "Vong817", null, "User", null, 0 },
                    { new Guid("8b51efb1-ef21-44bc-9041-b9f4482a53cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k132@gmail.com", "Quyen132", "hashed_password_132", null, false, false, "Vong132", null, "User", null, 0 },
                    { new Guid("8bcc873c-db83-488f-a030-f50463e96671"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k126@gmail.com", "Quyen126", "hashed_password_126", null, false, false, "Vong126", null, "User", null, 0 },
                    { new Guid("8c2b9d75-731e-44c6-a8d0-bd65b1a08049"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k654@gmail.com", "Quyen654", "hashed_password_654", null, false, false, "Vong654", null, "User", null, 0 },
                    { new Guid("8c51b8a0-74d7-40b8-8e2b-5a91260d7146"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k603@gmail.com", "Quyen603", "hashed_password_603", null, false, false, "Vong603", null, "User", null, 0 },
                    { new Guid("8c5e9f6d-92b2-477a-83b7-d26260ec6bf2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k753@gmail.com", "Quyen753", "hashed_password_753", null, false, false, "Vong753", null, "User", null, 0 },
                    { new Guid("8ccde4a7-fc05-4308-81bd-fb8f3407ed00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k690@gmail.com", "Quyen690", "hashed_password_690", null, false, false, "Vong690", null, "User", null, 0 },
                    { new Guid("8ccf1e3f-a317-4887-bd7a-4e4a173350b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k622@gmail.com", "Quyen622", "hashed_password_622", null, false, false, "Vong622", null, "User", null, 0 },
                    { new Guid("8d5b3a7e-5b6f-4bb6-9966-d464dc644958"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k98@gmail.com", "Quyen98", "hashed_password_98", null, false, false, "Vong98", null, "User", null, 0 },
                    { new Guid("8d707d8d-e8dc-4374-b3e1-e6655c735e7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k71@gmail.com", "Quyen71", "hashed_password_71", null, false, false, "Vong71", null, "User", null, 0 },
                    { new Guid("8d7989a4-c786-47a7-bf3b-33a8c5d5c631"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k25@gmail.com", "Quyen25", "hashed_password_25", null, false, false, "Vong25", null, "User", null, 0 },
                    { new Guid("8d895045-241f-4c14-8673-7c9247ab8b6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k59@gmail.com", "Quyen59", "hashed_password_59", null, false, false, "Vong59", null, "User", null, 0 },
                    { new Guid("8da694b3-c50a-4bbf-9416-069314de3977"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k322@gmail.com", "Quyen322", "hashed_password_322", null, false, false, "Vong322", null, "User", null, 0 },
                    { new Guid("8db0d8a2-c36e-4ecf-9b3c-f8aa32e12dfe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k668@gmail.com", "Quyen668", "hashed_password_668", null, false, false, "Vong668", null, "User", null, 0 },
                    { new Guid("8dbb4eeb-ccba-4546-933f-1a71ec368ad3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k32@gmail.com", "Quyen32", "hashed_password_32", null, false, false, "Vong32", null, "User", null, 0 },
                    { new Guid("8dbdb975-2d41-44d4-9810-0e6ea220d38f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k663@gmail.com", "Quyen663", "hashed_password_663", null, false, false, "Vong663", null, "User", null, 0 },
                    { new Guid("8de1cdf8-36f9-41ab-9aa4-3200c6435533"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k782@gmail.com", "Quyen782", "hashed_password_782", null, false, false, "Vong782", null, "User", null, 0 },
                    { new Guid("8e80fa43-4bcf-46da-bee6-909cb30b6e89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k790@gmail.com", "Quyen790", "hashed_password_790", null, false, false, "Vong790", null, "User", null, 0 },
                    { new Guid("8e83e846-25cb-48bb-bb3e-ec4578254b3c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k55@gmail.com", "Quyen55", "hashed_password_55", null, false, false, "Vong55", null, "User", null, 0 },
                    { new Guid("8e963667-f6b7-4ce4-9601-282b4e2d726a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k399@gmail.com", "Quyen399", "hashed_password_399", null, false, false, "Vong399", null, "User", null, 0 },
                    { new Guid("8ea87a22-8a11-40a0-aba5-23d66343d52c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k791@gmail.com", "Quyen791", "hashed_password_791", null, false, false, "Vong791", null, "User", null, 0 },
                    { new Guid("8ef460c3-6f4e-41da-bfe5-a8aa5206dba0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k962@gmail.com", "Quyen962", "hashed_password_962", null, false, false, "Vong962", null, "User", null, 0 },
                    { new Guid("8f06018d-848b-4d60-b895-0b6576ffe310"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k341@gmail.com", "Quyen341", "hashed_password_341", null, false, false, "Vong341", null, "User", null, 0 },
                    { new Guid("8f10d28a-0ab5-49f9-ac7d-f4fb0142024a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k615@gmail.com", "Quyen615", "hashed_password_615", null, false, false, "Vong615", null, "User", null, 0 },
                    { new Guid("8f644f89-16b1-4855-abea-f1a42e59787a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k550@gmail.com", "Quyen550", "hashed_password_550", null, false, false, "Vong550", null, "User", null, 0 },
                    { new Guid("8f6c04e8-abc8-4d12-8ddc-db084f1ec52c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k448@gmail.com", "Quyen448", "hashed_password_448", null, false, false, "Vong448", null, "User", null, 0 },
                    { new Guid("8f9e0d75-ac8f-4131-b691-cd40b3ccdd1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k384@gmail.com", "Quyen384", "hashed_password_384", null, false, false, "Vong384", null, "User", null, 0 },
                    { new Guid("8ffe8344-6085-4f2c-85a8-7b30a7e02dbe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k73@gmail.com", "Quyen73", "hashed_password_73", null, false, false, "Vong73", null, "User", null, 0 },
                    { new Guid("907e718e-f3f2-48f2-9de3-066d982d3918"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k72@gmail.com", "Quyen72", "hashed_password_72", null, false, false, "Vong72", null, "User", null, 0 },
                    { new Guid("9097e51b-450f-4eff-9faa-e3caafe89645"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k429@gmail.com", "Quyen429", "hashed_password_429", null, false, false, "Vong429", null, "User", null, 0 },
                    { new Guid("90bbac31-0435-479c-85c0-e757128031be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k198@gmail.com", "Quyen198", "hashed_password_198", null, false, false, "Vong198", null, "User", null, 0 },
                    { new Guid("915ada34-447b-4190-a3c4-b04feec965dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k670@gmail.com", "Quyen670", "hashed_password_670", null, false, false, "Vong670", null, "User", null, 0 },
                    { new Guid("915b8d42-584e-4a93-93cb-3a1072011dfe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k529@gmail.com", "Quyen529", "hashed_password_529", null, false, false, "Vong529", null, "User", null, 0 },
                    { new Guid("92214317-b330-4103-ad56-5efe4bc1ba15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k666@gmail.com", "Quyen666", "hashed_password_666", null, false, false, "Vong666", null, "User", null, 0 },
                    { new Guid("923735b3-d24e-4386-9ce3-44ce06fb8bf3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k47@gmail.com", "Quyen47", "hashed_password_47", null, false, false, "Vong47", null, "User", null, 0 },
                    { new Guid("9237c775-32b0-44f9-8c48-03e0923c0e61"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k186@gmail.com", "Quyen186", "hashed_password_186", null, false, false, "Vong186", null, "User", null, 0 },
                    { new Guid("923c37e5-e9a6-4183-b664-c46e37851e4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k254@gmail.com", "Quyen254", "hashed_password_254", null, false, false, "Vong254", null, "User", null, 0 },
                    { new Guid("926d259a-e633-4f6d-b100-20455f692d2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k994@gmail.com", "Quyen994", "hashed_password_994", null, false, false, "Vong994", null, "User", null, 0 },
                    { new Guid("927cdfcd-d920-4648-aef9-f4813c66ca8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k1@gmail.com", "Quyen1", "hashed_password_1", null, false, false, "Vong1", null, "User", null, 0 },
                    { new Guid("92a66219-3939-4239-ac08-4df6fe781725"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k68@gmail.com", "Quyen68", "hashed_password_68", null, false, false, "Vong68", null, "User", null, 0 },
                    { new Guid("92b94e97-0408-4461-ab21-cddcfc4e3b63"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k113@gmail.com", "Quyen113", "hashed_password_113", null, false, false, "Vong113", null, "User", null, 0 },
                    { new Guid("92c50165-4ebe-4821-b3e6-1cd6c2c358ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k335@gmail.com", "Quyen335", "hashed_password_335", null, false, false, "Vong335", null, "User", null, 0 },
                    { new Guid("92e625e1-9e08-4c0f-b241-dcad153e844d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k475@gmail.com", "Quyen475", "hashed_password_475", null, false, false, "Vong475", null, "User", null, 0 },
                    { new Guid("930e5a41-d76c-4fcc-ac83-e8fa6376211c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k972@gmail.com", "Quyen972", "hashed_password_972", null, false, false, "Vong972", null, "User", null, 0 },
                    { new Guid("9315c005-de11-4e3d-a03e-f6cbe7fe278e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k599@gmail.com", "Quyen599", "hashed_password_599", null, false, false, "Vong599", null, "User", null, 0 },
                    { new Guid("93289348-3026-45d3-a6b7-a3c2f0e72e27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k750@gmail.com", "Quyen750", "hashed_password_750", null, false, false, "Vong750", null, "User", null, 0 },
                    { new Guid("937cc679-d456-46aa-a35e-f146974eaced"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k314@gmail.com", "Quyen314", "hashed_password_314", null, false, false, "Vong314", null, "User", null, 0 },
                    { new Guid("9385c756-e508-4404-ab9e-5cb62e727ef9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k787@gmail.com", "Quyen787", "hashed_password_787", null, false, false, "Vong787", null, "User", null, 0 },
                    { new Guid("93e794a2-03ca-4d3b-82b9-2c219d01b8c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k868@gmail.com", "Quyen868", "hashed_password_868", null, false, false, "Vong868", null, "User", null, 0 },
                    { new Guid("93fc0c0e-8c00-400d-b27e-f2555d77770f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k243@gmail.com", "Quyen243", "hashed_password_243", null, false, false, "Vong243", null, "User", null, 0 },
                    { new Guid("9424f44e-7ef6-4a01-bd7b-a18639160377"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k352@gmail.com", "Quyen352", "hashed_password_352", null, false, false, "Vong352", null, "User", null, 0 },
                    { new Guid("943061a4-9938-4e61-92a5-6395c7b80198"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k286@gmail.com", "Quyen286", "hashed_password_286", null, false, false, "Vong286", null, "User", null, 0 },
                    { new Guid("9432c32a-7fc8-4e16-8783-49f04d3ffe5b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k831@gmail.com", "Quyen831", "hashed_password_831", null, false, false, "Vong831", null, "User", null, 0 },
                    { new Guid("944d609c-85ff-4c06-8103-cfadeee824b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k116@gmail.com", "Quyen116", "hashed_password_116", null, false, false, "Vong116", null, "User", null, 0 },
                    { new Guid("9495d975-b0ae-4804-9171-90ed77850a47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k929@gmail.com", "Quyen929", "hashed_password_929", null, false, false, "Vong929", null, "User", null, 0 },
                    { new Guid("94bd894e-53e7-4d03-90d9-a993e98a2317"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k370@gmail.com", "Quyen370", "hashed_password_370", null, false, false, "Vong370", null, "User", null, 0 },
                    { new Guid("95527e24-b044-4242-83e6-b67ae5e1a48d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k263@gmail.com", "Quyen263", "hashed_password_263", null, false, false, "Vong263", null, "User", null, 0 },
                    { new Guid("956bc9b1-8ae3-43c1-918b-c7f736ad5b67"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k455@gmail.com", "Quyen455", "hashed_password_455", null, false, false, "Vong455", null, "User", null, 0 },
                    { new Guid("95a1288e-37a5-47f0-a39a-f2ae4a562cef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k93@gmail.com", "Quyen93", "hashed_password_93", null, false, false, "Vong93", null, "User", null, 0 },
                    { new Guid("9603e9e4-565c-4761-a3b0-eab4e67a8bc3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k544@gmail.com", "Quyen544", "hashed_password_544", null, false, false, "Vong544", null, "User", null, 0 },
                    { new Guid("965ee180-3318-42dd-a015-0acf21ecaf76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k577@gmail.com", "Quyen577", "hashed_password_577", null, false, false, "Vong577", null, "User", null, 0 },
                    { new Guid("96a90202-821d-4929-adce-3d43afca1155"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k112@gmail.com", "Quyen112", "hashed_password_112", null, false, false, "Vong112", null, "User", null, 0 },
                    { new Guid("96b6d9c5-6d3f-4130-aabd-e533c34284d2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k239@gmail.com", "Quyen239", "hashed_password_239", null, false, false, "Vong239", null, "User", null, 0 },
                    { new Guid("9755ae1e-6f55-4d5f-b5af-daaf4c06cdb6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k82@gmail.com", "Quyen82", "hashed_password_82", null, false, false, "Vong82", null, "User", null, 0 },
                    { new Guid("979cf14e-d1b2-44cf-a6f1-f885f9aa1431"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k302@gmail.com", "Quyen302", "hashed_password_302", null, false, false, "Vong302", null, "User", null, 0 },
                    { new Guid("97bc2b47-6646-4dcb-87a1-a0f14dcb1cb8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k315@gmail.com", "Quyen315", "hashed_password_315", null, false, false, "Vong315", null, "User", null, 0 },
                    { new Guid("983eef23-25fd-47fe-b5d8-c9ef45dd67d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k912@gmail.com", "Quyen912", "hashed_password_912", null, false, false, "Vong912", null, "User", null, 0 },
                    { new Guid("989b7eb0-b6eb-4139-a80c-8f6b33a87b8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k415@gmail.com", "Quyen415", "hashed_password_415", null, false, false, "Vong415", null, "User", null, 0 },
                    { new Guid("98a60bf1-0bac-4048-9b38-ff8b79c5aa57"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k885@gmail.com", "Quyen885", "hashed_password_885", null, false, false, "Vong885", null, "User", null, 0 },
                    { new Guid("991fd011-14af-4ee5-9887-eefbda1cea85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k642@gmail.com", "Quyen642", "hashed_password_642", null, false, false, "Vong642", null, "User", null, 0 },
                    { new Guid("99ae0a28-b218-4b7c-8f5d-b73555d2343a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k714@gmail.com", "Quyen714", "hashed_password_714", null, false, false, "Vong714", null, "User", null, 0 },
                    { new Guid("99e6a4b2-65ed-40a0-8b7c-138041a85893"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k109@gmail.com", "Quyen109", "hashed_password_109", null, false, false, "Vong109", null, "User", null, 0 },
                    { new Guid("9a64de80-19ec-4ec1-b793-5f5f329f17fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k691@gmail.com", "Quyen691", "hashed_password_691", null, false, false, "Vong691", null, "User", null, 0 },
                    { new Guid("9a92e9ff-1374-44ed-9bf0-e82e4472f978"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k165@gmail.com", "Quyen165", "hashed_password_165", null, false, false, "Vong165", null, "User", null, 0 },
                    { new Guid("9abb41a3-f51f-4f16-baac-bda043c680fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k634@gmail.com", "Quyen634", "hashed_password_634", null, false, false, "Vong634", null, "User", null, 0 },
                    { new Guid("9ace34c6-2b42-4de7-814c-09bfc04575b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k149@gmail.com", "Quyen149", "hashed_password_149", null, false, false, "Vong149", null, "User", null, 0 },
                    { new Guid("9af512e0-4acd-4858-9543-553ba7642a59"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k519@gmail.com", "Quyen519", "hashed_password_519", null, false, false, "Vong519", null, "User", null, 0 },
                    { new Guid("9b06be56-a8e6-4596-9579-44450dba1005"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k163@gmail.com", "Quyen163", "hashed_password_163", null, false, false, "Vong163", null, "User", null, 0 },
                    { new Guid("9b1b0729-e7f5-4dd2-9473-7da291052e40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k271@gmail.com", "Quyen271", "hashed_password_271", null, false, false, "Vong271", null, "User", null, 0 },
                    { new Guid("9b28332e-c0e6-47f9-8e77-63f0fbbc5636"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k780@gmail.com", "Quyen780", "hashed_password_780", null, false, false, "Vong780", null, "User", null, 0 },
                    { new Guid("9b312057-18c5-4517-85fb-d784633c6548"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k974@gmail.com", "Quyen974", "hashed_password_974", null, false, false, "Vong974", null, "User", null, 0 },
                    { new Guid("9b48a3db-64bb-4fb3-b428-c0c4e13602cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k961@gmail.com", "Quyen961", "hashed_password_961", null, false, false, "Vong961", null, "User", null, 0 },
                    { new Guid("9b5f87b5-3192-47fc-afb7-ac5d47e67a2e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k207@gmail.com", "Quyen207", "hashed_password_207", null, false, false, "Vong207", null, "User", null, 0 },
                    { new Guid("9ba38d58-b959-4bbd-8a23-97c9e7fef311"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k215@gmail.com", "Quyen215", "hashed_password_215", null, false, false, "Vong215", null, "User", null, 0 },
                    { new Guid("9c0217e2-4850-484a-97b8-990e3714c7f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k438@gmail.com", "Quyen438", "hashed_password_438", null, false, false, "Vong438", null, "User", null, 0 },
                    { new Guid("9c597972-64ac-4c9f-bf2f-5b180341eb35"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k710@gmail.com", "Quyen710", "hashed_password_710", null, false, false, "Vong710", null, "User", null, 0 },
                    { new Guid("9cb88818-a1e6-4a96-957e-c88948fea694"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k788@gmail.com", "Quyen788", "hashed_password_788", null, false, false, "Vong788", null, "User", null, 0 },
                    { new Guid("9d92c5f1-5a61-4b46-a6f6-8c23383373f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k932@gmail.com", "Quyen932", "hashed_password_932", null, false, false, "Vong932", null, "User", null, 0 },
                    { new Guid("9daf690a-0f28-494b-98f9-c26e6f70c952"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k496@gmail.com", "Quyen496", "hashed_password_496", null, false, false, "Vong496", null, "User", null, 0 },
                    { new Guid("9e80fa51-3f09-488a-b9c2-eb65430c1fbc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k10@gmail.com", "Quyen10", "hashed_password_10", null, false, false, "Vong10", null, "User", null, 0 },
                    { new Guid("9e9ace78-a05b-4eae-87c8-76fab88270e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k466@gmail.com", "Quyen466", "hashed_password_466", null, false, false, "Vong466", null, "User", null, 0 },
                    { new Guid("9eba8990-48de-4bb0-a0a0-be47f27813a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k772@gmail.com", "Quyen772", "hashed_password_772", null, false, false, "Vong772", null, "User", null, 0 },
                    { new Guid("9ee9db32-1a2f-46ff-95c1-d1847f2ad0d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k84@gmail.com", "Quyen84", "hashed_password_84", null, false, false, "Vong84", null, "User", null, 0 },
                    { new Guid("9f28c5c2-56fc-4669-85fd-bf02a20c29ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k77@gmail.com", "Quyen77", "hashed_password_77", null, false, false, "Vong77", null, "User", null, 0 },
                    { new Guid("9f571c77-791c-488d-9587-380f5fa0c75a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k946@gmail.com", "Quyen946", "hashed_password_946", null, false, false, "Vong946", null, "User", null, 0 },
                    { new Guid("9f5b51a5-f39e-46db-aa66-dacb274ed349"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k757@gmail.com", "Quyen757", "hashed_password_757", null, false, false, "Vong757", null, "User", null, 0 },
                    { new Guid("9f82d90e-2c94-4eca-bd68-8201493b9648"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k977@gmail.com", "Quyen977", "hashed_password_977", null, false, false, "Vong977", null, "User", null, 0 },
                    { new Guid("9faac760-0a35-4ad9-adcf-5807cbda3feb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k225@gmail.com", "Quyen225", "hashed_password_225", null, false, false, "Vong225", null, "User", null, 0 },
                    { new Guid("9ffebaee-b010-48f8-ba39-242df72e1347"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k746@gmail.com", "Quyen746", "hashed_password_746", null, false, false, "Vong746", null, "User", null, 0 },
                    { new Guid("9fff6395-7099-4536-add1-d5de0b96c82e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k492@gmail.com", "Quyen492", "hashed_password_492", null, false, false, "Vong492", null, "User", null, 0 },
                    { new Guid("a0b4a134-79aa-43f0-a411-57149ba63784"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k769@gmail.com", "Quyen769", "hashed_password_769", null, false, false, "Vong769", null, "User", null, 0 },
                    { new Guid("a1036444-3a01-44f4-a511-ea926796c2c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k838@gmail.com", "Quyen838", "hashed_password_838", null, false, false, "Vong838", null, "User", null, 0 },
                    { new Guid("a122af9a-cd10-4e28-9676-fb3ab9df2af8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k968@gmail.com", "Quyen968", "hashed_password_968", null, false, false, "Vong968", null, "User", null, 0 },
                    { new Guid("a1365815-d52f-4d1a-a10e-e00561276ed5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k102@gmail.com", "Quyen102", "hashed_password_102", null, false, false, "Vong102", null, "User", null, 0 },
                    { new Guid("a1798271-22ad-4deb-bc1f-f629d56b0015"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k823@gmail.com", "Quyen823", "hashed_password_823", null, false, false, "Vong823", null, "User", null, 0 },
                    { new Guid("a17f9534-a212-4154-b428-d78ca8b9e1ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k505@gmail.com", "Quyen505", "hashed_password_505", null, false, false, "Vong505", null, "User", null, 0 },
                    { new Guid("a1eadf68-ee2c-4f4e-811d-25e871ab7c65"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k608@gmail.com", "Quyen608", "hashed_password_608", null, false, false, "Vong608", null, "User", null, 0 },
                    { new Guid("a2b7e61f-23f3-47e9-8ad7-7116f4ba96e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k852@gmail.com", "Quyen852", "hashed_password_852", null, false, false, "Vong852", null, "User", null, 0 },
                    { new Guid("a2e76938-314b-4ea8-a6b0-154dda640de6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k764@gmail.com", "Quyen764", "hashed_password_764", null, false, false, "Vong764", null, "User", null, 0 },
                    { new Guid("a3063c22-473f-4115-830f-bf5e08eb2755"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k0@gmail.com", "Quyen0", "hashed_password_0", null, false, false, "Vong0", null, "User", null, 0 },
                    { new Guid("a3afe627-b388-41ac-8323-1deee4097c89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k653@gmail.com", "Quyen653", "hashed_password_653", null, false, false, "Vong653", null, "User", null, 0 },
                    { new Guid("a407623b-381a-41c0-b4eb-73aeb81481ab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k800@gmail.com", "Quyen800", "hashed_password_800", null, false, false, "Vong800", null, "User", null, 0 },
                    { new Guid("a43e496c-f068-4042-bef6-af0f8c9b13ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k16@gmail.com", "Quyen16", "hashed_password_16", null, false, false, "Vong16", null, "User", null, 0 },
                    { new Guid("a4dfa313-11ce-4b35-94d9-6aa279de87e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k996@gmail.com", "Quyen996", "hashed_password_996", null, false, false, "Vong996", null, "User", null, 0 },
                    { new Guid("a506f53e-642d-484a-bfbe-512c9d04f463"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k234@gmail.com", "Quyen234", "hashed_password_234", null, false, false, "Vong234", null, "User", null, 0 },
                    { new Guid("a5711de7-346b-4eed-95c5-40f1e81e1a4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k555@gmail.com", "Quyen555", "hashed_password_555", null, false, false, "Vong555", null, "User", null, 0 },
                    { new Guid("a5c8f41b-b48a-4984-b017-d59e659bceb1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k955@gmail.com", "Quyen955", "hashed_password_955", null, false, false, "Vong955", null, "User", null, 0 },
                    { new Guid("a6225a37-9d64-4cfd-a700-72dbb74162ab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k856@gmail.com", "Quyen856", "hashed_password_856", null, false, false, "Vong856", null, "User", null, 0 },
                    { new Guid("a631394c-b06b-49cb-88fd-23c3b1c0f26a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k227@gmail.com", "Quyen227", "hashed_password_227", null, false, false, "Vong227", null, "User", null, 0 },
                    { new Guid("a672521d-1915-4146-b491-f92db1281364"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k494@gmail.com", "Quyen494", "hashed_password_494", null, false, false, "Vong494", null, "User", null, 0 },
                    { new Guid("a69b3ef0-46b2-458f-8230-bea1bd774a8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k347@gmail.com", "Quyen347", "hashed_password_347", null, false, false, "Vong347", null, "User", null, 0 },
                    { new Guid("a6c615b3-eae1-4c86-984b-ca744cdfb409"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k298@gmail.com", "Quyen298", "hashed_password_298", null, false, false, "Vong298", null, "User", null, 0 },
                    { new Guid("a73d35d6-34c0-46d7-9820-1bf060c5dfbc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k48@gmail.com", "Quyen48", "hashed_password_48", null, false, false, "Vong48", null, "User", null, 0 },
                    { new Guid("a7c887cf-9d7b-490b-b8c2-ceb240f25f37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k880@gmail.com", "Quyen880", "hashed_password_880", null, false, false, "Vong880", null, "User", null, 0 },
                    { new Guid("a7cc6111-2472-4e1e-acce-06f912d1c5a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k632@gmail.com", "Quyen632", "hashed_password_632", null, false, false, "Vong632", null, "User", null, 0 },
                    { new Guid("a86e3032-4c33-48c7-9549-f8d51f6d6ca1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k860@gmail.com", "Quyen860", "hashed_password_860", null, false, false, "Vong860", null, "User", null, 0 },
                    { new Guid("a91e47c7-2213-4039-a928-135b564270c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k171@gmail.com", "Quyen171", "hashed_password_171", null, false, false, "Vong171", null, "User", null, 0 },
                    { new Guid("a943ec11-3ae4-42d9-965a-c75d64baf55d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k587@gmail.com", "Quyen587", "hashed_password_587", null, false, false, "Vong587", null, "User", null, 0 },
                    { new Guid("a99a3c43-7296-499f-8b70-146368c750e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k958@gmail.com", "Quyen958", "hashed_password_958", null, false, false, "Vong958", null, "User", null, 0 },
                    { new Guid("aa04d9d5-adf6-431d-a207-2be9000aab5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k726@gmail.com", "Quyen726", "hashed_password_726", null, false, false, "Vong726", null, "User", null, 0 },
                    { new Guid("aa0d77a4-d011-489b-a6c0-969086ffa53d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k916@gmail.com", "Quyen916", "hashed_password_916", null, false, false, "Vong916", null, "User", null, 0 },
                    { new Guid("aa13d25c-4e56-4327-a78a-4b30573c8591"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k364@gmail.com", "Quyen364", "hashed_password_364", null, false, false, "Vong364", null, "User", null, 0 },
                    { new Guid("aa4ac4f8-7768-416a-b703-01a3f796c4ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k865@gmail.com", "Quyen865", "hashed_password_865", null, false, false, "Vong865", null, "User", null, 0 },
                    { new Guid("aa5f90af-9b9a-43bf-9d40-61e63f3aa67c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k373@gmail.com", "Quyen373", "hashed_password_373", null, false, false, "Vong373", null, "User", null, 0 },
                    { new Guid("aa770bae-2246-4c84-b702-9c09725462d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k725@gmail.com", "Quyen725", "hashed_password_725", null, false, false, "Vong725", null, "User", null, 0 },
                    { new Guid("aa874dff-569e-41f6-b721-c08c7653dfad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k482@gmail.com", "Quyen482", "hashed_password_482", null, false, false, "Vong482", null, "User", null, 0 },
                    { new Guid("aaa5b75f-d70b-4d88-880e-f721f10ee6ee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k989@gmail.com", "Quyen989", "hashed_password_989", null, false, false, "Vong989", null, "User", null, 0 },
                    { new Guid("ab304953-caa9-460d-8a51-87d1d2159c04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k31@gmail.com", "Quyen31", "hashed_password_31", null, false, false, "Vong31", null, "User", null, 0 },
                    { new Guid("ab924c42-7880-4f3a-b87f-2f630a5e6b55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k612@gmail.com", "Quyen612", "hashed_password_612", null, false, false, "Vong612", null, "User", null, 0 },
                    { new Guid("aba0afb3-ffb9-42c0-8b6d-3cdd14b8f322"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k720@gmail.com", "Quyen720", "hashed_password_720", null, false, false, "Vong720", null, "User", null, 0 },
                    { new Guid("ac0070c3-f1ca-451e-b15d-54bd86e7f4b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k188@gmail.com", "Quyen188", "hashed_password_188", null, false, false, "Vong188", null, "User", null, 0 },
                    { new Guid("ac0e2ee3-c9c3-4dcb-a614-d3d408f73a6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k12@gmail.com", "Quyen12", "hashed_password_12", null, false, false, "Vong12", null, "User", null, 0 },
                    { new Guid("ac1ad1d8-133d-4b0c-be4f-eff5bad61da8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k4@gmail.com", "Quyen4", "hashed_password_4", null, false, false, "Vong4", null, "User", null, 0 },
                    { new Guid("ac236b56-e35f-4273-a702-40dbe2f605b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k579@gmail.com", "Quyen579", "hashed_password_579", null, false, false, "Vong579", null, "User", null, 0 },
                    { new Guid("ac60c825-3bd9-4c9f-be28-0b79d57e376d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k80@gmail.com", "Quyen80", "hashed_password_80", null, false, false, "Vong80", null, "User", null, 0 },
                    { new Guid("ac918e51-5f83-4125-8eb3-1ef2bc0a3ae0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k371@gmail.com", "Quyen371", "hashed_password_371", null, false, false, "Vong371", null, "User", null, 0 },
                    { new Guid("ad1dd8ad-1917-4c55-b94e-6cddedd7d46f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k512@gmail.com", "Quyen512", "hashed_password_512", null, false, false, "Vong512", null, "User", null, 0 },
                    { new Guid("ad5a7581-0fef-4ea9-9bdb-512bf09df38b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k636@gmail.com", "Quyen636", "hashed_password_636", null, false, false, "Vong636", null, "User", null, 0 },
                    { new Guid("ad756330-53da-436f-8602-67abd1e03eda"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k633@gmail.com", "Quyen633", "hashed_password_633", null, false, false, "Vong633", null, "User", null, 0 },
                    { new Guid("ad7dc2dc-4aa0-4d56-a3b9-3b1280a10a07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k195@gmail.com", "Quyen195", "hashed_password_195", null, false, false, "Vong195", null, "User", null, 0 },
                    { new Guid("ae0d34ff-267e-4885-b23c-016c3605ef10"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k724@gmail.com", "Quyen724", "hashed_password_724", null, false, false, "Vong724", null, "User", null, 0 },
                    { new Guid("aecc8724-9920-4447-a70a-348935c09250"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k861@gmail.com", "Quyen861", "hashed_password_861", null, false, false, "Vong861", null, "User", null, 0 },
                    { new Guid("aeef912e-9165-45fa-bc6d-7c7f0488e81d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k993@gmail.com", "Quyen993", "hashed_password_993", null, false, false, "Vong993", null, "User", null, 0 },
                    { new Guid("aef75ede-6572-47f0-a3aa-7b6005856391"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k152@gmail.com", "Quyen152", "hashed_password_152", null, false, false, "Vong152", null, "User", null, 0 },
                    { new Guid("af08ebf3-0f5b-4ac8-aa65-8b594fc5dc95"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k197@gmail.com", "Quyen197", "hashed_password_197", null, false, false, "Vong197", null, "User", null, 0 },
                    { new Guid("af125b56-df12-43ab-92b7-27c665f27dc8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k153@gmail.com", "Quyen153", "hashed_password_153", null, false, false, "Vong153", null, "User", null, 0 },
                    { new Guid("af59abf9-3a74-4bc4-a06f-798c2cfae79c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "User", null, 0 },
                    { new Guid("af7af7cf-9574-471d-832c-7dc701c873df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k673@gmail.com", "Quyen673", "hashed_password_673", null, false, false, "Vong673", null, "User", null, 0 },
                    { new Guid("af801049-31fe-4aa1-af97-441988a22395"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k422@gmail.com", "Quyen422", "hashed_password_422", null, false, false, "Vong422", null, "User", null, 0 },
                    { new Guid("af8debd2-7cbf-44dc-85db-d26ba7a9c252"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k29@gmail.com", "Quyen29", "hashed_password_29", null, false, false, "Vong29", null, "User", null, 0 },
                    { new Guid("b07c5aba-5dba-4099-8f4a-ad27900f8ddb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k253@gmail.com", "Quyen253", "hashed_password_253", null, false, false, "Vong253", null, "User", null, 0 },
                    { new Guid("b0af5917-f43e-458a-9eef-ca62e73b2803"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k894@gmail.com", "Quyen894", "hashed_password_894", null, false, false, "Vong894", null, "User", null, 0 },
                    { new Guid("b0f69887-ad41-48c5-ab8a-632297ab014e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k396@gmail.com", "Quyen396", "hashed_password_396", null, false, false, "Vong396", null, "User", null, 0 },
                    { new Guid("b0fc70ac-a120-4901-9aaf-4b8c5026c213"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k735@gmail.com", "Quyen735", "hashed_password_735", null, false, false, "Vong735", null, "User", null, 0 },
                    { new Guid("b17a2a5f-bb69-4cad-b691-3aab36c94cb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k526@gmail.com", "Quyen526", "hashed_password_526", null, false, false, "Vong526", null, "User", null, 0 },
                    { new Guid("b1b75017-7727-4cc5-960b-3f008a99efea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k9@gmail.com", "Quyen9", "hashed_password_9", null, false, false, "Vong9", null, "User", null, 0 },
                    { new Guid("b1e337e0-ef8b-4ee1-9760-04ea74c0851d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k939@gmail.com", "Quyen939", "hashed_password_939", null, false, false, "Vong939", null, "User", null, 0 },
                    { new Guid("b1f5cdd4-97fe-489b-8892-5888fb35c1f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k267@gmail.com", "Quyen267", "hashed_password_267", null, false, false, "Vong267", null, "User", null, 0 },
                    { new Guid("b21073de-1229-4618-a1b4-1aa939e27162"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k479@gmail.com", "Quyen479", "hashed_password_479", null, false, false, "Vong479", null, "User", null, 0 },
                    { new Guid("b287bdb2-d40d-4a97-b82e-1260f18a503e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k871@gmail.com", "Quyen871", "hashed_password_871", null, false, false, "Vong871", null, "User", null, 0 },
                    { new Guid("b29be192-6221-4ad7-b14d-5ca901c8c06c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k419@gmail.com", "Quyen419", "hashed_password_419", null, false, false, "Vong419", null, "User", null, 0 },
                    { new Guid("b2d83c80-d797-485b-b264-531032959aa5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k811@gmail.com", "Quyen811", "hashed_password_811", null, false, false, "Vong811", null, "User", null, 0 },
                    { new Guid("b2ee4ccd-bf76-4312-9b18-c0776c39b500"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k535@gmail.com", "Quyen535", "hashed_password_535", null, false, false, "Vong535", null, "User", null, 0 },
                    { new Guid("b2f65d70-112c-49e2-8416-cf75118f05a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k910@gmail.com", "Quyen910", "hashed_password_910", null, false, false, "Vong910", null, "User", null, 0 },
                    { new Guid("b33ea139-fd59-4bf2-896b-0efa1fd0abea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k984@gmail.com", "Quyen984", "hashed_password_984", null, false, false, "Vong984", null, "User", null, 0 },
                    { new Guid("b35c7312-2330-49be-a89c-3ee3d6b9b394"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k208@gmail.com", "Quyen208", "hashed_password_208", null, false, false, "Vong208", null, "User", null, 0 },
                    { new Guid("b4360034-4e52-4301-96f9-0c3478104e2a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k869@gmail.com", "Quyen869", "hashed_password_869", null, false, false, "Vong869", null, "User", null, 0 },
                    { new Guid("b436c3c2-526b-48c0-9cf3-24889c8f89e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k500@gmail.com", "Quyen500", "hashed_password_500", null, false, false, "Vong500", null, "User", null, 0 },
                    { new Guid("b45bcbf9-c09d-4352-b8db-90575b310345"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k947@gmail.com", "Quyen947", "hashed_password_947", null, false, false, "Vong947", null, "User", null, 0 },
                    { new Guid("b464f50f-60ac-400f-9c48-d27ace6c1e80"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k546@gmail.com", "Quyen546", "hashed_password_546", null, false, false, "Vong546", null, "User", null, 0 },
                    { new Guid("b46991c1-5d9c-44a9-a355-c6f599ce935c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k957@gmail.com", "Quyen957", "hashed_password_957", null, false, false, "Vong957", null, "User", null, 0 },
                    { new Guid("b4737372-2a70-45e8-bc13-1e5ba6a81919"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k449@gmail.com", "Quyen449", "hashed_password_449", null, false, false, "Vong449", null, "User", null, 0 },
                    { new Guid("b4f32196-be8e-4bd7-bbbd-765cbf9b117a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k820@gmail.com", "Quyen820", "hashed_password_820", null, false, false, "Vong820", null, "User", null, 0 },
                    { new Guid("b50f683a-df32-46ce-b0fd-3feb981879ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k100@gmail.com", "Quyen100", "hashed_password_100", null, false, false, "Vong100", null, "User", null, 0 },
                    { new Guid("b5429c7a-8edb-44f6-a303-9e7a0dbf7f84"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k62@gmail.com", "Quyen62", "hashed_password_62", null, false, false, "Vong62", null, "User", null, 0 },
                    { new Guid("b61466c1-6b72-483f-ab44-92b92579ca59"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k306@gmail.com", "Quyen306", "hashed_password_306", null, false, false, "Vong306", null, "User", null, 0 },
                    { new Guid("b6be9ade-352f-40a9-866f-65ceeb00b8f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k973@gmail.com", "Quyen973", "hashed_password_973", null, false, false, "Vong973", null, "User", null, 0 },
                    { new Guid("b6db8acb-1678-48f3-9857-b5442d490359"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k950@gmail.com", "Quyen950", "hashed_password_950", null, false, false, "Vong950", null, "User", null, 0 },
                    { new Guid("b80295e8-2a4e-4c50-aa3a-bfa5ff7f9c43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k752@gmail.com", "Quyen752", "hashed_password_752", null, false, false, "Vong752", null, "User", null, 0 },
                    { new Guid("b8629204-099c-4543-bdfa-817dcd4371cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k122@gmail.com", "Quyen122", "hashed_password_122", null, false, false, "Vong122", null, "User", null, 0 },
                    { new Guid("b8faf0bc-f096-434e-9c09-11c0acf0bf81"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k832@gmail.com", "Quyen832", "hashed_password_832", null, false, false, "Vong832", null, "User", null, 0 },
                    { new Guid("b9433cb8-a231-4068-bb6e-959892ff0660"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k390@gmail.com", "Quyen390", "hashed_password_390", null, false, false, "Vong390", null, "User", null, 0 },
                    { new Guid("b9b27e1b-bbba-4bb2-a272-989c464662ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k240@gmail.com", "Quyen240", "hashed_password_240", null, false, false, "Vong240", null, "User", null, 0 },
                    { new Guid("b9f4bd6e-8d02-4b91-bca9-73938ab9b30c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k616@gmail.com", "Quyen616", "hashed_password_616", null, false, false, "Vong616", null, "User", null, 0 },
                    { new Guid("baabd20b-5052-429a-b6e2-01be67c4d364"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k270@gmail.com", "Quyen270", "hashed_password_270", null, false, false, "Vong270", null, "User", null, 0 },
                    { new Guid("babe67d4-b715-4465-a28d-53b6336473a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k24@gmail.com", "Quyen24", "hashed_password_24", null, false, false, "Vong24", null, "User", null, 0 },
                    { new Guid("baf3073b-6c24-4c86-b261-438e768c3196"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k229@gmail.com", "Quyen229", "hashed_password_229", null, false, false, "Vong229", null, "User", null, 0 },
                    { new Guid("bb13b97b-05b0-4ff6-9346-cd5378e447e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k255@gmail.com", "Quyen255", "hashed_password_255", null, false, false, "Vong255", null, "User", null, 0 },
                    { new Guid("bb15ecb9-ed65-49fe-befd-fb5dfc8abad2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k155@gmail.com", "Quyen155", "hashed_password_155", null, false, false, "Vong155", null, "User", null, 0 },
                    { new Guid("bb294489-0db3-4fef-9124-1981ea629fb0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k522@gmail.com", "Quyen522", "hashed_password_522", null, false, false, "Vong522", null, "User", null, 0 },
                    { new Guid("bb43c103-150d-414a-85ca-89e4b4e53e23"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k796@gmail.com", "Quyen796", "hashed_password_796", null, false, false, "Vong796", null, "User", null, 0 },
                    { new Guid("bba7d0f2-8798-41e5-84b3-392b2b94afc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k37@gmail.com", "Quyen37", "hashed_password_37", null, false, false, "Vong37", null, "User", null, 0 },
                    { new Guid("bbb32b60-efc0-4caf-9bf9-7fb313ed43ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k644@gmail.com", "Quyen644", "hashed_password_644", null, false, false, "Vong644", null, "User", null, 0 },
                    { new Guid("bbf5abce-a5d4-4d9f-a054-37d99427eaa7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k924@gmail.com", "Quyen924", "hashed_password_924", null, false, false, "Vong924", null, "User", null, 0 },
                    { new Guid("bbfc74e8-834d-4715-b783-ea23a33c0076"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k173@gmail.com", "Quyen173", "hashed_password_173", null, false, false, "Vong173", null, "User", null, 0 },
                    { new Guid("bc08b1d2-47e0-4680-b3a6-a839db59098b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k864@gmail.com", "Quyen864", "hashed_password_864", null, false, false, "Vong864", null, "User", null, 0 },
                    { new Guid("bc4153f9-faad-4d2d-87ae-c4e5f8571c45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k738@gmail.com", "Quyen738", "hashed_password_738", null, false, false, "Vong738", null, "User", null, 0 },
                    { new Guid("bccc26b5-a7cc-4638-9930-99fbb0d0e504"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k435@gmail.com", "Quyen435", "hashed_password_435", null, false, false, "Vong435", null, "User", null, 0 },
                    { new Guid("bce51c25-6621-4303-aef2-af7152f6fcb4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k406@gmail.com", "Quyen406", "hashed_password_406", null, false, false, "Vong406", null, "User", null, 0 },
                    { new Guid("bd990095-bfb2-4538-a20c-271519ed9b0c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k794@gmail.com", "Quyen794", "hashed_password_794", null, false, false, "Vong794", null, "User", null, 0 },
                    { new Guid("bdef1f5f-22d3-4b3e-8e72-f3c8610bc714"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k806@gmail.com", "Quyen806", "hashed_password_806", null, false, false, "Vong806", null, "User", null, 0 },
                    { new Guid("beb89a97-8481-470d-8122-dec6974baa58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k41@gmail.com", "Quyen41", "hashed_password_41", null, false, false, "Vong41", null, "User", null, 0 },
                    { new Guid("beba2d26-5934-4b3d-83ee-1fd772fda365"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k819@gmail.com", "Quyen819", "hashed_password_819", null, false, false, "Vong819", null, "User", null, 0 },
                    { new Guid("bf5e9dc3-5e6d-4a51-90e5-266c9dd46f1e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k402@gmail.com", "Quyen402", "hashed_password_402", null, false, false, "Vong402", null, "User", null, 0 },
                    { new Guid("bf7880fb-d106-49a2-ab02-45710204e6c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k339@gmail.com", "Quyen339", "hashed_password_339", null, false, false, "Vong339", null, "User", null, 0 },
                    { new Guid("bfa787d9-5458-4ce2-bf13-183bdb020215"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k842@gmail.com", "Quyen842", "hashed_password_842", null, false, false, "Vong842", null, "User", null, 0 },
                    { new Guid("bfd4ed4d-4d92-4fe5-b2f0-2a9e9b62de5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k923@gmail.com", "Quyen923", "hashed_password_923", null, false, false, "Vong923", null, "User", null, 0 },
                    { new Guid("c0c12bfe-abc6-4da8-b0c7-68f5db7eeffd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k268@gmail.com", "Quyen268", "hashed_password_268", null, false, false, "Vong268", null, "User", null, 0 },
                    { new Guid("c146d134-d384-4f10-9adf-622a2e48d3ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k166@gmail.com", "Quyen166", "hashed_password_166", null, false, false, "Vong166", null, "User", null, 0 },
                    { new Guid("c15b674f-7b96-4464-8434-daa9ac46efa3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k285@gmail.com", "Quyen285", "hashed_password_285", null, false, false, "Vong285", null, "User", null, 0 },
                    { new Guid("c15c1c60-4998-4603-96c4-728e6203ef79"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k489@gmail.com", "Quyen489", "hashed_password_489", null, false, false, "Vong489", null, "User", null, 0 },
                    { new Guid("c2c72f44-74ae-42a2-9175-fc4b62a501ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k758@gmail.com", "Quyen758", "hashed_password_758", null, false, false, "Vong758", null, "User", null, 0 },
                    { new Guid("c2e60f95-eece-4b56-b2d4-3e9b6bb52a13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k356@gmail.com", "Quyen356", "hashed_password_356", null, false, false, "Vong356", null, "User", null, 0 },
                    { new Guid("c355fa4f-6b3f-415f-be9c-cfc5e3a6ab0e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k591@gmail.com", "Quyen591", "hashed_password_591", null, false, false, "Vong591", null, "User", null, 0 },
                    { new Guid("c35b71e7-5cfb-427f-9012-2552437c10f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k727@gmail.com", "Quyen727", "hashed_password_727", null, false, false, "Vong727", null, "User", null, 0 },
                    { new Guid("c35ec5e7-e7c7-4fb4-985f-d932230d9cf2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k967@gmail.com", "Quyen967", "hashed_password_967", null, false, false, "Vong967", null, "User", null, 0 },
                    { new Guid("c41828b0-fd22-4067-bedc-3d50b7c68dd6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k953@gmail.com", "Quyen953", "hashed_password_953", null, false, false, "Vong953", null, "User", null, 0 },
                    { new Guid("c4183e6f-99c7-4d35-b676-c3e5c9ea73e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k431@gmail.com", "Quyen431", "hashed_password_431", null, false, false, "Vong431", null, "User", null, 0 },
                    { new Guid("c4b41b4f-dbff-4dfd-9b22-9ca440daded2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k559@gmail.com", "Quyen559", "hashed_password_559", null, false, false, "Vong559", null, "User", null, 0 },
                    { new Guid("c4be5879-e2ce-41f8-b90c-3a674092cc31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k247@gmail.com", "Quyen247", "hashed_password_247", null, false, false, "Vong247", null, "User", null, 0 },
                    { new Guid("c4ee24a7-a4fe-4b01-b18f-fdca470bfa2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k222@gmail.com", "Quyen222", "hashed_password_222", null, false, false, "Vong222", null, "User", null, 0 },
                    { new Guid("c4f76703-08ae-46e7-a236-1a4211d5d318"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k282@gmail.com", "Quyen282", "hashed_password_282", null, false, false, "Vong282", null, "User", null, 0 },
                    { new Guid("c4fbe59c-fe86-4093-bc8f-62224f7c0089"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k985@gmail.com", "Quyen985", "hashed_password_985", null, false, false, "Vong985", null, "User", null, 0 },
                    { new Guid("c560e670-a0d8-4b20-9d92-5030284fe5b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k534@gmail.com", "Quyen534", "hashed_password_534", null, false, false, "Vong534", null, "User", null, 0 },
                    { new Guid("c669c152-5339-4849-9606-c2ad064997d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k793@gmail.com", "Quyen793", "hashed_password_793", null, false, false, "Vong793", null, "User", null, 0 },
                    { new Guid("c69b0e6f-dd9e-46c1-a091-a446ca345cb4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k8@gmail.com", "Quyen8", "hashed_password_8", null, false, false, "Vong8", null, "User", null, 0 },
                    { new Guid("c6e6042d-7bb1-405e-98bd-1d5337f5d43c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k551@gmail.com", "Quyen551", "hashed_password_551", null, false, false, "Vong551", null, "User", null, 0 },
                    { new Guid("c6f1b148-0f78-4d85-a270-4c5a6f68f2b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k931@gmail.com", "Quyen931", "hashed_password_931", null, false, false, "Vong931", null, "User", null, 0 },
                    { new Guid("c77aa5b8-bd1a-4a29-9b83-b59b2ff5eed6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k516@gmail.com", "Quyen516", "hashed_password_516", null, false, false, "Vong516", null, "User", null, 0 },
                    { new Guid("c7fccd16-6504-455e-b1c7-460b3051939e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k103@gmail.com", "Quyen103", "hashed_password_103", null, false, false, "Vong103", null, "User", null, 0 },
                    { new Guid("c83e274c-f8cc-47f8-b296-23a66ed8dab2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k368@gmail.com", "Quyen368", "hashed_password_368", null, false, false, "Vong368", null, "User", null, 0 },
                    { new Guid("c87ada26-3f2c-4497-9faf-3721b2ffbe17"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k523@gmail.com", "Quyen523", "hashed_password_523", null, false, false, "Vong523", null, "User", null, 0 },
                    { new Guid("c8df730b-63c6-479b-9173-b5c3dbbf7590"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k53@gmail.com", "Quyen53", "hashed_password_53", null, false, false, "Vong53", null, "User", null, 0 },
                    { new Guid("c9295ed0-ebed-4c31-8537-b81b09203ae6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k241@gmail.com", "Quyen241", "hashed_password_241", null, false, false, "Vong241", null, "User", null, 0 },
                    { new Guid("c957fde5-db82-4a4b-b637-dd15357767eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k340@gmail.com", "Quyen340", "hashed_password_340", null, false, false, "Vong340", null, "User", null, 0 },
                    { new Guid("ca5a23b0-57bf-47e9-a6c5-e5c467f41630"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k501@gmail.com", "Quyen501", "hashed_password_501", null, false, false, "Vong501", null, "User", null, 0 },
                    { new Guid("ca5fa810-ab6e-4311-85d8-717642aa1d96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k773@gmail.com", "Quyen773", "hashed_password_773", null, false, false, "Vong773", null, "User", null, 0 },
                    { new Guid("ca645915-1734-4164-88cd-ab95837b8119"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k206@gmail.com", "Quyen206", "hashed_password_206", null, false, false, "Vong206", null, "User", null, 0 },
                    { new Guid("ca830455-6c51-42e8-ae1f-f649ab0a459b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k274@gmail.com", "Quyen274", "hashed_password_274", null, false, false, "Vong274", null, "User", null, 0 },
                    { new Guid("cb04e471-af7c-4519-a839-7dcffb350eba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k700@gmail.com", "Quyen700", "hashed_password_700", null, false, false, "Vong700", null, "User", null, 0 },
                    { new Guid("cb2a1018-6534-45f3-a926-e8a311472f91"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k592@gmail.com", "Quyen592", "hashed_password_592", null, false, false, "Vong592", null, "User", null, 0 },
                    { new Guid("cb32be04-525d-4722-9cf3-ee48efdfc0e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k205@gmail.com", "Quyen205", "hashed_password_205", null, false, false, "Vong205", null, "User", null, 0 },
                    { new Guid("cb543744-46a2-4657-9f43-6dd5205a3adf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k386@gmail.com", "Quyen386", "hashed_password_386", null, false, false, "Vong386", null, "User", null, 0 },
                    { new Guid("cb7d3fc6-0a23-4e86-863f-b403380a52b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k58@gmail.com", "Quyen58", "hashed_password_58", null, false, false, "Vong58", null, "User", null, 0 },
                    { new Guid("cc029f3e-fa64-4f59-ac4d-c5986b4b9f85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k744@gmail.com", "Quyen744", "hashed_password_744", null, false, false, "Vong744", null, "User", null, 0 },
                    { new Guid("cc3b18e1-13d8-4c96-b87b-fde5ab85cab2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k51@gmail.com", "Quyen51", "hashed_password_51", null, false, false, "Vong51", null, "User", null, 0 },
                    { new Guid("cc7f179d-0f8f-43ec-a8d7-335e8839d06c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k557@gmail.com", "Quyen557", "hashed_password_557", null, false, false, "Vong557", null, "User", null, 0 },
                    { new Guid("cc9376ca-7702-4604-8b64-c05dcba1ee19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k684@gmail.com", "Quyen684", "hashed_password_684", null, false, false, "Vong684", null, "User", null, 0 },
                    { new Guid("cd096200-b71a-49ec-b636-26bd19d4856e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k863@gmail.com", "Quyen863", "hashed_password_863", null, false, false, "Vong863", null, "User", null, 0 },
                    { new Guid("cd92d2a1-130b-481f-9c02-bcdce7bad481"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k308@gmail.com", "Quyen308", "hashed_password_308", null, false, false, "Vong308", null, "User", null, 0 },
                    { new Guid("ce7e1be1-29b1-4bbb-b099-293432993b70"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k956@gmail.com", "Quyen956", "hashed_password_956", null, false, false, "Vong956", null, "User", null, 0 },
                    { new Guid("ce86eed9-ad3d-4f9e-bb44-20d3e3c2f2bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k626@gmail.com", "Quyen626", "hashed_password_626", null, false, false, "Vong626", null, "User", null, 0 },
                    { new Guid("d004851c-9a01-42c6-86b8-46cf19068dd3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k580@gmail.com", "Quyen580", "hashed_password_580", null, false, false, "Vong580", null, "User", null, 0 },
                    { new Guid("d02b590a-568b-47fa-89ab-3edace0bdb0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k503@gmail.com", "Quyen503", "hashed_password_503", null, false, false, "Vong503", null, "User", null, 0 },
                    { new Guid("d08e7c49-8a9c-486d-88ef-2e425d471418"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k716@gmail.com", "Quyen716", "hashed_password_716", null, false, false, "Vong716", null, "User", null, 0 },
                    { new Guid("d0c9c5ff-e016-428d-83d7-219e5108e689"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k305@gmail.com", "Quyen305", "hashed_password_305", null, false, false, "Vong305", null, "User", null, 0 },
                    { new Guid("d0e567d5-d5fd-4207-a538-d8c1b519cca7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k917@gmail.com", "Quyen917", "hashed_password_917", null, false, false, "Vong917", null, "User", null, 0 },
                    { new Guid("d10f0157-0549-41ce-a76a-af9e71caf0bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k140@gmail.com", "Quyen140", "hashed_password_140", null, false, false, "Vong140", null, "User", null, 0 },
                    { new Guid("d1f450f4-a570-4e39-9295-60b5389b633c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k318@gmail.com", "Quyen318", "hashed_password_318", null, false, false, "Vong318", null, "User", null, 0 },
                    { new Guid("d24ebe19-a512-4cf2-945d-c007073bf03b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k228@gmail.com", "Quyen228", "hashed_password_228", null, false, false, "Vong228", null, "User", null, 0 },
                    { new Guid("d250ebcd-2696-422c-9777-d350f5721908"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k119@gmail.com", "Quyen119", "hashed_password_119", null, false, false, "Vong119", null, "User", null, 0 },
                    { new Guid("d2c0bfb7-d3ca-4f1d-ae54-3f1ea548b17b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k395@gmail.com", "Quyen395", "hashed_password_395", null, false, false, "Vong395", null, "User", null, 0 },
                    { new Guid("d2e47f38-8b5c-4a93-97be-ab30342915a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k34@gmail.com", "Quyen34", "hashed_password_34", null, false, false, "Vong34", null, "User", null, 0 },
                    { new Guid("d300a265-34a1-4a99-8c4f-1e9f754e679a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k855@gmail.com", "Quyen855", "hashed_password_855", null, false, false, "Vong855", null, "User", null, 0 },
                    { new Guid("d3037349-6d05-44f2-9f12-8ba277b8bb5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k922@gmail.com", "Quyen922", "hashed_password_922", null, false, false, "Vong922", null, "User", null, 0 },
                    { new Guid("d38aadfa-22a5-4179-becd-901b981f9ace"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k930@gmail.com", "Quyen930", "hashed_password_930", null, false, false, "Vong930", null, "User", null, 0 },
                    { new Guid("d3b2aa8e-818a-402e-90a9-4568319871b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k83@gmail.com", "Quyen83", "hashed_password_83", null, false, false, "Vong83", null, "User", null, 0 },
                    { new Guid("d3dbe1ee-44b0-4556-b301-e5896c6368c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k174@gmail.com", "Quyen174", "hashed_password_174", null, false, false, "Vong174", null, "User", null, 0 },
                    { new Guid("d4590231-2784-4b01-9e0f-31a336ff9f5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k61@gmail.com", "Quyen61", "hashed_password_61", null, false, false, "Vong61", null, "User", null, 0 },
                    { new Guid("d4698adf-44bf-466a-9740-925eb14bc745"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k400@gmail.com", "Quyen400", "hashed_password_400", null, false, false, "Vong400", null, "User", null, 0 },
                    { new Guid("d537abf9-f173-43ce-817f-cb23ad89e8dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k613@gmail.com", "Quyen613", "hashed_password_613", null, false, false, "Vong613", null, "User", null, 0 },
                    { new Guid("d5c6f045-c049-4841-8c1a-62bb983fe17d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k765@gmail.com", "Quyen765", "hashed_password_765", null, false, false, "Vong765", null, "User", null, 0 },
                    { new Guid("d652af6b-a40d-45c8-85d3-8730079a2b40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k745@gmail.com", "Quyen745", "hashed_password_745", null, false, false, "Vong745", null, "User", null, 0 },
                    { new Guid("d6603ca3-2d4c-47ad-8739-161fd6caf47c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k289@gmail.com", "Quyen289", "hashed_password_289", null, false, false, "Vong289", null, "User", null, 0 },
                    { new Guid("d665cc9a-d338-43ec-9175-52507013f73d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k327@gmail.com", "Quyen327", "hashed_password_327", null, false, false, "Vong327", null, "User", null, 0 },
                    { new Guid("d6c33b72-dfa3-4dd1-a035-6a39a04acc7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k824@gmail.com", "Quyen824", "hashed_password_824", null, false, false, "Vong824", null, "User", null, 0 },
                    { new Guid("d74267e5-b84c-484f-9c17-f46dcb25563d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k903@gmail.com", "Quyen903", "hashed_password_903", null, false, false, "Vong903", null, "User", null, 0 },
                    { new Guid("d7787a74-f5f3-412d-90ba-7c1e15b8b6e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k231@gmail.com", "Quyen231", "hashed_password_231", null, false, false, "Vong231", null, "User", null, 0 },
                    { new Guid("d77b42c6-aa55-4e93-ae3a-91ea1d108920"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k211@gmail.com", "Quyen211", "hashed_password_211", null, false, false, "Vong211", null, "User", null, 0 },
                    { new Guid("d7a00ed5-30cd-4bb0-bdd1-742c61e5c2a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k698@gmail.com", "Quyen698", "hashed_password_698", null, false, false, "Vong698", null, "User", null, 0 },
                    { new Guid("d805feb3-50b6-47b5-9b14-3654c7723f2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k125@gmail.com", "Quyen125", "hashed_password_125", null, false, false, "Vong125", null, "User", null, 0 },
                    { new Guid("d8231c2d-6e42-4ba0-91f6-e7a1c8a11d88"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k210@gmail.com", "Quyen210", "hashed_password_210", null, false, false, "Vong210", null, "User", null, 0 },
                    { new Guid("d86ee24e-1300-4e43-af8f-41016372b8d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k943@gmail.com", "Quyen943", "hashed_password_943", null, false, false, "Vong943", null, "User", null, 0 },
                    { new Guid("d878f493-7a1e-4d0e-b6ae-f3becb44565f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k244@gmail.com", "Quyen244", "hashed_password_244", null, false, false, "Vong244", null, "User", null, 0 },
                    { new Guid("d89eb071-d0e9-481e-a9ba-afe5059a470f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k451@gmail.com", "Quyen451", "hashed_password_451", null, false, false, "Vong451", null, "User", null, 0 },
                    { new Guid("d8dd785c-0796-418b-97b7-332f024e74cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k987@gmail.com", "Quyen987", "hashed_password_987", null, false, false, "Vong987", null, "User", null, 0 },
                    { new Guid("d964c393-ce96-4bac-b41e-547bd6a78938"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k404@gmail.com", "Quyen404", "hashed_password_404", null, false, false, "Vong404", null, "User", null, 0 },
                    { new Guid("d972ba3b-241f-459c-991b-9b174dc4b027"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k604@gmail.com", "Quyen604", "hashed_password_604", null, false, false, "Vong604", null, "User", null, 0 },
                    { new Guid("d9e5b65b-504e-4306-93bf-9678b7f3d6db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k610@gmail.com", "Quyen610", "hashed_password_610", null, false, false, "Vong610", null, "User", null, 0 },
                    { new Guid("da145fc3-e4be-429b-821f-f03a2f102404"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k572@gmail.com", "Quyen572", "hashed_password_572", null, false, false, "Vong572", null, "User", null, 0 },
                    { new Guid("da3fd9ec-f7d8-411f-8555-6b193296ab92"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k669@gmail.com", "Quyen669", "hashed_password_669", null, false, false, "Vong669", null, "User", null, 0 },
                    { new Guid("da48fcbf-c0eb-4035-ae75-1178c7a55c8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k345@gmail.com", "Quyen345", "hashed_password_345", null, false, false, "Vong345", null, "User", null, 0 },
                    { new Guid("da86663a-d4ec-4526-b9bd-89a905f27543"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k192@gmail.com", "Quyen192", "hashed_password_192", null, false, false, "Vong192", null, "User", null, 0 },
                    { new Guid("db1e28f7-0c37-4687-883f-7467dd0ab002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k325@gmail.com", "Quyen325", "hashed_password_325", null, false, false, "Vong325", null, "User", null, 0 },
                    { new Guid("db5349cf-10a8-4182-8bac-8ea6d4124555"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k630@gmail.com", "Quyen630", "hashed_password_630", null, false, false, "Vong630", null, "User", null, 0 },
                    { new Guid("dbc2a069-6374-4c8b-a6a5-2203eaa25107"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k595@gmail.com", "Quyen595", "hashed_password_595", null, false, false, "Vong595", null, "User", null, 0 },
                    { new Guid("dbc80103-cde9-4bcc-b8d4-1a87db9faf40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k517@gmail.com", "Quyen517", "hashed_password_517", null, false, false, "Vong517", null, "User", null, 0 },
                    { new Guid("dbdff177-43a5-4eda-9457-5e417874bf9d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k585@gmail.com", "Quyen585", "hashed_password_585", null, false, false, "Vong585", null, "User", null, 0 },
                    { new Guid("dc1de14f-724d-4c3e-ad5e-f110ceef3b8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k966@gmail.com", "Quyen966", "hashed_password_966", null, false, false, "Vong966", null, "User", null, 0 },
                    { new Guid("dc1f1700-1c9a-4364-874c-4b845331bb9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k969@gmail.com", "Quyen969", "hashed_password_969", null, false, false, "Vong969", null, "User", null, 0 },
                    { new Guid("dc8887e7-c7b3-48ac-b739-f2e3e4eda1e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k850@gmail.com", "Quyen850", "hashed_password_850", null, false, false, "Vong850", null, "User", null, 0 },
                    { new Guid("dcf6a239-2b9d-465e-a27f-ff76776656ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k385@gmail.com", "Quyen385", "hashed_password_385", null, false, false, "Vong385", null, "User", null, 0 },
                    { new Guid("dcfe311f-c165-4b46-b82a-d4e77fcf2681"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k570@gmail.com", "Quyen570", "hashed_password_570", null, false, false, "Vong570", null, "User", null, 0 },
                    { new Guid("dcff32aa-e42e-408a-bcf0-4f4d0683ffd0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k382@gmail.com", "Quyen382", "hashed_password_382", null, false, false, "Vong382", null, "User", null, 0 },
                    { new Guid("de17b0dc-006b-40ed-bb68-1c57ceb616d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k359@gmail.com", "Quyen359", "hashed_password_359", null, false, false, "Vong359", null, "User", null, 0 },
                    { new Guid("de2d537a-5792-4987-a00d-983757956d5f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k748@gmail.com", "Quyen748", "hashed_password_748", null, false, false, "Vong748", null, "User", null, 0 },
                    { new Guid("de2ddf94-005b-4389-940b-ed96b14155fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k287@gmail.com", "Quyen287", "hashed_password_287", null, false, false, "Vong287", null, "User", null, 0 },
                    { new Guid("de4a7ff8-22bb-4fb0-bb80-1d3a9c0bd044"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k265@gmail.com", "Quyen265", "hashed_password_265", null, false, false, "Vong265", null, "User", null, 0 },
                    { new Guid("de68ecee-6d0a-430b-926a-01a4d2724589"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k187@gmail.com", "Quyen187", "hashed_password_187", null, false, false, "Vong187", null, "User", null, 0 },
                    { new Guid("dea53cf9-51e1-4305-811b-f1e0b730fb6e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k375@gmail.com", "Quyen375", "hashed_password_375", null, false, false, "Vong375", null, "User", null, 0 },
                    { new Guid("debea68a-1dea-471a-8484-111e2a51d98b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k701@gmail.com", "Quyen701", "hashed_password_701", null, false, false, "Vong701", null, "User", null, 0 },
                    { new Guid("df332d20-9995-426e-9b4e-cc246e891eee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k743@gmail.com", "Quyen743", "hashed_password_743", null, false, false, "Vong743", null, "User", null, 0 },
                    { new Guid("df3a358c-dabb-401a-b71e-4c590433a9b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k681@gmail.com", "Quyen681", "hashed_password_681", null, false, false, "Vong681", null, "User", null, 0 },
                    { new Guid("df46ae9a-dc1c-4097-a5f1-f89b3ec10172"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k896@gmail.com", "Quyen896", "hashed_password_896", null, false, false, "Vong896", null, "User", null, 0 },
                    { new Guid("df5d278e-29ac-4d46-b324-d98fad5161b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k230@gmail.com", "Quyen230", "hashed_password_230", null, false, false, "Vong230", null, "User", null, 0 },
                    { new Guid("dfa08544-502d-48b7-9865-e684dc66c3a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k686@gmail.com", "Quyen686", "hashed_password_686", null, false, false, "Vong686", null, "User", null, 0 },
                    { new Guid("e03cb4d1-54e3-4996-851c-0939ac75c4da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k561@gmail.com", "Quyen561", "hashed_password_561", null, false, false, "Vong561", null, "User", null, 0 },
                    { new Guid("e072e358-ff91-42ed-91b5-2d63ba4fe00f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k983@gmail.com", "Quyen983", "hashed_password_983", null, false, false, "Vong983", null, "User", null, 0 },
                    { new Guid("e0e255e4-93a9-47d2-93b0-b7b5913f38ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k99@gmail.com", "Quyen99", "hashed_password_99", null, false, false, "Vong99", null, "User", null, 0 },
                    { new Guid("e1baf4dd-a1b3-4c79-93e4-35f4080df368"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k464@gmail.com", "Quyen464", "hashed_password_464", null, false, false, "Vong464", null, "User", null, 0 },
                    { new Guid("e1c16bfe-6235-45b9-afa0-e7f89454bc7d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k354@gmail.com", "Quyen354", "hashed_password_354", null, false, false, "Vong354", null, "User", null, 0 },
                    { new Guid("e1cc5e9d-7f2c-42a4-b0b2-0b05d587fdc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k295@gmail.com", "Quyen295", "hashed_password_295", null, false, false, "Vong295", null, "User", null, 0 },
                    { new Guid("e207bbe3-f58c-434d-9e3e-2077e2865de2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k938@gmail.com", "Quyen938", "hashed_password_938", null, false, false, "Vong938", null, "User", null, 0 },
                    { new Guid("e211554e-8040-494f-b059-e01c5cc7cb9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k502@gmail.com", "Quyen502", "hashed_password_502", null, false, false, "Vong502", null, "User", null, 0 },
                    { new Guid("e25f011b-3cf1-44b5-898a-731679c59e60"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k316@gmail.com", "Quyen316", "hashed_password_316", null, false, false, "Vong316", null, "User", null, 0 },
                    { new Guid("e28cadde-3ef3-450c-84ce-2e2908eb8b4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k115@gmail.com", "Quyen115", "hashed_password_115", null, false, false, "Vong115", null, "User", null, 0 },
                    { new Guid("e2c1886e-884f-4c79-bbce-cb4ea1b93a67"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k778@gmail.com", "Quyen778", "hashed_password_778", null, false, false, "Vong778", null, "User", null, 0 },
                    { new Guid("e2fefce2-71de-42ba-91fd-a9db937d2e72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k846@gmail.com", "Quyen846", "hashed_password_846", null, false, false, "Vong846", null, "User", null, 0 },
                    { new Guid("e32ef71d-7deb-450c-baaf-bf6e9615b252"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k803@gmail.com", "Quyen803", "hashed_password_803", null, false, false, "Vong803", null, "User", null, 0 },
                    { new Guid("e3930620-4e1d-427b-8161-974eff94a4f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k706@gmail.com", "Quyen706", "hashed_password_706", null, false, false, "Vong706", null, "User", null, 0 },
                    { new Guid("e3bece08-c4b4-4131-a726-21e3be56d102"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k440@gmail.com", "Quyen440", "hashed_password_440", null, false, false, "Vong440", null, "User", null, 0 },
                    { new Guid("e3ca71f4-188d-42fc-9de3-bb60728dab83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k891@gmail.com", "Quyen891", "hashed_password_891", null, false, false, "Vong891", null, "User", null, 0 },
                    { new Guid("e436d073-a3cc-4cca-a98a-d50e5a8f02b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k650@gmail.com", "Quyen650", "hashed_password_650", null, false, false, "Vong650", null, "User", null, 0 },
                    { new Guid("e44adc66-1159-4831-a057-33eed986daa3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k276@gmail.com", "Quyen276", "hashed_password_276", null, false, false, "Vong276", null, "User", null, 0 },
                    { new Guid("e46f6be2-4254-4439-8f7f-2a4a2fbd4e15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k747@gmail.com", "Quyen747", "hashed_password_747", null, false, false, "Vong747", null, "User", null, 0 },
                    { new Guid("e4d22543-b50f-4f69-848e-2366b83f092f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k504@gmail.com", "Quyen504", "hashed_password_504", null, false, false, "Vong504", null, "User", null, 0 },
                    { new Guid("e4d9c03b-1e0c-4087-a63b-50968f3edd44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k133@gmail.com", "Quyen133", "hashed_password_133", null, false, false, "Vong133", null, "User", null, 0 },
                    { new Guid("e4df01a7-7117-467f-8494-80e31664639b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k397@gmail.com", "Quyen397", "hashed_password_397", null, false, false, "Vong397", null, "User", null, 0 },
                    { new Guid("e58cfc3b-699b-4337-804c-4135cb606dd3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k135@gmail.com", "Quyen135", "hashed_password_135", null, false, false, "Vong135", null, "User", null, 0 },
                    { new Guid("e5af610c-a0b6-4a11-9dd9-095a9a57c87e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k104@gmail.com", "Quyen104", "hashed_password_104", null, false, false, "Vong104", null, "User", null, 0 },
                    { new Guid("e5cc023c-fab2-4a93-9a9f-a4a93104d99b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k541@gmail.com", "Quyen541", "hashed_password_541", null, false, false, "Vong541", null, "User", null, 0 },
                    { new Guid("e5ea6889-354a-4ec9-b369-cb2f2de8deb7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k911@gmail.com", "Quyen911", "hashed_password_911", null, false, false, "Vong911", null, "User", null, 0 },
                    { new Guid("e5eb8c45-d77c-4a2b-8244-0abce2b516c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k898@gmail.com", "Quyen898", "hashed_password_898", null, false, false, "Vong898", null, "User", null, 0 },
                    { new Guid("e670c35b-6bd0-456e-a206-813fbbd9df82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k346@gmail.com", "Quyen346", "hashed_password_346", null, false, false, "Vong346", null, "User", null, 0 },
                    { new Guid("e6fd2e26-0c6d-44d7-9203-274882362395"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k401@gmail.com", "Quyen401", "hashed_password_401", null, false, false, "Vong401", null, "User", null, 0 },
                    { new Guid("e713cfd3-8e82-444b-9424-10fa9edd4d02"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k816@gmail.com", "Quyen816", "hashed_password_816", null, false, false, "Vong816", null, "User", null, 0 },
                    { new Guid("e74de55a-e5ec-4799-8bc5-4c7650934266"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k646@gmail.com", "Quyen646", "hashed_password_646", null, false, false, "Vong646", null, "User", null, 0 },
                    { new Guid("e7610e9d-73a1-4b5c-8fc6-09d6a6afbfe4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k484@gmail.com", "Quyen484", "hashed_password_484", null, false, false, "Vong484", null, "User", null, 0 },
                    { new Guid("e7adde2f-147b-45c9-a732-27a6a3954e66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k434@gmail.com", "Quyen434", "hashed_password_434", null, false, false, "Vong434", null, "User", null, 0 },
                    { new Guid("e7f07ae4-635d-4985-a7d3-bfca7afdb38d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k583@gmail.com", "Quyen583", "hashed_password_583", null, false, false, "Vong583", null, "User", null, 0 },
                    { new Guid("e82dc971-7bdb-4b81-9c68-81d710d49f1f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k91@gmail.com", "Quyen91", "hashed_password_91", null, false, false, "Vong91", null, "User", null, 0 },
                    { new Guid("e88aea8a-c884-420b-b26e-849f71c87d8b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k36@gmail.com", "Quyen36", "hashed_password_36", null, false, false, "Vong36", null, "User", null, 0 },
                    { new Guid("e89a6c6a-fe3b-4204-9057-98873b756281"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k300@gmail.com", "Quyen300", "hashed_password_300", null, false, false, "Vong300", null, "User", null, 0 },
                    { new Guid("e8ef261d-dbad-433f-85df-3f6225b9e0a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k547@gmail.com", "Quyen547", "hashed_password_547", null, false, false, "Vong547", null, "User", null, 0 },
                    { new Guid("e9025111-72e5-4a19-b04a-3789d3b17917"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k643@gmail.com", "Quyen643", "hashed_password_643", null, false, false, "Vong643", null, "User", null, 0 },
                    { new Guid("ea9c9945-0939-479b-a41a-15f3df08ea29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k951@gmail.com", "Quyen951", "hashed_password_951", null, false, false, "Vong951", null, "User", null, 0 },
                    { new Guid("eaab7e83-f9ff-4ef3-a4be-78ee5fd1b1d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k688@gmail.com", "Quyen688", "hashed_password_688", null, false, false, "Vong688", null, "User", null, 0 },
                    { new Guid("eb0ff537-9988-4124-b517-3dc5f8bf59c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k258@gmail.com", "Quyen258", "hashed_password_258", null, false, false, "Vong258", null, "User", null, 0 },
                    { new Guid("eb118e2c-76a8-4907-8aa5-c45544ab5e38"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k6@gmail.com", "Quyen6", "hashed_password_6", null, false, false, "Vong6", null, "User", null, 0 },
                    { new Guid("eb1c6582-4cb7-4f0f-a77c-3118ea3d00d2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k260@gmail.com", "Quyen260", "hashed_password_260", null, false, false, "Vong260", null, "User", null, 0 },
                    { new Guid("eb36c796-f63f-480c-ad3f-949cb3d6df25"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k875@gmail.com", "Quyen875", "hashed_password_875", null, false, false, "Vong875", null, "User", null, 0 },
                    { new Guid("eba366b7-1779-4bf0-a522-8dddbf0515dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k731@gmail.com", "Quyen731", "hashed_password_731", null, false, false, "Vong731", null, "User", null, 0 },
                    { new Guid("ebf50672-d1eb-4251-909b-9479300f038f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k218@gmail.com", "Quyen218", "hashed_password_218", null, false, false, "Vong218", null, "User", null, 0 },
                    { new Guid("ebf800cf-7f9f-459b-962a-ff0fb728cbba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k328@gmail.com", "Quyen328", "hashed_password_328", null, false, false, "Vong328", null, "User", null, 0 },
                    { new Guid("ec181561-c2c1-471a-98d7-968d8a59d8cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k980@gmail.com", "Quyen980", "hashed_password_980", null, false, false, "Vong980", null, "User", null, 0 },
                    { new Guid("ec3b84b7-0edd-4826-bdb0-cbe46d8bf7f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k858@gmail.com", "Quyen858", "hashed_password_858", null, false, false, "Vong858", null, "User", null, 0 },
                    { new Guid("eca38293-b7af-4619-ad1a-1396488d7c19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k728@gmail.com", "Quyen728", "hashed_password_728", null, false, false, "Vong728", null, "User", null, 0 },
                    { new Guid("ecef3b5e-c876-4913-b332-32eaaf0c8711"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k515@gmail.com", "Quyen515", "hashed_password_515", null, false, false, "Vong515", null, "User", null, 0 },
                    { new Guid("ed009121-c3f6-4f94-a120-700d34de39ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k767@gmail.com", "Quyen767", "hashed_password_767", null, false, false, "Vong767", null, "User", null, 0 },
                    { new Guid("ed3a11cf-9f54-4be1-b3cc-0daf745219e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k600@gmail.com", "Quyen600", "hashed_password_600", null, false, false, "Vong600", null, "User", null, 0 },
                    { new Guid("ed5dc6ef-66e3-46ea-9719-c3a08f206b0c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k266@gmail.com", "Quyen266", "hashed_password_266", null, false, false, "Vong266", null, "User", null, 0 },
                    { new Guid("ed602681-7593-4c9c-82e2-46b7de9afb3e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k827@gmail.com", "Quyen827", "hashed_password_827", null, false, false, "Vong827", null, "User", null, 0 },
                    { new Guid("ed79fe08-5078-4271-8ea7-ea70538bb384"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k611@gmail.com", "Quyen611", "hashed_password_611", null, false, false, "Vong611", null, "User", null, 0 },
                    { new Guid("ed916b96-38f2-480b-badc-8874b3063389"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k158@gmail.com", "Quyen158", "hashed_password_158", null, false, false, "Vong158", null, "User", null, 0 },
                    { new Guid("eda70960-2153-431a-84f1-60f2ade745eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k344@gmail.com", "Quyen344", "hashed_password_344", null, false, false, "Vong344", null, "User", null, 0 },
                    { new Guid("edb52377-e981-4e34-b933-9a6dedc38fd2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k261@gmail.com", "Quyen261", "hashed_password_261", null, false, false, "Vong261", null, "User", null, 0 },
                    { new Guid("edcd987f-27b1-477b-bedb-4dda1ad7769b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k888@gmail.com", "Quyen888", "hashed_password_888", null, false, false, "Vong888", null, "User", null, 0 },
                    { new Guid("ede57b0b-a0c9-4ef2-8201-6031d44258a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k525@gmail.com", "Quyen525", "hashed_password_525", null, false, false, "Vong525", null, "User", null, 0 },
                    { new Guid("edf49215-c8bd-42d1-93be-d27b665eb168"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k514@gmail.com", "Quyen514", "hashed_password_514", null, false, false, "Vong514", null, "User", null, 0 },
                    { new Guid("ee0bfecc-7807-4020-bbf8-68f470d3e2d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k926@gmail.com", "Quyen926", "hashed_password_926", null, false, false, "Vong926", null, "User", null, 0 },
                    { new Guid("ee822d68-22ee-47f0-a636-6691fa9b68a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k635@gmail.com", "Quyen635", "hashed_password_635", null, false, false, "Vong635", null, "User", null, 0 },
                    { new Guid("eeb18bd6-9b1a-43e7-b4a0-ed3b1674fbf2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k45@gmail.com", "Quyen45", "hashed_password_45", null, false, false, "Vong45", null, "User", null, 0 },
                    { new Guid("eec22234-dfa3-47f6-8228-feb0c2959649"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k822@gmail.com", "Quyen822", "hashed_password_822", null, false, false, "Vong822", null, "User", null, 0 },
                    { new Guid("eed14b63-b584-42f5-90b7-7acb48cf45f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k734@gmail.com", "Quyen734", "hashed_password_734", null, false, false, "Vong734", null, "User", null, 0 },
                    { new Guid("eeeea9db-6ef0-4ee8-8344-bc1571efb72d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k338@gmail.com", "Quyen338", "hashed_password_338", null, false, false, "Vong338", null, "User", null, 0 },
                    { new Guid("eef8aea0-abe5-4980-ae38-185faf061517"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k658@gmail.com", "Quyen658", "hashed_password_658", null, false, false, "Vong658", null, "User", null, 0 },
                    { new Guid("ef109691-56a7-41a8-8adf-603bdbaef8dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k781@gmail.com", "Quyen781", "hashed_password_781", null, false, false, "Vong781", null, "User", null, 0 },
                    { new Guid("ef13ffe8-8775-4765-b63f-4eda080a753c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k323@gmail.com", "Quyen323", "hashed_password_323", null, false, false, "Vong323", null, "User", null, 0 },
                    { new Guid("ef41c347-1bab-420d-9d52-64c828655add"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k588@gmail.com", "Quyen588", "hashed_password_588", null, false, false, "Vong588", null, "User", null, 0 },
                    { new Guid("f07254c5-a3ee-4124-a34f-3c8e03a024a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k410@gmail.com", "Quyen410", "hashed_password_410", null, false, false, "Vong410", null, "User", null, 0 },
                    { new Guid("f0c8db9f-8e89-4eb5-a186-1d2f4fef9cb9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k593@gmail.com", "Quyen593", "hashed_password_593", null, false, false, "Vong593", null, "User", null, 0 },
                    { new Guid("f0f7495d-8be8-4219-8e46-5946245f3d7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k14@gmail.com", "Quyen14", "hashed_password_14", null, false, false, "Vong14", null, "User", null, 0 },
                    { new Guid("f16b1ac2-5689-4afa-ac8f-58808a6f5fe5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k763@gmail.com", "Quyen763", "hashed_password_763", null, false, false, "Vong763", null, "User", null, 0 },
                    { new Guid("f1c23b5f-9332-445d-8a37-03f59d5ec050"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k785@gmail.com", "Quyen785", "hashed_password_785", null, false, false, "Vong785", null, "User", null, 0 },
                    { new Guid("f1df0799-d628-4d2a-9592-c0000ca21059"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k949@gmail.com", "Quyen949", "hashed_password_949", null, false, false, "Vong949", null, "User", null, 0 },
                    { new Guid("f1e789ca-50b8-435c-96a4-3da341967d6d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k213@gmail.com", "Quyen213", "hashed_password_213", null, false, false, "Vong213", null, "User", null, 0 },
                    { new Guid("f1eff619-16c6-4d6b-bc62-3a52b3231f40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k337@gmail.com", "Quyen337", "hashed_password_337", null, false, false, "Vong337", null, "User", null, 0 },
                    { new Guid("f253c283-1831-4513-9184-f35f077cf228"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k111@gmail.com", "Quyen111", "hashed_password_111", null, false, false, "Vong111", null, "User", null, 0 },
                    { new Guid("f2aa3943-b47a-45f1-8f82-639eaeefb368"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k445@gmail.com", "Quyen445", "hashed_password_445", null, false, false, "Vong445", null, "User", null, 0 },
                    { new Guid("f338720b-7d76-4c90-9bf0-8377c557d70f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k982@gmail.com", "Quyen982", "hashed_password_982", null, false, false, "Vong982", null, "User", null, 0 },
                    { new Guid("f338f68e-4ac7-4f1a-868c-387aa42f7ab1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k631@gmail.com", "Quyen631", "hashed_password_631", null, false, false, "Vong631", null, "User", null, 0 },
                    { new Guid("f39ddec8-0fa6-4c4f-81e8-ea3fcf4f3cf9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k702@gmail.com", "Quyen702", "hashed_password_702", null, false, false, "Vong702", null, "User", null, 0 },
                    { new Guid("f3a226e0-65bf-4b11-a63c-32013752bf2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k918@gmail.com", "Quyen918", "hashed_password_918", null, false, false, "Vong918", null, "User", null, 0 },
                    { new Guid("f43588fe-23be-4327-b892-e2cd7e07da5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k528@gmail.com", "Quyen528", "hashed_password_528", null, false, false, "Vong528", null, "User", null, 0 },
                    { new Guid("f4fd3740-b5be-4874-a8ea-5fa8a4853c4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k508@gmail.com", "Quyen508", "hashed_password_508", null, false, false, "Vong508", null, "User", null, 0 },
                    { new Guid("f54c2bd3-b088-4e58-9455-08c12fffd6e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k26@gmail.com", "Quyen26", "hashed_password_26", null, false, false, "Vong26", null, "User", null, 0 },
                    { new Guid("f5a213c5-c974-4a53-88c6-b9ecf0b143c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k416@gmail.com", "Quyen416", "hashed_password_416", null, false, false, "Vong416", null, "User", null, 0 },
                    { new Guid("f5d5214a-3b5f-4f7d-bb16-9cb30bbcc873"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k657@gmail.com", "Quyen657", "hashed_password_657", null, false, false, "Vong657", null, "User", null, 0 },
                    { new Guid("f5efdefa-fcae-4a5a-abea-3cc92c1906aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k54@gmail.com", "Quyen54", "hashed_password_54", null, false, false, "Vong54", null, "User", null, 0 },
                    { new Guid("f60bae43-49af-4fa7-9111-dd90212fed1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k304@gmail.com", "Quyen304", "hashed_password_304", null, false, false, "Vong304", null, "User", null, 0 },
                    { new Guid("f6abf5af-f628-427d-b3cc-76e067cb2323"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k798@gmail.com", "Quyen798", "hashed_password_798", null, false, false, "Vong798", null, "User", null, 0 },
                    { new Guid("f7186eeb-687c-4316-b45b-17deebfd417a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k699@gmail.com", "Quyen699", "hashed_password_699", null, false, false, "Vong699", null, "User", null, 0 },
                    { new Guid("f7818492-cf71-448a-8296-7f5a28076a10"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k259@gmail.com", "Quyen259", "hashed_password_259", null, false, false, "Vong259", null, "User", null, 0 },
                    { new Guid("f7a76d03-cb6f-4a50-9f21-b5de486306e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k189@gmail.com", "Quyen189", "hashed_password_189", null, false, false, "Vong189", null, "User", null, 0 },
                    { new Guid("f7bae142-177c-4ede-b113-140324e4e72f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k749@gmail.com", "Quyen749", "hashed_password_749", null, false, false, "Vong749", null, "User", null, 0 },
                    { new Guid("f7cd1821-dc63-468f-8c39-64a30627adb8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k376@gmail.com", "Quyen376", "hashed_password_376", null, false, false, "Vong376", null, "User", null, 0 },
                    { new Guid("f7f015ca-df65-4d52-b21f-3817ef9dc426"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k463@gmail.com", "Quyen463", "hashed_password_463", null, false, false, "Vong463", null, "User", null, 0 },
                    { new Guid("f86025f7-52bf-4087-8baa-4e0758c86fdd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k965@gmail.com", "Quyen965", "hashed_password_965", null, false, false, "Vong965", null, "User", null, 0 },
                    { new Guid("f8cb093a-c2f3-4183-a3cd-233307ec627c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k281@gmail.com", "Quyen281", "hashed_password_281", null, false, false, "Vong281", null, "User", null, 0 },
                    { new Guid("f8e47a99-1bb0-4466-b135-6fcfe3e0948b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k22@gmail.com", "Quyen22", "hashed_password_22", null, false, false, "Vong22", null, "User", null, 0 },
                    { new Guid("f8ed42b3-a031-4ef6-90a6-523f8bef984a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k909@gmail.com", "Quyen909", "hashed_password_909", null, false, false, "Vong909", null, "User", null, 0 },
                    { new Guid("f96f5fe2-51bd-487f-bc7c-1b79b2e0a349"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k581@gmail.com", "Quyen581", "hashed_password_581", null, false, false, "Vong581", null, "User", null, 0 },
                    { new Guid("f98f028a-0eae-4a11-abd8-41de10e987f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k296@gmail.com", "Quyen296", "hashed_password_296", null, false, false, "Vong296", null, "User", null, 0 },
                    { new Guid("fa02339c-a9f1-4424-a244-5f2912f36cdf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k651@gmail.com", "Quyen651", "hashed_password_651", null, false, false, "Vong651", null, "User", null, 0 },
                    { new Guid("fa05dfc2-4922-40d0-b799-5cf64a851a89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k472@gmail.com", "Quyen472", "hashed_password_472", null, false, false, "Vong472", null, "User", null, 0 },
                    { new Guid("fa58a969-7a9c-48dc-bfac-de76d415095c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k717@gmail.com", "Quyen717", "hashed_password_717", null, false, false, "Vong717", null, "User", null, 0 },
                    { new Guid("fa697e10-586b-433c-95ae-6dcb88d4dffa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k242@gmail.com", "Quyen242", "hashed_password_242", null, false, false, "Vong242", null, "User", null, 0 },
                    { new Guid("fa752ffc-03a0-45f3-bf9b-4df1c0a4d341"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k66@gmail.com", "Quyen66", "hashed_password_66", null, false, false, "Vong66", null, "User", null, 0 },
                    { new Guid("fa8b77ad-9804-43dc-8aec-f1f79457ac83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k659@gmail.com", "Quyen659", "hashed_password_659", null, false, false, "Vong659", null, "User", null, 0 },
                    { new Guid("fa8d6a8e-d3ae-4e1e-8d67-1ae548e7bf7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k486@gmail.com", "Quyen486", "hashed_password_486", null, false, false, "Vong486", null, "User", null, 0 },
                    { new Guid("faa255e2-f489-4dfa-bbef-887316001e91"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k682@gmail.com", "Quyen682", "hashed_password_682", null, false, false, "Vong682", null, "User", null, 0 },
                    { new Guid("fadafe5e-79b9-403f-8d1b-432291d6e81d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k648@gmail.com", "Quyen648", "hashed_password_648", null, false, false, "Vong648", null, "User", null, 0 },
                    { new Guid("fb44f040-fa29-461b-ade0-e2c44f5aa0ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k933@gmail.com", "Quyen933", "hashed_password_933", null, false, false, "Vong933", null, "User", null, 0 },
                    { new Guid("fb63e8a8-f8ff-4282-9110-6460cb7d5581"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k172@gmail.com", "Quyen172", "hashed_password_172", null, false, false, "Vong172", null, "User", null, 0 },
                    { new Guid("fb71218b-3f87-4141-b4c3-1f3388791433"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k439@gmail.com", "Quyen439", "hashed_password_439", null, false, false, "Vong439", null, "User", null, 0 },
                    { new Guid("fbe5774d-a82b-4fee-9ef3-5a7157ebe8f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k303@gmail.com", "Quyen303", "hashed_password_303", null, false, false, "Vong303", null, "User", null, 0 },
                    { new Guid("fbe63a44-bc08-44a1-9327-7031f069de27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k250@gmail.com", "Quyen250", "hashed_password_250", null, false, false, "Vong250", null, "User", null, 0 },
                    { new Guid("fc513120-12e8-48ad-a011-866047c70e96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k656@gmail.com", "Quyen656", "hashed_password_656", null, false, false, "Vong656", null, "User", null, 0 },
                    { new Guid("fc7e0524-22b8-46a3-8329-26aa619e5929"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k999@gmail.com", "Quyen999", "hashed_password_999", null, false, false, "Vong999", null, "User", null, 0 },
                    { new Guid("fc807bc3-4edc-4873-8b41-8fa7dc0b3328"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k741@gmail.com", "Quyen741", "hashed_password_741", null, false, false, "Vong741", null, "User", null, 0 },
                    { new Guid("fcf8a0b8-bb10-4f27-8605-69200bb2a532"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k349@gmail.com", "Quyen349", "hashed_password_349", null, false, false, "Vong349", null, "User", null, 0 },
                    { new Guid("fd5fc3b3-d480-49f9-8571-fbaa19c01a66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k170@gmail.com", "Quyen170", "hashed_password_170", null, false, false, "Vong170", null, "User", null, 0 },
                    { new Guid("fdabb676-8aab-4603-9dbb-f99e2ec92377"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k594@gmail.com", "Quyen594", "hashed_password_594", null, false, false, "Vong594", null, "User", null, 0 },
                    { new Guid("fdce4ca3-215e-4814-bc81-801c9123152e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k430@gmail.com", "Quyen430", "hashed_password_430", null, false, false, "Vong430", null, "User", null, 0 },
                    { new Guid("fde859a3-1926-413a-a57e-ab1506128f8a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k278@gmail.com", "Quyen278", "hashed_password_278", null, false, false, "Vong278", null, "User", null, 0 },
                    { new Guid("fe1df691-8e82-4962-affb-7f4d6d229e05"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k18@gmail.com", "Quyen18", "hashed_password_18", null, false, false, "Vong18", null, "User", null, 0 },
                    { new Guid("fe477abf-6d5e-4358-a648-1575d849ba2a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k687@gmail.com", "Quyen687", "hashed_password_687", null, false, false, "Vong687", null, "User", null, 0 },
                    { new Guid("fe5e03c5-1f8a-4cce-b43d-8b802f2892d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k510@gmail.com", "Quyen510", "hashed_password_510", null, false, false, "Vong510", null, "User", null, 0 },
                    { new Guid("fe61fda3-e49a-438e-9568-337b4a4ee152"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k437@gmail.com", "Quyen437", "hashed_password_437", null, false, false, "Vong437", null, "User", null, 0 },
                    { new Guid("fe7cb111-b3ed-44b8-a3b6-2d981f10f511"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k283@gmail.com", "Quyen283", "hashed_password_283", null, false, false, "Vong283", null, "User", null, 0 },
                    { new Guid("ff2b8d85-dfd5-4be5-a50a-4408fe669dfb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k487@gmail.com", "Quyen487", "hashed_password_487", null, false, false, "Vong487", null, "User", null, 0 },
                    { new Guid("ff7e5147-9717-4265-838c-15e983a5bab1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k329@gmail.com", "Quyen329", "hashed_password_329", null, false, false, "Vong329", null, "User", null, 0 },
                    { new Guid("ffbfccc9-1fd3-4bc6-aede-8ee3c891df27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k866@gmail.com", "Quyen866", "hashed_password_866", null, false, false, "Vong866", null, "User", null, 0 },
                    { new Guid("ffc29fbf-5be9-485c-98bd-60fa7be57ea9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quyen332k245@gmail.com", "Quyen245", "hashed_password_245", null, false, false, "Vong245", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("008e43ee-36cd-4b39-919a-6c3aca8902c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo632", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("00a9815e-09cf-408f-af76-73b030dbfc06"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần457", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("00c26f07-7846-4f90-b852-572845418f44"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần465", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("00ec741f-dbee-4b68-9d54-e6f03a024682"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần795", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("00ef0939-8fda-4bc3-a8db-ef83ab3175de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần205", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("010cc40c-6ce0-4b89-aaa5-3e2817dff53e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo684", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("013c2a9e-3637-426f-8133-9303a0719630"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo932", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("0182d31f-77ce-4c44-a531-fb476f7cadbb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo190", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("01a563b0-28ae-4737-beb4-d28e17f2e0ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần509", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("01cb4c3f-b898-49e9-bafb-183927bf37c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo382", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("021ea924-518b-4679-84ab-3605c69cb0c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần743", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("023e0682-b56d-43a5-99fd-8429bb6e544f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần151", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("028ed367-f7be-4717-9aa2-a9dd53d4a18c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo350", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("02df48e4-095f-42f7-a728-b2ccb097fccb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần53", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("02e4c92f-9c06-4074-8a83-c4fdf0cc02e0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần861", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("030a9f48-4ae2-4fb0-abb2-a4a40b5cf210"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo278", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("03184e5c-7500-47cc-b2d1-311402f0c89d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo486", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("031b3229-959b-4a0b-b435-a1add5167d4f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần189", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("03444d39-49fd-4662-9055-70085dff9728"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần895", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("03db0c61-2e60-44c9-aee9-ad8a46e3eaa9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần325", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("04111bec-aead-4e20-8f5d-4cdd04d292aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo966", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("042ee0ab-ea61-4ad2-b7d0-c73d8383cf38"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần643", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0464cfc3-1e12-4846-aef1-fa86be779729"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo766", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("04b11efe-8f51-4871-8d16-97c6956f0abf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần593", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("04c01c2c-f8ce-4b99-928a-e23804687ada"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần93", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("04cea101-f1ae-49ec-9e5f-fe63f27e0b69"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần661", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("04f55700-08e9-4440-955a-d1592e5257c8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần347", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("056722a9-d937-4774-9dfa-0753285a6be9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần611", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("05857431-a227-4801-a40a-64a4a9b65a97"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần985", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("05c639bb-cb4b-48bd-a7c6-cb3935335370"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo228", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("071bc6bd-d7fc-42ec-9cd1-68b67710497d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo694", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("075db2a8-427b-48b1-984f-8095ae3bf1ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần725", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("07b1ee2d-14e2-4170-9ee7-449201ca1f41"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo418", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("07d115c5-c46c-4038-bccd-55a70f35e908"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo148", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("083bbfbf-e744-4da6-b2e6-718d7a733b82"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần841", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("084a9e99-47a6-41bc-8c35-dc96a901cf9b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần855", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("08794b14-c2ea-475c-af57-ee4e4b75fcfe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần441", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("08c8cbaa-4753-4d39-882b-4b0706085fe5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo152", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("08c9d5da-6482-4584-93f6-b1acdee82dd8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần223", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0a33b5da-f673-4878-9302-5637eb3b1183"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần153", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0a7afccb-e8bb-4d1d-9986-73018bc10432"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần15", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0aa1e584-238f-4443-b493-da7296079ce8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần247", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0b256158-d7f7-4476-a98f-c79beafd2ffb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo532", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("0b781ace-8ca4-4b17-ab0f-5349145d1a67"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần133", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0b9b6c52-d0cd-409a-aeb9-41cc26026db3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần379", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0ba23ce5-3ca3-4a03-8692-74b55734b0e8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần383", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0bb64710-774b-4096-bf5f-f6f9e1b3ebf5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần233", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0c04aefc-d5a8-423a-bfd7-ada78e3dcac8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo202", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("0c221c09-6e6c-495c-bf9b-36d537d8f5c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo358", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("0d4cdd8b-a77f-4eec-a65f-d245a17cd587"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo514", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("0d61aa3e-b270-478e-b8f1-af1c6a4d7185"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo722", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("0dcf9207-61ef-4cad-80ba-017e464ebfd6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần971", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0dea6249-a8e9-4ccd-bc51-493a90b017d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần445", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0e5c65b6-c9a5-4cf6-9e17-e3c19d6ddea5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo918", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("0e8b2c63-0719-4f5d-8dc0-fe9b9a4a3e01"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần235", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0e92cdb5-7a39-4b57-9531-eb6642133e6f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần333", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0ebf5831-9acb-4694-be5f-b11e665d39b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo22", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("0ec2bda5-1acf-4575-ac75-9f439d24480e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo88", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("0ef6c455-1f0d-43c8-96fd-71ef5aae26fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần569", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0f20be41-d439-435a-a1b6-448cf34a9603"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần883", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0f228470-0b77-400b-b3a2-0cad7ae30555"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần997", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("0fc7d4eb-05d0-4c41-bc6b-9b3166da7bfc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo372", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("0fe001c5-1d4f-41eb-8e69-76b3f70a89f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần799", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("10241407-9968-416c-b886-2d78076e4033"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần673", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1075a2ae-9cb7-4cec-9103-eb68c0869c20"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần59", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("10c943e8-3686-42da-aabd-647b09bb9943"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo296", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("10f24f34-3b7b-4b3c-b567-54c016e30c57"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo840", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("10f8f129-ebea-4f6a-87fd-8c58cc348ff2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần561", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1128e343-ab59-4c30-b4fc-9e639c23a7b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần809", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("115fb7d8-9830-4af4-80bb-76d6bd996fe7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần629", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1176e018-07b2-4155-bd34-773867f82f3a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo616", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("11cc73dc-d6d1-4d80-ba06-8d6feae60303"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo660", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("11dd6b5d-e0bc-4d21-909f-ec031e80b2d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo988", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1217cb9b-8ccc-48e3-b535-6e804fa48a1a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo912", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("12332a1b-bc88-4db0-987f-06d3464218aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần5", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("124f0f1e-121d-4372-a73c-6eaa544a362a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần225", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("126aa43f-bccb-422e-83c8-f75d4b619d75"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo26", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("129b7871-221a-4a0b-ad5e-3b3ea18096e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo842", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("13048d7a-d152-456d-8175-72a65b4073c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo664", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1341667c-7574-4008-8c5b-845eb93b26d1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo874", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("134304ad-8d27-4713-970e-2041989c195b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo394", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("135aeb86-9ada-4bd8-adf3-7ff4698c20f8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần293", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("139a3612-2979-4e68-835a-da993df0d690"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần147", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("13e0cfac-0883-4d9d-b545-cac2fe712467"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo232", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("13e13dc7-7584-48d2-8aba-249915369471"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần551", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("14b6ed4d-b23e-4092-8332-fd5800834c94"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần207", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1540e517-776c-4546-be6b-acf6c2adc160"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo226", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("154a3c4f-c72e-4790-b531-c5ed9be40fbf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo78", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("15522966-7511-4282-ac17-1b7ec1903c82"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo186", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1574d8c6-71a2-48e2-93ad-d60a4ba7500a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần735", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("15886220-f5b2-436b-b744-581c1eaf1a9b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần197", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1680515b-4301-4559-b9bf-bc8a1c1150dd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo474", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("179b043d-cf8b-401c-895e-0f579874e6fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo794", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("181b8dce-ea62-451b-92c4-fa87548ced00"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần391", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("189e322d-b89b-49af-b669-e396a35a9c37"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo444", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("18b0e3e5-7e55-4e90-b9bd-b18a65dff27a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần353", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("18e02d94-bec0-419e-b5c0-6c730e0dd180"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo666", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("18e36c79-a50a-41e0-adb9-985e41b83a8e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo132", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("18e6dc1a-12ec-4367-a06e-266ccf6abaec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần307", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("18e85c1f-6cf7-48ff-9825-3d101180f78d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần567", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("19141db3-3003-4ed3-9aa4-7d89cd92c70d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần269", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("19225b11-21ac-43db-911e-1ec127a7ee1f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo610", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("192b88a5-e670-420d-b0ef-39899fdfca4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo436", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1959440f-5c6b-429e-a20b-8fa0ca1aae85"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo60", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("199a90d8-70cb-44d1-be67-1535bb6967e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo460", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("19d1b4dd-d01c-47e6-81ab-42f1442c351d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo84", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("19f579d2-5be2-4e9b-9b10-de1603e5d5ed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần901", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1a3890fa-8046-4aec-b32a-7a25bf0eafc8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo638", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1a8637ae-e43a-43c5-b25e-63667a03b418"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần323", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1a9a8402-c8f3-44c8-afd9-1918bfdc786f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần67", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1aa7f1e9-1793-400c-ae50-a84dc738726c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo14", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1abd7f56-26d9-4bb7-936e-df829609ec93"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần395", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1ad335ec-2db2-4898-b562-a040b85c1ae2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo326", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1b0382aa-dac6-4eb6-a8e8-40bf696e6d40"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần683", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1bcdc8b8-a6b8-473c-a4d2-fd148eed9b22"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần503", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1bdfc7f2-c8a9-40a3-a29e-aa30ce233ce7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần377", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1c325b9e-d685-4a0c-b796-0e0c06955a77"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo484", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1c4030a4-ed58-4f61-bf78-096a950d2cf4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần849", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1c48232e-35da-481f-a2fe-0a989c9d1add"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần939", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1c9154b9-1129-43d3-8eaf-30a541608334"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần739", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1c9d0c53-443e-47d8-a0ad-ab8cc039ab6c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần249", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1cb2b580-7f25-4bdf-9089-e63fbc818166"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo920", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1cb9a58a-4177-4be5-8fac-b1ebec5c4ae9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần829", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1ddf93b2-0a19-492f-bf50-efcb3298ccd7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo654", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1dfd83ea-269b-4132-ac39-521d151aa13b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo800", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1e35fad8-d1b3-4795-b8c2-97cde6108a13"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần493", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1e377e51-d508-4c08-a01a-cb2825de9e87"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo156", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1e5bb663-ee94-4ffa-9cda-12bb4e609b86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo936", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1e6c4dbc-d1ef-4746-93c0-8711d529dfd9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo682", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1e9b341b-cc7e-4ffb-9888-480d594b90db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo338", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1ea0cb03-e7a5-4e8f-b041-3f3f5cd98041"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo750", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("1eadf96b-cd4a-4599-b174-955d730ca113"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần265", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1edb3670-807f-48c9-92db-2468fd1649a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần41", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1fce2b31-21a1-44bb-9894-6d1d8e7f90b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần529", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("1fea0cc9-4d40-4364-b3f9-458b0b4363b7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần419", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("200492b1-16b3-4c22-983d-707dbe84e26f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo184", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("20ea64a8-67af-46b1-99fa-30fe28b14226"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo892", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("20eb3846-936d-4f46-8ac9-104f9b4b4279"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần469", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("211d7879-01b1-4381-8eaf-6bdf49caf35f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo530", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("211d993c-b8fb-47dc-a25a-65dd876a091f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo248", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("21ac082d-9e8b-45ce-9fe1-20cb76850b12"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo108", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("21b015ba-7a21-46b4-88b5-58b116c8c135"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần729", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("226f5d0e-d0db-41d7-b943-05bfe3520109"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần915", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("2274898a-278f-494b-8b13-114cda226721"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo630", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2289f95b-b2e5-4732-951e-51421433c594"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần319", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("229014cf-f10a-461b-bd6b-930cfef4245d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo756", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("22903cc3-7e5a-4e89-a557-2d92d6f620fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo670", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2294a483-6b85-43ec-9c33-9d863d0bfc7c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần39", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("22a4a23e-6998-42df-ad32-059e4b828015"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần565", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("22bed95b-0d4f-4f7d-b010-6fd4c046f909"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần585", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("2329c70f-1c40-46d6-bae4-64d1b535aaa6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần953", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("2338c1d7-8478-445d-9e29-5776dd46edc1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần229", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("2398e162-983b-4c60-bcf8-0f70b4bcc905"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần773", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("23f44de9-fc1f-4a6f-b44e-65a41b562ab1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo224", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("24040f46-52d2-47af-b767-9a56b659d6d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần221", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("2414b4da-ce0d-424b-9952-b71277858aa6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo960", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("242c42bd-af9b-4897-aca0-c88462329242"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo826", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2475c35b-6944-40f1-a33e-d2416c11662f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo928", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("24bc80d9-6d7d-4629-8c05-42e65a90ed8a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo64", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("24f27ede-b930-449c-83d6-5049483d2a27"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần81", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("25c72cfe-6576-4b88-b655-e51a2def8ad6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần717", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("25cbc881-722a-4852-a429-4e02fe948fe5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần843", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("25dfacec-48b8-45f0-a199-1b0937332121"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần191", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("26ec6117-59b1-42f7-a683-41176508c414"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần499", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("26ed943e-dad9-4099-9adb-297657e2afe9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo930", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("26f92bd0-5ab6-4c55-8dbc-8102f9f616d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo700", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("27075185-2781-4f37-a9d1-e36452d1179d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo20", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("270a781c-08d2-495e-bb1a-71ec3ee74013"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo428", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("272077d5-4f6f-447c-86e6-05a873d2db8c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần237", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("273e817b-611d-41a3-bc6f-c51ab952d32c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo516", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("27a02895-553f-4927-a4d2-1abc1e68b2e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần557", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("27fc80bc-9156-4491-aebf-624e61a13e06"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần835", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("283becc5-1094-40ad-81aa-022ed1bb614f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo458", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("28b1fab3-2875-499f-bfd8-5d7f4d115b30"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jeans", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("29b210cd-216a-468c-b687-808b103ea264"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo950", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2a1aff12-41b4-4f7b-8cbb-403f8a4b12d7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo282", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2a6a58c2-9602-49dc-9f01-225fdf38cfe8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo852", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2a89c95b-3b34-4648-8eb4-6e10646ec117"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo882", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2ace647a-48e0-4239-af01-c16a1a008c3a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo158", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2acfeb0b-5502-4067-bdfd-23bb07119b37"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo856", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2b2c6ffa-0fc7-4802-abca-6162f61e4daa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo678", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2b4944f4-4a6c-455e-9d81-20ad40f13c0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần599", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("2b5ecebb-e19f-4192-aea8-668229e8708b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần479", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("2b94e5c0-2459-4a22-bf37-f3f35a5b64a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo442", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2b975dfd-d380-47ef-a1ff-9002b67e0424"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần589", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("2d6502ea-96c0-4ae8-8eee-2b549d4409ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần23", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("2d6bed86-d182-4243-a1bf-9e9fdc013fdd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo74", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2d942534-07cc-4c13-b1be-597684df295b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo714", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2dd2a690-86a2-427f-8f9c-6656c0b56aa0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo558", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2e2f43c3-e944-4b85-9103-20c6b96ae6b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo416", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("2e96fee9-8738-4796-ac8a-8b7a07312ce2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần521", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("2fd62b8b-0334-417d-a1ff-becb78ad5430"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần927", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("2fd9fd59-fcb7-45b9-b280-8a7027c3412e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần941", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("3062f2e8-4c54-4f1f-8209-c7434f3c4142"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần543", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("310f6f94-c936-45d3-8028-29298fd07aec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo366", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3119a133-5e61-473b-9aa1-70043f365493"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần57", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("313ed283-60d6-4b9a-9bc7-ba7d4af0d116"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo500", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3185d8bf-f0d6-4e64-85c6-af98e8079dfd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo618", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3187918c-ac86-46bc-803b-51cf3f491588"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần787", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("322f22e9-a865-4e6f-9512-a238a1cb16fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần285", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("3250bbcf-cbf6-42f8-b8a1-9003c463efcf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần367", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("3275bb56-fa66-44ae-9e2b-a952d26b9edf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần909", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("327ce3e6-5ac5-4903-a698-dc00f58d460f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần913", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("329c5da9-b5d9-4525-8424-93761d6b2af5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo456", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("32b1212a-f295-45d0-a03c-1de7d87135a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần423", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("32fa91f6-501e-48ac-a602-ee36a2aefd29"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo206", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3309ee19-ee70-4fc5-a3c7-f85a06153996"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo82", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("33326349-4132-4b25-ac5c-333325553606"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần437", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("33637468-258f-4e67-a447-c1883ac88c7f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần519", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("3398ff80-a1d9-45b4-9158-40d023418795"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo178", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("33efe598-6ca6-4978-bd2e-5b7fb3e73be5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần965", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("34344188-3702-4ba0-9059-6b7366e464ab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần35", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("345fa670-352d-46b7-8777-de2aae6fa464"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo346", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("34c71d7d-b255-4561-90ab-dad33b7a7f03"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần703", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("34e19b89-e06f-4fbc-906a-611488d05a3e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo266", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3573999d-184f-4fc2-aefa-0453812cc87d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần659", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("35da3ad8-6b88-4e9b-9a68-a199c2177015"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo476", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("35e761cc-08dd-48c2-b423-496d2bb39509"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo420", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("364259cc-7cee-49e3-af7d-1b14ec902427"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo716", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("368fa558-65f7-45be-886c-a776ce80b84d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo708", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("36cd6968-50f2-495c-b08c-b557c8e7d147"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần45", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("37c5282d-b825-46c2-ad14-0b289abc75da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo58", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("37d2203f-3fd8-4842-b2c2-ee7faa2143e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo334", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("37d83065-9486-4d65-b7ca-94444414f890"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần777", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("3823cd7d-51bd-40c7-8167-80b28aebe9d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần277", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("3890be5c-d9d2-475c-8cc0-60171af1b17e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo974", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("389bbe2c-ad82-4eb2-afe4-d70a675e16fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần515", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("38b6d481-c15f-4418-9c96-157ea1197958"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần853", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("39182ce4-944d-4549-8fc8-cf2ddc5cdec2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần33", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("39853178-4188-44a7-ba64-c95ecad4f124"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo524", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3a207576-8e2c-4012-a3df-f489d6872852"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần51", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("3aea8686-53b9-4869-9a70-49fc8258a986"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo144", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3ba605b8-e2dc-4f47-b10a-be805a8c847c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo376", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3be7bf60-6b79-42a9-bcbd-652261a7a747"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo76", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3beca282-17d9-41eb-b2d2-711ae989e321"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần925", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("3d1c44ec-19db-47ab-bc3a-7d7cf1718d16"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần137", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("3d3498b9-4c31-4776-9877-c7cf6cee48a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo696", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3d82b58a-77db-444d-a950-30ca6b38b484"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo490", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3d8c79bb-9ec0-4cf8-8462-0b3d1bb1d590"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo732", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3e380fe5-06f4-4e1e-ab96-4b80875c8e3d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo464", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3e4c088b-0e9b-465f-90df-743cbc76d150"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo330", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3e653ba0-5748-453c-a5f4-5402e168d83c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần723", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("3e98fcde-ab56-4c24-b821-0eb0638b91b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo990", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3e9a261a-60d1-4003-b7f8-20c9d04e1c31"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo890", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3f0cca7c-8bc6-4d37-8fed-1e82801f2b0f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần647", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("3f245bbc-19b6-4ecd-8a45-c01cf203a948"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo768", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3fc98c57-b993-467a-8956-ea9fa231bfe1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo562", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("3ffa2f17-44b9-4ae6-a346-3aeb01fea9fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần631", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("402b39f7-ded0-408e-b42e-a39429414193"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo710", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("406599a4-6bf3-45b2-b8af-f89104def0e0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo858", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("407c7ebd-1604-4f5a-81d5-38fa96627322"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo542", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("410ad9c0-0f5c-4d95-a111-3fb42d83f3ef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần179", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("415349f7-c48c-41f8-ba14-68c2ef807504"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo788", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("41b2e681-d0cd-4869-940c-fb8af743b8bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần275", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("41b3e022-47eb-41a8-aaa8-8d0aba1b9423"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo214", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("41bf2433-ab32-408f-b9d3-871a4a6eaf5a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần357", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4253cb83-efaf-4194-a16b-00629bcc7749"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần403", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("431662cc-6365-4606-ab77-9516a49e46bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần697", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("43825473-874b-4c24-acca-84e86e1b7677"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần455", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("444e4dd9-7b7d-41bc-a27a-5237a77973bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần779", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("445771cb-e528-462c-b285-d3ddfc5a4660"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần741", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("446d8f13-e95d-49bf-9980-64685b889b31"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần979", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4470aebe-30cf-44d1-8b81-f1c49a0836da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo814", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("447ac88e-ff4d-49ed-87b7-b88e94559bbe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo870", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4491ef42-5898-4455-a74c-edf307ceb956"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo876", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("44a0fed2-f735-4483-b6ec-26c7438115a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần905", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("44bd79b9-f119-49a6-a4de-8ada660ff362"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo94", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("44e4ecbc-aac7-4b76-ac47-53d324ab7dcc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo924", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("44e9cef7-7aa2-4000-8b1f-bbd9270660c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần881", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4515f746-6357-4ca9-a78b-fa9f33511242"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần43", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("45708105-2fb3-4577-acef-c4d41acf66d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo378", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("45a7beca-5736-4518-9f7b-e0b585d6468a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo344", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("45a83203-aef5-422a-87d5-6262eed207b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo ba lỗ", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("45d6199f-49ef-43df-9e4d-eec35a8b24b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần857", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("45da3d80-9ccc-4fa0-b7db-b46776aecc6d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo450", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("45f239d3-a6c5-4398-8722-6fc325e3a974"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo40", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4635d0d5-8c17-47ae-9dae-b1a537fc651c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần879", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("464a9737-3e2f-4652-871d-14ef2d883de6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần701", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("46c05313-51a0-475f-af4f-6185d35234e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần113", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("475b8138-6b04-46d2-8158-f52d81453c05"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần87", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4799995b-802f-42db-89be-94fc7c417423"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần757", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("47b9fd58-b100-414b-a24a-b0459065e1be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần111", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("47c4dcda-dfb1-4122-9162-fac3cb9e98de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo356", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("486725c8-89f5-43d8-b798-cd395bfa64ef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo396", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4867955a-1a47-478a-a263-3987d85b1240"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo786", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("488453e8-0692-4667-917f-d3da7a6d916f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần897", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("488e9821-011b-4b15-9f32-b55d5855672e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần709", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("48b513ba-3269-4009-b9f3-77e55831e47f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo210", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("48de5cc0-56e9-45c0-ba53-6472d21118aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo888", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4923af5e-2fcd-4070-aab3-7e6c3044047d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần651", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("49632d18-1cb2-4c12-907e-4036eef967f9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo946", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("49748b69-240e-4da4-a3f7-a97e1eed1218"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần893", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("49a39643-227e-4998-8ae9-8f64687220d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo594", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("49ad72fe-f7dc-41db-92a4-97c8d8629e4a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần405", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("49ce3965-e4e4-4325-b4ba-a0766ad78002"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần527", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("49db9ef1-71ae-4650-bf39-18de6bb4dfcc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo154", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("49deaa7a-759e-4a00-b026-935db294f2cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo734", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("49f5ff7f-d052-4d49-95f9-44f6623a6327"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần689", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4a1b4e23-5faa-4020-88cd-a45b2b06e58e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo30", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4a28004c-0a36-4312-9c5f-f1e73a9d5a3c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần119", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4a311c1a-220e-49db-b36a-114afb52a66e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo582", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4a32ce78-acb2-411b-bc9a-7678541139dd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo980", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4a39177e-dfee-4404-a204-48fe6e96088d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần693", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4a8278b7-525a-491b-9fa8-62ed839df68e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo568", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4afd9e4d-24d2-4769-8f09-ee9da716d990"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo236", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4b60f6cf-a085-42eb-a082-fbfaf6ff9942"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo824", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4b9efcde-d2a4-41ec-90b1-54e7a82c655a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo400", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4c57b613-88fb-4369-aec3-fc88f034ddfb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo976", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4c5ca16c-47b4-4efd-b4d1-7e158060adf2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần719", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4d2ef19c-5a44-40fc-a06f-93acbb956476"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo608", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4d686adb-bb70-4f8d-b301-f6bfe237bf63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo218", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4df075b6-452d-4ba6-b382-d77255f2c45c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo904", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4e302ad0-50b2-42fc-bd02-3b3b07703018"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần451", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4e3ea5db-0fe1-48ca-b34b-2c58cc9cde88"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần297", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4e429f3b-6ae2-4cdd-98c4-adf699bdd38d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần821", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4ee74118-e825-4903-993d-bcd9d03f410c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo662", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4efb44d0-2812-4ac4-bbb5-3b77219b82e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo914", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4f13abd3-e5ab-4fed-809f-4543e62681b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo724", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4f29b3ce-8f24-47a8-b0c6-9090343e2114"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo380", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4f51bed1-82bb-49ee-ae7c-71cf6799856b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo98", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4f83a5c9-83a7-427c-97b3-f24844d9a7c8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo600", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("4fc8208b-0b45-47b9-9011-741e5fe0ffe0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần761", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("4fd073db-f492-46b7-bbdb-89b6d04d9abf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo220", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5005ca14-05b5-443f-a9cd-26a4b5faaeb5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần959", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("502089cc-1877-4f3b-bbd8-72c8d54abef3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần875", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("504b916d-beb6-43b6-8c5d-59a6e2f45826"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần13", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("50db13a0-065c-4529-8e3a-5f582709fe7d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần675", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("50ed4bfd-e91c-44dd-8f6d-c8d15c7a655b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo622", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("515ef332-62a3-47f4-b5bf-6d2072d5943b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần863", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5173311b-33c3-4402-a1cd-c30814fcf5bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo492", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("52a4aff0-8e34-4033-b277-f3f2b30e90e9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần657", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5371ff8d-4c70-4f6d-87e6-1cb3e12c374d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần135", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("53a6aeb3-226c-4caa-abc1-a13c6f019b91"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo868", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("54028ebc-3578-4edb-9f2f-25f5f8972b32"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần3", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("549f800a-69c6-4e37-b3e4-b8be7966f6f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần639", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("54b8b00f-0bac-405c-bcfc-be9fe2c58a25"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo216", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("54c95441-5104-4fb2-a6e8-ff456cdc7580"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo908", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("55c5c40f-3452-4d95-9f02-89eab06280cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo134", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("56129cc9-54d9-4758-bf16-839295e334f8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo246", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("562ccf18-66c7-4af0-bb57-f19215a59fda"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần607", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5632f648-b905-47e9-868f-271e48c79ee8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo902", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("56906404-071d-4b13-b2f9-2e41941b1a0a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo272", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("56e4788e-1b9e-484b-acdd-b1e7a1217d62"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo720", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("576a6707-8c87-4924-8236-2d753ffa6e42"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo118", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("57d5f0ad-98f8-4882-8547-12fd1df30b4f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo204", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("584750c1-bdc8-4bfb-b3b6-31e969ffb777"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần201", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("58580873-af50-439d-af1f-274f93b6337b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần511", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("58ada7df-8196-4beb-bab9-ec7d71605d18"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo138", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("58ce734a-aca4-4834-8bb2-058ef7e03802"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo422", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("58f96cf8-db4e-4101-9e1b-ab7a5a48b9d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần825", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("591126da-b590-48db-b405-79ee3168f525"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo510", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("59322eb3-e7ab-49ba-b2ab-d05c7b513752"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo180", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("59a8bd07-2ae3-465f-a150-e21229bd7312"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần411", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("59e57a58-21aa-474a-b0a2-0bde2052df06"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần801", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5a0db482-4ba8-4c3b-b65b-1ccba5c5565c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần273", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5a57bd39-f342-4c98-a435-63b8d27bbbeb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần211", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5a699c08-2583-4179-aa10-519889de63cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo408", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5add74ae-e899-4f49-a010-d8c29b851b71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần533", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5b9b5f76-df25-44f0-9383-b2ac55060746"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo230", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5bd3f834-ed1f-4bee-a087-9cf7264918f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần461", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5bdb2051-b33d-4328-b3ca-23f2c16b3d23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo676", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5c0db80f-7c84-46a0-81bf-7984d102041f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo680", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5c2f6ee0-4967-4f75-88e3-34c4c4e84055"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo470", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5c6b5ed2-7f7c-45c1-bbfc-34d1d475536a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo564", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5cc8329f-b4d3-4f01-a154-ffcd3cc9710c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần851", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5d6b28c3-e565-47cc-bd53-392c7d69551a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo584", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5dbd0850-3c29-42fa-8b4b-4effda7161d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo958", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5dcd5443-5e62-43dd-a1f7-c8dddddeb4ef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần107", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5dd27688-bfbf-4921-9b43-2dd2ab4351b0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần283", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5e0b5239-4021-41da-909d-94ddb768d320"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần789", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("5e244623-1bdd-4bdb-9475-6d2a728154cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo150", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5e9c33f8-d72d-4204-b102-fed97b439c1a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo718", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5f39eae4-93ab-4568-84ac-d77a57fd4b07"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo712", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5f51abcb-410b-44d6-8896-0f5ac8976478"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo690", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("5f5fed2d-f935-44f1-870b-1e096f03a6aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần361", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6028285b-071c-4264-ae90-b31b7145537c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo336", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6030e32d-61d2-4d46-bd2a-a28c131eec6e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần923", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("60364dcc-b369-4407-8a0a-8725dca99165"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo242", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("603f95b7-50e4-492f-a636-710f1892726d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo348", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("604737fb-b776-48cc-91df-bb35cdc25935"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo526", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("604f8f9a-1925-4531-8b96-c1c8b20f3a43"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo92", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("609636b7-c98a-4bef-8448-0b8987fbc691"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo440", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("60980126-0b28-4ea7-8f5a-8ce5c4c411ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo996", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6130e156-5a29-4a59-a805-b1a7a34a52d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo740", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("61435390-9588-4648-9116-95a9326ff8ab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo628", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("616c2f17-c682-40d0-97e7-641109ea2d56"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo620", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("61a1f31c-76c8-4ec3-ac11-a4ffec1268b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo128", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("61d5a4d4-62d0-4763-9f4d-53f872be4a84"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo162", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("61e20025-0271-4260-82ea-973bc9ec6633"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần351", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6230d2dc-2296-40ab-977b-e66b04056281"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo274", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("62af08ee-13f7-4b57-97d2-fa5bcdc5b740"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo454", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6325a82c-f6aa-4a50-bdb3-6b83ce1296b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần819", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("63326a0d-aa43-456b-a617-f27bd30673d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần385", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("634d813f-45c8-4878-894b-fc412e97b793"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần613", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6395bdce-3975-45e9-b8fb-244f5f3ea60e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần963", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6395d715-24e5-404e-8f58-259489b8c910"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần817", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6399dc68-5797-444b-aa31-73e147fe48d1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần727", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("63b2cbac-7538-4ed5-946d-e8f199e84b8d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần623", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("63d28839-dc97-486e-8c5a-5964de62f948"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần91", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("640585fd-d2b6-462d-9c42-e1e185415dfc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo106", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6454b6e9-6a86-40e1-9eb8-38857a779a3b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo446", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("64929f42-753d-4148-a451-663b321709c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần253", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("649f94a5-0c24-455f-a970-b6d7d8c1ca21"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo68", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("650c2032-e38c-475c-b27c-03d8b3737bed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần317", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("65440520-4e4f-4854-9a2e-6eab566def42"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần649", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("664d38e6-a802-4db6-8363-aac5bbf521d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo124", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("667ee860-4aa4-4427-a6d7-e7d8ab3f7b2f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo808", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("66bfb52b-307e-4650-9b60-b9dbe51c8f63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo276", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("67400521-c559-4b1d-b1ff-3ff42a9a2452"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo744", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6746dc83-7ce1-40b8-b592-e12843899b8f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần105", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("676ddd9c-0bee-49fb-943d-d31622b11e24"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần467", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("678b8377-902a-43c7-9ff4-8e6021b65695"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo576", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6790910c-8390-4e84-8376-79a3a8d00bd2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo650", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("68803d91-8a59-4154-b09e-fa8b58a3a3ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần751", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("68b8304c-8480-43e2-b48b-b09ab69aa257"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo540", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("68d03fa2-c545-4076-b2bf-5bcf38f4c8b7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần279", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("69a10e27-f19d-4f91-bccf-48ac48fe0930"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần949", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("69d9b21e-7f3e-44bc-882b-48ef6d25e14d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo28", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6a7cac36-cfd0-4f34-8d44-2d68aa9f46d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần431", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6a93e7b9-7d1e-4eaa-a04d-8666816db076"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần685", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6ab27d9d-3784-40b2-b7ec-044100ec148e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo12", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6b228c99-7e70-4d30-83a0-d0ee01c8f8ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần287", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6bb6bf85-04a3-4c24-b328-de0f8925463f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo332", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6be79377-47f1-4f75-b9e2-01f3629e9f16"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần263", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6c385f3f-7d43-48f7-8ee2-731fb04b4398"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo552", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6c59dbc3-7c7f-4fb6-a136-1eb82a4952f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần213", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6c65f6cb-1774-41a4-bfc0-d6403ff38271"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần267", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6cb509bc-a1f6-4bdb-9c63-b191ca6071b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo364", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6cfc267e-f31e-4b08-bd5a-c70464002210"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần581", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6e31befd-d67d-46b8-b357-1fae70692f59"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo528", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6e7a24fc-e085-48ac-8b8d-98d71d4033f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo48", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6e8fc5f7-0e88-4014-85e5-4ca853079081"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo284", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("6f982242-740e-4778-8165-5c1c830046e0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần425", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("6fb367a5-b16e-4d23-bb13-a95f1cee186c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo90", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("700419fc-4063-4793-9547-329fa7adea58"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần669", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("703343aa-a9a4-4c4c-a7c2-1b9a34dedc46"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo360", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7095206d-a804-4826-a498-3b1d5f93381e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo10", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("70ad5372-522c-4f05-bf72-48d68584d424"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo802", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("717f9ef9-a7ae-45d3-882e-1c775f52bfbf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần155", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("718112d5-9b7f-4951-9168-836d0e41c57f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần261", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("71d0f771-23f0-436b-a647-d739847181d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần665", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("71d8b00d-da8f-4c4c-9db6-5dd1dcf8c682"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần193", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("71dd3927-6aba-46a1-a717-9085fb45859e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần591", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("724fcdea-7ec1-4621-833e-8d9487c7174b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần131", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("72a7dca6-004c-4e3a-9fc1-a09f36680a88"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần977", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("72ab5a97-04ae-4e59-9edd-561b63a70d81"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo736", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("72b88fe7-2512-45eb-ad9c-a18719fb3da4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần919", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("72c2c4a5-907f-4d3f-bf28-2107b0553f84"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần931", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("72f77e10-d778-4a7e-a21b-b3bcc2856f5f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần27", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("73274908-46be-41ae-8eb0-5e107073fb3b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần699", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("732cf8c4-1556-4a2b-9deb-b9f50d465951"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần833", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("739dd993-946d-40ff-86f6-d6d9d84f87c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần627", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("74003c06-b25d-450a-83be-fb04875a7e66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo538", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("743ef19c-cba3-448f-8d91-c23ea967fd86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần387", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("75424257-9e35-4c7a-af21-4787387c43ab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần707", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("760af21e-e1b7-48ca-b9a6-f5347e2ab60f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo962", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("76181a95-2f95-4c62-b292-261cbd6c3f2d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo624", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("76d648db-a880-47ca-8712-45528d841d6b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo430", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("77b86e5c-8f27-4198-9db4-834d38e4a2a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần149", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("780b5c26-1e25-43aa-bb41-cfa2e7ff330f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần481", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("783e4576-22f2-4bb3-ad35-b37701050748"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo746", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("785a4815-274f-4585-a461-ad1ccd7d00e5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần489", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("78d7dc2b-f30b-4c88-949c-53873e0e7ced"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo872", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7922a698-944f-4bdd-83b9-51d28604497e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần655", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("797ff233-0797-40e0-80e6-3b70fd2e8b24"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần839", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("7991deb6-4d5b-47bc-9070-cef29e870b86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần163", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("79d23630-e4d2-4c72-80c3-37316ad64781"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo452", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("79fdba3d-9e9b-45be-ab87-68e38820ab71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo812", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7a944380-f75c-4d66-8c08-78d2a7bb3ecf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo308", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7ae2d1e2-c71c-45be-bffa-d480351b50db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo968", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7bee9763-5b15-40a2-94ee-e17a5f2e9461"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo322", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7c0196c8-b311-477c-a590-86be998b4495"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo402", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7c102535-63d0-41ec-8fb9-c389cef055ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo570", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7c10e442-af5b-49af-9f47-da619df7072e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7c7a0901-927b-4249-9236-621a5aa2f2be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần513", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("7cd72197-19c8-49d0-a04b-bea70ad03e48"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo374", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7cecf3a5-4238-4a85-b1ec-601db7346649"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo198", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7cf75189-2ea8-4027-9d4d-8b8078ff3d25"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo104", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7d542560-1617-45b9-a8f0-26bb1b189bd6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo166", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7dac20d1-168c-489b-9a17-a3f0adf2178b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo674", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7df03786-e4a8-42e7-a667-3054384789cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo916", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7e0ca861-628a-4613-87ec-1896d6847b82"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần995", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("7e36e2db-aec1-4f69-b10e-3d088ca03049"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo764", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7e4760b8-4bf6-4a15-a9c3-fe39ce1ba939"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo234", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7e619bad-1507-404d-a393-f453ddb9259a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần203", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("7e90f1ea-a0ec-4ae1-a4dd-d359ce52648c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo982", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7e9f85f6-091b-47e0-81f5-9f006fe6616a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo288", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7ea4b102-036c-4114-a06b-f28efa00703a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo238", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7ed0147f-7f8f-4806-a14b-d09086d5eeaa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần783", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("7ee39cb3-736c-4a4e-a6c6-ad3878b7a164"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo310", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7f0880bc-cfb0-4411-b506-6b99c0841baf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo752", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("7f0ccf5d-232e-4878-be79-f08c4986cd53"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần877", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("7f2ed789-74b0-4f35-9564-50cb5af467ab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần439", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("7f634be3-cccf-4ae1-ad31-04e4e467004c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần535", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("7f8864df-848c-4bc1-bca2-28bc6596e1ca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần807", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("7f9ec0d8-307f-4610-9fc2-05c64a8480f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần653", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("80324724-f269-4c68-a328-c92d77b3aaac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần667", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("80e68fcd-48ff-45db-afaa-19b3836ce643"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần343", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("81514788-a236-4e67-bbb6-a3a3b9b87a89"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo410", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("81538973-c1dc-4198-aa3c-541dd67f688e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần463", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("81b6f132-f599-491e-90e9-5192bdb26b5d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo672", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("81e26087-7bec-40a1-a610-d3268118fd0a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần847", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("823d00a8-e902-41c2-b509-a68422c1893d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần397", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("825b518b-9aaf-440b-8b7f-3883d3bb6f7b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần415", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("82a0b50f-90e9-44fd-a0f5-f7c95886abea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo772", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("82bb1d6f-7fe9-4efd-a3d0-6b2e045b534d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo120", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("82bcbc1b-3a34-42ac-9432-486dc1a2f281"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần471", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("82c007ae-781a-4ca4-833d-7615c90c0f36"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần433", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("83213820-bd76-4177-9887-2a70e2402611"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần63", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("834a5505-7f74-48d3-8584-89fe0a48e83c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo496", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("83792d14-3f84-4be0-98c2-8879840418d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo866", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("83f4a314-64e7-4d83-a539-03a395393e20"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo286", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8447000a-2649-42c6-8d19-d5c485eace7b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo472", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("846a00c0-a9e3-4483-a0c4-6be19b3cff90"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo726", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("848e5945-edcf-40a1-88c4-ff9fd3e2921e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần553", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("84cc496a-4ea4-4359-841d-08af33bbe11f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần217", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("84ce22f9-352f-4af6-80a5-94c08cab06e7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần713", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("84d609fe-9144-43b3-9f57-beb1aed989a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần215", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("852c4b35-9692-4404-996b-05fe7c0b11a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo556", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("859cc448-58a4-47eb-be2b-eb1a35010bbc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo196", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("85ba8ae1-f233-4771-a25a-86379536d7df"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần271", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("85d877fa-eba0-4226-92bd-437a64ac8fb2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo548", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("861a13dd-fb72-4b64-a080-165bf3c7bb06"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần313", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("86330b0b-6b57-4026-a02a-f150a0d1118d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần181", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("864ecda2-34c9-48df-8118-c6332a3e2bab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo102", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("86594947-38e7-41fc-b949-34970277a0a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo424", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("86618371-f0b8-4bff-b8c4-4045b2c92e10"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần311", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("86e84f7e-3bc1-4f02-95be-cbde7ba0f099"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần887", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("86f4c0e1-92ee-41c4-af68-4798194371c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo176", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("876a7a52-c918-43f4-b63c-950014d74f58"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần687", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("87be9db0-8495-44f7-864d-8bf8d7158190"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần359", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("87f7cbdf-6bc4-4d3b-ab26-f73250907ab9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần797", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("87ff090f-0c16-4faa-b32f-d908c92cc05c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo926", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("882a102b-15bb-4428-bbde-e7acbbac9c10"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần921", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("88377d93-d5ff-4f96-b145-361397faefe1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo848", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("88949ab0-6c47-4065-b828-9a0e0d889120"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần259", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("88eb32b6-c123-4b7f-b996-c8a2c1431930"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo828", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("890c6290-4a82-4faf-a6ad-e25af513b236"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo136", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8934a65a-2a91-41e7-b441-9c27a384aca6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo550", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("898d2553-625e-454e-bf53-a2314bd74ae7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo498", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("89f8d608-6af9-4406-97aa-dc1b34fb73be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo942", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8a461793-e58b-40c3-be7b-8fddd41e7cbe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo646", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8a4e74fb-c246-478a-b53d-b197e6326804"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần679", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("8a535daa-d687-446d-ae8a-e5332896606d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần937", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("8b7d8e23-531a-4294-befa-763fd92413f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo754", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8b9a2141-f8a4-4489-a4f8-c7fee34a14c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo388", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8b9c6b2d-c6f3-43df-a6e1-67b836bcbbc9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần475", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("8be58c70-5f3a-4024-8eb7-f40f403d83cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần55", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("8c44ac96-d0c4-418a-89fd-158b67c18653"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo614", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8c8aa84f-350b-4126-a788-76fe800a8a76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần243", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("8cf4bfa7-87ab-4811-b460-cee2b75be748"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo994", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8d16b42d-5bb7-4722-b44e-f8f5448691f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo810", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8d474c3c-d6ed-4c94-a992-da33a99806f8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo586", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8d6b6c9d-5b19-41ba-9220-842d60fc5a61"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo798", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8dcad9f4-aa5f-4a0a-9a78-6f1058557cae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần245", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("8de6ebb9-e551-44ae-b9f9-e39db202c5f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo598", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8df9791d-600d-4885-ae26-d6530d61d315"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần907", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("8e3ef8d3-814c-4c5c-a9e6-3c76b0be89c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần309", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("8ec027fc-4889-4f41-8201-b0c0d36fa5ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần257", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("8ee690eb-2b4e-43b8-a7cd-c2f80c7a04cb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần619", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("8f10c0b6-6004-4546-be02-4135fb3612c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo652", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8f61f553-fe92-4785-a07f-bca2ef97b08d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần341", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("8f7297e1-b3a6-498d-9796-7419560eee81"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo412", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("8fb47c9d-5167-4b8c-80be-159c3078cf2f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo56", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("900617f8-07f6-4e24-affd-898325da021a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần321", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9042b761-2286-432e-8536-36efafff90ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần209", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("908fe90e-c640-4934-99c5-b26083a11c15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo896", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("90df3905-efbe-4848-9efe-652ea7e85893"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần873", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("915ddeb8-2abf-4dd7-a9ca-8b486d19e778"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần815", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("919b9bdf-a1e0-44d5-a912-bbdab213870f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần671", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("919e428e-4e33-494b-a55e-21a2f28bbf6a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần421", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("91e4b925-c0ee-45a3-9c44-210c60bed849"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần299", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9204b00f-616c-4171-b272-dc8a1a8ac580"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo252", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("923d091e-ba88-4228-8c1e-6d6d95f469ca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo534", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("92820b5f-7749-47fb-ba0a-fbd0d4821581"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần911", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("92c0b9c5-bfbf-4e14-93c2-915ce0c3268c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần331", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("92cab8b3-0531-4493-b679-28c8faa2afc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo390", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("934996ab-e01e-4e37-91c9-8845aecb5a17"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần83", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("934faa06-dcd1-4f10-8d40-30777f8cbdc8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo172", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9437f769-8518-4d94-89f2-2f4d75cbb5f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo648", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("94498c7e-aff8-491c-8409-52228efba341"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần721", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("94af1a2c-4e63-4e16-a7b4-970f68c0009f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần381", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("94d6c14a-9335-415b-bb6b-0ff721bfcbd7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần369", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("95e729b9-beaf-4111-90d5-c40b656daa0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần7", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("96d9adf0-df00-4010-92af-77ccb07a3b66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần645", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("96ed1edc-c193-40d8-b293-3b2fdeac0a4a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo796", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9706f7d4-1f1b-4edd-ba44-6badc7ff61d7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần315", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("971aeb60-dfb3-40fc-a116-4606b5c7da08"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần917", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("973e1c3c-692f-4b6c-8763-fc5d33aa3f21"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần993", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("978dd448-0a14-4026-a89a-10d0785b618d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo704", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("97c7a823-33d5-4bc2-ad4c-94587c77caa5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo906", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("988e787b-863e-4f15-808f-e4dbab214add"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần239", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("98a0237b-d18b-4830-b2aa-342da4dc947a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần621", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("995d49d9-2b7e-43fe-a38e-8b4530aadc78"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần935", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("998cca08-ed82-4db5-8ad3-2f0b99bdaf2a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần559", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9990ce18-0f19-46c1-b205-ee33b04aa2e9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo426", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9998024e-683f-4cb7-ae0b-3fc9084f8f1f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần749", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("99b0d929-dc58-4431-b8ef-497c1d1e2e46"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo820", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9a246396-f085-4f4a-9fb1-0e6aa146ddaa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần609", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9abcccdf-0709-4b10-b7f1-84ec47abd735"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần29", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9ad65253-8a04-43a6-a560-9f76d6975eab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo884", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9bbf3444-43ae-45c2-a82b-a05a9c903530"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo54", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9c5d130a-f725-4337-aeda-21c354e260fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần583", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9cac1bef-2dfe-4244-8708-5d02cb8e8875"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần389", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9ce41664-39f4-48de-adfd-e4ca39be8cae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần337", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9ce48dd6-79ac-4975-a681-74f0ddc79f7b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo406", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9d5b3c57-3728-4b2c-a871-266a02484155"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo954", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9d66378d-1f5e-465d-9447-bf8fbb326e60"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần601", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9da83da8-5ebb-4e51-b77a-02e5211ff071"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần167", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9dceb375-709b-4d55-aaaa-d8bf703f5661"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần77", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9e2ae6d9-ab20-4b28-a991-677b4ada93ea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo512", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9e4a6759-96bf-4fc8-b857-1bf5d811c2b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo816", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9e604ce1-8675-448f-be0f-5ce55f1103be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo66", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9e9739ab-181d-4b7d-8031-1c6b5475909b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần837", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9f21b623-4aa4-48af-877d-d0fbb4517e49"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần889", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9f49469d-5e0c-4a49-b4d4-0b5d567fd7e4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo174", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9f5a4cf1-d2f3-4d50-a53a-81c877c2900b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần69", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9f742889-ddf4-4f14-9f9a-b9a6313024de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo644", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9fa3576f-ce27-41b3-ac18-0ffc0dd2f11f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo52", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("9fa6ba94-0dcb-4550-8c8b-a3f8a7ee8358"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần175", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("9fec2aea-7bee-4d32-aa8d-1d6a0e70980b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo522", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a09c2b22-020b-4656-b053-fb5389e239da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo304", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a0a1246c-2bb0-4d00-b676-14050db08a23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần811", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a0d96aab-826b-41dd-aa57-9ea57293a870"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo468", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a143fa26-0fdb-4797-a543-b52cd0b2134c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo822", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a14dcc2d-5776-442c-b910-6880a166ba7d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo222", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a1645582-acf9-44e1-9c16-20a3a415282b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo18", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a1664f5f-6c06-4ba6-ac1b-bc69cb304c62"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo70", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a16e710b-2b87-4a5a-b45b-aefcfeb4cf62"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo62", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a21372e7-7e0e-4497-9b79-372c87c263b0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo244", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a2aaf27c-fab3-4a5c-94fb-254d88c3d876"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần891", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a2b30761-8ff7-4ee9-b574-ffd100465f74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần545", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a316a760-b9bf-4b85-a733-c97eba77105e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo758", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a31a7006-ee24-4588-b955-c99e5b2b5a6e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo126", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a33388f5-a40f-47b4-8e20-f5a6c28e4427"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo938", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a380a042-5542-4fba-9b30-3e570d415b00"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần991", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a39117bc-4254-46e8-8542-379c6c55a93d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo260", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a3bbea74-e7bd-4d86-888f-91f383f57be9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo544", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a41d5cc1-4ec3-419d-9ba3-23cad8e088ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần573", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a45702c3-9f3f-4bd0-95e1-f7219c717aaa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo130", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a4e02f70-9541-49a9-8cfd-49cff253f7cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo368", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a501fb8d-b66c-45dc-8b18-4a8068ae911a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo122", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a5d4589b-f332-4616-ac3c-141c8caf62ae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần955", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a5d842ab-e9de-4efd-be4c-5dd34b472dfe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo354", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a5f26a63-bf39-491c-bc98-790703938a61"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo188", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a61cc610-099d-4054-94a5-96483898c789"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo324", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a656008a-cd31-4574-b8da-678cdc08f2a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần75", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a6937fe2-8a04-4bb3-a4bb-8f19e35f6467"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần525", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a6a67df5-2869-4288-9b58-7a1fcce9095f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần775", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a756f20d-2c32-45c3-a4e4-a1b80b650114"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần605", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a7643c8a-23f8-4b7a-8e0e-4d02b48a2cf2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo878", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a7a238fc-7593-4a07-9cdc-b6df6075855b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần691", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a7a664b9-07bb-4cc2-b67a-316d89a8ea71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo984", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("a7a6de35-4d9c-4cf2-9278-efdb4aac3582"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần523", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a7b155e5-ee7e-4260-be33-eb419806767b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần19", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a9082b52-1c12-4197-a8ac-3ecdd9a6aa0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần95", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a98c5f20-971a-4b80-81a5-1a2a8a9e7bb1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần65", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("a9d4b723-89da-4eb2-8f19-6a1a9d6f75e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần97", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("aa65d08c-b2d7-4666-b3ee-11a41ec5145a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo438", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("aab09924-903f-4a66-bd35-dab3c631275d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo370", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ab133238-4a47-4189-91e6-23adf52d56d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần951", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ab91029e-f987-475d-b4a0-478710b06b2a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần869", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("abd306f0-15a9-41a9-b745-ae65cd0ebe17"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần37", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ac72796d-5262-43a5-9577-2d8ec1e91fd5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần227", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("acde899c-9ada-4645-8d96-ef30c2dab8c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo940", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ad309792-823c-45a7-b81a-f7c8ba211100"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo32", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ad38ed24-8f7e-404b-98db-b8ae43243859"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần563", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ad5419c2-4678-45a4-8b64-8cbf7ff93171"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần763", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ad76c4ce-bb95-4b18-a63b-3af34460fc46"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo392", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ad9c3a27-43cd-4cd5-b22b-972f5680d70b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo72", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("adeb93e3-1150-4028-b3b9-4799bbebd61e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần497", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("af2a12c3-758f-4497-a349-0c82d299a2fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần549", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("af624a20-d9fc-47be-91c3-0bb67823abd9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo362", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("af9b88c9-5e87-46f7-ab05-01af766037b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo268", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("afa45f9b-cb8c-478c-82c8-de1a6400d955"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo292", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("afb8279d-346e-4b82-9a3c-cc475ae3b46f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần587", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("affab8df-8e12-43f3-a270-aad3f4baf300"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo300", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b12217f8-b63f-4326-be23-aae77507278f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo298", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b1b87eee-b7f6-48d1-bc91-2be9289dffcd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần303", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b231ed43-c5a5-4928-816b-adb0720d5bd2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo318", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b23d2a41-7860-45e9-81d6-48db9fa436da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần349", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b32c629f-473a-4f7a-8e7d-5ed85dc90015"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần473", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b374aeb2-b400-4dc1-8937-05a626009ac2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo588", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b3792c41-070a-491c-836b-1c09b9611aa5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo240", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b388044f-092e-447e-8a19-ac7379c3456b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo986", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b3d675a6-6dc1-4395-be68-85f4e2e38af1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo4", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b3dc3911-6222-4377-8eb4-106c72bb770f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo404", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b41ee90d-f0d6-4e1b-9ed1-0eb20101903c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần159", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b4333f5c-bb47-4409-9e97-743da08582e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo328", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b43a075a-1969-49cd-a47f-1e2248562e23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo864", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b4713fa2-1e6a-43ad-91c0-61cf64b4d843"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo910", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b49160c3-4ef8-440e-aaa2-dfed1627499a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần71", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b52813a8-d9c7-4fe5-9e28-db26291d080a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần161", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b56018ed-ba8d-4433-8b76-0c24f4bc6855"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo658", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b57a1da2-4f49-4bb2-bae5-59302efe4ded"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo112", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b5b5ad4b-5d98-492f-a5f4-76e75849966c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo560", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b66c18fc-bda9-4106-aea4-0f325ba4ae61"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo592", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b6734fc2-c1f0-4c37-b7a7-5bac91334b5c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần943", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b6d2b439-f628-479e-83de-ce0eb6b77f91"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo434", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b6dc40bb-82b4-4e40-8586-ffe3100b907a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần731", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b70c2b2e-3af0-480a-9cac-35f8a15e1346"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo836", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b724435f-4e50-4db7-a937-7c5c3b40bd87"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần301", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b7a8cc09-2986-4266-a317-329350c05f86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo922", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b7db072a-7545-490c-8a1f-b9d27bca8e86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần989", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b84dccc9-00b1-4089-b185-44591faf5d6b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo774", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b86f396e-5ca1-41ed-a77e-b37159030516"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo860", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b8863055-d3d2-4eb0-9ecd-4a01afd0898a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần281", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b888dba3-9ddf-4de2-bb00-484b2b89141e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần957", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b892c32f-500e-4625-ac92-ce5f960fa8cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo780", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b8ac5b67-c3bc-49ef-bab9-85672cadde5c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần79", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("b965bf66-b7c0-4d72-91b6-2772a1688231"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo572", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("b97936f2-17e3-4726-a00a-5f2f9c8e8b11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo50", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ba65c602-9dc5-49de-86c2-3d7164f9f0f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần145", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("bb0936b6-acb3-4d2d-960c-84d29ad8d6b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo702", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("bb3db94d-537c-4699-bba5-b866c1ad6b4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo760", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("bb445d63-ffaf-4e35-b326-50ab12850f89"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần449", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("bb976424-eedd-43aa-9740-893da3c397a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo578", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("bbbf0cf0-c37f-455e-a5d3-1c53837bee45"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần435", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("bc1e09b3-e2c7-418d-a6ba-3ac3382cb761"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo948", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("bc31fc32-77cb-45c1-9178-9628b7c258ef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo34", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("bc8057af-58f0-4fa4-9321-ee6ea3f35405"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần291", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("bc829f3b-08ff-416b-ab0a-84f730e59029"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo0", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("bcaa5f9a-c367-4643-9836-92d0cb317d2f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần483", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("bda171ac-402e-43be-a5fb-658602695899"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần289", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("be784d97-0003-44a3-ac44-920359caa868"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo262", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("be88bee6-9c64-4aa7-9099-9429547abfed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần793", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("be8d2b3e-db08-4b12-9a61-03d827f0d3c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo42", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("bef7f0da-af62-4b31-a057-72f5e9b8e0ca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo742", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("bf673a9f-3cd3-4936-96b7-814210c6d03f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần987", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("bf8edf67-2198-4276-9fe0-f18611d67822"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần171", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("bfb04f41-6610-40e5-ae80-8df6d526a6ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần531", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("bfc38717-52cf-4570-8ac7-dd55625267b0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần537", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("bfcf4532-6a47-4aba-9f41-d1fd44846134"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo488", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c076b871-6fe1-488e-b8b3-46c89ec36c93"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo604", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c0cff1b5-062a-46cd-97e4-16d3b85a1cba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo110", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c0d7dfc3-57cc-41ac-abcb-1db0de8092d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo170", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c0ee28b2-747f-409a-8ba2-3273c863b141"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo992", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c166df4a-3185-4090-a73c-42a7fa3a4707"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần865", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c1ea65d9-a76d-40a6-9054-01b79ecf1c94"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần129", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c24936b6-8e6c-499a-aeba-c9a4a65c4d84"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo886", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c2edba75-e02c-42a7-aff6-3cc77e5c592e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo634", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c38d1ae4-1301-4ee3-b5bd-676fdc9bf7f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần791", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c3a48ed0-7fbc-4602-894d-8ac05affc284"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần577", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c3c9e247-090c-4916-8cc2-eca2b829ec52"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo192", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c3d65062-dd43-47af-bc6d-599a8302a4ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo580", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c3d9da1f-219b-4fb6-9664-8b47989e0394"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo352", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c3fcfdab-58b1-4724-8fc2-22731788ef6f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần637", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c4012fab-48d6-4b3b-a3d6-74b091d51e87"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần903", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c456852e-3cc4-4234-92a5-0770fed4a358"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần165", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c47ed88f-e19a-4a70-8705-6a6af6f5a218"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần633", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c4b8148e-8184-45b3-85c0-a94421932c24"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần329", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c4cfb3b2-edb8-4d15-8870-88b3f501917c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần755", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c4f6d098-fca9-40bf-85af-ad1cc2612b8c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo80", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c50c3a58-cf9f-42de-a6eb-15f60660a323"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần295", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c594391d-bb73-4a4c-baa6-f564e9d14a8d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo642", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c5e29e9b-43cd-4cdd-a45b-d7c7cb472c43"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo466", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c5f6d105-4de3-4440-8477-acde924095d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần187", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c63046d6-24c9-4645-8944-a0c98422776e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần505", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c6573a3f-ef55-408d-bfd5-9a05660df8d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo668", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c755d039-0c2e-45f7-a46e-9330724f4d8b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần507", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c77a20c8-b395-4cc2-b4a8-604e4b783430"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo502", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c785c7bc-5430-4887-9e17-e0bea1a70b39"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo776", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c7b73873-3d86-4eee-bca8-946cf48fa103"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo834", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c8317014-a878-4450-805b-a6b32a54000f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo972", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c8bf3a42-1fcf-4cd0-85d8-75276536548e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần453", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c94fdc08-be33-4f42-af78-1ec4da8701fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo688", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c9605e91-8cdb-462a-9da9-22ae2a695745"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo386", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c964c0f0-bc80-4b00-9001-890789dafc9c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo16", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c97a7291-bd1a-410c-b78c-f62e3996d966"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần767", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("c9d0c584-055e-409b-bba1-d3f351e1d503"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo536", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("c9f75703-062a-49f3-a8b4-0eeb30e7671e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần899", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ca0be6ba-945a-463a-be35-eb090d668b4c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần407", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ca896776-646c-458a-a163-f92ed25c0137"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo596", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("caa3ebc6-62cb-4dca-9244-884091aafcb4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo656", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("cac7b63e-ea50-4fb8-9dfd-a7f7ea477811"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần143", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cb702cc7-2c07-4656-91c1-62faffa66614"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần711", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cb83465a-27c7-4072-8102-d5b2b8ec89d2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo264", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("cb8ac5a8-8fa3-490e-96fb-28baaf19b7c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần31", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cbf3c987-6ac8-4d4b-b1f6-5a905742e620"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần11", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cbf97ea0-2da3-4178-978a-a45b58ec76a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần973", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cc2326c4-0e6b-4e7e-8f66-4e4ad54027a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần177", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cc69e1b4-3317-4186-8903-903d9eb956cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo208", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("cce8ec01-8584-46df-ae2b-c5ac66d2eefc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần547", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cd26ad58-ac37-4e8a-9828-f13ca1248d64"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần681", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cd96678b-4459-4cd9-a751-60adbfaf5bcb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần947", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cdb1a0d5-a9b1-4cd2-96e7-b12d348c392c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần715", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cdd48aab-d91f-45f2-adad-4f3f8a7709f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần195", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ce235138-46ac-4c13-9064-a77249c2978b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo462", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ce292f39-80b9-4360-95a7-ce1420babb3d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần115", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ce45f2bc-96a4-4974-8945-2794f048d1b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo782", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ce55342b-601a-4d02-b09b-f87f6e79af23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo312", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ced82212-bc8f-4f00-9eda-732ed7f6883a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo520", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("cee1262d-8a03-48fe-8108-212b041d1df0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần827", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cef3694e-377d-40fc-bb16-743889762ff3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần981", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("cfbd7c75-3bcc-405f-9ff4-2dea686e84d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo880", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d10fbd6b-ed26-4f29-a9c5-cebdb7afdccd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần983", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d1120b5a-450f-4c80-9d11-e7b4dee15116"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo748", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d12e461b-8387-4cf7-a192-0a227bf340c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần109", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d1b70a46-dc56-40fb-8f40-e65ea0bad5c7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo86", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d1bbf91d-aa79-43c8-869f-75970b79aff8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo114", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d1f44282-3612-4127-a0e5-8bb11e8f7715"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo250", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d1f84493-ffd5-477c-ade4-cc10fb2fcaa6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo194", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d26b513b-d416-4afb-be55-5720869d6f75"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo612", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d286c373-b2b5-4da0-9e83-e90137bc2801"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần487", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d328469a-201a-4d2e-8097-4b7eed4ce491"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần831", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d32f4473-cec0-434f-b822-0aa2dd3043ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần575", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d3755146-63f2-4907-a7cd-da1b28a56ca7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo432", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d3d9934e-b445-43cd-b953-ac23c5adeecb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo340", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d46f3aa9-beaa-46e1-a783-39b771389dc6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo944", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d4779b5b-4b8c-4927-9daa-c907e89ddb20"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần803", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d48ad3d0-c31c-4228-a65a-419b9e1ae5f2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo116", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d57e2b38-d636-4a73-b1d4-8168ec76f4a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần737", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d5a7ea55-1780-45e4-90a1-bed2486db816"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo686", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d5b23b98-e728-4872-bc2f-1fd4400aff66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo342", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d5b5c338-0e1d-4fdd-8092-09ea26bca626"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần127", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d5e637a9-beb6-45ce-ba54-128e14a76c58"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo44", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d610e0e8-53ba-487f-bbfb-88727467cb0b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần417", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d611e5b2-e3de-4c8e-b40b-c6503d6d133f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần375", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d62e48cf-a249-41b2-8428-3152ae5e4309"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo894", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d63d7615-a819-4b30-8386-da47088beb0a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo414", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d64bc9fc-f221-4039-8709-6c4272c19f3d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo770", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d66384e0-a994-44d7-a0a6-c2eb7be2936e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần427", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d672285d-a863-4288-84b8-c7e154632951"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo956", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d67300ec-7798-4e85-9442-172d932893fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần251", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d69cc864-6f79-4a00-ac43-93ad33ecdab8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần103", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d6b63419-b255-45ab-bf4e-398e860f5afd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo778", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d73351ad-6cac-475e-a42d-da5beb1fa3a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo730", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d778851e-b021-4f12-884d-59e07e83cd57"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần117", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d7a65d74-2e64-4a3a-b299-587bb80ea1c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo200", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d7c1613e-430c-49c8-96c5-580773e300d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần975", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d7fc2408-500c-4063-b0a6-2bcc238c5376"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo8", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d8b232f5-198a-4879-a0a4-ba14fb8bb9a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo254", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d8c6bf05-a22d-48bf-98b9-666b1405ddab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo258", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d8f9eb4d-66d6-4c40-98ac-3736c5a153b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo504", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d90b03d0-009d-4b3f-864c-11c7239cc8fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần859", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d958add6-bcb3-462c-b57b-14a0bad98978"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo168", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d987be92-4df0-4d5c-b407-16835913acaf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần219", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d988f4d9-2297-4b2f-a3ce-41cebafbc83d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần823", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d99648fc-8e38-48af-a117-401ffb0e5c6a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo314", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d9afd20a-b229-4459-93f8-384717c8c157"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần371", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("d9b10d08-a8c2-45e8-9cba-5bb81031584d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo290", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("d9c256b4-e96f-4595-8e61-77a9fad91871"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần305", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("da17bfda-aa97-4e1d-a324-60efbc3db302"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần61", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("dac1a360-49e2-4187-afea-399027f249f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo602", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("daf7dea8-8c8e-4b07-9306-0d64074355d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo448", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("db966eac-3339-4410-bd15-75caf6ff10e5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần365", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("dbd24e4d-5b8a-411a-8d2e-661d68295325"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần541", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("dc277b46-7070-4caf-9dc4-3bc8b87abaef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần443", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("dc465b68-08d9-4534-a766-698b3233527d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần363", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("dc5ef3ed-cd67-4352-945a-e03767774d34"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo306", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("dc8e8928-6225-4a90-9f77-af59ecc88940"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần141", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("dcc08567-6b43-4f7e-a6d0-f481e0ef3d99"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần579", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("dcd697eb-a9c0-4093-96ed-7b60ad1727a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần459", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("dce68385-ab60-4a3c-93e4-92c2f08cbe43"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần615", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("dd0bcc43-52c9-4611-822f-6d4a1c66173a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo728", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("de2810b2-270e-47fd-a323-fd4d9b2f90b0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần49", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("de629953-dc63-4735-8463-43a73cacc459"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo212", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("de7e205b-4437-48b9-92b7-32105cb8e605"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần571", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("dea3a580-85a2-4cc8-95e5-84983d72c5d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần597", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("df2540d0-32e6-449a-975f-c2adf5f09bce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo494", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("dfd57cc6-9ed4-48a5-91f2-d63a77ac312e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần393", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e09067e4-1c90-4408-9c2c-8cf5a82664a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần747", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e0d71f98-0d2d-4f53-964e-e69c4771899a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần491", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e0f6f3a9-9e3e-4bbb-84e4-d7f1af4937a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo546", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e1041a8b-1cde-475b-87de-5ca839eb0afb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần845", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e1a85e38-befe-442a-aa19-36344fc87bb0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần183", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e237ec6c-bcf0-40c9-b4c8-99c18e5d5f6f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo846", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e246ff39-09a3-4937-aa24-ec05f29d8110"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo384", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e25bbaad-bb4c-42ed-a282-4d08301c51f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần255", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e264ee29-bc30-42a3-beee-4e2175028bbd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo320", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e27174f0-481d-4202-98d4-f687012f7a7c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần641", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e2bcdb18-18de-4622-96f8-270899ba4097"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần765", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e31362b5-9a9b-4d8e-be90-7aa98255cf82"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần401", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e323fdc1-0476-4ca9-91d5-06950b8701e0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo818", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e36b16a7-5d71-415f-b6aa-92c6f9b98be6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo964", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e3810fd7-41c3-4b87-bcf2-6f67824fe76c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần1", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e3def886-d8ee-4115-807b-09601e1de955"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần771", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e4713b93-57ba-4e64-ac2f-307126e3e180"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo160", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e478aa34-e0d2-4e08-ab58-bc4911d01172"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần785", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e47a6c42-aefe-4f02-baa9-4aa0c1c15901"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần745", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e48f1592-9994-4205-8c2d-4de4b921d6f2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần121", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e52a1270-a9e8-41f8-a2b4-601bf67b8c74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo398", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e5348f04-6a71-41a3-ad3f-ccacc27a7d15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần769", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e564ef51-2397-4749-b6a7-b35e6e26c1dd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần961", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e5e31381-8af3-419d-8ba3-b0a56ae46803"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo294", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e657a8d4-e060-42c2-b850-9a1055ee8144"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo24", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e702b9c4-8a28-4b78-8b67-93a8f23d3c38"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần173", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e70d7f91-3f63-4332-8f59-c2529c93b994"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần139", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e7421c39-cd0d-4d43-8883-9a643a657979"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần595", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e79841b1-8621-4a39-84d2-e14d2b7ec2c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần17", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e7e53de1-bd18-4825-8e4b-bfebfb2019e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần753", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e7e8d082-3315-4fcf-9668-5143e690a5e4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo898", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e82bb48a-e659-44e1-a256-9804167237cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần85", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e9049ba4-3c82-44c2-b908-2ffc4f6fd19f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần999", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e92cf7b6-4935-4713-8484-3f750a48a124"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần199", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e944cea7-9737-411a-8af0-fe9a30a04a8c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo970", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("e955e95f-fe58-4c7b-85ab-5523c13590ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần969", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("e9fd4f71-dc5c-4360-8042-50a82929b5a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần409", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ea06fa33-6ff2-4731-a9d5-00b71dfe2406"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần25", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ea07e62b-95f7-47bb-b153-64d375afde41"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo478", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ea1eb95d-1d1d-4cc9-9c8a-339e420bc171"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần21", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ea3e17ad-b364-4e4a-b85a-92cfcafde195"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo280", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ea9ee9f6-79de-4a77-9995-e70d178cee89"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo46", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("eaa42ca4-e1e2-4d86-92d3-e25da8127dda"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần73", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("eada645c-b7c6-469b-ae13-be04f2844709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần241", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("eb15e6d3-aca8-4e9d-901f-abdeea163e67"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần355", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("eb4bd2d8-1b47-43f8-a907-e748a2712dc8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo482", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ebab16ea-14fb-4fec-a4a0-4e05522bb4a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo142", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ebb7c64d-9f2c-4914-92b3-8a0a3107a851"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần781", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ebc62485-5ba9-40b7-a1cd-aacde695c4a8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần495", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ebf8e894-234a-46ba-b883-ff01f730df4a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo854", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ec0570c9-5fbc-44b9-86c8-c18a5eeeaf21"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo692", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ecbe9cc9-e582-4fcc-9b57-ebfa7ca4f5b9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần759", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ece8a010-1167-4d5c-98f0-6f72a6c6d606"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo6", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ed2e8f2f-50c7-4bb4-aa2d-9ad7496ea7a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo952", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ed4678b9-ee77-42e2-b4bf-be0a80ea9108"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo830", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ed9fe73e-9bbe-45a9-b95e-4228380a80a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần705", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("edcbd2ba-11fe-4280-920a-5069df71c421"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo590", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ee300fc5-d8f8-4725-9928-5b83a410f598"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo862", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ee934dda-c241-4e8f-8c93-c5d1d74fcf56"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo506", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("eea2f50b-bfc1-4a15-a0ac-8a073d42e3d1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần125", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("eed47821-16de-4157-9940-849b0d390030"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần413", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ef227767-884e-44d4-83c8-45970a286e0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần9", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ef56f1cd-5339-4a58-80e4-171910e5bf68"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần813", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ef7bea1e-8f7d-43fe-934b-5971dfa5a9b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo270", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("efa79b4b-60ab-49d2-a3e9-af96b4882103"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần617", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("efb43925-8ac3-42d2-93e5-7aec668da301"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần169", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("efbfc6b2-5376-40ea-8a0a-30444fc9b81e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần373", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("efc94a74-8850-4140-a1cf-ea72ff857ce4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo804", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("efd7cec1-3a1b-4481-bf4e-8209471ce9e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo574", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("efe1e5fe-9666-4ada-9d1e-1e1ecc896cff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần867", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("eff769d3-4f65-4775-9ac9-1862d0524c6e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần805", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f0475760-576f-4e5c-b42d-b074a580d9ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần677", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f0793e9e-0f8c-4ee3-aa17-8dc0d3e561b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần733", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f094e55c-0b4c-4e11-bd39-32f861d7bdd2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo316", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f0b9080c-4b73-425c-853e-c916ba0afdcc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo762", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f0ea2ea6-3a8a-4b41-a5b7-4a2e01566411"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo164", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f13def83-7a5f-4b1c-8a71-543c760e0bcc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo706", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f13f6944-58d5-4176-a765-fcefd14b944d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần335", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f16ccec4-8d72-44a7-ba1c-0ed3e117dbf8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo934", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f1fd095a-3ae4-4467-a91f-c216404f9f0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo636", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f2212013-2427-401d-803b-78d00bad0c81"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần429", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f248d9f7-5dea-4662-bbb1-6db2d37a21c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần339", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f27709cf-6bda-4105-9802-eec43955a7a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo554", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f29363a8-a7c6-4856-9a5a-02c089f9deac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần945", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f3032e27-cc91-438d-b7a3-3a8cbef31352"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần185", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f342b7e1-ea6c-4864-9686-859a85622f04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo100", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f374fdf7-f7d0-4d6f-ac8b-ac190983fbd9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần695", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f472c25d-0d2c-4b1d-bf19-521d0e3d245c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần663", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f48201c0-d48d-47ca-b18f-55b3bbb27a05"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo698", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f48d44df-59d8-45cc-b862-5bb8e008ff7d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần555", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f4fe4e01-9cc3-4a0d-9ecd-9797137fbba5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần447", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f5c8b969-af29-4d56-ba3c-595c2ebe3829"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần539", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f6815b65-4df1-4d3e-b0e8-d650d163d630"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần485", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f6bd8d1c-2cdb-41bf-bb74-2c316101128c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo790", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f6cc29f2-8e6e-4109-9cf0-99a8bf51b5e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần933", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f6e10609-c140-4799-b437-0674f54b6413"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần517", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f7252584-355e-48ae-a345-08a941c27be8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo606", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f72c3c71-7695-4999-8292-03fea1a4defc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần101", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f76aaa9a-aa62-4f80-a075-916b61a3dd89"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần501", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f7710b7c-59a8-4a1b-8ab0-86adecbd8985"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo838", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f7cb98fc-4a26-47b1-9085-16b8d5269efb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần967", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f82591ff-0999-4943-b5db-47ff57991744"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo640", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f831c33d-41c9-41f7-a2a9-1f9ddac131fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần635", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f8bc4fc2-5d90-4d81-92b8-b1e6fbbbfc2e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo900", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f8c13b0e-33bd-4d95-a9dd-b04f7c3b2315"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần99", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f8fac33c-f07e-4181-9695-36e4e5c88a77"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần399", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f91ad070-e83c-4399-ab5a-0ee81fd4e722"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần231", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f93a024e-d107-4c45-be65-7b8855f5e49f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo844", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f9936fbb-bd69-4520-ba6f-5b530af44dcb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần345", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f997f622-5747-414c-84b4-c585a5162189"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần885", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("f99a06a0-181f-4bed-ba96-7f3cb788127f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo998", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("f99abaaf-79b8-4e8e-b19b-a77171369df7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần327", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("fa83eb01-1053-49b3-848a-12334f3db279"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo738", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fac1fbf2-aa8a-4db1-86b3-c51154c165db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo146", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fac78574-6a60-4260-bfcf-d7ecef1ba9e9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần477", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("fac8c176-3ed7-4b79-a999-c94711525c31"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo518", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fb0150e3-237c-4a39-97ea-c860cd02f4dc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần123", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("fb34f127-0309-45cf-b61e-8e1cce8041e0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần625", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("fb8e62ea-e339-48ea-b6dd-31ab6d8f6f71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo784", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fbabf16d-00c4-4b7d-999b-61dc85aa28e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo978", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fbafd372-6151-47ef-92db-f52ce555e1d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo850", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fc0603a1-39fc-4cbe-8869-ad3230acaca1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo140", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fc2291a2-62fe-4026-9696-393a4979815e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần603", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("fc2dddbd-f42e-4fe3-8e2a-90910e4bae45"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo256", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fc301760-56d1-41a9-a433-cede095e39c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo36", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fc513e5d-1bd2-43cc-a69e-477b42c8e2c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần89", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("fcfa8c4c-3e3b-4a56-8b51-db9c0b427565"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo832", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fd0aa164-c93d-4207-a9f5-4d9a1044a2b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần929", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("fd454f1a-0a9b-4977-b248-28424cc9e7b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo792", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fd5d8307-d24c-4fa0-9042-b5f8cd83e6f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo2", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fd73032e-b029-460c-9b2d-d771651b2f74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo96", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fdab3c05-bb7d-47c2-b450-2c5c4f7bf73c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo182", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fdb88a76-07dc-45c2-9b2e-b9d15760d49a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần871", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("fdeab895-1ab7-4bcb-8431-90485e38109b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần157", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("fdf53a57-18bc-4770-be2f-192e33cdd7b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo508", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fe05e9c8-5613-43c9-91e3-d199bc2ebd69"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo626", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fe7148a1-c3e7-4901-9971-10b62a38e56d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo806", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fecdfae0-07e7-46a2-bff2-6e6c0d86fa16"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo480", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fed82d58-0b87-4c40-9ea0-01d08c8c0a5b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo38", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("ff0f8758-c1cb-4f23-9d4e-2b76b1538f9c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần47", new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"), null },
                    { new Guid("ff6557d6-e42d-41b1-b7c1-4eb0e2a60a3a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo566", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null },
                    { new Guid("fff3004a-dd76-4012-b4bc-98efbe5f83f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo302", new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedAt", "IsDeleted", "Status", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("2da7b79f-5d37-4fb6-8e02-f6df3db3ba71"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("af59abf9-3a74-4bc4-a06f-798c2cfae79c") },
                    { new Guid("76ef2da9-5234-40c2-b9ed-7cb169925f9d"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("af59abf9-3a74-4bc4-a06f-798c2cfae79c") }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("dbac0a66-9521-451a-856b-ab02e18575c0"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("755ad1e8-e1ba-4284-9e5a-eb6095c9b26b") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdatedAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("2da7c582-8f86-4e10-91eb-c837cf2bd596"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("dbac0a66-9521-451a-856b-ab02e18575c0"), null, "https://example.com/images/ao_so_mi_nam.jpg" },
                    { new Guid("6805a866-ce9f-4ab5-8e73-f920b3a67082"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữ dáng ôm, tôn dáng, chất liệu denim co giãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("dbac0a66-9521-451a-856b-ab02e18575c0"), null, "https://example.com/images/quan_jeans_nu.jpg" },
                    { new Guid("e0eff2c3-402f-4e46-b5e8-cca27e606d86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cao cấp, thoáng mát, phù hợp cho mọi hoạt động hàng ngày.", false, "Áo Thun Nam", 199000m, new Guid("dbac0a66-9521-451a-856b-ab02e18575c0"), null, "https://example.com/images/ao_thun_nam.jpg" },
                    { new Guid("e68edaae-a9da-471c-ac84-a93bc1789963"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("dbac0a66-9521-451a-856b-ab02e18575c0"), null, "https://example.com/images/chan_vay_nu.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("008e43ee-36cd-4b39-919a-6c3aca8902c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00a9815e-09cf-408f-af76-73b030dbfc06"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00c26f07-7846-4f90-b852-572845418f44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00ec741f-dbee-4b68-9d54-e6f03a024682"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00ef0939-8fda-4bc3-a8db-ef83ab3175de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("010cc40c-6ce0-4b89-aaa5-3e2817dff53e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("013c2a9e-3637-426f-8133-9303a0719630"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0182d31f-77ce-4c44-a531-fb476f7cadbb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01a563b0-28ae-4737-beb4-d28e17f2e0ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01cb4c3f-b898-49e9-bafb-183927bf37c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("021ea924-518b-4679-84ab-3605c69cb0c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("023e0682-b56d-43a5-99fd-8429bb6e544f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("028ed367-f7be-4717-9aa2-a9dd53d4a18c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02df48e4-095f-42f7-a728-b2ccb097fccb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02e4c92f-9c06-4074-8a83-c4fdf0cc02e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("030a9f48-4ae2-4fb0-abb2-a4a40b5cf210"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03184e5c-7500-47cc-b2d1-311402f0c89d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("031b3229-959b-4a0b-b435-a1add5167d4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03444d39-49fd-4662-9055-70085dff9728"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03db0c61-2e60-44c9-aee9-ad8a46e3eaa9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04111bec-aead-4e20-8f5d-4cdd04d292aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("042ee0ab-ea61-4ad2-b7d0-c73d8383cf38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0464cfc3-1e12-4846-aef1-fa86be779729"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04b11efe-8f51-4871-8d16-97c6956f0abf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04c01c2c-f8ce-4b99-928a-e23804687ada"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04cea101-f1ae-49ec-9e5f-fe63f27e0b69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04f55700-08e9-4440-955a-d1592e5257c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("056722a9-d937-4774-9dfa-0753285a6be9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05857431-a227-4801-a40a-64a4a9b65a97"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05c639bb-cb4b-48bd-a7c6-cb3935335370"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("071bc6bd-d7fc-42ec-9cd1-68b67710497d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("075db2a8-427b-48b1-984f-8095ae3bf1ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07b1ee2d-14e2-4170-9ee7-449201ca1f41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07d115c5-c46c-4038-bccd-55a70f35e908"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("083bbfbf-e744-4da6-b2e6-718d7a733b82"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("084a9e99-47a6-41bc-8c35-dc96a901cf9b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08794b14-c2ea-475c-af57-ee4e4b75fcfe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08c8cbaa-4753-4d39-882b-4b0706085fe5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08c9d5da-6482-4584-93f6-b1acdee82dd8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a33b5da-f673-4878-9302-5637eb3b1183"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a7afccb-e8bb-4d1d-9986-73018bc10432"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0aa1e584-238f-4443-b493-da7296079ce8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b256158-d7f7-4476-a98f-c79beafd2ffb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b781ace-8ca4-4b17-ab0f-5349145d1a67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b9b6c52-d0cd-409a-aeb9-41cc26026db3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ba23ce5-3ca3-4a03-8692-74b55734b0e8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bb64710-774b-4096-bf5f-f6f9e1b3ebf5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0c04aefc-d5a8-423a-bfd7-ada78e3dcac8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0c221c09-6e6c-495c-bf9b-36d537d8f5c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d4cdd8b-a77f-4eec-a65f-d245a17cd587"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d61aa3e-b270-478e-b8f1-af1c6a4d7185"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0dcf9207-61ef-4cad-80ba-017e464ebfd6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0dea6249-a8e9-4ccd-bc51-493a90b017d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e5c65b6-c9a5-4cf6-9e17-e3c19d6ddea5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e8b2c63-0719-4f5d-8dc0-fe9b9a4a3e01"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e92cdb5-7a39-4b57-9531-eb6642133e6f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ebf5831-9acb-4694-be5f-b11e665d39b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ec2bda5-1acf-4575-ac75-9f439d24480e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ef6c455-1f0d-43c8-96fd-71ef5aae26fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f20be41-d439-435a-a1b6-448cf34a9603"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f228470-0b77-400b-b3a2-0cad7ae30555"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0fc7d4eb-05d0-4c41-bc6b-9b3166da7bfc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0fe001c5-1d4f-41eb-8e69-76b3f70a89f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10241407-9968-416c-b886-2d78076e4033"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1075a2ae-9cb7-4cec-9103-eb68c0869c20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10c943e8-3686-42da-aabd-647b09bb9943"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10f24f34-3b7b-4b3c-b567-54c016e30c57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10f8f129-ebea-4f6a-87fd-8c58cc348ff2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1128e343-ab59-4c30-b4fc-9e639c23a7b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("115fb7d8-9830-4af4-80bb-76d6bd996fe7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1176e018-07b2-4155-bd34-773867f82f3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11cc73dc-d6d1-4d80-ba06-8d6feae60303"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11dd6b5d-e0bc-4d21-909f-ec031e80b2d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1217cb9b-8ccc-48e3-b535-6e804fa48a1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12332a1b-bc88-4db0-987f-06d3464218aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("124f0f1e-121d-4372-a73c-6eaa544a362a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("126aa43f-bccb-422e-83c8-f75d4b619d75"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("129b7871-221a-4a0b-ad5e-3b3ea18096e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("13048d7a-d152-456d-8175-72a65b4073c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1341667c-7574-4008-8c5b-845eb93b26d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("134304ad-8d27-4713-970e-2041989c195b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("135aeb86-9ada-4bd8-adf3-7ff4698c20f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("139a3612-2979-4e68-835a-da993df0d690"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("13e0cfac-0883-4d9d-b545-cac2fe712467"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("13e13dc7-7584-48d2-8aba-249915369471"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14b6ed4d-b23e-4092-8332-fd5800834c94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1540e517-776c-4546-be6b-acf6c2adc160"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("154a3c4f-c72e-4790-b531-c5ed9be40fbf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("15522966-7511-4282-ac17-1b7ec1903c82"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1574d8c6-71a2-48e2-93ad-d60a4ba7500a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("15886220-f5b2-436b-b744-581c1eaf1a9b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1680515b-4301-4559-b9bf-bc8a1c1150dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("179b043d-cf8b-401c-895e-0f579874e6fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("181b8dce-ea62-451b-92c4-fa87548ced00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("189e322d-b89b-49af-b669-e396a35a9c37"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18b0e3e5-7e55-4e90-b9bd-b18a65dff27a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18e02d94-bec0-419e-b5c0-6c730e0dd180"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18e36c79-a50a-41e0-adb9-985e41b83a8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18e6dc1a-12ec-4367-a06e-266ccf6abaec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18e85c1f-6cf7-48ff-9825-3d101180f78d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19141db3-3003-4ed3-9aa4-7d89cd92c70d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19225b11-21ac-43db-911e-1ec127a7ee1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("192b88a5-e670-420d-b0ef-39899fdfca4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1959440f-5c6b-429e-a20b-8fa0ca1aae85"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("199a90d8-70cb-44d1-be67-1535bb6967e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19d1b4dd-d01c-47e6-81ab-42f1442c351d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19f579d2-5be2-4e9b-9b10-de1603e5d5ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a3890fa-8046-4aec-b32a-7a25bf0eafc8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a8637ae-e43a-43c5-b25e-63667a03b418"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a9a8402-c8f3-44c8-afd9-1918bfdc786f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1aa7f1e9-1793-400c-ae50-a84dc738726c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1abd7f56-26d9-4bb7-936e-df829609ec93"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ad335ec-2db2-4898-b562-a040b85c1ae2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b0382aa-dac6-4eb6-a8e8-40bf696e6d40"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bcdc8b8-a6b8-473c-a4d2-fd148eed9b22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bdfc7f2-c8a9-40a3-a29e-aa30ce233ce7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c325b9e-d685-4a0c-b796-0e0c06955a77"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c4030a4-ed58-4f61-bf78-096a950d2cf4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c48232e-35da-481f-a2fe-0a989c9d1add"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c9154b9-1129-43d3-8eaf-30a541608334"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c9d0c53-443e-47d8-a0ad-ab8cc039ab6c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1cb2b580-7f25-4bdf-9089-e63fbc818166"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1cb9a58a-4177-4be5-8fac-b1ebec5c4ae9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ddf93b2-0a19-492f-bf50-efcb3298ccd7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1dfd83ea-269b-4132-ac39-521d151aa13b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e35fad8-d1b3-4795-b8c2-97cde6108a13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e377e51-d508-4c08-a01a-cb2825de9e87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e5bb663-ee94-4ffa-9cda-12bb4e609b86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e6c4dbc-d1ef-4746-93c0-8711d529dfd9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e9b341b-cc7e-4ffb-9888-480d594b90db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ea0cb03-e7a5-4e8f-b041-3f3f5cd98041"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1eadf96b-cd4a-4599-b174-955d730ca113"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1edb3670-807f-48c9-92db-2468fd1649a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fce2b31-21a1-44bb-9894-6d1d8e7f90b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fea0cc9-4d40-4364-b3f9-458b0b4363b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("200492b1-16b3-4c22-983d-707dbe84e26f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20ea64a8-67af-46b1-99fa-30fe28b14226"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20eb3846-936d-4f46-8ac9-104f9b4b4279"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("211d7879-01b1-4381-8eaf-6bdf49caf35f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("211d993c-b8fb-47dc-a25a-65dd876a091f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21ac082d-9e8b-45ce-9fe1-20cb76850b12"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21b015ba-7a21-46b4-88b5-58b116c8c135"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("226f5d0e-d0db-41d7-b943-05bfe3520109"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2274898a-278f-494b-8b13-114cda226721"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2289f95b-b2e5-4732-951e-51421433c594"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("229014cf-f10a-461b-bd6b-930cfef4245d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22903cc3-7e5a-4e89-a557-2d92d6f620fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2294a483-6b85-43ec-9c33-9d863d0bfc7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22a4a23e-6998-42df-ad32-059e4b828015"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22bed95b-0d4f-4f7d-b010-6fd4c046f909"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2329c70f-1c40-46d6-bae4-64d1b535aaa6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2338c1d7-8478-445d-9e29-5776dd46edc1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2398e162-983b-4c60-bcf8-0f70b4bcc905"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("23f44de9-fc1f-4a6f-b44e-65a41b562ab1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("24040f46-52d2-47af-b767-9a56b659d6d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2414b4da-ce0d-424b-9952-b71277858aa6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("242c42bd-af9b-4897-aca0-c88462329242"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2475c35b-6944-40f1-a33e-d2416c11662f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("24bc80d9-6d7d-4629-8c05-42e65a90ed8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("24f27ede-b930-449c-83d6-5049483d2a27"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25c72cfe-6576-4b88-b655-e51a2def8ad6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25cbc881-722a-4852-a429-4e02fe948fe5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25dfacec-48b8-45f0-a199-1b0937332121"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26ec6117-59b1-42f7-a683-41176508c414"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26ed943e-dad9-4099-9adb-297657e2afe9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26f92bd0-5ab6-4c55-8dbc-8102f9f616d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27075185-2781-4f37-a9d1-e36452d1179d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("270a781c-08d2-495e-bb1a-71ec3ee74013"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("272077d5-4f6f-447c-86e6-05a873d2db8c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("273e817b-611d-41a3-bc6f-c51ab952d32c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27a02895-553f-4927-a4d2-1abc1e68b2e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27fc80bc-9156-4491-aebf-624e61a13e06"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("283becc5-1094-40ad-81aa-022ed1bb614f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28b1fab3-2875-499f-bfd8-5d7f4d115b30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("29b210cd-216a-468c-b687-808b103ea264"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a1aff12-41b4-4f7b-8cbb-403f8a4b12d7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a6a58c2-9602-49dc-9f01-225fdf38cfe8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a89c95b-3b34-4648-8eb4-6e10646ec117"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ace647a-48e0-4239-af01-c16a1a008c3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2acfeb0b-5502-4067-bdfd-23bb07119b37"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b2c6ffa-0fc7-4802-abca-6162f61e4daa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b4944f4-4a6c-455e-9d81-20ad40f13c0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b5ecebb-e19f-4192-aea8-668229e8708b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b94e5c0-2459-4a22-bf37-f3f35a5b64a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b975dfd-d380-47ef-a1ff-9002b67e0424"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d6502ea-96c0-4ae8-8eee-2b549d4409ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d6bed86-d182-4243-a1bf-9e9fdc013fdd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d942534-07cc-4c13-b1be-597684df295b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2dd2a690-86a2-427f-8f9c-6656c0b56aa0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2e2f43c3-e944-4b85-9103-20c6b96ae6b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2e96fee9-8738-4796-ac8a-8b7a07312ce2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2fd62b8b-0334-417d-a1ff-becb78ad5430"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2fd9fd59-fcb7-45b9-b280-8a7027c3412e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3062f2e8-4c54-4f1f-8209-c7434f3c4142"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("310f6f94-c936-45d3-8028-29298fd07aec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3119a133-5e61-473b-9aa1-70043f365493"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("313ed283-60d6-4b9a-9bc7-ba7d4af0d116"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3185d8bf-f0d6-4e64-85c6-af98e8079dfd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3187918c-ac86-46bc-803b-51cf3f491588"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("322f22e9-a865-4e6f-9512-a238a1cb16fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3250bbcf-cbf6-42f8-b8a1-9003c463efcf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3275bb56-fa66-44ae-9e2b-a952d26b9edf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("327ce3e6-5ac5-4903-a698-dc00f58d460f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("329c5da9-b5d9-4525-8424-93761d6b2af5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("32b1212a-f295-45d0-a03c-1de7d87135a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("32fa91f6-501e-48ac-a602-ee36a2aefd29"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3309ee19-ee70-4fc5-a3c7-f85a06153996"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("33326349-4132-4b25-ac5c-333325553606"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("33637468-258f-4e67-a447-c1883ac88c7f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3398ff80-a1d9-45b4-9158-40d023418795"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("33efe598-6ca6-4978-bd2e-5b7fb3e73be5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34344188-3702-4ba0-9059-6b7366e464ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("345fa670-352d-46b7-8777-de2aae6fa464"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34c71d7d-b255-4561-90ab-dad33b7a7f03"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34e19b89-e06f-4fbc-906a-611488d05a3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3573999d-184f-4fc2-aefa-0453812cc87d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35da3ad8-6b88-4e9b-9a68-a199c2177015"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35e761cc-08dd-48c2-b423-496d2bb39509"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("364259cc-7cee-49e3-af7d-1b14ec902427"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("368fa558-65f7-45be-886c-a776ce80b84d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("36cd6968-50f2-495c-b08c-b557c8e7d147"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37c5282d-b825-46c2-ad14-0b289abc75da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37d2203f-3fd8-4842-b2c2-ee7faa2143e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37d83065-9486-4d65-b7ca-94444414f890"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3823cd7d-51bd-40c7-8167-80b28aebe9d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3890be5c-d9d2-475c-8cc0-60171af1b17e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("389bbe2c-ad82-4eb2-afe4-d70a675e16fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("38b6d481-c15f-4418-9c96-157ea1197958"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39182ce4-944d-4549-8fc8-cf2ddc5cdec2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39853178-4188-44a7-ba64-c95ecad4f124"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a207576-8e2c-4012-a3df-f489d6872852"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3aea8686-53b9-4869-9a70-49fc8258a986"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ba605b8-e2dc-4f47-b10a-be805a8c847c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3be7bf60-6b79-42a9-bcbd-652261a7a747"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3beca282-17d9-41eb-b2d2-711ae989e321"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d1c44ec-19db-47ab-bc3a-7d7cf1718d16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d3498b9-4c31-4776-9877-c7cf6cee48a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d82b58a-77db-444d-a950-30ca6b38b484"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d8c79bb-9ec0-4cf8-8462-0b3d1bb1d590"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e380fe5-06f4-4e1e-ab96-4b80875c8e3d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e4c088b-0e9b-465f-90df-743cbc76d150"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e653ba0-5748-453c-a5f4-5402e168d83c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e98fcde-ab56-4c24-b821-0eb0638b91b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e9a261a-60d1-4003-b7f8-20c9d04e1c31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f0cca7c-8bc6-4d37-8fed-1e82801f2b0f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f245bbc-19b6-4ecd-8a45-c01cf203a948"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3fc98c57-b993-467a-8956-ea9fa231bfe1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ffa2f17-44b9-4ae6-a346-3aeb01fea9fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("402b39f7-ded0-408e-b42e-a39429414193"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("406599a4-6bf3-45b2-b8af-f89104def0e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("407c7ebd-1604-4f5a-81d5-38fa96627322"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("410ad9c0-0f5c-4d95-a111-3fb42d83f3ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("415349f7-c48c-41f8-ba14-68c2ef807504"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41b2e681-d0cd-4869-940c-fb8af743b8bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41b3e022-47eb-41a8-aaa8-8d0aba1b9423"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41bf2433-ab32-408f-b9d3-871a4a6eaf5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4253cb83-efaf-4194-a16b-00629bcc7749"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("431662cc-6365-4606-ab77-9516a49e46bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43825473-874b-4c24-acca-84e86e1b7677"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("444e4dd9-7b7d-41bc-a27a-5237a77973bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("445771cb-e528-462c-b285-d3ddfc5a4660"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("446d8f13-e95d-49bf-9980-64685b889b31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4470aebe-30cf-44d1-8b81-f1c49a0836da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("447ac88e-ff4d-49ed-87b7-b88e94559bbe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4491ef42-5898-4455-a74c-edf307ceb956"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44a0fed2-f735-4483-b6ec-26c7438115a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44bd79b9-f119-49a6-a4de-8ada660ff362"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44e4ecbc-aac7-4b76-ac47-53d324ab7dcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44e9cef7-7aa2-4000-8b1f-bbd9270660c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4515f746-6357-4ca9-a78b-fa9f33511242"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45708105-2fb3-4577-acef-c4d41acf66d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45a7beca-5736-4518-9f7b-e0b585d6468a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45a83203-aef5-422a-87d5-6262eed207b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45d6199f-49ef-43df-9e4d-eec35a8b24b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45da3d80-9ccc-4fa0-b7db-b46776aecc6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45f239d3-a6c5-4398-8722-6fc325e3a974"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4635d0d5-8c17-47ae-9dae-b1a537fc651c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("464a9737-3e2f-4652-871d-14ef2d883de6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46c05313-51a0-475f-af4f-6185d35234e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("475b8138-6b04-46d2-8158-f52d81453c05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4799995b-802f-42db-89be-94fc7c417423"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47b9fd58-b100-414b-a24a-b0459065e1be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47c4dcda-dfb1-4122-9162-fac3cb9e98de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("486725c8-89f5-43d8-b798-cd395bfa64ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4867955a-1a47-478a-a263-3987d85b1240"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("488453e8-0692-4667-917f-d3da7a6d916f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("488e9821-011b-4b15-9f32-b55d5855672e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48b513ba-3269-4009-b9f3-77e55831e47f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48de5cc0-56e9-45c0-ba53-6472d21118aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4923af5e-2fcd-4070-aab3-7e6c3044047d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49632d18-1cb2-4c12-907e-4036eef967f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49748b69-240e-4da4-a3f7-a97e1eed1218"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49a39643-227e-4998-8ae9-8f64687220d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49ad72fe-f7dc-41db-92a4-97c8d8629e4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49ce3965-e4e4-4325-b4ba-a0766ad78002"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49db9ef1-71ae-4650-bf39-18de6bb4dfcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49deaa7a-759e-4a00-b026-935db294f2cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49f5ff7f-d052-4d49-95f9-44f6623a6327"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a1b4e23-5faa-4020-88cd-a45b2b06e58e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a28004c-0a36-4312-9c5f-f1e73a9d5a3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a311c1a-220e-49db-b36a-114afb52a66e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a32ce78-acb2-411b-bc9a-7678541139dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a39177e-dfee-4404-a204-48fe6e96088d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a8278b7-525a-491b-9fa8-62ed839df68e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4afd9e4d-24d2-4769-8f09-ee9da716d990"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b60f6cf-a085-42eb-a082-fbfaf6ff9942"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b9efcde-d2a4-41ec-90b1-54e7a82c655a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c57b613-88fb-4369-aec3-fc88f034ddfb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c5ca16c-47b4-4efd-b4d1-7e158060adf2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d2ef19c-5a44-40fc-a06f-93acbb956476"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d686adb-bb70-4f8d-b301-f6bfe237bf63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4df075b6-452d-4ba6-b382-d77255f2c45c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e302ad0-50b2-42fc-bd02-3b3b07703018"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e3ea5db-0fe1-48ca-b34b-2c58cc9cde88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e429f3b-6ae2-4cdd-98c4-adf699bdd38d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ee74118-e825-4903-993d-bcd9d03f410c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4efb44d0-2812-4ac4-bbb5-3b77219b82e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f13abd3-e5ab-4fed-809f-4543e62681b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f29b3ce-8f24-47a8-b0c6-9090343e2114"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f51bed1-82bb-49ee-ae7c-71cf6799856b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f83a5c9-83a7-427c-97b3-f24844d9a7c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4fc8208b-0b45-47b9-9011-741e5fe0ffe0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4fd073db-f492-46b7-bbdb-89b6d04d9abf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5005ca14-05b5-443f-a9cd-26a4b5faaeb5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("502089cc-1877-4f3b-bbd8-72c8d54abef3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("504b916d-beb6-43b6-8c5d-59a6e2f45826"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50db13a0-065c-4529-8e3a-5f582709fe7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50ed4bfd-e91c-44dd-8f6d-c8d15c7a655b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("515ef332-62a3-47f4-b5bf-6d2072d5943b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5173311b-33c3-4402-a1cd-c30814fcf5bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52a4aff0-8e34-4033-b277-f3f2b30e90e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5371ff8d-4c70-4f6d-87e6-1cb3e12c374d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53a6aeb3-226c-4caa-abc1-a13c6f019b91"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54028ebc-3578-4edb-9f2f-25f5f8972b32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("549f800a-69c6-4e37-b3e4-b8be7966f6f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54b8b00f-0bac-405c-bcfc-be9fe2c58a25"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54c95441-5104-4fb2-a6e8-ff456cdc7580"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55c5c40f-3452-4d95-9f02-89eab06280cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56129cc9-54d9-4758-bf16-839295e334f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("562ccf18-66c7-4af0-bb57-f19215a59fda"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5632f648-b905-47e9-868f-271e48c79ee8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56906404-071d-4b13-b2f9-2e41941b1a0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56e4788e-1b9e-484b-acdd-b1e7a1217d62"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("576a6707-8c87-4924-8236-2d753ffa6e42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57d5f0ad-98f8-4882-8547-12fd1df30b4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("584750c1-bdc8-4bfb-b3b6-31e969ffb777"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58580873-af50-439d-af1f-274f93b6337b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58ada7df-8196-4beb-bab9-ec7d71605d18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58ce734a-aca4-4834-8bb2-058ef7e03802"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58f96cf8-db4e-4101-9e1b-ab7a5a48b9d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("591126da-b590-48db-b405-79ee3168f525"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59322eb3-e7ab-49ba-b2ab-d05c7b513752"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59a8bd07-2ae3-465f-a150-e21229bd7312"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59e57a58-21aa-474a-b0a2-0bde2052df06"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a0db482-4ba8-4c3b-b65b-1ccba5c5565c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a57bd39-f342-4c98-a435-63b8d27bbbeb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a699c08-2583-4179-aa10-519889de63cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5add74ae-e899-4f49-a010-d8c29b851b71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b9b5f76-df25-44f0-9383-b2ac55060746"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5bd3f834-ed1f-4bee-a087-9cf7264918f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5bdb2051-b33d-4328-b3ca-23f2c16b3d23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c0db80f-7c84-46a0-81bf-7984d102041f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c2f6ee0-4967-4f75-88e3-34c4c4e84055"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c6b5ed2-7f7c-45c1-bbfc-34d1d475536a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5cc8329f-b4d3-4f01-a154-ffcd3cc9710c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d6b28c3-e565-47cc-bd53-392c7d69551a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dbd0850-3c29-42fa-8b4b-4effda7161d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dcd5443-5e62-43dd-a1f7-c8dddddeb4ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dd27688-bfbf-4921-9b43-2dd2ab4351b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e0b5239-4021-41da-909d-94ddb768d320"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e244623-1bdd-4bdb-9475-6d2a728154cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e9c33f8-d72d-4204-b102-fed97b439c1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f39eae4-93ab-4568-84ac-d77a57fd4b07"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f51abcb-410b-44d6-8896-0f5ac8976478"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f5fed2d-f935-44f1-870b-1e096f03a6aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6028285b-071c-4264-ae90-b31b7145537c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6030e32d-61d2-4d46-bd2a-a28c131eec6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60364dcc-b369-4407-8a0a-8725dca99165"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("603f95b7-50e4-492f-a636-710f1892726d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("604737fb-b776-48cc-91df-bb35cdc25935"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("604f8f9a-1925-4531-8b96-c1c8b20f3a43"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("609636b7-c98a-4bef-8448-0b8987fbc691"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60980126-0b28-4ea7-8f5a-8ce5c4c411ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6130e156-5a29-4a59-a805-b1a7a34a52d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61435390-9588-4648-9116-95a9326ff8ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("616c2f17-c682-40d0-97e7-641109ea2d56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61a1f31c-76c8-4ec3-ac11-a4ffec1268b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61d5a4d4-62d0-4763-9f4d-53f872be4a84"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61e20025-0271-4260-82ea-973bc9ec6633"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6230d2dc-2296-40ab-977b-e66b04056281"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62af08ee-13f7-4b57-97d2-fa5bcdc5b740"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6325a82c-f6aa-4a50-bdb3-6b83ce1296b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63326a0d-aa43-456b-a617-f27bd30673d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("634d813f-45c8-4878-894b-fc412e97b793"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6395bdce-3975-45e9-b8fb-244f5f3ea60e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6395d715-24e5-404e-8f58-259489b8c910"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6399dc68-5797-444b-aa31-73e147fe48d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63b2cbac-7538-4ed5-946d-e8f199e84b8d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63d28839-dc97-486e-8c5a-5964de62f948"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("640585fd-d2b6-462d-9c42-e1e185415dfc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6454b6e9-6a86-40e1-9eb8-38857a779a3b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64929f42-753d-4148-a451-663b321709c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("649f94a5-0c24-455f-a970-b6d7d8c1ca21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("650c2032-e38c-475c-b27c-03d8b3737bed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65440520-4e4f-4854-9a2e-6eab566def42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("664d38e6-a802-4db6-8363-aac5bbf521d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("667ee860-4aa4-4427-a6d7-e7d8ab3f7b2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66bfb52b-307e-4650-9b60-b9dbe51c8f63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67400521-c559-4b1d-b1ff-3ff42a9a2452"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6746dc83-7ce1-40b8-b592-e12843899b8f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("676ddd9c-0bee-49fb-943d-d31622b11e24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("678b8377-902a-43c7-9ff4-8e6021b65695"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6790910c-8390-4e84-8376-79a3a8d00bd2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68803d91-8a59-4154-b09e-fa8b58a3a3ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68b8304c-8480-43e2-b48b-b09ab69aa257"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68d03fa2-c545-4076-b2bf-5bcf38f4c8b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("69a10e27-f19d-4f91-bccf-48ac48fe0930"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("69d9b21e-7f3e-44bc-882b-48ef6d25e14d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a7cac36-cfd0-4f34-8d44-2d68aa9f46d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a93e7b9-7d1e-4eaa-a04d-8666816db076"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ab27d9d-3784-40b2-b7ec-044100ec148e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b228c99-7e70-4d30-83a0-d0ee01c8f8ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6bb6bf85-04a3-4c24-b328-de0f8925463f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6be79377-47f1-4f75-b9e2-01f3629e9f16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c385f3f-7d43-48f7-8ee2-731fb04b4398"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c59dbc3-7c7f-4fb6-a136-1eb82a4952f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c65f6cb-1774-41a4-bfc0-d6403ff38271"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cb509bc-a1f6-4bdb-9c63-b191ca6071b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cfc267e-f31e-4b08-bd5a-c70464002210"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e31befd-d67d-46b8-b357-1fae70692f59"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e7a24fc-e085-48ac-8b8d-98d71d4033f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e8fc5f7-0e88-4014-85e5-4ca853079081"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f982242-740e-4778-8165-5c1c830046e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6fb367a5-b16e-4d23-bb13-a95f1cee186c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("700419fc-4063-4793-9547-329fa7adea58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("703343aa-a9a4-4c4c-a7c2-1b9a34dedc46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7095206d-a804-4826-a498-3b1d5f93381e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70ad5372-522c-4f05-bf72-48d68584d424"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("717f9ef9-a7ae-45d3-882e-1c775f52bfbf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("718112d5-9b7f-4951-9168-836d0e41c57f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71d0f771-23f0-436b-a647-d739847181d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71d8b00d-da8f-4c4c-9db6-5dd1dcf8c682"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71dd3927-6aba-46a1-a717-9085fb45859e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("724fcdea-7ec1-4621-833e-8d9487c7174b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72a7dca6-004c-4e3a-9fc1-a09f36680a88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72ab5a97-04ae-4e59-9edd-561b63a70d81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72b88fe7-2512-45eb-ad9c-a18719fb3da4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72c2c4a5-907f-4d3f-bf28-2107b0553f84"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72f77e10-d778-4a7e-a21b-b3bcc2856f5f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73274908-46be-41ae-8eb0-5e107073fb3b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("732cf8c4-1556-4a2b-9deb-b9f50d465951"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("739dd993-946d-40ff-86f6-d6d9d84f87c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74003c06-b25d-450a-83be-fb04875a7e66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("743ef19c-cba3-448f-8d91-c23ea967fd86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75424257-9e35-4c7a-af21-4787387c43ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("760af21e-e1b7-48ca-b9a6-f5347e2ab60f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("76181a95-2f95-4c62-b292-261cbd6c3f2d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("76d648db-a880-47ca-8712-45528d841d6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77b86e5c-8f27-4198-9db4-834d38e4a2a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("780b5c26-1e25-43aa-bb41-cfa2e7ff330f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("783e4576-22f2-4bb3-ad35-b37701050748"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("785a4815-274f-4585-a461-ad1ccd7d00e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78d7dc2b-f30b-4c88-949c-53873e0e7ced"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7922a698-944f-4bdd-83b9-51d28604497e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("797ff233-0797-40e0-80e6-3b70fd2e8b24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7991deb6-4d5b-47bc-9070-cef29e870b86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79d23630-e4d2-4c72-80c3-37316ad64781"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79fdba3d-9e9b-45be-ab87-68e38820ab71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a944380-f75c-4d66-8c08-78d2a7bb3ecf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ae2d1e2-c71c-45be-bffa-d480351b50db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bee9763-5b15-40a2-94ee-e17a5f2e9461"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c0196c8-b311-477c-a590-86be998b4495"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c102535-63d0-41ec-8fb9-c389cef055ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c10e442-af5b-49af-9f47-da619df7072e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c7a0901-927b-4249-9236-621a5aa2f2be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7cd72197-19c8-49d0-a04b-bea70ad03e48"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7cecf3a5-4238-4a85-b1ec-601db7346649"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7cf75189-2ea8-4027-9d4d-8b8078ff3d25"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d542560-1617-45b9-a8f0-26bb1b189bd6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7dac20d1-168c-489b-9a17-a3f0adf2178b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7df03786-e4a8-42e7-a667-3054384789cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e0ca861-628a-4613-87ec-1896d6847b82"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e36e2db-aec1-4f69-b10e-3d088ca03049"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e4760b8-4bf6-4a15-a9c3-fe39ce1ba939"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e619bad-1507-404d-a393-f453ddb9259a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e90f1ea-a0ec-4ae1-a4dd-d359ce52648c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e9f85f6-091b-47e0-81f5-9f006fe6616a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ea4b102-036c-4114-a06b-f28efa00703a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ed0147f-7f8f-4806-a14b-d09086d5eeaa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ee39cb3-736c-4a4e-a6c6-ad3878b7a164"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f0880bc-cfb0-4411-b506-6b99c0841baf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f0ccf5d-232e-4878-be79-f08c4986cd53"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f2ed789-74b0-4f35-9564-50cb5af467ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f634be3-cccf-4ae1-ad31-04e4e467004c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f8864df-848c-4bc1-bca2-28bc6596e1ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f9ec0d8-307f-4610-9fc2-05c64a8480f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80324724-f269-4c68-a328-c92d77b3aaac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80e68fcd-48ff-45db-afaa-19b3836ce643"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81514788-a236-4e67-bbb6-a3a3b9b87a89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81538973-c1dc-4198-aa3c-541dd67f688e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81b6f132-f599-491e-90e9-5192bdb26b5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81e26087-7bec-40a1-a610-d3268118fd0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("823d00a8-e902-41c2-b509-a68422c1893d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("825b518b-9aaf-440b-8b7f-3883d3bb6f7b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82a0b50f-90e9-44fd-a0f5-f7c95886abea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82bb1d6f-7fe9-4efd-a3d0-6b2e045b534d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82bcbc1b-3a34-42ac-9432-486dc1a2f281"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82c007ae-781a-4ca4-833d-7615c90c0f36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83213820-bd76-4177-9887-2a70e2402611"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("834a5505-7f74-48d3-8584-89fe0a48e83c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83792d14-3f84-4be0-98c2-8879840418d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83f4a314-64e7-4d83-a539-03a395393e20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8447000a-2649-42c6-8d19-d5c485eace7b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("846a00c0-a9e3-4483-a0c4-6be19b3cff90"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("848e5945-edcf-40a1-88c4-ff9fd3e2921e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84cc496a-4ea4-4359-841d-08af33bbe11f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84ce22f9-352f-4af6-80a5-94c08cab06e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84d609fe-9144-43b3-9f57-beb1aed989a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("852c4b35-9692-4404-996b-05fe7c0b11a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("859cc448-58a4-47eb-be2b-eb1a35010bbc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85ba8ae1-f233-4771-a25a-86379536d7df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85d877fa-eba0-4226-92bd-437a64ac8fb2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("861a13dd-fb72-4b64-a080-165bf3c7bb06"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86330b0b-6b57-4026-a02a-f150a0d1118d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("864ecda2-34c9-48df-8118-c6332a3e2bab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86594947-38e7-41fc-b949-34970277a0a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86618371-f0b8-4bff-b8c4-4045b2c92e10"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86e84f7e-3bc1-4f02-95be-cbde7ba0f099"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86f4c0e1-92ee-41c4-af68-4798194371c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("876a7a52-c918-43f4-b63c-950014d74f58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87be9db0-8495-44f7-864d-8bf8d7158190"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87f7cbdf-6bc4-4d3b-ab26-f73250907ab9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87ff090f-0c16-4faa-b32f-d908c92cc05c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("882a102b-15bb-4428-bbde-e7acbbac9c10"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88377d93-d5ff-4f96-b145-361397faefe1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88949ab0-6c47-4065-b828-9a0e0d889120"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88eb32b6-c123-4b7f-b996-c8a2c1431930"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("890c6290-4a82-4faf-a6ad-e25af513b236"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8934a65a-2a91-41e7-b441-9c27a384aca6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("898d2553-625e-454e-bf53-a2314bd74ae7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89f8d608-6af9-4406-97aa-dc1b34fb73be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a461793-e58b-40c3-be7b-8fddd41e7cbe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a4e74fb-c246-478a-b53d-b197e6326804"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a535daa-d687-446d-ae8a-e5332896606d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b7d8e23-531a-4294-befa-763fd92413f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b9a2141-f8a4-4489-a4f8-c7fee34a14c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b9c6b2d-c6f3-43df-a6e1-67b836bcbbc9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8be58c70-5f3a-4024-8eb7-f40f403d83cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8c44ac96-d0c4-418a-89fd-158b67c18653"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8c8aa84f-350b-4126-a788-76fe800a8a76"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8cf4bfa7-87ab-4811-b460-cee2b75be748"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d16b42d-5bb7-4722-b44e-f8f5448691f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d474c3c-d6ed-4c94-a992-da33a99806f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d6b6c9d-5b19-41ba-9220-842d60fc5a61"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8dcad9f4-aa5f-4a0a-9a78-6f1058557cae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8de6ebb9-e551-44ae-b9f9-e39db202c5f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8df9791d-600d-4885-ae26-d6530d61d315"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e3ef8d3-814c-4c5c-a9e6-3c76b0be89c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ec027fc-4889-4f41-8201-b0c0d36fa5ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ee690eb-2b4e-43b8-a7cd-c2f80c7a04cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f10c0b6-6004-4546-be02-4135fb3612c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f61f553-fe92-4785-a07f-bca2ef97b08d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f7297e1-b3a6-498d-9796-7419560eee81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8fb47c9d-5167-4b8c-80be-159c3078cf2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("900617f8-07f6-4e24-affd-898325da021a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9042b761-2286-432e-8536-36efafff90ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("908fe90e-c640-4934-99c5-b26083a11c15"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90df3905-efbe-4848-9efe-652ea7e85893"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("915ddeb8-2abf-4dd7-a9ca-8b486d19e778"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("919b9bdf-a1e0-44d5-a912-bbdab213870f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("919e428e-4e33-494b-a55e-21a2f28bbf6a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91e4b925-c0ee-45a3-9c44-210c60bed849"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9204b00f-616c-4171-b272-dc8a1a8ac580"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("923d091e-ba88-4228-8c1e-6d6d95f469ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92820b5f-7749-47fb-ba0a-fbd0d4821581"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92c0b9c5-bfbf-4e14-93c2-915ce0c3268c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92cab8b3-0531-4493-b679-28c8faa2afc2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("934996ab-e01e-4e37-91c9-8845aecb5a17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("934faa06-dcd1-4f10-8d40-30777f8cbdc8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9437f769-8518-4d94-89f2-2f4d75cbb5f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94498c7e-aff8-491c-8409-52228efba341"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94af1a2c-4e63-4e16-a7b4-970f68c0009f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94d6c14a-9335-415b-bb6b-0ff721bfcbd7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95e729b9-beaf-4111-90d5-c40b656daa0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96d9adf0-df00-4010-92af-77ccb07a3b66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96ed1edc-c193-40d8-b293-3b2fdeac0a4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9706f7d4-1f1b-4edd-ba44-6badc7ff61d7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("971aeb60-dfb3-40fc-a116-4606b5c7da08"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("973e1c3c-692f-4b6c-8763-fc5d33aa3f21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("978dd448-0a14-4026-a89a-10d0785b618d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97c7a823-33d5-4bc2-ad4c-94587c77caa5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("988e787b-863e-4f15-808f-e4dbab214add"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98a0237b-d18b-4830-b2aa-342da4dc947a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("995d49d9-2b7e-43fe-a38e-8b4530aadc78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("998cca08-ed82-4db5-8ad3-2f0b99bdaf2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9990ce18-0f19-46c1-b205-ee33b04aa2e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9998024e-683f-4cb7-ae0b-3fc9084f8f1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99b0d929-dc58-4431-b8ef-497c1d1e2e46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a246396-f085-4f4a-9fb1-0e6aa146ddaa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9abcccdf-0709-4b10-b7f1-84ec47abd735"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ad65253-8a04-43a6-a560-9f76d6975eab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9bbf3444-43ae-45c2-a82b-a05a9c903530"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c5d130a-f725-4337-aeda-21c354e260fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cac1bef-2dfe-4244-8708-5d02cb8e8875"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ce41664-39f4-48de-adfd-e4ca39be8cae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ce48dd6-79ac-4975-a681-74f0ddc79f7b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d5b3c57-3728-4b2c-a871-266a02484155"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d66378d-1f5e-465d-9447-bf8fbb326e60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9da83da8-5ebb-4e51-b77a-02e5211ff071"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9dceb375-709b-4d55-aaaa-d8bf703f5661"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e2ae6d9-ab20-4b28-a991-677b4ada93ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e4a6759-96bf-4fc8-b857-1bf5d811c2b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e604ce1-8675-448f-be0f-5ce55f1103be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e9739ab-181d-4b7d-8031-1c6b5475909b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f21b623-4aa4-48af-877d-d0fbb4517e49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f49469d-5e0c-4a49-b4d4-0b5d567fd7e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f5a4cf1-d2f3-4d50-a53a-81c877c2900b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f742889-ddf4-4f14-9f9a-b9a6313024de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9fa3576f-ce27-41b3-ac18-0ffc0dd2f11f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9fa6ba94-0dcb-4550-8c8b-a3f8a7ee8358"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9fec2aea-7bee-4d32-aa8d-1d6a0e70980b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a09c2b22-020b-4656-b053-fb5389e239da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a0a1246c-2bb0-4d00-b676-14050db08a23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a0d96aab-826b-41dd-aa57-9ea57293a870"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a143fa26-0fdb-4797-a543-b52cd0b2134c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a14dcc2d-5776-442c-b910-6880a166ba7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1645582-acf9-44e1-9c16-20a3a415282b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1664f5f-6c06-4ba6-ac1b-bc69cb304c62"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a16e710b-2b87-4a5a-b45b-aefcfeb4cf62"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a21372e7-7e0e-4497-9b79-372c87c263b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2aaf27c-fab3-4a5c-94fb-254d88c3d876"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2b30761-8ff7-4ee9-b574-ffd100465f74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a316a760-b9bf-4b85-a733-c97eba77105e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a31a7006-ee24-4588-b955-c99e5b2b5a6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a33388f5-a40f-47b4-8e20-f5a6c28e4427"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a380a042-5542-4fba-9b30-3e570d415b00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a39117bc-4254-46e8-8542-379c6c55a93d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3bbea74-e7bd-4d86-888f-91f383f57be9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a41d5cc1-4ec3-419d-9ba3-23cad8e088ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a45702c3-9f3f-4bd0-95e1-f7219c717aaa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4e02f70-9541-49a9-8cfd-49cff253f7cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a501fb8d-b66c-45dc-8b18-4a8068ae911a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5d4589b-f332-4616-ac3c-141c8caf62ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5d842ab-e9de-4efd-be4c-5dd34b472dfe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5f26a63-bf39-491c-bc98-790703938a61"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a61cc610-099d-4054-94a5-96483898c789"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a656008a-cd31-4574-b8da-678cdc08f2a9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6937fe2-8a04-4bb3-a4bb-8f19e35f6467"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6a67df5-2869-4288-9b58-7a1fcce9095f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a756f20d-2c32-45c3-a4e4-a1b80b650114"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7643c8a-23f8-4b7a-8e0e-4d02b48a2cf2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7a238fc-7593-4a07-9cdc-b6df6075855b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7a664b9-07bb-4cc2-b67a-316d89a8ea71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7a6de35-4d9c-4cf2-9278-efdb4aac3582"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7b155e5-ee7e-4260-be33-eb419806767b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9082b52-1c12-4197-a8ac-3ecdd9a6aa0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a98c5f20-971a-4b80-81a5-1a2a8a9e7bb1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9d4b723-89da-4eb2-8f19-6a1a9d6f75e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa65d08c-b2d7-4666-b3ee-11a41ec5145a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aab09924-903f-4a66-bd35-dab3c631275d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab133238-4a47-4189-91e6-23adf52d56d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab91029e-f987-475d-b4a0-478710b06b2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abd306f0-15a9-41a9-b745-ae65cd0ebe17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac72796d-5262-43a5-9577-2d8ec1e91fd5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("acde899c-9ada-4645-8d96-ef30c2dab8c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad309792-823c-45a7-b81a-f7c8ba211100"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad38ed24-8f7e-404b-98db-b8ae43243859"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad5419c2-4678-45a4-8b64-8cbf7ff93171"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad76c4ce-bb95-4b18-a63b-3af34460fc46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3a27-43cd-4cd5-b22b-972f5680d70b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("adeb93e3-1150-4028-b3b9-4799bbebd61e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("af2a12c3-758f-4497-a349-0c82d299a2fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("af624a20-d9fc-47be-91c3-0bb67823abd9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("af9b88c9-5e87-46f7-ab05-01af766037b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("afa45f9b-cb8c-478c-82c8-de1a6400d955"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("afb8279d-346e-4b82-9a3c-cc475ae3b46f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("affab8df-8e12-43f3-a270-aad3f4baf300"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b12217f8-b63f-4326-be23-aae77507278f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1b87eee-b7f6-48d1-bc91-2be9289dffcd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b231ed43-c5a5-4928-816b-adb0720d5bd2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b23d2a41-7860-45e9-81d6-48db9fa436da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b32c629f-473a-4f7a-8e7d-5ed85dc90015"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b374aeb2-b400-4dc1-8937-05a626009ac2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3792c41-070a-491c-836b-1c09b9611aa5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b388044f-092e-447e-8a19-ac7379c3456b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3d675a6-6dc1-4395-be68-85f4e2e38af1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3dc3911-6222-4377-8eb4-106c72bb770f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b41ee90d-f0d6-4e1b-9ed1-0eb20101903c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4333f5c-bb47-4409-9e97-743da08582e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b43a075a-1969-49cd-a47f-1e2248562e23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4713fa2-1e6a-43ad-91c0-61cf64b4d843"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b49160c3-4ef8-440e-aaa2-dfed1627499a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b52813a8-d9c7-4fe5-9e28-db26291d080a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56018ed-ba8d-4433-8b76-0c24f4bc6855"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b57a1da2-4f49-4bb2-bae5-59302efe4ded"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5b5ad4b-5d98-492f-a5f4-76e75849966c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b66c18fc-bda9-4106-aea4-0f325ba4ae61"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6734fc2-c1f0-4c37-b7a7-5bac91334b5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6d2b439-f628-479e-83de-ce0eb6b77f91"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6dc40bb-82b4-4e40-8586-ffe3100b907a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b70c2b2e-3af0-480a-9cac-35f8a15e1346"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b724435f-4e50-4db7-a937-7c5c3b40bd87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7a8cc09-2986-4266-a317-329350c05f86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7db072a-7545-490c-8a1f-b9d27bca8e86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b84dccc9-00b1-4089-b185-44591faf5d6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b86f396e-5ca1-41ed-a77e-b37159030516"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8863055-d3d2-4eb0-9ecd-4a01afd0898a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b888dba3-9ddf-4de2-bb00-484b2b89141e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b892c32f-500e-4625-ac92-ce5f960fa8cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8ac5b67-c3bc-49ef-bab9-85672cadde5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b965bf66-b7c0-4d72-91b6-2772a1688231"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b97936f2-17e3-4726-a00a-5f2f9c8e8b11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba65c602-9dc5-49de-86c2-3d7164f9f0f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb0936b6-acb3-4d2d-960c-84d29ad8d6b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb3db94d-537c-4699-bba5-b866c1ad6b4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb445d63-ffaf-4e35-b326-50ab12850f89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb976424-eedd-43aa-9740-893da3c397a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbbf0cf0-c37f-455e-a5d3-1c53837bee45"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc1e09b3-e2c7-418d-a6ba-3ac3382cb761"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc31fc32-77cb-45c1-9178-9628b7c258ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc8057af-58f0-4fa4-9321-ee6ea3f35405"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc829f3b-08ff-416b-ab0a-84f730e59029"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bcaa5f9a-c367-4643-9836-92d0cb317d2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bda171ac-402e-43be-a5fb-658602695899"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be784d97-0003-44a3-ac44-920359caa868"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be88bee6-9c64-4aa7-9099-9429547abfed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8d2b3e-db08-4b12-9a61-03d827f0d3c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bef7f0da-af62-4b31-a057-72f5e9b8e0ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf673a9f-3cd3-4936-96b7-814210c6d03f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf8edf67-2198-4276-9fe0-f18611d67822"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bfb04f41-6610-40e5-ae80-8df6d526a6ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bfc38717-52cf-4570-8ac7-dd55625267b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bfcf4532-6a47-4aba-9f41-d1fd44846134"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c076b871-6fe1-488e-b8b3-46c89ec36c93"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0cff1b5-062a-46cd-97e4-16d3b85a1cba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0d7dfc3-57cc-41ac-abcb-1db0de8092d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0ee28b2-747f-409a-8ba2-3273c863b141"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c166df4a-3185-4090-a73c-42a7fa3a4707"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1ea65d9-a76d-40a6-9054-01b79ecf1c94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c24936b6-8e6c-499a-aeba-c9a4a65c4d84"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2edba75-e02c-42a7-aff6-3cc77e5c592e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c38d1ae4-1301-4ee3-b5bd-676fdc9bf7f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3a48ed0-7fbc-4602-894d-8ac05affc284"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3c9e247-090c-4916-8cc2-eca2b829ec52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3d65062-dd43-47af-bc6d-599a8302a4ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3d9da1f-219b-4fb6-9664-8b47989e0394"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3fcfdab-58b1-4724-8fc2-22731788ef6f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4012fab-48d6-4b3b-a3d6-74b091d51e87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c456852e-3cc4-4234-92a5-0770fed4a358"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c47ed88f-e19a-4a70-8705-6a6af6f5a218"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4b8148e-8184-45b3-85c0-a94421932c24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4cfb3b2-edb8-4d15-8870-88b3f501917c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4f6d098-fca9-40bf-85af-ad1cc2612b8c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c50c3a58-cf9f-42de-a6eb-15f60660a323"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c594391d-bb73-4a4c-baa6-f564e9d14a8d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5e29e9b-43cd-4cdd-a45b-d7c7cb472c43"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5f6d105-4de3-4440-8477-acde924095d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c63046d6-24c9-4645-8944-a0c98422776e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6573a3f-ef55-408d-bfd5-9a05660df8d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c755d039-0c2e-45f7-a46e-9330724f4d8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c77a20c8-b395-4cc2-b4a8-604e4b783430"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c785c7bc-5430-4887-9e17-e0bea1a70b39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7b73873-3d86-4eee-bca8-946cf48fa103"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8317014-a878-4450-805b-a6b32a54000f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8bf3a42-1fcf-4cd0-85d8-75276536548e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c94fdc08-be33-4f42-af78-1ec4da8701fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9605e91-8cdb-462a-9da9-22ae2a695745"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c964c0f0-bc80-4b00-9001-890789dafc9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c97a7291-bd1a-410c-b78c-f62e3996d966"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9d0c584-055e-409b-bba1-d3f351e1d503"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9f75703-062a-49f3-a8b4-0eeb30e7671e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca0be6ba-945a-463a-be35-eb090d668b4c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca896776-646c-458a-a163-f92ed25c0137"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("caa3ebc6-62cb-4dca-9244-884091aafcb4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cac7b63e-ea50-4fb8-9dfd-a7f7ea477811"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb702cc7-2c07-4656-91c1-62faffa66614"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb83465a-27c7-4072-8102-d5b2b8ec89d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb8ac5a8-8fa3-490e-96fb-28baaf19b7c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cbf3c987-6ac8-4d4b-b1f6-5a905742e620"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cbf97ea0-2da3-4178-978a-a45b58ec76a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc2326c4-0e6b-4e7e-8f66-4e4ad54027a9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc69e1b4-3317-4186-8903-903d9eb956cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cce8ec01-8584-46df-ae2b-c5ac66d2eefc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd26ad58-ac37-4e8a-9828-f13ca1248d64"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd96678b-4459-4cd9-a751-60adbfaf5bcb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdb1a0d5-a9b1-4cd2-96e7-b12d348c392c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdd48aab-d91f-45f2-adad-4f3f8a7709f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce235138-46ac-4c13-9064-a77249c2978b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce292f39-80b9-4360-95a7-ce1420babb3d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce45f2bc-96a4-4974-8945-2794f048d1b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce55342b-601a-4d02-b09b-f87f6e79af23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ced82212-bc8f-4f00-9eda-732ed7f6883a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cee1262d-8a03-48fe-8108-212b041d1df0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cef3694e-377d-40fc-bb16-743889762ff3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cfbd7c75-3bcc-405f-9ff4-2dea686e84d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d10fbd6b-ed26-4f29-a9c5-cebdb7afdccd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1120b5a-450f-4c80-9d11-e7b4dee15116"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d12e461b-8387-4cf7-a192-0a227bf340c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1b70a46-dc56-40fb-8f40-e65ea0bad5c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1bbf91d-aa79-43c8-869f-75970b79aff8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1f44282-3612-4127-a0e5-8bb11e8f7715"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1f84493-ffd5-477c-ade4-cc10fb2fcaa6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d26b513b-d416-4afb-be55-5720869d6f75"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d286c373-b2b5-4da0-9e83-e90137bc2801"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d328469a-201a-4d2e-8097-4b7eed4ce491"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d32f4473-cec0-434f-b822-0aa2dd3043ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3755146-63f2-4907-a7cd-da1b28a56ca7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3d9934e-b445-43cd-b953-ac23c5adeecb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d46f3aa9-beaa-46e1-a783-39b771389dc6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d4779b5b-4b8c-4927-9daa-c907e89ddb20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d48ad3d0-c31c-4228-a65a-419b9e1ae5f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d57e2b38-d636-4a73-b1d4-8168ec76f4a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5a7ea55-1780-45e4-90a1-bed2486db816"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5b23b98-e728-4872-bc2f-1fd4400aff66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5b5c338-0e1d-4fdd-8092-09ea26bca626"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5e637a9-beb6-45ce-ba54-128e14a76c58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d610e0e8-53ba-487f-bbfb-88727467cb0b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d611e5b2-e3de-4c8e-b40b-c6503d6d133f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d62e48cf-a249-41b2-8428-3152ae5e4309"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d63d7615-a819-4b30-8386-da47088beb0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d64bc9fc-f221-4039-8709-6c4272c19f3d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d66384e0-a994-44d7-a0a6-c2eb7be2936e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d672285d-a863-4288-84b8-c7e154632951"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d67300ec-7798-4e85-9442-172d932893fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d69cc864-6f79-4a00-ac43-93ad33ecdab8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6b63419-b255-45ab-bf4e-398e860f5afd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d73351ad-6cac-475e-a42d-da5beb1fa3a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d778851e-b021-4f12-884d-59e07e83cd57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7a65d74-2e64-4a3a-b299-587bb80ea1c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7c1613e-430c-49c8-96c5-580773e300d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7fc2408-500c-4063-b0a6-2bcc238c5376"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8b232f5-198a-4879-a0a4-ba14fb8bb9a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8c6bf05-a22d-48bf-98b9-666b1405ddab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8f9eb4d-66d6-4c40-98ac-3736c5a153b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d90b03d0-009d-4b3f-864c-11c7239cc8fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d958add6-bcb3-462c-b57b-14a0bad98978"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d987be92-4df0-4d5c-b407-16835913acaf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d988f4d9-2297-4b2f-a3ce-41cebafbc83d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d99648fc-8e38-48af-a117-401ffb0e5c6a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9afd20a-b229-4459-93f8-384717c8c157"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9b10d08-a8c2-45e8-9cba-5bb81031584d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9c256b4-e96f-4595-8e61-77a9fad91871"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da17bfda-aa97-4e1d-a324-60efbc3db302"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dac1a360-49e2-4187-afea-399027f249f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("daf7dea8-8c8e-4b07-9306-0d64074355d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db966eac-3339-4410-bd15-75caf6ff10e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dbd24e4d-5b8a-411a-8d2e-661d68295325"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc277b46-7070-4caf-9dc4-3bc8b87abaef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc465b68-08d9-4534-a766-698b3233527d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc5ef3ed-cd67-4352-945a-e03767774d34"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc8e8928-6225-4a90-9f77-af59ecc88940"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcc08567-6b43-4f7e-a6d0-f481e0ef3d99"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcd697eb-a9c0-4093-96ed-7b60ad1727a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dce68385-ab60-4a3c-93e4-92c2f08cbe43"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd0bcc43-52c9-4611-822f-6d4a1c66173a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de2810b2-270e-47fd-a323-fd4d9b2f90b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de629953-dc63-4735-8463-43a73cacc459"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de7e205b-4437-48b9-92b7-32105cb8e605"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dea3a580-85a2-4cc8-95e5-84983d72c5d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df2540d0-32e6-449a-975f-c2adf5f09bce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfd57cc6-9ed4-48a5-91f2-d63a77ac312e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e09067e4-1c90-4408-9c2c-8cf5a82664a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0d71f98-0d2d-4f53-964e-e69c4771899a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0f6f3a9-9e3e-4bbb-84e4-d7f1af4937a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1041a8b-1cde-475b-87de-5ca839eb0afb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1a85e38-befe-442a-aa19-36344fc87bb0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e237ec6c-bcf0-40c9-b4c8-99c18e5d5f6f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e246ff39-09a3-4937-aa24-ec05f29d8110"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e25bbaad-bb4c-42ed-a282-4d08301c51f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e264ee29-bc30-42a3-beee-4e2175028bbd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e27174f0-481d-4202-98d4-f687012f7a7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2bcdb18-18de-4622-96f8-270899ba4097"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e31362b5-9a9b-4d8e-be90-7aa98255cf82"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e323fdc1-0476-4ca9-91d5-06950b8701e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e36b16a7-5d71-415f-b6aa-92c6f9b98be6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3810fd7-41c3-4b87-bcf2-6f67824fe76c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3def886-d8ee-4115-807b-09601e1de955"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4713b93-57ba-4e64-ac2f-307126e3e180"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e478aa34-e0d2-4e08-ab58-bc4911d01172"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e47a6c42-aefe-4f02-baa9-4aa0c1c15901"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e48f1592-9994-4205-8c2d-4de4b921d6f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e52a1270-a9e8-41f8-a2b4-601bf67b8c74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5348f04-6a71-41a3-ad3f-ccacc27a7d15"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e564ef51-2397-4749-b6a7-b35e6e26c1dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5e31381-8af3-419d-8ba3-b0a56ae46803"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e657a8d4-e060-42c2-b850-9a1055ee8144"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e702b9c4-8a28-4b78-8b67-93a8f23d3c38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e70d7f91-3f63-4332-8f59-c2529c93b994"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7421c39-cd0d-4d43-8883-9a643a657979"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e79841b1-8621-4a39-84d2-e14d2b7ec2c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7e53de1-bd18-4825-8e4b-bfebfb2019e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7e8d082-3315-4fcf-9668-5143e690a5e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e82bb48a-e659-44e1-a256-9804167237cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e9049ba4-3c82-44c2-b908-2ffc4f6fd19f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e92cf7b6-4935-4713-8484-3f750a48a124"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e944cea7-9737-411a-8af0-fe9a30a04a8c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e955e95f-fe58-4c7b-85ab-5523c13590ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e9fd4f71-dc5c-4360-8042-50a82929b5a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea06fa33-6ff2-4731-a9d5-00b71dfe2406"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea07e62b-95f7-47bb-b153-64d375afde41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea1eb95d-1d1d-4cc9-9c8a-339e420bc171"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea3e17ad-b364-4e4a-b85a-92cfcafde195"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea9ee9f6-79de-4a77-9995-e70d178cee89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eaa42ca4-e1e2-4d86-92d3-e25da8127dda"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eada645c-b7c6-469b-ae13-be04f2844709"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb15e6d3-aca8-4e9d-901f-abdeea163e67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb4bd2d8-1b47-43f8-a907-e748a2712dc8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ebab16ea-14fb-4fec-a4a0-4e05522bb4a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ebb7c64d-9f2c-4914-92b3-8a0a3107a851"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ebc62485-5ba9-40b7-a1cd-aacde695c4a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ebf8e894-234a-46ba-b883-ff01f730df4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec0570c9-5fbc-44b9-86c8-c18a5eeeaf21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecbe9cc9-e582-4fcc-9b57-ebfa7ca4f5b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ece8a010-1167-4d5c-98f0-6f72a6c6d606"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed2e8f2f-50c7-4bb4-aa2d-9ad7496ea7a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed4678b9-ee77-42e2-b4bf-be0a80ea9108"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed9fe73e-9bbe-45a9-b95e-4228380a80a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("edcbd2ba-11fe-4280-920a-5069df71c421"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee300fc5-d8f8-4725-9928-5b83a410f598"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee934dda-c241-4e8f-8c93-c5d1d74fcf56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eea2f50b-bfc1-4a15-a0ac-8a073d42e3d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eed47821-16de-4157-9940-849b0d390030"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef227767-884e-44d4-83c8-45970a286e0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef56f1cd-5339-4a58-80e4-171910e5bf68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef7bea1e-8f7d-43fe-934b-5971dfa5a9b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efa79b4b-60ab-49d2-a3e9-af96b4882103"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efb43925-8ac3-42d2-93e5-7aec668da301"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efbfc6b2-5376-40ea-8a0a-30444fc9b81e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efc94a74-8850-4140-a1cf-ea72ff857ce4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efd7cec1-3a1b-4481-bf4e-8209471ce9e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efe1e5fe-9666-4ada-9d1e-1e1ecc896cff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eff769d3-4f65-4775-9ac9-1862d0524c6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0475760-576f-4e5c-b42d-b074a580d9ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0793e9e-0f8c-4ee3-aa17-8dc0d3e561b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f094e55c-0b4c-4e11-bd39-32f861d7bdd2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0b9080c-4b73-425c-853e-c916ba0afdcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0ea2ea6-3a8a-4b41-a5b7-4a2e01566411"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f13def83-7a5f-4b1c-8a71-543c760e0bcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f13f6944-58d5-4176-a765-fcefd14b944d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f16ccec4-8d72-44a7-ba1c-0ed3e117dbf8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1fd095a-3ae4-4467-a91f-c216404f9f0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2212013-2427-401d-803b-78d00bad0c81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f248d9f7-5dea-4662-bbb1-6db2d37a21c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f27709cf-6bda-4105-9802-eec43955a7a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f29363a8-a7c6-4856-9a5a-02c089f9deac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3032e27-cc91-438d-b7a3-3a8cbef31352"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f342b7e1-ea6c-4864-9686-859a85622f04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f374fdf7-f7d0-4d6f-ac8b-ac190983fbd9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f472c25d-0d2c-4b1d-bf19-521d0e3d245c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f48201c0-d48d-47ca-b18f-55b3bbb27a05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f48d44df-59d8-45cc-b862-5bb8e008ff7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f4fe4e01-9cc3-4a0d-9ecd-9797137fbba5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5c8b969-af29-4d56-ba3c-595c2ebe3829"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6815b65-4df1-4d3e-b0e8-d650d163d630"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6bd8d1c-2cdb-41bf-bb74-2c316101128c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6cc29f2-8e6e-4109-9cf0-99a8bf51b5e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6e10609-c140-4799-b437-0674f54b6413"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7252584-355e-48ae-a345-08a941c27be8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f72c3c71-7695-4999-8292-03fea1a4defc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f76aaa9a-aa62-4f80-a075-916b61a3dd89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7710b7c-59a8-4a1b-8ab0-86adecbd8985"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7cb98fc-4a26-47b1-9085-16b8d5269efb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f82591ff-0999-4943-b5db-47ff57991744"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f831c33d-41c9-41f7-a2a9-1f9ddac131fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8bc4fc2-5d90-4d81-92b8-b1e6fbbbfc2e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8c13b0e-33bd-4d95-a9dd-b04f7c3b2315"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8fac33c-f07e-4181-9695-36e4e5c88a77"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f91ad070-e83c-4399-ab5a-0ee81fd4e722"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f93a024e-d107-4c45-be65-7b8855f5e49f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9936fbb-bd69-4520-ba6f-5b530af44dcb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f997f622-5747-414c-84b4-c585a5162189"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f99a06a0-181f-4bed-ba96-7f3cb788127f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f99abaaf-79b8-4e8e-b19b-a77171369df7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa83eb01-1053-49b3-848a-12334f3db279"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fac1fbf2-aa8a-4db1-86b3-c51154c165db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fac78574-6a60-4260-bfcf-d7ecef1ba9e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fac8c176-3ed7-4b79-a999-c94711525c31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb0150e3-237c-4a39-97ea-c860cd02f4dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb34f127-0309-45cf-b61e-8e1cce8041e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb8e62ea-e339-48ea-b6dd-31ab6d8f6f71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbabf16d-00c4-4b7d-999b-61dc85aa28e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbafd372-6151-47ef-92db-f52ce555e1d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc0603a1-39fc-4cbe-8869-ad3230acaca1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc2291a2-62fe-4026-9696-393a4979815e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc2dddbd-f42e-4fe3-8e2a-90910e4bae45"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc301760-56d1-41a9-a433-cede095e39c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc513e5d-1bd2-43cc-a69e-477b42c8e2c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcfa8c4c-3e3b-4a56-8b51-db9c0b427565"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd0aa164-c93d-4207-a9f5-4d9a1044a2b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd454f1a-0a9b-4977-b248-28424cc9e7b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd5d8307-d24c-4fa0-9042-b5f8cd83e6f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd73032e-b029-460c-9b2d-d771651b2f74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdab3c05-bb7d-47c2-b450-2c5c4f7bf73c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdb88a76-07dc-45c2-9b2e-b9d15760d49a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdeab895-1ab7-4bcb-8431-90485e38109b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdf53a57-18bc-4770-be2f-192e33cdd7b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe05e9c8-5613-43c9-91e3-d199bc2ebd69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe7148a1-c3e7-4901-9971-10b62a38e56d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fecdfae0-07e7-46a2-bff2-6e6c0d86fa16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fed82d58-0b87-4c40-9ea0-01d08c8c0a5b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff0f8758-c1cb-4f23-9d4e-2b76b1538f9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff6557d6-e42d-41b1-b7c1-4eb0e2a60a3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fff3004a-dd76-4012-b4bc-98efbe5f83f3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2da7b79f-5d37-4fb6-8e02-f6df3db3ba71"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("76ef2da9-5234-40c2-b9ed-7cb169925f9d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2da7c582-8f86-4e10-91eb-c837cf2bd596"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6805a866-ce9f-4ab5-8e73-f920b3a67082"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0eff2c3-402f-4e46-b5e8-cca27e606d86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e68edaae-a9da-471c-ac84-a93bc1789963"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("002114b4-c1e4-43da-98f1-eb06c75f5799"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00431ce4-4daf-40d3-9eca-1105a33bf0a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00478e5c-68b2-4916-a4aa-ff2581f526b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("004e343f-9d3e-4020-b340-5ea99a02e5b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00879e06-1df4-4267-8b54-1ebe66e0c135"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00a78fa5-4e1b-4aa3-8adb-5fdabd8261f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01a5e2ad-057c-43e3-a4e5-dde9750560e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01aaf8cd-e312-4906-be85-0747477e773b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01f48d5e-cdcf-4718-ad3c-558d87f0c585"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02467224-4688-454f-9853-a27295a17298"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02a27160-33f9-4a68-9951-eaa4a8c9fdc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02c849b2-c38e-4a57-abf3-68e65a8f9b96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02f7f4e8-a236-4578-bde6-6a7f212c28b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02ffca5b-c67f-42e2-a74e-975e80ae607e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("032b8fbf-b6d1-41e0-b384-741b534d4c2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03674420-7d58-4133-b5a2-d29b437b2ec4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03bd136c-92f7-49f7-ba4a-ddf73ba6bb4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("047e3644-89cf-43fe-b58c-0c904967838c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04aee3f1-3b8a-403b-9421-a810808658f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05405f27-bdb9-4de4-8910-fa1f3592089a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("058711bd-25cd-470d-a81c-409044abec6d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("059655e5-526e-4a48-9f4f-57d1f5a716fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05d91953-ad75-4b76-b0f5-a5a042cdb3b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06141866-d4aa-4485-83cd-fe5bf15e60ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06272e5a-e86c-4a9d-ba0e-e48ef31ee531"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0657119d-83ec-4392-9e36-61f7b17c2313"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06911fd0-8665-4d56-8169-279ff19951fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("070f2f15-6dd6-47a1-8056-4da819ac9658"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07135373-1b87-4f39-9481-768b7cb4d293"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0729666c-506d-43cb-b5f6-5d8a02cbf3b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("073a99e6-46b6-4992-a02a-9fcc0a77c508"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07a1cb97-3831-4c84-804c-f376a7aa8040"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("080a4182-70fe-4a3e-9832-62f5400dc7bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("082c658f-fe33-49e0-823f-8750fb623d39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("082e32a2-0024-4488-b441-40bf49e9041b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("083ab58e-16c8-4cf1-a917-7fcbdfa4c1d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("086d168f-1538-4da7-8339-08010d438c40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("087e8805-7e77-4593-8c96-561fd9937072"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("088c6520-caec-4f45-b416-9d5ef944e529"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08c614a7-3791-4d59-ab92-9010a04b9ead"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08d504ed-5d05-4c15-83a1-866680949818"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08e6b4db-0231-438f-90c1-6928b4c204df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08f2a0e8-58ae-4201-af13-b4adf3728251"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("090b81e1-ff7b-4dba-aa35-087075eaca42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("092147d0-3036-4f0f-a5aa-db0136b62f43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("092469d3-728e-453e-ae5f-55fb6a0529e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0939fd1a-aff5-42bb-abf8-5e9d2fb13328"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0953721b-1c4d-4c2f-9e1c-f3923de464eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("095a373b-70e8-4f06-81e4-34002101c347"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09674623-0267-414a-b869-88e9e4f45696"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09d3b4c8-34ab-4c13-b797-949c0ee1d77b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a226d9d-80ef-43a9-8b8b-4611be49c21f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a2fc11d-6fee-4916-b898-eb6e44bcb3fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a3edcbd-8c85-4a08-87b8-593320cba51a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a421c5d-fabe-418a-b37e-3626f6967c7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a79c33b-4772-4fa4-ac75-1bf5d167ce58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0aa81648-dfd7-491e-b971-086d9c25cdea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ae8b5a4-e7ff-4a64-b44d-1af1b25a30af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b0caf77-23d4-4b1c-bdef-b2647516cf43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b0da880-32fe-4efc-b80d-81d3d63b8467"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c5c6b5b-c00b-4f87-aa93-dcca704d6f3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d34e3eb-ed70-47a5-b605-d700fba01b4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0da861bd-7a4e-4b0b-94cc-3eb38de02fc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e01bbda-fb15-4f2c-b1c7-c47f9b5acc63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e53ecf8-87a1-48cb-8c48-118d7f63e26d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ec75f74-d092-4d3a-af2a-9c466aff0d7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f16d058-43ef-4d90-80a3-f237bccb504e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0fca04ad-5c1f-48e4-a316-67c5c0d75826"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0fecd7a7-6822-4259-95cc-a996a8e50fdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1031274a-83cd-4015-acb1-2b2c5dd9598d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1077fc56-a24b-49ef-ba32-06da22b9f6e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("109abf02-74eb-4c6f-ac37-8e9fbaa40c42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10a06441-bce6-44be-b986-e464b7925c41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10a628bf-4bda-4cf6-be25-0e8777f4d233"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10d2ed09-5ba5-4a52-969a-b4b5c99008ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("116d96d4-a394-43ff-bb6a-bb461603f9e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11d03ab6-5c00-4bb6-b09f-133c372f54d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("123ce268-adb3-48e0-a75f-814fad2c47e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12428c5f-898f-4da7-b1b7-cd146cb6c492"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12aea1ec-0afb-4674-bdce-c93905f78f09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("131e84e6-baea-4d77-b73d-4ef2a57ddea6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("135d6060-5f51-444a-95a6-defe7daf2eb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13c3c0b9-a092-480e-ade8-a1596a549e1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13e12b17-c822-4761-803a-e8088b6cde53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13fffab3-90e3-4c9f-8610-675a15b8ead2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("140eb59f-2632-4e3f-9c7e-4892e077cb1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14ac8767-9875-4ae0-ab12-67ac06883c78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14bc97e1-badc-44c3-bdc2-f126cb8b4f0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14ffb6e4-9ce0-419c-95c6-a1daca3b52b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15017aa3-3ba1-48a0-9b9d-d3de7150fcbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15db69b5-12f3-4e92-8aea-1436d1cfad1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15df031e-294f-4142-af12-6913d12f0f7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("160f0c64-7cf9-4d67-897e-fad2cd42bc64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1667424a-bf48-4da9-958d-f71cc8831176"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17130254-b096-4235-8015-bcab1ba96638"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17a15202-fb67-4110-a0f9-a6b049ea614a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("187f80ff-3eba-47e5-8150-542e43230703"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18e11d76-a784-403e-af45-44eca16b750b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19d20d8e-eaee-405c-a4a9-de43fcdc3055"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19eb377e-2c59-4204-93a7-9f05ba9a346b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19fb928b-3815-4199-852f-f789d01c86de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a49f21b-f82f-4710-89ee-038cfa1bdf67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ab5051c-7f2a-483e-9742-8378026e3612"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1aeabd50-8cf8-4b8c-99f7-645b8ed9968a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b0d50e6-d2f4-49c3-9e4e-651e3652d277"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1beab055-1bed-41af-977e-e784c2457512"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c242e6c-4d06-439e-a299-8a9f970b7771"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c29c2d0-a2a9-434f-9f13-f583ae7e75f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c397d35-a901-462a-b923-626ae67eb5a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c3e3ea1-ec15-40ea-bc15-80e73d2f39d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c440193-0985-448a-b1ac-616108c59d81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c52b511-2e66-4147-89c1-db746e07782e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c9b613a-c30a-472f-9442-fce54324afcd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cf339e7-f810-4b88-a3bb-0a943d77d0f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d15dc89-c561-4d69-8686-41d2ceaf49a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d3104e4-544f-4bf2-820c-53f48965033d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d8388f6-e5df-4252-8c8a-ee379a64b724"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e14a6ab-8089-4972-91bf-4a5afab35646"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ee2a9a2-5694-4f4f-aa46-be176438dd5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eec0dca-d3cf-4f20-a96f-e07fe68718f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eefa927-625c-4848-88b8-972542f1b0ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f18ff75-b034-412d-8450-964ab98bfd94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f741433-7b7e-4e28-9da4-e8c2f817ede6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2001c1a5-1915-416e-ba09-d817e824097f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("208e428e-79e0-430f-95a4-42ee8eae9f76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20a77ab3-151b-4972-b2e6-8f2899bf68d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21056122-f969-475d-8c40-7cb1aefc2e30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("213e92a3-7175-4a36-9f9b-661f74342b6d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("217fb4c6-7ae0-4cc7-accd-8a5c4a0a971f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21c7586b-238f-4ac1-bdf5-c20cb99e0572"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21d55201-821b-4391-a5f5-1b205b3c44e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("223c553f-21d6-4f4a-a83a-b3391fdc3171"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22754150-e2d7-4e82-9ca5-e65451943b01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22beedb1-a364-433e-a3e4-b3be9078472d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("232f998e-d859-412c-b924-b6e29d24ffd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2350d483-90c5-485d-86fd-4ff21c2b811b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("236c2032-9911-4360-b064-9b1efb130bca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23d90c28-d721-4378-a65e-9284dab32464"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2408fe42-be0a-4a43-acd6-3f6dd922bbaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("242f4ce0-8f02-4d3c-a1f6-2f83810f64ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24578b37-47ea-4b92-a2f8-92ffe878caaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("246dd22f-9412-4371-82cb-1863238a2507"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24ebc46f-78d6-44de-abb1-19affbf909a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2513dcda-2cee-4d00-946c-c3c912ba1eba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("257c588f-1739-459a-a68b-b76cdd44fe15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("258e74a8-a7f9-403a-a7ab-8da5646765d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25902c90-31fd-4c76-b7b3-64dc3562f695"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25d0a21f-2ed2-41dd-aa42-5b4470217c90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("261b9ef9-1f7d-4def-90a6-21b00af1755b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("265af3ea-694d-4af9-8485-8c180cb78ac3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26c89fdc-9d4d-445a-abb0-8aa5f3d76f11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26f87bd0-3d17-4665-b8c1-362727c64a82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("270a9ccd-3a70-4213-b6a2-a9c794ea6f06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27338afa-807b-4aaf-9e1c-fd74fc3c02fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("275e387d-772f-4930-9d05-20083c04c47b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27a0df0b-0107-4159-9180-2da50a683f11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("283fe9fe-603f-43f8-a13e-a810b244848e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("285eedaa-3a2f-4648-aacf-fc01da52f8f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("297bcc1c-ad48-4812-88cc-967d50e349a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("298219b8-b89c-4379-b338-94b06d77aba1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a990b84-331e-4ec4-8543-78a75c7b3693"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ac9045e-5d18-4748-b32c-f46599e7a254"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2af07ab4-b85d-4c75-9cd9-23e1476c83ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b22d0e0-42cb-4f33-b88e-7e4a84194b5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b6f12ee-1f5d-44f5-aeac-49f2c8d3f751"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bb9cc1c-c407-4610-94b0-f173be078a9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bff3006-abe5-4c2f-8ba7-629ac1e61a63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c16cca1-d4d5-46be-b6a2-e85952f4ad08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c1bc529-a2f1-43f5-950b-6ccdaf768dc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c1f8aa9-5a0e-4101-a772-bddb52492aa6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c4d2f99-1723-4623-977c-58289258491e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cabe246-eb3f-4a55-9255-3f75a04f625f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cbf9735-88e5-4581-813e-9bcd11c3c659"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cc82b7a-ff81-4f6f-82e0-661add157499"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d13fe13-1984-4953-b4c4-02ec40e91da3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d4e8943-c9a8-47e8-b242-f837f2c7869f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d999923-f4b1-4e8a-a4a9-37795a4e6acb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2da53ab0-6dc2-48df-8e02-305752e01bea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e03bec9-c1f3-4dfa-9e86-2d9723cf8bba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e0624e0-dca3-44a3-9ded-f61bf28276bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e66c49f-e313-4336-9473-782464e725cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e717b8c-a24e-4a64-8676-385c56e8d75d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ebc2121-9b84-43ce-8cb7-e41eb9e51a4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f429729-2724-453e-b483-b59e74f90558"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f523302-1c50-4fce-a1bd-400fb7d21cf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f6ffef6-cc3b-4986-a1a5-35faaeecb5cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f8d9e9c-e502-4b50-8e24-affa3e1b711b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f984694-e5c2-438f-804a-1e7678dc3291"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2fb66daa-1ba4-4603-bc91-825a667e3bf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2fd0d533-250c-4cbb-8bae-deb6f977a82a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ffcb4f5-1c86-4d41-8132-b3070c92735f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3047dd36-fa52-4adf-9a49-03038fe9dbb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("304c9f87-63ea-4581-a0eb-a393c1977e26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30819fc5-0637-4a99-bbb2-38d1c5b3f9e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3092e137-9c90-4554-8365-d86246a20e42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30f0bd80-51ef-4bd7-829a-01932cc1e81d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31516d29-464e-40fa-8023-993684560ae0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3151ce8f-d3f8-4ecb-a922-052682d95900"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31654c89-5b0c-4c06-9756-c8783af5a066"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31693c10-ad26-4d41-8cc6-24d157f1fbda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31c587c2-96a0-4b05-9266-db86b18cee10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31faeeb3-c6d8-48aa-a228-f30abf465608"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32440d90-8f4f-4c4d-86d8-184e8bbf0c04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3269e442-43a1-4e07-8063-5baf9d8bf4de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("329c1598-c8b2-4aae-a37a-231d706fd052"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("330c08b2-1815-4dd1-b65e-fffe2ef061eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33220f75-6114-4183-b52d-68bd638dc07a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("332279ff-5e0d-47dd-b709-7444c46f2572"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33bd96c0-9ce7-4e53-95f5-59403eb08287"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33be8522-6f32-4db3-baef-04ad3c3f326e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33fa37f5-04a9-42d2-aed2-3e53fe1aadb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3422d3cc-b93f-4cf3-b350-3cc4cc6aa1bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34449341-e789-4a04-b5be-6f6820c1e235"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3491ef6c-e7b8-4ae0-bec2-3649371566bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34e561f9-3f80-479e-b588-36616b0ebdcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("354b2a73-2974-48b8-9f44-bedddba2800b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35a9ad48-f95b-43ee-aa8f-b8924397ae2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("361a95a3-5409-4be6-8f23-46d6c8cdbec8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("369ad0e1-f17c-4d0e-b32c-c20d11133375"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36f83d0f-4a4c-4fdd-8381-a4cfd0f62994"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("377c790b-2ed5-4185-adb1-164989500f63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("384e0125-d1c1-4b4e-a1fe-3b046105321e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("384e102b-2dc9-4227-9f1e-a41f731d2852"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("386840a2-55c1-4c1c-b84b-ec21fab684ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38782d37-0e71-48cb-9f1a-70eb8456146f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38f496f1-1fcd-4fdc-bf9f-0417ce750245"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39986407-5e9f-410e-8c28-8995d1f5cf10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39cd8407-d428-4ac8-ba48-3d533c6f9380"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39de9a90-7dd7-41c4-a515-f01438a049a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39fd9228-0613-4c67-a1f9-9e464d85634b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39fe2fd7-b30e-4bdb-98cf-50eb79006191"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a22a94b-2c68-4668-b655-1c5e564d6adb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a24b656-9d49-48e2-961d-50db72866401"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a32ee8c-18b5-4cf0-8179-7a491cefc39e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a368cdb-ac5a-469b-ac45-8de8d6f8e6e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a568441-5ad4-426a-a4fc-00c479359120"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a5d669f-8ccf-4354-981e-415cb605090b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a7011d9-9186-40f3-83c8-5924f73a37ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a85f1f7-dfc9-4e25-8fd9-e7ff6ef76e80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3aa4bbea-8f62-4216-b9c6-25b7430edb23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3af0122c-9b62-4a7e-864d-f5e4ba9fb9e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3af1da6b-d288-4d36-a9a7-84f014e5e2f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b93b084-e528-4561-a546-4aa3ccc182c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3caa51c2-dd4c-4ece-a042-e37c9c45c896"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d14c013-4337-4ffe-8913-5d3306e78141"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e14154a-51fc-480c-8fd0-e9634a48600b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e34fef1-4486-4ba8-bb4f-78d98434a2d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e9d2cae-f753-4cde-b0cc-593a10b5d570"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ed001a9-ca63-4001-9b61-445072616a1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f0dc2c0-3614-4065-8ed3-8a9a2aeb5221"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f1e7941-8534-4462-91a4-dcceba792bcb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f5312c0-5c9a-4c03-baa8-e38a440a1b75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f9e778e-2a7f-4444-8b58-a1f4acea0c54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4001cf22-1fc4-4d23-b25a-87af12ad66d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("400ab835-a5e2-4f92-a08f-913ba8b69c41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4061153b-adf8-47cf-b930-ff91e8fef3c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40b39248-f923-448a-a558-053e1e4c62db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40f10196-046b-47b9-a4ce-c433d8b0eb20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41013230-cb02-40ab-b068-9b6ce35bdd22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4117482c-1594-4019-b5d6-59ca3c9cc824"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4181a6ce-129f-4867-bbf5-5a21fcbce1d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41866376-a687-43f5-b0ce-90a10b27430c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41da7dc8-f824-4167-ba28-3c87166328aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("420bb89a-30fb-49ca-b3e3-bb87fc4f3ed2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4261af0c-c26d-436c-96b6-017f58195d01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43253ba2-f89a-4fab-be79-9754a284b3b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4332c75c-66d3-430c-9049-4e8c51603aea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43acf221-9174-472c-be72-139f88223c14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43c5d74d-e7ec-422e-aa89-452d8a16150b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44028c94-ad5f-4009-aa75-52127dabb68e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("441fcec5-865c-41e9-b11d-fe758308a421"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("443f3b45-a84c-4c10-8831-757aeee1e7a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44622c80-d20e-4a8e-beec-56cdcb71969a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("449db17b-f21b-4631-8180-166989685cfb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44a08591-302e-4147-a72e-c950c72014fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44cfa4e3-5e90-41a3-a149-4e988e92a3a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("451c8890-7795-443d-ba72-297dda38f639"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4580c2e1-68c8-46a9-893c-a35e76788300"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("458a0a88-5acf-439c-8805-0964eae45708"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("458b92b8-7c48-40c9-bbcf-21a75a8f03f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4595dd09-4a81-41e5-8a2b-ae3108a07551"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45d61b4f-df1b-443c-ab66-81be350d327e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46a115c9-d039-4d42-b06e-09891c7517b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46a54f53-c4ee-48f8-91ff-c31176ab76f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46b6f32b-1782-4ebb-9d4f-b5276017fe9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46fa3f74-634c-4b2c-91c5-ffde63535270"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("473aefef-12dc-4a39-b21b-26b569896a09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4748b558-8439-4037-b70a-6b5ee14e29ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47799890-3d94-4df5-b058-bd4a6991fe08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47eb39e0-9d9c-46f3-8d46-a5729d8b78c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4820c37e-d22e-4d8e-a203-669fd0479e5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48779851-87b1-407f-85d5-4960b416ca56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4881661f-654e-4329-a34b-e2d1598ddc5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("492dd220-b010-4349-8053-3067989e5d39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49b542ff-914c-492a-b222-a44fd17ceb06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49efe51e-0d2c-4098-87d2-cdeb71ef4a63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49f87838-5a56-4074-9a05-02ef16bce578"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4aa86138-bf75-4376-82c1-63689938457a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b299810-3bbb-470b-aef9-42c261721dfd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c23fa1e-3f3f-4a71-8290-a6e0f03e55d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c66954c-46c3-4c3e-b96d-d8447ac93728"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c91191c-d73d-49db-ac34-d0b5ae6e50a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c94832d-6446-415d-a186-1ece45e5c159"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c9bdd8f-0ac9-404d-95ec-a755fb491db5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cf4df10-ab4b-4ede-afb5-6b861df3150b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d0c0ac9-56ab-4f69-af95-f1087c0a1304"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d1265d6-3a33-40c8-8801-56e7e1434a65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d840602-0a55-4f25-868f-52ecdb556b22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e154eda-e076-4408-b37e-25008e9ffe31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e319c80-7b35-4041-9859-982da7c15d86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e51884a-a683-4a50-bfc5-92cb99457d7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e87ffbd-ba7e-4b13-8912-8f4312cd9948"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e9e0d36-a1e1-4e5f-9d4d-3ab19824055e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4eabfacf-8615-4205-99dc-b0a63213570c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ed70dae-8498-4276-8228-ccf407041a34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4efae051-193e-479f-af88-36a83b0833e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f54e78c-3acb-4d41-b34b-fec1098762c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fab139f-cbc3-4ef8-aeb3-87278c4c7f42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fc3036b-ad24-4932-a9b4-af01ce048f09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("513f324f-5da1-4f34-82af-e955328d4ac2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51a9b0c5-d66d-45b9-b178-ef4b77c475a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51b7bd86-cce8-4ad4-b782-10c344e8809d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51b867b4-54ac-4e43-9382-a3b6726c7b23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51c7c259-5b2b-4c39-b711-8f0a2c6a2bbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51ffcfb3-a344-4d40-a68c-0573ab63baa7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("520f9ed1-c974-4eed-b4da-e3e2e7ccfdd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5229484d-2ab4-403a-be89-0b753f119a73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5259849a-be4d-45ea-8276-52b552947a32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52cd5bbf-fac8-4548-9240-15a84ae41572"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5302aedc-f101-468b-833f-927a715cc6a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53073e82-c1e7-492e-99fe-5d15be945585"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("531e6f52-d070-435d-bc86-4abbcaeb5cc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5362824b-f5c4-4bcb-832c-fa16c34ae2b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53638b9e-3d70-4580-99ec-807d06c1d6ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53b9956b-9ecb-447e-af83-55bf554d6295"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54b9ba3d-c71f-4a5a-8af1-9b0d309beda1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54d58d37-7b8d-4d74-b5ca-77cd7d5a9d75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54dafcf9-21e0-4789-94bb-1b669b7df235"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("555133d6-ca86-4a56-9fa2-299d3841ea05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("559855c1-4532-4c08-8ec1-d761dc3b1381"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55c8c033-0ffd-40cb-b40f-31ac41d7419b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55dedae7-835f-4125-a164-a0857f844f47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("561bf85e-d507-4314-9c54-8f38a88e68ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56e8cff2-4eff-4a53-86ad-4c9eaee64767"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5802f822-34a6-436f-b963-1bede8336c7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("580c8aff-e511-42ce-b2f5-5eed9c46a1cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5852e6e0-408e-41b8-982e-514f10eda8a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5870679c-90c9-4765-a932-7981de21b9b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59576a27-cc88-4c02-8e0b-73dc8da2730f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59ae4c8a-ed70-4f3e-87b8-530729a3cbd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59e839b2-1023-4d6b-b3b7-53133646e3d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a202895-7d47-4334-8d01-47b003490835"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a24920c-0d02-48ce-8eeb-b5750153a946"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a9a49b9-916f-405f-8c4c-a61091bdaef8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5aac70df-1e06-4952-99e6-b1763f08909f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b24df9b-e363-4bd9-bc41-7074873bf880"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b70c791-a258-453a-86a3-8d0cb603c02b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b81f8cf-dfc7-4246-9b37-fa24970ae437"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b8890d7-1091-42df-a667-fa010b77f042"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b8ee19a-5bd5-4cce-b63d-1f8d81e04673"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bba71b3-853c-4034-8fb4-10cb34ec3907"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bba9c10-c75d-4a13-b78d-2450b021cb2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bd929b2-ad13-4709-a451-f45f2bdb3b35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c3a3431-18a2-49a5-b480-aa463ac743ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c61e599-b254-42de-9652-e9bd7a7a9a1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c85e5ac-c50b-421c-a21d-ea8faf832b65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c8b8e50-1487-4608-b0b6-09492bce3588"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c992d32-42aa-48b2-b8de-ff0411363790"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5cbeeda0-db43-46ec-a869-172aaf8f87ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d480c64-8153-47f0-9550-173e79089538"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5dd245d3-fd9a-4fa5-a89d-254bd1f82298"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ddd5cef-84dd-40f2-b97f-d5afeeffed30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e2738c6-6d4a-4abb-92d0-75d297f9abfd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e4cae58-1709-419e-8e7e-4e68d7659e86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e8b99cc-0fb9-4039-ba04-2a28f529b589"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f702a44-0598-4ed8-af70-4386363b4c9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ff27c96-4064-49bd-bbf1-2a4cb3e234e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fffbf5f-e7fe-4f82-9d38-a76817341896"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6049393b-bef6-4f46-8636-4e6d45b05355"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("604c67e4-5a4d-4aa2-bd04-c39ea3aac457"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60db38e3-6675-44ee-a670-6b7d1b2d9de3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("612a3cbd-454e-4c97-a8e9-b23272e80648"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6167e2a0-8ee2-435e-b13e-2ad5fcc1edc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("616e4690-0833-44eb-8157-273567fe4d0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61cb5b21-355e-478b-a7c5-2ff172808f62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61e2babd-3989-41e9-9af9-5e145ff6d6a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61e4bb24-8557-46d8-9499-51484b3b8afc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62f729ad-e11e-471b-84ff-0c8581f4a97c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("635129e4-6ded-4011-bd33-f3ddb3df3749"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63998d36-a540-45d1-9693-bd7d17390b6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63d351e4-af6d-4d5a-8c51-f875a9554603"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("641c8fce-0079-4a61-8e58-e42a958681ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("643914b3-ef16-428a-93c3-915ef64233ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6469d915-a4cf-4c6a-bf35-d98953e3b444"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("649815a8-e6ea-4cca-8fde-c02c1c28b9c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64b8e88c-8d79-4866-9801-30d9ff9b9aa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65643851-ce35-4a66-8f5b-6997879100e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("658eb7a2-d821-4b20-9311-cfe24b7fe555"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65b558a4-7e67-4afc-af07-1ffd8ced062d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65f5c6e9-e33b-45d4-8012-539f433b940b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("669242dd-2a8f-4325-ab88-79010042fce5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("669263a4-466b-4bd8-be38-f1bce0159289"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66fba489-c8bd-44c4-a8c8-d93f0e017e38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67590569-0d99-4f73-8fca-63f41417fd7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6785c795-2cd6-4d2a-a246-2693b2a5969c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67cc6021-e2aa-4296-aa37-394004809acf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67fc3aaf-995e-4ab1-a091-b1daf15c459d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("680c1d60-5868-44bb-88fa-1427a304f791"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68530c61-446d-4a64-9d2a-eacf7684d98b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6884e090-969b-4305-af34-4d8723e440de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("692970fb-4c4a-45f1-8fbd-80f9d4de3894"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("697d8e88-78ca-40be-9282-28daa81f278c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd0f1b-9a59-4a2c-9675-26fc9563073a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a33890c-5fd2-491a-93e6-0aaa75537f06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a7ce9a7-91e2-45b8-853d-bd2c2ac1cd04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b344ccd-7470-4a65-9ab0-20e6e11126ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b803687-4cc9-42d3-8b3d-144e8c5bfa4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b80597c-5af3-4b11-8550-e0b7a27c6205"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bfe179a-cb30-4a28-9ba1-ba7f12a7eefc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c17af18-6379-4f74-b0a5-c283249cd4a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c1cfda2-6b92-4b09-9f9c-d6f49d74d71f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c84cfdb-e909-4911-ac90-8ead6dda6ef2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ce2668d-4c33-4e6e-949e-0db1d24830c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d450421-aef1-4109-958b-6a727d84884c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d4ef642-27dc-4433-8a59-177251780fb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d815fd3-5a57-4534-842b-16f70a919fd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6dee356c-649d-465f-916e-056362cbb50a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e21d2ac-911e-4a08-9573-1030098723de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e337908-357d-488b-9de2-2b7fba16ba86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e7a8bb6-a083-4779-a430-301d461031c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e962d1a-688c-4198-932c-eb4e2f6c79d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ea33d60-902d-434d-b979-aba86360f776"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6eab0316-3eb0-47fe-9e45-b069c13f95c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ef318a3-1c8a-46f0-9b00-5f9d8177bc14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f112f55-84c6-4535-886d-090e71f1a46f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f770273-c4df-4454-bbc6-c04dcfebf963"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fa5276f-8d6d-4b09-9690-830fd5ddefdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fd129ff-ba35-49a6-a0ee-932eff45e76f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6feeebfe-7be3-4af3-938b-76d61ad91565"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7025fa49-4ca3-498f-9a91-deb2293eac28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70cb5cfa-c891-4ca8-af99-63b7d3f206d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70db5ec0-85bb-4893-b5cc-2cdc531405d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70dd1e8c-d67f-465c-9241-385d90233026"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7113902b-a3dc-4422-bd77-a86f7ac96ad7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("712b93b4-2fef-4e28-9c72-c34c3fe95186"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72762b46-7dbd-4e5e-a8c5-ad036e92104a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72f98f6e-6545-451b-96c1-e9e72b3fef38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73479c12-e5e3-48c6-a86d-90e68dd6a37e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("735e631c-965b-4081-b861-56263b9ad7db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74a68264-16db-4bf1-b480-b1c4dc68f255"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74a7f2ec-bf76-4611-9330-b7bb332e1071"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74ae26f7-cc3b-4081-adb6-f2c3c13ff0b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74b7c20b-55be-48e2-8189-e437cdc3ac60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74d32af1-6d18-438c-b4e0-a7510865f1f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74f59802-f34f-4b05-a565-22071b86b58c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7506006d-4296-4a47-97a2-03e3250368e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75722094-f2fa-4b91-aa32-1984315ab718"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75ed37e0-3c13-403b-b87e-055e8b2b1448"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("761ed5c9-57a9-4400-87b8-473c923c6209"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76659b18-a10b-4ade-abe7-55ab8b8226ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76cce67c-89f7-409e-a7df-06c9ed09933f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("770f610b-b5c5-4908-90f5-e265b4b1cf4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7873868b-d905-45f6-af2a-014976f6ef1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78bfac24-b2b6-4377-a61e-e39ae4007b6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("793617cb-fbb5-4bd7-86df-60ee8a2a2140"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7960d142-e218-460e-8180-fddd3d7f89c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7977f787-8eaa-4d3e-b4ab-01119237bce1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79c44790-3840-4187-9dbf-ccfcb64b1d67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79ca6d90-1678-483f-b0a9-a2a28bd0b1b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a3faeb4-fc0b-40ff-941d-59db4824bca8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a4fe61e-e188-4423-a950-e43ea8303cb5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a847966-6b18-453f-b2ab-194afe322f38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7abbc736-e53b-44f1-a678-38964bb6e8fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b32f3bd-a482-49dd-bd10-7f5cbe3848f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7badeb49-d511-4a3d-b12b-8005b1447f84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c0c85ce-ffb0-4a69-8b25-90706fde6519"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c11a134-26b8-4b53-815b-c27d55048f7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c7627d2-3cf7-488b-8276-9ad1a3cc4c99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c82d0dd-e649-4e2a-a642-a21466af35b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c9b742a-4212-4c99-bd9c-27cdb8354766"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cc8fc86-2d86-4598-a73e-1f99430294b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ce892b9-eb0e-44c5-abe9-853a40781202"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf5dffa-1ede-44c7-9ffc-e44a73c879c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d254014-fbbd-4651-b9e1-93cc75703ac7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d898635-4212-4f1a-990b-948fa638ddaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ded07f9-cbb6-48f3-83cf-864d8a0c215f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e0c5934-ce28-4ab8-93ca-a30cce4c0196"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e2faee0-5d0c-4e66-adfa-80c83fbe46bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e3fb607-1704-45df-af77-c3126abfc7c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e619e47-6899-4237-9d0b-390b0b0ab1aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e893193-1502-4912-8fb5-c018093cb46e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7eaf6245-d674-41aa-978a-e6e0eed5ed1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ef1fde3-5835-4b1b-af0a-444563a61bf4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f3e13ad-7c38-4458-9680-f3c26bcd6422"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fc336ca-55ee-444c-9849-875385a9082f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fd94883-75ce-40c8-b9f4-23f373d49fe1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ff8aaef-e2ad-4a52-b5ed-c594c2b0574e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("808c3b87-0967-4dc3-9795-a63a426cd171"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81680233-270f-4e08-8a28-ff6ecbd1993d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81c51f2b-21c9-4827-b827-ce72dd324f62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82315fdd-8166-417f-8fe1-093a90dd3b2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82e16b46-6660-432c-b06b-e0ce02dd67b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82e89932-53ae-4c16-b634-49f0ed84cd9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8337bb4a-abc9-496b-97cf-71cb42c31a6d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83569c20-d47e-4e95-aeb5-ad0a67b9e97a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("836bcea0-d11f-4b47-af8a-2cf6f952fb35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("841b50d9-2b39-401f-b2b8-a35b52e117a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("842e98ee-bebb-457b-af25-0ab6f9ba592e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("848fa79f-5f7c-459a-a9f6-eb12c5b1c35d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84c155c1-66bf-4afb-875e-127a206370ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("851ff1d7-8885-4725-b75e-ae3073bf031e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85205d17-0bff-4f59-8bad-f264135d843b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8525a97e-cd63-4160-a562-d0e4259d35a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85aa2fdf-9c9b-492d-9963-2daa1f3f5931"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86406bbe-89e8-49fa-997e-116303a7cc65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("869606b7-0b2c-4ea1-95b6-726c087f9b31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86cd98a2-2d63-4149-b0f9-4f99accf70c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86f68c23-8ee1-4498-a4c4-f096630051cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("872d4e02-2d46-4616-b876-e9196a54c8ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("874806bf-cd31-4749-816d-c197d0ff8222"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87a6d3f2-0dae-40f9-be23-2accb0c264fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87c003d3-949d-4997-8158-c69c55d75226"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("883c462f-52e8-4468-8638-5c257d670042"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("884c3daf-19d7-456c-81e7-6be5d11726dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8873a2c6-9658-4e91-b2b9-3f6954121e94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88967d3e-f06c-4563-9b41-f7f691ddc9f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88e0b123-d93f-4cb9-ba31-107da746ddb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("891f26ef-ae8f-40de-9762-583783b7355f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8956d7ae-6cae-4aad-9869-ff4a6b6063f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89b5744e-7869-4b9e-a866-cd647336e7a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a6771ca-a8fe-471b-a06b-9ea3a6cb89ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a8abbb9-4303-4a0d-b355-c5c50bf0d5cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8aa18ff9-b008-43cb-b815-a173a65428c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ab75032-fce6-4e18-ae62-7759542ea96e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ad1041c-4690-42c0-8d73-5f35a8a8714a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ae60e29-612f-4bbb-ac21-6247c41ca336"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8af5a2c5-284e-45ae-a728-42a9bc5bb44f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b205774-0111-45c3-94b4-b8dd5e7385fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b51efb1-ef21-44bc-9041-b9f4482a53cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8bcc873c-db83-488f-a030-f50463e96671"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c2b9d75-731e-44c6-a8d0-bd65b1a08049"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c51b8a0-74d7-40b8-8e2b-5a91260d7146"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c5e9f6d-92b2-477a-83b7-d26260ec6bf2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ccde4a7-fc05-4308-81bd-fb8f3407ed00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ccf1e3f-a317-4887-bd7a-4e4a173350b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d5b3a7e-5b6f-4bb6-9966-d464dc644958"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d707d8d-e8dc-4374-b3e1-e6655c735e7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d7989a4-c786-47a7-bf3b-33a8c5d5c631"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d895045-241f-4c14-8673-7c9247ab8b6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8da694b3-c50a-4bbf-9416-069314de3977"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8db0d8a2-c36e-4ecf-9b3c-f8aa32e12dfe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8dbb4eeb-ccba-4546-933f-1a71ec368ad3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8dbdb975-2d41-44d4-9810-0e6ea220d38f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8de1cdf8-36f9-41ab-9aa4-3200c6435533"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e80fa43-4bcf-46da-bee6-909cb30b6e89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e83e846-25cb-48bb-bb3e-ec4578254b3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e963667-f6b7-4ce4-9601-282b4e2d726a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ea87a22-8a11-40a0-aba5-23d66343d52c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ef460c3-6f4e-41da-bfe5-a8aa5206dba0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f06018d-848b-4d60-b895-0b6576ffe310"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f10d28a-0ab5-49f9-ac7d-f4fb0142024a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f644f89-16b1-4855-abea-f1a42e59787a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f6c04e8-abc8-4d12-8ddc-db084f1ec52c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f9e0d75-ac8f-4131-b691-cd40b3ccdd1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ffe8344-6085-4f2c-85a8-7b30a7e02dbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("907e718e-f3f2-48f2-9de3-066d982d3918"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9097e51b-450f-4eff-9faa-e3caafe89645"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90bbac31-0435-479c-85c0-e757128031be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("915ada34-447b-4190-a3c4-b04feec965dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("915b8d42-584e-4a93-93cb-3a1072011dfe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92214317-b330-4103-ad56-5efe4bc1ba15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("923735b3-d24e-4386-9ce3-44ce06fb8bf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9237c775-32b0-44f9-8c48-03e0923c0e61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("923c37e5-e9a6-4183-b664-c46e37851e4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("926d259a-e633-4f6d-b100-20455f692d2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("927cdfcd-d920-4648-aef9-f4813c66ca8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92a66219-3939-4239-ac08-4df6fe781725"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92b94e97-0408-4461-ab21-cddcfc4e3b63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92c50165-4ebe-4821-b3e6-1cd6c2c358ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92e625e1-9e08-4c0f-b241-dcad153e844d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("930e5a41-d76c-4fcc-ac83-e8fa6376211c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9315c005-de11-4e3d-a03e-f6cbe7fe278e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93289348-3026-45d3-a6b7-a3c2f0e72e27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("937cc679-d456-46aa-a35e-f146974eaced"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9385c756-e508-4404-ab9e-5cb62e727ef9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93e794a2-03ca-4d3b-82b9-2c219d01b8c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93fc0c0e-8c00-400d-b27e-f2555d77770f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9424f44e-7ef6-4a01-bd7b-a18639160377"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("943061a4-9938-4e61-92a5-6395c7b80198"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9432c32a-7fc8-4e16-8783-49f04d3ffe5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("944d609c-85ff-4c06-8103-cfadeee824b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9495d975-b0ae-4804-9171-90ed77850a47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94bd894e-53e7-4d03-90d9-a993e98a2317"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95527e24-b044-4242-83e6-b67ae5e1a48d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("956bc9b1-8ae3-43c1-918b-c7f736ad5b67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95a1288e-37a5-47f0-a39a-f2ae4a562cef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9603e9e4-565c-4761-a3b0-eab4e67a8bc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("965ee180-3318-42dd-a015-0acf21ecaf76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96a90202-821d-4929-adce-3d43afca1155"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96b6d9c5-6d3f-4130-aabd-e533c34284d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9755ae1e-6f55-4d5f-b5af-daaf4c06cdb6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("979cf14e-d1b2-44cf-a6f1-f885f9aa1431"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97bc2b47-6646-4dcb-87a1-a0f14dcb1cb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("983eef23-25fd-47fe-b5d8-c9ef45dd67d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("989b7eb0-b6eb-4139-a80c-8f6b33a87b8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98a60bf1-0bac-4048-9b38-ff8b79c5aa57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("991fd011-14af-4ee5-9887-eefbda1cea85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99ae0a28-b218-4b7c-8f5d-b73555d2343a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e6a4b2-65ed-40a0-8b7c-138041a85893"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a64de80-19ec-4ec1-b793-5f5f329f17fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a92e9ff-1374-44ed-9bf0-e82e4472f978"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9abb41a3-f51f-4f16-baac-bda043c680fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ace34c6-2b42-4de7-814c-09bfc04575b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9af512e0-4acd-4858-9543-553ba7642a59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b06be56-a8e6-4596-9579-44450dba1005"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b1b0729-e7f5-4dd2-9473-7da291052e40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b28332e-c0e6-47f9-8e77-63f0fbbc5636"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b312057-18c5-4517-85fb-d784633c6548"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b48a3db-64bb-4fb3-b428-c0c4e13602cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b5f87b5-3192-47fc-afb7-ac5d47e67a2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ba38d58-b959-4bbd-8a23-97c9e7fef311"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c0217e2-4850-484a-97b8-990e3714c7f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c597972-64ac-4c9f-bf2f-5b180341eb35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cb88818-a1e6-4a96-957e-c88948fea694"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d92c5f1-5a61-4b46-a6f6-8c23383373f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9daf690a-0f28-494b-98f9-c26e6f70c952"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e80fa51-3f09-488a-b9c2-eb65430c1fbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e9ace78-a05b-4eae-87c8-76fab88270e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9eba8990-48de-4bb0-a0a0-be47f27813a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ee9db32-1a2f-46ff-95c1-d1847f2ad0d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f28c5c2-56fc-4669-85fd-bf02a20c29ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f571c77-791c-488d-9587-380f5fa0c75a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f5b51a5-f39e-46db-aa66-dacb274ed349"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f82d90e-2c94-4eca-bd68-8201493b9648"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9faac760-0a35-4ad9-adcf-5807cbda3feb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ffebaee-b010-48f8-ba39-242df72e1347"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fff6395-7099-4536-add1-d5de0b96c82e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0b4a134-79aa-43f0-a411-57149ba63784"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1036444-3a01-44f4-a511-ea926796c2c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a122af9a-cd10-4e28-9676-fb3ab9df2af8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1365815-d52f-4d1a-a10e-e00561276ed5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1798271-22ad-4deb-bc1f-f629d56b0015"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a17f9534-a212-4154-b428-d78ca8b9e1ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1eadf68-ee2c-4f4e-811d-25e871ab7c65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2b7e61f-23f3-47e9-8ad7-7116f4ba96e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2e76938-314b-4ea8-a6b0-154dda640de6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3063c22-473f-4115-830f-bf5e08eb2755"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3afe627-b388-41ac-8323-1deee4097c89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a407623b-381a-41c0-b4eb-73aeb81481ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a43e496c-f068-4042-bef6-af0f8c9b13ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4dfa313-11ce-4b35-94d9-6aa279de87e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a506f53e-642d-484a-bfbe-512c9d04f463"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5711de7-346b-4eed-95c5-40f1e81e1a4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5c8f41b-b48a-4984-b017-d59e659bceb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6225a37-9d64-4cfd-a700-72dbb74162ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a631394c-b06b-49cb-88fd-23c3b1c0f26a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a672521d-1915-4146-b491-f92db1281364"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a69b3ef0-46b2-458f-8230-bea1bd774a8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6c615b3-eae1-4c86-984b-ca744cdfb409"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a73d35d6-34c0-46d7-9820-1bf060c5dfbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7c887cf-9d7b-490b-b8c2-ceb240f25f37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7cc6111-2472-4e1e-acce-06f912d1c5a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a86e3032-4c33-48c7-9549-f8d51f6d6ca1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a91e47c7-2213-4039-a928-135b564270c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a943ec11-3ae4-42d9-965a-c75d64baf55d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a99a3c43-7296-499f-8b70-146368c750e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa04d9d5-adf6-431d-a207-2be9000aab5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa0d77a4-d011-489b-a6c0-969086ffa53d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa13d25c-4e56-4327-a78a-4b30573c8591"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa4ac4f8-7768-416a-b703-01a3f796c4ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa5f90af-9b9a-43bf-9d40-61e63f3aa67c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa770bae-2246-4c84-b702-9c09725462d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa874dff-569e-41f6-b721-c08c7653dfad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaa5b75f-d70b-4d88-880e-f721f10ee6ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab304953-caa9-460d-8a51-87d1d2159c04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab924c42-7880-4f3a-b87f-2f630a5e6b55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aba0afb3-ffb9-42c0-8b6d-3cdd14b8f322"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac0070c3-f1ca-451e-b15d-54bd86e7f4b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac0e2ee3-c9c3-4dcb-a614-d3d408f73a6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac1ad1d8-133d-4b0c-be4f-eff5bad61da8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac236b56-e35f-4273-a702-40dbe2f605b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac60c825-3bd9-4c9f-be28-0b79d57e376d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac918e51-5f83-4125-8eb3-1ef2bc0a3ae0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad1dd8ad-1917-4c55-b94e-6cddedd7d46f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad5a7581-0fef-4ea9-9bdb-512bf09df38b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad756330-53da-436f-8602-67abd1e03eda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad7dc2dc-4aa0-4d56-a3b9-3b1280a10a07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae0d34ff-267e-4885-b23c-016c3605ef10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aecc8724-9920-4447-a70a-348935c09250"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aeef912e-9165-45fa-bc6d-7c7f0488e81d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aef75ede-6572-47f0-a3aa-7b6005856391"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af08ebf3-0f5b-4ac8-aa65-8b594fc5dc95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af125b56-df12-43ab-92b7-27c665f27dc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af7af7cf-9574-471d-832c-7dc701c873df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af801049-31fe-4aa1-af97-441988a22395"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af8debd2-7cbf-44dc-85db-d26ba7a9c252"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b07c5aba-5dba-4099-8f4a-ad27900f8ddb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0af5917-f43e-458a-9eef-ca62e73b2803"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0f69887-ad41-48c5-ab8a-632297ab014e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0fc70ac-a120-4901-9aaf-4b8c5026c213"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b17a2a5f-bb69-4cad-b691-3aab36c94cb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1b75017-7727-4cc5-960b-3f008a99efea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1e337e0-ef8b-4ee1-9760-04ea74c0851d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1f5cdd4-97fe-489b-8892-5888fb35c1f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b21073de-1229-4618-a1b4-1aa939e27162"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b287bdb2-d40d-4a97-b82e-1260f18a503e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b29be192-6221-4ad7-b14d-5ca901c8c06c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2d83c80-d797-485b-b264-531032959aa5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2ee4ccd-bf76-4312-9b18-c0776c39b500"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2f65d70-112c-49e2-8416-cf75118f05a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b33ea139-fd59-4bf2-896b-0efa1fd0abea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b35c7312-2330-49be-a89c-3ee3d6b9b394"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4360034-4e52-4301-96f9-0c3478104e2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b436c3c2-526b-48c0-9cf3-24889c8f89e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b45bcbf9-c09d-4352-b8db-90575b310345"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b464f50f-60ac-400f-9c48-d27ace6c1e80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b46991c1-5d9c-44a9-a355-c6f599ce935c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4737372-2a70-45e8-bc13-1e5ba6a81919"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4f32196-be8e-4bd7-bbbd-765cbf9b117a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b50f683a-df32-46ce-b0fd-3feb981879ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5429c7a-8edb-44f6-a303-9e7a0dbf7f84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b61466c1-6b72-483f-ab44-92b92579ca59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6be9ade-352f-40a9-866f-65ceeb00b8f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6db8acb-1678-48f3-9857-b5442d490359"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b80295e8-2a4e-4c50-aa3a-bfa5ff7f9c43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8629204-099c-4543-bdfa-817dcd4371cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8faf0bc-f096-434e-9c09-11c0acf0bf81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9433cb8-a231-4068-bb6e-959892ff0660"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9b27e1b-bbba-4bb2-a272-989c464662ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9f4bd6e-8d02-4b91-bca9-73938ab9b30c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("baabd20b-5052-429a-b6e2-01be67c4d364"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("babe67d4-b715-4465-a28d-53b6336473a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("baf3073b-6c24-4c86-b261-438e768c3196"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb13b97b-05b0-4ff6-9346-cd5378e447e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb15ecb9-ed65-49fe-befd-fb5dfc8abad2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb294489-0db3-4fef-9124-1981ea629fb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb43c103-150d-414a-85ca-89e4b4e53e23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bba7d0f2-8798-41e5-84b3-392b2b94afc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbb32b60-efc0-4caf-9bf9-7fb313ed43ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbf5abce-a5d4-4d9f-a054-37d99427eaa7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbfc74e8-834d-4715-b783-ea23a33c0076"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc08b1d2-47e0-4680-b3a6-a839db59098b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc4153f9-faad-4d2d-87ae-c4e5f8571c45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bccc26b5-a7cc-4638-9930-99fbb0d0e504"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bce51c25-6621-4303-aef2-af7152f6fcb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd990095-bfb2-4538-a20c-271519ed9b0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bdef1f5f-22d3-4b3e-8e72-f3c8610bc714"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("beb89a97-8481-470d-8122-dec6974baa58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("beba2d26-5934-4b3d-83ee-1fd772fda365"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf5e9dc3-5e6d-4a51-90e5-266c9dd46f1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf7880fb-d106-49a2-ab02-45710204e6c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfa787d9-5458-4ce2-bf13-183bdb020215"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfd4ed4d-4d92-4fe5-b2f0-2a9e9b62de5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0c12bfe-abc6-4da8-b0c7-68f5db7eeffd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c146d134-d384-4f10-9adf-622a2e48d3ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c15b674f-7b96-4464-8434-daa9ac46efa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c15c1c60-4998-4603-96c4-728e6203ef79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2c72f44-74ae-42a2-9175-fc4b62a501ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2e60f95-eece-4b56-b2d4-3e9b6bb52a13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c355fa4f-6b3f-415f-be9c-cfc5e3a6ab0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c35b71e7-5cfb-427f-9012-2552437c10f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c35ec5e7-e7c7-4fb4-985f-d932230d9cf2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c41828b0-fd22-4067-bedc-3d50b7c68dd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4183e6f-99c7-4d35-b676-c3e5c9ea73e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4b41b4f-dbff-4dfd-9b22-9ca440daded2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4be5879-e2ce-41f8-b90c-3a674092cc31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4ee24a7-a4fe-4b01-b18f-fdca470bfa2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f76703-08ae-46e7-a236-1a4211d5d318"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4fbe59c-fe86-4093-bc8f-62224f7c0089"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c560e670-a0d8-4b20-9d92-5030284fe5b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c669c152-5339-4849-9606-c2ad064997d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c69b0e6f-dd9e-46c1-a091-a446ca345cb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6e6042d-7bb1-405e-98bd-1d5337f5d43c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6f1b148-0f78-4d85-a270-4c5a6f68f2b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c77aa5b8-bd1a-4a29-9b83-b59b2ff5eed6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7fccd16-6504-455e-b1c7-460b3051939e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c83e274c-f8cc-47f8-b296-23a66ed8dab2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c87ada26-3f2c-4497-9faf-3721b2ffbe17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8df730b-63c6-479b-9173-b5c3dbbf7590"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9295ed0-ebed-4c31-8537-b81b09203ae6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c957fde5-db82-4a4b-b637-dd15357767eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca5a23b0-57bf-47e9-a6c5-e5c467f41630"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca5fa810-ab6e-4311-85d8-717642aa1d96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca645915-1734-4164-88cd-ab95837b8119"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca830455-6c51-42e8-ae1f-f649ab0a459b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb04e471-af7c-4519-a839-7dcffb350eba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb2a1018-6534-45f3-a926-e8a311472f91"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb32be04-525d-4722-9cf3-ee48efdfc0e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb543744-46a2-4657-9f43-6dd5205a3adf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb7d3fc6-0a23-4e86-863f-b403380a52b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc029f3e-fa64-4f59-ac4d-c5986b4b9f85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc3b18e1-13d8-4c96-b87b-fde5ab85cab2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc7f179d-0f8f-43ec-a8d7-335e8839d06c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc9376ca-7702-4604-8b64-c05dcba1ee19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd096200-b71a-49ec-b636-26bd19d4856e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd92d2a1-130b-481f-9c02-bcdce7bad481"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce7e1be1-29b1-4bbb-b099-293432993b70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce86eed9-ad3d-4f9e-bb44-20d3e3c2f2bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d004851c-9a01-42c6-86b8-46cf19068dd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d02b590a-568b-47fa-89ab-3edace0bdb0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d08e7c49-8a9c-486d-88ef-2e425d471418"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0c9c5ff-e016-428d-83d7-219e5108e689"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0e567d5-d5fd-4207-a538-d8c1b519cca7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d10f0157-0549-41ce-a76a-af9e71caf0bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1f450f4-a570-4e39-9295-60b5389b633c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d24ebe19-a512-4cf2-945d-c007073bf03b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d250ebcd-2696-422c-9777-d350f5721908"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2c0bfb7-d3ca-4f1d-ae54-3f1ea548b17b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2e47f38-8b5c-4a93-97be-ab30342915a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d300a265-34a1-4a99-8c4f-1e9f754e679a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3037349-6d05-44f2-9f12-8ba277b8bb5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d38aadfa-22a5-4179-becd-901b981f9ace"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3b2aa8e-818a-402e-90a9-4568319871b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3dbe1ee-44b0-4556-b301-e5896c6368c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4590231-2784-4b01-9e0f-31a336ff9f5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4698adf-44bf-466a-9740-925eb14bc745"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d537abf9-f173-43ce-817f-cb23ad89e8dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5c6f045-c049-4841-8c1a-62bb983fe17d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d652af6b-a40d-45c8-85d3-8730079a2b40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6603ca3-2d4c-47ad-8739-161fd6caf47c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d665cc9a-d338-43ec-9175-52507013f73d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6c33b72-dfa3-4dd1-a035-6a39a04acc7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d74267e5-b84c-484f-9c17-f46dcb25563d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7787a74-f5f3-412d-90ba-7c1e15b8b6e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d77b42c6-aa55-4e93-ae3a-91ea1d108920"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7a00ed5-30cd-4bb0-bdd1-742c61e5c2a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d805feb3-50b6-47b5-9b14-3654c7723f2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8231c2d-6e42-4ba0-91f6-e7a1c8a11d88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d86ee24e-1300-4e43-af8f-41016372b8d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d878f493-7a1e-4d0e-b6ae-f3becb44565f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d89eb071-d0e9-481e-a9ba-afe5059a470f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8dd785c-0796-418b-97b7-332f024e74cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d964c393-ce96-4bac-b41e-547bd6a78938"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d972ba3b-241f-459c-991b-9b174dc4b027"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9e5b65b-504e-4306-93bf-9678b7f3d6db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da145fc3-e4be-429b-821f-f03a2f102404"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da3fd9ec-f7d8-411f-8555-6b193296ab92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da48fcbf-c0eb-4035-ae75-1178c7a55c8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da86663a-d4ec-4526-b9bd-89a905f27543"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db1e28f7-0c37-4687-883f-7467dd0ab002"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db5349cf-10a8-4182-8bac-8ea6d4124555"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbc2a069-6374-4c8b-a6a5-2203eaa25107"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbc80103-cde9-4bcc-b8d4-1a87db9faf40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbdff177-43a5-4eda-9457-5e417874bf9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc1de14f-724d-4c3e-ad5e-f110ceef3b8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc1f1700-1c9a-4364-874c-4b845331bb9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc8887e7-c7b3-48ac-b739-f2e3e4eda1e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dcf6a239-2b9d-465e-a27f-ff76776656ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dcfe311f-c165-4b46-b82a-d4e77fcf2681"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dcff32aa-e42e-408a-bcf0-4f4d0683ffd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de17b0dc-006b-40ed-bb68-1c57ceb616d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de2d537a-5792-4987-a00d-983757956d5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de2ddf94-005b-4389-940b-ed96b14155fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de4a7ff8-22bb-4fb0-bb80-1d3a9c0bd044"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de68ecee-6d0a-430b-926a-01a4d2724589"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dea53cf9-51e1-4305-811b-f1e0b730fb6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("debea68a-1dea-471a-8484-111e2a51d98b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df332d20-9995-426e-9b4e-cc246e891eee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df3a358c-dabb-401a-b71e-4c590433a9b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df46ae9a-dc1c-4097-a5f1-f89b3ec10172"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df5d278e-29ac-4d46-b324-d98fad5161b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dfa08544-502d-48b7-9865-e684dc66c3a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e03cb4d1-54e3-4996-851c-0939ac75c4da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e072e358-ff91-42ed-91b5-2d63ba4fe00f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0e255e4-93a9-47d2-93b0-b7b5913f38ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1baf4dd-a1b3-4c79-93e4-35f4080df368"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1c16bfe-6235-45b9-afa0-e7f89454bc7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1cc5e9d-7f2c-42a4-b0b2-0b05d587fdc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e207bbe3-f58c-434d-9e3e-2077e2865de2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e211554e-8040-494f-b059-e01c5cc7cb9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e25f011b-3cf1-44b5-898a-731679c59e60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e28cadde-3ef3-450c-84ce-2e2908eb8b4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2c1886e-884f-4c79-bbce-cb4ea1b93a67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2fefce2-71de-42ba-91fd-a9db937d2e72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e32ef71d-7deb-450c-baaf-bf6e9615b252"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3930620-4e1d-427b-8161-974eff94a4f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3bece08-c4b4-4131-a726-21e3be56d102"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3ca71f4-188d-42fc-9de3-bb60728dab83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e436d073-a3cc-4cca-a98a-d50e5a8f02b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e44adc66-1159-4831-a057-33eed986daa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e46f6be2-4254-4439-8f7f-2a4a2fbd4e15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4d22543-b50f-4f69-848e-2366b83f092f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4d9c03b-1e0c-4087-a63b-50968f3edd44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4df01a7-7117-467f-8494-80e31664639b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e58cfc3b-699b-4337-804c-4135cb606dd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5af610c-a0b6-4a11-9dd9-095a9a57c87e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5cc023c-fab2-4a93-9a9f-a4a93104d99b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5ea6889-354a-4ec9-b369-cb2f2de8deb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5eb8c45-d77c-4a2b-8244-0abce2b516c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e670c35b-6bd0-456e-a206-813fbbd9df82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6fd2e26-0c6d-44d7-9203-274882362395"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e713cfd3-8e82-444b-9424-10fa9edd4d02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e74de55a-e5ec-4799-8bc5-4c7650934266"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7610e9d-73a1-4b5c-8fc6-09d6a6afbfe4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7adde2f-147b-45c9-a732-27a6a3954e66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7f07ae4-635d-4985-a7d3-bfca7afdb38d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e82dc971-7bdb-4b81-9c68-81d710d49f1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e88aea8a-c884-420b-b26e-849f71c87d8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e89a6c6a-fe3b-4204-9057-98873b756281"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8ef261d-dbad-433f-85df-3f6225b9e0a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9025111-72e5-4a19-b04a-3789d3b17917"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea9c9945-0939-479b-a41a-15f3df08ea29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eaab7e83-f9ff-4ef3-a4be-78ee5fd1b1d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb0ff537-9988-4124-b517-3dc5f8bf59c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb118e2c-76a8-4907-8aa5-c45544ab5e38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb1c6582-4cb7-4f0f-a77c-3118ea3d00d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb36c796-f63f-480c-ad3f-949cb3d6df25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eba366b7-1779-4bf0-a522-8dddbf0515dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ebf50672-d1eb-4251-909b-9479300f038f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ebf800cf-7f9f-459b-962a-ff0fb728cbba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec181561-c2c1-471a-98d7-968d8a59d8cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec3b84b7-0edd-4826-bdb0-cbe46d8bf7f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eca38293-b7af-4619-ad1a-1396488d7c19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecef3b5e-c876-4913-b332-32eaaf0c8711"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed009121-c3f6-4f94-a120-700d34de39ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed3a11cf-9f54-4be1-b3cc-0daf745219e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed5dc6ef-66e3-46ea-9719-c3a08f206b0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed602681-7593-4c9c-82e2-46b7de9afb3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed79fe08-5078-4271-8ea7-ea70538bb384"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed916b96-38f2-480b-badc-8874b3063389"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eda70960-2153-431a-84f1-60f2ade745eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edb52377-e981-4e34-b933-9a6dedc38fd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edcd987f-27b1-477b-bedb-4dda1ad7769b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ede57b0b-a0c9-4ef2-8201-6031d44258a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edf49215-c8bd-42d1-93be-d27b665eb168"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee0bfecc-7807-4020-bbf8-68f470d3e2d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee822d68-22ee-47f0-a636-6691fa9b68a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eeb18bd6-9b1a-43e7-b4a0-ed3b1674fbf2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eec22234-dfa3-47f6-8228-feb0c2959649"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eed14b63-b584-42f5-90b7-7acb48cf45f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeea9db-6ef0-4ee8-8344-bc1571efb72d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eef8aea0-abe5-4980-ae38-185faf061517"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef109691-56a7-41a8-8adf-603bdbaef8dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef13ffe8-8775-4765-b63f-4eda080a753c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef41c347-1bab-420d-9d52-64c828655add"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f07254c5-a3ee-4124-a34f-3c8e03a024a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0c8db9f-8e89-4eb5-a186-1d2f4fef9cb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0f7495d-8be8-4219-8e46-5946245f3d7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f16b1ac2-5689-4afa-ac8f-58808a6f5fe5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1c23b5f-9332-445d-8a37-03f59d5ec050"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1df0799-d628-4d2a-9592-c0000ca21059"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1e789ca-50b8-435c-96a4-3da341967d6d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1eff619-16c6-4d6b-bc62-3a52b3231f40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f253c283-1831-4513-9184-f35f077cf228"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2aa3943-b47a-45f1-8f82-639eaeefb368"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f338720b-7d76-4c90-9bf0-8377c557d70f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f338f68e-4ac7-4f1a-868c-387aa42f7ab1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f39ddec8-0fa6-4c4f-81e8-ea3fcf4f3cf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3a226e0-65bf-4b11-a63c-32013752bf2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f43588fe-23be-4327-b892-e2cd7e07da5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4fd3740-b5be-4874-a8ea-5fa8a4853c4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f54c2bd3-b088-4e58-9455-08c12fffd6e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5a213c5-c974-4a53-88c6-b9ecf0b143c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5d5214a-3b5f-4f7d-bb16-9cb30bbcc873"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5efdefa-fcae-4a5a-abea-3cc92c1906aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f60bae43-49af-4fa7-9111-dd90212fed1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6abf5af-f628-427d-b3cc-76e067cb2323"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7186eeb-687c-4316-b45b-17deebfd417a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7818492-cf71-448a-8296-7f5a28076a10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7a76d03-cb6f-4a50-9f21-b5de486306e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7bae142-177c-4ede-b113-140324e4e72f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7cd1821-dc63-468f-8c39-64a30627adb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7f015ca-df65-4d52-b21f-3817ef9dc426"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f86025f7-52bf-4087-8baa-4e0758c86fdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8cb093a-c2f3-4183-a3cd-233307ec627c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8e47a99-1bb0-4466-b135-6fcfe3e0948b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8ed42b3-a031-4ef6-90a6-523f8bef984a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f96f5fe2-51bd-487f-bc7c-1b79b2e0a349"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f98f028a-0eae-4a11-abd8-41de10e987f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa02339c-a9f1-4424-a244-5f2912f36cdf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa05dfc2-4922-40d0-b799-5cf64a851a89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa58a969-7a9c-48dc-bfac-de76d415095c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa697e10-586b-433c-95ae-6dcb88d4dffa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa752ffc-03a0-45f3-bf9b-4df1c0a4d341"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa8b77ad-9804-43dc-8aec-f1f79457ac83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa8d6a8e-d3ae-4e1e-8d67-1ae548e7bf7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("faa255e2-f489-4dfa-bbef-887316001e91"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fadafe5e-79b9-403f-8d1b-432291d6e81d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb44f040-fa29-461b-ade0-e2c44f5aa0ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb63e8a8-f8ff-4282-9110-6460cb7d5581"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb71218b-3f87-4141-b4c3-1f3388791433"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbe5774d-a82b-4fee-9ef3-5a7157ebe8f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbe63a44-bc08-44a1-9327-7031f069de27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc513120-12e8-48ad-a011-866047c70e96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc7e0524-22b8-46a3-8329-26aa619e5929"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc807bc3-4edc-4873-8b41-8fa7dc0b3328"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcf8a0b8-bb10-4f27-8605-69200bb2a532"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd5fc3b3-d480-49f9-8571-fbaa19c01a66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdabb676-8aab-4603-9dbb-f99e2ec92377"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdce4ca3-215e-4814-bc81-801c9123152e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fde859a3-1926-413a-a57e-ab1506128f8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe1df691-8e82-4962-affb-7f4d6d229e05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe477abf-6d5e-4358-a648-1575d849ba2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe5e03c5-1f8a-4cce-b43d-8b802f2892d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe61fda3-e49a-438e-9568-337b4a4ee152"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe7cb111-b3ed-44b8-a3b6-2d981f10f511"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff2b8d85-dfd5-4be5-a50a-4408fe669dfb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff7e5147-9717-4265-838c-15e983a5bab1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffbfccc9-1fd3-4bc6-aede-8ee3c891df27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffc29fbf-5be9-485c-98bd-60fa7be57ea9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86404e65-c4d6-450a-beac-a5f0e15b1b0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e6f752d-3100-4693-a411-cfe96202ac61"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("dbac0a66-9521-451a-856b-ab02e18575c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af59abf9-3a74-4bc4-a06f-798c2cfae79c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("755ad1e8-e1ba-4284-9e5a-eb6095c9b26b"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

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
    }
}

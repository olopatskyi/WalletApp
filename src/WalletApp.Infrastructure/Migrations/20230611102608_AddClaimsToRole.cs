using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WalletApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddClaimsToRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21789e0e-1737-4545-862d-fc3fbae3bc6d"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("054a3c70-cfae-4903-8f4c-7c88c5b908dc"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("067969e9-dbe6-4b7a-9767-90dd3741411a"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("e951b17f-962c-4fda-8bd6-2e44ed76549c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("3c86f0d2-9196-45be-a007-a1a2f7af5fb8"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7bad2df0-c90a-4a1b-892d-8c6afe0ea5a7"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("87104dd6-7c44-46ee-b244-9526867a924b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ac6ac6a2-2575-4f3e-8a88-11ae8046efb9"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Barbers");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Clients",
                newName: "PhoneNumber");

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 14, "get:barber", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") },
                    { 15, "create:barber", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") },
                    { 16, "delete:barber", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") },
                    { 17, "update:barber", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") },
                    { 18, "get:client", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") },
                    { 19, "create:client", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") },
                    { 20, "delete:client", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") },
                    { 21, "update:client", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") },
                    { 22, "get:booking", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") },
                    { 23, "create:booking", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") },
                    { 24, "delete:booking", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") },
                    { 25, "update:booking", null, new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a") }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a"),
                column: "ConcurrencyStamp",
                value: "debf1c58-a326-4dcd-994d-0a1aee44f4d0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("7b47b6c2-dd7c-4054-93a3-13764fafb71a"), "7220d6ef-9152-463e-a159-9d06c4912ff4", "Barber", "BARBER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3615f116-6534-4566-a6ef-eace03040563"), 0, "c912d03f-d631-4004-9481-30e941f4be73", "artur@gmail.com", true, true, null, "ARTUR@GMAIL.COM", "Artur", "AQAAAAIAAYagAAAAEJf43FCiqbG6aiHa1j2LHJ7f1boLMtEY6qWrQJQOBW2fg6+DcYojBz2ZyE+Z6uSYxQ==", "1234567890", true, "4c5a46ea-2c57-46e6-b454-077f5da76ca6", false, "Артур" },
                    { new Guid("66f07b70-0485-4740-98fb-7b68c9137db6"), 0, "c3985bae-2101-4de4-8856-4de108d75f7e", "denys@gmail.com", true, true, null, "DENYS@GMAIL.COM", "DENYS", "AQAAAAIAAYagAAAAEO+/oMiFvIAZ1EeezVNHulhlLgkeqD/aBPjVarrXr9mAA24uRXjkXvSy354zl0Qg+Q==", "1234567890", true, "0a9c3078-3035-4da1-a71c-f44137784de3", false, "Денис" },
                    { new Guid("ce4bb7c0-6614-4fdd-b782-5e854ed803e7"), 0, "1b3f3d63-1da4-4b90-90f7-032be9245de7", "maksym@gmail.com", true, true, null, "MAKSYM@GMAIL.COM", "MAKSYM", "AQAAAAIAAYagAAAAEBJYxHpDyUApUeFzYShWJFfWy6k5z2rmTydKpXZ1M5FP6bYFriEH12M+UcvODYLyCQ==", "1234567890", true, "4d0ab5af-2ef3-4f33-83fa-d76f197e5fff", false, "Максим" }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Coefficient", "Status" },
                values: new object[,]
                {
                    { new Guid("17ff6de9-52d0-4eae-94a1-00e18a51939b"), 1.0, 0 },
                    { new Guid("1c35ff11-df37-4d9c-9077-7ebf6a0d52fb"), 1.2, 1 },
                    { new Guid("6eaf3ae3-6b4c-4829-9307-b8552f85d340"), 1.3999999999999999, 2 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "LogoUrl", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("4817abd2-f92e-4c63-9b24-753783f9f110"), "http://localhost:3000/assets/icons/golinya_icon.png", 150m, "Гоління" },
                    { new Guid("65869337-602e-4294-97ee-65f6d34a4234"), "http://localhost:3000/assets/icons/machine_icon.png", 150m, "Стрижка машинкою" },
                    { new Guid("d0e9876e-1f7e-4577-a056-65bc055680ab"), "http://localhost:3000/assets/icons/struzhka_icon.png", 200m, "Чоловіча стрижка" },
                    { new Guid("e000b913-7a7a-4a6a-b002-a000b5482086"), "http://localhost:3000/assets/icons/ukladka_icon.png", 100m, "Професійна укладка" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[] { 26, "get:booking", null, new Guid("7b47b6c2-dd7c-4054-93a3-13764fafb71a") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7b47b6c2-dd7c-4054-93a3-13764fafb71a"), new Guid("3615f116-6534-4566-a6ef-eace03040563") },
                    { new Guid("7b47b6c2-dd7c-4054-93a3-13764fafb71a"), new Guid("66f07b70-0485-4740-98fb-7b68c9137db6") },
                    { new Guid("7b47b6c2-dd7c-4054-93a3-13764fafb71a"), new Guid("ce4bb7c0-6614-4fdd-b782-5e854ed803e7") }
                });

            migrationBuilder.InsertData(
                table: "Barbers",
                columns: new[] { "Id", "Description", "PhotoUrl", "RankId" },
                values: new object[,]
                {
                    { new Guid("3615f116-6534-4566-a6ef-eace03040563"), "Доповню ваш образ гарною зачіскою", "http://localhost:3000/assets/img/third_barber.jpg", new Guid("6eaf3ae3-6b4c-4829-9307-b8552f85d340") },
                    { new Guid("66f07b70-0485-4740-98fb-7b68c9137db6"), "Зі мною можна поговорити", "http://localhost:3000/assets/img/second_barber.jpg", new Guid("1c35ff11-df37-4d9c-9077-7ebf6a0d52fb") },
                    { new Guid("ce4bb7c0-6614-4fdd-b782-5e854ed803e7"), "Працюю барбером вже 3 роки", "http://localhost:3000/assets/img/first_barber.jpg", new Guid("17ff6de9-52d0-4eae-94a1-00e18a51939b") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Barbers_AspNetUsers_Id",
                table: "Barbers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barbers_AspNetUsers_Id",
                table: "Barbers");

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7b47b6c2-dd7c-4054-93a3-13764fafb71a"), new Guid("3615f116-6534-4566-a6ef-eace03040563") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7b47b6c2-dd7c-4054-93a3-13764fafb71a"), new Guid("66f07b70-0485-4740-98fb-7b68c9137db6") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7b47b6c2-dd7c-4054-93a3-13764fafb71a"), new Guid("ce4bb7c0-6614-4fdd-b782-5e854ed803e7") });

            migrationBuilder.DeleteData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: new Guid("3615f116-6534-4566-a6ef-eace03040563"));

            migrationBuilder.DeleteData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: new Guid("66f07b70-0485-4740-98fb-7b68c9137db6"));

            migrationBuilder.DeleteData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: new Guid("ce4bb7c0-6614-4fdd-b782-5e854ed803e7"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("4817abd2-f92e-4c63-9b24-753783f9f110"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("65869337-602e-4294-97ee-65f6d34a4234"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d0e9876e-1f7e-4577-a056-65bc055680ab"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e000b913-7a7a-4a6a-b002-a000b5482086"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7b47b6c2-dd7c-4054-93a3-13764fafb71a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3615f116-6534-4566-a6ef-eace03040563"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("66f07b70-0485-4740-98fb-7b68c9137db6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce4bb7c0-6614-4fdd-b782-5e854ed803e7"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("17ff6de9-52d0-4eae-94a1-00e18a51939b"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("1c35ff11-df37-4d9c-9077-7ebf6a0d52fb"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("6eaf3ae3-6b4c-4829-9307-b8552f85d340"));

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Clients",
                newName: "Phone");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Barbers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a"),
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("21789e0e-1737-4545-862d-fc3fbae3bc6d"), 0, "b48bfbff-18c8-45d7-819c-40b8263c2742", "john@example.com", true, true, null, "JOHN@EXAMPLE.COM", "JOHN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIaTUeaiyk4/lhnGKmMWVJ79lSPbCbHGy+fb/CTnud+HUUVLAG+gM6FkTFQURNGh1Q==", "1234567890", true, "YourSecurityStamp", false, "john@example.com" });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Coefficient", "Status" },
                values: new object[,]
                {
                    { new Guid("054a3c70-cfae-4903-8f4c-7c88c5b908dc"), 0.0, 2 },
                    { new Guid("067969e9-dbe6-4b7a-9767-90dd3741411a"), 0.0, 0 },
                    { new Guid("e951b17f-962c-4fda-8bd6-2e44ed76549c"), 0.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "LogoUrl", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("3c86f0d2-9196-45be-a007-a1a2f7af5fb8"), "https://i0.wp.com/therighthairstyles.com/wp-content/uploads/2021/09/1-the-ivy-league-mens-cut.jpg?resize=500%2C592", 200m, "Чоловіча стрижка" },
                    { new Guid("7bad2df0-c90a-4a1b-892d-8c6afe0ea5a7"), "https://productimages.withfloats.com/serviceimages/tile/61d18e8ace08b1551a7cda07Men%20Haircut", 150m, "Стрижка машинкою" },
                    { new Guid("87104dd6-7c44-46ee-b244-9526867a924b"), "https://sonofelicebychristine.com/wp-content/uploads/2022/05/Male-haircut-near-me-Hair-Salon-Los-Angeles-Sono-Felice-by-Christine-scaled.jpg", 100m, "Професійна укладка" },
                    { new Guid("ac6ac6a2-2575-4f3e-8a88-11ae8046efb9"), "https://qph.cf2.quoracdn.net/main-qimg-3ded8bbf60b8247f83ac9f5600f10e33-pjlq", 150m, "Гоління" }
                });
        }
    }
}

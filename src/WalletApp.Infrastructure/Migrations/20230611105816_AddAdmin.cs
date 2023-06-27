using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WalletApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a"), new Guid("21789e0e-1737-4545-862d-fc3fbae3bc6d") });

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a"),
                column: "ConcurrencyStamp",
                value: "7acc740d-f2af-439b-bf57-fff95e4e5bba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7b47b6c2-dd7c-4054-93a3-13764fafb71a"),
                column: "ConcurrencyStamp",
                value: "041c970d-df9c-40b0-8783-ab8b5b84e199");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3615f116-6534-4566-a6ef-eace03040563"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54f49b3b-66c5-4265-a199-03c179443f6a", "AQAAAAIAAYagAAAAEOepPUiFmfhIUdSWQHaNxglx7sayOPpbx8iR8UqO48wpM1uJZWC1iSZZK+JDrYpddw==", "da6fadef-d7cb-4440-a6cd-2db167eaedad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("66f07b70-0485-4740-98fb-7b68c9137db6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd352105-2199-4274-9d25-cb48fc3b0aaf", "AQAAAAIAAYagAAAAEGK8DOxb3oOWVD7bhLOp6v/TS9fCWfRKwpVxh3jHcQAi+h4x1cFU8ScRq4euilYXrA==", "a36512cb-2d6e-44b3-bf26-f326ce97645e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce4bb7c0-6614-4fdd-b782-5e854ed803e7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbde3e0c-1bdc-4af2-9ef9-a2a181da5ba5", "AQAAAAIAAYagAAAAEG9aT1yo8qaR+o9zYZMX2wwPQMMqpog2ZUG3sbXkBGd5++MRA9jh2XrGWDabsoZibw==", "559d3995-d5a6-4964-85f7-8abad588b110" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"), 0, "870e93e4-5b74-4249-901a-ba81d8ff8fd7", "admin@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEKma5hRc/ULFSF5qpCmor7pN51bv0a1RA/UzIae2epsqZBHf1MxLoRHe17latE1CuQ==", null, true, "4a272fa6-b098-4974-aaab-b89a6c68d8e0", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "LogoUrl", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("095cb701-0d66-48e0-91c3-1c6df110dcf2"), "http://localhost:3000/assets/icons/struzhka_icon.png", 200m, "Чоловіча стрижка" },
                    { new Guid("2bff2bab-0fa9-4731-9c5c-1058b8cb3675"), "http://localhost:3000/assets/icons/ukladka_icon.png", 100m, "Професійна укладка" },
                    { new Guid("9040f34c-800c-4590-882a-37b8a608c676"), "http://localhost:3000/assets/icons/golinya_icon.png", 150m, "Гоління" },
                    { new Guid("c44a611e-52e9-46ef-8864-e1ca4df8aab7"), "http://localhost:3000/assets/icons/machine_icon.png", 150m, "Стрижка машинкою" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a"), new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a"), new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa") });

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("095cb701-0d66-48e0-91c3-1c6df110dcf2"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2bff2bab-0fa9-4731-9c5c-1058b8cb3675"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9040f34c-800c-4590-882a-37b8a608c676"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c44a611e-52e9-46ef-8864-e1ca4df8aab7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a"),
                column: "ConcurrencyStamp",
                value: "debf1c58-a326-4dcd-994d-0a1aee44f4d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7b47b6c2-dd7c-4054-93a3-13764fafb71a"),
                column: "ConcurrencyStamp",
                value: "7220d6ef-9152-463e-a159-9d06c4912ff4");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a"), new Guid("21789e0e-1737-4545-862d-fc3fbae3bc6d") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3615f116-6534-4566-a6ef-eace03040563"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c912d03f-d631-4004-9481-30e941f4be73", "AQAAAAIAAYagAAAAEJf43FCiqbG6aiHa1j2LHJ7f1boLMtEY6qWrQJQOBW2fg6+DcYojBz2ZyE+Z6uSYxQ==", "4c5a46ea-2c57-46e6-b454-077f5da76ca6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("66f07b70-0485-4740-98fb-7b68c9137db6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3985bae-2101-4de4-8856-4de108d75f7e", "AQAAAAIAAYagAAAAEO+/oMiFvIAZ1EeezVNHulhlLgkeqD/aBPjVarrXr9mAA24uRXjkXvSy354zl0Qg+Q==", "0a9c3078-3035-4da1-a71c-f44137784de3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce4bb7c0-6614-4fdd-b782-5e854ed803e7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b3f3d63-1da4-4b90-90f7-032be9245de7", "AQAAAAIAAYagAAAAEBJYxHpDyUApUeFzYShWJFfWy6k5z2rmTydKpXZ1M5FP6bYFriEH12M+UcvODYLyCQ==", "4d0ab5af-2ef3-4f33-83fa-d76f197e5fff" });

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
        }
    }
}

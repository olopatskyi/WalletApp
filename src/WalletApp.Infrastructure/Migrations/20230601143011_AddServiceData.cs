using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WalletApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddServiceData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("12ed5caa-ed8a-4c43-a33c-e3c1ed0c55be"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("de6b6cc6-5a7d-458b-a90a-846e0ed64a32"));

            migrationBuilder.DeleteData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: new Guid("f2425817-4e26-4e44-934f-a834cf91ef68"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21789e0e-1737-4545-862d-fc3fbae3bc6d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b48bfbff-18c8-45d7-819c-40b8263c2742", "AQAAAAIAAYagAAAAEIaTUeaiyk4/lhnGKmMWVJ79lSPbCbHGy+fb/CTnud+HUUVLAG+gM6FkTFQURNGh1Q==" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21789e0e-1737-4545-862d-fc3fbae3bc6d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b65860f5-d46a-429f-9fd7-66fa67665103", "AQAAAAIAAYagAAAAEPVuMB90SnGqdHBTJoYLf/YFpGnzlJKfJ0oDdX4mE2mGoYEdnQSka0I8WmKv1faBIw==" });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Coefficient", "Status" },
                values: new object[,]
                {
                    { new Guid("12ed5caa-ed8a-4c43-a33c-e3c1ed0c55be"), 0.0, 2 },
                    { new Guid("de6b6cc6-5a7d-458b-a90a-846e0ed64a32"), 0.0, 0 },
                    { new Guid("f2425817-4e26-4e44-934f-a834cf91ef68"), 0.0, 1 }
                });
        }
    }
}

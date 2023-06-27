using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WalletApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRanksData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "77e34a0b-eba4-473b-a407-ab9c8a60458d", "AQAAAAIAAYagAAAAEIavxsAcSVKI1kF0vX0k+F964lXkNQKh96Sn0yycXHL1QTQ6bR+gqnqZJpZqWyM7Gg==" });
        }
    }
}

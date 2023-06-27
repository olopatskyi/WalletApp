using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WalletApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLastName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Barbers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21789e0e-1737-4545-862d-fc3fbae3bc6d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77e34a0b-eba4-473b-a407-ab9c8a60458d", "AQAAAAIAAYagAAAAEIavxsAcSVKI1kF0vX0k+F964lXkNQKh96Sn0yycXHL1QTQ6bR+gqnqZJpZqWyM7Gg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Barbers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21789e0e-1737-4545-862d-fc3fbae3bc6d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d04d5189-8820-4ebe-86a7-9b10f3bc11e1", "AQAAAAIAAYagAAAAEHn104TC4CyKBdK5XPRENnGYFJTAeBaBojx/zEOcPkqTy7lK0CBFOzrfA1IPSucaKg==" });
        }
    }
}

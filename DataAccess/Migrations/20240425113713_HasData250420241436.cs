using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class HasData250420241436 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "BMW" },
                    { 2, true, false, "Mercedes-Benz" },
                    { 3, true, false, "Volvo" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "White" },
                    { 2, true, false, "Gray" },
                    { 3, true, false, "Black" },
                    { 4, true, false, "Red" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "ColorId", "DailyPrice", "Description", "IsActive", "IsDeleted", "ModelYear" },
                values: new object[,]
                {
                    { 1, 1, 3, 3700m, "BMW 520i Sedan 2023 Model", true, false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 1, 4200m, "Mercedes-Benz GLC180 SUV 2024 Model", true, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

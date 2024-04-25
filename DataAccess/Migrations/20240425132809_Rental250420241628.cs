using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Rental250420241628 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "ColorId", "DailyPrice", "Description", "IsActive", "IsDeleted", "ModelYear" },
                values: new object[] { 3, 3, 4, 3500m, "Volvo S90 Sedan 2022 Model", true, false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "ahmettkkahveci@gmail.com", "Ahmet", true, false, "Kahveci", "123456" },
                    { 2, "ebrukucuk024@gmail.com", "Ebru", true, false, "Küçük", "123456" },
                    { 3, "metsinpeace@gmail.com", "Metin", true, false, "Ata", "123456" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "IsActive", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { 1, "Ahmet Lojistik", true, false, 1 },
                    { 2, "Ebru Lojistik", true, false, 2 },
                    { 3, "Metin Lojistik", true, false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "CarId", "CustomerId", "IsActive", "IsDeleted", "RentDate", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, 1, true, false, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, 2, true, false, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, 3, true, false, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

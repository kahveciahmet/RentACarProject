using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseUpdate220520241913 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelYear = table.Column<int>(type: "int", nullable: false),
                    DailyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransmissionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "BMW" },
                    { 2, true, false, "Mercedes-Benz" },
                    { 3, true, false, "Volvo" },
                    { 4, true, false, "Nissan" },
                    { 5, true, false, "Toyota" },
                    { 6, true, false, "Honda" },
                    { 7, true, false, "Ford" },
                    { 8, true, false, "Chevrolet" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "BrandName", "ColorId", "ColorName", "DailyPrice", "Description", "IsActive", "IsDeleted", "ModelYear", "TransmissionType" },
                values: new object[,]
                {
                    { 1, 1, "BMW", 3, "Black", 1500m, "BMW 520i Sedan 2023 Model", true, false, 2023, "Automatic" },
                    { 2, 2, "Mercedes-Benz", 2, "White", 2000m, "Mercedes-Benz GLC180 SUV 2024 Model", true, false, 2024, "Automatic" },
                    { 3, 3, "Volvo", 4, "Red", 1800m, "Volvo S90 Sedan 2022 Model", true, false, 2022, "Automatic" },
                    { 4, 4, "Nissan", 5, "Midnight Purple", 2500m, "Nissan GT-R R35 2016 Model", true, false, 2024, "Automatic" },
                    { 5, 5, "Toyota", 1, "White", 1200m, "Toyota Corolla 2023 Model", true, false, 2023, "Manual" },
                    { 6, 6, "Honda", 2, "Gray", 1300m, "Honda Civic 2021 Model", true, false, 2021, "Automatic" },
                    { 7, 7, "Ford", 3, "Black", 1400m, "Ford Focus 2020 Model", true, false, 2020, "Manual" },
                    { 8, 8, "Chevrolet", 4, "Red", 1600m, "Chevrolet Malibu 2019 Model", true, false, 2019, "Automatic" },
                    { 9, 1, "BMW", 5, "Midnight Purple", 1500m, "BMW 320i 2018 Model", true, false, 2018, "Automatic" },
                    { 10, 2, "Mercedes-Benz", 1, "White", 1400m, "Mercedes-Benz C180 2017 Model", true, false, 2017, "Automatic" },
                    { 11, 3, "Volvo", 2, "Gray", 1300m, "Volvo XC60 2016 Model", true, false, 2016, "Automatic" },
                    { 12, 4, "Nissan", 3, "Black", 1200m, "Nissan Altima 2015 Model", true, false, 2015, "Manual" },
                    { 13, 5, "Toyota", 4, "Red", 1300m, "Toyota Camry 2014 Model", true, false, 2014, "Automatic" },
                    { 14, 6, "Honda", 5, "Midnight Purple", 1100m, "Honda Accord 2013 Model", true, false, 2013, "Manual" },
                    { 15, 7, "Ford", 1, "White", 1400m, "Ford Mustang 2012 Model", true, false, 2012, "Manual" },
                    { 16, 8, "Chevrolet", 2, "Gray", 1200m, "Chevrolet Cruze 2011 Model", true, false, 2011, "Automatic" },
                    { 17, 1, "BMW", 3, "Black", 1500m, "BMW X5 2010 Model", true, false, 2010, "Automatic" },
                    { 18, 2, "Mercedes-Benz", 4, "Red", 1400m, "Mercedes-Benz E200 2009 Model", true, false, 2009, "Automatic" },
                    { 19, 3, "Volvo", 5, "Midnight Purple", 1300m, "Volvo V60 2008 Model", true, false, 2008, "Automatic" },
                    { 20, 4, "Nissan", 1, "White", 1100m, "Nissan Sentra 2007 Model", true, false, 2007, "Manual" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "White" },
                    { 2, true, false, "Gray" },
                    { 3, true, false, "Black" },
                    { 4, true, false, "Red" },
                    { 5, true, false, "Midnight Purple" },
                    { 6, true, false, "Blue" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "IsActive", "IsDeleted", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, "Ahmet Lojistik", true, false, 1, "Ahmet Kahveci" },
                    { 2, "Ebru Lojistik", true, false, 2, "Ebru Küçük" },
                    { 3, "Metin Lojistik", true, false, 3, "Metin Ata" },
                    { 4, "Berkay Lojistik", true, false, 4, "Berkay Çamur" }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "admin" },
                    { 2, "moderator" },
                    { 3, "user" },
                    { 4, "car.add" },
                    { 5, "car.delete" },
                    { 6, "car.update" },
                    { 7, "brand.add" },
                    { 8, "brand.delete" },
                    { 9, "brand.update" },
                    { 10, "color.add" },
                    { 11, "color.delete" },
                    { 12, "color.update" },
                    { 13, "rental.add" },
                    { 14, "rental.delete" },
                    { 15, "rental.update" },
                    { 16, "carimage.add" },
                    { 17, "carimage.delete" },
                    { 18, "carimage.update" },
                    { 19, "user.add" },
                    { 20, "user.delete" },
                    { 21, "user.update" },
                    { 22, "customer.add" },
                    { 23, "customer.delete" },
                    { 24, "customer.update" }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "CarId", "CarName", "CustomerId", "CustomerName", "IsActive", "IsDeleted", "RentDate", "ReturnDate" },
                values: new object[,]
                {
                    { 9, 4, "Nissan GT-R R35 2016 Model", 1, "Ahmet Lojistik", true, false, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 3, "Volvo S90 Sedan 2022 Model", 2, "Ebru Lojistik", true, false, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 2, "Mercedes-Benz GLC180 SUV 2024 Model", 3, "Metin Lojistik", true, false, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, "BMW 520i Sedan 2023 Model", 4, "Berkay Lojistik", true, false, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "OperationClaimId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 4, 1 },
                    { 3, 5, 1 },
                    { 4, 6, 1 },
                    { 5, 3, 2 },
                    { 6, 3, 3 },
                    { 7, 3, 4 },
                    { 8, 10, 1 },
                    { 9, 11, 1 },
                    { 10, 12, 1 },
                    { 11, 13, 1 },
                    { 12, 14, 1 },
                    { 13, 15, 1 },
                    { 14, 16, 1 },
                    { 15, 17, 1 },
                    { 16, 18, 1 },
                    { 17, 19, 1 },
                    { 18, 20, 1 },
                    { 19, 21, 1 },
                    { 20, 22, 1 },
                    { 21, 23, 1 },
                    { 22, 24, 1 },
                    { 23, 7, 1 },
                    { 24, 8, 1 },
                    { 25, 9, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[,]
                {
                    { 1, "ahmettkkahveci@gmail.com", "Ahmet", true, false, "Kahveci", new byte[] { 175, 198, 47, 227, 211, 103, 52, 64, 31, 40, 44, 113, 214, 121, 228, 163, 150, 23, 229, 57, 187, 46, 60, 134, 89, 12, 155, 160, 95, 243, 174, 89, 232, 150, 168, 76, 144, 189, 81, 174, 143, 170, 217, 13, 183, 92, 39, 235, 128, 217, 91, 31, 145, 71, 223, 38, 170, 131, 52, 88, 38, 28, 55, 65 }, new byte[] { 221, 39, 132, 141, 87, 197, 53, 178, 234, 192, 111, 104, 213, 136, 198, 241, 91, 139, 86, 253, 90, 80, 47, 47, 150, 210, 204, 61, 244, 179, 196, 230, 15, 174, 1, 47, 120, 88, 159, 202, 193, 4, 130, 160, 72, 95, 176, 50, 2, 219, 142, 89, 182, 57, 24, 252, 80, 149, 42, 135, 62, 72, 204, 51, 1, 47, 2, 232, 57, 48, 119, 191, 126, 165, 152, 214, 243, 111, 241, 252, 233, 235, 80, 24, 53, 41, 177, 254, 148, 116, 198, 144, 152, 154, 61, 53, 202, 137, 190, 171, 215, 230, 196, 239, 105, 189, 207, 236, 185, 63, 181, 30, 217, 167, 2, 135, 73, 206, 169, 175, 135, 62, 69, 224, 4, 133, 9, 199 }, true },
                    { 2, "ebrukucuk024@gmail.com", "Ebru", true, false, "Küçük", new byte[] { 47, 158, 19, 251, 64, 70, 166, 164, 153, 61, 20, 193, 234, 0, 213, 127, 121, 226, 140, 131, 70, 90, 184, 116, 225, 59, 122, 249, 147, 2, 97, 9, 218, 182, 80, 41, 231, 136, 47, 46, 163, 126, 197, 170, 182, 34, 252, 201, 223, 226, 116, 49, 74, 34, 98, 173, 46, 41, 103, 229, 89, 201, 72, 202 }, new byte[] { 41, 54, 231, 38, 152, 210, 136, 228, 166, 196, 75, 252, 77, 216, 177, 18, 97, 222, 245, 244, 255, 108, 191, 14, 195, 50, 87, 45, 235, 104, 109, 49, 145, 34, 117, 15, 147, 106, 109, 167, 199, 89, 26, 109, 127, 83, 197, 172, 138, 99, 51, 210, 212, 183, 153, 138, 66, 157, 60, 23, 102, 1, 143, 139, 159, 74, 186, 188, 30, 61, 251, 165, 111, 11, 152, 147, 198, 209, 147, 222, 176, 241, 165, 118, 49, 38, 124, 46, 17, 164, 79, 144, 32, 196, 219, 139, 78, 244, 49, 156, 132, 150, 136, 23, 88, 107, 111, 97, 188, 54, 167, 46, 117, 137, 167, 6, 94, 62, 139, 80, 164, 10, 169, 38, 2, 249, 223, 254, 0 }, false },
                    { 3, "metsinpeace@gmail.com", "Metin", true, false, "Ata", new byte[] { 34, 2, 97, 251, 3, 210, 159, 44, 116, 81, 183, 58, 130, 181, 170, 14, 80, 250, 6, 66, 252, 23, 179, 231, 60, 97, 104, 39, 166, 206, 189, 71, 176, 240, 103, 205, 229, 155, 100, 252, 24, 67, 139, 7, 30, 43, 218, 250, 207, 172, 41, 171, 244, 56, 3, 225, 158, 40, 171, 232, 106, 132, 22, 7, 108, 9 }, new byte[] { 58, 129, 41, 142, 86, 59, 33, 69, 90, 95, 196, 156, 67, 159, 11, 83, 17, 203, 51, 252, 11, 23, 14, 58, 112, 112, 4, 250, 71, 30, 148, 73, 179, 3, 187, 54, 95, 32, 88, 170, 215, 220, 179, 106, 127, 213, 38, 34, 27, 191, 248, 129, 191, 108, 112, 92, 251, 28, 112, 92, 251, 28, 218, 229, 106, 237, 14, 136, 37, 10, 197, 109, 86, 213, 110, 52, 141, 115, 89, 161, 115, 239, 128, 14, 132, 6, 224, 133, 176, 33, 13, 170, 240, 118, 5, 104, 167, 218, 141, 86, 74, 16, 7, 83, 1, 238, 243, 176, 28, 245, 214, 8, 181, 35, 242, 248, 89, 112, 231, 202, 135, 173, 88, 164, 184, 6, 151, 138, 226, 151, 120, 61, 153, 1 }, false },
                    { 4, "berkaycamur61@gmail.com", "Berkay", true, false, "Çamur", new byte[] { 219, 85, 24, 68, 1, 206, 21, 175, 251, 8, 53, 239, 63, 35, 243, 18, 228, 18, 238, 94, 235, 68, 9, 109, 28, 185, 4, 228, 117, 76, 77, 159, 176, 155, 228, 107, 180, 118, 78, 59, 162, 67, 245, 120, 105, 44, 17, 100, 246, 235, 134, 248, 43, 156, 201, 226, 196, 42, 176, 147, 40, 236, 8, 66 }, new byte[] { 136, 89, 10, 67, 60, 35, 43, 23, 236, 223, 132, 127, 105, 112, 216, 131, 171, 244, 148, 25, 103, 219, 135, 177, 158, 18, 247, 140, 245, 123, 214, 39, 33, 243, 153, 69, 220, 166, 82, 22, 49, 127, 94, 103, 1, 100, 185, 247, 136, 129, 171, 61, 159, 6, 170, 69, 239, 82, 127, 232, 141, 199, 3, 138, 156, 197, 248, 180, 104, 81, 180, 128, 151, 187, 151, 218, 42, 23, 176, 227, 232, 93, 47, 174, 91, 253, 93, 6, 153, 230, 192, 52, 56, 181, 68, 125, 71, 20, 45, 56, 6, 45, 83, 217, 232, 228, 39, 21, 124, 34, 219, 41, 3, 55, 224, 239, 238, 110, 114, 244, 24, 244, 203, 161, 119, 192, 250, 209 }, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "CarImages");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(RentACarDB))]
    [Migration("20240513141223_OperationClaim130520241712")]
    partial class OperationClaim130520241712
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "moderator"
                        },
                        new
                        {
                            Id = 3,
                            Name = "user"
                        },
                        new
                        {
                            Id = 4,
                            Name = "car.add"
                        },
                        new
                        {
                            Id = 5,
                            Name = "car.delete"
                        },
                        new
                        {
                            Id = 6,
                            Name = "car.update"
                        },
                        new
                        {
                            Id = 7,
                            Name = "brand.add"
                        },
                        new
                        {
                            Id = 8,
                            Name = "brand.delete"
                        },
                        new
                        {
                            Id = 9,
                            Name = "brand.update"
                        },
                        new
                        {
                            Id = 10,
                            Name = "color.add"
                        },
                        new
                        {
                            Id = 11,
                            Name = "color.delete"
                        },
                        new
                        {
                            Id = 12,
                            Name = "color.update"
                        },
                        new
                        {
                            Id = 13,
                            Name = "rental.add"
                        },
                        new
                        {
                            Id = 14,
                            Name = "rental.delete"
                        },
                        new
                        {
                            Id = 15,
                            Name = "rental.update"
                        },
                        new
                        {
                            Id = 16,
                            Name = "carimage.add"
                        },
                        new
                        {
                            Id = 17,
                            Name = "carimage.delete"
                        },
                        new
                        {
                            Id = 18,
                            Name = "carimage.update"
                        },
                        new
                        {
                            Id = 19,
                            Name = "user.add"
                        },
                        new
                        {
                            Id = 20,
                            Name = "user.delete"
                        },
                        new
                        {
                            Id = 21,
                            Name = "user.update"
                        },
                        new
                        {
                            Id = 22,
                            Name = "customer.add"
                        },
                        new
                        {
                            Id = 23,
                            Name = "customer.delete"
                        },
                        new
                        {
                            Id = 24,
                            Name = "customer.update"
                        });
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ahmettkkahveci@gmail.com",
                            FirstName = "Ahmet",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Kahveci",
                            PasswordHash = new byte[] { 175, 198, 47, 227, 211, 103, 52, 64, 31, 40, 44, 113, 214, 121, 228, 163, 150, 23, 229, 57, 187, 46, 60, 134, 89, 12, 155, 160, 95, 243, 174, 89, 232, 150, 168, 76, 144, 189, 81, 174, 143, 170, 217, 13, 183, 92, 39, 235, 128, 217, 91, 31, 145, 71, 223, 38, 170, 131, 52, 88, 38, 28, 55, 65 },
                            PasswordSalt = new byte[] { 221, 39, 132, 141, 87, 197, 53, 178, 234, 192, 111, 104, 213, 136, 198, 241, 91, 139, 86, 253, 90, 80, 47, 47, 150, 210, 204, 61, 244, 179, 196, 230, 15, 174, 1, 47, 120, 88, 159, 202, 193, 4, 130, 160, 72, 95, 176, 50, 2, 219, 142, 89, 182, 57, 24, 252, 80, 149, 42, 135, 62, 72, 204, 51, 1, 47, 2, 232, 57, 48, 119, 191, 126, 165, 152, 214, 243, 111, 241, 252, 233, 235, 80, 24, 53, 41, 177, 254, 148, 116, 198, 144, 152, 154, 61, 53, 202, 137, 190, 171, 215, 230, 196, 239, 105, 189, 207, 236, 185, 63, 181, 30, 217, 167, 2, 135, 73, 206, 169, 175, 135, 62, 69, 224, 4, 133, 9, 199 },
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Email = "ebrukucuk024@gmail.com",
                            FirstName = "Ebru",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Küçük",
                            PasswordHash = new byte[] { 47, 158, 19, 251, 64, 70, 166, 164, 153, 61, 20, 193, 234, 0, 213, 127, 121, 226, 140, 131, 70, 90, 184, 116, 225, 59, 122, 249, 147, 2, 97, 9, 218, 182, 80, 41, 231, 136, 47, 46, 163, 126, 197, 170, 182, 34, 252, 201, 223, 226, 116, 49, 74, 34, 98, 173, 46, 41, 103, 229, 89, 201, 72, 202 },
                            PasswordSalt = new byte[] { 41, 54, 231, 38, 152, 210, 136, 228, 166, 196, 75, 252, 77, 216, 177, 18, 97, 222, 245, 244, 255, 108, 191, 14, 195, 50, 87, 45, 235, 104, 109, 49, 145, 34, 117, 15, 147, 106, 109, 167, 199, 89, 26, 109, 127, 83, 197, 172, 138, 99, 51, 210, 212, 183, 153, 138, 66, 157, 60, 23, 102, 1, 143, 139, 159, 74, 186, 188, 30, 61, 251, 165, 111, 11, 152, 147, 198, 209, 147, 222, 176, 241, 165, 118, 49, 38, 124, 46, 17, 164, 79, 144, 32, 196, 219, 139, 78, 244, 49, 156, 132, 150, 136, 23, 88, 107, 111, 97, 188, 54, 167, 46, 117, 137, 167, 6, 94, 62, 139, 80, 164, 10, 169, 38, 2, 249, 223, 254, 0 },
                            Status = false
                        },
                        new
                        {
                            Id = 3,
                            Email = "metsinpeace@gmail.com",
                            FirstName = "Metin",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Ata",
                            PasswordHash = new byte[] { 34, 2, 97, 251, 3, 210, 159, 44, 116, 81, 183, 58, 130, 181, 170, 14, 80, 250, 6, 66, 252, 23, 179, 231, 60, 97, 104, 39, 166, 206, 189, 71, 176, 240, 103, 205, 229, 155, 100, 252, 24, 67, 139, 7, 30, 43, 218, 250, 207, 172, 41, 171, 244, 56, 3, 225, 158, 40, 171, 232, 106, 132, 22, 7, 108, 9 },
                            PasswordSalt = new byte[] { 58, 129, 41, 142, 86, 59, 33, 69, 90, 95, 196, 156, 67, 159, 11, 83, 17, 203, 51, 252, 11, 23, 14, 58, 112, 112, 4, 250, 71, 30, 148, 73, 179, 3, 187, 54, 95, 32, 88, 170, 215, 220, 179, 106, 127, 213, 38, 34, 27, 191, 248, 129, 191, 108, 112, 92, 251, 28, 112, 92, 251, 28, 218, 229, 106, 237, 14, 136, 37, 10, 197, 109, 86, 213, 110, 52, 141, 115, 89, 161, 115, 239, 128, 14, 132, 6, 224, 133, 176, 33, 13, 170, 240, 118, 5, 104, 167, 218, 141, 86, 74, 16, 7, 83, 1, 238, 243, 176, 28, 245, 214, 8, 181, 35, 242, 248, 89, 112, 231, 202, 135, 173, 88, 164, 184, 6, 151, 138, 226, 151, 120, 61, 153, 1 },
                            Status = false
                        },
                        new
                        {
                            Id = 4,
                            Email = "berkaycamur61@gmail.com",
                            FirstName = "Berkay",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Çamur",
                            PasswordHash = new byte[] { 219, 85, 24, 68, 1, 206, 21, 175, 251, 8, 53, 239, 63, 35, 243, 18, 228, 18, 238, 94, 235, 68, 9, 109, 28, 185, 4, 228, 117, 76, 77, 159, 176, 155, 228, 107, 180, 118, 78, 59, 162, 67, 245, 120, 105, 44, 17, 100, 246, 235, 134, 248, 43, 156, 201, 226, 196, 42, 176, 147, 40, 236, 8, 66 },
                            PasswordSalt = new byte[] { 136, 89, 10, 67, 60, 35, 43, 23, 236, 223, 132, 127, 105, 112, 216, 131, 171, 244, 148, 25, 103, 219, 135, 177, 158, 18, 247, 140, 245, 123, 214, 39, 33, 243, 153, 69, 220, 166, 82, 22, 49, 127, 94, 103, 1, 100, 185, 247, 136, 129, 171, 61, 159, 6, 170, 69, 239, 82, 127, 232, 141, 199, 3, 138, 156, 197, 248, 180, 104, 81, 180, 128, 151, 187, 151, 218, 42, 23, 176, 227, 232, 93, 47, 174, 91, 253, 93, 6, 153, 230, 192, 52, 56, 181, 68, 125, 71, 20, 45, 56, 6, 45, 83, 217, 232, 228, 39, 21, 124, 34, 219, 41, 3, 55, 224, 239, 238, 110, 114, 244, 24, 244, 203, 161, 119, 192, 250, 209 },
                            Status = false
                        });
                });

            modelBuilder.Entity("Core.Entities.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserOperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OperationClaimId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            OperationClaimId = 4,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            OperationClaimId = 5,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            OperationClaimId = 6,
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            OperationClaimId = 3,
                            UserId = 2
                        },
                        new
                        {
                            Id = 6,
                            OperationClaimId = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 7,
                            OperationClaimId = 3,
                            UserId = 4
                        },
                        new
                        {
                            Id = 8,
                            OperationClaimId = 10,
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            OperationClaimId = 11,
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            OperationClaimId = 12,
                            UserId = 1
                        },
                        new
                        {
                            Id = 11,
                            OperationClaimId = 13,
                            UserId = 1
                        },
                        new
                        {
                            Id = 12,
                            OperationClaimId = 14,
                            UserId = 1
                        },
                        new
                        {
                            Id = 13,
                            OperationClaimId = 15,
                            UserId = 1
                        },
                        new
                        {
                            Id = 14,
                            OperationClaimId = 16,
                            UserId = 1
                        },
                        new
                        {
                            Id = 15,
                            OperationClaimId = 17,
                            UserId = 1
                        },
                        new
                        {
                            Id = 16,
                            OperationClaimId = 18,
                            UserId = 1
                        },
                        new
                        {
                            Id = 17,
                            OperationClaimId = 19,
                            UserId = 1
                        },
                        new
                        {
                            Id = 18,
                            OperationClaimId = 20,
                            UserId = 1
                        },
                        new
                        {
                            Id = 19,
                            OperationClaimId = 21,
                            UserId = 1
                        },
                        new
                        {
                            Id = 20,
                            OperationClaimId = 22,
                            UserId = 1
                        },
                        new
                        {
                            Id = 21,
                            OperationClaimId = 23,
                            UserId = 1
                        },
                        new
                        {
                            Id = 22,
                            OperationClaimId = 24,
                            UserId = 1
                        },
                        new
                        {
                            Id = 23,
                            OperationClaimId = 7,
                            UserId = 1
                        },
                        new
                        {
                            Id = 24,
                            OperationClaimId = 8,
                            UserId = 1
                        },
                        new
                        {
                            Id = 25,
                            OperationClaimId = 9,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Mercedes-Benz"
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Volvo"
                        },
                        new
                        {
                            Id = 4,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Nissan"
                        });
                });

            modelBuilder.Entity("Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<decimal>("DailyPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModelYear")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            ColorId = 3,
                            DailyPrice = 3700m,
                            Description = "BMW 520i Sedan 2023 Model",
                            IsActive = true,
                            IsDeleted = false,
                            ModelYear = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            ColorId = 1,
                            DailyPrice = 4200m,
                            Description = "Mercedes-Benz GLC180 SUV 2024 Model",
                            IsActive = true,
                            IsDeleted = false,
                            ModelYear = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 3,
                            ColorId = 4,
                            DailyPrice = 3500m,
                            Description = "Volvo S90 Sedan 2022 Model",
                            IsActive = true,
                            IsDeleted = false,
                            ModelYear = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 4,
                            ColorId = 5,
                            DailyPrice = 6000m,
                            Description = "Nissan GT-R R35 2016 Model",
                            IsActive = true,
                            IsDeleted = false,
                            ModelYear = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entities.CarImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarImages");
                });

            modelBuilder.Entity("Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "White"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Gray"
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Black"
                        },
                        new
                        {
                            Id = 4,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Red"
                        },
                        new
                        {
                            Id = 5,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Midnight Purple"
                        });
                });

            modelBuilder.Entity("Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Ahmet Lojistik",
                            IsActive = true,
                            IsDeleted = false,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Ebru Lojistik",
                            IsActive = true,
                            IsDeleted = false,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "Metin Lojistik",
                            IsActive = true,
                            IsDeleted = false,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            CompanyName = "Berkay Lojistik",
                            IsActive = true,
                            IsDeleted = false,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Entities.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Rentals");

                    b.HasData(
                        new
                        {
                            Id = 9,
                            CarId = 4,
                            CustomerId = 1,
                            IsActive = true,
                            IsDeleted = false,
                            RentDate = new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CarId = 3,
                            CustomerId = 2,
                            IsActive = true,
                            IsDeleted = false,
                            RentDate = new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            CarId = 2,
                            CustomerId = 3,
                            IsActive = true,
                            IsDeleted = false,
                            RentDate = new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            CarId = 1,
                            CustomerId = 4,
                            IsActive = true,
                            IsDeleted = false,
                            RentDate = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

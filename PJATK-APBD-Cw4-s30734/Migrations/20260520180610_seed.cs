using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PJATK_APBD_Cw4_s30734.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ComponentManufacturers",
                columns: new[] { "Id", "Abbreviation", "FoundationDate", "FullName" },
                values: new object[,]
                {
                    { 1, "INT", new DateOnly(1968, 7, 18), "Intel Corporation" },
                    { 2, "AMD", new DateOnly(1969, 5, 1), "Advanced Micro Devices" },
                    { 3, "NVDA", new DateOnly(1993, 4, 5), "Nvidia Corporation" },
                    { 4, "ASUS", new DateOnly(1989, 4, 2), "ASUSTeK Computer Inc." },
                    { 5, "MSI", new DateOnly(1986, 8, 4), "Micro-Star International" }
                });

            migrationBuilder.InsertData(
                table: "ComponentsTypes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { 1, "CPU", "Central Processing Unit" },
                    { 2, "GPU", "Graphics Processing Unit" },
                    { 3, "MB", "Motherboard" },
                    { 4, "RAM", "Random Access Memory" },
                    { 5, "PSU", "Power Supply Unit" }
                });

            migrationBuilder.InsertData(
                table: "PCs",
                columns: new[] { "Id", "CreatedAt", "Name", "Stock", "Warranty", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gamer Pro X", 10, 24, 15.5f },
                    { 2, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Office Workstation", 50, 12, 8.2f },
                    { 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creator Studio 9000", 5, 36, 18f },
                    { 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Budget Gamer", 20, 24, 12.1f },
                    { 5, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Home Media PC", 15, 12, 10f }
                });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Code", "ComponentManufacturersId", "ComponentTypesId", "Description", "Name" },
                values: new object[,]
                {
                    { "COMP-00001", 1, 1, "High-end CPU", "Intel Core i9-13900K" },
                    { "COMP-00002", 2, 1, "High-end CPU", "AMD Ryzen 9 7950X" },
                    { "COMP-00003", 3, 2, "High-end GPU", "Nvidia RTX 4090" },
                    { "COMP-00004", 4, 3, "High-end Motherboard", "ASUS ROG MAXIMUS Z790 HERO" },
                    { "COMP-00005", 5, 3, "Mid-range Motherboard", "MSI MPG B650 CARBON" }
                });

            migrationBuilder.InsertData(
                table: "PCComponents",
                columns: new[] { "ComponentCode", "PCId", "Amount" },
                values: new object[,]
                {
                    { "COMP-00001", 1, 1 },
                    { "COMP-00003", 1, 1 },
                    { "COMP-00002", 2, 1 },
                    { "COMP-00004", 3, 1 },
                    { "COMP-00005", 4, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComponentsTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ComponentsTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "COMP-00001", 1 });

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "COMP-00003", 1 });

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "COMP-00002", 2 });

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "COMP-00004", 3 });

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "COMP-00005", 4 });

            migrationBuilder.DeleteData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "COMP-00001");

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "COMP-00002");

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "COMP-00003");

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "COMP-00004");

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "COMP-00005");

            migrationBuilder.DeleteData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ComponentManufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ComponentManufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ComponentManufacturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ComponentManufacturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ComponentManufacturers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ComponentsTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ComponentsTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ComponentsTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

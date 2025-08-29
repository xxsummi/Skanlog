using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Activity2.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("75ca3ee7-652e-49b5-8888-fde0d78d8f1f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("77356cd1-b1cd-49cd-a2cf-5732eeb4b36a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("79f5d023-5414-4862-a28a-10e7d6cd1270"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "IsDeleted", "Name", "PagIbigNumber", "Position", "SSSNumber", "Salary" },
                values: new object[,]
                {
                    { new Guid("58b06f23-3540-48cb-835b-cf2520a7f01c"), "jeskhasamanthaderama@gmail.com", false, "Summi Derama", "21101228", "Developer", "21101228", 28000.0 },
                    { new Guid("74e2e28a-e237-4d2e-89da-4f633854ac95"), "jansenchoi@gmail.com", false, "Jansen Choi", "21101228", "Scrum Master", "21101228", 28000.0 },
                    { new Guid("79951851-4769-4125-acd8-cf06d7107a2b"), "joshlui@gmail.com", false, "Josh Lui", "21101228", "Project Owner", "21101228", 28000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("58b06f23-3540-48cb-835b-cf2520a7f01c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("74e2e28a-e237-4d2e-89da-4f633854ac95"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("79951851-4769-4125-acd8-cf06d7107a2b"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "IsDeleted", "Name", "PagIbigNumber", "Position", "SSSNumber", "Salary" },
                values: new object[,]
                {
                    { new Guid("75ca3ee7-652e-49b5-8888-fde0d78d8f1f"), "jeskhasamanthaderama@gmail.com", false, "Summi Derama", "21101228", "Developer", "21101228", 28000.0 },
                    { new Guid("77356cd1-b1cd-49cd-a2cf-5732eeb4b36a"), "jansenchoi@gmail.com", false, "Jansen Choi", "21101228", "Scrum Master", "21101228", 28000.0 },
                    { new Guid("79f5d023-5414-4862-a28a-10e7d6cd1270"), "joshlui@gmail.com", false, "Josh Lui", "21101228", "Project Owner", "21101228", 28000.0 }
                });
        }
    }
}

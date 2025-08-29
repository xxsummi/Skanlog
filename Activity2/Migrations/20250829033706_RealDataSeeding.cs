using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Activity2.Migrations
{
    /// <inheritdoc />
    public partial class RealDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("20176a93-4603-4cce-9d1b-884d8b3bfea6"), "joshlui@gmail.com", false, "Josh Lui", "21101228", "Project Owner", "21101228", 28000.0 },
                    { new Guid("e1c93f76-c6a4-4b1a-b423-aa7c5e1a2005"), "jansenchoi@gmail.com", false, "Jansen Choi", "21101228", "Scrum Master", "21101228", 28000.0 },
                    { new Guid("fafe3893-193c-4e84-9001-ffe1f478e914"), "jeskhasamanthaderama@gmail.com", false, "Summi Derama", "21101228", "Developer", "21101228", 28000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("20176a93-4603-4cce-9d1b-884d8b3bfea6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e1c93f76-c6a4-4b1a-b423-aa7c5e1a2005"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fafe3893-193c-4e84-9001-ffe1f478e914"));

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
    }
}

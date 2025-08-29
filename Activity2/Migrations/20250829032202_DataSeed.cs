using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Activity2.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("102441c3-1d91-4351-978e-d2f4eed95e77"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7a877bb7-ad4b-448b-bfd3-f6d85910f798"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("aae6d8f1-f6f6-4a0c-9651-cd988730387a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("102441c3-1d91-4351-978e-d2f4eed95e77"), "jeskhasamanthaderama@gmail.com", false, "Summi Derama", "21101228", "Developer", "21101228", 28000.0 },
                    { new Guid("7a877bb7-ad4b-448b-bfd3-f6d85910f798"), "jansenchoi@gmail.com", false, "Jansen Choi", "21101228", "Scrum Master", "21101228", 28000.0 },
                    { new Guid("aae6d8f1-f6f6-4a0c-9651-cd988730387a"), "joshlui@gmail.com", false, "Josh Lui", "21101228", "Project Owner", "21101228", 28000.0 }
                });
        }
    }
}

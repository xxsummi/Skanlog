using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Activity2.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

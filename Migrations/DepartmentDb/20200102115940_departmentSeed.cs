using Microsoft.EntityFrameworkCore.Migrations;

namespace EFExample.Migrations.DepartmentDb
{
    public partial class departmentSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DeptId", "DeptLocation", "DeptManager", "DeptName" },
                values: new object[] { 1, "Hyderabad", "PadmaRaju Sir", "CSE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 1);
        }
    }
}

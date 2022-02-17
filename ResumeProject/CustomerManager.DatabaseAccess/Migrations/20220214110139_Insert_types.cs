using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerManager.DatabaseAccess.Migrations
{
    public partial class Insert_types : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Name" },
                values: new object[] { "Active" }
                );
            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Name" },
                values: new object[] { "Potential" }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Name",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Name",
                keyValue: 2);
        }
    }
}

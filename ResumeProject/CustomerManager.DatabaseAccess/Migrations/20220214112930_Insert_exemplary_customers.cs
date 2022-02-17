using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerManager.DatabaseAccess.Migrations
{
    public partial class Insert_exemplary_customers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Customers",
            columns: new[] { "Name", "NIP", "TypeId", "Description", "Status" },
            values: new object[] { "DPS Software sp. z o.o.", "9511634331", 1, "DPS Software dystrybutor oprogramowania CAD/CAM/CAE/PDM/ERP dla przemysłu i edukacji.", true });

            migrationBuilder.InsertData(
            table: "Customers",
            columns: new[] { "Name", "NIP", "TypeId", "Description", "Status" },
            values: new object[] { "HP Polska sp. z o.o.", "7251020699", 2, "Sklep HP - autoryzowany Partner w Polsce. Komputery i laptopy HP w atrakcyjnych cenach", false });

            migrationBuilder.InsertData(
            table: "Customers",
            columns: new[] { "Name", "NIP", "TypeId", "Description", "Status" },
            values: new object[] { "XYZ Company", "1234567890", 1, "Przykładowy opis firmy", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

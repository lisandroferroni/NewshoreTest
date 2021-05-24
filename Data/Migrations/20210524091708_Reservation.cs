using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "Mail", "Name", "Number" },
                values: new object[] { 1, "jperez@gmail.com", "Juan Perez", 5493416335598L });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "Mail", "Name", "Number" },
                values: new object[] { 2, "mgarcia@gmail.com", "Manuel Garcia", 5493415887744L });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "Mail", "Name", "Number" },
                values: new object[] { 3, "alberto@gmail.com", "Alberto Perez", 5493415847744L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

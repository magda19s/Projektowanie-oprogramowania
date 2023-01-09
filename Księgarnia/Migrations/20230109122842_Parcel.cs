using Microsoft.EntityFrameworkCore.Migrations;

namespace Księgarnia.Migrations
{
    public partial class Parcel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "ParcelLockers");

            migrationBuilder.DropColumn(
                name: "NumberStreet",
                table: "ParcelLockers");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "ParcelLockers");

            migrationBuilder.RenameColumn(
                name: "idRegion",
                table: "ParcelLockers",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "ul. Wyszyńskiego 10 50-323 Wrocław");

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Address",
                value: "ul. Główna 30 50-323 Wrocław");

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Address",
                value: "ul. Orzeszkowej 61 50-453 Wrocław");

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Address",
                value: "ul. Pszenna 20 50-323 Wrocław");

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Address",
                value: "ul.Tęczowa 11 50-323 Wrocław");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "ParcelLockers",
                newName: "idRegion");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "ParcelLockers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberStreet",
                table: "ParcelLockers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "ParcelLockers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "NumberStreet", "Street", "idRegion" },
                values: new object[] { "Wrocław", 10, "ul. Wyszyńskiego", "50-323" });

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "NumberStreet", "Street", "idRegion" },
                values: new object[] { "Wrocław", 31, "ul. Główna", "50-423" });

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "NumberStreet", "Street", "idRegion" },
                values: new object[] { "Wrocław", 61, "ul. Pszenna", "50-423" });

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "NumberStreet", "Street", "idRegion" },
                values: new object[] { "Wrocław", 101, "ul. Tęczowa", "50-733" });

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "NumberStreet", "Street", "idRegion" },
                values: new object[] { "Wrocław", 61, "ul. Orzeszkowej", "50-423" });
        }
    }
}

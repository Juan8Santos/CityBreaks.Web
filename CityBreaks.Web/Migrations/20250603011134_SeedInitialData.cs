using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CityBreaks.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Cities_CityId",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "PricePerNight",
                table: "Properties",
                newName: "pricePerNight");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Properties",
                newName: "cityId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Properties",
                newName: "propertyName");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_CityId",
                table: "Properties",
                newName: "IX_Properties_cityId");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Countries",
                newName: "countryName");

            migrationBuilder.RenameColumn(
                name: "CountryCode",
                table: "Countries",
                newName: "countryCode");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cities",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Cities",
                newName: "countryId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                newName: "IX_Cities_countryId");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "countryCode", "countryName" },
                values: new object[,]
                {
                    { 1, "BR", "Brasil" },
                    { 2, "AL", "Alemanha" },
                    { 3, "NG", "Papua-Nova Guiné" },
                    { 4, "FR", "França" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "countryId", "name" },
                values: new object[,]
                {
                    { 1, 1, "Rio de Janeiro" },
                    { 2, 2, "Berlim" },
                    { 3, 3, "Port Moresby" },
                    { 4, 4, "Paris" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "cityId", "propertyName", "pricePerNight" },
                values: new object[,]
                {
                    { 1, 1, "Copacabana Palace", 3420.00m },
                    { 2, 2, "Adlon Kempinski Berlin", 2343.00m },
                    { 3, 3, "Hilton Port Moresby", 1004.00m },
                    { 4, 4, "Cheval Blanc Paris", 18330.00m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_countryId",
                table: "Cities",
                column: "countryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Cities_cityId",
                table: "Properties",
                column: "cityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_countryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Cities_cityId",
                table: "Properties");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "pricePerNight",
                table: "Properties",
                newName: "PricePerNight");

            migrationBuilder.RenameColumn(
                name: "cityId",
                table: "Properties",
                newName: "CityId");

            migrationBuilder.RenameColumn(
                name: "propertyName",
                table: "Properties",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_cityId",
                table: "Properties",
                newName: "IX_Properties_CityId");

            migrationBuilder.RenameColumn(
                name: "countryName",
                table: "Countries",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "countryCode",
                table: "Countries",
                newName: "CountryCode");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Cities",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "countryId",
                table: "Cities",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_countryId",
                table: "Cities",
                newName: "IX_Cities_CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Cities_CityId",
                table: "Properties",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyShopper.Migrations
{
    public partial class seedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 1, "Reddis", "Cool and soft", "Eskimo boots", "images/products/boots-reddis.png", 485L, 100, "Boots" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 2, "Nike", "Cool fashion", "Nike Hoodie", "images/products/hoodie.png", 485L, 332, "Hoodie" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 3, "Chinatown", "Very effective", "Chinese Chop Sticks", "images/products/chopsticks.png", 113L, 405, "Cutlery" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

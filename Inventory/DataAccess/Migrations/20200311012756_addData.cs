using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "RPT-546587");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "8bd6a67a-1d52-4472-996a-f49a52e59d4f");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "e3b7c11e-ecdd-4f44-ab11-ea8d0c935b3e");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "240d509f-272d-4692-8a83-10cfc44d126d", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "4fe8e54d-e529-479b-8665-b55a2ddf0c57", "Calle norte con occidente", "Bodega Norte" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "240d509f-272d-4692-8a83-10cfc44d126d");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "4fe8e54d-e529-479b-8665-b55a2ddf0c57");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductName", "TotalQuantity" },
                values: new object[] { "RPT-546587", "SLD", "", "Pastillas para la garganta LESUS", 0 });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "e3b7c11e-ecdd-4f44-ab11-ea8d0c935b3e", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "8bd6a67a-1d52-4472-996a-f49a52e59d4f", "Calle norte con occidente", "Bodega Norte" });
        }
    }
}

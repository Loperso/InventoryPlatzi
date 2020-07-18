using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class quannitysolution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "33e49d9d-ad8e-4c0a-8ccd-7e376c40bb7f");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "f9701e1c-4eb2-450f-bc6a-1dbd237049dd");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "89310351-f95f-457c-b790-773ac5b8fc86", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "b9344586-8bcb-46f5-8608-325a4fc6fd10", "Calle norte con occidente", "Bodega Norte" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "89310351-f95f-457c-b790-773ac5b8fc86");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "b9344586-8bcb-46f5-8608-325a4fc6fd10");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "33e49d9d-ad8e-4c0a-8ccd-7e376c40bb7f", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "f9701e1c-4eb2-450f-bc6a-1dbd237049dd", "Calle norte con occidente", "Bodega Norte" });
        }
    }
}

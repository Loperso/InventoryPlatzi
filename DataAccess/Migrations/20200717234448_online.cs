using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class online : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "79af36b7-e7cb-44c4-871c-fd1fdda2cea7");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "d0c16942-bb6f-4695-b13a-31503c9f6b19");

            migrationBuilder.DropColumn(
                name: "WherehouseId",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "TotalQuantity",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "TotalQuanity",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductName", "TotalQuanity" },
                values: new object[,]
                {
                    { "ASJ-98745", "PRF", "", "Crema para manos marca Tersa", 0 },
                    { "RPT-5465879", "SLD", "", "Pastillas para la garganta LESUS", 0 }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "33e49d9d-ad8e-4c0a-8ccd-7e376c40bb7f", "Calle 8 con 23", "Bodega Central" },
                    { "f9701e1c-4eb2-450f-bc6a-1dbd237049dd", "Calle norte con occidente", "Bodega Norte" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "ASJ-98745");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "RPT-5465879");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "33e49d9d-ad8e-4c0a-8ccd-7e376c40bb7f");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "f9701e1c-4eb2-450f-bc6a-1dbd237049dd");

            migrationBuilder.DropColumn(
                name: "TotalQuanity",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "WherehouseId",
                table: "Storages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalQuantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "79af36b7-e7cb-44c4-871c-fd1fdda2cea7", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "d0c16942-bb6f-4695-b13a-31503c9f6b19", "Calle norte con occidente", "Bodega Norte" });
        }
    }
}

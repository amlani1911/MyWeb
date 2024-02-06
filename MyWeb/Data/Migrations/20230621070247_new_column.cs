using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWeb.Data.Migrations
{
    public partial class new_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.DropForeignKey(
        //        name: "FK_Products_Capacities_Products_Sku_Code",
        //        table: "Products_Capacities");

        //    migrationBuilder.DropPrimaryKey(
        //        name: "PK_Products",
        //        table: "Products");

        //    migrationBuilder.DropColumn(
        //        name: "ID",
        //        table: "Products");

        //    migrationBuilder.AlterColumn<int>(
        //        name: "Sku_Code",
        //        table: "Products",
        //        type: "int",
        //        nullable: false,
        //        oldClrType: typeof(int),
        //        oldType: "int")
        //        .Annotation("SqlServer:Identity", "1, 1");

        //    migrationBuilder.AddColumn<string>(
        //        name: "CategoryImageUrl",
        //        table: "Categories",
        //        type: "nvarchar(max)",
        //        nullable: false,
        //        defaultValue: "");

        //    migrationBuilder.AddPrimaryKey(
        //        name: "PK_Products",
        //        table: "Products",
        //        column: "Sku_Code");

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_Products_Capacities_Products_Sku_Code",
        //        table: "Products_Capacities",
        //        column: "Sku_Code",
        //        principalTable: "Products",
        //        principalColumn: "Sku_Code",
        //        onDelete: ReferentialAction.Cascade);
        //}

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropForeignKey(
        //        name: "FK_Products_Capacities_Products_Sku_Code",
        //        table: "Products_Capacities");

        //    migrationBuilder.DropPrimaryKey(
        //        name: "PK_Products",
        //        table: "Products");

        //    migrationBuilder.DropColumn(
        //        name: "CategoryImageUrl",
        //        table: "Categories");

        //    migrationBuilder.AlterColumn<int>(
        //        name: "Sku_Code",
        //        table: "Products",
        //        type: "int",
        //        nullable: false,
        //        oldClrType: typeof(int),
        //        oldType: "int")
        //        .OldAnnotation("SqlServer:Identity", "1, 1");

        //    migrationBuilder.AddColumn<int>(
        //        name: "ID",
        //        table: "Products",
        //        type: "int",
        //        nullable: false,
        //        defaultValue: 0)
        //        .Annotation("SqlServer:Identity", "1, 1");

        //    migrationBuilder.AddPrimaryKey(
        //        name: "PK_Products",
        //        table: "Products",
        //        column: "ID");

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_Products_Capacities_Products_Sku_Code",
        //        table: "Products_Capacities",
        //        column: "Sku_Code",
        //        principalTable: "Products",
        //        principalColumn: "ID",
        //        onDelete: ReferentialAction.Cascade);
        }
    }
}

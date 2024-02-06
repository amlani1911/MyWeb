using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWeb.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.DropForeignKey(
        //        name: "FK_Products_Capacities_Products_Sku_Code",
        //        table: "Products_Capacities");

        //    migrationBuilder.DropPrimaryKey(
        //        name: "PK_Products",
        //        table: "Products");

        //    migrationBuilder.AlterColumn<string>(
        //        name: "ImageUrl",
        //        table: "Products",
        //        type: "nvarchar(max)",
        //        nullable: false,
        //        defaultValue: "",
        //        oldClrType: typeof(string),
        //        oldType: "nvarchar(max)",
        //        oldNullable: true);

        //    migrationBuilder.AlterColumn<int>(
        //        name: "Sku_Code",
        //        table: "Products",
        //        type: "int",
        //        nullable: false,
        //        oldClrType: typeof(int),
        //        oldType: "int")
        //        .OldAnnotation("SqlServer:Identity", "1, 1");

        //    migrationBuilder.AddColumn<int>(
        //        name: "Product_Id",
        //        table: "Products",
        //        type: "int",
        //        nullable: false,
        //        defaultValue: 0)
        //        .Annotation("SqlServer:Identity", "1, 1");

        //    migrationBuilder.AddPrimaryKey(
        //        name: "PK_Products",
        //        table: "Products",
        //        column: "Product_Id");

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_Products_Capacities_Products_Sku_Code",
        //        table: "Products_Capacities",
        //        column: "Sku_Code",
        //        principalTable: "Products",
        //        principalColumn: "Product_Id",
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
        //        name: "Product_Id",
        //        table: "Products");

        //    migrationBuilder.AlterColumn<int>(
        //        name: "Sku_Code",
        //        table: "Products",
        //        type: "int",
        //        nullable: false,
        //        oldClrType: typeof(int),
        //        oldType: "int")
        //        .Annotation("SqlServer:Identity", "1, 1");

        //    migrationBuilder.AlterColumn<string>(
        //        name: "ImageUrl",
        //        table: "Products",
        //        type: "nvarchar(max)",
        //        nullable: true,
        //        oldClrType: typeof(string),
        //        oldType: "nvarchar(max)");

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
        }
    }
}

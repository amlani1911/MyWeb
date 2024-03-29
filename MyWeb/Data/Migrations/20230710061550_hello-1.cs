﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWeb.Data.Migrations
{
    public partial class hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_identityUsers", x => x.Id);
                });
            /* migrationBuilder.CreateTable(
                 name: "Capacities",
                 columns: table => new
                 {
                     Capacity_Id = table.Column<int>(type: "int", nullable: false)
                         .Annotation("SqlServer:Identity", "1, 1"),
                     Cap = table.Column<string>(type: "nvarchar(max)", nullable: false)
                 },
                 constraints: table =>
                 {
                     table.PrimaryKey("PK_Capacities", x => x.Capacity_Id);
                 });

             migrationBuilder.CreateTable(
                 name: "Categories",
                 columns: table => new
                 {
                     Id = table.Column<int>(type: "int", nullable: false)
                         .Annotation("SqlServer:Identity", "1, 1"),
                     CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                     CategoryImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                 },
                 constraints: table =>
                 {
                     table.PrimaryKey("PK_Categories", x => x.Id);
                 });



             migrationBuilder.CreateTable(
                 name: "Products",
                 columns: table => new
                 {
                     Product_Id = table.Column<int>(type: "int", nullable: false)
                         .Annotation("SqlServer:Identity", "1, 1"),
                     Sku_Code = table.Column<int>(type: "int", nullable: false),
                     ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                     Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                     ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                     Id = table.Column<int>(type: "int", nullable: false)
                 },
                 constraints: table =>
                 {
                     table.PrimaryKey("PK_Products", x => x.Product_Id);
                     table.ForeignKey(
                         name: "FK_Products_Categories_Id",
                         column: x => x.Id,
                         principalTable: "Categories",
                         principalColumn: "Id",
                         onDelete: ReferentialAction.Cascade);
                 });

             migrationBuilder.CreateTable(
                 name: "Products_Capacities",
                 columns: table => new
                 {
                     Capacity_Id = table.Column<int>(type: "int", nullable: false),
                     Sku_Code = table.Column<int>(type: "int", nullable: false)
                 },
                 constraints: table =>
                 {
                     table.PrimaryKey("PK_Products_Capacities", x => new { x.Capacity_Id, x.Sku_Code });
                     table.ForeignKey(
                         name: "FK_Products_Capacities_Capacities_Capacity_Id",
                         column: x => x.Capacity_Id,
                         principalTable: "Capacities",
                         principalColumn: "Capacity_Id",
                         onDelete: ReferentialAction.Cascade);
                     table.ForeignKey(
                         name: "FK_Products_Capacities_Products_Sku_Code",
                         column: x => x.Sku_Code,
                         principalTable: "Products",
                         principalColumn: "Product_Id",
                         onDelete: ReferentialAction.Cascade);
                 });

             migrationBuilder.CreateIndex(
                 name: "IX_Products_Id",
                 table: "Products",
                 column: "Id");

             migrationBuilder.CreateIndex(
                 name: "IX_Products_Capacities_Sku_Code",
                 table: "Products_Capacities",
                 column: "Sku_Code");
         */
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "identityUsers");

            migrationBuilder.DropTable(
                name: "Products_Capacities");

            migrationBuilder.DropTable(
                name: "Capacities");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

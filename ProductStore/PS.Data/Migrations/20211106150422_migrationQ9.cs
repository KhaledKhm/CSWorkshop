﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class migrationQ9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Herbs",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsBiological",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LabName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MyAddress",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MyCity",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Biological",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Herbs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biological", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Biological_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chemicals",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    LabName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chemicals", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Chemicals_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biological");

            migrationBuilder.DropTable(
                name: "Chemicals");

            migrationBuilder.AddColumn<string>(
                name: "Herbs",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsBiological",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LabName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyAddress",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyCity",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

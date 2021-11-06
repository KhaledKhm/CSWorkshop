using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class MigrationPartie41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Products_ProductsProductId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Provider_ProvidersId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "ProductProvider",
                newName: "Providing");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "MyCategories");

            migrationBuilder.RenameColumn(
                name: "MyAddress_StreetAddress",
                table: "Products",
                newName: "MyAddress");

            migrationBuilder.RenameColumn(
                name: "MyAddress_City",
                table: "Products",
                newName: "MyCity");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_ProvidersId",
                table: "Providing",
                newName: "IX_Providing_ProvidersId");

            migrationBuilder.AlterColumn<string>(
                name: "MyAddress",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MyCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providing",
                table: "Providing",
                columns: new[] { "ProductsProductId", "ProvidersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MyCategories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "MyCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Providing_Products_ProductsProductId",
                table: "Providing",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Providing_Provider_ProvidersId",
                table: "Providing",
                column: "ProvidersId",
                principalTable: "Provider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_MyCategories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Providing_Products_ProductsProductId",
                table: "Providing");

            migrationBuilder.DropForeignKey(
                name: "FK_Providing_Provider_ProvidersId",
                table: "Providing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providing",
                table: "Providing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories");

            migrationBuilder.RenameTable(
                name: "Providing",
                newName: "ProductProvider");

            migrationBuilder.RenameTable(
                name: "MyCategories",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "MyCity",
                table: "Products",
                newName: "MyAddress_City");

            migrationBuilder.RenameColumn(
                name: "MyAddress",
                table: "Products",
                newName: "MyAddress_StreetAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Providing_ProvidersId",
                table: "ProductProvider",
                newName: "IX_ProductProvider_ProvidersId");

            migrationBuilder.AlterColumn<string>(
                name: "MyAddress_StreetAddress",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider",
                columns: new[] { "ProductsProductId", "ProvidersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Products_ProductsProductId",
                table: "ProductProvider",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Provider_ProvidersId",
                table: "ProductProvider",
                column: "ProvidersId",
                principalTable: "Provider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

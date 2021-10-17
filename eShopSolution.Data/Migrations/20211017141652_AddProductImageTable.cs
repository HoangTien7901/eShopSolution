using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("73070894-c850-4c9a-bada-9c3f26a3c0ca"),
                column: "ConcurrencyStamp",
                value: "beadecfd-c040-47ac-908e-6cdd294b8070");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("34bc8069-3954-421a-a817-46a1f48eddd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cad1a34c-ce4f-4bca-a8fb-014343ce7b83", "AQAAAAEAACcQAAAAEOYgvySO8zRiZ65/jVV4pX7Ymm838+9ioqyjl23m498IOMOpR3LmXCFAcOtwz17T9w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 10, 17, 21, 16, 51, 851, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("73070894-c850-4c9a-bada-9c3f26a3c0ca"),
                column: "ConcurrencyStamp",
                value: "74231718-26e3-4728-a128-7f322236c915");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("34bc8069-3954-421a-a817-46a1f48eddd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f77654b6-c75c-478b-b612-d0e76f671168", "AQAAAAEAACcQAAAAEC8Ah2CXx/Y4zttwZG8yY+pePfJLcUOqEFmvR6jAUurWCf1nnln0q/RVKqy4/7kQwg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 10, 16, 21, 58, 52, 75, DateTimeKind.Local).AddTicks(7851));
        }
    }
}

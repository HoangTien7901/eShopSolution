using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("73070894-c850-4c9a-bada-9c3f26a3c0ca"),
                column: "ConcurrencyStamp",
                value: "3cc341de-e9c2-43f7-9a3b-1b853195f78e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("34bc8069-3954-421a-a817-46a1f48eddd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90f86d8b-1c19-4081-86e9-83f2766b955a", "AQAAAAEAACcQAAAAEP1thwvFrPBAkwXU5EKjtwBloEDQb/fxmYxa4n7RbDgI4oAs3GMKlqnQ6+K8w7bjrA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 10, 17, 22, 37, 35, 960, DateTimeKind.Local).AddTicks(9886));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

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
        }
    }
}

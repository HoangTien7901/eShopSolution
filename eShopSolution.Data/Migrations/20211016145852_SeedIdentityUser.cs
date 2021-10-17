using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("73070894-c850-4c9a-bada-9c3f26a3c0ca"), "74231718-26e3-4728-a128-7f322236c915", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("73070894-c850-4c9a-bada-9c3f26a3c0ca"), new Guid("34bc8069-3954-421a-a817-46a1f48eddd9") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("34bc8069-3954-421a-a817-46a1f48eddd9"), 0, "f77654b6-c75c-478b-b612-d0e76f671168", new DateTime(2001, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "tinhoang7901@gmail.com", true, "Tien", "Hoang", false, null, "tinhoang7901@gmail.com", "admin", "AQAAAAEAACcQAAAAEC8Ah2CXx/Y4zttwZG8yY+pePfJLcUOqEFmvR6jAUurWCf1nnln0q/RVKqy4/7kQwg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 10, 16, 21, 58, 52, 75, DateTimeKind.Local).AddTicks(7851));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("73070894-c850-4c9a-bada-9c3f26a3c0ca"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("73070894-c850-4c9a-bada-9c3f26a3c0ca"), new Guid("34bc8069-3954-421a-a817-46a1f48eddd9") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("34bc8069-3954-421a-a817-46a1f48eddd9"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 10, 16, 21, 25, 40, 793, DateTimeKind.Local).AddTicks(3648));
        }
    }
}

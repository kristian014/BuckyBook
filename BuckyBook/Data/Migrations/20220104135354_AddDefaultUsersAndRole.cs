using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuckyBook.Data.Migrations
{
    public partial class AddDefaultUsersAndRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456", "483c43da-018a-465d-a2d8-ce565eb76acc", "Company", "COMPANY" },
                    { "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166", "da9d3c1a-1856-42ea-afac-d84d785c34f9", "User", "USER" },
                    { "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866", "42be7ec0-a6d4-46c3-9204-54a7e39fcf28", "Employer", "EMPLOYER" },
                    { "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176", "bb77cb23-e0a5-4710-966a-68b6534c52bf", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176");
        }
    }
}

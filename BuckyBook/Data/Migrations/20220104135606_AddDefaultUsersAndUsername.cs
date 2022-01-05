using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuckyBook.Data.Migrations
{
    public partial class AddDefaultUsersAndUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                column: "ConcurrencyStamp",
                value: "e44510cb-98d8-4352-83fd-93eca39e2803");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "14c7e302-6c64-4913-9066-9e43f70d0e46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "238d3269-014d-46db-996e-d27588a823ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "3dee1969-d917-43a7-8461-5c7f8d38e096");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6bc333d6-41cd-5539-ad37-a8c941bf66d5", 0, "London", "5faf9993-b6e3-449b-aaa1-e87709da63d2", "ApplicationUser", "user@localhost.com", true, false, null, "system", "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHwedTeV+a98o3fjy5gsmfSVaUU3gOm8tDr9uXaN+lf96uSaUT5kAaS12Ob8z6/qgQ==", null, false, null, "3e5db6f0-2d49-40ca-9e09-f616935e40b0", null, null, false, "user@localhost.com" },
                    { "6bd555a6-61fc-4339-bc37-a5c532bf99d5", 0, "Doncaster", "5098c17e-7700-4787-b667-77e98a166215", "ApplicationUser", "company@localhost.com", true, false, null, "system", "COMPANY@LOCALHOST.COM", "COMPANY@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGUfGYNALDCe/kWTp4lWxsLYJySRAhv4MBBwc3+fvx27MvqnxkcDGY5GLzU1p1tcxw==", null, false, null, "a86350ce-0d1c-4f21-9798-0f6a75fd0cff", null, null, false, "company@localhost.com" },
                    { "6dc22d7-83cc-4799-cf47-a2c222bc22d5", 0, "Leeds", "6467b836-6d34-48a4-a3df-08b6c11c98b2", "ApplicationUser", "employer@localhost.com", true, false, null, "system", "EMPLOYER@LOCALHOST.COM", "EMPLOYER@LOCALHOST.COM", "AQAAAAEAACcQAAAAELIaGtXlKVoqVM27NkKuzdyz6YBB+Z7xjxKtEyg7PC0ObDNBWb6UhWwkhE5JnhQ7XQ==", null, false, null, "5379bb14-44ea-4c5c-8fd0-f035314304bb", null, null, false, "employer@localhost.com" },
                    { "8ea993d6-11ab-4438-ac76-a9b951af77d5", 0, "Hull", "f56b02d3-15f2-485a-bc8a-c3f1942b7dcc", "ApplicationUser", "admin@localhost.com", true, false, null, "system", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJ45OMeMUvts7CKiPtOhuM5dDtVwgTqGM5acZ0bqXPVtrGGJZg/wqBk84qVtmZo4Tw==", null, false, null, "f5175c3a-9d5d-4685-97f8-df65f0bb2b15", null, null, false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166", "6bc333d6-41cd-5539-ad37-a8c941bf66d5" },
                    { "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456", "6bd555a6-61fc-4339-bc37-a5c532bf99d5" },
                    { "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866", "6dc22d7-83cc-4799-cf47-a2c222bc22d5" },
                    { "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176", "8ea993d6-11ab-4438-ac76-a9b951af77d5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166", "6bc333d6-41cd-5539-ad37-a8c941bf66d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456", "6bd555a6-61fc-4339-bc37-a5c532bf99d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866", "6dc22d7-83cc-4799-cf47-a2c222bc22d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176", "8ea993d6-11ab-4438-ac76-a9b951af77d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                column: "ConcurrencyStamp",
                value: "483c43da-018a-465d-a2d8-ce565eb76acc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "da9d3c1a-1856-42ea-afac-d84d785c34f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "42be7ec0-a6d4-46c3-9204-54a7e39fcf28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "bb77cb23-e0a5-4710-966a-68b6534c52bf");
        }
    }
}

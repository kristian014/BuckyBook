using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuckyBook.Data.Migrations
{
    public partial class DropCompanyIdInDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                column: "ConcurrencyStamp",
                value: "478afb92-fd37-4b25-b2a8-a0d3de542707");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "c3030d9d-97a7-48d7-8332-53944e74ee22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "c1982681-e156-4ab3-9f47-ea89ec42e6bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "7b5a5981-7d23-41f2-8c0c-5e18c0709b56");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba8de4bf-b6f8-4875-8afe-e66ca2b4370d", "AQAAAAEAACcQAAAAEMkDWiqUVIhYphCiJyDn9N5zn+Sh3Ahm7kB2uQIkzDMJzB/hYP7w1AKIfjhrEhBoiQ==", "974c13c0-d765-4966-887c-fa7fddd4ceba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57d385d1-2a09-40bb-9a78-d1a8683d89ed", "AQAAAAEAACcQAAAAEOqS8Y1nRlNqAKusjRhNFXt4Es+nrPoIO2ziB+miYFAjguspOFb9FUL1HoDpPne7Rg==", "a353cb5e-c8ab-4775-ab75-4354eddf0d16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ee02e55-1628-48f0-97eb-a9ed29cc8c72", "AQAAAAEAACcQAAAAEHWkq7B80F/YZd1aFEFvgWH22kDMmOwLlQLZqPUeLapKnKgYGibTbLbOXCxIxDns3w==", "01f8295a-4516-4365-95ee-8574de25aed6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96c3ddff-dc5c-45d7-a29b-fad8264cac46", "AQAAAAEAACcQAAAAEB980Ho1pqDPThfwImktOxZdEohE8GTfVDUjuLyfJKfGfWJkojLNegThZfTM11mfGg==", "84596a87-e21f-4879-9471-ea98817e5cf6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                column: "ConcurrencyStamp",
                value: "e21457c4-193b-4514-aed9-22d2beb30bb0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "705c1cb6-6ee8-40fe-8c26-9ac524a782d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "9d2f0e08-2a92-47aa-812a-25f7084079f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "ca8332aa-9bb3-45b2-9a0e-dbef18ef7863");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompanyId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6bc333d6-41cd-5539-ad37-a8c941bf66d5", 0, "London", 0, "efa7ed38-abc7-4f6c-99be-523b898eac0b", "ApplicationUser", "user@localhost.com", true, false, null, "system", "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPO+Dex0YV92qrD9+Hl5BJW9iCdCT00ZfPsE1JDyisPNCfn6UgiW2uXPYhP889Nm7A==", null, false, null, "a8701116-a800-4503-b6d7-a8d82697593d", null, null, false, "user@localhost.com" },
                    { "6bd555a6-61fc-4339-bc37-a5c532bf99d5", 0, "Doncaster", 0, "c6607662-8f54-4a38-95bc-da8fcf8679c1", "ApplicationUser", "company@localhost.com", true, false, null, "system", "COMPANY@LOCALHOST.COM", "COMPANY@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFAzIEJiMY2LczdtdzLmhU9NWWWSZMsc3c9/GKDM3gLvjroIzpnKVpycIDmv1/9zaw==", null, false, null, "f2e44dd1-3b0f-4872-93bd-66780f1a423e", null, null, false, "company@localhost.com" },
                    { "6dc22d7-83cc-4799-cf47-a2c222bc22d5", 0, "Leeds", 0, "64403cd5-6d26-4715-8036-f0c397ae3f21", "ApplicationUser", "employer@localhost.com", true, false, null, "system", "EMPLOYER@LOCALHOST.COM", "EMPLOYER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBbHUQaZEK6ranPAhnbrKHRPXackwTmvsgTR4DauWk2pu0UY/LPuQuE/tu2FsTwmZQ==", null, false, null, "bbce4d65-3add-4a80-8106-5cebfa136eeb", null, null, false, "employer@localhost.com" },
                    { "8ea993d6-11ab-4438-ac76-a9b951af77d5", 0, "Hull", 0, "b3a3d444-bba1-4ec1-9bad-59b4e343238e", "ApplicationUser", "admin@localhost.com", true, false, null, "system", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAELlf6t0PLHi4S9S43xzndCnPlkotGlqSgiEDvI7kmSr8vG8qnTE7xOeSE1A9CyAFHw==", null, false, null, "a1455f62-9352-46dc-b4bd-30a6e3350df1", null, null, false, "admin@localhost.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

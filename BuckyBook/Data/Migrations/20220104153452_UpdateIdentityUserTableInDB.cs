using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuckyBook.Data.Migrations
{
    public partial class UpdateIdentityUserTableInDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efa7ed38-abc7-4f6c-99be-523b898eac0b", "AQAAAAEAACcQAAAAEPO+Dex0YV92qrD9+Hl5BJW9iCdCT00ZfPsE1JDyisPNCfn6UgiW2uXPYhP889Nm7A==", "a8701116-a800-4503-b6d7-a8d82697593d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6607662-8f54-4a38-95bc-da8fcf8679c1", "AQAAAAEAACcQAAAAEFAzIEJiMY2LczdtdzLmhU9NWWWSZMsc3c9/GKDM3gLvjroIzpnKVpycIDmv1/9zaw==", "f2e44dd1-3b0f-4872-93bd-66780f1a423e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64403cd5-6d26-4715-8036-f0c397ae3f21", "AQAAAAEAACcQAAAAEBbHUQaZEK6ranPAhnbrKHRPXackwTmvsgTR4DauWk2pu0UY/LPuQuE/tu2FsTwmZQ==", "bbce4d65-3add-4a80-8106-5cebfa136eeb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3a3d444-bba1-4ec1-9bad-59b4e343238e", "AQAAAAEAACcQAAAAELlf6t0PLHi4S9S43xzndCnPlkotGlqSgiEDvI7kmSr8vG8qnTE7xOeSE1A9CyAFHw==", "a1455f62-9352-46dc-b4bd-30a6e3350df1" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5faf9993-b6e3-449b-aaa1-e87709da63d2", "AQAAAAEAACcQAAAAEHwedTeV+a98o3fjy5gsmfSVaUU3gOm8tDr9uXaN+lf96uSaUT5kAaS12Ob8z6/qgQ==", "3e5db6f0-2d49-40ca-9e09-f616935e40b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5098c17e-7700-4787-b667-77e98a166215", "AQAAAAEAACcQAAAAEGUfGYNALDCe/kWTp4lWxsLYJySRAhv4MBBwc3+fvx27MvqnxkcDGY5GLzU1p1tcxw==", "a86350ce-0d1c-4f21-9798-0f6a75fd0cff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6467b836-6d34-48a4-a3df-08b6c11c98b2", "AQAAAAEAACcQAAAAELIaGtXlKVoqVM27NkKuzdyz6YBB+Z7xjxKtEyg7PC0ObDNBWb6UhWwkhE5JnhQ7XQ==", "5379bb14-44ea-4c5c-8fd0-f035314304bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f56b02d3-15f2-485a-bc8a-c3f1942b7dcc", "AQAAAAEAACcQAAAAEJ45OMeMUvts7CKiPtOhuM5dDtVwgTqGM5acZ0bqXPVtrGGJZg/wqBk84qVtmZo4Tw==", "f5175c3a-9d5d-4685-97f8-df65f0bb2b15" });
        }
    }
}

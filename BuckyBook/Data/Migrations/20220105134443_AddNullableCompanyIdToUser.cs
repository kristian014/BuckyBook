using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuckyBook.Data.Migrations
{
    public partial class AddNullableCompanyIdToUser : Migration
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
                value: "11a1a1c5-3d1c-4b9c-9673-3532f3ea8aaa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "0180ce19-c77a-4d21-800b-3d03d2e5ae37");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "7e78d08e-19c6-4dec-a9da-00a0d137233b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "bec53252-9bc6-49fc-bc2d-a0e3cde9b313");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b10d798-f414-4cf5-a552-68601100a988", "AQAAAAEAACcQAAAAEInUmQ9bDPs+6XgumpA2UjuIwiPuimmCxfFYcY/mt1gM8P6aSiJTJ2KTM/ex0K05YQ==", "6be65051-0bbe-4e49-804e-07ff637d69d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8af2b1f-f73f-42bc-a54f-8cf87b13074f", "AQAAAAEAACcQAAAAEA8Jv+o5HS2NiXq9Ko69L032Uaqq1cHoNI36sesycEh34zzXKtf0pNa2GKsl2lCvbA==", "6c03addc-ebcc-4af1-a2ca-a5e17e76bfe3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "888f6e96-bfb1-4fbe-aad4-bebb42557148", "AQAAAAEAACcQAAAAEC0pfDFA+rFpTL+lnVqLtJDApQtmuoaPogrnQOqIqnaEWulUvicxA/TpnrU84ysPhw==", "de9cd4c1-2b3b-46af-a084-93d7be280767" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d781255c-0a9b-4698-b6dc-311c96b9d290", "AQAAAAEAACcQAAAAED/zctnV26qFnj5u5grzRq5wFmr3TkH8JSmKAei3daR1owgZUpQSikillQys5kmepA==", "752eb322-03fe-4df0-9bcd-35992de1c241" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
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
    }
}

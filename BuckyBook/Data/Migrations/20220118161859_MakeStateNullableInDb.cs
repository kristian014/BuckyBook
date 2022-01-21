using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuckyBook.Data.Migrations
{
    public partial class MakeStateNullableInDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                column: "ConcurrencyStamp",
                value: "5b5e356a-e49d-4d31-b210-1f4d12c35658");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "9bb75dfd-60ab-43d0-aeb5-fbe768238616");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "fbc4a3c5-cb33-4f5e-b8aa-0b7ce029782d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "f41ea3c9-9221-4d56-ba62-8076db3b6b19");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de54cf0d-c591-4014-bcab-21b01a45d7b5", "AQAAAAEAACcQAAAAELZIvePhrIHza+wkIr97w9bMhyQObfCp5J1FCTpqKlmNHiBB4FvSmx1D71BtEqzAcQ==", "a5865140-e33a-443e-bf80-a54a69c374c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e8d246e-6fda-417b-96d8-90bdf37aebcc", "AQAAAAEAACcQAAAAEElau9uub2Jtz6W/PsQcb0wLcrR3kSfsHN71XuF1a7rDTnBURrIPKl3LG5HsdIeLBg==", "91d7a464-b077-4c3e-abfa-971e7b984f7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "864c6b04-ef5e-4c82-8b8b-ee1b3b28374e", "AQAAAAEAACcQAAAAEEQFrGJbWw+GvFrJRkMycOzkEr8b4G/KP8vKHQ26Ldq3tSzAMp+WvTWMyvtgCHX3kQ==", "84a4dcdd-0002-40d8-a82c-4cb23d775fbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b76b95d-f875-4f65-a47d-14798c5a9bec", "AQAAAAEAACcQAAAAEGKO+O8d4ytbBR5w2DyHnSrBpWMphURLTz0m5//q53nyZPPenJzv0DfiD4hz7YZ5Rg==", "d41f72db-339f-4184-ba97-9f4b4b16dc4d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                column: "ConcurrencyStamp",
                value: "5063e498-e405-403c-a698-9b815c81853b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "62042bcc-687c-49b1-99a0-e2d3ff66a861");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "87fa0d32-87b5-4aae-ad11-8bfa109fcc19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "4aea9a10-e5d5-4a7c-89d1-460f0f0c8e62");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32941d24-e86f-425b-8b42-fb36ed6b9802", "AQAAAAEAACcQAAAAEP3jIcNtbWff7IXtMcPk1hBLts0xcaFtsAWXYKNHRgrqXTedDfcvNPN4zs6MPiCaCA==", "e1b89be7-636c-49ac-808b-2652b56d0589" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4baf6cf7-8928-4ec8-9cae-0e5bda934b07", "AQAAAAEAACcQAAAAEM+H0GUZDi47fe3QADv0XgYMhh4n+I749GS/hZjAKFXyYzB2+dBf6VkgXbjfmkuYig==", "10f11a1d-1d02-4e0c-a892-17cce3450e36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d3ef281-f084-487c-bee5-ac10db61183f", "AQAAAAEAACcQAAAAEEnlXGCu2U6iLz1Je/uKVjep9Jlv0vX44kiOQEH46RB4M3b/qCc/TfGevv8wXPKJBQ==", "47d2018b-1c65-4038-bc6d-2fb7b43d4f82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6b70ff5-0ea7-49cb-aca7-d0625989a58e", "AQAAAAEAACcQAAAAEPxJuQDmw0ZM6CsKYCxYUrvjlXM0x30SjE86J+idXs6JAMbH33P3sysS7vzp1eKtAA==", "0749ffc9-045a-4d34-b418-ad4dc25d2523" });
        }
    }
}

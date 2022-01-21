using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuckyBook.Data.Migrations
{
    public partial class AddMoreAttributeToDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                column: "ConcurrencyStamp",
                value: "4b6ac569-3916-44cd-bc26-c3e8d444b78b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "56f198bb-27c6-48b5-995d-183b6a28dc56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "03d5cb96-c83c-4d26-a795-cceb63d9e93f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "b8651eea-4a9e-45ab-a8ce-e29391ebe645");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21ffcad7-38ae-4e06-8af9-034ddd6c028e", "AQAAAAEAACcQAAAAEPLBDJfTLB/Zf17Iz+Nb3W8tYzr8zjylFQ2JFosAI2Gl/Z4Ynnk19QEC8Xu4bUUZJg==", "28f79138-2ba9-4079-b800-e40c496f8f08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c93965b3-540e-4cac-b0b3-7412a61a9e00", "AQAAAAEAACcQAAAAEAvT7CJqmr/dk+NvkePPBDBiSQniYr3pomV9BRkyOFvL2lrr38QHwNjS/MLS+KtezQ==", "4bfe0668-0919-41c3-9f10-a8bae6c6d541" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00e6d968-ee80-4dc3-b958-987d8f925234", "AQAAAAEAACcQAAAAEORPnJ4geVK0W7+1fBoZ+hk8hqkLovMjxNmPcn0CKALlnJhNXj6kANOJbYs0GZqjzw==", "50627b3f-bcf1-449b-8aac-df8415bb1a0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dd8467a-745e-4895-bd1c-9c7f0b7f2628", "AQAAAAEAACcQAAAAEHHulyUBvWH+1tKrRks3fzo8640DCONLmt55adoF0PnqcnJMdm6TyEknLMcPj2coIA==", "df8f48eb-09f1-46e2-97bc-2ce4681815bf" });
        }
    }
}

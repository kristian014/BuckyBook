using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuckyBook.Data.Migrations
{
    public partial class UserRegistrationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                column: "ConcurrencyStamp",
                value: "62572123-faca-4df9-89d4-030e3b138136");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "b928ceae-e18a-4404-b993-3898606d4def");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "45225f0d-724d-49a2-9c90-ba6d91736b58");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "27c5ec9f-ec31-46d3-8504-ff77f09e0252");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "1196b43a-1349-40e9-97b9-69e6eb3660da", "AQAAAAEAACcQAAAAEARv3XHhBjPzoPiEnnX7VTKkicq1EGzjHb6SUEetvcL7K7R8A8BwYVL6JO+7DPUpHQ==", "07563223562", "0cb42642-b3fb-407d-a46f-31efe48bd58b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "2c70be4c-aa56-4b2d-aae5-ed634ae99ccc", "AQAAAAEAACcQAAAAEAQb8hbHXe/OkLnXSZJSURnpf6SIogRI0fZw3LkRVqiZ1SctVywcIfVfroSrqiyJbg==", "07563223245", "a9a4b44b-3359-438f-84fc-1264b39a50f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "1c639a7d-091a-4090-a93e-bc302604c54a", "AQAAAAEAACcQAAAAEMno4wpXcSzyGPIc4PFmHpwOv4rs09R19+Jg+1BjNjIc0U6X3kWb5U+L/Y3YnNfUNQ==", "07563237582", "e1411798-fbf2-41df-8354-dd116b590131" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "4acac6d6-a81a-4701-92dc-8428d0c575e5", "AQAAAAEAACcQAAAAEN227EvjQgz+wfPAogcdL8Yjdsvk10EtN/SJLPwqxQFtLF2vEYbNtZA5hePPU/9ZhA==", "07563223432", "9701e069-a60c-4e52-aff1-125f4ff2d59b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                column: "ConcurrencyStamp",
                value: "7094422e-638f-4970-a75b-28a7a1fcdbe4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "1603b247-bc73-4667-9eb1-130f95e37380");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "72d7c756-b7c8-4c8a-80f5-ab54e53d099b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "c41f5857-f4d4-42af-a33a-923cee10181f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "f4a99bfe-42a7-43e2-a4a1-c334d2a11faf", "AQAAAAEAACcQAAAAEJ/EY8SvRshLoRs2HpLwhIW6+M6KXe7tqSwJWsMWp2jkhgQQ2eiTB9Z78l5EwKGS6w==", null, "9825b195-0f1c-4c4d-bb7b-2364f221bc8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "eb0aacfb-7b47-4c89-840a-c93527c22082", "AQAAAAEAACcQAAAAEDhcDoR/SBjHcuc0R379nW33OA+TSSm+uvVnM3D1oB4PXory2lAbRIcmGwT3+lo8dg==", null, "259be62a-24b8-45ba-85c9-d5f4b69cf38d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "743d2c19-6e43-48ad-ba52-31eb76e7ba57", "AQAAAAEAACcQAAAAEI2PSH/0eWLp2kuR5tEk3U+zd+mV36p8MGH7vVI+76HpNIuJAHthK4QsxRy14vclZw==", null, "9713a947-145d-4e22-87bc-0d303c204903" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "ccc56da7-2eb9-41c3-82e1-e8b4abc1e681", "AQAAAAEAACcQAAAAEEnfmGktrJKnGqF6HGZuApJ4x1CoKTe19lzXGLjUjQLS274mNceGfkFIn1WoCCeFWg==", null, "28838525-7d1a-4f2a-9e3b-f60bc89f3768" });
        }
    }
}

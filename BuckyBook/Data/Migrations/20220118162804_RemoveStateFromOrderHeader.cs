using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuckyBook.Data.Migrations
{
    public partial class RemoveStateFromOrderHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "OrderHeaders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                column: "ConcurrencyStamp",
                value: "2776077c-16b1-4bbc-85ec-2aa65099bad4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "b724f073-3f57-4d47-975d-9aa98919c377");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "d916c71c-a83c-43ad-88ee-a7af97104899");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "7deb7a98-1281-4b7e-ab7a-2cfb07c7f234");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fb12c87-6fc5-40ab-a0eb-b9c888a27420", "AQAAAAEAACcQAAAAENEy6IKSDGrMoXSdC8+ossJ+XsTswfdGlErvzG+O6Sc/iQ7otmOQ+K9kqmouLHd0gQ==", "88748a29-c068-4670-9b94-fb7505419057" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0dd35fa-2e7a-4648-9f42-8e1ee2d4b4aa", "AQAAAAEAACcQAAAAEAoderjz8+orfwAJ73gg/rt3f9fnW4Z1eteLrjot2QtS5mq7op10t1SSLvI4k5XS9w==", "0e097751-a416-49fd-bf0f-acf5e45ed705" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1c0627a-beef-450d-ab67-75c1f6357f4e", "AQAAAAEAACcQAAAAEEtwV7D0A59p8SyzhHNGUI/65aTwCVi5UGw9WBLMFpM7tNmeDUGnLe5chGdJwmbjow==", "a16cca0c-8e40-4b38-b1d8-72eb0ee71e8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1113ac2-09f7-4ae1-89a4-a637859df41a", "AQAAAAEAACcQAAAAEAh2tOM4Wa2GvGbjva1XanB3jROCQfMsmsU38A1aHXxQ+LWmXE2TdfdoLgGpY19fOA==", "8f4a745d-05ad-43a1-93ec-08b440bc79da" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "OrderHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}

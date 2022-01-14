using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuckyBook.Data.Migrations
{
    public partial class AddShoppingCartToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                column: "ConcurrencyStamp",
                value: "a0a1417a-692d-46c6-b5a1-293f242897e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                column: "ConcurrencyStamp",
                value: "348717e4-8d21-41e8-979d-0c8eed515997");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                column: "ConcurrencyStamp",
                value: "be661177-8e07-45bd-8a0a-72729042e7d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                column: "ConcurrencyStamp",
                value: "e163dbc9-e76c-465f-9ded-95d56cbeec6c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f20ec47-9ec3-4a21-bddc-bbb85f9c3616", "AQAAAAEAACcQAAAAEDjs0gVb/fVsnjaT6lmJi1CFr/R2BzqObITHmJT8Qmik/RRyDLKiN1U36TwzqCyZgg==", "a5aff700-9f6e-4029-b852-fb6521fe7e95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aba93f8-2606-4eae-ae03-541306d3ae45", "AQAAAAEAACcQAAAAEIFN3wXUG5CDNpTaZKxi8OY03aNzf2Q9JttufnidZ0NpyQbfPD3evN0gDJnTEt6E8g==", "822e9986-1814-45f9-bb48-e809818d906a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e72d3c16-a9ab-4535-b7b3-861c14e36301", "AQAAAAEAACcQAAAAEGD1EcYNz1VuDMutYDHF0z0fo3VRAjZnJfHSBwq0YzzGIxYR4JfFjj+pHAuf5BJdGg==", "b4e8ce39-f5c5-4ab1-bcd9-eb9264813d98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03241565-1704-47cc-ae11-6e12dfc537f0", "AQAAAAEAACcQAAAAEHR434mUOy6Y8H3uN7cEoeng5WnGiHb7T6SdaFvJ+ZZyvXV/ZGIP78qzHmwSS6fq1g==", "75272cdc-f454-4130-a575-63b16c4b0b27" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCarts");

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
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManager.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.UserName);
                });

            migrationBuilder.InsertData(
                table: "TaiKhoan",
                columns: new[] { "UserName", "PassWord" },
                values: new object[] { "huii", "123" });

            migrationBuilder.InsertData(
                table: "TaiKhoan",
                columns: new[] { "UserName", "PassWord" },
                values: new object[] { "huiii", "1234" });

            migrationBuilder.InsertData(
                table: "TaiKhoan",
                columns: new[] { "UserName", "PassWord" },
                values: new object[] { "huiiiii", "12345" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaiKhoan");
        }
    }
}

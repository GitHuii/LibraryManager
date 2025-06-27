using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManager.Migrations
{
    public partial class haii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaiKhoans",
                keyColumn: "UserName",
                keyValue: "huiii");

            migrationBuilder.DeleteData(
                table: "TaiKhoans",
                keyColumn: "UserName",
                keyValue: "huiiiii");

            migrationBuilder.InsertData(
                table: "TaiKhoans",
                columns: new[] { "UserName", "PassWord" },
                values: new object[] { "duy", "12345" });

            migrationBuilder.InsertData(
                table: "TaiKhoans",
                columns: new[] { "UserName", "PassWord" },
                values: new object[] { "Hai", "1234" });

            migrationBuilder.InsertData(
                table: "TaiKhoans",
                columns: new[] { "UserName", "PassWord" },
                values: new object[] { "manh", "123456" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaiKhoans",
                keyColumn: "UserName",
                keyValue: "duy");

            migrationBuilder.DeleteData(
                table: "TaiKhoans",
                keyColumn: "UserName",
                keyValue: "Hai");

            migrationBuilder.DeleteData(
                table: "TaiKhoans",
                keyColumn: "UserName",
                keyValue: "manh");

            migrationBuilder.InsertData(
                table: "TaiKhoans",
                columns: new[] { "UserName", "PassWord" },
                values: new object[] { "huiii", "1234" });

            migrationBuilder.InsertData(
                table: "TaiKhoans",
                columns: new[] { "UserName", "PassWord" },
                values: new object[] { "huiiiii", "12345" });
        }
    }
}

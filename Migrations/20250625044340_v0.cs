using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManager.Migrations
{
    public partial class v0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocGia",
                columns: table => new
                {
                    MaDocGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGia", x => x.MaDocGia);
                });

            migrationBuilder.CreateTable(
                name: "Saches",
                columns: table => new
                {
                    MaSach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NXB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamXuatBan = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saches", x => x.MaSach);
                });

            migrationBuilder.CreateTable(
                name: "PhieuMuonTra",
                columns: table => new
                {
                    MaPhieuMuonTra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDocGia = table.Column<int>(type: "int", nullable: false),
                    NgayMuon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HanTra = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuonTra", x => x.MaPhieuMuonTra);
                    table.ForeignKey(
                        name: "FK_PhieuMuonTra_DocGia_MaDocGia",
                        column: x => x.MaDocGia,
                        principalTable: "DocGia",
                        principalColumn: "MaDocGia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuPhat",
                columns: table => new
                {
                    MaPhieuPhat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaDocGia = table.Column<int>(type: "int", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoTienPhat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaThuTien = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuPhat", x => x.MaPhieuPhat);
                    table.ForeignKey(
                        name: "FK_PhieuPhat_DocGia_MaDocGia",
                        column: x => x.MaDocGia,
                        principalTable: "DocGia",
                        principalColumn: "MaDocGia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuMuonTra",
                columns: table => new
                {
                    MaChiTietPhieuMuon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhieuMuonTra = table.Column<int>(type: "int", nullable: false),
                    MaSach = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    NgayTraThucTe = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DaTra = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuMuonTra", x => x.MaChiTietPhieuMuon);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuonTra_PhieuMuonTra_MaPhieuMuonTra",
                        column: x => x.MaPhieuMuonTra,
                        principalTable: "PhieuMuonTra",
                        principalColumn: "MaPhieuMuonTra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuonTra_Saches_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Saches",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DocGia",
                columns: new[] { "MaDocGia", "DiaChi", "Email", "NgaySinh", "SDT", "Ten" },
                values: new object[,]
                {
                    { 1, "Hà Nội", "a@example.com", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911111111", "Nguyễn Văn A" },
                    { 2, "TP.HCM", "b@example.com", new DateTime(1999, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0922222222", "Trần Thị B" },
                    { 3, "Đà Nẵng", "c@example.com", new DateTime(2001, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0933333333", "Lê Văn C" },
                    { 4, "Huế", "d@example.com", new DateTime(2002, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0944444444", "Phạm Thị D" },
                    { 5, "Cần Thơ", "e@example.com", new DateTime(1998, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0955555555", "Hoàng Văn E" }
                });

            migrationBuilder.InsertData(
                table: "Saches",
                columns: new[] { "MaSach", "NXB", "NamXuatBan", "SoLuong", "TacGia", "Ten", "TheLoai" },
                values: new object[,]
                {
                    { 1, "NXB Trẻ", 2021, 10, "Nguyễn Văn T", "Lập trình C#", "CNTT" },
                    { 2, "NXB Giáo dục", 2020, 15, "Phạm Văn P", "Toán cao cấp", "Giáo trình" },
                    { 3, "NXB Thanh Niên", 2019, 8, "Trần Thị Q", "Kỹ năng sống", "Kỹ năng" },
                    { 4, "NXB Văn hóa", 2018, 12, "Lê Văn K", "Tiếng Anh giao tiếp", "Ngoại ngữ" },
                    { 5, "NXB Lao động", 2022, 6, "Nguyễn Thị H", "Tư duy phản biện", "Kỹ năng" }
                });

            migrationBuilder.InsertData(
                table: "PhieuMuonTra",
                columns: new[] { "MaPhieuMuonTra", "HanTra", "MaDocGia", "NgayMuon" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 3, new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 4, new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), 5, new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "PhieuPhat",
                columns: new[] { "MaPhieuPhat", "DaThuTien", "LyDo", "MaDocGia", "NgayLap", "SoTienPhat" },
                values: new object[,]
                {
                    { "PP001", false, "Trả trễ", 1, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 5000m },
                    { "PP002", false, "Mất sách", 2, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 7000m },
                    { "PP003", true, "Trả sai sách", 3, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 10000m },
                    { "PP004", false, "Sách rách", 4, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 3000m },
                    { "PP005", true, "Không trả sách", 5, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 8000m }
                });

            migrationBuilder.InsertData(
                table: "ChiTietPhieuMuonTra",
                columns: new[] { "MaChiTietPhieuMuon", "DaTra", "MaPhieuMuonTra", "MaSach", "NgayTraThucTe", "SoLuong" },
                values: new object[,]
                {
                    { 1, false, 1, 1, null, 2 },
                    { 2, false, 1, 2, null, 1 },
                    { 3, false, 2, 3, null, 1 },
                    { 4, false, 3, 4, null, 1 },
                    { 5, false, 4, 5, null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuonTra_MaPhieuMuonTra",
                table: "ChiTietPhieuMuonTra",
                column: "MaPhieuMuonTra");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuonTra_MaSach",
                table: "ChiTietPhieuMuonTra",
                column: "MaSach");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuonTra_MaDocGia",
                table: "PhieuMuonTra",
                column: "MaDocGia");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuPhat_MaDocGia",
                table: "PhieuPhat",
                column: "MaDocGia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuMuonTra");

            migrationBuilder.DropTable(
                name: "PhieuPhat");

            migrationBuilder.DropTable(
                name: "PhieuMuonTra");

            migrationBuilder.DropTable(
                name: "Saches");

            migrationBuilder.DropTable(
                name: "DocGia");
        }
    }
}

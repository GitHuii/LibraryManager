using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManager.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuonTra_PhieuMuonTra_MaPhieuMuonTra",
                table: "ChiTietPhieuMuonTra");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuonTra_Saches_MaSach",
                table: "ChiTietPhieuMuonTra");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuMuonTra_DocGia_MaDocGia",
                table: "PhieuMuonTra");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuPhat_DocGia_MaDocGia",
                table: "PhieuPhat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaiKhoan",
                table: "TaiKhoan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuPhat",
                table: "PhieuPhat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuMuonTra",
                table: "PhieuMuonTra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocGia",
                table: "DocGia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuMuonTra",
                table: "ChiTietPhieuMuonTra");

            migrationBuilder.RenameTable(
                name: "TaiKhoan",
                newName: "TaiKhoans");

            migrationBuilder.RenameTable(
                name: "PhieuPhat",
                newName: "PhieuPhats");

            migrationBuilder.RenameTable(
                name: "PhieuMuonTra",
                newName: "PhieuMuonTras");

            migrationBuilder.RenameTable(
                name: "DocGia",
                newName: "DocGias");

            migrationBuilder.RenameTable(
                name: "ChiTietPhieuMuonTra",
                newName: "ChiTietPhieuMuonTras");

            migrationBuilder.RenameIndex(
                name: "IX_PhieuPhat_MaDocGia",
                table: "PhieuPhats",
                newName: "IX_PhieuPhats_MaDocGia");

            migrationBuilder.RenameIndex(
                name: "IX_PhieuMuonTra_MaDocGia",
                table: "PhieuMuonTras",
                newName: "IX_PhieuMuonTras_MaDocGia");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuonTra_MaSach",
                table: "ChiTietPhieuMuonTras",
                newName: "IX_ChiTietPhieuMuonTras_MaSach");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuonTra_MaPhieuMuonTra",
                table: "ChiTietPhieuMuonTras",
                newName: "IX_ChiTietPhieuMuonTras_MaPhieuMuonTra");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaiKhoans",
                table: "TaiKhoans",
                column: "UserName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuPhats",
                table: "PhieuPhats",
                column: "MaPhieuPhat");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuMuonTras",
                table: "PhieuMuonTras",
                column: "MaPhieuMuonTra");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocGias",
                table: "DocGias",
                column: "MaDocGia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuMuonTras",
                table: "ChiTietPhieuMuonTras",
                column: "MaChiTietPhieuMuon");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuonTras_PhieuMuonTras_MaPhieuMuonTra",
                table: "ChiTietPhieuMuonTras",
                column: "MaPhieuMuonTra",
                principalTable: "PhieuMuonTras",
                principalColumn: "MaPhieuMuonTra",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuonTras_Saches_MaSach",
                table: "ChiTietPhieuMuonTras",
                column: "MaSach",
                principalTable: "Saches",
                principalColumn: "MaSach",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuMuonTras_DocGias_MaDocGia",
                table: "PhieuMuonTras",
                column: "MaDocGia",
                principalTable: "DocGias",
                principalColumn: "MaDocGia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuPhats_DocGias_MaDocGia",
                table: "PhieuPhats",
                column: "MaDocGia",
                principalTable: "DocGias",
                principalColumn: "MaDocGia",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuonTras_PhieuMuonTras_MaPhieuMuonTra",
                table: "ChiTietPhieuMuonTras");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuonTras_Saches_MaSach",
                table: "ChiTietPhieuMuonTras");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuMuonTras_DocGias_MaDocGia",
                table: "PhieuMuonTras");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuPhats_DocGias_MaDocGia",
                table: "PhieuPhats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaiKhoans",
                table: "TaiKhoans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuPhats",
                table: "PhieuPhats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuMuonTras",
                table: "PhieuMuonTras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocGias",
                table: "DocGias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuMuonTras",
                table: "ChiTietPhieuMuonTras");

            migrationBuilder.RenameTable(
                name: "TaiKhoans",
                newName: "TaiKhoan");

            migrationBuilder.RenameTable(
                name: "PhieuPhats",
                newName: "PhieuPhat");

            migrationBuilder.RenameTable(
                name: "PhieuMuonTras",
                newName: "PhieuMuonTra");

            migrationBuilder.RenameTable(
                name: "DocGias",
                newName: "DocGia");

            migrationBuilder.RenameTable(
                name: "ChiTietPhieuMuonTras",
                newName: "ChiTietPhieuMuonTra");

            migrationBuilder.RenameIndex(
                name: "IX_PhieuPhats_MaDocGia",
                table: "PhieuPhat",
                newName: "IX_PhieuPhat_MaDocGia");

            migrationBuilder.RenameIndex(
                name: "IX_PhieuMuonTras_MaDocGia",
                table: "PhieuMuonTra",
                newName: "IX_PhieuMuonTra_MaDocGia");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuonTras_MaSach",
                table: "ChiTietPhieuMuonTra",
                newName: "IX_ChiTietPhieuMuonTra_MaSach");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuonTras_MaPhieuMuonTra",
                table: "ChiTietPhieuMuonTra",
                newName: "IX_ChiTietPhieuMuonTra_MaPhieuMuonTra");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaiKhoan",
                table: "TaiKhoan",
                column: "UserName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuPhat",
                table: "PhieuPhat",
                column: "MaPhieuPhat");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuMuonTra",
                table: "PhieuMuonTra",
                column: "MaPhieuMuonTra");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocGia",
                table: "DocGia",
                column: "MaDocGia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuMuonTra",
                table: "ChiTietPhieuMuonTra",
                column: "MaChiTietPhieuMuon");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuonTra_PhieuMuonTra_MaPhieuMuonTra",
                table: "ChiTietPhieuMuonTra",
                column: "MaPhieuMuonTra",
                principalTable: "PhieuMuonTra",
                principalColumn: "MaPhieuMuonTra",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuonTra_Saches_MaSach",
                table: "ChiTietPhieuMuonTra",
                column: "MaSach",
                principalTable: "Saches",
                principalColumn: "MaSach",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuMuonTra_DocGia_MaDocGia",
                table: "PhieuMuonTra",
                column: "MaDocGia",
                principalTable: "DocGia",
                principalColumn: "MaDocGia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuPhat_DocGia_MaDocGia",
                table: "PhieuPhat",
                column: "MaDocGia",
                principalTable: "DocGia",
                principalColumn: "MaDocGia",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

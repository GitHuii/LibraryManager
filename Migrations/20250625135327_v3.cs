using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManager.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaTra",
                table: "ChiTietPhieuMuonTras");

            migrationBuilder.DropColumn(
                name: "NgayTraThucTe",
                table: "ChiTietPhieuMuonTras");

            migrationBuilder.AddColumn<bool>(
                name: "DaTra",
                table: "PhieuMuonTras",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTraThucTe",
                table: "PhieuMuonTras",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaTra",
                table: "PhieuMuonTras");

            migrationBuilder.DropColumn(
                name: "NgayTraThucTe",
                table: "PhieuMuonTras");

            migrationBuilder.AddColumn<bool>(
                name: "DaTra",
                table: "ChiTietPhieuMuonTras",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTraThucTe",
                table: "ChiTietPhieuMuonTras",
                type: "datetime2",
                nullable: true);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "khoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "monHocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenmh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoGio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_monHocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "giangViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChuyenNganh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaKhoa = table.Column<int>(type: "int", nullable: false),
                    KhoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giangViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_giangViens_khoas_KhoaId",
                        column: x => x.KhoaId,
                        principalTable: "khoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lops_khoas_KhoaId",
                        column: x => x.KhoaId,
                        principalTable: "khoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sinhViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSinhVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioiTinh = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Malop = table.Column<int>(type: "int", nullable: false),
                    LopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sinhViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sinhViens_lops_LopId",
                        column: x => x.LopId,
                        principalTable: "lops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "diemThis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSinhVien = table.Column<int>(type: "int", nullable: false),
                    SinhVienId = table.Column<int>(type: "int", nullable: false),
                    Mamh = table.Column<int>(type: "int", nullable: false),
                    MonHocId = table.Column<int>(type: "int", nullable: false),
                    LanThi = table.Column<int>(type: "int", nullable: false),
                    Diemthi = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diemThis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_diemThis_monHocs_MonHocId",
                        column: x => x.MonHocId,
                        principalTable: "monHocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_diemThis_sinhViens_SinhVienId",
                        column: x => x.SinhVienId,
                        principalTable: "sinhViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_diemThis_MonHocId",
                table: "diemThis",
                column: "MonHocId");

            migrationBuilder.CreateIndex(
                name: "IX_diemThis_SinhVienId",
                table: "diemThis",
                column: "SinhVienId");

            migrationBuilder.CreateIndex(
                name: "IX_giangViens_KhoaId",
                table: "giangViens",
                column: "KhoaId");

            migrationBuilder.CreateIndex(
                name: "IX_lops_KhoaId",
                table: "lops",
                column: "KhoaId");

            migrationBuilder.CreateIndex(
                name: "IX_sinhViens_LopId",
                table: "sinhViens",
                column: "LopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "diemThis");

            migrationBuilder.DropTable(
                name: "giangViens");

            migrationBuilder.DropTable(
                name: "monHocs");

            migrationBuilder.DropTable(
                name: "sinhViens");

            migrationBuilder.DropTable(
                name: "lops");

            migrationBuilder.DropTable(
                name: "khoas");
        }
    }
}

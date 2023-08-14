using Design.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.DataX
{
    public class appDbcontext : DbContext
    {
        public DbSet<DiemThi> diemThis { get; set; }
        public DbSet<GiangVien> giangViens { get; set; }
        public DbSet<Khoa> khoas { get; set; }
        public DbSet<Lop> lops { get; set; }
        public DbSet<SinhVien> sinhViens { get; set; }
        public DbSet<MonHoc> monHocs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server = DESKTOP-F49D6LP; database = QuanLysinhVienProject; trusted_Connection = true;TrustServerCertificate=True;");
        }
    }
}

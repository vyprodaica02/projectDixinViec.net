using Design.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Entity
{
    public class DiemThi : BaseEntity
    {
        public int MaSinhVien { get; set; }
        public SinhVien SinhVien { get; set; }
        public int Mamh { get ; set; }
        public MonHoc MonHoc { get; set; }
        public int LanThi { get; set; }
        public float Diemthi { get; set; }

    }
}

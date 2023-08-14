using Design.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Entity
{
    public class SinhVien : BaseEntity
    {
        public string TenSinhVien { get; set; }
        public int gioiTinh { get; set; }   
        public DateTime NgaySinh { get; set; }
        public int Malop { get; set; }
        public Lop Lop { get; set; }
    }
}

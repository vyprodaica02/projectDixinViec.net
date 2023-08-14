using Design.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Entity
{
    public class GiangVien : BaseEntity
    {
        public string TenGv { get; set; }
        public string ChuyenNganh { get; set; }
        public int MaKhoa { get; set; } 
        public Khoa Khoa { get; set; }
    }
}

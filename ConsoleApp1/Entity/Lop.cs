using Design.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Entity
{
    public class Lop : BaseEntity
    {
        public string TenLop { get; set; }
        public string MaKhoa { get; set; }
        public Khoa Khoa { get; set;}
    }
}

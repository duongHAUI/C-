using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTapPart2
{
    class ThiSinh
    {
        public string sbd { get; set; }
        public string Hoten { get; set; }
        public float diemToan { get; set; }
        public float diemLy { get; set; }
        public float diemHoa { get; set; }

        public ThiSinh() { }
        public ThiSinh(string sbd,string Hoten,float diemToan,float diemLy,float diemHoa)
        {
            this.sbd = sbd;
            this.Hoten = Hoten;
            this.diemHoa = diemHoa;
            this.diemLy = diemLy;
            this.diemToan = diemToan;
        }

        public virtual float Tongdiem()
        {
            return diemToan + diemLy + diemHoa;
        }
        public virtual string XetTuyen(float diemSan)
        {
            if (Tongdiem() >= diemSan) return "Thi Do";
            else return "Thi Truot";
        }
    }
}

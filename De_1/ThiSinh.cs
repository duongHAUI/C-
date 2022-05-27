using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_1
{
    class ThiSinh
    {
        public string sbd { get; set; }
        public string hoten { get; set; }
        public float diemtoan  { get; set; }
        public float diemly { get; set; }
        public float diemhoa { get; set; }

        public ThiSinh() { }
        public ThiSinh(string sbd,string hoten,float diemtoan,float diemly,float diemhoa)
        {
            this.sbd = sbd;
            this.hoten = hoten;
            this.diemtoan = diemtoan;
            this.diemly = diemly;
            this.diemhoa = diemhoa;
        }
        public virtual float TongDiem()
        {
            return diemtoan + diemly + diemhoa;
        }
        public string XetTuyen(float diemsan)
        {
            if (TongDiem() >= diemsan)
                return "Thi đỗ";
            else
                return "Thi trượt";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_1
{
    class ThiSinhUT : ThiSinh
    {
        public int khuvuc { get; set; }
        public float diemuutien { 
            get
            {
                if (khuvuc == 2)
                    return (float)0.5;
                else if (khuvuc == 3)
                    return 1;
                else
                    return 0;
            }
        }

        public  void NhapThongTin()
        {
            Console.Write("Nhập sbd : ");
            sbd = Console.ReadLine();
            Console.Write("Nhập họ tên : ");
            hoten = Console.ReadLine();
            Console.Write("Nhap điểm toán : ");
            diemtoan = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm lý : ");
            diemly = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm hóa : ");
            diemhoa = float.Parse(Console.ReadLine());
            Console.Write("Nhập khu vực : ");
            khuvuc = int.Parse(Console.ReadLine());
        }
        public void HienThi()
        {
            Console.WriteLine("{0,-10}{1,-15}{2,10}{3,10}{4,10}{5,15}{6,15}{7,15}", sbd,hoten,diemtoan,diemly,diemhoa,khuvuc,diemuutien,TongDiem());
        }
        public static void TieuDe()
        {
            Console.WriteLine("{0,-10}{1,-15}{2,10}{3,10}{4,10}{5,15}{6,15}{7,15}", "sbd", "hoten", "diemtoan", "diemly", "diemhoa", "khuvuc", "diemuutien","tong diem");
        }
        public override float TongDiem()
        {
            return base.TongDiem() + diemuutien;
        }

    }
    class ThiSinhUTTongDiemComparer : IComparer<ThiSinhUT>
    {
        public int Compare(ThiSinhUT a,ThiSinhUT b)
        {
            return a.TongDiem().CompareTo(b.TongDiem());
        }
    }
}

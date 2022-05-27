using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTapPart2
{
    class ThiSinhUT : ThiSinh, IComparable<ThiSinhUT>
    {
        public int KhuVuc { get; set; }
        public float diemUT
        {
            get
            {
                if(KhuVuc == 2)
                {
                    return 1;
                }else if(KhuVuc == 1)
                {
                    return 0.5f;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int CompareTo(ThiSinhUT other)
        {
            return other.Tongdiem().CompareTo(this.Tongdiem());
        }

        public void input()
        {
            Console.WriteLine("Nhap so bao danh: ");
            sbd = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: ");
            Hoten = Console.ReadLine();
            Console.WriteLine("Nhap diem ");
            Console.WriteLine("\t\t Toan: "); diemToan = float.Parse(Console.ReadLine());
            Console.WriteLine("\t\t Ly: "); diemLy = float.Parse(Console.ReadLine());
            Console.WriteLine("\t\t Hoa: "); diemHoa = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap khu vuc : ");
            KhuVuc = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("{0,-8}{1,-15}{2,-8}{3,8}{4,8}{5,10}{6,10}{7,10}", sbd, Hoten, diemToan, diemLy, diemHoa, KhuVuc,diemUT,Tongdiem());
        }
        public override float Tongdiem()
        {
            return base.Tongdiem() + diemUT;
        }
    }
}

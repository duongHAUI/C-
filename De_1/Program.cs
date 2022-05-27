using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_1
{
    class Program
    {
        static List<ThiSinhUT> li = new List<ThiSinhUT>();
        static void Main(string[] args)
        {
            int luachon;
            while (true)
            {
                Console.WriteLine("1. Nhập thêm thông tin 1 thí sinh từ màn hình vào Danh sách thí sinh!");
                Console.WriteLine("2. Hiển thị thông tin toàn bộ các thí sinh trong Danh sách theo thứ tự đã nhập.");
                Console.WriteLine("3. Hiển thị thông tin toàn bộ các thí sinh trong Danh sách có sắp xếp theo Tổng điểm thi ");
                Console.WriteLine("4. Nhập vào Điểm sàn từ bàn phím và trả ra danh sách các thí sinh đã “Thi đỗ”.");
                Console.WriteLine("5. Nhập vào Khu vực ưu tiên, hiển thị danh sách các thí sinh có cùng khu vực ưu tiên đã nhập.");
                Console.WriteLine("6. Tìm kiếm và hiển thị thông tin thí sinh theo số báo danh nhập từ bàn phím.");
                Console.WriteLine("7. Nhập vào thông tin số báo danh, xóa thí sinh đó khỏi danh sách.");
                Console.WriteLine("8. Kết thúc chương trình.");
                Console.Write("Nhap lua chon : ");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        {
                            NhapThiSinhUT();
                            break;
                        }
                    case 2:
                        {
                            HienThiThiSinhUT();
                            break;
                        }
                    case 3:
                        {
                            SXTongDiemTHi();
                            break;
                        }
                    case 4:
                        {
                            DSThiDo();
                            break;
                        }
                    case 5:
                        {
                            KVUT();
                            break;
                        }
                    case 6:
                        {
                            TSTheoSBD();
                            break;
                        }
                    case 7:
                        {
                            Xoa();
                            break;
                        }
                    case 8:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Lựa chọn không hợp lệ!");
                            break;
                        }
                        
                }
            }
        }
        public static void NhapThiSinhUT()
        {
            ThiSinhUT ts = new ThiSinhUT();
            ts.NhapThongTin();
            li.Add(ts);
        }
        public static void HienThiThiSinhUT()
        {
            ThiSinhUT.TieuDe();
            li.ForEach(item => item.HienThi());
        }
        public static void SXTongDiemTHi()
        {
            li.Sort((a,b)=>
            {
                return (int)(a.TongDiem() - b.TongDiem());
            });
        }
        public static void DSThiDo()
        {
            Console.WriteLine("Nhap diem san : ");
            float ds = float.Parse(Console.ReadLine());
            foreach (var item in li)
            {
                if(item.XetTuyen(ds).Equals("Thi đỗ"))
                {
                    item.HienThi();
                }
            }
        }
        public static void KVUT()
        {
            Console.WriteLine("Nhap khu vuc : ");
            int kv = int.Parse(Console.ReadLine());
            foreach (var item in li)
            {
                if (item.khuvuc == kv)
                {
                    item.HienThi();
                }
            }
        }
        public static void TSTheoSBD()
        {
            Console.WriteLine("Nhap sbd : ");
            string sbd = Console.ReadLine();
            foreach(var item in li)
            {
                if (item.sbd.Equals(sbd))
                {
                    item.HienThi();
                }
            }
        }
        public static void Xoa()
        {
            Console.WriteLine("Nhap sbd : ");
            string sbd = Console.ReadLine();
            foreach (var item in li)
            {
                if (item.sbd.Equals(sbd))
                {
                    li.RemoveAt(li.BinarySearch(item));
                }
            }
        }
    }
}
